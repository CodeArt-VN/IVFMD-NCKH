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
    public static partial class BS_PRO_DonXinXetDuyet
    {
        public static DTO_PRO_DonXinXetDuyet get_PRO_DonXinXetDuyetByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_DonXinXetDuyet.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false).Select(s => new DTO_PRO_DonXinXetDuyet
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                HoTenChuNhiem = s.HoTenChuNhiem,
                DonVi = s.DonVi,
                DiaChi = s.DiaChi,
                DienThoai = s.DienThoai,
                TenDeTai = s.TenDeTai,
                TenDonViChuTri = s.TenDonViChuTri,
                DiaChiDonVi = s.DiaChiDonVi,
                DienThoaiDonVi = s.DienThoaiDonVi,
                DiaDiemNghienCuu = s.DiaDiemNghienCuu,
                ThoiGianNghienCuu = s.ThoiGianNghienCuu,
                TuNgay = s.TuNgay,
                DenNgay = s.DenNgay,
                ThuyetMinhDeCuong = s.ThuyetMinhDeCuong,
                LLKHChuNhiem = s.LLKHChuNhiem,
                LLKHNCV = s.LLKHNCV,
                GiayToKhac = s.GiayToKhac,
                GhiChuGiayToKha = s.GhiChuGiayToKha,
                HTML = s.HTML,
                FormConfig = s.FormConfig,
                NgayKy_ChuKy = s.NgayKy_ChuKy,
                NgayKy_Nam = s.NgayKy_Nam,
                NgayKy_Ngay = s.NgayKy_Ngay,
                NgayKy_Thang = s.NgayKy_Thang,
                IsDisabled = s.tbl_PRO_DeTai.IsDisabledHDDD ?? false,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                NgayKy_ChuKyThuTruong = s.NgayKy_ChuKyThuTruong
            }).FirstOrDefault();

            if (query == null)
            {
                query = new DTO_PRO_DonXinXetDuyet
                {
                    IDDeTai = deTaiId
                };
                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == deTaiId);
                if (detai != null)
                {
                    query.TenDeTai = detai.TenTiengViet;

                    var chunhiem = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(c => c.ID == detai.IDChuNhiem);
                    if (chunhiem != null)
                    {
                        query.HoTenChuNhiem = chunhiem.Name;
                        query.DiaChi = chunhiem.DiaChi;
                        query.DienThoai = chunhiem.SoDienThoai;
                    }
                }
            }

            return query;
        }

        public static DTO_PRO_DonXinXetDuyet save_PRO_DonXinXetDuyet(AppEntities db, DTO_PRO_DonXinXetDuyet item, string Username)
        {
            var dbitem = db.tbl_PRO_DonXinXetDuyet.FirstOrDefault(c => c.IDDeTai == item.IDDeTai && c.IsDeleted == false);
            if (dbitem == null)
            {
                dbitem = new tbl_PRO_DonXinXetDuyet();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                dbitem.TenDeTai = item.TenDeTai;
                dbitem.HoTenChuNhiem = item.HoTenChuNhiem;
                dbitem.DiaChi = item.DiaChi;
                dbitem.DienThoai = item.DienThoai;
                db.tbl_PRO_DonXinXetDuyet.Add(dbitem);
            }

            dbitem.IDDeTai = item.IDDeTai;
            dbitem.DonVi = item.DonVi;
            dbitem.TenDonViChuTri = item.TenDonViChuTri;
            dbitem.DiaChiDonVi = item.DiaChiDonVi;
            dbitem.DienThoaiDonVi = item.DienThoaiDonVi;
            dbitem.DiaDiemNghienCuu = item.DiaDiemNghienCuu;
            dbitem.ThoiGianNghienCuu = item.ThoiGianNghienCuu;
            dbitem.TuNgay = item.TuNgay;
            dbitem.DenNgay = item.DenNgay;
            dbitem.ThuyetMinhDeCuong = item.ThuyetMinhDeCuong;
            dbitem.LLKHChuNhiem = item.LLKHChuNhiem;
            dbitem.LLKHNCV = item.LLKHNCV;
            dbitem.GiayToKhac = item.GiayToKhac;
            dbitem.GhiChuGiayToKha = item.GhiChuGiayToKha;
            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;
            dbitem.NgayKy_Ngay = item.NgayKy_Ngay;
            dbitem.NgayKy_Thang = item.NgayKy_Thang;
            dbitem.NgayKy_Nam = item.NgayKy_Nam;
            dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;
            dbitem.FormConfig = item.FormConfig;
            dbitem.NgayKy_ChuKyThuTruong = item.NgayKy_ChuKyThuTruong;

            dbitem.CreatedBy = Username;
            dbitem.CreatedDate = DateTime.Now;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;


            try
            {
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinXetDuyet", DateTime.Now, Username);


                item.ID = dbitem.ID;

                item.CreatedBy = dbitem.CreatedBy;
                item.CreatedDate = dbitem.CreatedDate;

                item.ModifiedBy = dbitem.ModifiedBy;
                item.ModifiedDate = dbitem.ModifiedDate;

            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("save_PRO_DonXinXetDuyet", e);
                item = null;
            }
            return item;
        }

    }
}
