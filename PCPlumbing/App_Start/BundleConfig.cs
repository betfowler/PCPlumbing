﻿using System.Web;
using System.Web.Optimization;

namespace PCPlumbing
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/JavaScript.js",
                      "~/Scripts/gallery.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/fancybox").Include(
                    "~/Scripts/FancyBox/jquery.fancybox-init.js",
                    "~/Scripts/FancyBox/jquery.fancybox.pack.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/Info.css",
                      "~/Content/Index.css",
                      "~/Content/Site.css"

                      ));
        }
    }
}
