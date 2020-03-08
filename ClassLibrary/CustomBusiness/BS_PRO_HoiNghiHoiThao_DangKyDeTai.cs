using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_PRO_HoiNghiHoiThao_DangKyDeTai
    {
        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> get_PRO_HoiNghiHoiThao_DangKyDeTaiTheoHoiNghi(AppEntities db, Dictionary<string, string> QueryStrings, int idHoiNghi)
        {
            var query = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Where(c => c.IDHoiNghiHoiThao == idHoiNghi && c.IDTrangThai != -(int)SYSVarType.TrangThai_HNHT_ChoGui).AsQueryable();

            //Query keyword



            //Query ID (int)
            if (QueryStrings.Any(d => d.Key == "ID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ID));
            }

            //Query IDDangKy (int)
            if (QueryStrings.Any(d => d.Key == "IDDangKy"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDangKy").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDangKy));
            }

            //Query IDHoiNghiHoiThao (int)
            if (QueryStrings.Any(d => d.Key == "IDHoiNghiHoiThao"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHoiNghiHoiThao").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHoiNghiHoiThao));
            }

            //Query IDHinhThucDangKy (int)
            if (QueryStrings.Any(d => d.Key == "IDHinhThucDangKy"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHinhThucDangKy").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHinhThucDangKy));
            }

            //Query IDTrangThai (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai));
            }

            //Query TenDeTai (string)
            if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d => d.TenDeTai == keyword);
            }

            //Query BaiAbstract (string)
            if (QueryStrings.Any(d => d.Key == "BaiAbstract") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BaiAbstract").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BaiAbstract").Value;
                query = query.Where(d => d.BaiAbstract == keyword);
            }

            //Query BaiFulltext (string)
            if (QueryStrings.Any(d => d.Key == "BaiFulltext") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value;
                query = query.Where(d => d.BaiFulltext == keyword);
            }

            //Query CreatedDate (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

            //Query CreatedBy (string)
            if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d => d.CreatedBy == keyword);
            }

            //Query ModifiedDate (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

            //Query ModifiedBy (string)
            if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d => d.ModifiedBy == keyword);
            }


            return toDTOCustom(query);

        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> get_PRO_HoiNghiHoiThao_DangKyDeTaiTheoDangKy(AppEntities db, Dictionary<string, string> QueryStrings, int idDangKy)
        {
            var query = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Where(c => c.IDDangKy == idDangKy).AsQueryable();

            //Query keyword



            //Query ID (int)
            if (QueryStrings.Any(d => d.Key == "ID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ID));
            }

            //Query IDDangKy (int)
            if (QueryStrings.Any(d => d.Key == "IDDangKy"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDangKy").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDangKy));
            }

            //Query IDHoiNghiHoiThao (int)
            if (QueryStrings.Any(d => d.Key == "IDHoiNghiHoiThao"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHoiNghiHoiThao").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHoiNghiHoiThao));
            }

            //Query IDHinhThucDangKy (int)
            if (QueryStrings.Any(d => d.Key == "IDHinhThucDangKy"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHinhThucDangKy").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHinhThucDangKy));
            }

            //Query IDTrangThai (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai));
            }

            //Query TenDeTai (string)
            if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d => d.TenDeTai == keyword);
            }

            //Query BaiAbstract (string)
            if (QueryStrings.Any(d => d.Key == "BaiAbstract") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BaiAbstract").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BaiAbstract").Value;
                query = query.Where(d => d.BaiAbstract == keyword);
            }

            //Query BaiFulltext (string)
            if (QueryStrings.Any(d => d.Key == "BaiFulltext") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value;
                query = query.Where(d => d.BaiFulltext == keyword);
            }

            //Query CreatedDate (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

            //Query CreatedBy (string)
            if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d => d.CreatedBy == keyword);
            }

            //Query ModifiedDate (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

            //Query ModifiedBy (string)
            if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d => d.ModifiedBy == keyword);
            }


            return toDTOCustom(query);

        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> toDTOCustom(IQueryable<tbl_PRO_HoiNghiHoiThao_DangKyDeTai> query)
        {
            return query
            .Select(s => new DTO_PRO_HoiNghiHoiThao_DangKyDeTai()
            {
                ID = s.ID,
                TenNCV = s.tbl_PRO_HoiNghiHoiThao_DangKy.tbl_CUS_HRM_STAFF_NhanSu.Name,
                IDDangKy = s.IDDangKy,
                IDHoiNghiHoiThao = s.IDHoiNghiHoiThao,
                TenHoiNghi = s.tbl_PRO_HoiNghiHoiThao.TenHoiNghi,
                DiaDiem = s.tbl_PRO_HoiNghiHoiThao.DiaDiem,
                ThoiGian = s.tbl_PRO_HoiNghiHoiThao.ThoiGian.Value,
                ThoiGianHetHan = s.tbl_PRO_HoiNghiHoiThao.ThoiGianHetHan,
                IDHinhThucDangKy = s.IDHinhThucDangKy,
                HinhThucDangKy = s.tbl_SYS_Var.ValueOfVar,
                IDTrangThai = s.IDTrangThai,
                TrangThai = s.tbl_SYS_Var1.ValueOfVar,
                TenDeTai = s.TenDeTai,
                BaiAbstract = s.BaiAbstract,
                BaiFulltext = s.BaiFulltext,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                UploadBaiAbstract = !string.IsNullOrEmpty(s.BaiAbstract) ? "Đã up" : "Chưa up",
                UploadBaiFulltext = !string.IsNullOrEmpty(s.BaiFulltext) ? "Đã up" : "Chưa up",
            });
        }

        public static string put_PRO_HoiNghiHoiThao_DangKyDeTaiCustom(AppEntities db, int ID, DTO_PRO_HoiNghiHoiThao_DangKyDeTai item, string Username)
        {
            string result = "";
            var dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Find(ID);
            if (dbitem != null)
            {
                dbitem.IDHinhThucDangKy = item.IDHinhThucDangKy;
                dbitem.TenDeTai = item.TenDeTai;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                if (dbitem.IDTrangThai == -(int)SYSVarType.TrangThai_HNHT_ChoDuyet)
                    result = "Đề tài đã gửi, không thể chỉnh sửa";
                if (dbitem.IDTrangThai == -(int)SYSVarType.TrangThai_HNHT_DaDuyet)
                    result = "Đề tài đã duyệt, không thể chỉnh sửa";

                if (!string.IsNullOrEmpty(result))
                    return result;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "put_PRO_HoiNghiHoiThao_DangKyDeTaiCustom", DateTime.Now, Username);
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("put_PRO_HoiNghiHoiThao_DangKyDeTaiCustom", e);
                    result = e.InnerException.Message;
                }
            }
            return result;
        }

        public static DTO_PRO_HoiNghiHoiThao_DangKyDeTai post_PRO_HoiNghiHoiThao_DangKyDeTaiCustom(AppEntities db, DTO_PRO_HoiNghiHoiThao_DangKyDeTai item, string Username)
        {
            tbl_PRO_HoiNghiHoiThao_DangKyDeTai dbitem = new tbl_PRO_HoiNghiHoiThao_DangKyDeTai();
            if (item != null)
            {
                dbitem.IDDangKy = item.IDDangKy;
                dbitem.IDHinhThucDangKy = item.IDHinhThucDangKy;
                dbitem.IDTrangThai = -(int)SYSVarType.TrangThai_HNHT_ChoGui;
                dbitem.TenDeTai = item.TenDeTai;

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                var dangky = db.tbl_PRO_HoiNghiHoiThao_DangKy.FirstOrDefault(c => c.ID == item.IDDangKy);
                if (dangky != null)
                {
                    dbitem.IDHoiNghiHoiThao = dangky.IDHoiNghiHoiThao;
                    if (dangky.tbl_PRO_HoiNghiHoiThao.ThoiGianHetHan < DateTime.Now)
                    {
                        item.Error = "Hội nghị đã hết hạn, không thể đăng ký đề tài";
                        return item;
                    }
                }

                try
                {
                    db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Add(dbitem);
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "post_PRO_HoiNghiHoiThao_DangKyDeTaiCustom", DateTime.Now, Username);


                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_PRO_HoiNghiHoiThao_DangKyDeTaiCustom", e);
                    item = null;
                }
            }
            return item;
        }

        public static bool uploadAbstract_PRO_HoiNghiHoiThaoDangKyDeTai(AppEntities db, int ID, string path, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Find(ID);
            if (dbitem != null)
            {
                dbitem.BaiAbstract = path;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKyDeTai", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("uploadAbstract_PRO_HoiNghiHoiThaoDangKyDeTai", e);
                    result = false;
                }
            }
            return result;
        }

        public static bool uploadFullText_PRO_HoiNghiHoiThaoDangKyDeTai(AppEntities db, int ID, string path, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Find(ID);
            if (dbitem != null)
            {
                dbitem.BaiFulltext = path;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKyDeTai", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("uploadFullText_PRO_HoiNghiHoiThaoDangKyDeTai", e);
                    result = false;
                }
            }
            return result;
        }

        public static string updateStatus_PRO_HoiNghiHoiThaoDangKyDeTai(AppEntities db, int ID, string ActionCode, string Username)
        {
            tbl_PRO_HoiNghiHoiThao_DangKyDeTai dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Find(ID);

            if (dbitem != null)
            {
                #region Gửi Duyệt
                if (ActionCode == "SendApproved")
                {
                    if (dbitem.IDTrangThai == -(int)SYSVarType.TrangThai_HNHT_ChoGui)
                    {
                        //if (string.IsNullOrEmpty(dbitem.BaiAbstract) && string.IsNullOrEmpty(dbitem.BaiFulltext))
                        //    return "Chưa up Bài Abstract/Bài Fulltext, không thể gửi duyệt";

                        dbitem.IDTrangThai = -(int)SYSVarType.TrangThai_HNHT_ChoDuyet;
                        dbitem.ModifiedBy = Username;
                        dbitem.ModifiedDate = DateTime.Now;
                        db.SaveChanges();
                    }
                    else return "Chỉ được gửi duyệt đề tài Chờ gửi";
                }
                #endregion

                #region Duyệt
                if (ActionCode == "Approved")
                {
                    if (dbitem.IDTrangThai == -(int)SYSVarType.TrangThai_HNHT_ChoDuyet)
                    {
                        dbitem.IDTrangThai = -(int)SYSVarType.TrangThai_HNHT_DaDuyet;
                        dbitem.ModifiedBy = Username;
                        dbitem.ModifiedDate = DateTime.Now;
                        db.SaveChanges();
                    }
                    else return "Chỉ được duyệt đề tài đang chờ duyệt";
                }
                #endregion

                #region Hủy Duyệt
                if (ActionCode == "UnApproved")
                {
                    if (dbitem.IDTrangThai == -(int)SYSVarType.TrangThai_HNHT_DaDuyet)
                    {
                        dbitem.IDTrangThai = -(int)SYSVarType.TrangThai_HNHT_ChoDuyet;
                        dbitem.ModifiedBy = Username;
                        dbitem.ModifiedDate = DateTime.Now;
                        db.SaveChanges();
                    }
                    else return "Chỉ được hủy duyệt đề tài đã duyệt";
                }
                #endregion
            }

            return string.Empty;
        }

        public static List<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> getExcel_PRO_HoiNghiHoiThao_DangKyDeTaiTheoHoiNghi(AppEntities db, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Where(c => c.IDTrangThai != -(int)SYSVarType.TrangThai_HNHT_ChoGui).AsQueryable();
            //Query IDHoiNghiHoiThao (int)
            if (QueryStrings.Any(d => d.Key == "IDHoiNghiHoiThao"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHoiNghiHoiThao").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHoiNghiHoiThao));
            }
            else
            {
                if (QueryStrings.Any(d => d.Key == "DateFrom") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value))
                {
                    var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value.Replace("\\", "");
                    try
                    {

                        DateTime dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(keyword).ToLocalTime();
                        query = query.Where(c => c.tbl_PRO_HoiNghiHoiThao.ThoiGian >= dt);
                    }
                    catch { }
                }

                if (QueryStrings.Any(d => d.Key == "DateTo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value))
                {
                    var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value.Replace("\\", "");
                    try
                    {
                        DateTime dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(keyword).ToLocalTime();
                        query = query.Where(c => c.tbl_PRO_HoiNghiHoiThao.ThoiGian <= dt);
                    }
                    catch { }
                }
            }

            var data = query
            .Select(s => new DTO_PRO_HoiNghiHoiThao_DangKyDeTai()
            {
                ID = s.ID,
                TenNCV = s.tbl_PRO_HoiNghiHoiThao_DangKy.tbl_CUS_HRM_STAFF_NhanSu.Name,
                IDDangKy = s.IDDangKy,
                IDHoiNghiHoiThao = s.IDHoiNghiHoiThao,
                TenHoiNghi = s.tbl_PRO_HoiNghiHoiThao.TenHoiNghi,
                DiaDiem = s.tbl_PRO_HoiNghiHoiThao.DiaDiem,
                ThoiGian = s.tbl_PRO_HoiNghiHoiThao.ThoiGian.Value,
                ThoiGianHetHan = s.tbl_PRO_HoiNghiHoiThao.ThoiGianHetHan,
                IDHinhThucDangKy = s.IDHinhThucDangKy,
                HinhThucDangKy = s.tbl_SYS_Var.ValueOfVar,
                IDTrangThai = s.IDTrangThai,
                TrangThai = s.tbl_SYS_Var1.ValueOfVar,
                TenDeTai = s.TenDeTai,
                BaiAbstract = s.BaiAbstract,
                BaiFulltext = s.BaiFulltext,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                TongSoDeTaiDangKy = 0,
                TongSoNguoiDangKy = 0,
                UploadBaiAbstract = !string.IsNullOrEmpty(s.BaiAbstract) ? "Đã up" : "Chưa up",
                UploadBaiFulltext = !string.IsNullOrEmpty(s.BaiFulltext) ? "Đã up" : "Chưa up",
            }).ToList();

            var lstHoiNghiID = data.Select(c => c.IDHoiNghiHoiThao).Distinct().ToList();
            var lstHoiNghi = db.tbl_PRO_HoiNghiHoiThao.Where(c => lstHoiNghiID.Contains(c.ID)).Select(c => new
            {
                c.ID,
                TongSoNguoiDangKy = c.tbl_PRO_HoiNghiHoiThao_DangKy.Count(),
                TongSoDeTaiDangKy = c.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Count(d => d.IDTrangThai != -(int)SYSVarType.TrangThai_HNHT_ChoGui)
            }).ToList();

            foreach (var item in data)
            {
                var hoinghi = lstHoiNghi.FirstOrDefault(c => c.ID == item.IDHoiNghiHoiThao);
                if (hoinghi != null)
                {
                    item.TongSoDeTaiDangKy = hoinghi.TongSoDeTaiDangKy;
                    item.TongSoNguoiDangKy = hoinghi.TongSoNguoiDangKy;
                }
            }
            return data;
        }

    }
}
