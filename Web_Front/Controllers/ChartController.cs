using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_DomainClasses.ViewModels;
using Web_Services.ChartData;

namespace Web_Front.Controllers
{
    public class ChartController : Controller
    {
        ChartDataService ServiceChartData = new ChartDataService();
        // GET: Chart
        public ActionResult Index()
        {
            ChartDataVM view_model = new ChartDataVM();

            view_model.TotalOrders = ServiceChartData.TotalOrders;
            view_model.TotalMoneyCollected = ServiceChartData.TotalMoneyCollected;
            view_model.TotalPaintingsSold = ServiceChartData.TotalPaintingsSold;
            /*view_model.FirstSellingPaint =*/var a = ServiceChartData.FirstSellingPaint;
            return View(view_model);
        }
    }
}