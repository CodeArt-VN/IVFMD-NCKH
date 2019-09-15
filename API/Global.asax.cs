using System;
using Syncfusion.Licensing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SyncfusionLicenseProvider.RegisterLicense("NDQxNTdAMzEzNjJlMzMyZTMwaUFZQWpPZ0xZaElRc3lVT21qdzhhaGFneTJHQzdoaVQweWpKbTQzWmkyRT0=;NDQxNThAMzEzNjJlMzMyZTMwaEtmSHhoZDJVKzRKaUxjQ1NkdldvcE1QNVBQNkFLckVkRDBRMUE2aUtEOD0=;NDQxNTlAMzEzNjJlMzMyZTMwbnJUY2d4Y2lrQ1ppS01nOVZRenNHbUR0NVF4MVZiRXZjd1VQek9CenAyOD0=;NDQxNjBAMzEzNjJlMzMyZTMwZEhJbUhkUU1QOFc0Tm4rcVhJSlptTDFSRUR1MTkzOWo0ME9sZ1BiaWtPbz0=;NDQxNjFAMzEzNjJlMzMyZTMwTTdUSld2YXBONWVaak1LZDk2WVc2S3BOZ213eUNoOVhUSlplQmhadVhGZz0=;NDQxNjJAMzEzNjJlMzMyZTMwTzNZLzJKVEpqTVBlMjV2UGNQN1dhYUFrdUhQZVFSUHdtTUFTMjVrbmpHcz0=;NDQxNjNAMzEzNjJlMzMyZTMwQlFadzB4NlVyQzdycFVRT3NUWk8xYkRwaUZSVG1Kbjdjb0gvRHJIdm10az0=;NDQxNjRAMzEzNjJlMzMyZTMwTStZeUNUdTNWTUdQWjcxa0JCL3o2MW92SzJyYlJsdXM1TDhNVkxNcW5XMD0=;NDQxNjVAMzEzNjJlMzMyZTMwUUZSYlVEckpuSVo3U2ROM2EzUUQySUc1L1I1aUZHUlhxcVpBdXRqRlFQST0=");

            ////AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            ////BundleConfig.RegisterBundles(BundleTable.Bundles);

            //log4net.Config.XmlConfigurator.Configure();
        }
    }
}
