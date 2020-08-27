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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
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
using System.IO;

namespace API.Controllers.DOC
{
	[RoutePrefix("api/CUS/DOC/File")]
    public class FileController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CUS_DOC_File> Get()
        {
            var result = BS_CUS_DOC_File.get_CUS_DOC_File(db, PartnerID, QueryStrings, true).ToList();
            
            if (QueryStrings.Any(d => d.Key == "IncludeOwner"))
            {
            
                var query = db.tbl_CUS_DOC_File
                .Where(d => d.IsDeleted == false && d.IsHidden != true && d.IDPartner == PartnerID && (d.ModifiedBy == Username || d.CreatedBy == Username));

                if (QueryStrings.Any(d => d.Key == "IDFolder"))
                {
                    var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDFolder").Value.Replace("[", "").Replace("]", "").Split(',');
                    List<int> IDs = new List<int>();
                    foreach (var item in IDList)
                    {
                        if (int.TryParse(item, out int i))
                            IDs.Add(i);
                        else if (item == "null")
                        {
                            query = query.Where(d => !d.tbl_CUS_DOC_FileInFolder.Any());
                        }
                    }
                    if (IDs.Count > 0)
                        query = query.Where(d => d.tbl_CUS_DOC_FileInFolder.Any(c => c.IDFolder.HasValue && IDs.Contains(c.IDFolder.Value)));
                }

                var result2 = BS_CUS_DOC_File.ctoDTO(query).ToList();

                if (result2.Count > 0)
                {
                    foreach (var item in result2)
                    {
                        if (!result.Any(d => d.ID == item.ID))
                        {
                            result.Add(item);
                        }
                    }
                }
                
            }
            
            return result.AsQueryable();
        }

        [Route("MissingFile")]
        public IQueryable<DTO_CUS_DOC_File> GetMissingFile()
        {
            var result = BS_CUS_DOC_File.get_CUS_DOC_File(db, PartnerID, QueryStrings, true).ToList();
            List<DTO_CUS_DOC_File> r2 = new List<DTO_CUS_DOC_File>();

            if (QueryStrings.Any(d => d.Key == "IncludeOwner"))
            {

                var query = db.tbl_CUS_DOC_File
                .Where(d => d.IsDeleted == false && d.IDPartner == PartnerID && (d.ModifiedBy == Username || d.CreatedBy == Username));

                if (QueryStrings.Any(d => d.Key == "IDFolder"))
                {
                    var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDFolder").Value.Replace("[", "").Replace("]", "").Split(',');
                    List<int> IDs = new List<int>();
                    foreach (var item in IDList)
                    {
                        if (int.TryParse(item, out int i))
                            IDs.Add(i);
                        else if (item == "null")
                        {
                            query = query.Where(d => !d.tbl_CUS_DOC_FileInFolder.Any());
                        }
                    }
                    if (IDs.Count > 0)
                        query = query.Where(d => d.tbl_CUS_DOC_FileInFolder.Any(c => c.IDFolder.HasValue && IDs.Contains(c.IDFolder.Value)));
                }

                var result2 = BS_CUS_DOC_File.ctoDTO(query).ToList();

                if (result2.Count > 0)
                {
                    foreach (var item in result2)
                    {
                        if (!result.Any(d => d.ID == item.ID))
                        {
                            result.Add(item);
                        }
                    }
                }

            }
            string mapPath = System.Web.HttpContext.Current.Server.MapPath("~/");

            foreach (var item in result)
            {
                if ((item.Extension=="doc" || item.Extension == "docx") && !File.Exists(mapPath + item.Code))
                {
                    if (File.Exists(mapPath + item.Path))
                    {
                        r2.Add(item);
                        convertWordToPDF(mapPath + item.Path, mapPath + item.Code);
                    }
                    else
                    {
                        item.Remark = "Ko file goc";
                        r2.Add(item);
                    }
                    
                }
            }

            return r2.AsQueryable();
        }

