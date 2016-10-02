using System.Web;
using System.Web.Optimization;

namespace NC.MCJ.WebApi
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                        "~/Areas/Help/Document/dist/js/jquery.js",
                        "~/Areas/Help/Document/dist/js/bootstrap.js",
                        "~/Areas/Help/Document/dist/js/customer.js"));

            bundles.Add(new ScriptBundle("~/bundles/Jformat").Include(
                "~/Areas/Help/Document/dist/plugs/json.formater/json.formater.js"));
            bundles.Add(new StyleBundle("~/Content/Jformat/").Include(
                "~/Areas/Help/Document/dist/plugs/json.formater/json.formater.css"));

            bundles.Add(new StyleBundle("~/bundles/style/").Include(
                "~/Areas/Help/Document/dist/css/bootstrap.css",
                "~/Areas/Help/Document/dist/css/css.css"));
        }
    }
}