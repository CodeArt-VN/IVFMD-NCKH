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
using System.Threading;
using System.Threading.Tasks;
using DTOModel;

using System.Web;
using OfficeOpenXml;
using System.IO;


namespace API.Controllers
{
    [MyActionFilter]
    [Authorize]
    public partial class CustomApiController : ApiController
    {
        public CustomApiController()
        {
            this.ApplicationDbContext = new ApplicationDbContext();

            //log.Debug("Debug message");
            //log.Warn("Warn message");
            //log.Error("Error message");
            //log.Fatal("Fatal message");
            
        }

        public ILog log = log4net.LogManager.GetLogger("API Logs");

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



        public AppEntities db = new AppEntities();
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        
        public string Username
        {
            get
            {
                return User.Identity.Name;
            }
        }
        public int PartnerID {
            get {
                if (!User.Identity.IsAuthenticated)
                {
                    return 0;
                }
                else
                {
                    int id = 0;
                    var uid = User.Identity.GetUserId();
                    var user = UserManager.FindById(uid);

                    //Nếu HOST và có gửi kèm theo IDPartner thì lấy IDPartner đó.
                    if (user.Roles.Any(d => d.RoleId == "HOST") && QueryStrings.Any(d => d.Key == "IDPartner"))
                    {
                        var strValue = QueryStrings.FirstOrDefault(d => d.Key == "IDPartner").Value;
                        if (int.TryParse(strValue, out int i))
                        return i;
                    }

                    if (user != null)
                    {
                        id = user.PartnerID;
                    }
                    return id;
                }
            }
        }
        public int StaffID
        {
            get
            {
                int id = 0;
                var user = UserManager.FindById(User.Identity.GetUserId());

                if (user != null)
                {
                    id = user.StaffID;
                }
                return id;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public Dictionary<string, string> QueryStrings
        {
            get
            {
                return Request.GetQueryNameValuePairs().Distinct().ToDictionary(kv => kv.Key, kv => kv.Value, StringComparer.OrdinalIgnoreCase);
            }

        }


        //public override Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken)
        //{
        //    //string localPath = controllerContext.Request.RequestUri.LocalPath;
        //    //log.Info(localPath);
        //    return base.ExecuteAsync(controllerContext, cancellationToken);
        //}

        private bool checkUserRole()
        {
            string id = User.Identity.GetUserId();
            UserManager.GetRoles(id);
            return false;
        }
        public IList<string> Roles
        {
            get
            {
                var user = UserManager.FindById(User.Identity.GetUserId());
                if (user != null)
                {
                    var roleList = db.tbl_CUS_SYS_Role.Where(d => d.tbl_CUS_HRM_STAFF_NhanSu.Any(s => s.ID == user.StaffID));
                    if (roleList.Count() > 0)
                    {
                        foreach (var ro in roleList)
                        {
                            user.Roles.Add(new IdentityUserRole() { RoleId = ro.Code });
                        }
                    }
                    if (user.Roles.Count == 0)
                    {
                        user.Roles.Add(new IdentityUserRole() { RoleId = "GUEST" });
                    }
                }

                return user.Roles.Select(s => s.RoleId).ToList();
            }
        }
        public DTO_AppRole AppRole {
            get
            {
                DTO_AppRole result = new DTO_AppRole();

                var user = UserManager.FindById(User.Identity.GetUserId());
                if (user != null)
                {

                    var CUSRoles = db.tbl_CUS_SYS_Role.Where(d => d.tbl_CUS_HRM_STAFF_NhanSu.Any(s => s.ID == user.StaffID));
                    
                    result.CUSRoles = new List<int>();
                    foreach (var ro in CUSRoles)
                    {
                        result.CUSRoles.Add( ro.ID );
                    }

                    result.SYSRoles = new List<string>();
                    foreach (var ro in user.Roles)
                    {
                        result.SYSRoles.Add(ro.RoleId);
                    }
                }


                if (result.SYSRoles.Count == 0 && result.CUSRoles.Count == 0) {
                    result.SYSRoles.Add("GUEST");
                }


                return result;
            }
        }

        public ExcelPackage GetTemplateWorkbook(string fileTemplate, string SaveName, out string fileurl)
        {
            string templateFilePath = "Uploads/FileTemplate/" + fileTemplate;
            string fileName = SaveName;
            string mapPath = HttpContext.Current.Server.MapPath("~/");
            string uploadPath = "/Uploads/" + DateTime.Today.ToString("yyyy/MM/dd").Replace("-", "/");
            string strDirectoryPath = mapPath + uploadPath;
            string strFilePath = strDirectoryPath + "/" + fileName;
            fileurl = uploadPath + "/" + fileName;


            FileInfo exportFile = new FileInfo(strFilePath);

            if (!System.IO.Directory.Exists(strDirectoryPath))
                System.IO.Directory.CreateDirectory(strDirectoryPath);

            if (exportFile.Exists)
            {
                exportFile.Delete();
                exportFile = new FileInfo(strFilePath);
            }

            FileInfo templateFile = new FileInfo(mapPath + templateFilePath);

            var package = new ExcelPackage(templateFile);
            package.SaveAs(exportFile);
            return package;
        }
        public HttpResponseMessage downloadFile(string fileurl, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            HttpResponseMessage response;
            response = Request.CreateResponse(statusCode);
            response.Content = new StringContent(fileurl);

            return response;
        }
        public ExcelPackage SaveImportedFile(out string fileurl)
        {
            fileurl = "";
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count < 1)
            {
                return null;
            }
            

            #region upload file
            var postedFile = httpRequest.Files[0];


            string mapPath = HttpContext.Current.Server.MapPath("~/");
            string fileName = "Validate_" + Path.GetFileName(postedFile.FileName);
            string uploadPath = "/Uploads/" + DateTime.Today.ToString("yyyy/MM/dd").Replace("-", "/");
            string strDirectoryPath = mapPath + uploadPath;
            string strFilePath = strDirectoryPath + "/" + fileName;
            FileInfo existingFile = new FileInfo(strFilePath);

            if (!System.IO.Directory.Exists(strDirectoryPath))
                System.IO.Directory.CreateDirectory(strDirectoryPath);
            if (existingFile.Exists)
            {
                existingFile.Delete();
                existingFile = new FileInfo(strFilePath);
            }

            postedFile.SaveAs(strFilePath);
            #endregion

            var package = new ExcelPackage(existingFile);
            return package;
        }

    }

    
}


//public(.*) (.*)(?([^\r\n])\s)(.*)(?([^\r\n])\s)({.*})
//$3 = s.$3,