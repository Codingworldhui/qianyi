using System.Web;
using System.Web.Optimization;

namespace qianyi
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
    "~/Content/1.0.css"));

            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Scripts/1.0.js"));

        }
    }
}
