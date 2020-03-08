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
    public static partial class BS_PRO_HoiNghiHoiThao
    {
        public static IQueryable<DTO_PRO_HoiNghiHoiThao> get_PRO_HoiNghiHoiThaoCustom(AppEntities db, int StaffID, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_HoiNghiHoiThao.Where(d => d.IsDeleted == false);

            //Query keyword
            if (QueryStrings.Any(d => d.Key == "DateFrom") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value.Replace("\\", "");
                try
                {

                    DateTime dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(keyword).ToLocalTime();
                    query = query.Where(c => c.ThoiGian >= dt);
                }
                catch { }
            }

            if (QueryStrings.Any(d => d.Key == "DateTo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value.Replace("\\", "");
                try
                {
                    DateTime dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(keyword).ToLocalTime();
                    query = query.Where(c => c.ThoiGian <= dt);
                }
                catch { }
            }


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

            //Query IDNhanVien (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDNhanVien"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhanVien").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhanVien));
            }

            //Query ThoiGian (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ThoiGianFrom") && QueryStrings.Any(d => d.Key == "ThoiGianTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ThoiGian && d.ThoiGian <= toDate);

            //Query DiaDiem (string)
            if (QueryStrings.Any(d => d.Key == "DiaDiem") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaDiem").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaDiem").Value;
                query = query.Where(d => d.DiaDiem == keyword);
            }

            //Query TenHoiNghi (string)
            if (QueryStrings.Any(d => d.Key == "TenHoiNghi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenHoiNghi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenHoiNghi").Value;
                query = query.Where(d => d.TenHoiNghi == keyword);
            }

            //Query CVBaoCaoVien (string)
            if (QueryStrings.Any(d => d.Key == "CVBaoCaoVien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CVBaoCaoVien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CVBaoCaoVien").Value;
                query = query.Where(d => d.CVBaoCaoVien == keyword);
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

            //Query HTMLHosrem (string)
            if (QueryStrings.Any(d => d.Key == "HTMLHosrem") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HTMLHosrem").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HTMLHosrem").Value;
                query = query.Where(d => d.HTMLHosrem == keyword);
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

            //Query IsDisabled (bool)
            if (QueryStrings.Any(d => d.Key == "IsDisabled"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDisabled").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDisabled);
            }

            //Query IsDeleted (bool)
            if (QueryStrings.Any(d => d.Key == "IsDeleted"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDeleted").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDeleted);
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

            //Query ThoiGianHetHan (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ThoiGianHetHanFrom") && QueryStrings.Any(d => d.Key == "ThoiGianHetHanTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianHetHanFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianHetHanTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ThoiGianHetHan && d.ThoiGianHetHan <= toDate);



            return toDTOCustom(query);
        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao> toDTOCustom(IQueryable<tbl_PRO_HoiNghiHoiThao> query)
        {
            return query
            .Select(s => new DTO_PRO_HoiNghiHoiThao()
            {
                ID = s.ID,
                IDNhanVien = s.IDNhanVien,
                ThoiGian = s.ThoiGian,
                ThoiGianHetHan = s.ThoiGianHetHan,
                DiaDiem = s.DiaDiem,
                TenHoiNghi = s.TenHoiNghi,
                CVBaoCaoVien = s.CVBaoCaoVien,
                BaiAbstract = s.BaiAbstract,
                BaiFulltext = s.BaiFulltext,
                HTMLHosrem = s.HTMLHosrem,
                IDTrangThai = s.IDTrangThai,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                TongSoNguoiDangKy = s.tbl_PRO_HoiNghiHoiThao_DangKy.Count(),
                TongSoDeTaiDangKy = s.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Count(c=> c.IDTrangThai != -(int)SYSVarType.TrangThai_HNHT_ChoGui)
            });
        }

        public static bool put_PRO_HoiNghiHoiThaoCustom(AppEntities db, int ID, DTO_PRO_HoiNghiHoiThao item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao.Find(ID);
            if (dbitem != null)
            {
                dbitem.ThoiGian = item.ThoiGian;
                dbitem.ThoiGianHetHan = item.ThoiGianHetHan;
                dbitem.DiaDiem = item.DiaDiem;
                dbitem.TenHoiNghi = item.TenHoiNghi;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("put_PRO_HoiNghiHoiThaoCustom", e);
                    result = false;
                }
            }
            return result;
        }

        public static bool uploadAbstract_PRO_HoiNghiHoiThao(AppEntities db, int ID, string path, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao.Find(ID);
            if (dbitem != null)
            {
                dbitem.BaiAbstract = path;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("uploadAbstract_PRO_HoiNghiHoiThao", e);
                    result = false;
                }
            }
            return result;
        }

        public static bool uploadFullText_PRO_HoiNghiHoiThao(AppEntities db, int ID, string path, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao.Find(ID);
            if (dbitem != null)
            {
                dbitem.BaiFulltext = path;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("uploadFullText_PRO_HoiNghiHoiThao", e);
                    result = false;
                }
            }
            return result;
        }

        public static DTO_PRO_HoiNghiHoiThao post_PRO_HoiNghiHoiThaoCustom(AppEntities db, DTO_PRO_HoiNghiHoiThao item, string Username)
        {
            tbl_PRO_HoiNghiHoiThao dbitem = new tbl_PRO_HoiNghiHoiThao();
            if (item != null)
            {
                dbitem.IDNhanVien = item.IDNhanVien;
                dbitem.ThoiGian = item.ThoiGian;
                dbitem.ThoiGianHetHan = item.ThoiGianHetHan;
                dbitem.DiaDiem = item.DiaDiem;
                dbitem.TenHoiNghi = item.TenHoiNghi;
                dbitem.CVBaoCaoVien = item.CVBaoCaoVien;
                dbitem.IDTrangThai = item.IDTrangThai;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;


                try
                {
                    db.tbl_PRO_HoiNghiHoiThao.Add(dbitem);
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao", DateTime.Now, Username);


                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_PRO_HoiNghiHoiThaoCustom", e);
                    item = null;
                }
            }
            return item;
        }

        public static string updateStatus_PRO_HoiNghiHoiThao(AppEntities db, int ID, string ActionCode, string Username)
        {
            tbl_PRO_HoiNghiHoiThao dbitem = db.tbl_PRO_HoiNghiHoiThao.Find(ID);

            if (dbitem != null)
            {
                #region Gửi Duyệt
                if (ActionCode == "SendApproved")
                {
                    if (dbitem.IDTrangThai == -(int)SYSVarType.TrangThai_HNHT_ChoGui)
                    {
                        if (string.IsNullOrEmpty(dbitem.BaiAbstract))
                            return "Chưa up Bài Abstract, không thể gửi duyệt";
                        if (string.IsNullOrEmpty(dbitem.BaiFulltext))
                            return "Chưa up Bài FullText, không thể gửi duyệt";

                        var hosrem = db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.FirstOrDefault(c => c.IDNhanSu == dbitem.IDNhanVien && c.IsDeleted == false);
                        if (hosrem == null)
                            return "Chưa cập nhật CV Hosrem, không thể gửi duyệt";

                        dbitem.IDTrangThai = -(int)SYSVarType.TrangThai_HNHT_ChoDuyet;
                        dbitem.ModifiedBy = Username;
                        dbitem.ModifiedDate = DateTime.Now;
                        db.SaveChanges();
                    }
                    else return "Chỉ được gửi duyệt Hội nghị, hội thảo đang chờ gửi";
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
                    else return "Chỉ được duyệt Hội nghị, hội thảo đang chờ duyệt";
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
                    else return "Chỉ được hủy duyệt Hội nghị, hội thảo đã duyệt";
                }
                #endregion
            }

            return string.Empty;
        }
    }
}
