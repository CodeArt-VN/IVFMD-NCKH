//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    
    using System;
    using System.Collections.Generic;
    
    
    public partial class tbl_PRO_PhieuXemXetDaoDuc
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string MaSo { get; set; }
        public bool NghienCuuDuocTaiTro { get; set; }
        public bool XinPhepTapThe { get; set; }
        public bool KhongThuocNghienCuuNao { get; set; }
        public bool NghienCuuHocVienSauDaiHoc { get; set; }
        public bool DonXinTaiCapPhep { get; set; }
        public bool NghienCuuCuaSinhVienDaiHoc { get; set; }
        public bool SoGiayPhepCu { get; set; }
        public string TenNCSYH { get; set; }
        public string JSON_CacNCV { get; set; }
        public string DonViChuTri { get; set; }
        public string NguoiGiaoDich_HoTen { get; set; }
        public string NguoiGiaoDich_DiaChiGiaoDich { get; set; }
        public string NguoiGiaoDich_DienThoaiCQ { get; set; }
        public string NguoiGiaoDich_DienThoaiFx { get; set; }
        public string NguoiGiaoDich_DienThoaiNR { get; set; }
        public string NguoiGiaoDich_DienThoaiDD { get; set; }
        public string NguoiGiaoDich_Email { get; set; }
        public string JSON_CacCoQuan { get; set; }
        public bool QuyChe_TreEm { get; set; }
        public bool QuyChe_NguoiQuanHeLeThuoc { get; set; }
        public bool QuyChe_PhongXa { get; set; }
        public bool QuyChe_PhacDoDieuTri { get; set; }
        public bool QuyChe_GienNguoi { get; set; }
        public bool QuyChe_NguoiTonThuongThanKinh { get; set; }
        public bool QuyChe_CacTapTheNhomNguoi { get; set; }
        public bool QuyChe_NghienCuuDichTeHoc { get; set; }
        public bool QuyChe_NguoiCanChamSocYTe { get; set; }
        public bool QuyChe_NguoiDanToc { get; set; }
        public bool QuyChe_ThuNghiemLamSang { get; set; }
        public bool QuyChe_SuDungMauMoNguoi { get; set; }
        public string ThongTinNguonTaiTro { get; set; }
        public string ThongTinNCYSHSinhVien { get; set; }
        public string QuyTrinh_MoTaDuAn { get; set; }
        public string QuyTrinh_QuyTrinhThucHien { get; set; }
        public string QuyTrinh_MucDich { get; set; }
        public string QuyTrinh_VanDeLienQuan { get; set; }
        public string QuyTrinh_DiaDiemNghienCuu { get; set; }
        public string QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia { get; set; }
        public bool NguyCoTiemTang_NhomNghienCuu { get; set; }
        public bool NguyCoTiemTang_NguoiThamGia { get; set; }
        public bool NguyCoTiemTang_CongDongCuaTruong { get; set; }
        public bool NguyCoTiemTang_CongDongLonHon { get; set; }
        public string NguyCoTiemTang_SoSanhRuiRo { get; set; }
        public string NguyCoTiemTang_QuyTrinhGiamRuiRo { get; set; }
        public string NguyCoTiemTang_CachXuLyRuiRo { get; set; }
        public string LoiIchTiemTang_NhungLoiIch { get; set; }
        public string LoiIchTiemTang_AiDuocLoi { get; set; }
        public string LoiIchTiemTang_DongGopKhoaHoc { get; set; }
        public string LoiIchTiemTang_SoSanh { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
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
        public string QuyTrinhXinChapThuanTinhNguyen { get; set; }
        public string QuanLyDLVaBaoMat_ThuThapTrucTiep { get; set; }
        public string QuanLyDLVaBaoMat_TiepCanThongTinCaNhan { get; set; }
        public string QuanLyDLVaBaoMat_GhiLaiDL { get; set; }
        public string QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam { get; set; }
        public string QuanLyDLVaBaoMat_BaoMatThongTin { get; set; }
        public string QuanLyDLVaBaoMat_LuuTruDLTrongXNam { get; set; }
        public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat { get; set; }
        public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan { get; set; }
        public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru { get; set; }
        public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon { get; set; }
        public string QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat { get; set; }
        public string QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan { get; set; }
        public string QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru { get; set; }
        public string QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon { get; set; }
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
        public string MauThuanLoiIch_NghienCuuTheoYeuCau { get; set; }
        public string MauThuanLoiIch_PhuThuocTaiChinh { get; set; }
        public string MauThuanLoiIch_LoiIchTaiChinh { get; set; }
        public string CanNhacDaoDucKhac { get; set; }
        public string TongQuanTaiLieuKeHoachPhuongPhap { get; set; }
        public string CanKet_TenNCYSH { get; set; }
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
        public string YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap { get; set; }
        public string YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap { get; set; }
        public string YKienTruongKhoa_NhanXet { get; set; }
        public string YKienTruongKhoa_BoMon { get; set; }
        public string YKienTruongKhoa_NgayKy { get; set; }
        public string YKienTruongKhoa_ThangKy { get; set; }
        public string YKienTruongKhoa_NamKy { get; set; }
        public string YKienTruongKhoa_HoTenVaChucDanh { get; set; }
        public string JSON_ChuKy { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_PhieuXemXetDaoDuc
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string MaSo { get; set; }
		public bool NghienCuuDuocTaiTro { get; set; }
		public bool XinPhepTapThe { get; set; }
		public bool KhongThuocNghienCuuNao { get; set; }
		public bool NghienCuuHocVienSauDaiHoc { get; set; }
		public bool DonXinTaiCapPhep { get; set; }
		public bool NghienCuuCuaSinhVienDaiHoc { get; set; }
		public bool SoGiayPhepCu { get; set; }
		public string TenNCSYH { get; set; }
		public string JSON_CacNCV { get; set; }
		public string DonViChuTri { get; set; }
		public string NguoiGiaoDich_HoTen { get; set; }
		public string NguoiGiaoDich_DiaChiGiaoDich { get; set; }
		public string NguoiGiaoDich_DienThoaiCQ { get; set; }
		public string NguoiGiaoDich_DienThoaiFx { get; set; }
		public string NguoiGiaoDich_DienThoaiNR { get; set; }
		public string NguoiGiaoDich_DienThoaiDD { get; set; }
		public string NguoiGiaoDich_Email { get; set; }
		public string JSON_CacCoQuan { get; set; }
		public bool QuyChe_TreEm { get; set; }
		public bool QuyChe_NguoiQuanHeLeThuoc { get; set; }
		public bool QuyChe_PhongXa { get; set; }
		public bool QuyChe_PhacDoDieuTri { get; set; }
		public bool QuyChe_GienNguoi { get; set; }
		public bool QuyChe_NguoiTonThuongThanKinh { get; set; }
		public bool QuyChe_CacTapTheNhomNguoi { get; set; }
		public bool QuyChe_NghienCuuDichTeHoc { get; set; }
		public bool QuyChe_NguoiCanChamSocYTe { get; set; }
		public bool QuyChe_NguoiDanToc { get; set; }
		public bool QuyChe_ThuNghiemLamSang { get; set; }
		public bool QuyChe_SuDungMauMoNguoi { get; set; }
		public string ThongTinNguonTaiTro { get; set; }
		public string ThongTinNCYSHSinhVien { get; set; }
		public string QuyTrinh_MoTaDuAn { get; set; }
		public string QuyTrinh_QuyTrinhThucHien { get; set; }
		public string QuyTrinh_MucDich { get; set; }
		public string QuyTrinh_VanDeLienQuan { get; set; }
		public string QuyTrinh_DiaDiemNghienCuu { get; set; }
		public string QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia { get; set; }
		public bool NguyCoTiemTang_NhomNghienCuu { get; set; }
		public bool NguyCoTiemTang_NguoiThamGia { get; set; }
		public bool NguyCoTiemTang_CongDongCuaTruong { get; set; }
		public bool NguyCoTiemTang_CongDongLonHon { get; set; }
		public string NguyCoTiemTang_SoSanhRuiRo { get; set; }
		public string NguyCoTiemTang_QuyTrinhGiamRuiRo { get; set; }
		public string NguyCoTiemTang_CachXuLyRuiRo { get; set; }
		public string LoiIchTiemTang_NhungLoiIch { get; set; }
		public string LoiIchTiemTang_AiDuocLoi { get; set; }
		public string LoiIchTiemTang_DongGopKhoaHoc { get; set; }
		public string LoiIchTiemTang_SoSanh { get; set; }
		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
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
		public string QuyTrinhXinChapThuanTinhNguyen { get; set; }
		public string QuanLyDLVaBaoMat_ThuThapTrucTiep { get; set; }
		public string QuanLyDLVaBaoMat_TiepCanThongTinCaNhan { get; set; }
		public string QuanLyDLVaBaoMat_GhiLaiDL { get; set; }
		public string QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam { get; set; }
		public string QuanLyDLVaBaoMat_BaoMatThongTin { get; set; }
		public string QuanLyDLVaBaoMat_LuuTruDLTrongXNam { get; set; }
		public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat { get; set; }
		public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan { get; set; }
		public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru { get; set; }
		public string QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon { get; set; }
		public string QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat { get; set; }
		public string QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan { get; set; }
		public string QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru { get; set; }
		public string QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon { get; set; }
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
		public string MauThuanLoiIch_NghienCuuTheoYeuCau { get; set; }
		public string MauThuanLoiIch_PhuThuocTaiChinh { get; set; }
		public string MauThuanLoiIch_LoiIchTaiChinh { get; set; }
		public string CanNhacDaoDucKhac { get; set; }
		public string TongQuanTaiLieuKeHoachPhuongPhap { get; set; }
		public string CanKet_TenNCYSH { get; set; }
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
		public string YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap { get; set; }
		public string YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap { get; set; }
		public string YKienTruongKhoa_NhanXet { get; set; }
		public string YKienTruongKhoa_BoMon { get; set; }
		public string YKienTruongKhoa_NgayKy { get; set; }
		public string YKienTruongKhoa_ThangKy { get; set; }
		public string YKienTruongKhoa_NamKy { get; set; }
		public string YKienTruongKhoa_HoTenVaChucDanh { get; set; }
		public string JSON_ChuKy { get; set; }
	}
}


