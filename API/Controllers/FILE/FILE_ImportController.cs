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
using System.Web;
using OfficeOpenXml;
using System.IO;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Web.Http.Cors;

namespace API.Controllers.FILE
{
    [RoutePrefix("api/FILE/Import")]
    public partial class FILE_ImportController : CustomApiController
    {
        #region NhatKyLamViec

        [Route("NhatKyLamViec")]
        public HttpResponseMessage Post_NhatKyLamViec()
        {
            string fileurl = "";
            var package = SaveImportedFile(out fileurl);
            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                ExcelWorksheet ws = workBook.Worksheets.FirstOrDefault();
                bool haveError = false;
                List<DTO_CUS_VANTAI_WO_NhatKyLamViec> sheet1Data = readWorksheet(ws, ref haveError);
                if (haveError)
                {
                    package.Save();
                    return downloadFile(fileurl, HttpStatusCode.Conflict);
                }
                BS_CUS_VANTAI_WO_NhatKyLamViec.ProcessNhatKyLamViec(db, PartnerID, sheet1Data, Username);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return Request.CreateResponse(HttpStatusCode.Created);

            //var httpRequest = HttpContext.Current.Request;
            //if (httpRequest.Files.Count < 1)
            //{
            //    return Request.CreateResponse(HttpStatusCode.BadRequest);
            //}
            //foreach (string file in httpRequest.Files)
            //{
            //    #region upload file
            //    var postedFile = httpRequest.Files[file];
            //    //var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);
            //    // NOTE: To store in memory use postedFile.InputStream

            //    string mapPath = HttpContext.Current.Server.MapPath("~/");
            //    string fileName = "Validate_" + Path.GetFileName(postedFile.FileName);
            //    string uploadPath = "/Uploads/" + DateTime.Today.ToString("yyyy/MM/dd").Replace("-", "/");
            //    string strDirectoryPath = mapPath + uploadPath;
            //    string strFilePath = strDirectoryPath + "/" + fileName;
            //    FileInfo existingFile = new FileInfo(strFilePath);

            //    if (!System.IO.Directory.Exists(strDirectoryPath))
            //        System.IO.Directory.CreateDirectory(strDirectoryPath);
            //    if (existingFile.Exists)
            //    {
            //        existingFile.Delete();
            //        existingFile = new FileInfo(strFilePath);
            //    }

            //    postedFile.SaveAs(strFilePath);
            //    #endregion

            //    using (var package = new ExcelPackage(existingFile))
            //    {
            //        ExcelWorkbook workBook = package.Workbook;
            //        var stream = new MemoryStream();
            //        if (workBook != null)
            //        {

            //            ExcelWorksheet ws = workBook.Worksheets.FirstOrDefault();

            //            bool haveError = false;
            //            List<DTO_CUS_VANTAI_WO_NhatKyLamViec> sheet1Data = readWorksheet(ws, ref haveError);
            //            if (haveError)
            //            {
            //                package.Save();
            //                stream = new MemoryStream(package.GetAsByteArray());
            //                var fileurl = uploadPath +"/"+ fileName;

            //                HttpResponseMessage response;
            //                response = Request.CreateResponse(HttpStatusCode.Conflict);
            //                response.Content = new StringContent(fileurl);
            //                return response;

            //            }
            //            BS_CUS_VANTAI_WO_NhatKyLamViec.ProcessNhatKyLamViec(db, PartnerID, sheet1Data, Username);

            //        }
            //    }

            //}

            //return Request.CreateResponse(HttpStatusCode.Created);
            ////http://www.c-sharpcorner.com/UploadFile/2b481f/uploading-a-file-in-Asp-Net-web-api/l
        }

        [Route("NhatKyLamViec")]
        public HttpResponseMessage Get_NhatKyLamViec()
        {
            string fileurl = "";
            var package = GetTemplateWorkbook("nhat-ky-lam-viec-template.xlsx", "NhatTrinh.xlsx", out fileurl);

            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                AddListData(workBook.Worksheets["DS"]);
                AddRows(workBook.Worksheets.FirstOrDefault());

                package.Save();
            }

            return downloadFile(fileurl);


            //string templateFilePath = "Uploads/FileTemplate/nhat-ky-lam-viec-template.xlsx";
            //string fileName = "NhatKyLamViec.xlsx";
            //string mapPath = HttpContext.Current.Server.MapPath("~/");
            //string uploadPath = "/Uploads/" + DateTime.Today.ToString("yyyy/MM/dd").Replace("-", "/");
            //string strDirectoryPath = mapPath + uploadPath;
            //string strFilePath = strDirectoryPath + "/" + fileName;
            //string fileurl = uploadPath +"/" + fileName;
            ////var stream = new MemoryStream();

            //FileInfo exportFile = new FileInfo(strFilePath);

            //if (!System.IO.Directory.Exists(strDirectoryPath))
            //    System.IO.Directory.CreateDirectory(strDirectoryPath);

