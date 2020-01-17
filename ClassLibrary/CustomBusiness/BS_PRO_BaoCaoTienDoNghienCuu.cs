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
                query = query.Where(d => d.tbl_PRO_DeTai.DeTai == keyword);
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
                query = query.Where(d => d.tbl_PRO_DeTai.DeTai == keyword);
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
                TenDeTai = s.tbl_PRO_DeTai.DeTai,
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
    }
}
