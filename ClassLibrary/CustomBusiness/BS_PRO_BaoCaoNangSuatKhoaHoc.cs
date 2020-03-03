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
    public static partial class BS_PRO_BaoCaoNangSuatKhoaHoc
    {
        public static IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> get_PRO_BaoCaoNangSuatKhoaHocCustom(AppEntities db, int StaffID, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.AsQueryable();

            query = query.Where(d => d.IsDeleted == false);
            var staff = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(c => c.ID == StaffID);
            if (staff != null)
            {
                if (staff.IsHRCO != true)
                    query = query.Where(c => c.IDNCV == staff.ID);
            }
            else query = query.Where(c => false);

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

            //Query IDDeTai (int)
            if (QueryStrings.Any(d => d.Key == "IDDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDeTai));
            }

            //Query IDNhom (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDNhom"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhom").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhom));
            }

            //Query IDSite (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDSite"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDSite").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDSite));
            }

            //Query TenDeTai (string)
            if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d => d.TenDeTai == keyword);
            }

            //Query NgayBaoCao (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "NgayBaoCaoFrom") && QueryStrings.Any(d => d.Key == "NgayBaoCaoTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCaoFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCaoTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayBaoCao && d.NgayBaoCao <= toDate);

            //Query TapChiHoiNghi (string)
            if (QueryStrings.Any(d => d.Key == "TapChiHoiNghi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TapChiHoiNghi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TapChiHoiNghi").Value;
                query = query.Where(d => d.TapChiHoiNghi == keyword);
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

            //Query IDKinhPhi (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDKinhPhi"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDKinhPhi").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDKinhPhi));
            }

            //Query KinhPhi (decimal)
            if (QueryStrings.Any(d => d.Key == "KinhPhiFrom") && QueryStrings.Any(d => d.Key == "KinhPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "KinhPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "KinhPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.KinhPhi && d.KinhPhi <= toVal);



            return toDTOCustom(query);
        }

        public static IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> toDTOCustom(IQueryable<tbl_PRO_BaoCaoNangSuatKhoaHoc> query)
        {
            return query
            .Select(s => new DTO_PRO_BaoCaoNangSuatKhoaHoc()
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                IDKinhPhi = s.IDKinhPhi,
                IDNhom = s.IDNhom,
                IDSite = s.IDSite,
                TenDeTai = s.TenDeTai,
                NgayBaoCao = s.NgayBaoCao,
                TapChiHoiNghi = s.TapChiHoiNghi,
                KinhPhi = s.KinhPhi,
                TenKinhPhi = s.tbl_CAT_KinhPhi.Name,
                TenNhom = s.tbl_CAT_Nhom.Name,
                TenSite = s.tbl_CAT_Site.Name,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                NCVChinh = s.tbl_CUS_HRM_STAFF_NhanSu.Name,
                IsApproved = s.IsApproved,
                ApprovedDate = s.ApprovedDate,
                TrangThaiDuyet = s.IsApproved ? "Đã duyệt" : "Chưa duyệt"
            });
        }

        public static DTO_PRO_BaoCaoNangSuatKhoaHoc postCustom_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, int StaffID, DTO_PRO_BaoCaoNangSuatKhoaHoc item, string Username)
        {
            tbl_PRO_BaoCaoNangSuatKhoaHoc dbitem = new tbl_PRO_BaoCaoNangSuatKhoaHoc();
            if (item != null)
            {
                dbitem.IDDeTai = item.IDDeTai;
                dbitem.IDNhom = item.IDNhom;
                dbitem.IDSite = item.IDSite;
                dbitem.TenDeTai = item.TenDeTai;
                dbitem.NgayBaoCao = item.NgayBaoCao;
                dbitem.TapChiHoiNghi = item.TapChiHoiNghi;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;
                dbitem.IDKinhPhi = item.IDKinhPhi;
                dbitem.KinhPhi = item.KinhPhi;
                dbitem.IDNCV = StaffID;

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                string sKey = SYSConfigCode.ThoiGianBaoCaoNSKH.ToString();
                var config = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == sKey && !c.IsDeleted);
                if (config != null)
                {
                    try
                    {
                        var setting = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_SYS_Config_ThoiGianBaoCaoNSKH>(config.Value);
                        if (setting != null && setting.NgayBatDau.HasValue && setting.NgayKetThuc.HasValue)
                        {
                            int NgayBatDau = setting.NgayBatDau.Value.Day;
                            int NgayKetThuc = setting.NgayKetThuc.Value.Day;
                            if (dbitem.CreatedDate.Day < NgayBatDau || dbitem.CreatedDate.Day > NgayKetThuc)
                            {
                                item.Error = "Đã hết thời hạn được báo cáo, thời hạn báo cáo cho phép từ ngày " + NgayBatDau + " đến ngày " + NgayKetThuc + " hằng tháng";
                            }
                        }
                    }
                    catch { }
                }

                var kinhphi = db.tbl_CAT_KinhPhi.FirstOrDefault(c => c.ID == item.IDKinhPhi);
                if (kinhphi != null && kinhphi.IsManual != true)
                {
                    DateTime dt = item.NgayBaoCao;
                    var banggia = db.tbl_CAT_BangGiaKinhPhi.Where(c => c.IDKinhPhi == item.IDKinhPhi && c.NgayHieuLuc <= dt).OrderByDescending(c => c.NgayHieuLuc).FirstOrDefault();
                    if (banggia != null)
                        dbitem.KinhPhi = banggia.Gia;
                }

                try
                {
                    db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Add(dbitem);
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNangSuatKhoaHoc", DateTime.Now, Username);


                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_PRO_BaoCaoNangSuatKhoaHoc", e);
                    item = null;
                }
            }
            return item;
        }

        public static string putCustom_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, int ID, DTO_PRO_BaoCaoNangSuatKhoaHoc item, string Username)
        {
            string result = string.Empty;
            var dbitem = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Find(ID);
            if (dbitem != null)
            {
                dbitem.IDDeTai = item.IDDeTai;
                dbitem.IDNhom = item.IDNhom;
                dbitem.IDSite = item.IDSite;
                dbitem.TenDeTai = item.TenDeTai;
                dbitem.NgayBaoCao = item.NgayBaoCao;
                dbitem.TapChiHoiNghi = item.TapChiHoiNghi;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;
                dbitem.IDKinhPhi = item.IDKinhPhi;
                dbitem.IDNCV = item.IDNCV;
                dbitem.IsApproved = item.IsApproved;
                dbitem.ApprovedDate = item.ApprovedDate;

                if (item.IsApproved)
                    return "Kinh phí đã duyệt, không thể chỉnh sửa";

                var kinhphi = db.tbl_CAT_KinhPhi.FirstOrDefault(c => c.ID == item.IDKinhPhi);
                if (kinhphi != null && kinhphi.IsManual != true)
                {
                    DateTime dt = item.NgayBaoCao;
                    var banggia = db.tbl_CAT_BangGiaKinhPhi.Where(c => c.IDKinhPhi == item.IDKinhPhi && c.NgayHieuLuc <= dt).OrderByDescending(c => c.NgayHieuLuc).FirstOrDefault();
                    if (banggia != null)
                        dbitem.KinhPhi = banggia.Gia;
                }
                else dbitem.KinhPhi = item.KinhPhi;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNangSuatKhoaHoc", DateTime.Now, Username);
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("put_PRO_BaoCaoNangSuatKhoaHoc", e);
                    result = e.InnerException.Message;
                }
            }
            return result;
        }

        public static string updateStatus_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, int ID, string ActionCode, string Username)
        {
            tbl_PRO_BaoCaoNangSuatKhoaHoc dbitem = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Find(ID);

            if (dbitem != null)
            {
                #region Duyệt
                if (ActionCode == "Approved")
                {
                    if (dbitem.IsApproved == false)
                    {
                        dbitem.IsApproved = true;
                        dbitem.ApprovedDate = DateTime.Now;
                        db.SaveChanges();
                    }
                    else return "Chi phí đã được duyệt trước đó";
                }
                #endregion

                #region Hủy Duyệt
                if (ActionCode == "UnApproved")
                {
                    if (dbitem.IsApproved == true)
                    {
                        dbitem.IsApproved = false;
                        db.SaveChanges();
                    }
                    else return "Chi phí chưa duyệt, không thể hủy";
                }
                #endregion
            }

            return string.Empty;
        }
    }
}
