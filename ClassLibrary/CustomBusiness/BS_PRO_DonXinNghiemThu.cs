﻿using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_PRO_DonXinNghiemThu
    {
        public static DTO_PRO_DonXinNghiemThu get_PRO_DonXinNghiemThuByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_DonXinNghiemThu.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false).Select(s => new DTO_PRO_DonXinNghiemThu
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
                BaoCaoTomTat = s.BaoCaoTomTat,
                BaoCaoTongKet = s.BaoCaoTongKet,
                ThuyetMinhDeTai = s.ThuyetMinhDeTai,
                QuyetDinhChapThuanHDDD = s.QuyetDinhChapThuanHDDD,
                QuyetDinhGiaoNhiemVu = s.QuyetDinhGiaoNhiemVu,
                HopDongThucHienDeTai = s.HopDongThucHienDeTai,
                BangGiaiNganKinhPhi = s.BangGiaiNganKinhPhi,
                BaiDangBao = s.BaiDangBao,
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
                query = new DTO_PRO_DonXinNghiemThu
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