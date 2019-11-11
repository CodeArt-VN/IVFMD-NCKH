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
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
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

                    var chunhiem = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(c => c.ID == detai.IDChuNhiem);
                    if (chunhiem != null)
                    {
                        query.HoTenChuNhiem = chunhiem.Ho + " " + chunhiem.Ten;
                        query.DiaChi = chunhiem.DiaChi;
                        query.DienThoai = chunhiem.SoDienThoai;
                    }
                }
            }

            return query;
        }
    }
}