        [Route("{id:int}", Name = "get_CUS_DOC_File")]
        [ResponseType(typeof(DTO_CUS_DOC_File))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_DOC_File tbl_CUS_DOC_File = BS_CUS_DOC_File.get_CUS_DOC_File(db, PartnerID, id, true);
            if (tbl_CUS_DOC_File == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_DOC_File);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_DOC_File tbl_CUS_DOC_File)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_DOC_File.ID)
                return BadRequest();

            //Get list staff with email can approve document
            var staffs = db.tbl_CUS_HRM_STAFF_NhanSu.Where(d => d.tbl_CUS_SYS_Role.tbl_CUS_SYS_PermissionList.Any(c => c.tbl_SYS_Form.Code == "page-approve" && c.Visible) && d.IsDeleted == false && d.Email != "" && d.IDPartner == PartnerID);

            string sendMailType = "";

            //Không có quyền duyệt mà sửa file, gửi duyệt => chờ duyệt
            if (!staffs.Any(d=>d.Email == Username) && tbl_CUS_DOC_File.ApprovedBy == "Chờ duyệt")
            {
                tbl_CUS_DOC_File.IsApproved = false;
                tbl_CUS_DOC_File.ModifiedBy = Username;
                tbl_CUS_DOC_File.ModifiedDate = DateTime.Now;
                tbl_CUS_DOC_File.ApprovedBy = "Chờ duyệt";
                sendMailType = "ApproveRequired";
            }
            //Không có quyền duyệt mà sửa file, KHÔNG gửi duyệt
            else if (!staffs.Any(d => d.Email == Username))
            {
                tbl_CUS_DOC_File.IsApproved = false;
                tbl_CUS_DOC_File.ModifiedBy = Username;
                tbl_CUS_DOC_File.ModifiedDate = DateTime.Now;
            }
            //có quyền duyệt, thực hiện duyệt file bằng cách gán IsApproved = true
            else if (tbl_CUS_DOC_File.IsApproved)
            {
                tbl_CUS_DOC_File.ModifiedBy = Username;
                tbl_CUS_DOC_File.ModifiedDate = DateTime.Now;
                tbl_CUS_DOC_File.ApprovedBy = Username;
                tbl_CUS_DOC_File.ApprovedDate = DateTime.Now;
                sendMailType = "Approved";
            }
            //có quyền duyệt trả file bằng cách gán ApprovedBy = "Không được duyệt"
            else if (tbl_CUS_DOC_File.ApprovedBy == "Không được duyệt")
            {
                tbl_CUS_DOC_File.IsApproved = false;
                tbl_CUS_DOC_File.ApprovedDate = DateTime.Now;
                sendMailType = "Denied";
            }
            //có quyền duyệt, chỉ update thông thuường
            else
            {
                //Đánh dấu không gửi mail
                tbl_CUS_DOC_File.ModifiedBy = Username;
                tbl_CUS_DOC_File.ModifiedDate = DateTime.Now;
            }

            bool resul = BS_CUS_DOC_File.put_CUS_DOC_File(db, PartnerID, id, tbl_CUS_DOC_File, Username, true);

            if (resul)
            {
                if (!string.IsNullOrEmpty(sendMailType))
                {
                    string template = "";
                    string subject = "";


                    if (sendMailType == "ApproveRequired")
                    {
                        subject = "Quản lý Đề tài Nghiên cứu khoa học - tài liệu chờ duyệt";
                        template =
                            @"
                        Xin chào <strong>@Model.ToName</strong>,
                        <br>
                        <br>Tài khoản @Model.ModifiedBy vừa cập nhật tài liệu trên hệ thống thư viện điện tử.
                        <br>Thông tin văn bản chờ duyệt:
                        <br>
                        <br><strong>Tiêu đề:</strong>
                        <br>@Model.Name
                        <br><strong>Mô tả ngắn:</strong>
                        <br>@Model.Remark
                        <br>
                        <br>Vui lòng xem các văn bản đang chờ duyệt tại
                        <br><a href='@Model.Domain'>@Model.Domain</a>
                        <br>";

                        foreach (var s in staffs)
                        {
                            var html = Engine.Razor.RunCompile(template, "File_ApproveRequired", null, new
                            {
                                ToName = s.Name,
                                ModifiedBy = Username,
                                Name = tbl_CUS_DOC_File.Name,
                                Remark = tbl_CUS_DOC_File.Remark,
                                Domain = "http://myduc.appcenter.vn:9003/#/approve"
                            });

                            EmailService emailService = new EmailService();
                            //emailService.Send(new IdentityMessage() { Subject = subject, Destination = s.Email, Body = html });
                        }

                    }
                    else if (sendMailType == "Approved")
                    {
                        subject = "Quản lý Đề tài Nghiên cứu khoa học - đã duyệt tài liệu (" + tbl_CUS_DOC_File.Name + ")";
                        template =
                            @"
                        Xin chào <strong>@Model.ToName</strong>,
                        <br>
                        <br>Tài liệu <span style='color: green'>ĐÃ ĐƯỢC DUYỆT</span> trên hệ thống thư viện điện tử.
                        <br>Thông tin tài liệu:
                        <br>
                        <br><strong>Tiêu đề:</strong>
                        <br>@Model.Name
                        <br><strong>Mô tả ngắn:</strong>
                        <br>@Model.Remark
                        <br>
                        <br>Vui lòng xem các văn bản tại
                        <br><a href='@Model.Domain'>@Model.Domain</a>
                        <br>";

                        var s = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(d => d.Email == tbl_CUS_DOC_File.ModifiedBy);
                        if (s != null)
                        {
                            var html = Engine.Razor.RunCompile(template, "File_Approved", null, new
                            {
                                ToName = s.Name,

                                Name = tbl_CUS_DOC_File.Name,
                                Remark = tbl_CUS_DOC_File.Remark,
                                Domain = "http://myduc.appcenter.vn:9003/#/sops"
                            });

                            EmailService emailService = new EmailService();
                            //emailService.Send(new IdentityMessage() { Subject = subject, Destination = s.Email, Body = html });
                        }



                    }
                    else if (sendMailType == "Denied")
                    {
                        subject = "Quản lý Đề tài Nghiên cứu khoa học - TỪ CHỐI duyệt tài liệu (" + tbl_CUS_DOC_File.Name + ")";
                        template =
                            @"
                        Xin chào <strong>@Model.ToName</strong>,
                        <br>
                        <br>Tài liệu đã <span style='color: red'>BỊ TỪ CHỐI DUYỆT</span> trên hệ thống thư viện điện tử.
                        <br>Thông tin văn bản chờ duyệt:
                        <br>
                        <br><strong>Tiêu đề:</strong>
                        <br>@Model.Name
                        <br><strong>Mô tả ngắn:</strong>
                        <br>@Model.Remark
                        <br>
                        <br>Vui lòng xem lại các văn bản tại
                        <br><a href='@Model.Domain'>@Model.Domain</a>
                        <br>";

                        var s = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(d => d.Email == tbl_CUS_DOC_File.ModifiedBy);
                        if (s != null)
                        {
                            var html = Engine.Razor.RunCompile(template, "File_Denied", null, new
                            {
                                ToName = s.Name,

                                Name = tbl_CUS_DOC_File.Name,
                                Remark = tbl_CUS_DOC_File.Remark,
                                Domain = "http://myduc.appcenter.vn:9003/#/sops"
                            });

                            EmailService emailService = new EmailService();
                            //emailService.Send(new IdentityMessage() { Subject = subject, Destination = s.Email, Body = html });
                        }
                    }
                }
                
                return StatusCode(HttpStatusCode.NoContent);
            }
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_DOC_File))]
        public IHttpActionResult Post(DTO_CUS_DOC_File tbl_CUS_DOC_File)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_DOC_File result = BS_CUS_DOC_File.post_CUS_DOC_File(db, PartnerID, tbl_CUS_DOC_File, Username, true);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_DOC_File", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_DOC_File))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_DOC_File.check_CUS_DOC_File_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_DOC_File.delete_CUS_DOC_File(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
				return Conflict();

        }

        [Route("FileUpload/{id:int}")]
        public IHttpActionResult Post_FileUpload(int id)
        {
            var httpRequest = System.Web.HttpContext.Current.Request;
            if (httpRequest.Files.Count < 1)
            {
                return BadRequest(ModelState);
            }

            DTO_CUS_DOC_File result = null;
            DTO_CUS_DOC_File item = new DTO_CUS_DOC_File();

            foreach (string file in httpRequest.Files)
            {
                #region upload file
                var postedFile = httpRequest.Files[file];



                string uploadPath = "/Uploads/DOCs/" + DateTime.Today.ToString("yyyy/MM/dd").Replace("-", "/");

                
                string oldName = System.IO.Path.GetFileName(postedFile.FileName);
                string ext = oldName.Substring(oldName.LastIndexOf('.') + 1).ToLower();

                var g = Guid.NewGuid();
                string fileid = g.ToString();
                string fileName = "" + fileid + "." + oldName;
                string viewName = "" + fileid + ".pdf";

                string mapPath = System.Web.HttpContext.Current.Server.MapPath("~/");
                string strDirectoryPath = mapPath + uploadPath;
                string strFilePath = strDirectoryPath + "/" + fileName;
                string viewFilePath = strDirectoryPath + "/" + viewName;

                System.IO.FileInfo existingFile = new System.IO.FileInfo(strFilePath);

                if (!System.IO.Directory.Exists(strDirectoryPath))
                    System.IO.Directory.CreateDirectory(strDirectoryPath);
                if (existingFile.Exists)
                {
                    existingFile.Delete();
                    existingFile = new System.IO.FileInfo(strFilePath);
                }

                postedFile.SaveAs(strFilePath);

                switch (ext)
                {
                    case "doc":
                    case "docx":
                        convertWordToPDF(strFilePath, viewFilePath);
                        break;

                    case "xls":
                    case "xlsx":
                        convertExcelToPDF(strFilePath, viewFilePath);
                        break;

                    case "ppt":
                    case "pptx":
                        convertPowerpointToPDF(strFilePath, viewFilePath);
                        break;
                        
                    default:
                        viewName = fileName;
                        break;
                }

                #endregion


                if (id == 0)
                {
                    item.Name = "";
                    item.IDPartner = 1;
                    item.Code = uploadPath + "/" + viewName;
                    item.IsDeleted = true;
                    item.Path = uploadPath + "/" + fileName;
                    item.Extension = System.IO.Path.GetExtension(strFilePath).Replace(".", "");
                    item.FileSize = new System.IO.FileInfo(strFilePath).Length;

                    result = BS_CUS_DOC_File.post_CUS_DOC_File(db, PartnerID, item, Username, true);
                }
                else
                {
                    item.ID = id;
                    item.IDPartner = 1;
                    item.Code = uploadPath + "/" + viewName;
                    item.Path = uploadPath + "/" + fileName;
                    item.Extension = System.IO.Path.GetExtension(strFilePath).Replace(".", "");
                    item.FileSize = new System.IO.FileInfo(strFilePath).Length;
                    
                    result = item;


                    //var doc = db.tbl_CUS_DOC_File.Find(id);
                    //if (doc!=null)
                    //{
                    //    doc.Code = item.Code = uploadPath + "/" + viewName;
                    //    doc.Path = item.Path = uploadPath + fileName;
                    //    doc.Extension = item.Extension = System.IO.Path.GetExtension(strFilePath).Replace(".", "");
                    //    doc.FileSize = item.FileSize = new System.IO.FileInfo(strFilePath).Length;
                    //    item.ID = id;
                    //    result = item;
                    //    db.SaveChanges();
                    //}
                    //else
                    //{
                    //    return NotFound();
                    //}
                }
                
            }

            
            if (result != null)
            {
                return CreatedAtRoute("get_CUS_DOC_File", new { id = result.ID }, result);
            }
            return Conflict();

            
        }

        [Route("RPT_FileInFolder")]
        public List<DTO_CUS_DOC_RPT_Folder> GetRTPFileInFolder()
        {
            return BS_CUS_DOC_Folder.RPT_FileInFolder(db, PartnerID, QueryStrings);
        }

        //api/CUS/DOC/File/RPT_FileByType
        [Route("RPT_FileByType")]
        public List<DTO_CUS_DOC_RPT_FileExtention> GetRPTFileByType()
        {
            return BS_CUS_DOC_Folder.RPT_FileByType(db, PartnerID, QueryStrings);
        }

        [HttpPost]
        [Route("DocumentEditor/Import/{id:int}")]
        public HttpResponseMessage Import(int id)
        {

            DTO_CUS_DOC_File tbl_CUS_DOC_File = BS_CUS_DOC_File.get_CUS_DOC_File(db, PartnerID, id, true);
            if (tbl_CUS_DOC_File == null || !(tbl_CUS_DOC_File.Extension == "docx" || tbl_CUS_DOC_File.Extension == "doc"))
            {
                return null;
            }
            
            string path = System.Web.HttpContext.Current.Server.MapPath("~") + tbl_CUS_DOC_File.Path;
            string json = "";

            System.IO.FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                Stream stream = File.OpenRead(path);
                Syncfusion.EJ2.DocumentEditor.WordDocument document = Syncfusion.EJ2.DocumentEditor.WordDocument.Load(stream, GetFormatType("." + tbl_CUS_DOC_File.Extension.ToLower()));
                json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
                // Releases unmanaged and optionally managed resources.
                document.Dispose();
                stream.Close();
            }


            return new HttpResponseMessage() { Content = new StringContent(json, System.Text.Encoding.UTF8, "text/plain") };
        }

        [HttpPost]
        [Route("DocumentEditor/Save/{id:int}")]
        public void Save(int id)
        {
            DTO_CUS_DOC_File item = BS_CUS_DOC_File.get_CUS_DOC_File(db, PartnerID, id, true);
            if (item == null)
            {
                return;
            }

            string path = System.Web.HttpContext.Current.Server.MapPath("~");

            item.ModifiedDate = DateTime.Now;
            string version = ".V" + item.ModifiedDate.ToString("yyMMdd-HHmmss");

            int index = item.Path.LastIndexOf(".V") == -1 ? item.Path.LastIndexOf(".") : item.Path.LastIndexOf(".V");
            string fileID = item.Path.Substring(0, index);

            string newFilePath = fileID + version + ".docx";
            string pdfFIlePath = fileID + version + ".pdf";

            System.Web.HttpPostedFile file = System.Web.HttpContext.Current.Request.Files[0];
            Syncfusion.DocIO.DLS.WordDocument document = new Syncfusion.DocIO.DLS.WordDocument(file.InputStream);

            document.Save(path + newFilePath);
            document.Close();

            convertWordToPDF(path + newFilePath, path + pdfFIlePath);

            item.ModifiedBy = Username;
            

            item.Code = pdfFIlePath;
            item.Path = newFilePath;
            item.Extension = "docx";
            item.FileSize = new System.IO.FileInfo(path + newFilePath).Length;

            Put(id, item);

        }

        [HttpPost]
        [Route("DocumentEditor/SaveSFDT/{id:int}")]
        public void SaveSFDT(int id)
        {
            DTO_CUS_DOC_File item = BS_CUS_DOC_File.get_CUS_DOC_File(db, PartnerID, id, true);
            if (item == null)
            {
                return;
            }

            string path = System.Web.HttpContext.Current.Server.MapPath("~");

            item.ModifiedDate = DateTime.Now;
            string version = ".V" + item.ModifiedDate.ToString("yyMMdd-HHmmss");

            int index = item.Path.LastIndexOf(".V") == -1 ? item.Path.LastIndexOf(".") : item.Path.LastIndexOf(".V");
            string fileID = item.Path.Substring(0, index);

            string newFilePath = fileID + version + ".docx";
            string pdfFIlePath = fileID + version + ".pdf";

            System.Web.HttpPostedFile file = System.Web.HttpContext.Current.Request.Files[0];
            Syncfusion.DocIO.DLS.WordDocument document = new Syncfusion.DocIO.DLS.WordDocument(file.InputStream);

            document.Save(path + newFilePath);
            document.Close();

            convertWordToPDF(path + newFilePath, path + pdfFIlePath);

            item.ModifiedBy = Username;


            item.Code = pdfFIlePath;
            item.Path = newFilePath;
            item.Extension = "docx";
            item.FileSize = new System.IO.FileInfo(path + newFilePath).Length;

            Put(id, item);

        }





        #region convert files to pdf

        bool convertExcelToPDF(string source, string destination)
        {
            ExcelToPdfConverter converter = new ExcelToPdfConverter(source);
            converter.ChartToImageConverter = new Syncfusion.ExcelChartToImageConverter.ChartToImageConverter();
            //Set the image quality
            converter.ChartToImageConverter.ScalingMode = Syncfusion.XlsIO.ScalingMode.Best;
            //Intialize the PdfDocument Class
            PdfDocument pdfDoc = new PdfDocument();

            //Intialize the ExcelToPdfConverterSettings class
            ExcelToPdfConverterSettings settings = new ExcelToPdfConverterSettings();

            //Set the Layout Options for the output Pdf page.
            //if (Group1 == "NoScaling")
            //    settings.LayoutOptions = LayoutOptions.NoScaling;
            //else if (Group1 == "FitAllRowsOnOnePage")
            //    settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
            //else if (Group1 == "FitAllColumnsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
            //else
            //    settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

            //Assign the output PdfDocument to the TemplateDocument property of ExcelToPdfConverterSettings 
            pdfDoc.PageSettings.Orientation = PdfPageOrientation.Landscape;
            settings.TemplateDocument = pdfDoc;
            settings.DisplayGridLines = GridLinesDisplayStyle.Invisible;
            //Convert the Excel document to PDf
            pdfDoc = converter.Convert(settings);
            try
            {
                pdfDoc.Save(destination);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {

            }
            return true;
        }
        bool convertWordToPDF(string source, string destination)
        {
            WordDocument document = new WordDocument(source);

            //Initialize chart to image converter for converting charts in Word to PDF conversion
            document.ChartToImageConverter = new ChartToImageConverter();
            document.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Normal;

            DocToPDFConverter converter = new DocToPDFConverter();
            //Enable Direct PDF rendering mode for faster conversion.
            //if (renderingMode == "DirectPDF")
            //    converter.Settings.EnableFastRendering = true;
            //if (renderingMode1 == "PreserveStructureTags")
            //    converter.Settings.AutoTag = true;
            //if (renderingMode2 == "PreserveFormFields")
            //    converter.Settings.PreserveFormFields = true;
            //converter.Settings.ExportBookmarks = 
                //renderingMode3 == "PreserveWordHeadingsToPDFBookmarks"
                //? 
                //Syncfusion.DocIO.ExportBookmarkType.Headings
                //: 
            //    Syncfusion.DocIO.ExportBookmarkType.Bookmarks;
            //if (renderingMode4 == "EnablesCompleteFont")
            //    converter.Settings.EmbedCompleteFonts = true;
            //if (renderingMode5 == "EnablesSubsetFont")
            //    converter.Settings.EmbedFonts = true;
            //Convert word document into PDF document
            
            
            try
            {
                PdfDocument pdfDoc = converter.ConvertToPDF(document);
                pdfDoc.Save(destination);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

            }
            return true;
        }
        bool convertPowerpointToPDF(string source, string destination)
        {
            try
            {

                IPresentation presentation = Presentation.Open(source);

                //Creates an instance of ChartToImageConverter and assigns it to ChartToImageConverter property of Presentation
                presentation.ChartToImageConverter = new ChartToImageConverter();

                //Sets the scaling mode of the chart to best.
                presentation.ChartToImageConverter.ScalingMode = ScalingMode.Best;

                //Instantiates the Presentation to pdf converter settings instance.
                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();

                //Sets the option for adding hidden slides to converted pdf
                settings.ShowHiddenSlides = false;

                //Sets the slide per page settings; this is optional.
                settings.SlidesPerPage = SlidesPerPage.One;
                settings.EnablePortableRendering = true;
                //Sets the settings to enable notes pages while conversion.
                settings.PublishOptions = PublishOptions.Slides;

                //Converts the PowerPoint Presentation into PDF document
                PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation, settings);

                //Saves the PDF document
                pdfDocument.Save(destination);

                //Closes the PDF document
                pdfDocument.Close(true);

                //Closes the Presentation
                presentation.Close();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {

            }
            
        }

        internal static Syncfusion.EJ2.DocumentEditor.FormatType GetFormatType(string format)
        {
            if (string.IsNullOrEmpty(format))
                throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
            switch (format.ToLower())
            {
                case ".dotx":
                case ".docx":
                case ".docm":
                case ".dotm":
                    return Syncfusion.EJ2.DocumentEditor.FormatType.Docx;
                case ".dot":
                case ".doc":
                    return Syncfusion.EJ2.DocumentEditor.FormatType.Doc;
                case ".rtf":
                    return Syncfusion.EJ2.DocumentEditor.FormatType.Rtf;
                case ".txt":
                    return Syncfusion.EJ2.DocumentEditor.FormatType.Txt;
                case ".xml":
                    return Syncfusion.EJ2.DocumentEditor.FormatType.WordML;
                default:
                    throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
            }
        }
        #endregion
    }
}


//API info
/*






*/