            //if (exportFile.Exists)
            //{
            //    exportFile.Delete();
            //    exportFile = new FileInfo(strFilePath);
            //}

            //FileInfo templateFile = new FileInfo(mapPath + templateFilePath);
            //using (var package = new ExcelPackage(templateFile))
            //{
            //    ExcelWorkbook workBook = package.Workbook;
            //    if (workBook != null)
            //    {
            //        AddListData(workBook.Worksheets["DS"]);
            //        AddRows(workBook.Worksheets.FirstOrDefault());

            //        package.SaveAs(exportFile);
            //    }
            //    //stream = new MemoryStream(package.GetAsByteArray());
            //}

            //HttpResponseMessage response;
            //response = Request.CreateResponse(HttpStatusCode.OK);
            //response.Content = new StringContent(fileurl);

            //return response;

            ////HttpResponseMessage response;
            ////response = Request.CreateResponse(HttpStatusCode.OK);
            ////MediaTypeHeaderValue mediaType = new MediaTypeHeaderValue("application/octet-stream");
            ////response.Content = new StreamContent(stream);
            ////response.Content.Headers.ContentType = mediaType;
            ////response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            ////response.Content.Headers.ContentDisposition.FileName = fileName;
            ////return response;

        }

        #endregion
        

        #region KhachHang

        [Route("KhachHang")]
        public HttpResponseMessage Get_KhachHang()
        {
            string fileurl = "";
            var package = GetTemplateWorkbook("DS-KhachHang.xlsx", "DS-KhachHang.xlsx", out fileurl);

            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                var ws = workBook.Worksheets.FirstOrDefault(); //Worksheets["DS"];
                var data = BS_CUS_CRM_CONTACT_KhachHang.get_CUS_CRM_CONTACT_KhachHang(db, PartnerID, QueryStrings);

                int rowid = 3;
                foreach (var item in data)
                {
                    ws.Cells["B" + rowid].Value = item.Sort;  //STT
                    ws.Cells["C" + rowid].Value = item.Code;
                    ws.Cells["D" + rowid].Value = item.Name;
                    ws.Cells["E" + rowid].Value = item.MaSoThue;
                    ws.Cells["F" + rowid].Value = item.SoDienThoai1;
                    ws.Cells["G" + rowid].Value = item.SoDienThoai2;
                    ws.Cells["H" + rowid].Value = item.Fax; //6
                    ws.Cells["I" + rowid].Value = item.Email;
                    ws.Cells["J" + rowid].Value = item.Website;
                    ws.Cells["K" + rowid].Value = item.DiaChi;
                    ws.Cells["L" + rowid].Value = item.IDQuanHuyen;//10
                    ws.Cells["M" + rowid].Value = item.IDTinhThanh;
                    ws.Cells["N" + rowid].Value = item.IDNhanSuChamSoc;
                    ws.Cells["O" + rowid].Value = item.Remark;//13
                    ws.Cells["P" + rowid].Value = item.IDLoaiKhachHang;
                    ws.Cells["Q" + rowid].Value = item.IDLinhVucKinhDoanh;
                    ws.Cells["R" + rowid].Value = item.IDQuyMoDoanhThu;
                    ws.Cells["S" + rowid].Value = item.IDQuyMoDoanhNghiep;
                    ws.Cells["T" + rowid].Value = item.SanPhamDichVu;
                    ws.Cells["U" + rowid].Value = item.BackgroundColor;//19

                    ws.Cells["V" + rowid].Value = item.IsDeleted;
                    ws.Cells["W" + rowid].Value = item.CreatedBy;
                    ws.Cells["X" + rowid].Value = item.CreatedDate;
                    ws.Cells["Y" + rowid].Value = item.ModifiedBy;
                    ws.Cells["Z" + rowid].Value = item.ModifiedDate;


                    rowid++;
                }

                package.Save();
            }

