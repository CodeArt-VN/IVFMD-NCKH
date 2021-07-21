using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using API.Models;
using API.Providers;
using API.Results;
using System.Linq;
using DTOModel;
using BaseBusiness;
using System.Web.Security;
using System.Web.Http.Description;
using System.Net;
using RazorEngine;
using RazorEngine.Templating;

namespace API.Controllers
{

    [RoutePrefix("api/Account")]
    public class AccountController : CustomApiController
    {
        private const string LocalLoginProvider = "Local";
        private string domain = "http://nckh.appcenter.vn/"; //"http://myduc.appcenter.vn:9003/"; 

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager, ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            //UserManager = userManager;
            AccessTokenFormat = accessTokenFormat;
        }

        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }

        [Route("UserInfo")]
        public DTO_APP_UserInfo GetUserInfo()
        {
            DTO_APP_UserInfo result = new DTO_APP_UserInfo();
            result.Id = "";
            result.Roles = new DTO_AppRole();
            result.Roles.CUSRoles = new List<int>();
            result.Roles.SYSRoles = new List<string>();
            result.Partners = new List<DTO_Partner>();

            result.MenuItems = new List<DTO_APP_FormGroup>();


            if (User.Identity.IsAuthenticated)
            {
                
                ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
                if (user != null)
                {
                    result.Id = user.Id;
                    result.UserName = user.UserName;
                    result.Email = user.Email;
                    result.PartnerID = user.PartnerID;
                    result.StaffID = user.StaffID;
                    result.FullName = user.FullName;
                    result.PhoneNumber = user.PhoneNumber;
                    result.Avatar = user.Avatar;


                    var CUSRoles = db.tbl_CUS_SYS_Role.Where(d => d.tbl_CUS_HRM_STAFF_NhanSu.Any(s => s.ID == user.StaffID));
                    
                    foreach (var ro in CUSRoles)
                    {
                        result.Roles.CUSRoles.Add(ro.ID);
                    }
                    
                    foreach (var ro in user.Roles)
                    {
                        result.Roles.SYSRoles.Add(ro.RoleId);
                    }

                }
            }
            
            //if (result.Roles.SYSRoles.Count == 0 && result.Roles.CUSRoles.Count == 0)
            //{
            //    result.Roles.SYSRoles.Add("GUEST");
            //}

            if (QueryStrings.Any(d => d.Key == "GetMenu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "GetMenu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                {
                    result.MenuItems = BS_SYS_Form.get_SYS_Form(db, PartnerID, result.Roles);

                    if (result.Roles.SYSRoles.Contains("HOST"))
                    {
                        var partners = BS_PAR_Partner.get_PAR_Partner(db, QueryStrings).Select(partner => new DTO_Partner() { ID = partner.ID, Code = partner.Code, Name = partner.Name, LogoURL = partner.LogoURL, Remark=partner.Remark, BannerURL = partner.BannerURL, TemplateHeader = partner.TemplateHeader, TemplateFooter = partner.TemplateFooter });
                        result.Partners = partners.ToList();
                        
                    }
                    else
                    {
                        var partner = BS_PAR_Partner.get_PAR_Partner(db, result.PartnerID);
                        if (partner != null)
                        {

                            result.Partners.Add(new DTO_Partner() { ID = partner.ID, Code = partner.Code, Name = partner.Name, LogoURL = partner.LogoURL, Remark = partner.Remark, BannerURL = partner.BannerURL, TemplateHeader = partner.TemplateHeader, TemplateFooter = partner.TemplateFooter });
                        }
                    }

                    
                    
                }
            }

            //if (result.MenuItems == null)
            //    result.MenuItems = new List<DTO_APP_FormGroup>();

            if (User.Identity.IsAuthenticated)
            {
                if (result.MenuItems != null && result.MenuItems.Count > 0)
                {
                    result.MenuItems.Insert(0, new DTO_APP_FormGroup
                    {
                        ID = 0,
                        AppID = 0,
                        Code = "Home",
                        AppName = "Home",
                        FormMenu = new List<DTO_APP_Form>
                {
                    new DTO_APP_Form
                    {
                        ID = 0,
                        Code = "page-default",
                        Name = "Home",
                        IsHiddenMenu = true
                    }
                },
                        Forms = new List<DTO_APP_Form>
                {
                    new DTO_APP_Form
                    {
                        ID = 0,
                        Code = "page-default",
                        Name = "Home",
                        IsHiddenMenu = true
                    }
                }
                    });
                }
            }

            return result;
        }
        
        [Route("ApplicationUsers")]
        public List<UserInfoViewModel> GetApplicationUsers()
        {
            var context = new ApplicationDbContext();
            var userList = context.Users.Select(s => new UserInfoViewModel()
            {
                ID = s.Id,
                Email = s.Email,
                Avatar = s.Avatar,
                CreatedBy = s.CreatedBy,
                CreatedDate = s.CreatedDate,
                DOB = s.DOB,
                FullName = s.FullName,
                PhoneNumber = s.PhoneNumber,
                UserName = s.UserName,
                PartnerID = s.PartnerID,
                PatientID = s.PatientID,
                StaffID = s.StaffID,
                LockoutEnabled = s.LockoutEnabled,

                Gender = s.Gender,
                Address = s.Address,
                IDTinhThanh = s.IDTinhThanh,
                IDQuanHuyen = s.IDQuanHuyen,

                Roles = s.Roles.Select(ss => new Role() { RoleId = ss.RoleId }).ToList()

            }).ToList();

            return userList;
        }

        [Route("ApplicationUsers/{id}")]
        public UserInfoViewModel GetApplicationUsers(string id)
        {
            var context = new ApplicationDbContext();
            var userList = context.Users.Where(d=>d.Email==id || d.Id == id).Select(s => new UserInfoViewModel()
            {
                ID = s.Id,
                Email = s.Email,
                Avatar = s.Avatar,
                CreatedBy = s.CreatedBy,
                CreatedDate = s.CreatedDate,
                DOB = s.DOB,
                FullName = s.FullName,
                PhoneNumber = s.PhoneNumber,
                UserName = s.UserName,
                PartnerID = s.PartnerID,
                PatientID = s.PatientID,
                StaffID = s.StaffID,
                LockoutEnabled = s.LockoutEnabled,

                Gender = s.Gender,
                Address = s.Address,
                IDTinhThanh = s.IDTinhThanh,
                IDQuanHuyen = s.IDQuanHuyen,

                Roles = s.Roles.Select(ss => new Role() { RoleId = ss.RoleId }).ToList()

            }).ToList();

            return userList.FirstOrDefault();
        }


        [Route("ApplicationUsers/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutApplicationUsers(string id, UserInfoViewModel u)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != u.ID)
                return BadRequest();

            var context = new ApplicationDbContext();
            var dbUser = context.Users.FirstOrDefault(d => d.Id == id);

            if (dbUser == null)
            {
                return BadRequest("Not found user with Id: " + id);
            }
            dbUser.UserName = dbUser.Email = string.IsNullOrEmpty( u.Email) ? null : u.Email.ToLower();
            
            dbUser.FullName = u.FullName;
            dbUser.Avatar = u.Avatar;
            dbUser.PhoneNumber = u.PhoneNumber;
            dbUser.Address = u.Address;
            dbUser.Gender = u.Gender;
            dbUser.DOB = u.DOB;
            dbUser.StaffID = u.StaffID;
            dbUser.PartnerID = u.PartnerID;

            dbUser.LockoutEnabled = u.LockoutEnabled;
            
            try
            {
                context.SaveChanges();


                #region Update roles
                if (User.IsInRole("HOST"))
                {
                    var user = UserManager.FindById(dbUser.Id);
                    UserManager.RemoveFromRoles(dbUser.Id, UserManager.GetRoles(dbUser.Id).ToArray());
                    foreach (var r in u.Roles)
                    {
                        UserManager.AddToRole(dbUser.Id, r.RoleId);
                    }
                    UserManager.Update(user);
                }
                #endregion

                //if ( dbUser.StaffID!=0 || u.Roles.Any(d => d.RoleId == "ThuKy" || d.RoleId == "BacSi") && (User.IsInRole("ThuKy") || User.IsInRole("Admin")))
                //{
                //     DTO_CUS_HRM_STAFF_NhanSu i = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, dbUser.StaffID, dbUser.Email);
                //    if (i == null)
                //        i = new DTO_CUS_HRM_STAFF_NhanSu();
                //    //i.Username = dbUser.UserName;
                //    i.FullName = dbUser.FullName;
                //    var names = i.FullName.Split(' ');
                //    //i.FirstName = names[names.Length - 1];
                //    //i.LastName = i.FullName.Substring(0, i.FullName.Length - i.FirstName.Length).Trim();
                //    //i.Gender = dbUser.Gender;
                //    //i.DOB = dbUser.DOB;
                //    //i.PhoneNumber = dbUser.PhoneNumber;
                //    //i.EmailAddress = dbUser.Email;

                //    if ( i.ID != 0)
                //    {
                //        BS_CUS_HRM_STAFF_NhanSu.put_LIST_Staff(db, PartnerID, i.ID, i, Username);
                //    }
                //    else
                //    {
                //        dbUser.StaffID = BS_CUS_HRM_STAFF_NhanSu.post_LIST_Staff(db, PartnerID, i, Username).ID;
                //        context.SaveChanges();
                //    }
                //}
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                log.Error("PutApplicationUsers", ex);
                throw;
            }
        }

        [Route("ApplicationUsers")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PostApplicationUsers(UserInfoViewModel u)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var context = new ApplicationDbContext();
            ApplicationUser dbUser = context.Users.FirstOrDefault(d => d.Email == u.Email);
            string activeLink = "";
            string password = u.UserName;


            if (dbUser == null)
            {
                dbUser = new ApplicationUser();
                var user = new ApplicationUser() { UserName = u.Email, Email = u.Email };
                user.CreatedDate = DateTime.UtcNow;
                user.CreatedBy = Username;
                IdentityResult result = await UserManager.CreateAsync(user, password);
                if (!result.Succeeded)
                {
                    return GetErrorResult(result);
                }
                else
                {
                    string code = System.Web.HttpUtility.UrlEncode(UserManager.GenerateEmailConfirmationToken(user.Id));
                    activeLink = string.Format(domain + "Home/ConfirmEmail/?userId={0}&code={1}", user.Id, code);
                }

                dbUser = context.Users.FirstOrDefault(d => d.Email == u.Email);
            }
            else
            {
                return BadRequest("Account with email is exits: " + u.Email);
            }

            #region Update roles
            if (User.IsInRole("HOST"))
            {
                var user = UserManager.FindById(dbUser.Id);
                UserManager.RemoveFromRoles(dbUser.Id, UserManager.GetRoles(dbUser.Id).ToArray());
                if (u.Roles != null)
                {
                    foreach (var r in u.Roles)
                    {
                        UserManager.AddToRole(dbUser.Id, r.RoleId);
                    }
                }
                UserManager.Update(user);
            }
            #endregion



            dbUser.UserName = dbUser.Email = string.IsNullOrEmpty(u.Email) ? null : u.Email.ToLower();

            dbUser.FullName = u.FullName;
            dbUser.Avatar = u.Avatar;
            dbUser.PhoneNumber = u.PhoneNumber;
            dbUser.Address = u.Address;
            dbUser.Gender = u.Gender;
            dbUser.DOB = u.DOB;
            dbUser.StaffID = u.StaffID;
            dbUser.PartnerID = u.PartnerID;

            dbUser.LockoutEnabled = u.LockoutEnabled;

            try
            {
                context.SaveChanges();

                // using RazorEngine;
                // using RazorEngine.Templating; // Dont forget to include this.
                string template =
                    @"
                        Xin chào <strong>@Model.FullName</strong>,
                        <br>
                        <br>Bạn vừa được tạo tài khoản truy cập vào hệ thống Quản lý Đề tài Nghiên cứu khoa học.
                        <br>
                        <br>Tài khoản đăng nhập:
                        <br>Email: <strong>@Model.Email</strong>
                        <br>Mật khẩu: <strong>@Model.Password</strong>
                        <br>
                        <br>Vui lòng đăng nhập
                        <br> - Đối với mạng của BV Mỹ Đức: <a href='@Model.Domain2'>@Model.Domain2</a> 
                        <br> - Đối với mạng ngoài BV: <a href='@Model.Domain'>@Model.Domain</a> 
                        <br>";

                var html = Engine.Razor.RunCompile(template, "Register_EmailTemplate", null, new { FullName = dbUser.FullName, Email = dbUser.Email, Password = password, Domain = "http://113.161.87.251:9004/", Domain2 = "http://172.16.1.18:9002/" });

                EmailService emailService = new EmailService();
                emailService.Send(new IdentityMessage() { Subject = "Quản lý Đề tài Nghiên cứu khoa học - thông tin tài khoản", Destination = dbUser.Email, Body = html });

                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                log.Error("PostApplicationUsers", ex);
                throw;
            }
        }


        // POST api/Account/Logout
        [Route("Logout")]
        public IHttpActionResult Logout()
        {
            SecurityHelper.GetLoggedInUsers().Remove(User.Identity.Name);
            Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);

            return Ok();
        }

        // GET api/Account/ManageInfo?returnUrl=%2F&generateState=true
        [Route("ManageInfo")]
        public async Task<ManageInfoViewModel> GetManageInfo(string returnUrl, bool generateState = false)
        {
            IdentityUser user = await UserManager.FindByIdAsync(User.Identity.GetUserId());

            if (user == null)
            {
                return null;
            }

            List<UserLoginInfoViewModel> logins = new List<UserLoginInfoViewModel>();

            foreach (IdentityUserLogin linkedAccount in user.Logins)
            {
                logins.Add(new UserLoginInfoViewModel
                {
                    LoginProvider = linkedAccount.LoginProvider,
                    ProviderKey = linkedAccount.ProviderKey
                });
            }

            if (user.PasswordHash != null)
            {
                logins.Add(new UserLoginInfoViewModel
                {
                    LoginProvider = LocalLoginProvider,
                    ProviderKey = user.UserName,
                });
            }

            return new ManageInfoViewModel
            {
                LocalLoginProvider = LocalLoginProvider,
                Email = user.UserName,
                Logins = logins,
                ExternalLoginProviders = GetExternalLogins(returnUrl, generateState)
            };
        }

        // POST api/Account/ChangePassword
        [Route("ChangePassword")]
        public async Task<IHttpActionResult> ChangePassword(ChangePasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword,
                model.NewPassword);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // POST api/Account/SetPassword
        [Route("SetPassword")]
        public async Task<IHttpActionResult> SetPassword(SetPasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string Id = string.IsNullOrEmpty(model.UserId) ? User.Identity.GetUserId() : model.UserId;
            UserManager.RemovePassword(Id);

            IdentityResult result = await UserManager.AddPasswordAsync(Id, model.NewPassword);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // POST api/Account/AddExternalLogin
        [Route("AddExternalLogin")]
        public async Task<IHttpActionResult> AddExternalLogin(AddExternalLoginBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);

            AuthenticationTicket ticket = AccessTokenFormat.Unprotect(model.ExternalAccessToken);

            if (ticket == null || ticket.Identity == null || (ticket.Properties != null
                && ticket.Properties.ExpiresUtc.HasValue
                && ticket.Properties.ExpiresUtc.Value < DateTimeOffset.UtcNow))
            {
                return BadRequest("External login failure.");
            }

            ExternalLoginData externalData = ExternalLoginData.FromIdentity(ticket.Identity);

            if (externalData == null)
            {
                return BadRequest("The external login is already associated with an account.");
            }

            IdentityResult result = await UserManager.AddLoginAsync(User.Identity.GetUserId(),
                new UserLoginInfo(externalData.LoginProvider, externalData.ProviderKey));

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // POST api/Account/RemoveLogin
        [Route("RemoveLogin")]
        public async Task<IHttpActionResult> RemoveLogin(RemoveLoginBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result;

            if (model.LoginProvider == LocalLoginProvider)
            {
                result = await UserManager.RemovePasswordAsync(User.Identity.GetUserId());
            }
            else
            {
                result = await UserManager.RemoveLoginAsync(User.Identity.GetUserId(),
                    new UserLoginInfo(model.LoginProvider, model.ProviderKey));
            }

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // GET api/Account/ExternalLogin
        [OverrideAuthentication]
        [HostAuthentication(DefaultAuthenticationTypes.ExternalCookie)]
        [AllowAnonymous]
        [Route("ExternalLogin", Name = "ExternalLogin")]
        public async Task<IHttpActionResult> GetExternalLogin(string provider, string error = null)
        {
            if (error != null)
            {
                return Redirect(Url.Content("~/") + "#error=" + Uri.EscapeDataString(error));
            }

            if (!User.Identity.IsAuthenticated)
            {
                return new ChallengeResult(provider, this);
            }

            ExternalLoginData externalLogin = ExternalLoginData.FromIdentity(User.Identity as ClaimsIdentity);

            if (externalLogin == null)
            {
                return InternalServerError();
            }

            if (externalLogin.LoginProvider != provider)
            {
                Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                return new ChallengeResult(provider, this);
            }

            ApplicationUser user = await UserManager.FindAsync(new UserLoginInfo(externalLogin.LoginProvider,
                externalLogin.ProviderKey));

            bool hasRegistered = user != null;

            if (hasRegistered)
            {
                Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);

                ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(UserManager,
                   OAuthDefaults.AuthenticationType);
                ClaimsIdentity cookieIdentity = await user.GenerateUserIdentityAsync(UserManager,
                    CookieAuthenticationDefaults.AuthenticationType);

                AuthenticationProperties properties = ApplicationOAuthProvider.CreateProperties(user);
                Authentication.SignIn(properties, oAuthIdentity, cookieIdentity);
            }
            else
            {
                IEnumerable<Claim> claims = externalLogin.GetClaims();
                ClaimsIdentity identity = new ClaimsIdentity(claims, OAuthDefaults.AuthenticationType);
                Authentication.SignIn(identity);
            }

            return Ok();
        }

        // GET api/Account/ExternalLogins?returnUrl=%2F&generateState=true
        [AllowAnonymous]
        [Route("ExternalLogins")]
        public IEnumerable<ExternalLoginViewModel> GetExternalLogins(string returnUrl, bool generateState = false)
        {
            IEnumerable<AuthenticationDescription> descriptions = Authentication.GetExternalAuthenticationTypes();
            List<ExternalLoginViewModel> logins = new List<ExternalLoginViewModel>();

            string state;

            if (generateState)
            {
                const int strengthInBits = 256;
                state = RandomOAuthStateGenerator.Generate(strengthInBits);
            }
            else
            {
                state = null;
            }

            foreach (AuthenticationDescription description in descriptions)
            {
                ExternalLoginViewModel login = new ExternalLoginViewModel
                {
                    Name = description.Caption,
                    Url = Url.Route("ExternalLogin", new
                    {
                        provider = description.AuthenticationType,
                        response_type = "token",
                        client_id = Startup.PublicClientId,
                        redirect_uri = new Uri(Request.RequestUri, returnUrl).AbsoluteUri,
                        state = state
                    }),
                    State = state
                };
                logins.Add(login);
            }

            return logins;
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(RegisterBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser() { UserName = model.Email, Email = model.Email };
            try
            {

                user.CreatedDate = DateTime.UtcNow;
                user.CreatedBy = "Register";
                IdentityResult result = await UserManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    return GetErrorResult(result);
                }
                else
                {
                    ////kiểm tra tạo patient => tạo accounnt cho patient.
                    //DTO_LIST_Patients patient = BS_LIST_Patients.get_LIST_Patients(db, 0, model.PhoneNumber, model.Email);
                    //if (patient == null)
                    //    patient = new DTO_LIST_Patients();

                    ////Todo: Tạo mã thẻ thành viên
                    //patient.FullName = model.FullName;
                    //var names = patient.FullName.Split(' ');
                    //patient.FirstName = names[names.Length - 1];
                    //patient.LastName = patient.FullName.Substring(0, patient.FullName.Length - patient.FirstName.Length).Trim();
                    //patient.PhoneNumber = model.PhoneNumber;
                    //patient.EmailAddress = model.Email;
                    //patient.Username = model.Email;

                    //if (patient.ID == 0)
                    //{
                    //    patient = BS_LIST_Patients.post_LIST_Patients(db, PartnerID, patient, "Register");
                    //}
                    //else
                    //{
                    //    BS_LIST_Patients.put_LIST_Patients(db, PartnerID, patient.ID, patient, "Register");
                    //}

                    ////Update account info
                    //user.FullName = model.FullName;
                    //user.PhoneNumber = model.PhoneNumber;

                    //user.StaffID = model.StaffID;
                    //user.PatientID = patient.ID;

                    //// Associate the role with the new user 
                    //await UserManager.AddToRoleAsync(user.Id, "BenhNhan");
                    //UserManager.Update(user);

                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                    string code = UserManager.GenerateEmailConfirmationToken(user.Id);

                    var callbackUrl = string.Format(domain + "Home/ConfirmEmail/?userId={0}&code={1}", user.Id, code);
                    UserManager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                ClassLibrary.errorLog.logMessage("api/Account/Register", e);
            }









            return Ok();
        }

        // POST api/Account/RegisterExternal
        [OverrideAuthentication]
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [Route("RegisterExternal")]
        public async Task<IHttpActionResult> RegisterExternal(RegisterExternalBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var info = await Authentication.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return InternalServerError();
            }

            var user = new ApplicationUser() { UserName = model.Email, Email = model.Email };

            IdentityResult result = await UserManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            result = await UserManager.AddLoginAsync(user.Id, info.Login);
            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }
            return Ok();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("ForgotPassword")]
        public async Task<IHttpActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                // If user has to activate his email to confirm his account, the use code listing below
                //if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
                //{
                //    return Ok();
                //}
                if (user == null)
                {
                    return NotFound();
                }

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                var callbackUrl =  string.Format(domain + "Home/ResetPassword?userId={0}&token={1}", user.Id, System.Web.HttpUtility.UrlEncode(code) );

                await UserManager.SendEmailAsync(user.Id, "Thư viện điên tử - Yêu cầu đổi mật khẩu",
                    $"Chào bạn, <br><br>Hệ thống đã nhận được yêu cầu đổi mật khẩu tài khoản của bạn.<br>" +
                    $"Vui lòng <b><a href='{callbackUrl}'>bấm vào đây để thay đổi mật khẩu</a></b>.<br>" +
                    $"Nếu bạn không yêu cầu thay đổi mật khẩu, vui lòng bỏ qua email này.<br>" +
                    $"<br>---<br>" +
                    $"Trân trọng!");

                return Ok();
            }

            // If we got this far, something failed, redisplay form
            return BadRequest(ModelState);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return NotFound();
            }

            IdentityResult result = await UserManager.ConfirmEmailAsync(userId, code);

            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> ResetPassword(string userId, string token, string newPassword)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token) || string.IsNullOrEmpty(newPassword))
            {
                return NotFound();
            }

            IdentityResult result = await UserManager.ResetPasswordAsync(userId, token, newPassword);

            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region Helpers

        private IAuthenticationManager Authentication
        {
            get { return Request.GetOwinContext().Authentication; }
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        private class ExternalLoginData
        {
            public string LoginProvider { get; set; }
            public string ProviderKey { get; set; }
            public string UserName { get; set; }

            public IList<Claim> GetClaims()
            {
                IList<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, ProviderKey, null, LoginProvider));

                if (UserName != null)
                {
                    claims.Add(new Claim(ClaimTypes.Name, UserName, null, LoginProvider));
                }

                return claims;
            }

            public static ExternalLoginData FromIdentity(ClaimsIdentity identity)
            {
                if (identity == null)
                {
                    return null;
                }

                Claim providerKeyClaim = identity.FindFirst(ClaimTypes.NameIdentifier);

                if (providerKeyClaim == null || String.IsNullOrEmpty(providerKeyClaim.Issuer)
                    || String.IsNullOrEmpty(providerKeyClaim.Value))
                {
                    return null;
                }

                if (providerKeyClaim.Issuer == ClaimsIdentity.DefaultIssuer)
                {
                    return null;
                }

                return new ExternalLoginData
                {
                    LoginProvider = providerKeyClaim.Issuer,
                    ProviderKey = providerKeyClaim.Value,
                    UserName = identity.FindFirstValue(ClaimTypes.Name)
                };
            }
        }

        private static class RandomOAuthStateGenerator
        {
            private static RandomNumberGenerator _random = new RNGCryptoServiceProvider();

            public static string Generate(int strengthInBits)
            {
                const int bitsPerByte = 8;

                if (strengthInBits % bitsPerByte != 0)
                {
                    throw new ArgumentException("strengthInBits must be evenly divisible by 8.", "strengthInBits");
                }

                int strengthInBytes = strengthInBits / bitsPerByte;

                byte[] data = new byte[strengthInBytes];
                _random.GetBytes(data);
                return HttpServerUtility.UrlTokenEncode(data);
            }
        }

        #endregion
    }
}
