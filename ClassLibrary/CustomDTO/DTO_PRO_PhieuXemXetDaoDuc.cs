using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_PRO_PhieuXemXetDaoDuc
    {
        public bool QuyChe_CoTroGiupKiThuat { get; set; }

        public string NguyCoTiemTang_SucKhoeVaTinhAnToan { get; set; }
        public string NguyCoTiemTang_CacVanDeAnToanSinhHoc { get; set; }
        public string NguyCoTiemTang_ThaoTacGen { get; set; }

        //4
        public string NguoiThamGiaNghienCuu_DuKien { get; set; }
        public string NguoiThamGiaNghienCuu_CachXacDinh { get; set; }
        public string NguoiThamGiaNghienCuu_TreViThanhNien { get; set; }
        public string NguoiThamGiaNghienCuu_ThieuNangTriTue { get; set; }
        public string NguoiThamGiaNghienCuu_CoQuanHeLeThuoc { get; set; }
        public string NguoiThamGiaNghienCuu_MoiQuanHeSanCo { get; set; }
        public string NguoiThamGiaNghienCuu_RaoCanNgonNgu { get; set; }
        public string NguoiThamGiaNghienCuu_SangTuyen { get; set; }
        public string NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung { get; set; }
        public string NguoiThamGiaNghienCuu_DanTocThieuSo { get; set; }
        public string NguoiThamGiaNghienCuu_ThamGiaTapThe { get; set; }
        public string NguoiThamGiaNghienCuu_ChiTraKhuyenKhich { get; set; }
        public string NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung { get; set; }
        public string NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat { get; set; }

        //5
        public string QuyTrinhXinChapThuanTinhNguyen { get; set; }

        //6
        public string QuanLyDLVaBaoMat_ThuThapTrucTiep { get; set; }
        public string QuanLyDLVaBaoMat_TiepCanThongTinCaNhan { get; set; }
        public string QuanLyDLVaBaoMat_GhiLaiDL { get; set; }
        public string QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam { get; set; }
        public string QuanLyDLVaBaoMat_BaoMatThongTin { get; set; }
        public string QuanLyDLVaBaoMat_LuuTruDLTrongXNam { get; set; }

        public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat { get; set; }
        public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan { get; set; }
        public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru { get; set; }
        public bool QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon { get; set; }

        public string QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat { get; set; }
        public string QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan { get; set; }
        public string QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru { get; set; }
        public bool QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon { get; set; }


        public string QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru { get; set; }
        public string QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo { get; set; }
        public string QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat { get; set; }

        public string ThoiGianThucHien_ThuNghiem_NgayBatDau { get; set; }
        public string ThoiGianThucHien_ThuNghiem_NgayKetThuc { get; set; }
        public string ThoiGianThucHien_ThuNghiem_ThangBatDau { get; set; }
        public string ThoiGianThucHien_ThuNghiem_ThangKetThuc { get; set; }
        public string ThoiGianThucHien_ThuNghiem_NamBatDau { get; set; }
        public string ThoiGianThucHien_ThuNghiem_NamKetThuc { get; set; }

        public string ThoiGianThucHien_ThuThapDL_NgayBatDau { get; set; }
        public string ThoiGianThucHien_ThuThapDL_NgayKetThuc { get; set; }
        public string ThoiGianThucHien_ThuThapDL_ThangBatDau { get; set; }
        public string ThoiGianThucHien_ThuThapDL_ThangKetThuc { get; set; }
        public string ThoiGianThucHien_ThuThapDL_NamBatDau { get; set; }
        public string ThoiGianThucHien_ThuThapDL_NamKetThuc { get; set; }

        public string ThoiGianThucHien_TongThoiGian_NgayBatDau { get; set; }
        public string ThoiGianThucHien_TongThoiGian_NgayKetThuc { get; set; }
        public string ThoiGianThucHien_TongThoiGian_ThangBatDau { get; set; }
        public string ThoiGianThucHien_TongThoiGian_ThangKetThuc { get; set; }
        public string ThoiGianThucHien_TongThoiGian_NamBatDau { get; set; }
        public string ThoiGianThucHien_TongThoiGian_NamKetThuc { get; set; }


        //8
        public string MauThuanLoiIch_NghienCuuTheoYeuCau { get; set; }
        public string MauThuanLoiIch_PhuThuocTaiChinh { get; set; }
        public string MauThuanLoiIch_LoiIchTaiChinh { get; set; }

        //9
        public string CanNhacDaoDucKhac { get; set; }
        //10
        public string TongQuanTaiLieuKeHoachPhuongPhap { get; set; }
        //11
        public string CanKet_TenNCYSH { get; set; }

        //12
        public string YKienNguoiHuongDan_TenNCYSH { get; set; }
        public string YKienNguoiHuongDan_NhanXet { get; set; }
        public string YKienNguoiHuongDan_BoMon { get; set; }
        public string YKienNguoiHuongDan_NgayKy { get; set; }
        public string YKienNguoiHuongDan_ThangKy { get; set; }
        public string YKienNguoiHuongDan_NamKy { get; set; }
        public string YKienNguoiHuongDan_HoTenVaChucDanh { get; set; }


        public string YKienTruongKhoa_XemXetBoiHDKH { get; set; }
        public string YKienTruongKhoa_XemXetBoiCapCaNhan { get; set; }

        public string YKienTruongKhoa_XemXetBoiKhoaPhong { get; set; }

        public bool YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap { get; set; }
        public bool YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap { get; set; }
        public bool YKienTruongKhoa_NhanXet { get; set; }
        public string YKienTruongKhoa_BoMon { get; set; }
        public string YKienTruongKhoa_NgayKy { get; set; }
        public string YKienTruongKhoa_ThangKy { get; set; }
        public string YKienTruongKhoa_NamKy { get; set; }
        public string YKienTruongKhoa_HoTenVaChucDanh { get; set; }

        public List<DTO_PRO_PhieuXemXetDaoDuc_ChuKy> CanKet_ListChuKy { get; set; }
        public List<DTO_PRO_PhieuXemXetDaoDuc_NCV> ListNCV { get; set; }
        public List<DTO_PRO_PhieuXemXetDaoDuc_CoQuan> ListCoQuan { get; set; }
    }

    public class DTO_PRO_PhieuXemXetDaoDuc_NCV
    {
        public string HoTen { get; set; }
        public string ChucDanh { get; set; }
        public string ChucVu { get; set; }
    }

    public class DTO_PRO_PhieuXemXetDaoDuc_CoQuan
    {
        public string CoQuan { get; set; }
        public bool DuocCapPhep { get; set; }
        public bool ChoCapPhep { get; set; }
        public bool ChuaXinPhep { get; set; }
        public bool GhiChuKhac { get; set; }
    }

    public class DTO_PRO_PhieuXemXetDaoDuc_ChuKy
    {
        public string BoMon { get; set; }
        public string NgayKy { get; set; }
        public string ThangKy { get; set; }
        public string NamKy { get; set; }
        public string HoTenVaChucDanh { get; set; }
    }
}
