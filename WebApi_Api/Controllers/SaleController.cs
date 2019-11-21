using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi_Database;
using WebApi_Entities.Sales;
using WebApi_Services;

namespace WebApi_Api.Controllers
{
    public class SaleController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();



        /////////////////////////////////////////////////////////////////////////////////////
        ///                                                                               ///
        ///                             Sale                                              ///
        ///                                                                               ///
        ///////////////////////////////////////////////////////////////////////////////////// 
        // GET: api/Sale
        public IQueryable<Sale> GetSales()
        {
            IQueryable<Sale> sales = db.SaleDb.Include(x => x.purchacedItems);

            return sales;
        }

        // GET: api/Sale/5
        [ResponseType(typeof(Sale))]
        public IHttpActionResult GetSale(int id)
        {
            IQueryable<Sale> sale = db.SaleDb
                .Where(w => w.SaleId == id)
                .Include(x => x.purchacedItems);

            

            if (sale == null)
            {
                return NotFound();
            }           
            return Ok(sale);
        }

        // POST: api/Sale
        [ResponseType(typeof(Sale))]
        public IHttpActionResult PostSale(Sale sale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           
            db.SaleDb.Add(sale);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sale.SaleId }, sale);
        }





        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}












