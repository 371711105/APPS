using System.Web;
using System.Web.Optimization;

namespace Apps
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/tree/css/tree.css"));

            bundles.Add(new ScriptBundle("~/bundles/easyui").Include(
                       "~/Scripts/jquery.easyui-1.4.5.js",
                        "~/Scripts/locale/easyui-lang-zh_CN.js",
                       "~/Scripts/jquery.easyui.plus.js"));

            //jquery plus
            bundles.Add(new ScriptBundle("~/bundles/jquery/plus").Include(
                       "~/Scripts/jquery.form.js",
                       "~/Scripts/jquery.validate.js",
                       "~/Scripts/jquery.validate.unobtrusive.js",
                       "~/Scripts/jquery.unobtrusive-ajax.js",
                       "~/Scripts/jquery.tree.js"));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                       "~/Scripts/admin-page/home.js"));

            //easyui
            bundles.Add(new StyleBundle("~/Content/themes/black/css").Include("~/Content/themes/black/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/bootstrap/css").Include("~/Content/themes/bootstrap/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/default/css").Include("~/Content/themes/default/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/gray/css").Include("~/Content/themes/gray/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/material/css").Include("~/Content/themes/material/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/metro/css").Include("~/Content/themes/metro/easyui.css"));


        }
    }
}
