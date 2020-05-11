
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

    public static partial class BS_CUS_HRM_STAFF_NhanSu
    {
        public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu> ctoDTO(IQueryable<tbl_CUS_HRM_STAFF_NhanSu> query)
        {
            return query
            .Select(s => new DTO_CUS_HRM_STAFF_NhanSu()
            {
                IDPartner = s.IDPartner,
                IDChucDanh = s.IDChucDanh,
                IDBoPhan = s.IDBoPhan,
                IDRole = s.IDRole,
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
                Ten = s.Ten,
                Ho = s.Ho,
                Email = s.Email,
                SoDienThoai = s.SoDienThoai,
                DiaChi = s.DiaChi,
                RoleName = s.IDRole.HasValue ? s.tbl_CUS_SYS_Role.Name: "",
                IsHRCO = s.IsHRCO,
                IsCNDT = s.IsCNDT,
                CNDT = s.IsCNDT == true ? "Chủ nhiệm đề tài" : ""
            }).OrderBy(o => o.Sort); 
        }

        public static DTO_CUS_HRM_STAFF_NhanSu ctoDTO(tbl_CUS_HRM_STAFF_NhanSu dbResult)
        {
            if (dbResult != null)
            {
                return new DTO_CUS_HRM_STAFF_NhanSu()
                {
                    IDPartner = dbResult.IDPartner,
                    IDChucDanh = dbResult.IDChucDanh,
                    IDBoPhan = dbResult.IDBoPhan,
                    IDRole = dbResult.IDRole,
                    ID = dbResult.ID,
                    Code = dbResult.Code,
                    Name = dbResult.Name,
                    Remark = dbResult.Remark,
                    Sort = dbResult.Sort,
                    IsDisabled = dbResult.IsDisabled,
                    IsDeleted = dbResult.IsDeleted,
                    CreatedBy = dbResult.CreatedBy,
                    ModifiedBy = dbResult.ModifiedBy,
                    CreatedDate = dbResult.CreatedDate,
                    ModifiedDate = dbResult.ModifiedDate,
                    Ten = dbResult.Ten,
                    Ho = dbResult.Ho,
                    Email = dbResult.Email,
                    SoDienThoai = dbResult.SoDienThoai,
                    DiaChi = dbResult.DiaChi,
                    RoleName = dbResult.IDRole.HasValue ? dbResult.tbl_CUS_SYS_Role.Name : "",
                    IsHRCO = dbResult.IsHRCO,
                    IsCNDT = dbResult.IsCNDT
                };
            }
            else
                return null;
        }

        public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu> get_CUS_HRM_STAFF_NhanSu(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings, bool isChuNhiem)
        {


            var query = db.tbl_CUS_HRM_STAFF_NhanSu
            .Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);

            if (isChuNhiem)
            {
                query = query.Where(c => c.IsCNDT == true).OrderBy(c => c.Name);
            }


            //Query keyword
            if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d => d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



            //Query IDPartner (int)
            if (QueryStrings.Any(d => d.Key == "IDPartner"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPartner").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPartner));
            }

            //Query IDChucDanh (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDChucDanh"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDChucDanh").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => d.IDChucDanh.HasValue && IDs.Contains(d.IDChucDanh.Value));
            }

            //Query IDBoPhan (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDBoPhan"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDBoPhan").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => d.IDBoPhan.HasValue && IDs.Contains(d.IDBoPhan.Value));
            }

            //Query IDRole (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDRole"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDRole").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => d.IDRole.HasValue && IDs.Contains(d.IDRole.Value));
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

            //Query Ten (string)
            if (QueryStrings.Any(d => d.Key == "Ten") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Ten").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Ten").Value;
                query = query.Where(d => d.Ten == keyword);
            }

            //Query Ho (string)
            if (QueryStrings.Any(d => d.Key == "Ho") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Ho").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Ho").Value;
                query = query.Where(d => d.Ho == keyword);
            }

            //Query Email (string)
            if (QueryStrings.Any(d => d.Key == "Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email").Value;
                query = query.Where(d => d.Email == keyword);
            }

            //Query SoDienThoai (string)
            if (QueryStrings.Any(d => d.Key == "SoDienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoai").Value;
                query = query.Where(d => d.SoDienThoai == keyword);
            }

            //Query DiaChi (string)
            if (QueryStrings.Any(d => d.Key == "DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value;
                query = query.Where(d => d.DiaChi == keyword);
            }


            return ctoDTO(query);

        }

        public static DTO_CUS_HRM_STAFF_NhanSu get_CUS_HRM_STAFF_NhanSu(AppEntities db, int PartnerID, int id, bool isChuNhiem)
        {
            var dbResult = db.tbl_CUS_HRM_STAFF_NhanSu.Find(id);

            if (dbResult == null || dbResult.IDPartner != PartnerID)
                return null;
            else
                return ctoDTO(dbResult);

        }

        public static string check_CUS_HRM_STAFF_NhanSu(AppEntities db, int id, DTO_CUS_HRM_STAFF_NhanSu item)
        {
            var obj = db.tbl_CUS_HRM_STAFF_NhanSu.Find(id);

            if (obj != null)
            {
                if (obj.IsCNDT == true && item.IsCNDT == false)
                {
                    if (db.tbl_PRO_DeTai.Any(c => c.IDChuNhiem == obj.ID && c.IsDeleted == false))
                    {
                        return "Nhân sự đã tham gia vào dự án có vai trò chủ nhiệm, không thể chỉnh sửa";
                    }
                }
            }

            return string.Empty;
        }

    }
}