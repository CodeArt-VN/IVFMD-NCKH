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
    public static partial class BS_PRO_BaoCaoNghiemThuDeTai
    {
        public static DTO_PRO_BaoCaoNghiemThuDeTai get_PRO_BaoCaoNghiemThuDeTaiCustom(AppEntities db, int idDeTai, int? id = -1)
        {
            DTO_PRO_BaoCaoNghiemThuDeTai query = null;
            if (id > 0)
            {
                query = db.tbl_PRO_BaoCaoNghiemThuDeTai.Where(d => d.ID == id).Select(s => new DTO_PRO_BaoCaoNghiemThuDeTai
                {
                    ID = s.ID,
                    IDDeTai = s.IDDeTai,
                    TenDeTai = s.TenDeTai,
                    ChuNhiemDeTai = s.ChuNhiemDeTai,
                    JSON_DanhSachThamGia = s.JSON_DanhSachThamGia,
                    JSON_TomTat = s.JSON_TomTat,
                    JSON_Abstract = s.JSON_Abstract,
                    JSON_LoiCamOn = s.JSON_LoiCamOn,
                    JSON_MucLuc = s.JSON_MucLuc,
                    JSON_CacChuVietTat = s.JSON_CacChuVietTat,
                    JSON_DanhMucCacBang = s.JSON_DanhMucCacBang,
                    JSON_MucTieu = s.JSON_MucTieu,
                    JSON_Chuong1 = s.JSON_Chuong1,
                    JSON_Chuong2 = s.JSON_Chuong2,
                    JSON_VatLieuPhuongPhap = s.JSON_VatLieuPhuongPhap,
                    JSON_Chuong3 = s.JSON_Chuong3,
                    JSON_Chuong4 = s.JSON_Chuong4,
                    JSON_Chuong5 = s.JSON_Chuong5,
                    JSON_KetLuan = s.JSON_KetLuan,
                    JSON_TaiLieuThamKhao = s.JSON_TaiLieuThamKhao,
                    HTML = s.HTML,
                    IsDisabled = s.IsDisabled,
                    IsDeleted = s.IsDeleted,
                    CreatedDate = s.CreatedDate,
                    CreatedBy = s.CreatedBy,
                    ModifiedDate = s.ModifiedDate,
                    ModifiedBy = s.ModifiedBy,
                    BaiFulltext = s.BaiFulltext,
                }).FirstOrDefault();

                //Edit
                if (!string.IsNullOrWhiteSpace(query.JSON_DanhSachThamGia))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_TomTat))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_Abstract))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_LoiCamOn))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CacChuVietTat))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_DanhMucCacBang))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_MucTieu))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_Chuong1))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_Chuong2))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_VatLieuPhuongPhap))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_Chuong3))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_Chuong4))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_Chuong5))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_KetLuan))
                {
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_TaiLieuThamKhao))
                {
                }
            }
            else
            {
                //New
                query = new DTO_PRO_BaoCaoNghiemThuDeTai
                {
                    IDDeTai = idDeTai,
                };

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == idDeTai);
                if (detai != null)
                {
                    query.TenDeTai = detai.TenTiengViet;
                    query.ChuNhiemDeTai = detai.tbl_CUS_HRM_STAFF_NhanSu1 != null ? detai.tbl_CUS_HRM_STAFF_NhanSu1.Name : "";
                }

                //query.ListCanThiepThuocThuLamSan = new List<DTO_PRO_BaoCaoNghiemThuDeTai_CanThiepThuocThuLamSan>() { new DTO_PRO_BaoCaoNghiemThuDeTai_CanThiepThuocThuLamSan() };
                //query.ListDanhGiaNCV = new List<DTO_PRO_BaoCaoNghiemThuDeTai_DanhGiaNCV>() { new DTO_PRO_BaoCaoNghiemThuDeTai_DanhGiaNCV() };
                //query.ListThuocSuDungDongThoi = new List<DTO_PRO_BaoCaoNghiemThuDeTai_ThuocSuDungDongThoi>() { new DTO_PRO_BaoCaoNghiemThuDeTai_ThuocSuDungDongThoi() };
                //query.ListThuocThuLamSan = new List<DTO_PRO_BaoCaoNghiemThuDeTai_ThuocThuLamSan>() { new DTO_PRO_BaoCaoNghiemThuDeTai_ThuocThuLamSan() };
            }

            return query;
        }

        public static DTO_PRO_BaoCaoNghiemThuDeTai save_PRO_BaoCaoNghiemThuDeTai(AppEntities db, DTO_PRO_BaoCaoNghiemThuDeTai item, string Username)
        {
            var dbitem = db.tbl_PRO_BaoCaoNghiemThuDeTai.Find(item.ID);
            if (dbitem == null)
            {
                dbitem = new tbl_PRO_BaoCaoNghiemThuDeTai();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                db.tbl_PRO_BaoCaoNghiemThuDeTai.Add(dbitem);
            }

            dbitem.IDDeTai = item.IDDeTai;
            dbitem.TenDeTai = item.TenDeTai;
            dbitem.ChuNhiemDeTai = item.ChuNhiemDeTai;
            dbitem.BaiFulltext = item.BaiFulltext;

            //if (item.ListThuocThuLamSan != null)
            //{
            //    dbitem.JSON_ThuocThuLamSang = JsonConvert.SerializeObject(item.ListThuocThuLamSan);
            //}
            //else
            //    dbitem.JSON_ThuocThuLamSang = string.Empty;

            //if (item.ListCanThiepThuocThuLamSan != null)
            //{
            //    dbitem.JSON_CanThiepThuocThuLamSang = JsonConvert.SerializeObject(item.ListCanThiepThuocThuLamSan);
            //}
            //else
            //    dbitem.JSON_CanThiepThuocThuLamSang = string.Empty;

            //if (item.ListThuocSuDungDongThoi != null)
            //{
            //    dbitem.JSON_ThuocSuDungDongThoi = JsonConvert.SerializeObject(item.ListThuocSuDungDongThoi);
            //}
            //else
            //    dbitem.JSON_ThuocSuDungDongThoi = string.Empty;

            //if (item.ListDanhGiaNCV != null)
            //{
            //    dbitem.JSON_DanhGiaNCV = JsonConvert.SerializeObject(item.ListDanhGiaNCV);
            //}
            //else
            //    dbitem.JSON_DanhGiaNCV = string.Empty;

            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            try
            {
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNghiemThuDeTai", DateTime.Now, Username);
                item.ID = dbitem.ID;
                item.CreatedBy = dbitem.CreatedBy;
                item.CreatedDate = dbitem.CreatedDate;

                item.ModifiedBy = dbitem.ModifiedBy;
                item.ModifiedDate = dbitem.ModifiedDate;
                return item;
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("save_PRO_BaoCaoNghiemThuDeTai", e);
                return null;
            }
        }

        public static bool uploadFullText_PRO_BaoCaoNghiemThuDeTai(AppEntities db, int ID, string path, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_BaoCaoNghiemThuDeTai.FirstOrDefault(c => c.IDDeTai == ID);
            if (dbitem == null)
            {
                dbitem = new tbl_PRO_BaoCaoNghiemThuDeTai();
                dbitem.CreatedDate = DateTime.Now;
                dbitem.CreatedBy = Username;
                dbitem.IDDeTai = ID;
                db.tbl_PRO_BaoCaoNghiemThuDeTai.Add(dbitem);
            }
            else
            {
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
            }

            dbitem.BaiFulltext = path;

            try
            {
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNghiemThuDeTai", DateTime.Now, Username);

                result = true;
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("uploadFullText_PRO_BaoCaoNghiemThuDeTai", e);
                result = false;
            }

            return result;
        }
    }
}
