using System.Web;
using System.Web.Optimization;

namespace Web_Front
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //// CUSTOM SCRIPT COLLECTIONS 1 -------------------->>
            //bundles.Add(new ScriptBundle("~/bundles/Skriptakia").Include(
            //          "~/js/vendor/bootstrap.min.js",
            //          "~/js/jquery.ajaxchimp.min.js",
            //          "~/js/owl.carousel.min.js",
            //          "~/js/jquery.nice-select.min.js",
            //          "~/js/jquery.magnific-popup.min.js",
            //          "~/js/jquery.counterup.min.js",
            //          "~/js/waypoints.min.js",
            //          "~/js/main.js"
            //          ));

            //// CUSTOM STYLE COLLECTIONS  -------------------->>
            //bundles.Add(new ScriptBundle("~/bundles/Stylakia").Include(
            //          "~/css/linearicons.css",
            //          "~/css/owl.carousel.css",
            //          "~/css/font-awesome.min.css",
            //          "~/css/nice-select.css",
            //          "~/css/magnific-popup.css",
            //          "~/css/bootstrap.css",
            //          "~/css/main.css"
            //          ));

        }
    }
}