            return downloadFile(fileurl);
        }


        [Route("KhachHang")]
        public HttpResponseMessage Post_KhachHang()
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

                    if (row[1] == "") //check code null
                        continue;

                    string code = row[1];
                    DTO_CUS_CRM_CONTACT_KhachHang dbitem = BS_CUS_CRM_CONTACT_KhachHang.get_CUS_CRM_CONTACT_KhachHang(db, PartnerID, code);
                    if (dbitem == null)
                        dbitem = new DTO_CUS_CRM_CONTACT_KhachHang();

                    if (int.TryParse(row[0], out int sort))
                        dbitem.Sort = sort;

                    dbitem.Code = row[1];
                    dbitem.Name = row[2];

                    dbitem.MaSoThue = row[3];
                    dbitem.SoDienThoai1 = row[4];
                    dbitem.SoDienThoai2 = row[5];

                    dbitem.Fax = row[6];
                    dbitem.Email = row[7];
                    dbitem.Website = row[8];

                    dbitem.DiaChi = row[9];
                    dbitem.Remark = row[13];
                    dbitem.BackgroundColor = string.IsNullOrEmpty(row[19]) ? "#333" : row[19];

                    try
                    {
                        if (dbitem.ID != 0)
                        {
                            BS_CUS_CRM_CONTACT_KhachHang.put_CUS_CRM_CONTACT_KhachHang(db, PartnerID, dbitem.ID, dbitem, Username);
                        }
                        else
                        {
                            BS_CUS_CRM_CONTACT_KhachHang.post_CUS_CRM_CONTACT_KhachHang(db, PartnerID, dbitem, Username);
                        }
                    }
                    catch (Exception ex)
                    {
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


        #region PhuongTien

        [Route("PhuongTien")]
        public HttpResponseMessage Get_PhuongTien()
        {
            string fileurl = "";
            var package = GetTemplateWorkbook("DS-Xe.xlsx", "DS-Xe.xlsx", out fileurl);

            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                var ws = workBook.Worksheets.FirstOrDefault(); //Worksheets["DS"];
                var data = BS_CUS_VANTAI_CONF_PhuongTien.get_CUS_VANTAI_CONF_PhuongTien(db, PartnerID, QueryStrings);

                int rowid = 3;
                foreach (var item in data)
                {
                    ws.Cells["B" + rowid].Value = item.Sort; //STT
                    ws.Cells["C" + rowid].Value = item.Code;
                    ws.Cells["D" + rowid].Value = item.Name;


                    DTO_CUS_CRM_CONTRACT_NhomGiaPhuongTien nhomGia = BS_CUS_CRM_CONTRACT_NhomGiaPhuongTien.get_CUS_CRM_CONTRACT_NhomGiaPhuongTien(db, PartnerID, item.IDNhomGiaPhuongTien);
                    if (nhomGia != null)
                    {
                        ws.Cells["E" + rowid].Value = nhomGia.Code;
                    }
                    
                    ws.Cells["F" + rowid].Value = item.ChuXe;
                    ws.Cells["G" + rowid].Value = item.TriGia;
                    ws.Cells["H" + rowid].Value = item.TiLe;

                    if (item.NgayMua.HasValue)
                        ws.Cells["I" + rowid].Value = item.NgayMua.Value.ToOADate();
                    if (item.NgayKiemDinh.HasValue)
                        ws.Cells["J" + rowid].Value = item.NgayKiemDinh.Value.ToOADate();
                    if (item.NgayHetHan.HasValue)
                        ws.Cells["K" + rowid].Value = item.NgayHetHan.Value.ToOADate();
                    ws.Cells["L" + rowid].Value = item.Remark;

                    rowid++;
                }

                package.Save();
            }

            return downloadFile(fileurl);
        }


        [Route("PhuongTien")]
        public HttpResponseMessage Post_PhuongTien()
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
                        row.Add(ws.Cells[rowid, i].Value == null ? "" : ws.Cells[rowid, i].Value.ToString());

                    if (row[1] == "") //check code null
                        continue;

                    string code = row[1];
                    DTO_CUS_VANTAI_CONF_PhuongTien dbitem = BS_CUS_VANTAI_CONF_PhuongTien.get_CUS_VANTAI_CONF_PhuongTien(db, PartnerID, code);
                    if (dbitem == null)
                    {
                        dbitem = new DTO_CUS_VANTAI_CONF_PhuongTien();
                        dbitem.IDLoaiPhuongTien = 1;
                    }

                    if(int.TryParse(row[0], out int sort))
                        dbitem.Sort = sort;
                    dbitem.Code = row[1];
                    dbitem.Name = row[2];

                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        DTO_CUS_CRM_CONTRACT_NhomGiaPhuongTien nhomGia = BS_CUS_CRM_CONTRACT_NhomGiaPhuongTien.get_CUS_CRM_CONTRACT_NhomGiaPhuongTien(db, PartnerID, row[3]);
                        if (nhomGia != null)
                        {
                            dbitem.IDNhomGiaPhuongTien = nhomGia.ID;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    
                    dbitem.ChuXe = row[4];


                    dbitem.TriGia = string.IsNullOrEmpty(row[5]) ? 0 : double.Parse(row[5]);

                    dbitem.TiLe = string.IsNullOrEmpty(row[6]) ? 1 : double.Parse(row[6]);

                    if (double.TryParse(row[7], out double d))
                    {
                        dbitem.NgayMua = DateTime.FromOADate(d);
                    }

                    if (double.TryParse(row[8], out double d2))
                    {
                        dbitem.NgayKiemDinh = DateTime.FromOADate(d2);
                    }

                    if (double.TryParse(row[9], out double d3))
                    {
                        dbitem.NgayHetHan = DateTime.FromOADate(d3);
                    }
                    
                    dbitem.Remark = row[10];

                    try
                    {
                        if (dbitem.ID != 0)
                        {
                            BS_CUS_VANTAI_CONF_PhuongTien.put_CUS_VANTAI_CONF_PhuongTien(db, PartnerID, dbitem.ID, dbitem, Username);
                        }
                        else
                        {
                            BS_CUS_VANTAI_CONF_PhuongTien.post_CUS_VANTAI_CONF_PhuongTien(db, PartnerID, dbitem, Username);
                        }
                    }
                    catch (Exception ex)
                    {
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
                    ws.Cells["D" + rowid].Value = item.TenDayDu;

                    if (item.IDChucDanh.HasValue)
                    {
                        var chucDanh = BS_CUS_HRM_LIST_ChucDanh.get_CUS_HRM_LIST_ChucDanh(db, PartnerID, item.IDChucDanh.Value);
                        if (chucDanh != null)
                        {
                            ws.Cells["E" + rowid].Value = chucDanh.Code;
                            ws.Cells["F" + rowid].Value = chucDanh.Name;
                        }
                    }
                    
                    ws.Cells["G" + rowid].Value = item.SoXe;
                    ws.Cells["H" + rowid].Value = item.NgaySinh;
                    ws.Cells["I" + rowid].Value = item.NguyenQuan;
                    ws.Cells["J" + rowid].Value = item.ThuongTru;
                    ws.Cells["K" + rowid].Value = item.CMND;
                    ws.Cells["L" + rowid].Value = item.NgayCap;
                    ws.Cells["M" + rowid].Value = item.IsDisabled;

                    rowid++;
                }

                package.Save();
            }

            return downloadFile(fileurl);
        }


        [Route("NhanSu")]
        public HttpResponseMessage Post_NhanSu()
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

                    if (row[1] == "") //check code null
                        continue;


                    string code = row[1];
                    var dbitem = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, code);
                    if (dbitem == null)
                        dbitem = new DTO_CUS_HRM_STAFF_NhanSu();

                    if (int.TryParse(row[0], out int sort))
                        dbitem.Sort = sort;

                    dbitem.Code = row[1];
                    dbitem.TenDayDu = row[2];

                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        var chucDanh = BS_CUS_HRM_LIST_ChucDanh.get_CUS_HRM_LIST_ChucDanh(db, PartnerID, row[3]);
                        if (chucDanh != null)
                        {
                            dbitem.IDChucDanh = chucDanh.ID;
                        }
                        else
                        {
                            
                        }
                    }

                    dbitem.SoXe = row[5];

                    dbitem.NgaySinh = row[6];
                    dbitem.NguyenQuan = row[7];
                    dbitem.ThuongTru = row[8];

                    dbitem.CMND = row[9];
                    dbitem.NgayCap = row[10];

                    if (row[11]=="1")
                    {
                        dbitem.IsDisabled = true;
                    }



                    //STT Mã nhân viên    Họ và tên Mã công việc    Công việc   5 Xe Ngày sinh 7Nguyên quán Địa chỉ thường trú CMND    Ngày cấp    Đã nghỉ việc



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
                    }
                    catch (Exception ex)
                    {
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


        #region DS-BangGiaChung

        [Route("BangGiaChung")]
        public HttpResponseMessage Get_BangGiaChung()
        {
            string fileurl = "";
            var package = GetTemplateWorkbook("DS-BangGiaChung.xlsx", "BangGiaChung.xlsx", out fileurl);

            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                var ws = workBook.Worksheets.FirstOrDefault(); //Worksheets["DS"];
                var data = BS_CUS_CRM_CONTRACT_NhomGiaPhuongTien.get_CUS_CRM_CONTRACT_NhomGiaPhuongTien(db, PartnerID, QueryStrings);
                var gialist = BS_CUS_CRM_CONTRACT_BangGia.get_CUS_CRM_CONTRACT_BangGia(db, PartnerID, QueryStrings);

                int rowid = 3;
                foreach (var item in data)
                {
                    ws.Cells["B" + rowid].Value = item.Sort; //STT
                    ws.Cells["C" + rowid].Value = item.Code;
                    ws.Cells["D" + rowid].Value = item.Name;

                    var gia = gialist.FirstOrDefault(d => d.IDNhomGiaPhuongTien == item.ID);
                    if (gia != null)
                    {
                        ws.Cells["E" + rowid].Value = gia.SoGioQuyDinhCa;
                        ws.Cells["F" + rowid].Value = gia.DonGiaCa;
                        ws.Cells["G" + rowid].Value = gia.DonGiaTangCa;
                        ws.Cells["H" + rowid].Formula = string.Format("F{0}*G{0}", rowid);
                        ws.Cells["I" + rowid].Value = gia.DonGiaNgayLe;
                        ws.Cells["J" + rowid].Formula = string.Format("F{0}*I{0}", rowid);
                        
                    }
                    
                    rowid++;
                }

                package.Save();
            }

            return downloadFile(fileurl);
        }


        [Route("BangGiaChung")]
        public HttpResponseMessage Post_BangGiaChung()
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

                var gialist = BS_CUS_CRM_CONTRACT_BangGia.get_CUS_CRM_CONTRACT_BangGia(db, PartnerID, QueryStrings);

                for (int rowid = 3; rowid <= SheetRowCount; rowid++)
                {
                    #region item
                    List<string> row = new List<string>();

                    for (int i = 2; i <= SheetColumnsCount; i++)
                        row.Add(ws.Cells[rowid, i].Value == null ? "" : ws.Cells[rowid, i].Value.ToString());

                    if (row[1] == "") //check code null
                        continue;

                    string code = row[1];
                    var dbitem = BS_CUS_CRM_CONTRACT_NhomGiaPhuongTien.get_CUS_CRM_CONTRACT_NhomGiaPhuongTien(db, PartnerID, code);
                    if (dbitem == null)
                        dbitem = new DTO_CUS_CRM_CONTRACT_NhomGiaPhuongTien();

                    if (int.TryParse(row[0], out int sort))
                        dbitem.Sort = sort;

                    dbitem.Code = row[1];
                    dbitem.Name = row[2];
                    
                    try
                    {
                        if (dbitem.ID != 0)
                        {
                            BS_CUS_CRM_CONTRACT_NhomGiaPhuongTien.put_CUS_CRM_CONTRACT_NhomGiaPhuongTien(db, PartnerID, dbitem.ID, dbitem, Username);
                        }
                        else
                        {
                            BS_CUS_CRM_CONTRACT_NhomGiaPhuongTien.post_CUS_CRM_CONTRACT_NhomGiaPhuongTien(db, PartnerID, dbitem, Username);
                        }

                        //Save gia

                        var gia = gialist.FirstOrDefault(d => d.IDNhomGiaPhuongTien == dbitem.ID);
                        if (gia == null)
                        {
                            gia = new DTO_CUS_CRM_CONTRACT_BangGia();
                            gia.IDNhomGiaPhuongTien = dbitem.ID;
                        }

                        if (decimal.TryParse(row[3], out decimal sogioca))
                            gia.SoGioQuyDinhCa = sogioca;

                        if (decimal.TryParse(row[4], out decimal dongia))
                            gia.DonGiaCa = dongia;

                        if (decimal.TryParse(row[5], out decimal tangca))
                            gia.DonGiaTangCa = tangca;

                        if (decimal.TryParse(row[7], out decimal ngayle))
                            gia.DonGiaNgayLe = ngayle;




                        if (gia.ID != 0)
                        {
                            BS_CUS_CRM_CONTRACT_BangGia.put_CUS_CRM_CONTRACT_BangGia(db, PartnerID, gia.ID, gia, Username);
                        }
                        else
                        {
                            BS_CUS_CRM_CONTRACT_BangGia.post_CUS_CRM_CONTRACT_BangGia(db, PartnerID, gia, Username);
                        }

                    }
                    catch (Exception ex)
                    {
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


        #region QuanHuyen

        [Route("QuanHuyen")]
        public HttpResponseMessage Get_QuanHuyen()
        {
            string fileurl = "";
            var package = GetTemplateWorkbook("DS-KhachHang.xlsx", "DS-KhachHang.xlsx", out fileurl);

            ExcelWorkbook workBook = package.Workbook;
            if (workBook != null)
            {
                var ws = workBook.Worksheets.FirstOrDefault(); //Worksheets["DS"];
                var data = BS_CUS_CRM_CONTACT_KhachHang.get_CUS_CRM_CONTACT_KhachHang(db, PartnerID, QueryStrings);

                int rowid = 3;
                foreach (var item in data)
                {
                    ws.Cells["B" + rowid].Value = rowid - (rowid - 1); //STT
                    ws.Cells["C" + rowid].Value = item.Code;
                    ws.Cells["D" + rowid].Value = item.Name;
                    ws.Cells["E" + rowid].Value = item.MaSoThue;
                    ws.Cells["F" + rowid].Value = item.SoDienThoai1;
                    ws.Cells["G" + rowid].Value = item.SoDienThoai2;
                    ws.Cells["H" + rowid].Value = item.Fax;
                    ws.Cells["I" + rowid].Value = item.Email;
                    ws.Cells["J" + rowid].Value = item.Website;
                    ws.Cells["K" + rowid].Value = item.DiaChi;

                    rowid++;
                }

                package.Save();
            }

            return downloadFile(fileurl);
        }


        [Route("QuanHuyen")]
        public HttpResponseMessage Post_QuanHuyen()
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

                    if (row[1] == "") //check code null
                        continue;

                    string code = row[1];
                    DTO_CUS_CRM_CONTACT_KhachHang dbitem = BS_CUS_CRM_CONTACT_KhachHang.get_CUS_CRM_CONTACT_KhachHang(db, PartnerID, code);
                    if (dbitem == null)
                        dbitem = new DTO_CUS_CRM_CONTACT_KhachHang();

                    dbitem.Code = row[1];
                    dbitem.Name = row[2];

                    dbitem.MaSoThue = row[3];
                    dbitem.SoDienThoai1 = row[4];
                    dbitem.SoDienThoai2 = row[5];

                    dbitem.Fax = row[6];
                    dbitem.Email = row[7];
                    dbitem.Website = row[8];

                    dbitem.DiaChi = row[9];

                    try
                    {
                        if (dbitem.ID != 0)
                        {
                            BS_CUS_CRM_CONTACT_KhachHang.put_CUS_CRM_CONTACT_KhachHang(db, PartnerID, dbitem.ID, dbitem, Username);
                        }
                        else
                        {
                            BS_CUS_CRM_CONTACT_KhachHang.post_CUS_CRM_CONTACT_KhachHang(db, PartnerID, dbitem, Username);
                        }
                    }
                    catch (Exception ex)
                    {
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

















        #region private method
        public List<DTO_CUS_VANTAI_WO_NhatKyLamViec> readWorksheet(ExcelWorksheet ws, ref bool haveError)
        {
            List<DTO_CUS_VANTAI_WO_NhatKyLamViec> data = new List<DTO_CUS_VANTAI_WO_NhatKyLamViec>();
            try
            {

                //var phuongTienList = BS_CUS_VANTAI_CONF_PhuongTien.get_CUS_VANTAI_CONF_PhuongTien(db, PartnerID).ToList();
                //var nhanSuList = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID).ToList();

                int SheetColumnsCount = 0;
                int SheetRowCount = 0;

                SheetColumnsCount = ws.Dimension.End.Column;// Find End Column
                SheetRowCount = ws.Dimension.End.Row;// Find End Row

                if (SheetColumnsCount != 21)
                {
                    haveError = true;
                    return data;
                }


                for (int rowid = 2; rowid <= SheetRowCount; rowid++)
                {
                    DTO_CUS_VANTAI_WO_NhatKyLamViec p = new DTO_CUS_VANTAI_WO_NhatKyLamViec();

                    #region item
                    List<string> row = new List<string>();

                    for (int i = 1; i <= SheetColumnsCount; i++)
                    {
                        row.Add(ws.Cells[rowid, i].Value == null ? "" : ws.Cells[rowid, i].Text);
                    }

                    if (row[1] == "" || row[2] == "" || row[3] == "" || row[4] == "")
                    {
                        continue;
                    }

                    int iID = 0;
                    int.TryParse(row[0], out iID);
                    p.ID = iID;
                    p.NgayThucHien = DateTime.Parse(row[1]); //DateTime.FromOADate(long.Parse(row[1]));

                    p.IDPhuongTien = int.Parse(Regex.Match(row[2], @"\[(\d+)\]").Groups[1].Value); // phuongTienList.First(d => d.Code == row[2]).ID;
                    p.IDLenhLamViec = int.Parse(Regex.Match(row[3], @"\[(\d+)\]").Groups[1].Value);
                    p.TaiXe = int.Parse(Regex.Match(row[4], @"\[(\d+)\]").Groups[1].Value); //nhanSuList.First(d => d.Code == row[4]).ID;

                    if (int.TryParse(Regex.Match(row[5], @"\[(\d+)\]").Groups[1].Value, out int phuXe))
                        p.PhuXe = phuXe;

                    //p.PhuXe = row[5] == "" ? null : int.Parse(Regex.Match(row[5], @"\[(\d+)\]").Groups[1].Value); //nhanSuList.First(d => d.Code == row[5]).ID;

                    p.SangBatDau = row[6];
                    p.SangKetThuc = row[7];
                    p.TruaBatDau = row[8];
                    p.TruaKetThuc = row[9];
                    p.ChieuBatDau = row[10];
                    p.ChieuKetThuc = row[11];
                    p.ToiBatDau = row[12];
                    p.ToiKetThuc = row[13];
                    
                    p.GiamSatThiCong = row[15];
                    p.GiamSatThiCongXacNhan = row[16] == "ok";
                    p.GiamSatThiCongNhanXet = row[17];
                    p.ChiHuyTruong = row[18];
                    p.ChiHuyTruongXacNhan = row[19] == "ok";
                    p.ChiHuyTruongNhanXet = row[20];

                    #endregion

                    //ID Ngày thực hiện  2Xe 3Nội dung làm việc 4Tài xế 5Phụ xe 6Sáng        8Trưa 10Chiều       12Tối     14"Tổng số giờ"	
                    //15"Giám sát thi công"	"Xác nhận"	17Nhận xét	
                    //18Chỉ huy trưởng	"Xác nhận"	Nhận xét

                    validateImportRow(ws, data, p, rowid, ref haveError);
                    if (p.SoGioLamViec!=0)
                    {
                        data.Add(p);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                haveError = true;
            }
            return data;
        }
        void validateImportRow(ExcelWorksheet ws, List<DTO_CUS_VANTAI_WO_NhatKyLamViec> data, DTO_CUS_VANTAI_WO_NhatKyLamViec frow, int rowid, ref bool haveError)
        {
            int inputIntTryParse = 0;
            bool inputBoolTryParse = false;
            bool isInvalid = false;
            string errormessage = "";

            //if (frow.Categorization == 1 && string.IsNullOrEmpty(frow.DefaultValue))
            //{
            //    isInvalid = true;
            //    errormessage = string.Format(Resources.message.RequireMessage, frow.FieldName);
            //}
            //if (frow.ControlID == "drlProduct")
            //{
            //    var drlProductDataSource = documentCtrl.en.tbl_LSProduct.Where(d => d.tbl_LSProductCategory.Partner == PartnerCode && d.IsDeleted == false).Select(s => new
            //    {
            //        s.Code,
            //        ProductName = s.tbl_LSProductDetail.Where(c => c.Language == language).FirstOrDefault() == null ? "N/A" :
            //        s.tbl_LSProductDetail.Where(c => c.Language == language).FirstOrDefault().ProductName
            //    });
            //    int importproductcode = 0;
            //    int.TryParse(frow.DefaultValue, out importproductcode);

            //    if (drlProductDataSource.Where(d => d.Code == importproductcode).Count() == 0)
            //    {
            //        isInvalid = true;
            //        errormessage = string.Format(Resources.lang.document_inputFieldInvalid, frow.FieldName);
            //    }
            //}
            //else if (ws.Name.Contains("4. ") && frow.ControlID == "drlBuyer" && data.Count(d => d.ControlID == "drlBuyer" && d.DefaultValue == frow.DefaultValue) > 0)
            //{
            //    isInvalid = true;
            //    errormessage = string.Format(Resources.lang.document_importDupplicateErrorMessage, frow.FieldName);
            //}
            //else if (!(string.IsNullOrEmpty(frow.DefaultValue)) && frow.DataType == 2 && !int.TryParse(frow.DefaultValue, out inputIntTryParse))
            //{
            //    isInvalid = true;
            //    errormessage = string.Format(Resources.message.FieldIsNumber, frow.FieldName);
            //}
            //else if (!(string.IsNullOrEmpty(frow.DefaultValue)) && frow.DataType == 16 && !bool.TryParse(frow.DefaultValue, out inputBoolTryParse))
            //{
            //    isInvalid = true;
            //    errormessage = Resources.lang.document_ListValidateErrorMessage;
            //}

            //if (isInvalid)
            //{
            //    var comment = ws.Cells["E" + rowid].AddComment(errormessage, "traceverified");
            //    comment.AutoFit = true;
            //    haveError = true;
            //    ws.Cells["E" + rowid].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            //    ws.Cells["E" + rowid].Style.Fill.BackgroundColor.SetColor(Color.Red);
            //    ws.Cells["E" + rowid].Style.Font.Color.SetColor(Color.White);
            //}
        }
        public void AddRows(ExcelWorksheet ws)
        {
            var phuongTienList = BS_CUS_VANTAI_CONF_PhuongTien.get_CUS_VANTAI_CONF_PhuongTien(db, PartnerID, new Dictionary<string, string>()).ToList();
            var lenhLamViecList = BS_CUS_VANTAI_WO_LenhLamViec.get_CUS_VANTAI_WO_LenhLamViec(db, PartnerID, new Dictionary<string, string>(), true);
            var nhanSuList = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, new Dictionary<string, string>());
            int rowid = 1;

            foreach (var lenhLamViec in lenhLamViecList)
            {

                var nhatKyLamViecList = db.tbl_CUS_VANTAI_WO_NhatKyLamViec.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID && d.IDLenhLamViec == lenhLamViec.ID).ToList();
                if (nhatKyLamViecList.Count() == 0 && lenhLamViec.NgayThucHien<= DateTime.Today && DateTime.Today <= lenhLamViec.NgayDuKienKetThuc && (lenhLamViec.IDTinhTrangLamViec == 2 || lenhLamViec.IDTinhTrangLamViec == 5))
                {
                    var tempNhatKy = new tbl_CUS_VANTAI_WO_NhatKyLamViec() { IDLenhLamViec = lenhLamViec.ID, IDPhuongTien = lenhLamViec.IDPhuongTien };
                    tempNhatKy.NgayThucHien = DateTime.Today;
                    if (lenhLamViec.TaiXe.HasValue)
                        tempNhatKy.TaiXe = lenhLamViec.TaiXe.Value;
                    if (lenhLamViec.PhuXe.HasValue)
                        tempNhatKy.PhuXe = lenhLamViec.PhuXe.Value;
                    
                    nhatKyLamViecList.Add(tempNhatKy);
                }

                foreach (var item in nhatKyLamViecList)
                {
                    rowid++;

                    //ws.Cells["A" + rowid].Value = item.ID;
                    ws.Cells["B" + rowid].Value = item.NgayThucHien.ToOADate();
                    var phuongtien = phuongTienList.FirstOrDefault(d => d.ID == item.IDPhuongTien);
                    if (phuongtien != null)
                        ws.Cells["C" + rowid].Value = phuongtien.Code + " [" + phuongtien.ID + "]";



                    ws.Cells["D" + rowid].Value = lenhLamViec.Name + " [" + lenhLamViec.ID + "]";

                    var taixe = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, item.TaiXe);
                    if (taixe != null)
                        ws.Cells["E" + rowid].Value = taixe.TenDayDu + " [" + taixe.ID + "]";

                    var phuxe = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, item.PhuXe.GetValueOrDefault());
                    if (phuxe != null)
                        ws.Cells["F" + rowid].Value = phuxe.TenDayDu + " [" + phuxe.ID + "]";

                    if (!string.IsNullOrEmpty(item.SangBatDau))
                    {
                        ws.Cells["G" + rowid].Value = TimeSpan.Parse(item.SangBatDau).TotalDays;
                    }
                    if (!string.IsNullOrEmpty(item.SangKetThuc))
                    {
                        ws.Cells["H" + rowid].Value = TimeSpan.Parse(item.SangKetThuc).TotalDays;
                    }
                    if (!string.IsNullOrEmpty(item.TruaBatDau))
                    {
                        ws.Cells["I" + rowid].Value = TimeSpan.Parse(item.TruaBatDau).TotalDays;
                    }
                    if (!string.IsNullOrEmpty(item.TruaKetThuc))
                    {
                        ws.Cells["J" + rowid].Value = TimeSpan.Parse(item.TruaKetThuc).TotalDays;
                    }
                    if (!string.IsNullOrEmpty(item.ChieuBatDau))
                    {
                        ws.Cells["K" + rowid].Value = TimeSpan.Parse(item.ChieuBatDau).TotalDays;
                    }
                    if (!string.IsNullOrEmpty(item.ChieuKetThuc))
                    {
                        ws.Cells["L" + rowid].Value = TimeSpan.Parse(item.ChieuKetThuc).TotalDays;
                    }
                    if (!string.IsNullOrEmpty(item.ToiBatDau))
                    {
                        ws.Cells["M" + rowid].Value = TimeSpan.Parse(item.ToiBatDau).TotalDays;
                    }
                    if (!string.IsNullOrEmpty(item.ToiKetThuc))
                    {
                        ws.Cells["N" + rowid].Value = TimeSpan.Parse(item.ToiKetThuc).TotalDays;
                    }

                    ws.Cells["O" + rowid].Formula = string.Format("N{0}-M{0}+L{0}-K{0}+J{0}-I{0}+H{0}-G{0}", rowid);
                    ws.Cells["P" + rowid].Value = item.GiamSatThiCong;
                    ws.Cells["Q" + rowid].Value = item.GiamSatThiCongXacNhan ? "ok" : "";
                    ws.Cells["R" + rowid].Value = item.GiamSatThiCongNhanXet;
                    ws.Cells["S" + rowid].Value = item.ChiHuyTruong;
                    ws.Cells["T" + rowid].Value = item.ChiHuyTruongXacNhan ? "ok" : "";
                    ws.Cells["U" + rowid].Value = item.ChiHuyTruongNhanXet;
                }
            }


        }
        public void AddListData(ExcelWorksheet ws)
        {
            var phuongTienList = BS_CUS_VANTAI_CONF_PhuongTien.get_CUS_VANTAI_CONF_PhuongTien(db, PartnerID, new Dictionary<string, string>());
            var nhanSuList = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, new Dictionary<string, string>());
            Dictionary<string, string> queryStrings = new Dictionary<string, string>();
            //queryStrings.Add("CodeTinhTrangLamViec", "\"PT1\", \"PT2\"");

            var lenhLamViecList = BS_CUS_VANTAI_WO_LenhLamViec.get_CUS_VANTAI_WO_LenhLamViec(db, PartnerID, queryStrings, true);
            //A.Xe 
            //B.Tài xế 
            //C.Phụ xe 
            //D.Nội dung làm việc
            
            int rowid = 1;
            foreach (var item in phuongTienList)
            {
                rowid++;
                ws.Cells["A" + rowid].Value = item.Code + " [" + item.ID + "]";
            }

            rowid = 1;
            foreach (var item in nhanSuList)
            {
                if(item.IDChucDanh == 5 || item.IDChucDanh == 8 || item.IDChucDanh == 10 || item.IDChucDanh == 12)
                {
                    rowid++;
                    ws.Cells["B" + rowid].Value = item.TenDayDu + " [" + item.ID + "]";
                }
            }

            rowid = 1;
            foreach (var item in nhanSuList)
            {
                if (item.IDChucDanh == 6 || item.IDChucDanh == 9 || item.IDChucDanh == 11 || item.IDChucDanh == 14)
                {
                    rowid++;
                    ws.Cells["C" + rowid].Value = item.TenDayDu + " [" + item.ID + "]";
                }
            }


            rowid = 1;
            foreach (var item in lenhLamViecList)
            {
                rowid++;
                ws.Cells["D" + rowid].Value = item.Name + " [" + item.ID + "]";
            }

        }
        
        #endregion
        
    }
}