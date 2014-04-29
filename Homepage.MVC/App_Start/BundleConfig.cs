using System.Web;
using System.Web.Optimization;

namespace Homepage.MVC
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            bundles.Add(new StyleBundle("~/stylesheets/bootstrap").Include(
                "~/Css/bootstrap.min.css",
                "~/Css/landing-page.css",
                "~/Content/Fonts/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/stylesheets/carousel").Include(
                "~/Css/owl.carousel.css",
                "~/Css/owl.theme.css"));

            bundles.Add(new ScriptBundle("~/scripts/bootstrap").Include(
                       "~/Scripts/JS/dropdown.js",
                       "~/Scripts/JS/jquery-1.10.2.min.js",
                       "~/Scripts/JS/anchor.js",
                       "~/Scripts/JS/collapse.js"));

            bundles.Add(new ScriptBundle("~/scripts/carousel").Include(
           "~/Scripts/JS/owl.carousel.min.js"));

        }
    }
}