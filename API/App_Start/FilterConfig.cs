using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new TrackLoginsFilter());
        }
    }

    //MVC filter
    public class TrackLoginsFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Dictionary<string, DateTime> loggedInUsers = SecurityHelper.GetLoggedInUsers();

            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                if (loggedInUsers.ContainsKey(HttpContext.Current.User.Identity.Name))
                {
                    loggedInUsers[HttpContext.Current.User.Identity.Name] = System.DateTime.Now;
                }
                else
                {
                    loggedInUsers.Add(HttpContext.Current.User.Identity.Name, System.DateTime.Now);
                }

            }

            // remove users where time exceeds session timeout
            var keys = loggedInUsers.Where(u => DateTime.Now.Subtract(u.Value).Minutes >
                       HttpContext.Current.Session.Timeout).Select(u => u.Key);
            foreach (var key in keys)
            {
                loggedInUsers.Remove(key);
            }

        }
    }

    //WebApi filter
    public class MyActionFilter : System.Web.Http.Filters.ActionFilterAttribute
    {
        ILog log = log4net.LogManager.GetLogger("WebApi filter");

        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //string localPath = actionContext.Request.RequestUri.LocalPath;
            //bool isViewable = true;
            //if (!isViewable)
            //{
            //    actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            //}
            //else
            //{
            //}
        }

        //public override Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        //{
        //    string localPath = actionContext.Request.RequestUri.LocalPath;
        //    bool isViewable = false;
        //    if (!isViewable)
        //    {
        //        actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
        //        return Task<HttpResponseMessage>.Factory.StartNew(() => actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Access denied"), cancellationToken);
        //    }
        //    else
        //    {
        //        return base.OnActionExecutingAsync(actionContext, cancellationToken);
        //    }
        //}


    }

    public static class SecurityHelper
    {
        public static Dictionary<string, DateTime> GetLoggedInUsers()
        {
            Dictionary<string, DateTime> loggedInUsers = new Dictionary<string, DateTime>();

            if (HttpContext.Current != null)
            {
                loggedInUsers = (Dictionary<string, DateTime>)HttpContext.Current.Application["loggedinusers"];
                if (loggedInUsers == null)
                {
                    loggedInUsers = new Dictionary<string, DateTime>();
                    HttpContext.Current.Application["loggedinusers"] = loggedInUsers;
                }
            }
            return loggedInUsers;

        }
    }
}
