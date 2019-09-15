//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

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
using DTOModel;
using BaseBusiness;

using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.Presentation;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.OfficeChart;


using RazorEngine;
using RazorEngine.Templating; // Dont forget to include this.
using Microsoft.AspNet.Identity;

using OfficeOpenXml;
using API.Models;
using System.Threading.Tasks;

namespace API.Controllers.DOC
{

	[RoutePrefix("api/CUS/FILE")]
    public class FileUploadController : CustomApiController
    {
        [Route("UploadImage")]
        public IHttpActionResult Post_UploadImage()
        {
            var httpRequest = System.Web.HttpContext.Current.Request;
            if (httpRequest.Files.Count < 1)
            {
                return BadRequest(ModelState);
            }

            DTO_WEB_BaiViet result = new DTO_WEB_BaiViet();

            foreach (string file in httpRequest.Files)
            {
                #region upload file
                var postedFile = httpRequest.Files[file];
                
                string uploadPath = "/Uploads/WebImages/" + DateTime.Today.ToString("yyyy/MM/dd").Replace("-", "/");
                
                string oldName = System.IO.Path.GetFileName(postedFile.FileName);
                string ext = oldName.Substring(oldName.LastIndexOf('.') + 1).ToLower();

                var g = Guid.NewGuid();
                string fileid = g.ToString();
                string fileName = "" + fileid + "." + oldName;
        
                string mapPath = System.Web.HttpContext.Current.Server.MapPath("~/");
                string strDirectoryPath = mapPath + uploadPath;
                string strFilePath = strDirectoryPath + "/" + fileName;

                System.IO.FileInfo existingFile = new System.IO.FileInfo(strFilePath);

                if (!System.IO.Directory.Exists(strDirectoryPath)) System.IO.Directory.CreateDirectory(strDirectoryPath);
                if (existingFile.Exists)
                {
                    existingFile.Delete();
                    existingFile = new System.IO.FileInfo(strFilePath);
                }

                postedFile.SaveAs(strFilePath);

                result.Image = uploadPath +"/"+ fileName;

                #endregion
            }

            
            if (result != null)
            {
                return CreatedAtRoute("", new { id = result.ID }, result);
            }
            return Conflict();

            
        }

        [Route("UploadAvatar/{code}")]
        public IHttpActionResult Post_UploadAvatar(string code)
        {
            var httpRequest = System.Web.HttpContext.Current.Request;
            if (httpRequest.Files.Count < 1)
            {
                return BadRequest(ModelState);
            }
            
            foreach (string file in httpRequest.Files)
            {
                #region upload file
                var postedFile = httpRequest.Files[file];

                string mapPath = System.Web.HttpContext.Current.Server.MapPath("~/");
                string uploadPath = "/Uploads/HRM/Staffs/Avatars/";
                string strDirectoryPath = mapPath + uploadPath;
                if (!System.IO.Directory.Exists(strDirectoryPath)) System.IO.Directory.CreateDirectory(strDirectoryPath);

             
                string fileName = code + ".jpg";
                string strFilePath = strDirectoryPath + "/" + fileName;

                System.IO.FileInfo existingFile = new System.IO.FileInfo(strFilePath);

                
                if (existingFile.Exists)
                {
                    existingFile.Delete();
                    existingFile = new System.IO.FileInfo(strFilePath);
                }

                postedFile.SaveAs(strFilePath);
                
                #endregion
            }

            return CreatedAtRoute("", new { id = 0 }, code + ".jpg");
        }


        #region NhanSu

        [Route("NhanSu")]
        public HttpResponseMessage Get_NhanSu()
        {
            string fileurl = "";
            var package = GetTemplateWorkbook("DS-NhanSu.xlsx", "DS-NhanSu.xlsx", out fileurl);

            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                var ws = workBook.Worksheets.FirstOrDefault(); //Worksheets["DS"];
                var data = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, QueryStrings);

                int rowid = 3;
                foreach (var item in data)
                {
                    ws.Cells["B" + rowid].Value = item.Sort; //STT
                    ws.Cells["C" + rowid].Value = item.Code;
                    ws.Cells["D" + rowid].Value = item.Name;

                    ws.Cells["E" + rowid].Value = item.SoDienThoai;
                    ws.Cells["F" + rowid].Value = item.Email;
                    ws.Cells["G" + rowid].Value = "";
                    //ws.Cells["H" + rowid].Value = item.IDRole;

                    if (item.IDRole.HasValue)
                    {
                        var ite = BS_CUS_SYS_Role.get_CUS_SYS_Role(db, PartnerID, item.IDRole.Value);
                        if (ite != null)
                        {
                            ws.Cells["H" + rowid].Value = ite.Code;
                        }
                    }

                    rowid++;
                }

                package.Save();
            }

