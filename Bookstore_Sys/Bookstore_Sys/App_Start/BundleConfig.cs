using System.Web;
using System.Web.Optimization;

namespace Bookstore_Sys
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            //Add CDN to icons
            bundles.UseCdn = true;
            //add Css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //add link to jquery on the CDN
            var cssCdnPath = "https://cdn-uicons.flaticon.com/uicons-regular-straight/css/uicons-regular-straight.css";
            //Add 
            bundles.Add(new StyleBundle("~/bundles/css", cssCdnPath).Include(
                      "~/css/uicons-regular-straight.css"));
        }

    }
}
