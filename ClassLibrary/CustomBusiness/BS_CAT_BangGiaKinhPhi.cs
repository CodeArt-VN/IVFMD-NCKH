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
    public static partial class BS_CAT_BangGiaKinhPhi
    {
        public static IQueryable<DTO_CAT_BangGiaKinhPhi> get_CAT_BangGiaKinhPhiCustom(AppEntities db, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_CAT_BangGiaKinhPhi.Where(d => d.IsDeleted == false);

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

            //Query IDKinhPhi (int)
            if (QueryStrings.Any(d => d.Key == "IDKinhPhi"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDKinhPhi").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDKinhPhi));
            }

            //Query NgayHieuLuc (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "NgayHieuLucFrom") && QueryStrings.Any(d => d.Key == "NgayHieuLucTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHieuLucFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHieuLucTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayHieuLuc && d.NgayHieuLuc <= toDate);

            //Query Gia (decimal)
            if (QueryStrings.Any(d => d.Key == "GiaFrom") && QueryStrings.Any(d => d.Key == "GiaTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "GiaFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "GiaTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.Gia && d.Gia <= toVal);

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

            return toDTOCustom(query);
        }

        public static IQueryable<DTO_CAT_BangGiaKinhPhi> toDTOCustom(IQueryable<tbl_CAT_BangGiaKinhPhi> query)
        {
            return query
            .Select(s => new DTO_CAT_BangGiaKinhPhi()
            {
                ID = s.ID,
                IDKinhPhi = s.IDKinhPhi,
                KinhPhi = s.tbl_CAT_KinhPhi.Name,
                Gia = s.Gia,
                NgayHieuLuc = s.NgayHieuLuc,
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
