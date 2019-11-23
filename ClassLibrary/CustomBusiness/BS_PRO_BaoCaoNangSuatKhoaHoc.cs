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
        public static IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> get_PRO_BaoCaoNangSuatKhoaHocCustom(AppEntities db, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.AsQueryable();

            query = query.Where(d => d.IsDeleted == false);


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

        public static IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> get_PRO_BaoCaoNangSuatKhoaHocByDeTai(AppEntities db, int deTaiId, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.AsQueryable();

            query = query.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false);


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
            });
        }
    }
}
