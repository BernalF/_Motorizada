using System.Web;
using System.Web.Optimization;

namespace StoreLite
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapJS").Include("~/Scripts/bootstrap.*", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/bootstrapCSS")
                .Include("~/Content/bootstrap.css", new CssRewriteUrlTransform())
                .Include("~/Content/bootstrap-responsive.css", new CssRewriteUrlTransform()));

            BundleTable.EnableOptimizations = true;
        }
    }
}