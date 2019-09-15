using API.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using System.IO;
using Syncfusion.EJ2.DocumentEditor;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        public HomeController()
        {
            this.ApplicationDbContext = new ApplicationDbContext();
        }
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        // GET: /Home/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                ViewBag.errorMessage = "No code or  userId";
            }
            IdentityResult result;
            try
            {
                
                result = await UserManager.ConfirmEmailAsync(userId, code);
            }
            catch (InvalidOperationException ioe)
            {
                ViewBag.errorMessage = ioe.Message;
                return View();
            }

            if (result.Succeeded)
            {
                return View();
            }
            else
            {
                ViewBag.errorMessage = "ConfirmEmail failed";
                return View();
            }
           
        }

        // GET: /Home/ResetPassword
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> ResetPassword(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                ViewBag.errorMessage = "invalid reset link";
            }
            return View();
        }

        // POST: /Home/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.errorMessage = "userId, token or newPassword is invalid";
                return View(model);
            }

            IdentityResult result = await UserManager.ResetPasswordAsync(model.userId, model.token, model.Password);

            if (!result.Succeeded)
            {
                ViewBag.errorMessage = result.Errors.FirstOrDefault();

            }
            else
            {
                ViewBag.errorMessage = "succeeded";


//                string template =
//@"<html>
//<body>
//Hi @Model.FirstName @Model.LastName,

//Here are your orders: 
//@foreach(var order in Model.Orders) {
//    Order ID @order.Id Quantity : @order.Qty <strong>@order.Price</strong>. 
//}

//</body>
//</html>";

//                var model1 = new OrderModel
//                {
//                    FirstName = "Martin",
//                    LastName = "Whatever",
//                    Orders = new[] {
//                        new Order { Id = 1, Qty = 5, Price = 29.99 },
//                        new Order { Id = 2, Qty = 1, Price = 9.99 }
//                    }
//                };

     


            }

            return View();

        }
        
        public ActionResult DocumentEditor(string id, string token, string partner)
        {
            ViewBag.Token = token;
            ViewBag.Partner = partner;
            ViewBag.FileID = id;
            
            if(string.IsNullOrEmpty(token) || string.IsNullOrEmpty(id))
            {
                return View();
            }
            else
            {
                return PartialView();
            }
        }
        public ActionResult DocEditor(string id, string token, string partner)
        {
            ViewBag.Token = token;
            ViewBag.Partner = partner;
            ViewBag.FileID = id;

            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(id))
            {
                return View();
            }
            else
            {
                return PartialView();
            }
        }

    }
}
