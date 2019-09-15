
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ClassLibrary;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Microsoft.AspNet.Identity;
using API.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using log4net;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace API.Controllers
{
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Method,  Inherited = true, AllowMultiple = true)]
    public class AuthorizeAttribute : AuthorizationFilterAttribute
    {
        ILog log = log4net.LogManager.GetLogger("AuthorizeAttribute");
        public AppEntities db = new AppEntities();


        public override void OnAuthorization(HttpActionContext actionContext)
        {
            string localPath = actionContext.Request.RequestUri.LocalPath;
            var user = actionContext.RequestContext.Principal;
            var actionList = getListControllerAction().FirstOrDefault(d=>d.LocalPath.StartsWith(localPath));
            bool isViewable = false;

            if (actionList != null) {
                foreach (var role in actionList.Roles)
                {
                    if (user.IsInRole(role))
                    {
                        isViewable = true;
                        break;
                    }
                    
                }
            }
            else
            {
                isViewable = true;
            }

            var userString = string.IsNullOrEmpty(user.Identity.Name) ? "unknown" : user.Identity.Name;

            log4net.ThreadContext.Properties["ipaddress"] = HttpContext.Current.Request.UserHostAddress;
            log4net.ThreadContext.Properties["loggedby"] = userString;

            string ipList = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ipList))
            {
                ipList = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            log4net.ThreadContext.Properties["ipaddresslan"] = ipList;

            if (!isViewable)
            {
                log.Warn(userString + " try to access " + localPath);
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
            else
            {
                log.Info(userString + " accessed to " + localPath);
                base.OnAuthorization(actionContext);
            }
        }

        public List<controllerAction> getListControllerAction()
        {
            List<controllerAction> result = new List<controllerAction>();
            result.Add(new controllerAction() { LocalPath = "/api/BOOK/Bookings", Roles = new List<string>() { "ThuKy", "BacSi", "CongTac", "BenhNhan" } });

            return result;
        }
    }

    public class controllerAction
    {
        public int ID { get; set; }
        public string LocalPath { get; set; }
        public List<string> Roles { get; set; }
    }
}