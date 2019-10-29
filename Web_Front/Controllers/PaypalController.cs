﻿using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_DomainClasses.Entities.School;
using Web_Front.Models.Paypal;
using Web_Services.ApiMapping;

namespace Web_Front.Controllers
{
    public class PayPalController : MasterController

    {
        PaintingApiService ServicePainting = new PaintingApiService();
        // GET: PayPal
        public ActionResult Index()
        {
            List<Item> CartList = Session["CartList"] as List<Item>;
            return View("Index", CartList);
        }


        public ActionResult AddToCart(int PaintingID)
        {
            //List<Item> CartList = Session["CartList"] as List<Item>;
            List<Item> CartList = Session["CartList"] as List<Item>;

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
                sku = "sku"
            };
            CartList.Add(item);
            Session["CartList"] = CartList;
            return View("Index", CartList);
        }

        public ActionResult PayPalPayment()
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
                    if (itemList.items==null)
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

            //Empty Session Storage From Cart Items On Success Payment
            Session["CartList"] = null;
            //on successful payment, show success page to user.
            return View("SuccessView");
        }
    }
}