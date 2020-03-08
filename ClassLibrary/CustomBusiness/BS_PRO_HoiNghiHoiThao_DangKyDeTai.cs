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
            var query = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Where(c => c.IDHoiNghiHoiThao == idHoiNghi).AsQueryable();

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
            });
        }
    }
}
