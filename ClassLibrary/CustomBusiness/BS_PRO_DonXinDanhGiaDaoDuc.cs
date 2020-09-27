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
    public static partial class BS_PRO_DonXinDanhGiaDaoDuc
    {
        public static DTO_PRO_DonXinDanhGiaDaoDuc get_PRO_DonXinDanhGiaDaoDucByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_DonXinDanhGiaDaoDuc.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false).Select(s => new DTO_PRO_DonXinDanhGiaDaoDuc
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
                BangKiemLuaChon = s.BangKiemLuaChon,
                PhieuThongTinXemXet = s.PhieuThongTinXemXet,
                DeCuongNCYSH = s.DeCuongNCYSH,
                CacBangCauHoi = s.CacBangCauHoi,
                MauPhieuChapThuanTinhNguyen = s.MauPhieuChapThuanTinhNguyen,
                TrangThongTinGioiThieu = s.TrangThongTinGioiThieu,
                SYLLChuNhiem = s.SYLLChuNhiem,
                GiayToKhac = s.GiayToKhac,
                GhiChuGiayToKhac = s.GhiChuGiayToKhac,
                HTML = s.HTML,
                FormConfig = s.FormConfig,
                IsDisabled = s.tbl_PRO_DeTai.IsDisabledHDDD ?? false,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                NgayKy_ChuKy = s.NgayKy_ChuKy,
                NgayKy_Nam = s.NgayKy_Nam,
                NgayKy_Ngay = s.NgayKy_Ngay,
                NgayKy_Thang = s.NgayKy_Thang,
                NgayKy_ChuKyThuTruong = s.NgayKy_ChuKyThuTruong,
            }).FirstOrDefault();

            if (query == null)
            {
                query = new DTO_PRO_DonXinDanhGiaDaoDuc
                {
                    IDDeTai = deTaiId
                };
                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == deTaiId);
                if (detai != null)
                {
                    query.TenDeTai = detai.TenTiengViet;
                    query.IsDisabled = detai.IsDisabledHDDD ?? false;
                    var chunhiem = db.tbl_PRO_LLKH.FirstOrDefault(c => c.IDDetai == deTaiId && c.IDNhanSu == detai.IDChuNhiem);
                    if (chunhiem != null)
                    {
                        query.HoTenChuNhiem = chunhiem.HoTen;
                        query.DiaChi = chunhiem.DiaChi_CaNhan;
                        query.DienThoai = chunhiem.DienThoai_CaNhan;
                    }
                }
            }

            return query;
        }

        public static DTO_PRO_DonXinDanhGiaDaoDuc save_PRO_DonXinDanhGiaDaoDuc(AppEntities db, DTO_PRO_DonXinDanhGiaDaoDuc item, string Username)
        {
            var dbitem = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == item.IDDeTai && c.IsDeleted == false);
            if (dbitem == null)
            {
                dbitem = new tbl_PRO_DonXinDanhGiaDaoDuc();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                dbitem.TenDeTai = item.TenDeTai;
                dbitem.HoTenChuNhiem = item.HoTenChuNhiem;
                dbitem.DiaChi = item.DiaChi;
                dbitem.DienThoai = item.DienThoai;
                db.tbl_PRO_DonXinDanhGiaDaoDuc.Add(dbitem);
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
            dbitem.BangKiemLuaChon = item.BangKiemLuaChon;
            dbitem.PhieuThongTinXemXet = item.PhieuThongTinXemXet;
            dbitem.DeCuongNCYSH = item.DeCuongNCYSH;
            dbitem.CacBangCauHoi = item.CacBangCauHoi;
            dbitem.MauPhieuChapThuanTinhNguyen = item.MauPhieuChapThuanTinhNguyen;
            dbitem.TrangThongTinGioiThieu = item.TrangThongTinGioiThieu;
            dbitem.SYLLChuNhiem = item.SYLLChuNhiem;
            dbitem.GiayToKhac = item.GiayToKhac;
            dbitem.GhiChuGiayToKhac = item.GhiChuGiayToKhac;
            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;
            dbitem.NgayKy_Ngay = item.NgayKy_Ngay;
            dbitem.NgayKy_Thang = item.NgayKy_Thang;
            dbitem.NgayKy_Nam = item.NgayKy_Nam;
            dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;
            dbitem.FormConfig = item.FormConfig;
            dbitem.NgayKy_ChuKyThuTruong = item.NgayKy_ChuKyThuTruong;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == item.IDDeTai);
            if (detai != null)
            {
                var chunhiem = db.tbl_PRO_LLKH.FirstOrDefault(c => c.IDDetai == item.IDDeTai && c.IDNhanSu == detai.IDChuNhiem);
                if (chunhiem != null)
                {
                    dbitem.HoTenChuNhiem = chunhiem.HoTen;
                    dbitem.DiaChi = chunhiem.DiaChi_CaNhan;
                    dbitem.DienThoai = chunhiem.DienThoai_CaNhan;
                }
            }

            try
            {
                db.SaveChanges();
                item.ID = dbitem.ID;
                BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinDanhGiaDaoDuc", DateTime.Now, Username);
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("put_PRO_DonXinDanhGiaDaoDuc", e);
            }
            return item;
        }

    }
}
