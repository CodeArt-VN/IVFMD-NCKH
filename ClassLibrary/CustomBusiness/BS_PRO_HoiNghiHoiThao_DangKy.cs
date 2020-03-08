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
    public static partial class BS_PRO_HoiNghiHoiThao_DangKy
    {
        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKy> get_PRO_HoiNghiHoiThao_DangKyTheoHoiNghi(AppEntities db, Dictionary<string, string> QueryStrings, int idHoiNghi)
        {
            var query = db.tbl_PRO_HoiNghiHoiThao_DangKy.Where(c => c.IDHoiNghiHoiThao == idHoiNghi).AsQueryable();

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

            //Query IDNhanVien (int)
            if (QueryStrings.Any(d => d.Key == "IDNhanVien"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhanVien").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhanVien));
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

        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKy> toDTOCustom(IQueryable<tbl_PRO_HoiNghiHoiThao_DangKy> query)
        {
            return query
            .Select(s => new DTO_PRO_HoiNghiHoiThao_DangKy()
            {
                ID = s.ID,
                IDNhanVien = s.IDNhanVien,
                TenNCV = s.tbl_CUS_HRM_STAFF_NhanSu.Name,
                IDHoiNghiHoiThao = s.IDHoiNghiHoiThao,
                TenHoiNghi = s.tbl_PRO_HoiNghiHoiThao.TenHoiNghi,
                SoDeTaiDangKy = s.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Count(d => d.IDDangKy == s.ID),
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            });
        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKy> get_PRO_HoiNghiHoiThao_DangKyTheoNCV(AppEntities db, Dictionary<string, string> QueryStrings, int StaffID)
        {
            var query = db.tbl_PRO_HoiNghiHoiThao_DangKy.Where(c => c.IDNhanVien == StaffID).AsQueryable();

            return query
            .Select(s => new DTO_PRO_HoiNghiHoiThao_DangKy()
            {
                ID = s.ID,
                IDNhanVien = s.IDNhanVien,
                IDHoiNghiHoiThao = s.IDHoiNghiHoiThao,
                TenHoiNghi = s.tbl_PRO_HoiNghiHoiThao.TenHoiNghi,
                DiaDiem = s.tbl_PRO_HoiNghiHoiThao.DiaDiem,
                ThoiGian = s.tbl_PRO_HoiNghiHoiThao.ThoiGian.Value,
                ThoiGianHetHan = s.tbl_PRO_HoiNghiHoiThao.ThoiGianHetHan,
                SoDeTaiDangKy = s.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Count(d => d.IDDangKy == s.ID),
                CreatedBy = s.CreatedBy,
                CreatedDate = s.CreatedDate
            });
        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao> get_PRO_HoiNghiHoiThao_ChuaDangKy(AppEntities db, Dictionary<string, string> QueryStrings, int StaffID)
        {
            var query = db.tbl_PRO_HoiNghiHoiThao.Where(c => c.IsDeleted == false && c.IsDisabled == false && c.tbl_PRO_HoiNghiHoiThao_DangKy.Any(d => d.IDNhanVien == StaffID) == false).Select(s => new DTO_PRO_HoiNghiHoiThao()
            {
                ID = s.ID,
                ThoiGian = s.ThoiGian,
                ThoiGianHetHan = s.ThoiGianHetHan,
                DiaDiem = s.DiaDiem,
                TenHoiNghi = s.TenHoiNghi,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                CoTheDangKy = s.ThoiGianHetHan < DateTime.Now,
                ChoPhepDangKy = s.ThoiGianHetHan < DateTime.Now ? "Đăng ký đề tài" : "Đã hết hạn"
            }).OrderBy(c => c.ThoiGianHetHan);

            return query;
        }

        public static DTO_PRO_HoiNghiHoiThao_DangKy post_PRO_HoiNghiHoiThao_DangKyCustom(AppEntities db, DTO_PRO_HoiNghiHoiThao_DangKy item, string Username)
        {
            tbl_PRO_HoiNghiHoiThao_DangKy dbitem = new tbl_PRO_HoiNghiHoiThao_DangKy();
            if (item != null)
            {
                dbitem.IDNhanVien = item.IDNhanVien;
                dbitem.IDHoiNghiHoiThao = item.IDHoiNghiHoiThao;

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                var hoinghi = db.tbl_PRO_HoiNghiHoiThao.FirstOrDefault(c => c.ID == item.IDHoiNghiHoiThao);
                if (hoinghi != null)
                {
                    if (hoinghi.ThoiGianHetHan < DateTime.Now)
                    {
                        item.Error = "Hội nghị đã hết hạn đăng ký!";
                        return item;
                    }
                }

                try
                {
                    db.tbl_PRO_HoiNghiHoiThao_DangKy.Add(dbitem);
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKy", DateTime.Now, Username);


                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_PRO_HoiNghiHoiThao_DangKy", e);
                    item = null;
                }
            }
            return item;
        }

    }
}
