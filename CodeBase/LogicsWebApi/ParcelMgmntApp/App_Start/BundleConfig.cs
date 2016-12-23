using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ParcelMgmntApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //    "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //    "~/Scripts/jquery.validate.js",
            //    "~/Scripts/jquery.validate.unobtrusive.js"
            //    ));
            var bund = new StyleBundle("~/Content/themes/base").Include(
    "~/Content/themes/base/minified/jquery.ui.core.min.css",
    "~/Content/themes/base/minified/jquery.ui.resizable.min.css",
    "~/Content/themes/base/minified/jquery.ui.selectable.min.css",
    "~/Content/themes/base/minified/jquery.ui.accordion.min.css",
    "~/Content/themes/base/minified/jquery.ui.autocomplete.min.css",
    "~/Content/themes/base/minified/jquery.ui.button.min.css",
    "~/Content/themes/base/minified/jquery.ui.dialog.min.css",
    "~/Content/themes/base/minified/jquery.ui.slider.min.css",
    "~/Content/themes/base/minified/jquery.ui.tabs.min.css",
    "~/Content/themes/base/minified/jquery.ui.datepicker.min.css",
    "~/Content/themes/base/minified/jquery.ui.progressbar.min.css",
    "~/Content/themes/base/minified/jquery.ui.theme.min.css",
    "~/Content/themes/base/minified/jquery.ui.spinner.min.css",
    "~/Content/themes/base/minified/jquery.ui.menu.min.css",
    "~/Content/themes/base/minified/jquery.ui.tooltip.min.css"
    );

            bundles.Add(bund);

#if DEBUG

            BundleTable.EnableOptimizations = false;
#else
        BundleTable.EnableOptimizations = true;
#endif
         }
       }
    }