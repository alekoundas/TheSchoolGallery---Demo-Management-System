using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using Web_DomainClasses.Entities.School;
using Web_Front.Models;
using Web_Front.Models.Paypal;
using Web_Services.ApiMapping;
namespace Web_Front.Controllers
{
    public class PayPalController : MasterController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        PaintingApiService ServicePainting = new PaintingApiService();


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
            };
            if (CartList.Any(x => x.name == item.name && x.price == item.price))
            {
                Debug.WriteLine("");
            }
            CartList.Add(item);
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
            Session["UserId"] = UserId;
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
                        subtotal = itemList.items.Select(x => int.Parse(x.price)).Sum().ToString()
                    };

                    var amount = new Amount()
                    {
                        currency = "USD",
                        total = itemList.items.Select(x => int.Parse(x.price)).Sum().ToString(), // Total must be equal to sum of shipping, tax and subtotal.
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
            SendEmail(user.Email);

            //Empty Session Storage From Cart Items On Success Payment
            Session["CartList"] = null;

            //on successful payment, show success page to user.
            return View("Index");
        }


        public static void SendEmail(string RecieverEmail)
        {
            EmailBusiness ServiceMail = new EmailBusiness();
            ServiceMail.to = new MailAddress(RecieverEmail, "Administrator");
            ServiceMail.body = "ppppppppppppp";
            ServiceMail.ToAdmin();
        }
    }
    public class EmailBusiness
    {
        public MailAddress to { get; set; }
        public MailAddress from { get; set; }
        public string sub { get; set; }
        public string body { get; set; }

        //Constructor
        public EmailBusiness()
        {
            from = new MailAddress("GallerySchoolDonationSite@hotmail.com");
            sub = "Donation To Schools";
        }


        public void ToAdmin()
        {
            EmailBusiness me = new EmailBusiness();

            MailMessage Mail = new MailMessage() { Subject = sub, Body = body, IsBodyHtml = true };
            Mail.To.Add(to);
            Mail.From = new MailAddress(from.ToString());
            Mail.Sender = to;


            SmtpClient smtp = new SmtpClient
            {
                Host = "pod51014.outlook.com",
                Port = 587,
                Credentials = new NetworkCredential("GallerySchoolDonationSite@hotmail.com", "1Gallery2School3Donation4Site5"),
                EnableSsl = true
            };

            smtp.Send(Mail);
        }
    }
}