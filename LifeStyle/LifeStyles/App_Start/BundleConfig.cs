using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace LifeStyles
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundle)
        {

            //       < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/bootstrap.min.css' rel = "stylesheet" type = "text/css" />

            //< link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/fonts/css/font-awesome.min.css' rel = "stylesheet" type = "text/css" />

            //     < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/animate.min.css' rel = "stylesheet" type = "text/css" />

            //          < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/custom.css' rel = "stylesheet" type = "text/css" />

            //               < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/icheck/flat/green.css' rel = "stylesheet" type = "text/css" />

            //                    < !--Custom styling plus plugins-- >

            //                    < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/editor/external/google-code-prettify/prettify.css' rel = "stylesheet" type = "text/css" />

            //                         < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/editor/index.css' rel = "stylesheet" type = "text/css" />

            //                              < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/select/select2.min.css' rel = "stylesheet" type = "text/css" />

            //                                   < link href = '@System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString()Layout/css/switchery/switchery.min.css' rel = "stylesheet" type = "text/css" />
            //                                               \


            bundle.Add(new StyleBundle("~/content/css").Include("~/Content/css/bootstrap.min.css", "~/Content/css/slick.css",
                "~/Content/slick-theme.css", "~/Content/css/nouislider.min.css",
                "~/Content/css/font-awesome.min.css", "~/Content/css/style.css", "~/Layout/animate.min.css"));

            bundle.Add(new ScriptBundle("~/content/js").Include("~/Content/js/jquery.min.js",
                "~/Content/js/bootstrap.min.js", "~/Content/js/slick.min.js",
                "~/Content/js/nouislider.min.js", "~/Content/js/jquery.zoom.min.js", "~/Content/js/main.js"));
            //bundle.Add(new StyleBundle("~/content/bootstrap").Include("~/ Content / css / bootstrap.min.css"));
            bundle.Add(new StyleBundle("~/content/bootstrap").Include("~/Content/css/bootstrap.min.css"));
        }
    }
}