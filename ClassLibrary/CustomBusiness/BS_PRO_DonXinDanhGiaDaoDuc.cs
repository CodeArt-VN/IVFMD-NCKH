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
    }
}
