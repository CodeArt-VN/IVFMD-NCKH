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
    public static partial class BS_PRO_BaoCaoTienDoNghienCuu
    {
        public static IQueryable<DTO_PRO_BaoCaoTienDoNghienCuu> get_PRO_BaoCaoTienDoNghienCuuCustom(AppEntities db, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_BaoCaoTienDoNghienCuu.AsQueryable();

            query = query.Where(d => d.IsDeleted == false);


            //Query keyword

            //Query TenDeTai (string)
            if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d => d.TenDeTai == keyword);
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

            //Query SoCaThuThapHopLe (string)
            if (QueryStrings.Any(d => d.Key == "SoCaThuThapHopLe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoCaThuThapHopLe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoCaThuThapHopLe").Value;
                query = query.Where(d => d.SoCaThuThapHopLe == keyword);
            }

            //Query TienDoThuNhanMau (string)
            if (QueryStrings.Any(d => d.Key == "TienDoThuNhanMau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TienDoThuNhanMau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TienDoThuNhanMau").Value;
                query = query.Where(d => d.TienDoThuNhanMau == keyword);
            }

            //Query KhoKhan (string)
            if (QueryStrings.Any(d => d.Key == "KhoKhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "KhoKhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "KhoKhan").Value;
                query = query.Where(d => d.KhoKhan == keyword);
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

            return toDTOCustom(query);
        }

        public static IQueryable<DTO_PRO_BaoCaoTienDoNghienCuu> get_PRO_BaoCaoTienDoNghienCuuByDeTai(AppEntities db, int deTaiId, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_BaoCaoTienDoNghienCuu.AsQueryable();

            query = query.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false);


            //Query keyword



            //Query TenDeTai (string)
            if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d => d.TenDeTai == keyword);
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

            //Query SoCaThuThapHopLe (string)
            if (QueryStrings.Any(d => d.Key == "SoCaThuThapHopLe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoCaThuThapHopLe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoCaThuThapHopLe").Value;
                query = query.Where(d => d.SoCaThuThapHopLe == keyword);
            }

            //Query TienDoThuNhanMau (string)
            if (QueryStrings.Any(d => d.Key == "TienDoThuNhanMau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TienDoThuNhanMau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TienDoThuNhanMau").Value;
                query = query.Where(d => d.TienDoThuNhanMau == keyword);
            }

            //Query KhoKhan (string)
            if (QueryStrings.Any(d => d.Key == "KhoKhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "KhoKhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "KhoKhan").Value;
                query = query.Where(d => d.KhoKhan == keyword);
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


            return toDTOCustom(query);
        }

        public static IQueryable<DTO_PRO_BaoCaoTienDoNghienCuu> toDTOCustom(IQueryable<tbl_PRO_BaoCaoTienDoNghienCuu> query)
        {
            return query
            .Select(s => new DTO_PRO_BaoCaoTienDoNghienCuu()
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                TenDeTai = s.TenDeTai,
                ChuNhiemDeTai = s.ChuNhiemDeTai,
                SoNCT = s.SoNCT,
                CoMau = s.CoMau,
                NCVChinh = s.NCVChinh,
                NgayDuyetNghienCuu = s.NgayDuyetNghienCuu,
                ThoiGianTienHanh = s.ThoiGianTienHanh,
                SoCaThuThapHopLe = s.SoCaThuThapHopLe,
                TienDoThuNhanMau = s.TienDoThuNhanMau,
                KhoKhan = s.KhoKhan,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            });
        }

        public static DTO_PRO_BaoCaoTienDoNghienCuu post_PRO_BaoCaoTienDoNghienCuuCustom(AppEntities db, DTO_PRO_BaoCaoTienDoNghienCuu item, string Username)
        {
            tbl_PRO_BaoCaoTienDoNghienCuu dbitem = new tbl_PRO_BaoCaoTienDoNghienCuu();
            if (item != null)
            {
                dbitem.IDDeTai = item.IDDeTai;
                dbitem.SoCaThuThapHopLe = item.SoCaThuThapHopLe;
                dbitem.TienDoThuNhanMau = item.TienDoThuNhanMau;
                dbitem.KhoKhan = item.KhoKhan;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == item.IDDeTai);
                if (detai != null)
                {
                    dbitem.TenDeTai = detai.TenTiengViet;
                    dbitem.ChuNhiemDeTai = detai.tbl_CUS_HRM_STAFF_NhanSu1 != null ? detai.tbl_CUS_HRM_STAFF_NhanSu1.Name : "";
                    dbitem.SoNCT = detai.SoNCT;
                    dbitem.NCVChinh = detai.tbl_CUS_HRM_STAFF_NhanSu.Name;

                    if (detai.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_DaDuyet)
                    {
                        var trangthaiHDDD = db.tbl_PRO_TrangThai_Log.Where(c => c.IDDeTai == item.IDDeTai && c.IDTrangThaiMoi == -(int)SYSVarType.TrangThai_HDDD_DaDuyet).OrderByDescending(c => c.CreatedDate).FirstOrDefault();
                        if (trangthaiHDDD != null)
                            dbitem.NgayDuyetNghienCuu = trangthaiHDDD.CreatedDate.ToString("dd/MM/yyyy HH:mm:ss");
                    }
                    else
                    {
                        item.Error = "Đề tài chưa duyệt, không thể tạo báo cáo";
                        return item;
                    }

                    var donxindanhgiaDD = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == item.IDDeTai && c.IsDeleted == false);
                    if (donxindanhgiaDD != null)
                    {
                        dbitem.ThoiGianTienHanh = donxindanhgiaDD.ThoiGianNghienCuu;
                    }

                    var thuyetminhdetai = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == item.IDDeTai && c.IsDeleted == false);
                    if (thuyetminhdetai != null)
                    {
                        dbitem.CoMau = thuyetminhdetai.B3222_CoMau;
                    }
                }

                try
                {
                    db.tbl_PRO_BaoCaoTienDoNghienCuu.Add(dbitem);
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoTienDoNghienCuu", DateTime.Now, Username);


                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_PRO_BaoCaoTienDoNghienCuuCustom", e);
                    item = null;
                }
            }
            return item;
        }

    }
}