namespace BaseBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using DTOModel;
    using ClassLibrary;
	using System.Data.Entity.Validation;

    public static partial class BS_PRO_PhieuXemXetDaoDuc 
    {
		public static IQueryable<DTO_PRO_PhieuXemXetDaoDuc> toDTO(IQueryable<tbl_PRO_PhieuXemXetDaoDuc> query)
        {
			return query
			.Select(s => new DTO_PRO_PhieuXemXetDaoDuc(){							
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
				IsDisabled = s.IsDisabled,							
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
			});
                              
        }

		public static DTO_PRO_PhieuXemXetDaoDuc toDTO(tbl_PRO_PhieuXemXetDaoDuc dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_PhieuXemXetDaoDuc()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					MaSo = dbResult.MaSo,							
					NghienCuuDuocTaiTro = dbResult.NghienCuuDuocTaiTro,							
					XinPhepTapThe = dbResult.XinPhepTapThe,							
					KhongThuocNghienCuuNao = dbResult.KhongThuocNghienCuuNao,							
					NghienCuuHocVienSauDaiHoc = dbResult.NghienCuuHocVienSauDaiHoc,							
					DonXinTaiCapPhep = dbResult.DonXinTaiCapPhep,							
					NghienCuuCuaSinhVienDaiHoc = dbResult.NghienCuuCuaSinhVienDaiHoc,							
					SoGiayPhepCu = dbResult.SoGiayPhepCu,							
					TenNCSYH = dbResult.TenNCSYH,							
					JSON_CacNCV = dbResult.JSON_CacNCV,							
					DonViChuTri = dbResult.DonViChuTri,							
					NguoiGiaoDich_HoTen = dbResult.NguoiGiaoDich_HoTen,							
					NguoiGiaoDich_DiaChiGiaoDich = dbResult.NguoiGiaoDich_DiaChiGiaoDich,							
					NguoiGiaoDich_DienThoaiCQ = dbResult.NguoiGiaoDich_DienThoaiCQ,							
					NguoiGiaoDich_DienThoaiFx = dbResult.NguoiGiaoDich_DienThoaiFx,							
					NguoiGiaoDich_DienThoaiNR = dbResult.NguoiGiaoDich_DienThoaiNR,							
					NguoiGiaoDich_DienThoaiDD = dbResult.NguoiGiaoDich_DienThoaiDD,							
					NguoiGiaoDich_Email = dbResult.NguoiGiaoDich_Email,							
					JSON_CacCoQuan = dbResult.JSON_CacCoQuan,							
					QuyChe_TreEm = dbResult.QuyChe_TreEm,							
					QuyChe_NguoiQuanHeLeThuoc = dbResult.QuyChe_NguoiQuanHeLeThuoc,							
					QuyChe_PhongXa = dbResult.QuyChe_PhongXa,							
					QuyChe_PhacDoDieuTri = dbResult.QuyChe_PhacDoDieuTri,							
					QuyChe_GienNguoi = dbResult.QuyChe_GienNguoi,							
					QuyChe_NguoiTonThuongThanKinh = dbResult.QuyChe_NguoiTonThuongThanKinh,							
					QuyChe_CacTapTheNhomNguoi = dbResult.QuyChe_CacTapTheNhomNguoi,							
					QuyChe_NghienCuuDichTeHoc = dbResult.QuyChe_NghienCuuDichTeHoc,							
					QuyChe_NguoiCanChamSocYTe = dbResult.QuyChe_NguoiCanChamSocYTe,							
					QuyChe_NguoiDanToc = dbResult.QuyChe_NguoiDanToc,							
					QuyChe_ThuNghiemLamSang = dbResult.QuyChe_ThuNghiemLamSang,							
					QuyChe_SuDungMauMoNguoi = dbResult.QuyChe_SuDungMauMoNguoi,							
					ThongTinNguonTaiTro = dbResult.ThongTinNguonTaiTro,							
					ThongTinNCYSHSinhVien = dbResult.ThongTinNCYSHSinhVien,							
					QuyTrinh_MoTaDuAn = dbResult.QuyTrinh_MoTaDuAn,							
					QuyTrinh_QuyTrinhThucHien = dbResult.QuyTrinh_QuyTrinhThucHien,							
					QuyTrinh_MucDich = dbResult.QuyTrinh_MucDich,							
					QuyTrinh_VanDeLienQuan = dbResult.QuyTrinh_VanDeLienQuan,							
					QuyTrinh_DiaDiemNghienCuu = dbResult.QuyTrinh_DiaDiemNghienCuu,							
					QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = dbResult.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia,							
					NguyCoTiemTang_NhomNghienCuu = dbResult.NguyCoTiemTang_NhomNghienCuu,							
					NguyCoTiemTang_NguoiThamGia = dbResult.NguyCoTiemTang_NguoiThamGia,							
					NguyCoTiemTang_CongDongCuaTruong = dbResult.NguyCoTiemTang_CongDongCuaTruong,							
					NguyCoTiemTang_CongDongLonHon = dbResult.NguyCoTiemTang_CongDongLonHon,							
					NguyCoTiemTang_SoSanhRuiRo = dbResult.NguyCoTiemTang_SoSanhRuiRo,							
					NguyCoTiemTang_QuyTrinhGiamRuiRo = dbResult.NguyCoTiemTang_QuyTrinhGiamRuiRo,							
					NguyCoTiemTang_CachXuLyRuiRo = dbResult.NguyCoTiemTang_CachXuLyRuiRo,							
					LoiIchTiemTang_NhungLoiIch = dbResult.LoiIchTiemTang_NhungLoiIch,							
					LoiIchTiemTang_AiDuocLoi = dbResult.LoiIchTiemTang_AiDuocLoi,							
					LoiIchTiemTang_DongGopKhoaHoc = dbResult.LoiIchTiemTang_DongGopKhoaHoc,							
					LoiIchTiemTang_SoSanh = dbResult.LoiIchTiemTang_SoSanh,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					NguoiThamGiaNghienCuu_DuKien = dbResult.NguoiThamGiaNghienCuu_DuKien,							
					NguoiThamGiaNghienCuu_CachXacDinh = dbResult.NguoiThamGiaNghienCuu_CachXacDinh,							
					NguoiThamGiaNghienCuu_TreViThanhNien = dbResult.NguoiThamGiaNghienCuu_TreViThanhNien,							
					NguoiThamGiaNghienCuu_ThieuNangTriTue = dbResult.NguoiThamGiaNghienCuu_ThieuNangTriTue,							
					NguoiThamGiaNghienCuu_CoQuanHeLeThuoc = dbResult.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc,							
					NguoiThamGiaNghienCuu_MoiQuanHeSanCo = dbResult.NguoiThamGiaNghienCuu_MoiQuanHeSanCo,							
					NguoiThamGiaNghienCuu_RaoCanNgonNgu = dbResult.NguoiThamGiaNghienCuu_RaoCanNgonNgu,							
					NguoiThamGiaNghienCuu_SangTuyen = dbResult.NguoiThamGiaNghienCuu_SangTuyen,							
					NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung = dbResult.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung,							
					NguoiThamGiaNghienCuu_DanTocThieuSo = dbResult.NguoiThamGiaNghienCuu_DanTocThieuSo,							
					NguoiThamGiaNghienCuu_ThamGiaTapThe = dbResult.NguoiThamGiaNghienCuu_ThamGiaTapThe,							
					NguoiThamGiaNghienCuu_ChiTraKhuyenKhich = dbResult.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich,							
					NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung = dbResult.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung,							
					NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat = dbResult.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat,							
					QuyTrinhXinChapThuanTinhNguyen = dbResult.QuyTrinhXinChapThuanTinhNguyen,							
					QuanLyDLVaBaoMat_ThuThapTrucTiep = dbResult.QuanLyDLVaBaoMat_ThuThapTrucTiep,							
					QuanLyDLVaBaoMat_TiepCanThongTinCaNhan = dbResult.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan,							
					QuanLyDLVaBaoMat_GhiLaiDL = dbResult.QuanLyDLVaBaoMat_GhiLaiDL,							
					QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam = dbResult.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam,							
					QuanLyDLVaBaoMat_BaoMatThongTin = dbResult.QuanLyDLVaBaoMat_BaoMatThongTin,							
					QuanLyDLVaBaoMat_LuuTruDLTrongXNam = dbResult.QuanLyDLVaBaoMat_LuuTruDLTrongXNam,							
					QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat = dbResult.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat,							
					QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan = dbResult.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan,							
					QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru = dbResult.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru,							
					QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon = dbResult.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon,							
					QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat = dbResult.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat,							
					QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan = dbResult.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan,							
					QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru = dbResult.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru,							
					QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon = dbResult.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon,							
					QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru = dbResult.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru,							
					QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo = dbResult.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo,							
					QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat = dbResult.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat,							
					ThoiGianThucHien_ThuNghiem_NgayBatDau = dbResult.ThoiGianThucHien_ThuNghiem_NgayBatDau,							
					ThoiGianThucHien_ThuNghiem_NgayKetThuc = dbResult.ThoiGianThucHien_ThuNghiem_NgayKetThuc,							
					ThoiGianThucHien_ThuNghiem_ThangBatDau = dbResult.ThoiGianThucHien_ThuNghiem_ThangBatDau,							
					ThoiGianThucHien_ThuNghiem_ThangKetThuc = dbResult.ThoiGianThucHien_ThuNghiem_ThangKetThuc,							
					ThoiGianThucHien_ThuNghiem_NamBatDau = dbResult.ThoiGianThucHien_ThuNghiem_NamBatDau,							
					ThoiGianThucHien_ThuNghiem_NamKetThuc = dbResult.ThoiGianThucHien_ThuNghiem_NamKetThuc,							
					ThoiGianThucHien_ThuThapDL_NgayBatDau = dbResult.ThoiGianThucHien_ThuThapDL_NgayBatDau,							
					ThoiGianThucHien_ThuThapDL_NgayKetThuc = dbResult.ThoiGianThucHien_ThuThapDL_NgayKetThuc,							
					ThoiGianThucHien_ThuThapDL_ThangBatDau = dbResult.ThoiGianThucHien_ThuThapDL_ThangBatDau,							
					ThoiGianThucHien_ThuThapDL_ThangKetThuc = dbResult.ThoiGianThucHien_ThuThapDL_ThangKetThuc,							
					ThoiGianThucHien_ThuThapDL_NamBatDau = dbResult.ThoiGianThucHien_ThuThapDL_NamBatDau,							
					ThoiGianThucHien_ThuThapDL_NamKetThuc = dbResult.ThoiGianThucHien_ThuThapDL_NamKetThuc,							
					ThoiGianThucHien_TongThoiGian_NgayBatDau = dbResult.ThoiGianThucHien_TongThoiGian_NgayBatDau,							
					ThoiGianThucHien_TongThoiGian_NgayKetThuc = dbResult.ThoiGianThucHien_TongThoiGian_NgayKetThuc,							
					ThoiGianThucHien_TongThoiGian_ThangBatDau = dbResult.ThoiGianThucHien_TongThoiGian_ThangBatDau,							
					ThoiGianThucHien_TongThoiGian_ThangKetThuc = dbResult.ThoiGianThucHien_TongThoiGian_ThangKetThuc,							
					ThoiGianThucHien_TongThoiGian_NamBatDau = dbResult.ThoiGianThucHien_TongThoiGian_NamBatDau,							
					ThoiGianThucHien_TongThoiGian_NamKetThuc = dbResult.ThoiGianThucHien_TongThoiGian_NamKetThuc,							
					MauThuanLoiIch_NghienCuuTheoYeuCau = dbResult.MauThuanLoiIch_NghienCuuTheoYeuCau,							
					MauThuanLoiIch_PhuThuocTaiChinh = dbResult.MauThuanLoiIch_PhuThuocTaiChinh,							
					MauThuanLoiIch_LoiIchTaiChinh = dbResult.MauThuanLoiIch_LoiIchTaiChinh,							
					CanNhacDaoDucKhac = dbResult.CanNhacDaoDucKhac,							
					TongQuanTaiLieuKeHoachPhuongPhap = dbResult.TongQuanTaiLieuKeHoachPhuongPhap,							
					CanKet_TenNCYSH = dbResult.CanKet_TenNCYSH,							
					YKienNguoiHuongDan_TenNCYSH = dbResult.YKienNguoiHuongDan_TenNCYSH,							
					YKienNguoiHuongDan_NhanXet = dbResult.YKienNguoiHuongDan_NhanXet,							
					YKienNguoiHuongDan_BoMon = dbResult.YKienNguoiHuongDan_BoMon,							
					YKienNguoiHuongDan_NgayKy = dbResult.YKienNguoiHuongDan_NgayKy,							
					YKienNguoiHuongDan_ThangKy = dbResult.YKienNguoiHuongDan_ThangKy,							
					YKienNguoiHuongDan_NamKy = dbResult.YKienNguoiHuongDan_NamKy,							
					YKienNguoiHuongDan_HoTenVaChucDanh = dbResult.YKienNguoiHuongDan_HoTenVaChucDanh,							
					YKienTruongKhoa_XemXetBoiHDKH = dbResult.YKienTruongKhoa_XemXetBoiHDKH,							
					YKienTruongKhoa_XemXetBoiCapCaNhan = dbResult.YKienTruongKhoa_XemXetBoiCapCaNhan,							
					YKienTruongKhoa_XemXetBoiKhoaPhong = dbResult.YKienTruongKhoa_XemXetBoiKhoaPhong,							
					YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap = dbResult.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap,							
					YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap = dbResult.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap,							
					YKienTruongKhoa_NhanXet = dbResult.YKienTruongKhoa_NhanXet,							
					YKienTruongKhoa_BoMon = dbResult.YKienTruongKhoa_BoMon,							
					YKienTruongKhoa_NgayKy = dbResult.YKienTruongKhoa_NgayKy,							
					YKienTruongKhoa_ThangKy = dbResult.YKienTruongKhoa_ThangKy,							
					YKienTruongKhoa_NamKy = dbResult.YKienTruongKhoa_NamKy,							
					YKienTruongKhoa_HoTenVaChucDanh = dbResult.YKienTruongKhoa_HoTenVaChucDanh,							
					JSON_ChuKy = dbResult.JSON_ChuKy,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_PhieuXemXetDaoDuc> get_PRO_PhieuXemXetDaoDuc(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_PhieuXemXetDaoDuc.Where(d => d.IsDeleted == false );

			//Query keyword



			//Query ID (int)
			if (QueryStrings.Any(d => d.Key == "ID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ID));
            }

			//Query IDDeTai (int)
			if (QueryStrings.Any(d => d.Key == "IDDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDeTai));
            }

			//Query MaSo (string)
			if (QueryStrings.Any(d => d.Key == "MaSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value;
                query = query.Where(d=>d.MaSo == keyword);
            }

			//Query NghienCuuDuocTaiTro (bool)
			if (QueryStrings.Any(d => d.Key == "NghienCuuDuocTaiTro"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghienCuuDuocTaiTro").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghienCuuDuocTaiTro);
            }

			//Query XinPhepTapThe (bool)
			if (QueryStrings.Any(d => d.Key == "XinPhepTapThe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "XinPhepTapThe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.XinPhepTapThe);
            }

			//Query KhongThuocNghienCuuNao (bool)
			if (QueryStrings.Any(d => d.Key == "KhongThuocNghienCuuNao"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KhongThuocNghienCuuNao").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KhongThuocNghienCuuNao);
            }

			//Query NghienCuuHocVienSauDaiHoc (bool)
			if (QueryStrings.Any(d => d.Key == "NghienCuuHocVienSauDaiHoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghienCuuHocVienSauDaiHoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghienCuuHocVienSauDaiHoc);
            }

			//Query DonXinTaiCapPhep (bool)
			if (QueryStrings.Any(d => d.Key == "DonXinTaiCapPhep"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DonXinTaiCapPhep").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DonXinTaiCapPhep);
            }

			//Query NghienCuuCuaSinhVienDaiHoc (bool)
			if (QueryStrings.Any(d => d.Key == "NghienCuuCuaSinhVienDaiHoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghienCuuCuaSinhVienDaiHoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghienCuuCuaSinhVienDaiHoc);
            }

			//Query SoGiayPhepCu (bool)
			if (QueryStrings.Any(d => d.Key == "SoGiayPhepCu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "SoGiayPhepCu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.SoGiayPhepCu);
            }

			//Query TenNCSYH (string)
			if (QueryStrings.Any(d => d.Key == "TenNCSYH") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenNCSYH").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenNCSYH").Value;
                query = query.Where(d=>d.TenNCSYH == keyword);
            }

			//Query JSON_CacNCV (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CacNCV") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacNCV").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacNCV").Value;
                query = query.Where(d=>d.JSON_CacNCV == keyword);
            }

			//Query DonViChuTri (string)
			if (QueryStrings.Any(d => d.Key == "DonViChuTri") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DonViChuTri").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DonViChuTri").Value;
                query = query.Where(d=>d.DonViChuTri == keyword);
            }

			//Query NguoiGiaoDich_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_HoTen").Value;
                query = query.Where(d=>d.NguoiGiaoDich_HoTen == keyword);
            }

			//Query NguoiGiaoDich_DiaChiGiaoDich (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DiaChiGiaoDich") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DiaChiGiaoDich").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DiaChiGiaoDich").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DiaChiGiaoDich == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiCQ (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiCQ") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiCQ").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiCQ").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiCQ == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiFx (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiFx") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiFx").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiFx").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiFx == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiNR (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiNR") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiNR").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiNR").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiNR == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiDD (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiDD") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiDD").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiDD").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiDD == keyword);
            }

			//Query NguoiGiaoDich_Email (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_Email").Value;
                query = query.Where(d=>d.NguoiGiaoDich_Email == keyword);
            }

			//Query JSON_CacCoQuan (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CacCoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacCoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacCoQuan").Value;
                query = query.Where(d=>d.JSON_CacCoQuan == keyword);
            }

			//Query QuyChe_TreEm (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_TreEm"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_TreEm").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_TreEm);
            }

			//Query QuyChe_NguoiQuanHeLeThuoc (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiQuanHeLeThuoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiQuanHeLeThuoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiQuanHeLeThuoc);
            }

			//Query QuyChe_PhongXa (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_PhongXa"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_PhongXa").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_PhongXa);
            }

			//Query QuyChe_PhacDoDieuTri (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_PhacDoDieuTri"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_PhacDoDieuTri").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_PhacDoDieuTri);
            }

			//Query QuyChe_GienNguoi (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_GienNguoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_GienNguoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_GienNguoi);
            }

			//Query QuyChe_NguoiTonThuongThanKinh (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiTonThuongThanKinh"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiTonThuongThanKinh").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiTonThuongThanKinh);
            }

			//Query QuyChe_CacTapTheNhomNguoi (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_CacTapTheNhomNguoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_CacTapTheNhomNguoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_CacTapTheNhomNguoi);
            }

			//Query QuyChe_NghienCuuDichTeHoc (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NghienCuuDichTeHoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NghienCuuDichTeHoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NghienCuuDichTeHoc);
            }

			//Query QuyChe_NguoiCanChamSocYTe (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiCanChamSocYTe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiCanChamSocYTe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiCanChamSocYTe);
            }

			//Query QuyChe_NguoiDanToc (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiDanToc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiDanToc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiDanToc);
            }

			//Query QuyChe_ThuNghiemLamSang (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_ThuNghiemLamSang"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_ThuNghiemLamSang").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_ThuNghiemLamSang);
            }

			//Query QuyChe_SuDungMauMoNguoi (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_SuDungMauMoNguoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_SuDungMauMoNguoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_SuDungMauMoNguoi);
            }

			//Query ThongTinNguonTaiTro (string)
			if (QueryStrings.Any(d => d.Key == "ThongTinNguonTaiTro") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNguonTaiTro").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNguonTaiTro").Value;
                query = query.Where(d=>d.ThongTinNguonTaiTro == keyword);
            }

			//Query ThongTinNCYSHSinhVien (string)
			if (QueryStrings.Any(d => d.Key == "ThongTinNCYSHSinhVien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNCYSHSinhVien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNCYSHSinhVien").Value;
                query = query.Where(d=>d.ThongTinNCYSHSinhVien == keyword);
            }

			//Query QuyTrinh_MoTaDuAn (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_MoTaDuAn") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MoTaDuAn").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MoTaDuAn").Value;
                query = query.Where(d=>d.QuyTrinh_MoTaDuAn == keyword);
            }

			//Query QuyTrinh_QuyTrinhThucHien (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_QuyTrinhThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_QuyTrinhThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_QuyTrinhThucHien").Value;
                query = query.Where(d=>d.QuyTrinh_QuyTrinhThucHien == keyword);
            }

			//Query QuyTrinh_MucDich (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_MucDich") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MucDich").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MucDich").Value;
                query = query.Where(d=>d.QuyTrinh_MucDich == keyword);
            }

			//Query QuyTrinh_VanDeLienQuan (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_VanDeLienQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_VanDeLienQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_VanDeLienQuan").Value;
                query = query.Where(d=>d.QuyTrinh_VanDeLienQuan == keyword);
            }

			//Query QuyTrinh_DiaDiemNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_DiaDiemNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_DiaDiemNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_DiaDiemNghienCuu").Value;
                query = query.Where(d=>d.QuyTrinh_DiaDiemNghienCuu == keyword);
            }

			//Query QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia").Value;
                query = query.Where(d=>d.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia == keyword);
            }

			//Query NguyCoTiemTang_NhomNghienCuu (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_NhomNghienCuu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_NhomNghienCuu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_NhomNghienCuu);
            }

			//Query NguyCoTiemTang_NguoiThamGia (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_NguoiThamGia"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_NguoiThamGia").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_NguoiThamGia);
            }

			//Query NguyCoTiemTang_CongDongCuaTruong (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_CongDongCuaTruong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CongDongCuaTruong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_CongDongCuaTruong);
            }

			//Query NguyCoTiemTang_CongDongLonHon (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_CongDongLonHon"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CongDongLonHon").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_CongDongLonHon);
            }

			//Query NguyCoTiemTang_SoSanhRuiRo (string)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_SoSanhRuiRo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_SoSanhRuiRo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_SoSanhRuiRo").Value;
                query = query.Where(d=>d.NguyCoTiemTang_SoSanhRuiRo == keyword);
            }

			//Query NguyCoTiemTang_QuyTrinhGiamRuiRo (string)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_QuyTrinhGiamRuiRo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_QuyTrinhGiamRuiRo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_QuyTrinhGiamRuiRo").Value;
                query = query.Where(d=>d.NguyCoTiemTang_QuyTrinhGiamRuiRo == keyword);
            }

			//Query NguyCoTiemTang_CachXuLyRuiRo (string)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_CachXuLyRuiRo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CachXuLyRuiRo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CachXuLyRuiRo").Value;
                query = query.Where(d=>d.NguyCoTiemTang_CachXuLyRuiRo == keyword);
            }

			//Query LoiIchTiemTang_NhungLoiIch (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_NhungLoiIch") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_NhungLoiIch").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_NhungLoiIch").Value;
                query = query.Where(d=>d.LoiIchTiemTang_NhungLoiIch == keyword);
            }

			//Query LoiIchTiemTang_AiDuocLoi (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_AiDuocLoi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_AiDuocLoi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_AiDuocLoi").Value;
                query = query.Where(d=>d.LoiIchTiemTang_AiDuocLoi == keyword);
            }

			//Query LoiIchTiemTang_DongGopKhoaHoc (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_DongGopKhoaHoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_DongGopKhoaHoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_DongGopKhoaHoc").Value;
                query = query.Where(d=>d.LoiIchTiemTang_DongGopKhoaHoc == keyword);
            }

			//Query LoiIchTiemTang_SoSanh (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_SoSanh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_SoSanh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_SoSanh").Value;
                query = query.Where(d=>d.LoiIchTiemTang_SoSanh == keyword);
            }

			//Query HTML (string)
			if (QueryStrings.Any(d => d.Key == "HTML") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value;
                query = query.Where(d=>d.HTML == keyword);
            }

			//Query IsDisabled (bool)
			if (QueryStrings.Any(d => d.Key == "IsDisabled"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDisabled").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDisabled);
            }

			//Query IsDeleted (bool)
			if (QueryStrings.Any(d => d.Key == "IsDeleted"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDeleted").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDeleted);
            }

			//Query CreatedDate (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

			//Query CreatedBy (string)
			if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d=>d.CreatedBy == keyword);
            }

			//Query ModifiedDate (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

			//Query ModifiedBy (string)
			if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d=>d.ModifiedBy == keyword);
            }

			//Query NguoiThamGiaNghienCuu_DuKien (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_DuKien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_DuKien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_DuKien").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_DuKien == keyword);
            }

			//Query NguoiThamGiaNghienCuu_CachXacDinh (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_CachXacDinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_CachXacDinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_CachXacDinh").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_CachXacDinh == keyword);
            }

			//Query NguoiThamGiaNghienCuu_TreViThanhNien (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_TreViThanhNien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_TreViThanhNien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_TreViThanhNien").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_TreViThanhNien == keyword);
            }

			//Query NguoiThamGiaNghienCuu_ThieuNangTriTue (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_ThieuNangTriTue") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_ThieuNangTriTue").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_ThieuNangTriTue").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_ThieuNangTriTue == keyword);
            }

			//Query NguoiThamGiaNghienCuu_CoQuanHeLeThuoc (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_CoQuanHeLeThuoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_CoQuanHeLeThuoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_CoQuanHeLeThuoc").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc == keyword);
            }

			//Query NguoiThamGiaNghienCuu_MoiQuanHeSanCo (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_MoiQuanHeSanCo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_MoiQuanHeSanCo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_MoiQuanHeSanCo").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_MoiQuanHeSanCo == keyword);
            }

			//Query NguoiThamGiaNghienCuu_RaoCanNgonNgu (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_RaoCanNgonNgu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_RaoCanNgonNgu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_RaoCanNgonNgu").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_RaoCanNgonNgu == keyword);
            }

			//Query NguoiThamGiaNghienCuu_SangTuyen (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_SangTuyen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_SangTuyen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_SangTuyen").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_SangTuyen == keyword);
            }

			//Query NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung == keyword);
            }

			//Query NguoiThamGiaNghienCuu_DanTocThieuSo (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_DanTocThieuSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_DanTocThieuSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_DanTocThieuSo").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_DanTocThieuSo == keyword);
            }

			//Query NguoiThamGiaNghienCuu_ThamGiaTapThe (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_ThamGiaTapThe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_ThamGiaTapThe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_ThamGiaTapThe").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_ThamGiaTapThe == keyword);
            }

			//Query NguoiThamGiaNghienCuu_ChiTraKhuyenKhich (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_ChiTraKhuyenKhich") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_ChiTraKhuyenKhich").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_ChiTraKhuyenKhich").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich == keyword);
            }

			//Query NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung == keyword);
            }

			//Query NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat").Value;
                query = query.Where(d=>d.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat == keyword);
            }

			//Query QuyTrinhXinChapThuanTinhNguyen (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinhXinChapThuanTinhNguyen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinhXinChapThuanTinhNguyen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinhXinChapThuanTinhNguyen").Value;
                query = query.Where(d=>d.QuyTrinhXinChapThuanTinhNguyen == keyword);
            }

			//Query QuanLyDLVaBaoMat_ThuThapTrucTiep (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_ThuThapTrucTiep") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_ThuThapTrucTiep").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_ThuThapTrucTiep").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_ThuThapTrucTiep == keyword);
            }

			//Query QuanLyDLVaBaoMat_TiepCanThongTinCaNhan (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_TiepCanThongTinCaNhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_TiepCanThongTinCaNhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_TiepCanThongTinCaNhan").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan == keyword);
            }

			//Query QuanLyDLVaBaoMat_GhiLaiDL (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_GhiLaiDL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_GhiLaiDL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_GhiLaiDL").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_GhiLaiDL == keyword);
            }

			//Query QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam == keyword);
            }

			//Query QuanLyDLVaBaoMat_BaoMatThongTin (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_BaoMatThongTin") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoMatThongTin").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoMatThongTin").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_BaoMatThongTin == keyword);
            }

			//Query QuanLyDLVaBaoMat_LuuTruDLTrongXNam (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_LuuTruDLTrongXNam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_LuuTruDLTrongXNam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_LuuTruDLTrongXNam").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_LuuTruDLTrongXNam == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru == keyword);
            }

			//Query QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon == keyword);
            }

			//Query QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru == keyword);
            }

			//Query QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo == keyword);
            }

			//Query QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat").Value;
                query = query.Where(d=>d.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat == keyword);
            }

			//Query ThoiGianThucHien_ThuNghiem_NgayBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuNghiem_NgayBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NgayBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NgayBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuNghiem_NgayBatDau == keyword);
            }

			//Query ThoiGianThucHien_ThuNghiem_NgayKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuNghiem_NgayKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NgayKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NgayKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuNghiem_NgayKetThuc == keyword);
            }

			//Query ThoiGianThucHien_ThuNghiem_ThangBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuNghiem_ThangBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_ThangBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_ThangBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuNghiem_ThangBatDau == keyword);
            }

			//Query ThoiGianThucHien_ThuNghiem_ThangKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuNghiem_ThangKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_ThangKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_ThangKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuNghiem_ThangKetThuc == keyword);
            }

			//Query ThoiGianThucHien_ThuNghiem_NamBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuNghiem_NamBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NamBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NamBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuNghiem_NamBatDau == keyword);
            }

			//Query ThoiGianThucHien_ThuNghiem_NamKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuNghiem_NamKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NamKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuNghiem_NamKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuNghiem_NamKetThuc == keyword);
            }

			//Query ThoiGianThucHien_ThuThapDL_NgayBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuThapDL_NgayBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NgayBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NgayBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuThapDL_NgayBatDau == keyword);
            }

			//Query ThoiGianThucHien_ThuThapDL_NgayKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuThapDL_NgayKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NgayKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NgayKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuThapDL_NgayKetThuc == keyword);
            }

			//Query ThoiGianThucHien_ThuThapDL_ThangBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuThapDL_ThangBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_ThangBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_ThangBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuThapDL_ThangBatDau == keyword);
            }

			//Query ThoiGianThucHien_ThuThapDL_ThangKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuThapDL_ThangKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_ThangKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_ThangKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuThapDL_ThangKetThuc == keyword);
            }

			//Query ThoiGianThucHien_ThuThapDL_NamBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuThapDL_NamBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NamBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NamBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuThapDL_NamBatDau == keyword);
            }

			//Query ThoiGianThucHien_ThuThapDL_NamKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_ThuThapDL_NamKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NamKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_ThuThapDL_NamKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_ThuThapDL_NamKetThuc == keyword);
            }

			//Query ThoiGianThucHien_TongThoiGian_NgayBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_TongThoiGian_NgayBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NgayBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NgayBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_TongThoiGian_NgayBatDau == keyword);
            }

			//Query ThoiGianThucHien_TongThoiGian_NgayKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_TongThoiGian_NgayKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NgayKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NgayKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_TongThoiGian_NgayKetThuc == keyword);
            }

			//Query ThoiGianThucHien_TongThoiGian_ThangBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_TongThoiGian_ThangBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_ThangBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_ThangBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_TongThoiGian_ThangBatDau == keyword);
            }

			//Query ThoiGianThucHien_TongThoiGian_ThangKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_TongThoiGian_ThangKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_ThangKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_ThangKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_TongThoiGian_ThangKetThuc == keyword);
            }

			//Query ThoiGianThucHien_TongThoiGian_NamBatDau (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_TongThoiGian_NamBatDau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NamBatDau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NamBatDau").Value;
                query = query.Where(d=>d.ThoiGianThucHien_TongThoiGian_NamBatDau == keyword);
            }

			//Query ThoiGianThucHien_TongThoiGian_NamKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThucHien_TongThoiGian_NamKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NamKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThucHien_TongThoiGian_NamKetThuc").Value;
                query = query.Where(d=>d.ThoiGianThucHien_TongThoiGian_NamKetThuc == keyword);
            }

			//Query MauThuanLoiIch_NghienCuuTheoYeuCau (string)
			if (QueryStrings.Any(d => d.Key == "MauThuanLoiIch_NghienCuuTheoYeuCau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MauThuanLoiIch_NghienCuuTheoYeuCau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MauThuanLoiIch_NghienCuuTheoYeuCau").Value;
                query = query.Where(d=>d.MauThuanLoiIch_NghienCuuTheoYeuCau == keyword);
            }

			//Query MauThuanLoiIch_PhuThuocTaiChinh (string)
			if (QueryStrings.Any(d => d.Key == "MauThuanLoiIch_PhuThuocTaiChinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MauThuanLoiIch_PhuThuocTaiChinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MauThuanLoiIch_PhuThuocTaiChinh").Value;
                query = query.Where(d=>d.MauThuanLoiIch_PhuThuocTaiChinh == keyword);
            }

			//Query MauThuanLoiIch_LoiIchTaiChinh (string)
			if (QueryStrings.Any(d => d.Key == "MauThuanLoiIch_LoiIchTaiChinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MauThuanLoiIch_LoiIchTaiChinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MauThuanLoiIch_LoiIchTaiChinh").Value;
                query = query.Where(d=>d.MauThuanLoiIch_LoiIchTaiChinh == keyword);
            }

			//Query CanNhacDaoDucKhac (string)
			if (QueryStrings.Any(d => d.Key == "CanNhacDaoDucKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CanNhacDaoDucKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CanNhacDaoDucKhac").Value;
                query = query.Where(d=>d.CanNhacDaoDucKhac == keyword);
            }

			//Query TongQuanTaiLieuKeHoachPhuongPhap (string)
			if (QueryStrings.Any(d => d.Key == "TongQuanTaiLieuKeHoachPhuongPhap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TongQuanTaiLieuKeHoachPhuongPhap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TongQuanTaiLieuKeHoachPhuongPhap").Value;
                query = query.Where(d=>d.TongQuanTaiLieuKeHoachPhuongPhap == keyword);
            }

			//Query CanKet_TenNCYSH (string)
			if (QueryStrings.Any(d => d.Key == "CanKet_TenNCYSH") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CanKet_TenNCYSH").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CanKet_TenNCYSH").Value;
                query = query.Where(d=>d.CanKet_TenNCYSH == keyword);
            }

			//Query YKienNguoiHuongDan_TenNCYSH (string)
			if (QueryStrings.Any(d => d.Key == "YKienNguoiHuongDan_TenNCYSH") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_TenNCYSH").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_TenNCYSH").Value;
                query = query.Where(d=>d.YKienNguoiHuongDan_TenNCYSH == keyword);
            }

			//Query YKienNguoiHuongDan_NhanXet (string)
			if (QueryStrings.Any(d => d.Key == "YKienNguoiHuongDan_NhanXet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_NhanXet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_NhanXet").Value;
                query = query.Where(d=>d.YKienNguoiHuongDan_NhanXet == keyword);
            }

			//Query YKienNguoiHuongDan_BoMon (string)
			if (QueryStrings.Any(d => d.Key == "YKienNguoiHuongDan_BoMon") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_BoMon").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_BoMon").Value;
                query = query.Where(d=>d.YKienNguoiHuongDan_BoMon == keyword);
            }

			//Query YKienNguoiHuongDan_NgayKy (string)
			if (QueryStrings.Any(d => d.Key == "YKienNguoiHuongDan_NgayKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_NgayKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_NgayKy").Value;
                query = query.Where(d=>d.YKienNguoiHuongDan_NgayKy == keyword);
            }

			//Query YKienNguoiHuongDan_ThangKy (string)
			if (QueryStrings.Any(d => d.Key == "YKienNguoiHuongDan_ThangKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_ThangKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_ThangKy").Value;
                query = query.Where(d=>d.YKienNguoiHuongDan_ThangKy == keyword);
            }

			//Query YKienNguoiHuongDan_NamKy (string)
			if (QueryStrings.Any(d => d.Key == "YKienNguoiHuongDan_NamKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_NamKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_NamKy").Value;
                query = query.Where(d=>d.YKienNguoiHuongDan_NamKy == keyword);
            }

			//Query YKienNguoiHuongDan_HoTenVaChucDanh (string)
			if (QueryStrings.Any(d => d.Key == "YKienNguoiHuongDan_HoTenVaChucDanh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_HoTenVaChucDanh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienNguoiHuongDan_HoTenVaChucDanh").Value;
                query = query.Where(d=>d.YKienNguoiHuongDan_HoTenVaChucDanh == keyword);
            }

			//Query YKienTruongKhoa_XemXetBoiHDKH (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_XemXetBoiHDKH") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_XemXetBoiHDKH").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_XemXetBoiHDKH").Value;
                query = query.Where(d=>d.YKienTruongKhoa_XemXetBoiHDKH == keyword);
            }

			//Query YKienTruongKhoa_XemXetBoiCapCaNhan (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_XemXetBoiCapCaNhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_XemXetBoiCapCaNhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_XemXetBoiCapCaNhan").Value;
                query = query.Where(d=>d.YKienTruongKhoa_XemXetBoiCapCaNhan == keyword);
            }

			//Query YKienTruongKhoa_XemXetBoiKhoaPhong (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_XemXetBoiKhoaPhong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_XemXetBoiKhoaPhong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_XemXetBoiKhoaPhong").Value;
                query = query.Where(d=>d.YKienTruongKhoa_XemXetBoiKhoaPhong == keyword);
            }

			//Query YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap").Value;
                query = query.Where(d=>d.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap == keyword);
            }

			//Query YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap").Value;
                query = query.Where(d=>d.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap == keyword);
            }

			//Query YKienTruongKhoa_NhanXet (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_NhanXet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_NhanXet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_NhanXet").Value;
                query = query.Where(d=>d.YKienTruongKhoa_NhanXet == keyword);
            }

			//Query YKienTruongKhoa_BoMon (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_BoMon") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_BoMon").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_BoMon").Value;
                query = query.Where(d=>d.YKienTruongKhoa_BoMon == keyword);
            }

			//Query YKienTruongKhoa_NgayKy (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_NgayKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_NgayKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_NgayKy").Value;
                query = query.Where(d=>d.YKienTruongKhoa_NgayKy == keyword);
            }

			//Query YKienTruongKhoa_ThangKy (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_ThangKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_ThangKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_ThangKy").Value;
                query = query.Where(d=>d.YKienTruongKhoa_ThangKy == keyword);
            }

			//Query YKienTruongKhoa_NamKy (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_NamKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_NamKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_NamKy").Value;
                query = query.Where(d=>d.YKienTruongKhoa_NamKy == keyword);
            }

			//Query YKienTruongKhoa_HoTenVaChucDanh (string)
			if (QueryStrings.Any(d => d.Key == "YKienTruongKhoa_HoTenVaChucDanh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_HoTenVaChucDanh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienTruongKhoa_HoTenVaChucDanh").Value;
                query = query.Where(d=>d.YKienTruongKhoa_HoTenVaChucDanh == keyword);
            }

			//Query JSON_ChuKy (string)
			if (QueryStrings.Any(d => d.Key == "JSON_ChuKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_ChuKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_ChuKy").Value;
                query = query.Where(d=>d.JSON_ChuKy == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_PhieuXemXetDaoDuc get_PRO_PhieuXemXetDaoDuc(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_PhieuXemXetDaoDuc.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_PhieuXemXetDaoDuc(AppEntities db, int ID, DTO_PRO_PhieuXemXetDaoDuc item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_PhieuXemXetDaoDuc.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.MaSo = item.MaSo;							
				dbitem.NghienCuuDuocTaiTro = item.NghienCuuDuocTaiTro;							
				dbitem.XinPhepTapThe = item.XinPhepTapThe;							
				dbitem.KhongThuocNghienCuuNao = item.KhongThuocNghienCuuNao;							
				dbitem.NghienCuuHocVienSauDaiHoc = item.NghienCuuHocVienSauDaiHoc;							
				dbitem.DonXinTaiCapPhep = item.DonXinTaiCapPhep;							
				dbitem.NghienCuuCuaSinhVienDaiHoc = item.NghienCuuCuaSinhVienDaiHoc;							
				dbitem.SoGiayPhepCu = item.SoGiayPhepCu;							
				dbitem.TenNCSYH = item.TenNCSYH;							
				dbitem.JSON_CacNCV = item.JSON_CacNCV;							
				dbitem.DonViChuTri = item.DonViChuTri;							
				dbitem.NguoiGiaoDich_HoTen = item.NguoiGiaoDich_HoTen;							
				dbitem.NguoiGiaoDich_DiaChiGiaoDich = item.NguoiGiaoDich_DiaChiGiaoDich;							
				dbitem.NguoiGiaoDich_DienThoaiCQ = item.NguoiGiaoDich_DienThoaiCQ;							
				dbitem.NguoiGiaoDich_DienThoaiFx = item.NguoiGiaoDich_DienThoaiFx;							
				dbitem.NguoiGiaoDich_DienThoaiNR = item.NguoiGiaoDich_DienThoaiNR;							
				dbitem.NguoiGiaoDich_DienThoaiDD = item.NguoiGiaoDich_DienThoaiDD;							
				dbitem.NguoiGiaoDich_Email = item.NguoiGiaoDich_Email;							
				dbitem.JSON_CacCoQuan = item.JSON_CacCoQuan;							
				dbitem.QuyChe_TreEm = item.QuyChe_TreEm;							
				dbitem.QuyChe_NguoiQuanHeLeThuoc = item.QuyChe_NguoiQuanHeLeThuoc;							
				dbitem.QuyChe_PhongXa = item.QuyChe_PhongXa;							
				dbitem.QuyChe_PhacDoDieuTri = item.QuyChe_PhacDoDieuTri;							
				dbitem.QuyChe_GienNguoi = item.QuyChe_GienNguoi;							
				dbitem.QuyChe_NguoiTonThuongThanKinh = item.QuyChe_NguoiTonThuongThanKinh;							
				dbitem.QuyChe_CacTapTheNhomNguoi = item.QuyChe_CacTapTheNhomNguoi;							
				dbitem.QuyChe_NghienCuuDichTeHoc = item.QuyChe_NghienCuuDichTeHoc;							
				dbitem.QuyChe_NguoiCanChamSocYTe = item.QuyChe_NguoiCanChamSocYTe;							
				dbitem.QuyChe_NguoiDanToc = item.QuyChe_NguoiDanToc;							
				dbitem.QuyChe_ThuNghiemLamSang = item.QuyChe_ThuNghiemLamSang;							
				dbitem.QuyChe_SuDungMauMoNguoi = item.QuyChe_SuDungMauMoNguoi;							
				dbitem.ThongTinNguonTaiTro = item.ThongTinNguonTaiTro;							
				dbitem.ThongTinNCYSHSinhVien = item.ThongTinNCYSHSinhVien;							
				dbitem.QuyTrinh_MoTaDuAn = item.QuyTrinh_MoTaDuAn;							
				dbitem.QuyTrinh_QuyTrinhThucHien = item.QuyTrinh_QuyTrinhThucHien;							
				dbitem.QuyTrinh_MucDich = item.QuyTrinh_MucDich;							
				dbitem.QuyTrinh_VanDeLienQuan = item.QuyTrinh_VanDeLienQuan;							
				dbitem.QuyTrinh_DiaDiemNghienCuu = item.QuyTrinh_DiaDiemNghienCuu;							
				dbitem.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = item.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia;							
				dbitem.NguyCoTiemTang_NhomNghienCuu = item.NguyCoTiemTang_NhomNghienCuu;							
				dbitem.NguyCoTiemTang_NguoiThamGia = item.NguyCoTiemTang_NguoiThamGia;							
				dbitem.NguyCoTiemTang_CongDongCuaTruong = item.NguyCoTiemTang_CongDongCuaTruong;							
				dbitem.NguyCoTiemTang_CongDongLonHon = item.NguyCoTiemTang_CongDongLonHon;							
				dbitem.NguyCoTiemTang_SoSanhRuiRo = item.NguyCoTiemTang_SoSanhRuiRo;							
				dbitem.NguyCoTiemTang_QuyTrinhGiamRuiRo = item.NguyCoTiemTang_QuyTrinhGiamRuiRo;							
				dbitem.NguyCoTiemTang_CachXuLyRuiRo = item.NguyCoTiemTang_CachXuLyRuiRo;							
				dbitem.LoiIchTiemTang_NhungLoiIch = item.LoiIchTiemTang_NhungLoiIch;							
				dbitem.LoiIchTiemTang_AiDuocLoi = item.LoiIchTiemTang_AiDuocLoi;							
				dbitem.LoiIchTiemTang_DongGopKhoaHoc = item.LoiIchTiemTang_DongGopKhoaHoc;							
				dbitem.LoiIchTiemTang_SoSanh = item.LoiIchTiemTang_SoSanh;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NguoiThamGiaNghienCuu_DuKien = item.NguoiThamGiaNghienCuu_DuKien;							
				dbitem.NguoiThamGiaNghienCuu_CachXacDinh = item.NguoiThamGiaNghienCuu_CachXacDinh;							
				dbitem.NguoiThamGiaNghienCuu_TreViThanhNien = item.NguoiThamGiaNghienCuu_TreViThanhNien;							
				dbitem.NguoiThamGiaNghienCuu_ThieuNangTriTue = item.NguoiThamGiaNghienCuu_ThieuNangTriTue;							
				dbitem.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc = item.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc;							
				dbitem.NguoiThamGiaNghienCuu_MoiQuanHeSanCo = item.NguoiThamGiaNghienCuu_MoiQuanHeSanCo;							
				dbitem.NguoiThamGiaNghienCuu_RaoCanNgonNgu = item.NguoiThamGiaNghienCuu_RaoCanNgonNgu;							
				dbitem.NguoiThamGiaNghienCuu_SangTuyen = item.NguoiThamGiaNghienCuu_SangTuyen;							
				dbitem.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung = item.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung;							
				dbitem.NguoiThamGiaNghienCuu_DanTocThieuSo = item.NguoiThamGiaNghienCuu_DanTocThieuSo;							
				dbitem.NguoiThamGiaNghienCuu_ThamGiaTapThe = item.NguoiThamGiaNghienCuu_ThamGiaTapThe;							
				dbitem.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich = item.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich;							
				dbitem.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung = item.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung;							
				dbitem.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat = item.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat;							
				dbitem.QuyTrinhXinChapThuanTinhNguyen = item.QuyTrinhXinChapThuanTinhNguyen;							
				dbitem.QuanLyDLVaBaoMat_ThuThapTrucTiep = item.QuanLyDLVaBaoMat_ThuThapTrucTiep;							
				dbitem.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan = item.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan;							
				dbitem.QuanLyDLVaBaoMat_GhiLaiDL = item.QuanLyDLVaBaoMat_GhiLaiDL;							
				dbitem.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam = item.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam;							
				dbitem.QuanLyDLVaBaoMat_BaoMatThongTin = item.QuanLyDLVaBaoMat_BaoMatThongTin;							
				dbitem.QuanLyDLVaBaoMat_LuuTruDLTrongXNam = item.QuanLyDLVaBaoMat_LuuTruDLTrongXNam;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon;							
				dbitem.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru = item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru;							
				dbitem.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo = item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo;							
				dbitem.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat = item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat;							
				dbitem.ThoiGianThucHien_ThuNghiem_NgayBatDau = item.ThoiGianThucHien_ThuNghiem_NgayBatDau;							
				dbitem.ThoiGianThucHien_ThuNghiem_NgayKetThuc = item.ThoiGianThucHien_ThuNghiem_NgayKetThuc;							
				dbitem.ThoiGianThucHien_ThuNghiem_ThangBatDau = item.ThoiGianThucHien_ThuNghiem_ThangBatDau;							
				dbitem.ThoiGianThucHien_ThuNghiem_ThangKetThuc = item.ThoiGianThucHien_ThuNghiem_ThangKetThuc;							
				dbitem.ThoiGianThucHien_ThuNghiem_NamBatDau = item.ThoiGianThucHien_ThuNghiem_NamBatDau;							
				dbitem.ThoiGianThucHien_ThuNghiem_NamKetThuc = item.ThoiGianThucHien_ThuNghiem_NamKetThuc;							
				dbitem.ThoiGianThucHien_ThuThapDL_NgayBatDau = item.ThoiGianThucHien_ThuThapDL_NgayBatDau;							
				dbitem.ThoiGianThucHien_ThuThapDL_NgayKetThuc = item.ThoiGianThucHien_ThuThapDL_NgayKetThuc;							
				dbitem.ThoiGianThucHien_ThuThapDL_ThangBatDau = item.ThoiGianThucHien_ThuThapDL_ThangBatDau;							
				dbitem.ThoiGianThucHien_ThuThapDL_ThangKetThuc = item.ThoiGianThucHien_ThuThapDL_ThangKetThuc;							
				dbitem.ThoiGianThucHien_ThuThapDL_NamBatDau = item.ThoiGianThucHien_ThuThapDL_NamBatDau;							
				dbitem.ThoiGianThucHien_ThuThapDL_NamKetThuc = item.ThoiGianThucHien_ThuThapDL_NamKetThuc;							
				dbitem.ThoiGianThucHien_TongThoiGian_NgayBatDau = item.ThoiGianThucHien_TongThoiGian_NgayBatDau;							
				dbitem.ThoiGianThucHien_TongThoiGian_NgayKetThuc = item.ThoiGianThucHien_TongThoiGian_NgayKetThuc;							
				dbitem.ThoiGianThucHien_TongThoiGian_ThangBatDau = item.ThoiGianThucHien_TongThoiGian_ThangBatDau;							
				dbitem.ThoiGianThucHien_TongThoiGian_ThangKetThuc = item.ThoiGianThucHien_TongThoiGian_ThangKetThuc;							
				dbitem.ThoiGianThucHien_TongThoiGian_NamBatDau = item.ThoiGianThucHien_TongThoiGian_NamBatDau;							
				dbitem.ThoiGianThucHien_TongThoiGian_NamKetThuc = item.ThoiGianThucHien_TongThoiGian_NamKetThuc;							
				dbitem.MauThuanLoiIch_NghienCuuTheoYeuCau = item.MauThuanLoiIch_NghienCuuTheoYeuCau;							
				dbitem.MauThuanLoiIch_PhuThuocTaiChinh = item.MauThuanLoiIch_PhuThuocTaiChinh;							
				dbitem.MauThuanLoiIch_LoiIchTaiChinh = item.MauThuanLoiIch_LoiIchTaiChinh;							
				dbitem.CanNhacDaoDucKhac = item.CanNhacDaoDucKhac;							
				dbitem.TongQuanTaiLieuKeHoachPhuongPhap = item.TongQuanTaiLieuKeHoachPhuongPhap;							
				dbitem.CanKet_TenNCYSH = item.CanKet_TenNCYSH;							
				dbitem.YKienNguoiHuongDan_TenNCYSH = item.YKienNguoiHuongDan_TenNCYSH;							
				dbitem.YKienNguoiHuongDan_NhanXet = item.YKienNguoiHuongDan_NhanXet;							
				dbitem.YKienNguoiHuongDan_BoMon = item.YKienNguoiHuongDan_BoMon;							
				dbitem.YKienNguoiHuongDan_NgayKy = item.YKienNguoiHuongDan_NgayKy;							
				dbitem.YKienNguoiHuongDan_ThangKy = item.YKienNguoiHuongDan_ThangKy;							
				dbitem.YKienNguoiHuongDan_NamKy = item.YKienNguoiHuongDan_NamKy;							
				dbitem.YKienNguoiHuongDan_HoTenVaChucDanh = item.YKienNguoiHuongDan_HoTenVaChucDanh;							
				dbitem.YKienTruongKhoa_XemXetBoiHDKH = item.YKienTruongKhoa_XemXetBoiHDKH;							
				dbitem.YKienTruongKhoa_XemXetBoiCapCaNhan = item.YKienTruongKhoa_XemXetBoiCapCaNhan;							
				dbitem.YKienTruongKhoa_XemXetBoiKhoaPhong = item.YKienTruongKhoa_XemXetBoiKhoaPhong;							
				dbitem.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap = item.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap;							
				dbitem.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap = item.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap;							
				dbitem.YKienTruongKhoa_NhanXet = item.YKienTruongKhoa_NhanXet;							
				dbitem.YKienTruongKhoa_BoMon = item.YKienTruongKhoa_BoMon;							
				dbitem.YKienTruongKhoa_NgayKy = item.YKienTruongKhoa_NgayKy;							
				dbitem.YKienTruongKhoa_ThangKy = item.YKienTruongKhoa_ThangKy;							
				dbitem.YKienTruongKhoa_NamKy = item.YKienTruongKhoa_NamKy;							
				dbitem.YKienTruongKhoa_HoTenVaChucDanh = item.YKienTruongKhoa_HoTenVaChucDanh;							
				dbitem.JSON_ChuKy = item.JSON_ChuKy;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_PhieuXemXetDaoDuc", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_PhieuXemXetDaoDuc",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_PhieuXemXetDaoDuc post_PRO_PhieuXemXetDaoDuc(AppEntities db, DTO_PRO_PhieuXemXetDaoDuc item, string Username)
        {
            tbl_PRO_PhieuXemXetDaoDuc dbitem = new tbl_PRO_PhieuXemXetDaoDuc();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.MaSo = item.MaSo;							
				dbitem.NghienCuuDuocTaiTro = item.NghienCuuDuocTaiTro;							
				dbitem.XinPhepTapThe = item.XinPhepTapThe;							
				dbitem.KhongThuocNghienCuuNao = item.KhongThuocNghienCuuNao;							
				dbitem.NghienCuuHocVienSauDaiHoc = item.NghienCuuHocVienSauDaiHoc;							
				dbitem.DonXinTaiCapPhep = item.DonXinTaiCapPhep;							
				dbitem.NghienCuuCuaSinhVienDaiHoc = item.NghienCuuCuaSinhVienDaiHoc;							
				dbitem.SoGiayPhepCu = item.SoGiayPhepCu;							
				dbitem.TenNCSYH = item.TenNCSYH;							
				dbitem.JSON_CacNCV = item.JSON_CacNCV;							
				dbitem.DonViChuTri = item.DonViChuTri;							
				dbitem.NguoiGiaoDich_HoTen = item.NguoiGiaoDich_HoTen;							
				dbitem.NguoiGiaoDich_DiaChiGiaoDich = item.NguoiGiaoDich_DiaChiGiaoDich;							
				dbitem.NguoiGiaoDich_DienThoaiCQ = item.NguoiGiaoDich_DienThoaiCQ;							
				dbitem.NguoiGiaoDich_DienThoaiFx = item.NguoiGiaoDich_DienThoaiFx;							
				dbitem.NguoiGiaoDich_DienThoaiNR = item.NguoiGiaoDich_DienThoaiNR;							
				dbitem.NguoiGiaoDich_DienThoaiDD = item.NguoiGiaoDich_DienThoaiDD;							
				dbitem.NguoiGiaoDich_Email = item.NguoiGiaoDich_Email;							
				dbitem.JSON_CacCoQuan = item.JSON_CacCoQuan;							
				dbitem.QuyChe_TreEm = item.QuyChe_TreEm;							
				dbitem.QuyChe_NguoiQuanHeLeThuoc = item.QuyChe_NguoiQuanHeLeThuoc;							
				dbitem.QuyChe_PhongXa = item.QuyChe_PhongXa;							
				dbitem.QuyChe_PhacDoDieuTri = item.QuyChe_PhacDoDieuTri;							
				dbitem.QuyChe_GienNguoi = item.QuyChe_GienNguoi;							
				dbitem.QuyChe_NguoiTonThuongThanKinh = item.QuyChe_NguoiTonThuongThanKinh;							
				dbitem.QuyChe_CacTapTheNhomNguoi = item.QuyChe_CacTapTheNhomNguoi;							
				dbitem.QuyChe_NghienCuuDichTeHoc = item.QuyChe_NghienCuuDichTeHoc;							
				dbitem.QuyChe_NguoiCanChamSocYTe = item.QuyChe_NguoiCanChamSocYTe;							
				dbitem.QuyChe_NguoiDanToc = item.QuyChe_NguoiDanToc;							
				dbitem.QuyChe_ThuNghiemLamSang = item.QuyChe_ThuNghiemLamSang;							
				dbitem.QuyChe_SuDungMauMoNguoi = item.QuyChe_SuDungMauMoNguoi;							
				dbitem.ThongTinNguonTaiTro = item.ThongTinNguonTaiTro;							
				dbitem.ThongTinNCYSHSinhVien = item.ThongTinNCYSHSinhVien;							
				dbitem.QuyTrinh_MoTaDuAn = item.QuyTrinh_MoTaDuAn;							
				dbitem.QuyTrinh_QuyTrinhThucHien = item.QuyTrinh_QuyTrinhThucHien;							
				dbitem.QuyTrinh_MucDich = item.QuyTrinh_MucDich;							
				dbitem.QuyTrinh_VanDeLienQuan = item.QuyTrinh_VanDeLienQuan;							
				dbitem.QuyTrinh_DiaDiemNghienCuu = item.QuyTrinh_DiaDiemNghienCuu;							
				dbitem.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = item.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia;							
				dbitem.NguyCoTiemTang_NhomNghienCuu = item.NguyCoTiemTang_NhomNghienCuu;							
				dbitem.NguyCoTiemTang_NguoiThamGia = item.NguyCoTiemTang_NguoiThamGia;							
				dbitem.NguyCoTiemTang_CongDongCuaTruong = item.NguyCoTiemTang_CongDongCuaTruong;							
				dbitem.NguyCoTiemTang_CongDongLonHon = item.NguyCoTiemTang_CongDongLonHon;							
				dbitem.NguyCoTiemTang_SoSanhRuiRo = item.NguyCoTiemTang_SoSanhRuiRo;							
				dbitem.NguyCoTiemTang_QuyTrinhGiamRuiRo = item.NguyCoTiemTang_QuyTrinhGiamRuiRo;							
				dbitem.NguyCoTiemTang_CachXuLyRuiRo = item.NguyCoTiemTang_CachXuLyRuiRo;							
				dbitem.LoiIchTiemTang_NhungLoiIch = item.LoiIchTiemTang_NhungLoiIch;							
				dbitem.LoiIchTiemTang_AiDuocLoi = item.LoiIchTiemTang_AiDuocLoi;							
				dbitem.LoiIchTiemTang_DongGopKhoaHoc = item.LoiIchTiemTang_DongGopKhoaHoc;							
				dbitem.LoiIchTiemTang_SoSanh = item.LoiIchTiemTang_SoSanh;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NguoiThamGiaNghienCuu_DuKien = item.NguoiThamGiaNghienCuu_DuKien;							
				dbitem.NguoiThamGiaNghienCuu_CachXacDinh = item.NguoiThamGiaNghienCuu_CachXacDinh;							
				dbitem.NguoiThamGiaNghienCuu_TreViThanhNien = item.NguoiThamGiaNghienCuu_TreViThanhNien;							
				dbitem.NguoiThamGiaNghienCuu_ThieuNangTriTue = item.NguoiThamGiaNghienCuu_ThieuNangTriTue;							
				dbitem.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc = item.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc;							
				dbitem.NguoiThamGiaNghienCuu_MoiQuanHeSanCo = item.NguoiThamGiaNghienCuu_MoiQuanHeSanCo;							
				dbitem.NguoiThamGiaNghienCuu_RaoCanNgonNgu = item.NguoiThamGiaNghienCuu_RaoCanNgonNgu;							
				dbitem.NguoiThamGiaNghienCuu_SangTuyen = item.NguoiThamGiaNghienCuu_SangTuyen;							
				dbitem.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung = item.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung;							
				dbitem.NguoiThamGiaNghienCuu_DanTocThieuSo = item.NguoiThamGiaNghienCuu_DanTocThieuSo;							
				dbitem.NguoiThamGiaNghienCuu_ThamGiaTapThe = item.NguoiThamGiaNghienCuu_ThamGiaTapThe;							
				dbitem.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich = item.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich;							
				dbitem.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung = item.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung;							
				dbitem.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat = item.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat;							
				dbitem.QuyTrinhXinChapThuanTinhNguyen = item.QuyTrinhXinChapThuanTinhNguyen;							
				dbitem.QuanLyDLVaBaoMat_ThuThapTrucTiep = item.QuanLyDLVaBaoMat_ThuThapTrucTiep;							
				dbitem.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan = item.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan;							
				dbitem.QuanLyDLVaBaoMat_GhiLaiDL = item.QuanLyDLVaBaoMat_GhiLaiDL;							
				dbitem.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam = item.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam;							
				dbitem.QuanLyDLVaBaoMat_BaoMatThongTin = item.QuanLyDLVaBaoMat_BaoMatThongTin;							
				dbitem.QuanLyDLVaBaoMat_LuuTruDLTrongXNam = item.QuanLyDLVaBaoMat_LuuTruDLTrongXNam;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru;							
				dbitem.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon = item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru;							
				dbitem.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon = item.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon;							
				dbitem.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru = item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru;							
				dbitem.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo = item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo;							
				dbitem.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat = item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat;							
				dbitem.ThoiGianThucHien_ThuNghiem_NgayBatDau = item.ThoiGianThucHien_ThuNghiem_NgayBatDau;							
				dbitem.ThoiGianThucHien_ThuNghiem_NgayKetThuc = item.ThoiGianThucHien_ThuNghiem_NgayKetThuc;							
				dbitem.ThoiGianThucHien_ThuNghiem_ThangBatDau = item.ThoiGianThucHien_ThuNghiem_ThangBatDau;							
				dbitem.ThoiGianThucHien_ThuNghiem_ThangKetThuc = item.ThoiGianThucHien_ThuNghiem_ThangKetThuc;							
				dbitem.ThoiGianThucHien_ThuNghiem_NamBatDau = item.ThoiGianThucHien_ThuNghiem_NamBatDau;							
				dbitem.ThoiGianThucHien_ThuNghiem_NamKetThuc = item.ThoiGianThucHien_ThuNghiem_NamKetThuc;							
				dbitem.ThoiGianThucHien_ThuThapDL_NgayBatDau = item.ThoiGianThucHien_ThuThapDL_NgayBatDau;							
				dbitem.ThoiGianThucHien_ThuThapDL_NgayKetThuc = item.ThoiGianThucHien_ThuThapDL_NgayKetThuc;							
				dbitem.ThoiGianThucHien_ThuThapDL_ThangBatDau = item.ThoiGianThucHien_ThuThapDL_ThangBatDau;							
				dbitem.ThoiGianThucHien_ThuThapDL_ThangKetThuc = item.ThoiGianThucHien_ThuThapDL_ThangKetThuc;							
				dbitem.ThoiGianThucHien_ThuThapDL_NamBatDau = item.ThoiGianThucHien_ThuThapDL_NamBatDau;							
				dbitem.ThoiGianThucHien_ThuThapDL_NamKetThuc = item.ThoiGianThucHien_ThuThapDL_NamKetThuc;							
				dbitem.ThoiGianThucHien_TongThoiGian_NgayBatDau = item.ThoiGianThucHien_TongThoiGian_NgayBatDau;							
				dbitem.ThoiGianThucHien_TongThoiGian_NgayKetThuc = item.ThoiGianThucHien_TongThoiGian_NgayKetThuc;							
				dbitem.ThoiGianThucHien_TongThoiGian_ThangBatDau = item.ThoiGianThucHien_TongThoiGian_ThangBatDau;							
				dbitem.ThoiGianThucHien_TongThoiGian_ThangKetThuc = item.ThoiGianThucHien_TongThoiGian_ThangKetThuc;							
				dbitem.ThoiGianThucHien_TongThoiGian_NamBatDau = item.ThoiGianThucHien_TongThoiGian_NamBatDau;							
				dbitem.ThoiGianThucHien_TongThoiGian_NamKetThuc = item.ThoiGianThucHien_TongThoiGian_NamKetThuc;							
				dbitem.MauThuanLoiIch_NghienCuuTheoYeuCau = item.MauThuanLoiIch_NghienCuuTheoYeuCau;							
				dbitem.MauThuanLoiIch_PhuThuocTaiChinh = item.MauThuanLoiIch_PhuThuocTaiChinh;							
				dbitem.MauThuanLoiIch_LoiIchTaiChinh = item.MauThuanLoiIch_LoiIchTaiChinh;							
				dbitem.CanNhacDaoDucKhac = item.CanNhacDaoDucKhac;							
				dbitem.TongQuanTaiLieuKeHoachPhuongPhap = item.TongQuanTaiLieuKeHoachPhuongPhap;							
				dbitem.CanKet_TenNCYSH = item.CanKet_TenNCYSH;							
				dbitem.YKienNguoiHuongDan_TenNCYSH = item.YKienNguoiHuongDan_TenNCYSH;							
				dbitem.YKienNguoiHuongDan_NhanXet = item.YKienNguoiHuongDan_NhanXet;							
				dbitem.YKienNguoiHuongDan_BoMon = item.YKienNguoiHuongDan_BoMon;							
				dbitem.YKienNguoiHuongDan_NgayKy = item.YKienNguoiHuongDan_NgayKy;							
				dbitem.YKienNguoiHuongDan_ThangKy = item.YKienNguoiHuongDan_ThangKy;							
				dbitem.YKienNguoiHuongDan_NamKy = item.YKienNguoiHuongDan_NamKy;							
				dbitem.YKienNguoiHuongDan_HoTenVaChucDanh = item.YKienNguoiHuongDan_HoTenVaChucDanh;							
				dbitem.YKienTruongKhoa_XemXetBoiHDKH = item.YKienTruongKhoa_XemXetBoiHDKH;							
				dbitem.YKienTruongKhoa_XemXetBoiCapCaNhan = item.YKienTruongKhoa_XemXetBoiCapCaNhan;							
				dbitem.YKienTruongKhoa_XemXetBoiKhoaPhong = item.YKienTruongKhoa_XemXetBoiKhoaPhong;							
				dbitem.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap = item.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap;							
				dbitem.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap = item.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap;							
				dbitem.YKienTruongKhoa_NhanXet = item.YKienTruongKhoa_NhanXet;							
				dbitem.YKienTruongKhoa_BoMon = item.YKienTruongKhoa_BoMon;							
				dbitem.YKienTruongKhoa_NgayKy = item.YKienTruongKhoa_NgayKy;							
				dbitem.YKienTruongKhoa_ThangKy = item.YKienTruongKhoa_ThangKy;							
				dbitem.YKienTruongKhoa_NamKy = item.YKienTruongKhoa_NamKy;							
				dbitem.YKienTruongKhoa_HoTenVaChucDanh = item.YKienTruongKhoa_HoTenVaChucDanh;							
				dbitem.JSON_ChuKy = item.JSON_ChuKy;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_PhieuXemXetDaoDuc.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_PhieuXemXetDaoDuc", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_PhieuXemXetDaoDuc",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_PhieuXemXetDaoDuc(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_PhieuXemXetDaoDuc.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_PhieuXemXetDaoDuc", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_PhieuXemXetDaoDuc",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_PhieuXemXetDaoDuc_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_PhieuXemXetDaoDuc.Any(e => e.ID == id);
		}
		
    }

}






