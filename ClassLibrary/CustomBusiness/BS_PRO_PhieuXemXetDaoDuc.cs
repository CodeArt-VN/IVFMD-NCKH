using ClassLibrary;
using DTOModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_PRO_PhieuXemXetDaoDuc
    {
        public static DTO_PRO_PhieuXemXetDaoDuc get_PRO_PhieuXemXetDaoDucCustom(AppEntities db, int idDeTai)
        {
            var query = db.tbl_PRO_PhieuXemXetDaoDuc.Where(d => d.IDDeTai == idDeTai && d.IsDeleted == false).Select(s => new DTO_PRO_PhieuXemXetDaoDuc
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                MaSo = s.MaSo,
                NghienCuuDuocTaiTro = s.NghienCuuDuocTaiTro,
                XinPhepTapThe = s.XinPhepTapThe,
                KhongThuocNghienCuuNao = s.KhongThuocNghienCuuNao,
                NghienCuuHocVienSauDaiHoc = s.NghienCuuHocVienSauDaiHoc,
                DonXinTaiCapPhep = s.DonXinTaiCapPhep,
                NghienCuuCuaSinhVienDaiHoc = s.NghienCuuCuaSinhVienDaiHoc,
                SoGiayPhepCu = s.SoGiayPhepCu,
                TenNCSYH = s.TenNCSYH,
                JSON_CacNCV = s.JSON_CacNCV,
                DonViChuTri = s.DonViChuTri,
                NguoiGiaoDich_HoTen = s.NguoiGiaoDich_HoTen,
                NguoiGiaoDich_DiaChiGiaoDich = s.NguoiGiaoDich_DiaChiGiaoDich,
                NguoiGiaoDich_DienThoaiCQ = s.NguoiGiaoDich_DienThoaiCQ,
                NguoiGiaoDich_DienThoaiFx = s.NguoiGiaoDich_DienThoaiFx,
                NguoiGiaoDich_DienThoaiNR = s.NguoiGiaoDich_DienThoaiNR,
                NguoiGiaoDich_DienThoaiDD = s.NguoiGiaoDich_DienThoaiDD,
                NguoiGiaoDich_Email = s.NguoiGiaoDich_Email,
                JSON_CacCoQuan = s.JSON_CacCoQuan,
                QuyChe_TreEm = s.QuyChe_TreEm,
                QuyChe_NguoiQuanHeLeThuoc = s.QuyChe_NguoiQuanHeLeThuoc,
                QuyChe_PhongXa = s.QuyChe_PhongXa,
                QuyChe_PhacDoDieuTri = s.QuyChe_PhacDoDieuTri,
                QuyChe_GienNguoi = s.QuyChe_GienNguoi,
                QuyChe_NguoiTonThuongThanKinh = s.QuyChe_NguoiTonThuongThanKinh,
                QuyChe_CacTapTheNhomNguoi = s.QuyChe_CacTapTheNhomNguoi,
                QuyChe_NghienCuuDichTeHoc = s.QuyChe_NghienCuuDichTeHoc,
                QuyChe_NguoiCanChamSocYTe = s.QuyChe_NguoiCanChamSocYTe,
                QuyChe_NguoiDanToc = s.QuyChe_NguoiDanToc,
                QuyChe_ThuNghiemLamSang = s.QuyChe_ThuNghiemLamSang,
                QuyChe_SuDungMauMoNguoi = s.QuyChe_SuDungMauMoNguoi,
                ThongTinNguonTaiTro = s.ThongTinNguonTaiTro,
                ThongTinNCYSHSinhVien = s.ThongTinNCYSHSinhVien,
                QuyTrinh_MoTaDuAn = s.QuyTrinh_MoTaDuAn,
                QuyTrinh_QuyTrinhThucHien = s.QuyTrinh_QuyTrinhThucHien,
                QuyTrinh_MucDich = s.QuyTrinh_MucDich,
                QuyTrinh_VanDeLienQuan = s.QuyTrinh_VanDeLienQuan,
                QuyTrinh_DiaDiemNghienCuu = s.QuyTrinh_DiaDiemNghienCuu,
                QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = s.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia,
                NguyCoTiemTang_NhomNghienCuu = s.NguyCoTiemTang_NhomNghienCuu,
                NguyCoTiemTang_NguoiThamGia = s.NguyCoTiemTang_NguoiThamGia,
                NguyCoTiemTang_CongDongCuaTruong = s.NguyCoTiemTang_CongDongCuaTruong,
                NguyCoTiemTang_CongDongLonHon = s.NguyCoTiemTang_CongDongLonHon,
                NguyCoTiemTang_SoSanhRuiRo = s.NguyCoTiemTang_SoSanhRuiRo,
                NguyCoTiemTang_QuyTrinhGiamRuiRo = s.NguyCoTiemTang_QuyTrinhGiamRuiRo,
                NguyCoTiemTang_CachXuLyRuiRo = s.NguyCoTiemTang_CachXuLyRuiRo,
                LoiIchTiemTang_NhungLoiIch = s.LoiIchTiemTang_NhungLoiIch,
                LoiIchTiemTang_AiDuocLoi = s.LoiIchTiemTang_AiDuocLoi,
                LoiIchTiemTang_DongGopKhoaHoc = s.LoiIchTiemTang_DongGopKhoaHoc,
                LoiIchTiemTang_SoSanh = s.LoiIchTiemTang_SoSanh,
                HTML = s.HTML,
                FormConfig = s.FormConfig,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            }).FirstOrDefault();

            if (query == null)
            {
                //New
                query = new DTO_PRO_PhieuXemXetDaoDuc
                {
                    IDDeTai = idDeTai
                };

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == idDeTai);
                if (detai != null)
                {
                    query.TenNCSYH = detai.TenTiengViet;
                    var dgdd = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == idDeTai && c.IsDeleted == false);
                    if (dgdd != null)
                    {
                        query.DonViChuTri = dgdd.TenDonViChuTri + "<br>Địa chỉ: " + dgdd.DiaChiDonVi + "<br>Điện thoại:" + dgdd.DienThoaiDonVi;
                    }
                }

                query.ListCoQuan = new List<DTO_PRO_PhieuXemXetDaoDuc_CoQuan>() { new DTO_PRO_PhieuXemXetDaoDuc_CoQuan() };
                query.ListNCV = new List<DTO_PRO_PhieuXemXetDaoDuc_NCV>() { new DTO_PRO_PhieuXemXetDaoDuc_NCV() };
            }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.JSON_CacCoQuan))
                {
                    query.ListCoQuan = JsonConvert.DeserializeObject<List<DTO_PRO_PhieuXemXetDaoDuc_CoQuan>>(query.JSON_CacCoQuan);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CacNCV))
                {
                    query.ListNCV = JsonConvert.DeserializeObject<List<DTO_PRO_PhieuXemXetDaoDuc_NCV>>(query.JSON_CacNCV);
                }
            }

            return query;
        }
    }
}
