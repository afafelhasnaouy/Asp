using System.Web;
using System.Web.Optimization;

namespace PlateformeConcours
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

			bundles.Add(new ScriptBundle("~/bundles/all").Include(
					"~/Scripts/jquery-3.3.1.min.js",
					"~/Scripts/jquery-migrate-3.0.1.min.js",
					 "~/Scripts/bootstrap.min.js",
					  "~/Scripts/aos.js",
					  "~/Scripts/bootstrap-datepicker.min.js",
					  "~/Scripts/jquery.countdown.min.js",
					  "~/Scripts/jquery.easing.1.3.js",
					  "~/Scripts/jquery.fancybox.min.js",
					  "~/Scripts/jquery.magnific-popup.min.js",
					  "~/Scripts/jquery.stellar.min.js",
					  "~/Scripts/jquery.sticky.js",
					  "~/Scripts/jquery-ui.js",
					  "~/Scripts/typed.js",
					  "~/Scripts/mediaelement-and-player.min.js",
					  "~/Scripts/owl.carousel.min.js",
					  "~/Scripts/popper.min.js",
					  "~/Scripts/slick.min.js",
					  "~/Scripts/App.js",
					  "~/Scripts/main.js"
					  ));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.min.css",
					  "~/Content/bootstrap-datepicker.css",
					  "~/Content/aos.css",
					  "~/Content/jquery-ui.css",
					  "~/Content/jquery.fancybox.min.css",
					  "~/Content/magnific-popup.css",
					  "~/Content/mediaelementplayer.css",
					  "~/Content/owl.carousel.min.css",
					  "~/Content/owl.theme.default.min.css",
					  "~/Content/style.css"));
		}
	}
}