            return downloadFile(fileurl);
        }


        [Route("NhanSu")]
        public async Task<HttpResponseMessage> Post_NhanSu()
        {
            string fileurl = "";
            var package = SaveImportedFile(out fileurl);
            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                ExcelWorksheet ws = workBook.Worksheets.FirstOrDefault();
                bool haveError = false;


                int SheetColumnsCount, SheetRowCount = 0;

                SheetColumnsCount = ws.Dimension.End.Column;    // Find End Column
                SheetRowCount = ws.Dimension.End.Row;           // Find End Row

                for (int rowid = 3; rowid <= SheetRowCount; rowid++)
                {
                    #region item
                    List<string> row = new List<string>();

                    for (int i = 2; i <= SheetColumnsCount; i++)
                        row.Add(ws.Cells[rowid, i].Value == null ? "" : ws.Cells[rowid, i].Text);

                    if (string.IsNullOrEmpty( row[1]) || string.IsNullOrEmpty(row[2]) || string.IsNullOrEmpty(row[4]) || string.IsNullOrEmpty(row[6])) //check validate
                        continue;


                    string code = row[1];
                    var dbitem = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, code);
                    if (dbitem == null)
                        dbitem = new DTO_CUS_HRM_STAFF_NhanSu();

                    if (int.TryParse(row[0], out int sort))
                        dbitem.Sort = sort;

                    dbitem.Code = row[1];
                    dbitem.Name = row[2];
                    dbitem.SoDienThoai = row[3];
                    dbitem.Email = row[4].ToLower();
                    string password = row[5];

                    //update role
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        var r = BS_CUS_SYS_Role.get_CUS_SYS_Role(db, PartnerID, row[6]);
                        if (r != null)
                        {
                            dbitem.IDRole = r.ID;
                        }
                        else
                        {
                            continue;
                        }
                    }


                    try
                    {
                        if (dbitem.ID != 0)
                        {
                            BS_CUS_HRM_STAFF_NhanSu.put_CUS_HRM_STAFF_NhanSu(db, PartnerID, dbitem.ID, dbitem, Username);
                        }
                        else
                        {
                            BS_CUS_HRM_STAFF_NhanSu.post_CUS_HRM_STAFF_NhanSu(db, PartnerID, dbitem, Username);
                        }

                        
                        //create/update account
                        var context = new ApplicationDbContext();
                        var dbUser = context.Users.FirstOrDefault(d => d.Email == dbitem.Email);
                        bool isCreate = false;

                        if (dbUser == null && !string.IsNullOrEmpty(password))
                        {
                            isCreate = true;
                            dbUser = new ApplicationUser();
                            dbUser.UserName = dbUser.Email = dbitem.Email;
                            dbUser.CreatedDate = DateTime.UtcNow;
                            dbUser.CreatedBy = Username;
                            IdentityResult result = await UserManager.CreateAsync(dbUser, password);
                        }

                        if (dbUser != null)
                        {
                            
                            dbUser.FullName = dbitem.Name;
                            dbUser.Avatar = string.Format("Uploads/HRM/Staffs/Avatars/{0}.jpg", dbitem.Code);
                            dbUser.PhoneNumber = dbitem.SoDienThoai;
                            dbUser.StaffID = dbitem.ID;
                            dbUser.PartnerID = dbitem.IDPartner;

                            context.SaveChanges();
                        }
                        //mail
                        if (isCreate)
                        {
                            string template =
                        @"
                    Xin chào <strong>@Model.FullName</strong>,
                    <br>
                    <br>Bạn vừa được tạo tài khoản truy cập vào hệ thống thư viện điện tử.
                    <br>
                    <br>Tài khoản đăng nhập:
                    <br>Email: <strong>@Model.Email</strong>
                    <br>Mật khẩu: <strong>@Model.Password</strong>
                    <br>
                    <br>Vui lòng đăng nhập tại
                    <br><a href='@Model.Domain'>@Model.Domain</a>
                    <br>";

                            var html = Engine.Razor.RunCompile(template, "Register_EmailTemplate", null, new { FullName = dbUser.FullName, Email = dbUser.Email, Password = password, Domain = "http://myduc.appcenter.vn:9003/" });

                            EmailService emailService = new EmailService();
                            emailService.SendSync(new IdentityMessage() { Subject = "Thư viện điện tử - thông tin tài khoản", Destination = dbUser.Email, Body = html });

                        }
                        else if(!string.IsNullOrEmpty(password))
                        {
                            UserManager.RemovePassword(dbUser.Id);
                            IdentityResult result = await UserManager.AddPasswordAsync(dbUser.Id, password);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        log.Error("Import/Post_NhanSu", ex);
                        continue;
                    }



                    #endregion

                }


                if (haveError)
                {
                    package.Save();
                    return downloadFile(fileurl, HttpStatusCode.Conflict);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        #endregion



    }


}