using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Services.ApiMapping.Sales;
using Web_Services.ApiMapping;
using Web_DomainClasses.Entities.School;

namespace Web_Services.ChartData
{
    public class ChartDataService
    {
        private SaleApiService ServiceSaleApi = new SaleApiService();
        private PaintingApiService ServicePaintingApi = new PaintingApiService();


        /////////////////////////////////////////////////// 
        ///                                             ///
        ///              Full - Properties              ///
        ///                                             ///
        ///////////////////////////////////////////////////

        public int TotalOrders { get { return GetTotalOrders(); } }
        public double TotalMoneyCollected { get { return GetTotalMoneyCollected(); } }
        public int TotalPaintingsSold { get { return GetTotalPaintingsSold(); } }
        public Painting FirstSellingPaint { get { return GetFirstSellingPaint(); } }



        /////////////////////////////////////////////////// 
        ///                                             ///
        ///              Private functions              ///
        ///                                             ///
        ///////////////////////////////////////////////////

        private int GetTotalOrders()
        {

            return ServiceSaleApi.GetSales().Count();
        }

        private double GetTotalMoneyCollected()
        {
            //LINQ Purpose: Get list of sales ,find the purchased paintingid's , use id to find painting price, multiply by the quantity



            return ServiceSaleApi                                       //Custom service for sales
              .GetSales()                                               //Use this function to get all sales from api
              .Select(a => a.purchacedItems)                            //Select the list of purchasedItems (contains paintid,quantity)
              .Select(b =>                                              //Every object in list
                  ServicePaintingApi                                    //Custom service for paintings
                    .GetPainting(b                                      //Get 1 painting from api based on id
                        .Select(c => c.PurchasedPaintingId)             //Select the paint id from current sale
                            .First())                                   //Get the first painting object
                                .Price * b.Select(z => z.Quantity)      //Multiply the price with quantity
                                    .First())                           //Get the first quantity prop , return a list of cost per product
              .Sum();                                                   //Get the sum of that list and return it
        }



        private int GetTotalPaintingsSold()
        {
            //LINQ Purpose: Get list of sales ,find the purchased paintings quantity, find sum


            return ServiceSaleApi
              .GetSales()
              .Select(a => a.purchacedItems)
              .Select(b => b.Select(c => c.Quantity).First())
              .Sum();
        }





        private Painting GetFirstSellingPaint()
        {
            //LINQ Purpose:
            //var aa = ServicePaintingApi
            //           .GetPaintings()
            //           .GroupBy(a => a.PaintingTitle)
            //           .Select(b => b.First())
            //           .ToList()
            //        .Where(c => c.PaintingId== ServiceSaleApi
            //                        .GetSales()
            //                        .Select(d => d.purchacedItems)
            //                        .Select(e=>e.)
            //                        )





            //ServiceSaleApi
            // .GetSales()
            // .Select(a => a.purchacedItems)
            // .Select(b => new
            // {
            //     paintList = ServicePaintingApi
            //                    .GetPaintings()
            //                    .GroupBy(d => d.PaintingTitle)
            //                    .Select(e => e.First())
            //                    .ToList(),
            //    quantity= b.Select(x=>x.q),
            //    paint
            // })

            // .Select(f => f.Quantity += a.)
            // ;







            return new Painting() { };
        }


        //private Painting GetFirstSellingPaint222222()
        //{
        //    //LINQ Purpose:
        //    ServiceSaleApi                                             //Custom service for sales
        //     .GetSales()                                               //Use this function to get all sales from api
        //     .Select(a => a.purchacedItems)                            //Select the list of purchasedItems (contains paintid,quantity)
        //     .Select(b =>                                              //Every object in list
        //         ServicePaintingApi                                    //Custom service for paintings
        //           .GetPainting(b                                      //Get 1 painting from api based on id
        //               .Select(c => c.PurchasedPaintingId)             //Select the paint id from current sale
        //                   .First())                                   //Get the first painting object
        //                       .Price * b.Select(z => z.Quantity)      //Multiply the price with quantity
        //                           .First())                           //Get the first quantity prop , return a list of cost per product                                           
        //     .Max();                                                   //Get the sum of that list and return it



        //    return new Painting() { };
        //}

    }
}
