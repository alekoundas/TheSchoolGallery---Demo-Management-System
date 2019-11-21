using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Web.Mvc;
using Web_DomainClasses.Entities.School;
using Web_DomainClasses.Entities.Sales;
using Web_Front.Models;
using Web_Front.Models.Paypal;
using Web_Services.ApiMapping;
using Web_Services.ApiMapping.Sales;
using Web_Services.Mail;

namespace Web_Front.Controllers
{
    public class PayPalController : MasterController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        PaintingApiService ServicePainting = new PaintingApiService();
        SaleApiService ServiceSale = new SaleApiService();


        // GET: PayPal
        public ActionResult Index()
        {

            List<Item> CartList = Session["CartList"] as List<Item>;
            return View("Index", CartList);
        }

        // GET: PayPal/AddToCart/

        public ActionResult AddToCart(int PaintingID)
        {
            List<Item> CartList = Session["CartList"] as List<Item>;


            //Check if Session Was Empty
            if (CartList == null)
            {
                CartList = new List<Item>();
            }
            Painting painting = ServicePainting.GetPainting(PaintingID);
            Item item = new Item()
            {
                name = painting.PaintingTitle.ToString(),
                currency = "USD",
                price = painting.Price.ToString(),
                quantity = "1",
                sku = "sku",
                description = painting.PaintingId.ToString()
            };
            AddOrUpdateCart(CartList, item);

            Session["CartList"] = CartList;
            return View("Index", CartList);
        }



        public ActionResult ClearCart()
        {
            Session["CartList"] = null;
            return View("Index", new List<Item>());
        }

        public ActionResult PayPalPayment(string UserId)
        {

            try
            {
                var apiContext = PaypalConfiguration.GetAPIContext();
                string payerId = Request.Params["PayerID"];
                if (string.IsNullOrEmpty(payerId))
                {
                    //Get Items From Session Storage
                    var itemList = new ItemList()
                    {
                        items = Session["CartList"] as List<Item>
                    };

                    //Return To Cart If He Doest Have Anything In Cart
                    if (itemList.items == null)
                    {
                        return View("Index");
                    }


                    var payer = new Payer() { payment_method = "paypal" };

                    var baseURI = Request.Url.Scheme + "://" + Request.Url.Authority + "/PayPal/PayPalPayment?";
                    var guid = Convert.ToString((new Random()).Next(100000));
                    var redirectUrl = baseURI + "guid=" + guid;
                    var redirUrls = new RedirectUrls()
                    {
                        cancel_url = redirectUrl + "&cancel=true",
                        return_url = redirectUrl
                    };

                    var details = new Details()
                    {
                        tax = "0",
                        shipping = "0",
                        subtotal = itemList.items.Select(x => int.Parse(x.price) * int.Parse(x.quantity)).Sum().ToString()// Based on item prices by quantities
                    };

                    var amount = new Amount()
                    {
                        currency = "USD",
                        total = itemList.items.Select(x => int.Parse(x.price) * int.Parse(x.quantity)).Sum().ToString(), // Total must be equal to sum of shipping, tax and subtotal.
                        details = details
                    };

                    var transactionList = new List<Transaction>();
                    transactionList.Add(new Transaction()
                    {
                        description = "Transaction description.",
                        invoice_number = PaypalCommonTools.GetRandomInvoiceNumber(),
                        amount = amount,
                        item_list = itemList
                    });

                    var payment = new Payment()
                    {
                        intent = "sale",
                        payer = payer,
                        transactions = transactionList,
                        redirect_urls = redirUrls
                    };
                    var createdPayment = payment.Create(apiContext);
                    var links = createdPayment.links.GetEnumerator();

                    string paypalRedirectUrl = null;

                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;

                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            //saving the payapalredirect URL to which user will be redirected for payment
                            paypalRedirectUrl = lnk.href;
                        }
                    }

                    // saving the paymentID in the key guid
                    Session.Add(guid, createdPayment.id);
                    Session.Add("UserId", UserId);

                    return Redirect(paypalRedirectUrl);
                }
                else
                {

                    // This function exectues after receving all parameters for the payment

                    var guid = Request.Params["guid"];
                    var paymentId = Session[guid] as string;
                    var paymentExecution = new PaymentExecution() { payer_id = payerId };
                    var payment = new Payment() { id = paymentId };

                    var executedPayment = payment.Execute(apiContext, paymentExecution);

                    //If executed payment failed then we will show payment failure message to user
                    if (executedPayment.state.ToLower() != "approved")
                    {
                        return View("FailureView");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                return View("FailureView");
            }



            //Get Email Of Logged in User
            string userid = Session["UserId"] as string;
            var user = db.Users.Where(x => x.Id == userid).FirstOrDefault();

            //Send Email With Painting On Success Payment to User Email
            //Get ids from decription and give them as a list of strings
            List<Item> CartList = Session["CartList"] as List<Item>;
            SendEmail(user.Email, CartList.Select(x => x.description).ToList());
           
            //Will use method below to return a sale and then the ServiceSale 
            //will send this obj to WebApi project
            ServiceSale.CreateSale(CreateSaleObj(CartList));








            //Empty Session Storage From Cart Items On Success Payment
            Session["CartList"] = null;

            //on successful payment, show success page to user.
            return View("Index");
        }

        /// <summary>
        /// Will create and send automated email based on users email and
        /// selection of paintngs.This will be executed after successful purchase
        /// </summary>
        /// <param name="recieverEmail"></param>
        /// <param name="paintingIDs"></param>
        public static void SendEmail(string recieverEmail, List<string> paintingIDs)
        {
            CustomEmailService mail = new CustomEmailService();

            mail.to = new MailAddress(recieverEmail);
            mail.CreateAttachments(paintingIDs);
            mail.SendMail();
        }





        /// <summary>
        /// Checks if the cart has the same item.If true it increases existing item quantity by 1
        /// else adds the new item to list
        /// </summary>
        /// <param name="CartList"></param>
        /// <param name="item"></param>
        private static void AddOrUpdateCart(List<Item> CartList, Item item)
        {
            if (CartList.Any(x => x.name == item.name && x.price == item.price))
            {
                string current_quantity = CartList.Where(x => x.name == item.name && x.price == item.price).FirstOrDefault().quantity;
                int new_quantity = Int32.Parse(current_quantity) + 1;
                CartList.Where(x => x.name == item.name && x.price == item.price).FirstOrDefault().quantity = new_quantity.ToString();
            }
            else
            {
                CartList.Add(item);
            }
        }





        private static Web_DomainClasses.Entities.Sales.Sale  CreateSaleObj(List<Item> cartList)
        {
            //Purpose of Linq: Create a list of PurchasedItem objects ,based on users painting selection
           List<PurchacedItem> purchases =  cartList
                .Select(a => new PurchacedItem                          //Create Obj
                { 
                    PurchasedPaintingId = Int32.Parse(a.description)    //Add the
                    ,Quantity = Int32.Parse(a.quantity)                 //properties
                })
                .ToList();                                              //Return it as a list

            return new Web_DomainClasses.Entities.Sales.Sale() { purchacedItems =  purchases };
            

        }

    }
}