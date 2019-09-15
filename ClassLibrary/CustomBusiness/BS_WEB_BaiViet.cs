namespace BaseBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using DTOModel;
    using ClassLibrary;
    using System.Data.Entity.Validation;

    public static partial class BS_WEB_BaiViet
    {
        public static IQueryable<DTO_WEB_BaiViet> toCDTO(IQueryable<tbl_WEB_BaiViet> query)
        {
            return query
            .Select(s => new DTO_WEB_BaiViet()
            {
                IDDanhMuc = s.IDDanhMuc,
                IDParent = s.IDParent,
                ID = s.ID,
                Code = s.Code,
                Name = s.Name,
                Remark = s.Remark,
                Sort = s.Sort,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedBy = s.CreatedBy,
                ModifiedBy = s.ModifiedBy,
                CreatedDate = s.CreatedDate,
                ModifiedDate = s.ModifiedDate,
                Type = s.Type,
                ThumbnailImage = s.ThumbnailImage,
                Image = s.Image,
                AlternateImage = s.AlternateImage,
                NgayDangBaiViet = s.NgayDangBaiViet,
                LuotXem = s.LuotXem,
                DanhGia = s.DanhGia,
                AllowComment = s.AllowComment,
                LuotThich = s.LuotThich,
                //NgonNgu = s.NgonNgu,
                Summary = s.Summary,
                //NoiDung = s.NoiDung,
                TenKhac = s.TenKhac,
                ReadMoreText = s.ReadMoreText,
                SEO1 = s.SEO1,
                SEO2 = s.SEO2,
                Duyet = s.Duyet,
                URL = s.URL,
                Pin = s.Pin,
                PinPos = s.PinPos,
                Home = s.Home,
                HomePos = s.HomePos,
            }).OrderBy(o => o.Sort == null).ThenBy(o=>o.Sort).ThenByDescending(o=>o.CreatedDate);
        }

        public static IQueryable<DTO_WEB_BaiViet> get_WEB_BaiViet(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings, bool Custome)
        {
            var query = db.tbl_WEB_BaiViet
            .Where(d => d.IsDeleted == false);


            //Query keyword
            if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d => d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



            //Query IDDanhMuc (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDDanhMuc"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDanhMuc").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDanhMuc));
            }

            //Query IDParent (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDParent"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDParent").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDParent));
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

            //Query Code (string)
            if (QueryStrings.Any(d => d.Key == "Code") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Code").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Code").Value;
                query = query.Where(d => d.Code == keyword);
            }

            //Query Name (string)
            if (QueryStrings.Any(d => d.Key == "Name") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Name").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Name").Value;
                query = query.Where(d => d.Name == keyword);
            }

            //Query Remark (string)
            if (QueryStrings.Any(d => d.Key == "Remark") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Remark").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Remark").Value;
                query = query.Where(d => d.Remark == keyword);
            }

            //Query Sort (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "SortFrom") && QueryStrings.Any(d => d.Key == "SortTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "SortFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "SortTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.Sort && d.Sort <= toVal);

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

            //Query CreatedBy (string)
            if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d => d.CreatedBy == keyword);
            }

            //Query ModifiedBy (string)
            if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d => d.ModifiedBy == keyword);
            }

            //Query CreatedDate (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

            //Query ModifiedDate (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

            //Query Type (int)
            if (QueryStrings.Any(d => d.Key == "TypeFrom") && QueryStrings.Any(d => d.Key == "TypeTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TypeFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TypeTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.Type && d.Type <= toVal);

            //Query ThumbnailImage (string)
            if (QueryStrings.Any(d => d.Key == "ThumbnailImage") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThumbnailImage").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThumbnailImage").Value;
                query = query.Where(d => d.ThumbnailImage == keyword);
            }

            //Query Image (string)
            if (QueryStrings.Any(d => d.Key == "Image") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Image").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Image").Value;
                query = query.Where(d => d.Image == keyword);
            }

            //Query AlternateImage (string)
            if (QueryStrings.Any(d => d.Key == "AlternateImage") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "AlternateImage").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "AlternateImage").Value;
                query = query.Where(d => d.AlternateImage == keyword);
            }

            //Query NgayDangBaiViet (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "NgayDangBaiVietFrom") && QueryStrings.Any(d => d.Key == "NgayDangBaiVietTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDangBaiVietFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDangBaiVietTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayDangBaiViet && d.NgayDangBaiViet <= toDate);

            //Query LuotXem (int)
            if (QueryStrings.Any(d => d.Key == "LuotXemFrom") && QueryStrings.Any(d => d.Key == "LuotXemTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LuotXemFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LuotXemTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.LuotXem && d.LuotXem <= toVal);

            //Query DanhGia (string)
            if (QueryStrings.Any(d => d.Key == "DanhGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DanhGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DanhGia").Value;
                query = query.Where(d => d.DanhGia == keyword);
            }

            //Query AllowComment (bool)
            if (QueryStrings.Any(d => d.Key == "AllowComment"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "AllowComment").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.AllowComment);
            }

            //Query LuotThich (int)
            if (QueryStrings.Any(d => d.Key == "LuotThichFrom") && QueryStrings.Any(d => d.Key == "LuotThichTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LuotThichFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LuotThichTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.LuotThich && d.LuotThich <= toVal);

            //Query NgonNgu (string)
            if (QueryStrings.Any(d => d.Key == "NgonNgu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgonNgu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgonNgu").Value;
                query = query.Where(d => d.NgonNgu == keyword);
            }

            //Query Summary (string)
            if (QueryStrings.Any(d => d.Key == "Summary") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Summary").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Summary").Value;
                query = query.Where(d => d.Summary == keyword);
            }

            //Query NoiDung (string)
            if (QueryStrings.Any(d => d.Key == "NoiDung") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NoiDung").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NoiDung").Value;
                query = query.Where(d => d.NoiDung == keyword);
            }

            //Query TenKhac (string)
            if (QueryStrings.Any(d => d.Key == "TenKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenKhac").Value;
                query = query.Where(d => d.TenKhac == keyword);
            }

            //Query ReadMoreText (string)
            if (QueryStrings.Any(d => d.Key == "ReadMoreText") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ReadMoreText").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ReadMoreText").Value;
                query = query.Where(d => d.ReadMoreText == keyword);
            }

            //Query SEO1 (string)
            if (QueryStrings.Any(d => d.Key == "SEO1") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SEO1").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SEO1").Value;
                query = query.Where(d => d.SEO1 == keyword);
            }

            //Query SEO2 (string)
            if (QueryStrings.Any(d => d.Key == "SEO2") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SEO2").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SEO2").Value;
                query = query.Where(d => d.SEO2 == keyword);
            }

            //Query Duyet (bool)
            if (QueryStrings.Any(d => d.Key == "Duyet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "Duyet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.Duyet);
            }

            //Query URL (string)
            if (QueryStrings.Any(d => d.Key == "URL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "URL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "URL").Value;
                query = query.Where(d => d.URL == keyword);
            }

            //Query Pin (bool)
            if (QueryStrings.Any(d => d.Key == "Pin"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "Pin").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.Pin);
            }

            //Query PinPos (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "PinPosFrom") && QueryStrings.Any(d => d.Key == "PinPosTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "PinPosFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "PinPosTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.PinPos && d.PinPos <= toVal);

            //Query Home (bool)
            if (QueryStrings.Any(d => d.Key == "Home"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "Home").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.Home);
            }

            //Query HomePos (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "HomePosFrom") && QueryStrings.Any(d => d.Key == "HomePosTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "HomePosFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "HomePosTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.HomePos && d.HomePos <= toVal);


            return toCDTO(query);

        }


    }
}
