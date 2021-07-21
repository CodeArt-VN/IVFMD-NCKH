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

        public static List<DTO_PRO_BaoCaoTienDoNghienCuu_DeTai> get_PRO_BaoCaoTienDoNghienCuuTheoDeTai(AppEntities db, Dictionary<string, string> QueryStrings)
        {
            List<DTO_PRO_BaoCaoTienDoNghienCuu_DeTai> result = new List<DTO_PRO_BaoCaoTienDoNghienCuu_DeTai>();
            List<int> ListStatusID = new List<int>();
            var query = db.tbl_PRO_BaoCaoTienDoNghienCuu.AsQueryable();
            if (QueryStrings.Any(d => d.Key == "ListStatusID") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ListStatusID").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ListStatusID").Value;
                try
                {
                    ListStatusID = keyword.Split(',').Select(int.Parse).ToList();
                    if (ListStatusID.Count > 0)
                        query = query.Where(c => c.tbl_PRO_DeTai.IDTinhTrangNghienCuu > 0 && ListStatusID.Contains(c.tbl_PRO_DeTai.IDTinhTrangNghienCuu.Value));
                }
                catch { }
            }

            if (QueryStrings.Any(d => d.Key == "DateFrom") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value.Replace("\\", "");
                try
                {

                    DateTime dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(keyword).ToLocalTime();
                    query = query.Where(c => c.CreatedDate >= dt);
                }
                catch { }
            }

            if (QueryStrings.Any(d => d.Key == "DateTo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value.Replace("\\", "");
                try
                {
                    DateTime dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(keyword).ToLocalTime();
                    query = query.Where(c => c.CreatedDate <= dt);
                }
                catch { }
            }

            query = query.Where(d => d.IsDeleted == false);

            var lstData = query.Select(c => new { c.IDDeTai, c.tbl_PRO_DeTai.SoNCT, c.tbl_PRO_DeTai.TenTiengViet, c.ChuNhiemDeTai, c.NCVChinh, c.NgayDuyetNghienCuu, c.ThoiGianTienHanh, c.CreatedBy, c.CreatedDate, SoLanDaBaoCao = db.tbl_PRO_BaoCaoTienDoNghienCuu.Count(d => d.IDDeTai == c.IDDeTai && d.IsDeleted == false) }).ToList();
            var lstIDDeTai = lstData.Select(c => c.IDDeTai).Distinct().ToList();
            foreach (var item in lstIDDeTai)
            {
                DTO_PRO_BaoCaoTienDoNghienCuu_DeTai obj = new DTO_PRO_BaoCaoTienDoNghienCuu_DeTai
                {
                    IDDeTai = item,
                };
                var detai = lstData.Where(c => c.IDDeTai == item).OrderByDescending(c => c.CreatedDate).FirstOrDefault();
                if (detai != null)
                {
                    obj.TenDeTai = detai.TenTiengViet;
                    obj.ChuNhiemDeTai = detai.ChuNhiemDeTai;
                    obj.NCVChinh = detai.NCVChinh;
                    obj.NgayDuyetNghienCuu = detai.NgayDuyetNghienCuu;
                    obj.SoNCT = detai.SoNCT;
                    obj.ThoiGianTienHanh = detai.ThoiGianTienHanh;
                    obj.LastReportDate = detai.CreatedDate;
                    obj.LastReportBy = detai.CreatedBy;
                    obj.SoLanDaBaoCao = detai.SoLanDaBaoCao;
                    var trangthaiHDDD = db.tbl_PRO_TrangThai_Log.Where(c => c.IDDeTai == obj.IDDeTai && c.IDTrangThaiMoi == -(int)SYSVarType.TrangThai_HDDD_DaDuyet).OrderByDescending(c => c.CreatedDate).FirstOrDefault();
                    if (trangthaiHDDD != null && !string.IsNullOrEmpty(obj.ThoiGianTienHanh))
                    {
                        int month = 0;
                        try
                        {
                            month = Int32.Parse(obj.ThoiGianTienHanh);
                        }
                        catch { }
                        DateTime dtEnd = trangthaiHDDD.CreatedDate.AddMonths(month);
                        if (dtEnd < DateTime.Now)
                            obj.CompletePercent = 100;
                        else
                        {
                            try
                            {
                                obj.CompletePercent = Convert.ToInt32((DateTime.Now - trangthaiHDDD.CreatedDate).TotalDays / (dtEnd - trangthaiHDDD.CreatedDate).TotalDays * 100);
                                if (obj.CompletePercent > 100)
                                    obj.CompletePercent = 100;
                            }
                            catch { }
                        }
                    }
                    result.Add(obj);
                }
            }

            result = result.OrderByDescending(c => c.LastReportDate).ToList();
            return result;
        }

        public static List<DTO_PRO_BaoCaoTienDoNghienCuu> get_PRO_BaoCaoTienDoNghienCuuTheoDeTaiChiTiet(AppEntities db, Dictionary<string, string> QueryStrings)
        {
            List<DTO_PRO_BaoCaoTienDoNghienCuu> result = new List<DTO_PRO_BaoCaoTienDoNghienCuu>();
            List<int> ListStatusID = new List<int>();
            var query = db.tbl_PRO_BaoCaoTienDoNghienCuu.AsQueryable();
            if (QueryStrings.Any(d => d.Key == "ListStatusID") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ListStatusID").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ListStatusID").Value;
                try
                {
                    ListStatusID = keyword.Split(',').Select(int.Parse).ToList();
                    if (ListStatusID.Count > 0)
                        query = query.Where(c => c.tbl_PRO_DeTai.IDTinhTrangNghienCuu > 0 && ListStatusID.Contains(c.tbl_PRO_DeTai.IDTinhTrangNghienCuu.Value));
                }
                catch { }
            }

            if (QueryStrings.Any(d => d.Key == "DateFrom") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateFrom").Value;
                try
                {
                    DateTime dt = Convert.ToDateTime(keyword);
                    query = query.Where(c => c.CreatedDate >= dt);
                }
                catch { }
            }

            if (QueryStrings.Any(d => d.Key == "DateTo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DateTo").Value;
                try
                {
                    DateTime dt = Convert.ToDateTime(keyword);
                    query = query.Where(c => c.CreatedDate <= dt);
                }
                catch { }
            }

            query = query.Where(d => d.IsDeleted == false);

            var lstData = query.Select(c => new { c.IDDeTai, c.tbl_PRO_DeTai.SoNCT, c.tbl_PRO_DeTai.TenTiengViet, c.ChuNhiemDeTai, c.NCVChinh, c.NgayDuyetNghienCuu, c.ThoiGianTienHanh, c.CreatedBy, c.CreatedDate, SoLanDaBaoCao = db.tbl_PRO_BaoCaoTienDoNghienCuu.Count(d => d.IDDeTai == c.IDDeTai && d.IsDeleted == false), c.CoMau, c.KhoKhan, c.SoCaThuThapHopLe, c.TienDoThuNhanMau, TinhTrangNghienCuu = c.IDTinhTrangNghienCuu > 0 ? c.tbl_SYS_Var.ValueOfVar : "", TinhTrangNghienCuuHienTai = c.tbl_PRO_DeTai.IDTinhTrangNghienCuu > 0 ? c.tbl_PRO_DeTai.tbl_SYS_Var6.ValueOfVar : "" }).ToList();
            foreach (var itemGroup in lstData.GroupBy(c=>c.IDDeTai))
            {
                var trangthaiHDDD = db.tbl_PRO_TrangThai_Log.Where(c => c.IDDeTai == itemGroup.Key && c.IDTrangThaiMoi == -(int)SYSVarType.TrangThai_HDDD_DaDuyet).OrderByDescending(c => c.CreatedDate).FirstOrDefault();
                foreach (var item in itemGroup)
                {
                    DTO_PRO_BaoCaoTienDoNghienCuu obj = new DTO_PRO_BaoCaoTienDoNghienCuu
                    {
                        IDDeTai = item.IDDeTai,
                        TenDeTai = item.TenTiengViet,
                        ChuNhiemDeTai = item.ChuNhiemDeTai,
                        CoMau = item.CoMau,
                        KhoKhan = item.KhoKhan,
                        SoCaThuThapHopLe = item.SoCaThuThapHopLe,
                        SoLanDaBaoCao = item.SoLanDaBaoCao,
                        SoNCT = item.SoNCT,
                        NCVChinh = item.NCVChinh,
                        NgayDuyetNghienCuu = item.NgayDuyetNghienCuu,
                        TienDoThuNhanMau = item.TienDoThuNhanMau,
                        TinhTrangNghienCuu = item.TinhTrangNghienCuu,
                        TinhTrangNghienCuuHienTai = item.TinhTrangNghienCuuHienTai,
                        ThoiGianTienHanh = item.ThoiGianTienHanh,
                        CreatedBy = item.CreatedBy,
                        CreatedDate = item.CreatedDate
                    };

                    if (trangthaiHDDD != null && !string.IsNullOrEmpty(item.ThoiGianTienHanh))
                    {
                        int month = 0;
                        try
                        {
                            month = Int32.Parse(item.ThoiGianTienHanh);
                        }
                        catch { }
                        DateTime dtEnd = trangthaiHDDD.CreatedDate.AddMonths(month);
                        if (dtEnd < DateTime.Now)
                            obj.CompletePercent = 100;
                        else
                        {
                            try
                            {
                                obj.CompletePercent = Convert.ToInt32(Math.Round((dtEnd - DateTime.Now).TotalDays / (dtEnd - trangthaiHDDD.CreatedDate).TotalDays, 0));
                            }
                            catch { }
                        }
                    }

                    result.Add(obj);
                }
            }

            result = result.OrderBy(c => c.TenDeTai).OrderByDescending(c => c.CreatedDate).ToList();
            int sort = 1;
            foreach (var item in result)
            {
                item.Sort = sort++;
            }
            return result;
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
                IDTinhTrangNghienCuu = s.IDTinhTrangNghienCuu,
                TinhTrangNghienCuu =  s.IDTinhTrangNghienCuu > 0 ? s.tbl_SYS_Var.ValueOfVar : "",
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
                dbitem.IDTinhTrangNghienCuu = item.IDTinhTrangNghienCuu ?? -(int)SYSVarType.PhanLoaiDeTai;
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                string sKey = SYSConfigCode.ThoiGianBaoCaoTDNC.ToString();
                var config = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == sKey && !c.IsDeleted);
                if (config != null)
                {
                    try
                    {
                        var setting = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_SYS_Config_ThoiGianBaoCaoTDNC>(config.Value);
                        if (setting != null)
                        {
                            int GiaiDoan1_NgayBatDau = setting.GiaiDoan1_NgayBatDau;
                            int GiaiDoan1_NgayKetThuc = setting.GiaiDoan1_NgayKetThuc;
                            int GiaiDoan2_NgayBatDau = setting.GiaiDoan2_NgayBatDau;
                            int GiaiDoan2_NgayKetThuc = setting.GiaiDoan2_NgayKetThuc;
                            bool isSuccess = false;
                            if (GiaiDoan1_NgayBatDau > 0 && GiaiDoan1_NgayKetThuc > 0)
                            {
                                if (dbitem.CreatedDate.Day >= GiaiDoan1_NgayBatDau && dbitem.CreatedDate.Day <= GiaiDoan1_NgayKetThuc)
                                {
                                    isSuccess = true;
                                }
                            }

                            if (!isSuccess && GiaiDoan2_NgayBatDau > 0 && GiaiDoan2_NgayKetThuc > 0)
                            {
                                if (dbitem.CreatedDate.Day >= GiaiDoan2_NgayBatDau && dbitem.CreatedDate.Day <= GiaiDoan2_NgayKetThuc)
                                {
                                    isSuccess = true;
                                }
                            }
                            if (!isSuccess)
                            {
                                item.Error = "Đã hết thời hạn được báo cáo, thời hạn báo cáo cho phép từ ngày " + GiaiDoan1_NgayBatDau.ToString("00") + " đến " + GiaiDoan1_NgayKetThuc.ToString("00") + " và từ ngày " + GiaiDoan2_NgayBatDau.ToString("00") + " đến " + GiaiDoan2_NgayKetThuc.ToString("00") + " hằng tháng";
                                return item;
                            }
                        }
                    }
                    catch { }
                }

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == item.IDDeTai);
                if (detai != null)
                {
                    detai.IDTinhTrangNghienCuu = dbitem.IDTinhTrangNghienCuu;

                    dbitem.TenDeTai = detai.TenTiengViet;
                    dbitem.ChuNhiemDeTai = detai.tbl_CUS_HRM_STAFF_NhanSu1 != null ? detai.tbl_CUS_HRM_STAFF_NhanSu1.Name : "";
                    dbitem.SoNCT = detai.SoNCT;
                    dbitem.NCVChinh = detai.tbl_CUS_HRM_STAFF_NhanSu.Name;

                    if (detai.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_DaDuyet)
                    {
                        var trangthaiHDDD = db.tbl_PRO_TrangThai_Log.Where(c => c.IDDeTai == item.IDDeTai && c.IDTrangThaiMoi == -(int)SYSVarType.TrangThai_HDDD_DaDuyet).OrderByDescending(c => c.CreatedDate).FirstOrDefault();
                        if (trangthaiHDDD != null)
                            dbitem.NgayDuyetNghienCuu = trangthaiHDDD.CreatedDate.ToString("dd/MM/yyyy HH:mm");
                    }
                    else
                    {
                        item.Error = "Đề tài chưa duyệt HĐĐĐ, không thể tạo báo cáo";
                        return item;
                    }

                    var donxindanhgiaDD = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == item.IDDeTai && c.IsDeleted == false);
                    if (donxindanhgiaDD != null)
                    {
                        dbitem.ThoiGianTienHanh = donxindanhgiaDD.ThoiGianNghienCuu;
                    }

                    //var thuyetminhdetai = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == item.IDDeTai && c.IsDeleted == false);
                    //if (thuyetminhdetai != null)
                    //{
                    //    dbitem.CoMau = thuyetminhdetai.B3222_CoMau;
                    //}
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

        public static string put_PRO_BaoCaoTienDoNghienCuuCustom(AppEntities db, int ID, DTO_PRO_BaoCaoTienDoNghienCuu item, string Username)
        {
            string result = string.Empty;
            var dbitem = db.tbl_PRO_BaoCaoTienDoNghienCuu.Find(ID);
            if (dbitem != null)
            {
                dbitem.IDDeTai = item.IDDeTai;
                dbitem.SoCaThuThapHopLe = item.SoCaThuThapHopLe;
                dbitem.TienDoThuNhanMau = item.TienDoThuNhanMau;
                dbitem.KhoKhan = item.KhoKhan;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;
                dbitem.TenDeTai = item.TenDeTai;
                dbitem.ChuNhiemDeTai = item.ChuNhiemDeTai;
                dbitem.NCVChinh = item.NCVChinh;
                dbitem.NgayDuyetNghienCuu = item.NgayDuyetNghienCuu;
                dbitem.SoNCT = item.SoNCT;
                dbitem.ThoiGianTienHanh = item.ThoiGianTienHanh;
                dbitem.CoMau = item.CoMau;
                dbitem.IDTinhTrangNghienCuu = item.IDTinhTrangNghienCuu;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                string sKey = SYSConfigCode.ThoiGianBaoCaoTDNC.ToString();
                var config = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == sKey && !c.IsDeleted);
                if (config != null)
                {
                    try
                    {
                        var setting = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_SYS_Config_ThoiGianBaoCaoTDNC>(config.Value);
                        if (setting != null)
                        {
                            int GiaiDoan1_NgayBatDau = setting.GiaiDoan1_NgayBatDau;
                            int GiaiDoan1_NgayKetThuc = setting.GiaiDoan1_NgayKetThuc;
                            int GiaiDoan2_NgayBatDau = setting.GiaiDoan2_NgayBatDau;
                            int GiaiDoan2_NgayKetThuc = setting.GiaiDoan2_NgayKetThuc;
                            bool isSuccess = false;
                            if (GiaiDoan1_NgayBatDau > 0 && GiaiDoan1_NgayKetThuc > 0)
                            {
                                if (dbitem.ModifiedDate.Value.Day >= GiaiDoan1_NgayBatDau && dbitem.ModifiedDate.Value.Day <= GiaiDoan1_NgayKetThuc)
                                {
                                    isSuccess = true;
                                }
                            }

                            if (!isSuccess && GiaiDoan2_NgayBatDau > 0 && GiaiDoan2_NgayKetThuc > 0)
                            {
                                if (dbitem.ModifiedDate.Value.Day >= GiaiDoan2_NgayBatDau && dbitem.ModifiedDate.Value.Day <= GiaiDoan2_NgayKetThuc)
                                {
                                    isSuccess = true;
                                }
                            }
                            if (!isSuccess)
                                item.Error = "Đã hết thời hạn được báo cáo, thời hạn báo cáo cho phép từ ngày " + GiaiDoan1_NgayBatDau.ToString("00") + " đến " + GiaiDoan1_NgayKetThuc.ToString("00") + " và từ ngày " + GiaiDoan2_NgayBatDau.ToString("00") + " đến " + GiaiDoan2_NgayKetThuc.ToString("00") + " hằng tháng";
                        }
                    }
                    catch { }
                }

                try
                {
                    var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == item.IDDeTai);
                    if (detai != null)
                    {
                        detai.IDTinhTrangNghienCuu = dbitem.IDTinhTrangNghienCuu;
                    }
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoTienDoNghienCuu", DateTime.Now, Username);
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("put_PRO_BaoCaoTienDoNghienCuuCustom", e);
                    result = e.Message;
                }
            }
            return result;
        }
    }
}
