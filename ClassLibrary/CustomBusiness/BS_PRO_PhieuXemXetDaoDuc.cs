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
                IsDisabled = s.tbl_PRO_DeTai.IsDisabledHDDD ?? false,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                NguoiThamGiaNghienCuu_DuKien = s.NguoiThamGiaNghienCuu_DuKien,
                NguoiThamGiaNghienCuu_CachXacDinh = s.NguoiThamGiaNghienCuu_CachXacDinh,
                NguoiThamGiaNghienCuu_TreViThanhNien = s.NguoiThamGiaNghienCuu_TreViThanhNien,
                NguoiThamGiaNghienCuu_ThieuNangTriTue = s.NguoiThamGiaNghienCuu_ThieuNangTriTue,
                NguoiThamGiaNghienCuu_CoQuanHeLeThuoc = s.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc,
                NguoiThamGiaNghienCuu_MoiQuanHeSanCo = s.NguoiThamGiaNghienCuu_MoiQuanHeSanCo,
                NguoiThamGiaNghienCuu_RaoCanNgonNgu = s.NguoiThamGiaNghienCuu_RaoCanNgonNgu,
                NguoiThamGiaNghienCuu_SangTuyen = s.NguoiThamGiaNghienCuu_SangTuyen,
                NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung = s.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung,
                NguoiThamGiaNghienCuu_DanTocThieuSo = s.NguoiThamGiaNghienCuu_DanTocThieuSo,
                NguoiThamGiaNghienCuu_ThamGiaTapThe = s.NguoiThamGiaNghienCuu_ThamGiaTapThe,
                NguoiThamGiaNghienCuu_ChiTraKhuyenKhich = s.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich,
                NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung = s.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung,
                NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat = s.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat,
                QuyTrinhXinChapThuanTinhNguyen = s.QuyTrinhXinChapThuanTinhNguyen,
                QuanLyDLVaBaoMat_ThuThapTrucTiep = s.QuanLyDLVaBaoMat_ThuThapTrucTiep,
                QuanLyDLVaBaoMat_TiepCanThongTinCaNhan = s.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan,
                QuanLyDLVaBaoMat_GhiLaiDL = s.QuanLyDLVaBaoMat_GhiLaiDL,
                QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam = s.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam,
                QuanLyDLVaBaoMat_BaoMatThongTin = s.QuanLyDLVaBaoMat_BaoMatThongTin,
                QuanLyDLVaBaoMat_LuuTruDLTrongXNam = s.QuanLyDLVaBaoMat_LuuTruDLTrongXNam,
                QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat = s.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat,
                QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan = s.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan,
                QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru = s.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru,
                QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon = s.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon,
                QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat = s.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat,
                QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan = s.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan,
                QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru = s.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru,
                QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon = s.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon,
                QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru = s.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru,
                QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo = s.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo,
                QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat = s.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat,
                ThoiGianThucHien_ThuNghiem_NgayBatDau = s.ThoiGianThucHien_ThuNghiem_NgayBatDau,
                ThoiGianThucHien_ThuNghiem_NgayKetThuc = s.ThoiGianThucHien_ThuNghiem_NgayKetThuc,
                ThoiGianThucHien_ThuNghiem_ThangBatDau = s.ThoiGianThucHien_ThuNghiem_ThangBatDau,
                ThoiGianThucHien_ThuNghiem_ThangKetThuc = s.ThoiGianThucHien_ThuNghiem_ThangKetThuc,
                ThoiGianThucHien_ThuNghiem_NamBatDau = s.ThoiGianThucHien_ThuNghiem_NamBatDau,
                ThoiGianThucHien_ThuNghiem_NamKetThuc = s.ThoiGianThucHien_ThuNghiem_NamKetThuc,
                ThoiGianThucHien_ThuThapDL_NgayBatDau = s.ThoiGianThucHien_ThuThapDL_NgayBatDau,
                ThoiGianThucHien_ThuThapDL_NgayKetThuc = s.ThoiGianThucHien_ThuThapDL_NgayKetThuc,
                ThoiGianThucHien_ThuThapDL_ThangBatDau = s.ThoiGianThucHien_ThuThapDL_ThangBatDau,
                ThoiGianThucHien_ThuThapDL_ThangKetThuc = s.ThoiGianThucHien_ThuThapDL_ThangKetThuc,
                ThoiGianThucHien_ThuThapDL_NamBatDau = s.ThoiGianThucHien_ThuThapDL_NamBatDau,
                ThoiGianThucHien_ThuThapDL_NamKetThuc = s.ThoiGianThucHien_ThuThapDL_NamKetThuc,
                ThoiGianThucHien_TongThoiGian_NgayBatDau = s.ThoiGianThucHien_TongThoiGian_NgayBatDau,
                ThoiGianThucHien_TongThoiGian_NgayKetThuc = s.ThoiGianThucHien_TongThoiGian_NgayKetThuc,
                ThoiGianThucHien_TongThoiGian_ThangBatDau = s.ThoiGianThucHien_TongThoiGian_ThangBatDau,
                ThoiGianThucHien_TongThoiGian_ThangKetThuc = s.ThoiGianThucHien_TongThoiGian_ThangKetThuc,
                ThoiGianThucHien_TongThoiGian_NamBatDau = s.ThoiGianThucHien_TongThoiGian_NamBatDau,
                ThoiGianThucHien_TongThoiGian_NamKetThuc = s.ThoiGianThucHien_TongThoiGian_NamKetThuc,
                MauThuanLoiIch_NghienCuuTheoYeuCau = s.MauThuanLoiIch_NghienCuuTheoYeuCau,
                MauThuanLoiIch_PhuThuocTaiChinh = s.MauThuanLoiIch_PhuThuocTaiChinh,
                MauThuanLoiIch_LoiIchTaiChinh = s.MauThuanLoiIch_LoiIchTaiChinh,
                CanNhacDaoDucKhac = s.CanNhacDaoDucKhac,
                TongQuanTaiLieuKeHoachPhuongPhap = s.TongQuanTaiLieuKeHoachPhuongPhap,
                CanKet_TenNCYSH = s.CanKet_TenNCYSH,
                YKienNguoiHuongDan_TenNCYSH = s.YKienNguoiHuongDan_TenNCYSH,
                YKienNguoiHuongDan_NhanXet = s.YKienNguoiHuongDan_NhanXet,
                YKienNguoiHuongDan_BoMon = s.YKienNguoiHuongDan_BoMon,
                YKienNguoiHuongDan_NgayKy = s.YKienNguoiHuongDan_NgayKy,
                YKienNguoiHuongDan_ThangKy = s.YKienNguoiHuongDan_ThangKy,
                YKienNguoiHuongDan_NamKy = s.YKienNguoiHuongDan_NamKy,
                YKienNguoiHuongDan_HoTenVaChucDanh = s.YKienNguoiHuongDan_HoTenVaChucDanh,
                YKienTruongKhoa_XemXetBoiHDKH = s.YKienTruongKhoa_XemXetBoiHDKH,
                YKienTruongKhoa_XemXetBoiCapCaNhan = s.YKienTruongKhoa_XemXetBoiCapCaNhan,
                YKienTruongKhoa_XemXetBoiKhoaPhong = s.YKienTruongKhoa_XemXetBoiKhoaPhong,
                YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap = s.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap,
                YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap = s.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap,
                YKienTruongKhoa_NhanXet = s.YKienTruongKhoa_NhanXet,
                YKienTruongKhoa_BoMon = s.YKienTruongKhoa_BoMon,
                YKienTruongKhoa_NgayKy = s.YKienTruongKhoa_NgayKy,
                YKienTruongKhoa_ThangKy = s.YKienTruongKhoa_ThangKy,
                YKienTruongKhoa_NamKy = s.YKienTruongKhoa_NamKy,
                YKienTruongKhoa_HoTenVaChucDanh = s.YKienTruongKhoa_HoTenVaChucDanh,
                JSON_ChuKy = s.JSON_ChuKy,
                FormConfig = s.FormConfig,
                QuyChe_CoTroGiupKiThuat = s.QuyChe_CoTroGiupKiThuat,
                NguyCoTiemTang_SucKhoeVaTinhAnToan = s.NguyCoTiemTang_SucKhoeVaTinhAnToan,
                NguyCoTiemTang_CacVanDeAnToanSinhHoc = s.NguyCoTiemTang_CacVanDeAnToanSinhHoc,
                NguyCoTiemTang_ThaoTacGen = s.NguyCoTiemTang_ThaoTacGen,
                JSON_CanKet_ListChuKy = s.JSON_CanKet_ListChuKy,
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
                    query.IsDisabled = detai.IsDisabledHDDD ?? false;
                    query.TenNCSYH = detai.TenTiengViet;
                    var dgdd = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == idDeTai && c.IsDeleted == false);
                    if (dgdd != null)
                    {
                        query.DonViChuTri = dgdd.TenDonViChuTri + "<br>Địa chỉ: " + dgdd.DiaChiDonVi + "<br>Điện thoại:" + dgdd.DienThoaiDonVi;
                    }
                }

                query.ListCoQuan = new List<DTO_PRO_PhieuXemXetDaoDuc_CoQuan>() { new DTO_PRO_PhieuXemXetDaoDuc_CoQuan() };
                query.ListNCV = new List<DTO_PRO_PhieuXemXetDaoDuc_NCV>() { new DTO_PRO_PhieuXemXetDaoDuc_NCV() };
                query.CanKet_ListChuKy = new List<DTO_PRO_PhieuXemXetDaoDuc_ChuKy>() { new DTO_PRO_PhieuXemXetDaoDuc_ChuKy() };
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
                if (!string.IsNullOrWhiteSpace(query.JSON_ChuKy))
                {
                    query.CanKet_ListChuKy = JsonConvert.DeserializeObject<List<DTO_PRO_PhieuXemXetDaoDuc_ChuKy>>(query.JSON_ChuKy);
                }
            }

            return query;
        }
    }
}
