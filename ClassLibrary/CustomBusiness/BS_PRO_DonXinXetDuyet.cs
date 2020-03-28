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
    }
}
