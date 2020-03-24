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
    
    
    public partial class tbl_PRO_ThuyetMinhDeTai
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string A1_TenTiengViet { get; set; }
        public string A1_TenTiengAnh { get; set; }
        public bool A2_QuanLy { get; set; }
        public bool A2_SinhHocVaCongNghe { get; set; }
        public bool A2_KhoaHocSucKhoe { get; set; }
        public bool A2_Khac { get; set; }
        public string A2_KhacMoTa { get; set; }
        public bool A3_NghienCuuCoBan { get; set; }
        public bool A3_NghienCuuUngDung { get; set; }
        public bool A3_NghienCuuTrienKhai { get; set; }
        public string A4_ThoiGianThucHien { get; set; }
        public string A5_TongKinhPhi { get; set; }
        public string A6_HoTen { get; set; }
        public string A6_NgaySinh { get; set; }
        public string A6_GioiTinh { get; set; }
        public string A6_CMND { get; set; }
        public string A6_NgayCap { get; set; }
        public string A6_NoiCap { get; set; }
        public string A6_MST { get; set; }
        public string A6_STK { get; set; }
        public string A6_NganHang { get; set; }
        public string A6_DiaChiCoQuan { get; set; }
        public string A6_DienThoai { get; set; }
        public string A6_Email { get; set; }
        public string A6_TomTatHoatDong { get; set; }
        public string A7_TenCoQuan { get; set; }
        public string A7_HoTenThuTruong { get; set; }
        public string A7_DienThoai { get; set; }
        public string A7_DiaChi { get; set; }
        public string A8_CoQuanPhoiHopThucHien { get; set; }
        public string A9_JSON_NhanLucNghienCuu { get; set; }
        public string B1_GioiThieu { get; set; }
        public string B2_TaiLieuThamKhao { get; set; }
        public string B2_JSON_GioiThieuChuyenGia { get; set; }
        public string B311_MucTieuNghienCuu { get; set; }
        public string B312_ChiTieuDanhGia { get; set; }
        public string B313_DiaChi { get; set; }
        public string B313_JSON_KeHoachThucHien { get; set; }
        public string B321_ThietKeNghienCuu { get; set; }
        public string B322_DanSoNghienCuu { get; set; }
        public string B3221_TieuChuanNhanLoai { get; set; }
        public string B3222_CoMau { get; set; }
        public string B323_PhuongPhapTienHanh { get; set; }
        public string B324_PhuongPhapDanhGia { get; set; }
        public string B3241_YeuToDanhGiaKetQua { get; set; }
        public string B3242_CacBienChungDieuTri { get; set; }
        public string B3243_CacBienChungVeSanKhoa { get; set; }
        public string B325_PhuongPhapPhanTich { get; set; }
        public string B326_JSON_CacBienSoCanThuThap { get; set; }
        public string B327_BangKetQuaDuKien { get; set; }
        public string B328_VanDeYDuc { get; set; }
        public string B329_TinhKhaThi { get; set; }
        public string B33_PhuongAnPhoiHop { get; set; }
        public string B33_PhuongAnPhoiHopPTN { get; set; }
        public string B33_PhuongAnPhoiHopDonVi { get; set; }
        public string B33_PhuongAnPhoiHopCGCN { get; set; }
        public string B4_KetQuaNghienCuu { get; set; }
        public string B41_AnPhamKhoaHoc { get; set; }
        public string B42_DangKySoHuuTriTue { get; set; }
        public string B43_KetQuaDaoTao { get; set; }
        public string B5_KhaNangUngDung { get; set; }
        public string B51_KhaNangUngDungLinhVucDaoTao { get; set; }
        public string B52_TongHopKinhPhi { get; set; }
        public string B52_JSON_TongHopKinhPhi { get; set; }
        public string PhuLuc_JSON_KhoanCongLaoDong { get; set; }
        public string PhuLuc_JSON_NguyenVatLieu { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string PhuLuc_JSON_ThietBi { get; set; }
        public string PhuLuc_JSON_ChiKhac { get; set; }
        public string A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai { get; set; }
        public string B52_CoQuanChuTri_NgayKy_Ngay { get; set; }
        public string B52_CoQuanChuTri_NgayKy_Thang { get; set; }
        public string B52_CoQuanChuTri_NgayKy_Nam { get; set; }
        public string B52_CoQuanChuTri_NgayKy_ChuKy { get; set; }
        public string B52_CNDT_NgayKy_Ngay { get; set; }
        public string B52_CNDT_NgayKy_Thang { get; set; }
        public string B52_CNDT_NgayKy_Nam { get; set; }
        public string B52_CNDT_NgayKy_ChuKy { get; set; }
        public string FormConfig { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_ThuyetMinhDeTai
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string A1_TenTiengViet { get; set; }
		public string A1_TenTiengAnh { get; set; }
		public bool A2_QuanLy { get; set; }
		public bool A2_SinhHocVaCongNghe { get; set; }
		public bool A2_KhoaHocSucKhoe { get; set; }
		public bool A2_Khac { get; set; }
		public string A2_KhacMoTa { get; set; }
		public bool A3_NghienCuuCoBan { get; set; }
		public bool A3_NghienCuuUngDung { get; set; }
		public bool A3_NghienCuuTrienKhai { get; set; }
		public string A4_ThoiGianThucHien { get; set; }
		public string A5_TongKinhPhi { get; set; }
		public string A6_HoTen { get; set; }
		public string A6_NgaySinh { get; set; }
		public string A6_GioiTinh { get; set; }
		public string A6_CMND { get; set; }
		public string A6_NgayCap { get; set; }
		public string A6_NoiCap { get; set; }
		public string A6_MST { get; set; }
		public string A6_STK { get; set; }
		public string A6_NganHang { get; set; }
		public string A6_DiaChiCoQuan { get; set; }
		public string A6_DienThoai { get; set; }
		public string A6_Email { get; set; }
		public string A6_TomTatHoatDong { get; set; }
		public string A7_TenCoQuan { get; set; }
		public string A7_HoTenThuTruong { get; set; }
		public string A7_DienThoai { get; set; }
		public string A7_DiaChi { get; set; }
		public string A8_CoQuanPhoiHopThucHien { get; set; }
		public string A9_JSON_NhanLucNghienCuu { get; set; }
		public string B1_GioiThieu { get; set; }
		public string B2_TaiLieuThamKhao { get; set; }
		public string B2_JSON_GioiThieuChuyenGia { get; set; }
		public string B311_MucTieuNghienCuu { get; set; }
		public string B312_ChiTieuDanhGia { get; set; }
		public string B313_DiaChi { get; set; }
		public string B313_JSON_KeHoachThucHien { get; set; }
		public string B321_ThietKeNghienCuu { get; set; }
		public string B322_DanSoNghienCuu { get; set; }
		public string B3221_TieuChuanNhanLoai { get; set; }
		public string B3222_CoMau { get; set; }
		public string B323_PhuongPhapTienHanh { get; set; }
		public string B324_PhuongPhapDanhGia { get; set; }
		public string B3241_YeuToDanhGiaKetQua { get; set; }
		public string B3242_CacBienChungDieuTri { get; set; }
		public string B3243_CacBienChungVeSanKhoa { get; set; }
		public string B325_PhuongPhapPhanTich { get; set; }
		public string B326_JSON_CacBienSoCanThuThap { get; set; }
		public string B327_BangKetQuaDuKien { get; set; }
		public string B328_VanDeYDuc { get; set; }
		public string B329_TinhKhaThi { get; set; }
		public string B33_PhuongAnPhoiHop { get; set; }
		public string B33_PhuongAnPhoiHopPTN { get; set; }
		public string B33_PhuongAnPhoiHopDonVi { get; set; }
		public string B33_PhuongAnPhoiHopCGCN { get; set; }
		public string B4_KetQuaNghienCuu { get; set; }
		public string B41_AnPhamKhoaHoc { get; set; }
		public string B42_DangKySoHuuTriTue { get; set; }
		public string B43_KetQuaDaoTao { get; set; }
		public string B5_KhaNangUngDung { get; set; }
		public string B51_KhaNangUngDungLinhVucDaoTao { get; set; }
		public string B52_TongHopKinhPhi { get; set; }
		public string B52_JSON_TongHopKinhPhi { get; set; }
		public string PhuLuc_JSON_KhoanCongLaoDong { get; set; }
		public string PhuLuc_JSON_NguyenVatLieu { get; set; }
		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public string PhuLuc_JSON_ThietBi { get; set; }
		public string PhuLuc_JSON_ChiKhac { get; set; }
		public string A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai { get; set; }
		public string B52_CoQuanChuTri_NgayKy_Ngay { get; set; }
		public string B52_CoQuanChuTri_NgayKy_Thang { get; set; }
		public string B52_CoQuanChuTri_NgayKy_Nam { get; set; }
		public string B52_CoQuanChuTri_NgayKy_ChuKy { get; set; }
		public string B52_CNDT_NgayKy_Ngay { get; set; }
		public string B52_CNDT_NgayKy_Thang { get; set; }
		public string B52_CNDT_NgayKy_Nam { get; set; }
		public string B52_CNDT_NgayKy_ChuKy { get; set; }
		public string FormConfig { get; set; }
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

    public static partial class BS_PRO_ThuyetMinhDeTai 
    {
		public static IQueryable<DTO_PRO_ThuyetMinhDeTai> toDTO(IQueryable<tbl_PRO_ThuyetMinhDeTai> query)
        {
			return query
			.Select(s => new DTO_PRO_ThuyetMinhDeTai(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				A1_TenTiengViet = s.A1_TenTiengViet,							
				A1_TenTiengAnh = s.A1_TenTiengAnh,							
				A2_QuanLy = s.A2_QuanLy,							
				A2_SinhHocVaCongNghe = s.A2_SinhHocVaCongNghe,							
				A2_KhoaHocSucKhoe = s.A2_KhoaHocSucKhoe,							
				A2_Khac = s.A2_Khac,							
				A2_KhacMoTa = s.A2_KhacMoTa,							
				A3_NghienCuuCoBan = s.A3_NghienCuuCoBan,							
				A3_NghienCuuUngDung = s.A3_NghienCuuUngDung,							
				A3_NghienCuuTrienKhai = s.A3_NghienCuuTrienKhai,							
				A4_ThoiGianThucHien = s.A4_ThoiGianThucHien,							
				A5_TongKinhPhi = s.A5_TongKinhPhi,							
				A6_HoTen = s.A6_HoTen,							
				A6_NgaySinh = s.A6_NgaySinh,							
				A6_GioiTinh = s.A6_GioiTinh,							
				A6_CMND = s.A6_CMND,							
				A6_NgayCap = s.A6_NgayCap,							
				A6_NoiCap = s.A6_NoiCap,							
				A6_MST = s.A6_MST,							
				A6_STK = s.A6_STK,							
				A6_NganHang = s.A6_NganHang,							
				A6_DiaChiCoQuan = s.A6_DiaChiCoQuan,							
				A6_DienThoai = s.A6_DienThoai,							
				A6_Email = s.A6_Email,							
				A6_TomTatHoatDong = s.A6_TomTatHoatDong,							
				A7_TenCoQuan = s.A7_TenCoQuan,							
				A7_HoTenThuTruong = s.A7_HoTenThuTruong,							
				A7_DienThoai = s.A7_DienThoai,							
				A7_DiaChi = s.A7_DiaChi,							
				A8_CoQuanPhoiHopThucHien = s.A8_CoQuanPhoiHopThucHien,							
				A9_JSON_NhanLucNghienCuu = s.A9_JSON_NhanLucNghienCuu,							
				B1_GioiThieu = s.B1_GioiThieu,							
				B2_TaiLieuThamKhao = s.B2_TaiLieuThamKhao,							
				B2_JSON_GioiThieuChuyenGia = s.B2_JSON_GioiThieuChuyenGia,							
				B311_MucTieuNghienCuu = s.B311_MucTieuNghienCuu,							
				B312_ChiTieuDanhGia = s.B312_ChiTieuDanhGia,							
				B313_DiaChi = s.B313_DiaChi,							
				B313_JSON_KeHoachThucHien = s.B313_JSON_KeHoachThucHien,							
				B321_ThietKeNghienCuu = s.B321_ThietKeNghienCuu,							
				B322_DanSoNghienCuu = s.B322_DanSoNghienCuu,							
				B3221_TieuChuanNhanLoai = s.B3221_TieuChuanNhanLoai,							
				B3222_CoMau = s.B3222_CoMau,							
				B323_PhuongPhapTienHanh = s.B323_PhuongPhapTienHanh,							
				B324_PhuongPhapDanhGia = s.B324_PhuongPhapDanhGia,							
				B3241_YeuToDanhGiaKetQua = s.B3241_YeuToDanhGiaKetQua,							
				B3242_CacBienChungDieuTri = s.B3242_CacBienChungDieuTri,							
				B3243_CacBienChungVeSanKhoa = s.B3243_CacBienChungVeSanKhoa,							
				B325_PhuongPhapPhanTich = s.B325_PhuongPhapPhanTich,							
				B326_JSON_CacBienSoCanThuThap = s.B326_JSON_CacBienSoCanThuThap,							
				B327_BangKetQuaDuKien = s.B327_BangKetQuaDuKien,							
				B328_VanDeYDuc = s.B328_VanDeYDuc,							
				B329_TinhKhaThi = s.B329_TinhKhaThi,							
				B33_PhuongAnPhoiHop = s.B33_PhuongAnPhoiHop,							
				B33_PhuongAnPhoiHopPTN = s.B33_PhuongAnPhoiHopPTN,							
				B33_PhuongAnPhoiHopDonVi = s.B33_PhuongAnPhoiHopDonVi,							
				B33_PhuongAnPhoiHopCGCN = s.B33_PhuongAnPhoiHopCGCN,							
				B4_KetQuaNghienCuu = s.B4_KetQuaNghienCuu,							
				B41_AnPhamKhoaHoc = s.B41_AnPhamKhoaHoc,							
				B42_DangKySoHuuTriTue = s.B42_DangKySoHuuTriTue,							
				B43_KetQuaDaoTao = s.B43_KetQuaDaoTao,							
				B5_KhaNangUngDung = s.B5_KhaNangUngDung,							
				B51_KhaNangUngDungLinhVucDaoTao = s.B51_KhaNangUngDungLinhVucDaoTao,							
				B52_TongHopKinhPhi = s.B52_TongHopKinhPhi,							
				B52_JSON_TongHopKinhPhi = s.B52_JSON_TongHopKinhPhi,							
				PhuLuc_JSON_KhoanCongLaoDong = s.PhuLuc_JSON_KhoanCongLaoDong,							
				PhuLuc_JSON_NguyenVatLieu = s.PhuLuc_JSON_NguyenVatLieu,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				PhuLuc_JSON_ThietBi = s.PhuLuc_JSON_ThietBi,							
				PhuLuc_JSON_ChiKhac = s.PhuLuc_JSON_ChiKhac,							
				A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai = s.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai,							
				B52_CoQuanChuTri_NgayKy_Ngay = s.B52_CoQuanChuTri_NgayKy_Ngay,							
				B52_CoQuanChuTri_NgayKy_Thang = s.B52_CoQuanChuTri_NgayKy_Thang,							
				B52_CoQuanChuTri_NgayKy_Nam = s.B52_CoQuanChuTri_NgayKy_Nam,							
				B52_CoQuanChuTri_NgayKy_ChuKy = s.B52_CoQuanChuTri_NgayKy_ChuKy,							
				B52_CNDT_NgayKy_Ngay = s.B52_CNDT_NgayKy_Ngay,							
				B52_CNDT_NgayKy_Thang = s.B52_CNDT_NgayKy_Thang,							
				B52_CNDT_NgayKy_Nam = s.B52_CNDT_NgayKy_Nam,							
				B52_CNDT_NgayKy_ChuKy = s.B52_CNDT_NgayKy_ChuKy,							
				FormConfig = s.FormConfig,					
			});
                              
        }

		public static DTO_PRO_ThuyetMinhDeTai toDTO(tbl_PRO_ThuyetMinhDeTai dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_ThuyetMinhDeTai()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					A1_TenTiengViet = dbResult.A1_TenTiengViet,							
					A1_TenTiengAnh = dbResult.A1_TenTiengAnh,							
					A2_QuanLy = dbResult.A2_QuanLy,							
					A2_SinhHocVaCongNghe = dbResult.A2_SinhHocVaCongNghe,							
					A2_KhoaHocSucKhoe = dbResult.A2_KhoaHocSucKhoe,							
					A2_Khac = dbResult.A2_Khac,							
					A2_KhacMoTa = dbResult.A2_KhacMoTa,							
					A3_NghienCuuCoBan = dbResult.A3_NghienCuuCoBan,							
					A3_NghienCuuUngDung = dbResult.A3_NghienCuuUngDung,							
					A3_NghienCuuTrienKhai = dbResult.A3_NghienCuuTrienKhai,							
					A4_ThoiGianThucHien = dbResult.A4_ThoiGianThucHien,							
					A5_TongKinhPhi = dbResult.A5_TongKinhPhi,							
					A6_HoTen = dbResult.A6_HoTen,							
					A6_NgaySinh = dbResult.A6_NgaySinh,							
					A6_GioiTinh = dbResult.A6_GioiTinh,							
					A6_CMND = dbResult.A6_CMND,							
					A6_NgayCap = dbResult.A6_NgayCap,							
					A6_NoiCap = dbResult.A6_NoiCap,							
					A6_MST = dbResult.A6_MST,							
					A6_STK = dbResult.A6_STK,							
					A6_NganHang = dbResult.A6_NganHang,							
					A6_DiaChiCoQuan = dbResult.A6_DiaChiCoQuan,							
					A6_DienThoai = dbResult.A6_DienThoai,							
					A6_Email = dbResult.A6_Email,							
					A6_TomTatHoatDong = dbResult.A6_TomTatHoatDong,							
					A7_TenCoQuan = dbResult.A7_TenCoQuan,							
					A7_HoTenThuTruong = dbResult.A7_HoTenThuTruong,							
					A7_DienThoai = dbResult.A7_DienThoai,							
					A7_DiaChi = dbResult.A7_DiaChi,							
					A8_CoQuanPhoiHopThucHien = dbResult.A8_CoQuanPhoiHopThucHien,							
					A9_JSON_NhanLucNghienCuu = dbResult.A9_JSON_NhanLucNghienCuu,							
					B1_GioiThieu = dbResult.B1_GioiThieu,							
					B2_TaiLieuThamKhao = dbResult.B2_TaiLieuThamKhao,							
					B2_JSON_GioiThieuChuyenGia = dbResult.B2_JSON_GioiThieuChuyenGia,							
					B311_MucTieuNghienCuu = dbResult.B311_MucTieuNghienCuu,							
					B312_ChiTieuDanhGia = dbResult.B312_ChiTieuDanhGia,							
					B313_DiaChi = dbResult.B313_DiaChi,							
					B313_JSON_KeHoachThucHien = dbResult.B313_JSON_KeHoachThucHien,							
					B321_ThietKeNghienCuu = dbResult.B321_ThietKeNghienCuu,							
					B322_DanSoNghienCuu = dbResult.B322_DanSoNghienCuu,							
					B3221_TieuChuanNhanLoai = dbResult.B3221_TieuChuanNhanLoai,							
					B3222_CoMau = dbResult.B3222_CoMau,							
					B323_PhuongPhapTienHanh = dbResult.B323_PhuongPhapTienHanh,							
					B324_PhuongPhapDanhGia = dbResult.B324_PhuongPhapDanhGia,							
					B3241_YeuToDanhGiaKetQua = dbResult.B3241_YeuToDanhGiaKetQua,							
					B3242_CacBienChungDieuTri = dbResult.B3242_CacBienChungDieuTri,							
					B3243_CacBienChungVeSanKhoa = dbResult.B3243_CacBienChungVeSanKhoa,							
					B325_PhuongPhapPhanTich = dbResult.B325_PhuongPhapPhanTich,							
					B326_JSON_CacBienSoCanThuThap = dbResult.B326_JSON_CacBienSoCanThuThap,							
					B327_BangKetQuaDuKien = dbResult.B327_BangKetQuaDuKien,							
					B328_VanDeYDuc = dbResult.B328_VanDeYDuc,							
					B329_TinhKhaThi = dbResult.B329_TinhKhaThi,							
					B33_PhuongAnPhoiHop = dbResult.B33_PhuongAnPhoiHop,							
					B33_PhuongAnPhoiHopPTN = dbResult.B33_PhuongAnPhoiHopPTN,							
					B33_PhuongAnPhoiHopDonVi = dbResult.B33_PhuongAnPhoiHopDonVi,							
					B33_PhuongAnPhoiHopCGCN = dbResult.B33_PhuongAnPhoiHopCGCN,							
					B4_KetQuaNghienCuu = dbResult.B4_KetQuaNghienCuu,							
					B41_AnPhamKhoaHoc = dbResult.B41_AnPhamKhoaHoc,							
					B42_DangKySoHuuTriTue = dbResult.B42_DangKySoHuuTriTue,							
					B43_KetQuaDaoTao = dbResult.B43_KetQuaDaoTao,							
					B5_KhaNangUngDung = dbResult.B5_KhaNangUngDung,							
					B51_KhaNangUngDungLinhVucDaoTao = dbResult.B51_KhaNangUngDungLinhVucDaoTao,							
					B52_TongHopKinhPhi = dbResult.B52_TongHopKinhPhi,							
					B52_JSON_TongHopKinhPhi = dbResult.B52_JSON_TongHopKinhPhi,							
					PhuLuc_JSON_KhoanCongLaoDong = dbResult.PhuLuc_JSON_KhoanCongLaoDong,							
					PhuLuc_JSON_NguyenVatLieu = dbResult.PhuLuc_JSON_NguyenVatLieu,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					PhuLuc_JSON_ThietBi = dbResult.PhuLuc_JSON_ThietBi,							
					PhuLuc_JSON_ChiKhac = dbResult.PhuLuc_JSON_ChiKhac,							
					A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai = dbResult.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai,							
					B52_CoQuanChuTri_NgayKy_Ngay = dbResult.B52_CoQuanChuTri_NgayKy_Ngay,							
					B52_CoQuanChuTri_NgayKy_Thang = dbResult.B52_CoQuanChuTri_NgayKy_Thang,							
					B52_CoQuanChuTri_NgayKy_Nam = dbResult.B52_CoQuanChuTri_NgayKy_Nam,							
					B52_CoQuanChuTri_NgayKy_ChuKy = dbResult.B52_CoQuanChuTri_NgayKy_ChuKy,							
					B52_CNDT_NgayKy_Ngay = dbResult.B52_CNDT_NgayKy_Ngay,							
					B52_CNDT_NgayKy_Thang = dbResult.B52_CNDT_NgayKy_Thang,							
					B52_CNDT_NgayKy_Nam = dbResult.B52_CNDT_NgayKy_Nam,							
					B52_CNDT_NgayKy_ChuKy = dbResult.B52_CNDT_NgayKy_ChuKy,							
					FormConfig = dbResult.FormConfig,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_ThuyetMinhDeTai> get_PRO_ThuyetMinhDeTai(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_ThuyetMinhDeTai.Where(d => d.IsDeleted == false );

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

			//Query A1_TenTiengViet (string)
			if (QueryStrings.Any(d => d.Key == "A1_TenTiengViet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A1_TenTiengViet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A1_TenTiengViet").Value;
                query = query.Where(d=>d.A1_TenTiengViet == keyword);
            }

			//Query A1_TenTiengAnh (string)
			if (QueryStrings.Any(d => d.Key == "A1_TenTiengAnh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A1_TenTiengAnh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A1_TenTiengAnh").Value;
                query = query.Where(d=>d.A1_TenTiengAnh == keyword);
            }

			//Query A2_QuanLy (bool)
			if (QueryStrings.Any(d => d.Key == "A2_QuanLy"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "A2_QuanLy").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.A2_QuanLy);
            }

			//Query A2_SinhHocVaCongNghe (bool)
			if (QueryStrings.Any(d => d.Key == "A2_SinhHocVaCongNghe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "A2_SinhHocVaCongNghe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.A2_SinhHocVaCongNghe);
            }

			//Query A2_KhoaHocSucKhoe (bool)
			if (QueryStrings.Any(d => d.Key == "A2_KhoaHocSucKhoe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "A2_KhoaHocSucKhoe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.A2_KhoaHocSucKhoe);
            }

			//Query A2_Khac (bool)
			if (QueryStrings.Any(d => d.Key == "A2_Khac"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "A2_Khac").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.A2_Khac);
            }

			//Query A2_KhacMoTa (string)
			if (QueryStrings.Any(d => d.Key == "A2_KhacMoTa") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A2_KhacMoTa").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A2_KhacMoTa").Value;
                query = query.Where(d=>d.A2_KhacMoTa == keyword);
            }

			//Query A3_NghienCuuCoBan (bool)
			if (QueryStrings.Any(d => d.Key == "A3_NghienCuuCoBan"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "A3_NghienCuuCoBan").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.A3_NghienCuuCoBan);
            }

			//Query A3_NghienCuuUngDung (bool)
			if (QueryStrings.Any(d => d.Key == "A3_NghienCuuUngDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "A3_NghienCuuUngDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.A3_NghienCuuUngDung);
            }

			//Query A3_NghienCuuTrienKhai (bool)
			if (QueryStrings.Any(d => d.Key == "A3_NghienCuuTrienKhai"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "A3_NghienCuuTrienKhai").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.A3_NghienCuuTrienKhai);
            }

			//Query A4_ThoiGianThucHien (string)
			if (QueryStrings.Any(d => d.Key == "A4_ThoiGianThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A4_ThoiGianThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A4_ThoiGianThucHien").Value;
                query = query.Where(d=>d.A4_ThoiGianThucHien == keyword);
            }

			//Query A5_TongKinhPhi (string)
			if (QueryStrings.Any(d => d.Key == "A5_TongKinhPhi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A5_TongKinhPhi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A5_TongKinhPhi").Value;
                query = query.Where(d=>d.A5_TongKinhPhi == keyword);
            }

			//Query A6_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "A6_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_HoTen").Value;
                query = query.Where(d=>d.A6_HoTen == keyword);
            }

			//Query A6_NgaySinh (string)
			if (QueryStrings.Any(d => d.Key == "A6_NgaySinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_NgaySinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_NgaySinh").Value;
                query = query.Where(d=>d.A6_NgaySinh == keyword);
            }

			//Query A6_GioiTinh (string)
			if (QueryStrings.Any(d => d.Key == "A6_GioiTinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_GioiTinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_GioiTinh").Value;
                query = query.Where(d=>d.A6_GioiTinh == keyword);
            }

			//Query A6_CMND (string)
			if (QueryStrings.Any(d => d.Key == "A6_CMND") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_CMND").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_CMND").Value;
                query = query.Where(d=>d.A6_CMND == keyword);
            }

			//Query A6_NgayCap (string)
			if (QueryStrings.Any(d => d.Key == "A6_NgayCap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_NgayCap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_NgayCap").Value;
                query = query.Where(d=>d.A6_NgayCap == keyword);
            }

			//Query A6_NoiCap (string)
			if (QueryStrings.Any(d => d.Key == "A6_NoiCap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_NoiCap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_NoiCap").Value;
                query = query.Where(d=>d.A6_NoiCap == keyword);
            }

			//Query A6_MST (string)
			if (QueryStrings.Any(d => d.Key == "A6_MST") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_MST").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_MST").Value;
                query = query.Where(d=>d.A6_MST == keyword);
            }

			//Query A6_STK (string)
			if (QueryStrings.Any(d => d.Key == "A6_STK") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_STK").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_STK").Value;
                query = query.Where(d=>d.A6_STK == keyword);
            }

			//Query A6_NganHang (string)
			if (QueryStrings.Any(d => d.Key == "A6_NganHang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_NganHang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_NganHang").Value;
                query = query.Where(d=>d.A6_NganHang == keyword);
            }

			//Query A6_DiaChiCoQuan (string)
			if (QueryStrings.Any(d => d.Key == "A6_DiaChiCoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_DiaChiCoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_DiaChiCoQuan").Value;
                query = query.Where(d=>d.A6_DiaChiCoQuan == keyword);
            }

			//Query A6_DienThoai (string)
			if (QueryStrings.Any(d => d.Key == "A6_DienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_DienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_DienThoai").Value;
                query = query.Where(d=>d.A6_DienThoai == keyword);
            }

			//Query A6_Email (string)
			if (QueryStrings.Any(d => d.Key == "A6_Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_Email").Value;
                query = query.Where(d=>d.A6_Email == keyword);
            }

			//Query A6_TomTatHoatDong (string)
			if (QueryStrings.Any(d => d.Key == "A6_TomTatHoatDong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A6_TomTatHoatDong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A6_TomTatHoatDong").Value;
                query = query.Where(d=>d.A6_TomTatHoatDong == keyword);
            }

			//Query A7_TenCoQuan (string)
			if (QueryStrings.Any(d => d.Key == "A7_TenCoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A7_TenCoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A7_TenCoQuan").Value;
                query = query.Where(d=>d.A7_TenCoQuan == keyword);
            }

			//Query A7_HoTenThuTruong (string)
			if (QueryStrings.Any(d => d.Key == "A7_HoTenThuTruong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A7_HoTenThuTruong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A7_HoTenThuTruong").Value;
                query = query.Where(d=>d.A7_HoTenThuTruong == keyword);
            }

			//Query A7_DienThoai (string)
			if (QueryStrings.Any(d => d.Key == "A7_DienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A7_DienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A7_DienThoai").Value;
                query = query.Where(d=>d.A7_DienThoai == keyword);
            }

			//Query A7_DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "A7_DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A7_DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A7_DiaChi").Value;
                query = query.Where(d=>d.A7_DiaChi == keyword);
            }

			//Query A8_CoQuanPhoiHopThucHien (string)
			if (QueryStrings.Any(d => d.Key == "A8_CoQuanPhoiHopThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A8_CoQuanPhoiHopThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A8_CoQuanPhoiHopThucHien").Value;
                query = query.Where(d=>d.A8_CoQuanPhoiHopThucHien == keyword);
            }

			//Query A9_JSON_NhanLucNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "A9_JSON_NhanLucNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A9_JSON_NhanLucNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A9_JSON_NhanLucNghienCuu").Value;
                query = query.Where(d=>d.A9_JSON_NhanLucNghienCuu == keyword);
            }

			//Query B1_GioiThieu (string)
			if (QueryStrings.Any(d => d.Key == "B1_GioiThieu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B1_GioiThieu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B1_GioiThieu").Value;
                query = query.Where(d=>d.B1_GioiThieu == keyword);
            }

			//Query B2_TaiLieuThamKhao (string)
			if (QueryStrings.Any(d => d.Key == "B2_TaiLieuThamKhao") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B2_TaiLieuThamKhao").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B2_TaiLieuThamKhao").Value;
                query = query.Where(d=>d.B2_TaiLieuThamKhao == keyword);
            }

			//Query B2_JSON_GioiThieuChuyenGia (string)
			if (QueryStrings.Any(d => d.Key == "B2_JSON_GioiThieuChuyenGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B2_JSON_GioiThieuChuyenGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B2_JSON_GioiThieuChuyenGia").Value;
                query = query.Where(d=>d.B2_JSON_GioiThieuChuyenGia == keyword);
            }

			//Query B311_MucTieuNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "B311_MucTieuNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B311_MucTieuNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B311_MucTieuNghienCuu").Value;
                query = query.Where(d=>d.B311_MucTieuNghienCuu == keyword);
            }

			//Query B312_ChiTieuDanhGia (string)
			if (QueryStrings.Any(d => d.Key == "B312_ChiTieuDanhGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B312_ChiTieuDanhGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B312_ChiTieuDanhGia").Value;
                query = query.Where(d=>d.B312_ChiTieuDanhGia == keyword);
            }

			//Query B313_DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "B313_DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B313_DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B313_DiaChi").Value;
                query = query.Where(d=>d.B313_DiaChi == keyword);
            }

			//Query B313_JSON_KeHoachThucHien (string)
			if (QueryStrings.Any(d => d.Key == "B313_JSON_KeHoachThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B313_JSON_KeHoachThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B313_JSON_KeHoachThucHien").Value;
                query = query.Where(d=>d.B313_JSON_KeHoachThucHien == keyword);
            }

			//Query B321_ThietKeNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "B321_ThietKeNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B321_ThietKeNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B321_ThietKeNghienCuu").Value;
                query = query.Where(d=>d.B321_ThietKeNghienCuu == keyword);
            }

			//Query B322_DanSoNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "B322_DanSoNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B322_DanSoNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B322_DanSoNghienCuu").Value;
                query = query.Where(d=>d.B322_DanSoNghienCuu == keyword);
            }

			//Query B3221_TieuChuanNhanLoai (string)
			if (QueryStrings.Any(d => d.Key == "B3221_TieuChuanNhanLoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B3221_TieuChuanNhanLoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B3221_TieuChuanNhanLoai").Value;
                query = query.Where(d=>d.B3221_TieuChuanNhanLoai == keyword);
            }

			//Query B3222_CoMau (string)
			if (QueryStrings.Any(d => d.Key == "B3222_CoMau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B3222_CoMau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B3222_CoMau").Value;
                query = query.Where(d=>d.B3222_CoMau == keyword);
            }

			//Query B323_PhuongPhapTienHanh (string)
			if (QueryStrings.Any(d => d.Key == "B323_PhuongPhapTienHanh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B323_PhuongPhapTienHanh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B323_PhuongPhapTienHanh").Value;
                query = query.Where(d=>d.B323_PhuongPhapTienHanh == keyword);
            }

			//Query B324_PhuongPhapDanhGia (string)
			if (QueryStrings.Any(d => d.Key == "B324_PhuongPhapDanhGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B324_PhuongPhapDanhGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B324_PhuongPhapDanhGia").Value;
                query = query.Where(d=>d.B324_PhuongPhapDanhGia == keyword);
            }

			//Query B3241_YeuToDanhGiaKetQua (string)
			if (QueryStrings.Any(d => d.Key == "B3241_YeuToDanhGiaKetQua") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B3241_YeuToDanhGiaKetQua").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B3241_YeuToDanhGiaKetQua").Value;
                query = query.Where(d=>d.B3241_YeuToDanhGiaKetQua == keyword);
            }

			//Query B3242_CacBienChungDieuTri (string)
			if (QueryStrings.Any(d => d.Key == "B3242_CacBienChungDieuTri") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B3242_CacBienChungDieuTri").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B3242_CacBienChungDieuTri").Value;
                query = query.Where(d=>d.B3242_CacBienChungDieuTri == keyword);
            }

			//Query B3243_CacBienChungVeSanKhoa (string)
			if (QueryStrings.Any(d => d.Key == "B3243_CacBienChungVeSanKhoa") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B3243_CacBienChungVeSanKhoa").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B3243_CacBienChungVeSanKhoa").Value;
                query = query.Where(d=>d.B3243_CacBienChungVeSanKhoa == keyword);
            }

			//Query B325_PhuongPhapPhanTich (string)
			if (QueryStrings.Any(d => d.Key == "B325_PhuongPhapPhanTich") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B325_PhuongPhapPhanTich").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B325_PhuongPhapPhanTich").Value;
                query = query.Where(d=>d.B325_PhuongPhapPhanTich == keyword);
            }

			//Query B326_JSON_CacBienSoCanThuThap (string)
			if (QueryStrings.Any(d => d.Key == "B326_JSON_CacBienSoCanThuThap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B326_JSON_CacBienSoCanThuThap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B326_JSON_CacBienSoCanThuThap").Value;
                query = query.Where(d=>d.B326_JSON_CacBienSoCanThuThap == keyword);
            }

			//Query B327_BangKetQuaDuKien (string)
			if (QueryStrings.Any(d => d.Key == "B327_BangKetQuaDuKien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B327_BangKetQuaDuKien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B327_BangKetQuaDuKien").Value;
                query = query.Where(d=>d.B327_BangKetQuaDuKien == keyword);
            }

			//Query B328_VanDeYDuc (string)
			if (QueryStrings.Any(d => d.Key == "B328_VanDeYDuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B328_VanDeYDuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B328_VanDeYDuc").Value;
                query = query.Where(d=>d.B328_VanDeYDuc == keyword);
            }

			//Query B329_TinhKhaThi (string)
			if (QueryStrings.Any(d => d.Key == "B329_TinhKhaThi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B329_TinhKhaThi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B329_TinhKhaThi").Value;
                query = query.Where(d=>d.B329_TinhKhaThi == keyword);
            }

			//Query B33_PhuongAnPhoiHop (string)
			if (QueryStrings.Any(d => d.Key == "B33_PhuongAnPhoiHop") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHop").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHop").Value;
                query = query.Where(d=>d.B33_PhuongAnPhoiHop == keyword);
            }

			//Query B33_PhuongAnPhoiHopPTN (string)
			if (QueryStrings.Any(d => d.Key == "B33_PhuongAnPhoiHopPTN") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHopPTN").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHopPTN").Value;
                query = query.Where(d=>d.B33_PhuongAnPhoiHopPTN == keyword);
            }

			//Query B33_PhuongAnPhoiHopDonVi (string)
			if (QueryStrings.Any(d => d.Key == "B33_PhuongAnPhoiHopDonVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHopDonVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHopDonVi").Value;
                query = query.Where(d=>d.B33_PhuongAnPhoiHopDonVi == keyword);
            }

			//Query B33_PhuongAnPhoiHopCGCN (string)
			if (QueryStrings.Any(d => d.Key == "B33_PhuongAnPhoiHopCGCN") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHopCGCN").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B33_PhuongAnPhoiHopCGCN").Value;
                query = query.Where(d=>d.B33_PhuongAnPhoiHopCGCN == keyword);
            }

			//Query B4_KetQuaNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "B4_KetQuaNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B4_KetQuaNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B4_KetQuaNghienCuu").Value;
                query = query.Where(d=>d.B4_KetQuaNghienCuu == keyword);
            }

			//Query B41_AnPhamKhoaHoc (string)
			if (QueryStrings.Any(d => d.Key == "B41_AnPhamKhoaHoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B41_AnPhamKhoaHoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B41_AnPhamKhoaHoc").Value;
                query = query.Where(d=>d.B41_AnPhamKhoaHoc == keyword);
            }

			//Query B42_DangKySoHuuTriTue (string)
			if (QueryStrings.Any(d => d.Key == "B42_DangKySoHuuTriTue") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B42_DangKySoHuuTriTue").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B42_DangKySoHuuTriTue").Value;
                query = query.Where(d=>d.B42_DangKySoHuuTriTue == keyword);
            }

			//Query B43_KetQuaDaoTao (string)
			if (QueryStrings.Any(d => d.Key == "B43_KetQuaDaoTao") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B43_KetQuaDaoTao").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B43_KetQuaDaoTao").Value;
                query = query.Where(d=>d.B43_KetQuaDaoTao == keyword);
            }

			//Query B5_KhaNangUngDung (string)
			if (QueryStrings.Any(d => d.Key == "B5_KhaNangUngDung") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B5_KhaNangUngDung").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B5_KhaNangUngDung").Value;
                query = query.Where(d=>d.B5_KhaNangUngDung == keyword);
            }

			//Query B51_KhaNangUngDungLinhVucDaoTao (string)
			if (QueryStrings.Any(d => d.Key == "B51_KhaNangUngDungLinhVucDaoTao") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B51_KhaNangUngDungLinhVucDaoTao").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B51_KhaNangUngDungLinhVucDaoTao").Value;
                query = query.Where(d=>d.B51_KhaNangUngDungLinhVucDaoTao == keyword);
            }

			//Query B52_TongHopKinhPhi (string)
			if (QueryStrings.Any(d => d.Key == "B52_TongHopKinhPhi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_TongHopKinhPhi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_TongHopKinhPhi").Value;
                query = query.Where(d=>d.B52_TongHopKinhPhi == keyword);
            }

			//Query B52_JSON_TongHopKinhPhi (string)
			if (QueryStrings.Any(d => d.Key == "B52_JSON_TongHopKinhPhi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_JSON_TongHopKinhPhi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_JSON_TongHopKinhPhi").Value;
                query = query.Where(d=>d.B52_JSON_TongHopKinhPhi == keyword);
            }

			//Query PhuLuc_JSON_KhoanCongLaoDong (string)
			if (QueryStrings.Any(d => d.Key == "PhuLuc_JSON_KhoanCongLaoDong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_KhoanCongLaoDong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_KhoanCongLaoDong").Value;
                query = query.Where(d=>d.PhuLuc_JSON_KhoanCongLaoDong == keyword);
            }

			//Query PhuLuc_JSON_NguyenVatLieu (string)
			if (QueryStrings.Any(d => d.Key == "PhuLuc_JSON_NguyenVatLieu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_NguyenVatLieu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_NguyenVatLieu").Value;
                query = query.Where(d=>d.PhuLuc_JSON_NguyenVatLieu == keyword);
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

			//Query PhuLuc_JSON_ThietBi (string)
			if (QueryStrings.Any(d => d.Key == "PhuLuc_JSON_ThietBi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_ThietBi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_ThietBi").Value;
                query = query.Where(d=>d.PhuLuc_JSON_ThietBi == keyword);
            }

			//Query PhuLuc_JSON_ChiKhac (string)
			if (QueryStrings.Any(d => d.Key == "PhuLuc_JSON_ChiKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_ChiKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhuLuc_JSON_ChiKhac").Value;
                query = query.Where(d=>d.PhuLuc_JSON_ChiKhac == keyword);
            }

			//Query A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai (string)
			if (QueryStrings.Any(d => d.Key == "A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai").Value;
                query = query.Where(d=>d.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai == keyword);
            }

			//Query B52_CoQuanChuTri_NgayKy_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "B52_CoQuanChuTri_NgayKy_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_Ngay").Value;
                query = query.Where(d=>d.B52_CoQuanChuTri_NgayKy_Ngay == keyword);
            }

			//Query B52_CoQuanChuTri_NgayKy_Thang (string)
			if (QueryStrings.Any(d => d.Key == "B52_CoQuanChuTri_NgayKy_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_Thang").Value;
                query = query.Where(d=>d.B52_CoQuanChuTri_NgayKy_Thang == keyword);
            }

			//Query B52_CoQuanChuTri_NgayKy_Nam (string)
			if (QueryStrings.Any(d => d.Key == "B52_CoQuanChuTri_NgayKy_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_Nam").Value;
                query = query.Where(d=>d.B52_CoQuanChuTri_NgayKy_Nam == keyword);
            }

			//Query B52_CoQuanChuTri_NgayKy_ChuKy (string)
			if (QueryStrings.Any(d => d.Key == "B52_CoQuanChuTri_NgayKy_ChuKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_ChuKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CoQuanChuTri_NgayKy_ChuKy").Value;
                query = query.Where(d=>d.B52_CoQuanChuTri_NgayKy_ChuKy == keyword);
            }

			//Query B52_CNDT_NgayKy_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "B52_CNDT_NgayKy_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_Ngay").Value;
                query = query.Where(d=>d.B52_CNDT_NgayKy_Ngay == keyword);
            }

			//Query B52_CNDT_NgayKy_Thang (string)
			if (QueryStrings.Any(d => d.Key == "B52_CNDT_NgayKy_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_Thang").Value;
                query = query.Where(d=>d.B52_CNDT_NgayKy_Thang == keyword);
            }

			//Query B52_CNDT_NgayKy_Nam (string)
			if (QueryStrings.Any(d => d.Key == "B52_CNDT_NgayKy_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_Nam").Value;
                query = query.Where(d=>d.B52_CNDT_NgayKy_Nam == keyword);
            }

			//Query B52_CNDT_NgayKy_ChuKy (string)
			if (QueryStrings.Any(d => d.Key == "B52_CNDT_NgayKy_ChuKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_ChuKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "B52_CNDT_NgayKy_ChuKy").Value;
                query = query.Where(d=>d.B52_CNDT_NgayKy_ChuKy == keyword);
            }

			//Query FormConfig (string)
			if (QueryStrings.Any(d => d.Key == "FormConfig") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value;
                query = query.Where(d=>d.FormConfig == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_ThuyetMinhDeTai get_PRO_ThuyetMinhDeTai(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_ThuyetMinhDeTai.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_ThuyetMinhDeTai(AppEntities db, int ID, DTO_PRO_ThuyetMinhDeTai item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_ThuyetMinhDeTai.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.A1_TenTiengViet = item.A1_TenTiengViet;							
				dbitem.A1_TenTiengAnh = item.A1_TenTiengAnh;							
				dbitem.A2_QuanLy = item.A2_QuanLy;							
				dbitem.A2_SinhHocVaCongNghe = item.A2_SinhHocVaCongNghe;							
				dbitem.A2_KhoaHocSucKhoe = item.A2_KhoaHocSucKhoe;							
				dbitem.A2_Khac = item.A2_Khac;							
				dbitem.A2_KhacMoTa = item.A2_KhacMoTa;							
				dbitem.A3_NghienCuuCoBan = item.A3_NghienCuuCoBan;							
				dbitem.A3_NghienCuuUngDung = item.A3_NghienCuuUngDung;							
				dbitem.A3_NghienCuuTrienKhai = item.A3_NghienCuuTrienKhai;							
				dbitem.A4_ThoiGianThucHien = item.A4_ThoiGianThucHien;							
				dbitem.A5_TongKinhPhi = item.A5_TongKinhPhi;							
				dbitem.A6_HoTen = item.A6_HoTen;							
				dbitem.A6_NgaySinh = item.A6_NgaySinh;							
				dbitem.A6_GioiTinh = item.A6_GioiTinh;							
				dbitem.A6_CMND = item.A6_CMND;							
				dbitem.A6_NgayCap = item.A6_NgayCap;							
				dbitem.A6_NoiCap = item.A6_NoiCap;							
				dbitem.A6_MST = item.A6_MST;							
				dbitem.A6_STK = item.A6_STK;							
				dbitem.A6_NganHang = item.A6_NganHang;							
				dbitem.A6_DiaChiCoQuan = item.A6_DiaChiCoQuan;							
				dbitem.A6_DienThoai = item.A6_DienThoai;							
				dbitem.A6_Email = item.A6_Email;							
				dbitem.A6_TomTatHoatDong = item.A6_TomTatHoatDong;							
				dbitem.A7_TenCoQuan = item.A7_TenCoQuan;							
				dbitem.A7_HoTenThuTruong = item.A7_HoTenThuTruong;							
				dbitem.A7_DienThoai = item.A7_DienThoai;							
				dbitem.A7_DiaChi = item.A7_DiaChi;							
				dbitem.A8_CoQuanPhoiHopThucHien = item.A8_CoQuanPhoiHopThucHien;							
				dbitem.A9_JSON_NhanLucNghienCuu = item.A9_JSON_NhanLucNghienCuu;							
				dbitem.B1_GioiThieu = item.B1_GioiThieu;							
				dbitem.B2_TaiLieuThamKhao = item.B2_TaiLieuThamKhao;							
				dbitem.B2_JSON_GioiThieuChuyenGia = item.B2_JSON_GioiThieuChuyenGia;							
				dbitem.B311_MucTieuNghienCuu = item.B311_MucTieuNghienCuu;							
				dbitem.B312_ChiTieuDanhGia = item.B312_ChiTieuDanhGia;							
				dbitem.B313_DiaChi = item.B313_DiaChi;							
				dbitem.B313_JSON_KeHoachThucHien = item.B313_JSON_KeHoachThucHien;							
				dbitem.B321_ThietKeNghienCuu = item.B321_ThietKeNghienCuu;							
				dbitem.B322_DanSoNghienCuu = item.B322_DanSoNghienCuu;							
				dbitem.B3221_TieuChuanNhanLoai = item.B3221_TieuChuanNhanLoai;							
				dbitem.B3222_CoMau = item.B3222_CoMau;							
				dbitem.B323_PhuongPhapTienHanh = item.B323_PhuongPhapTienHanh;							
				dbitem.B324_PhuongPhapDanhGia = item.B324_PhuongPhapDanhGia;							
				dbitem.B3241_YeuToDanhGiaKetQua = item.B3241_YeuToDanhGiaKetQua;							
				dbitem.B3242_CacBienChungDieuTri = item.B3242_CacBienChungDieuTri;							
				dbitem.B3243_CacBienChungVeSanKhoa = item.B3243_CacBienChungVeSanKhoa;							
				dbitem.B325_PhuongPhapPhanTich = item.B325_PhuongPhapPhanTich;							
				dbitem.B326_JSON_CacBienSoCanThuThap = item.B326_JSON_CacBienSoCanThuThap;							
				dbitem.B327_BangKetQuaDuKien = item.B327_BangKetQuaDuKien;							
				dbitem.B328_VanDeYDuc = item.B328_VanDeYDuc;							
				dbitem.B329_TinhKhaThi = item.B329_TinhKhaThi;							
				dbitem.B33_PhuongAnPhoiHop = item.B33_PhuongAnPhoiHop;							
				dbitem.B33_PhuongAnPhoiHopPTN = item.B33_PhuongAnPhoiHopPTN;							
				dbitem.B33_PhuongAnPhoiHopDonVi = item.B33_PhuongAnPhoiHopDonVi;							
				dbitem.B33_PhuongAnPhoiHopCGCN = item.B33_PhuongAnPhoiHopCGCN;							
				dbitem.B4_KetQuaNghienCuu = item.B4_KetQuaNghienCuu;							
				dbitem.B41_AnPhamKhoaHoc = item.B41_AnPhamKhoaHoc;							
				dbitem.B42_DangKySoHuuTriTue = item.B42_DangKySoHuuTriTue;							
				dbitem.B43_KetQuaDaoTao = item.B43_KetQuaDaoTao;							
				dbitem.B5_KhaNangUngDung = item.B5_KhaNangUngDung;							
				dbitem.B51_KhaNangUngDungLinhVucDaoTao = item.B51_KhaNangUngDungLinhVucDaoTao;							
				dbitem.B52_TongHopKinhPhi = item.B52_TongHopKinhPhi;							
				dbitem.B52_JSON_TongHopKinhPhi = item.B52_JSON_TongHopKinhPhi;							
				dbitem.PhuLuc_JSON_KhoanCongLaoDong = item.PhuLuc_JSON_KhoanCongLaoDong;							
				dbitem.PhuLuc_JSON_NguyenVatLieu = item.PhuLuc_JSON_NguyenVatLieu;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.PhuLuc_JSON_ThietBi = item.PhuLuc_JSON_ThietBi;							
				dbitem.PhuLuc_JSON_ChiKhac = item.PhuLuc_JSON_ChiKhac;							
				dbitem.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai = item.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai;							
				dbitem.B52_CoQuanChuTri_NgayKy_Ngay = item.B52_CoQuanChuTri_NgayKy_Ngay;							
				dbitem.B52_CoQuanChuTri_NgayKy_Thang = item.B52_CoQuanChuTri_NgayKy_Thang;							
				dbitem.B52_CoQuanChuTri_NgayKy_Nam = item.B52_CoQuanChuTri_NgayKy_Nam;							
				dbitem.B52_CoQuanChuTri_NgayKy_ChuKy = item.B52_CoQuanChuTri_NgayKy_ChuKy;							
				dbitem.B52_CNDT_NgayKy_Ngay = item.B52_CNDT_NgayKy_Ngay;							
				dbitem.B52_CNDT_NgayKy_Thang = item.B52_CNDT_NgayKy_Thang;							
				dbitem.B52_CNDT_NgayKy_Nam = item.B52_CNDT_NgayKy_Nam;							
				dbitem.B52_CNDT_NgayKy_ChuKy = item.B52_CNDT_NgayKy_ChuKy;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_ThuyetMinhDeTai", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_ThuyetMinhDeTai",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_ThuyetMinhDeTai post_PRO_ThuyetMinhDeTai(AppEntities db, DTO_PRO_ThuyetMinhDeTai item, string Username)
        {
            tbl_PRO_ThuyetMinhDeTai dbitem = new tbl_PRO_ThuyetMinhDeTai();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.A1_TenTiengViet = item.A1_TenTiengViet;							
				dbitem.A1_TenTiengAnh = item.A1_TenTiengAnh;							
				dbitem.A2_QuanLy = item.A2_QuanLy;							
				dbitem.A2_SinhHocVaCongNghe = item.A2_SinhHocVaCongNghe;							
				dbitem.A2_KhoaHocSucKhoe = item.A2_KhoaHocSucKhoe;							
				dbitem.A2_Khac = item.A2_Khac;							
				dbitem.A2_KhacMoTa = item.A2_KhacMoTa;							
				dbitem.A3_NghienCuuCoBan = item.A3_NghienCuuCoBan;							
				dbitem.A3_NghienCuuUngDung = item.A3_NghienCuuUngDung;							
				dbitem.A3_NghienCuuTrienKhai = item.A3_NghienCuuTrienKhai;							
				dbitem.A4_ThoiGianThucHien = item.A4_ThoiGianThucHien;							
				dbitem.A5_TongKinhPhi = item.A5_TongKinhPhi;							
				dbitem.A6_HoTen = item.A6_HoTen;							
				dbitem.A6_NgaySinh = item.A6_NgaySinh;							
				dbitem.A6_GioiTinh = item.A6_GioiTinh;							
				dbitem.A6_CMND = item.A6_CMND;							
				dbitem.A6_NgayCap = item.A6_NgayCap;							
				dbitem.A6_NoiCap = item.A6_NoiCap;							
				dbitem.A6_MST = item.A6_MST;							
				dbitem.A6_STK = item.A6_STK;							
				dbitem.A6_NganHang = item.A6_NganHang;							
				dbitem.A6_DiaChiCoQuan = item.A6_DiaChiCoQuan;							
				dbitem.A6_DienThoai = item.A6_DienThoai;							
				dbitem.A6_Email = item.A6_Email;							
				dbitem.A6_TomTatHoatDong = item.A6_TomTatHoatDong;							
				dbitem.A7_TenCoQuan = item.A7_TenCoQuan;							
				dbitem.A7_HoTenThuTruong = item.A7_HoTenThuTruong;							
				dbitem.A7_DienThoai = item.A7_DienThoai;							
				dbitem.A7_DiaChi = item.A7_DiaChi;							
				dbitem.A8_CoQuanPhoiHopThucHien = item.A8_CoQuanPhoiHopThucHien;							
				dbitem.A9_JSON_NhanLucNghienCuu = item.A9_JSON_NhanLucNghienCuu;							
				dbitem.B1_GioiThieu = item.B1_GioiThieu;							
				dbitem.B2_TaiLieuThamKhao = item.B2_TaiLieuThamKhao;							
				dbitem.B2_JSON_GioiThieuChuyenGia = item.B2_JSON_GioiThieuChuyenGia;							
				dbitem.B311_MucTieuNghienCuu = item.B311_MucTieuNghienCuu;							
				dbitem.B312_ChiTieuDanhGia = item.B312_ChiTieuDanhGia;							
				dbitem.B313_DiaChi = item.B313_DiaChi;							
				dbitem.B313_JSON_KeHoachThucHien = item.B313_JSON_KeHoachThucHien;							
				dbitem.B321_ThietKeNghienCuu = item.B321_ThietKeNghienCuu;							
				dbitem.B322_DanSoNghienCuu = item.B322_DanSoNghienCuu;							
				dbitem.B3221_TieuChuanNhanLoai = item.B3221_TieuChuanNhanLoai;							
				dbitem.B3222_CoMau = item.B3222_CoMau;							
				dbitem.B323_PhuongPhapTienHanh = item.B323_PhuongPhapTienHanh;							
				dbitem.B324_PhuongPhapDanhGia = item.B324_PhuongPhapDanhGia;							
				dbitem.B3241_YeuToDanhGiaKetQua = item.B3241_YeuToDanhGiaKetQua;							
				dbitem.B3242_CacBienChungDieuTri = item.B3242_CacBienChungDieuTri;							
				dbitem.B3243_CacBienChungVeSanKhoa = item.B3243_CacBienChungVeSanKhoa;							
				dbitem.B325_PhuongPhapPhanTich = item.B325_PhuongPhapPhanTich;							
				dbitem.B326_JSON_CacBienSoCanThuThap = item.B326_JSON_CacBienSoCanThuThap;							
				dbitem.B327_BangKetQuaDuKien = item.B327_BangKetQuaDuKien;							
				dbitem.B328_VanDeYDuc = item.B328_VanDeYDuc;							
				dbitem.B329_TinhKhaThi = item.B329_TinhKhaThi;							
				dbitem.B33_PhuongAnPhoiHop = item.B33_PhuongAnPhoiHop;							
				dbitem.B33_PhuongAnPhoiHopPTN = item.B33_PhuongAnPhoiHopPTN;							
				dbitem.B33_PhuongAnPhoiHopDonVi = item.B33_PhuongAnPhoiHopDonVi;							
				dbitem.B33_PhuongAnPhoiHopCGCN = item.B33_PhuongAnPhoiHopCGCN;							
				dbitem.B4_KetQuaNghienCuu = item.B4_KetQuaNghienCuu;							
				dbitem.B41_AnPhamKhoaHoc = item.B41_AnPhamKhoaHoc;							
				dbitem.B42_DangKySoHuuTriTue = item.B42_DangKySoHuuTriTue;							
				dbitem.B43_KetQuaDaoTao = item.B43_KetQuaDaoTao;							
				dbitem.B5_KhaNangUngDung = item.B5_KhaNangUngDung;							
				dbitem.B51_KhaNangUngDungLinhVucDaoTao = item.B51_KhaNangUngDungLinhVucDaoTao;							
				dbitem.B52_TongHopKinhPhi = item.B52_TongHopKinhPhi;							
				dbitem.B52_JSON_TongHopKinhPhi = item.B52_JSON_TongHopKinhPhi;							
				dbitem.PhuLuc_JSON_KhoanCongLaoDong = item.PhuLuc_JSON_KhoanCongLaoDong;							
				dbitem.PhuLuc_JSON_NguyenVatLieu = item.PhuLuc_JSON_NguyenVatLieu;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.PhuLuc_JSON_ThietBi = item.PhuLuc_JSON_ThietBi;							
				dbitem.PhuLuc_JSON_ChiKhac = item.PhuLuc_JSON_ChiKhac;							
				dbitem.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai = item.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai;							
				dbitem.B52_CoQuanChuTri_NgayKy_Ngay = item.B52_CoQuanChuTri_NgayKy_Ngay;							
				dbitem.B52_CoQuanChuTri_NgayKy_Thang = item.B52_CoQuanChuTri_NgayKy_Thang;							
				dbitem.B52_CoQuanChuTri_NgayKy_Nam = item.B52_CoQuanChuTri_NgayKy_Nam;							
				dbitem.B52_CoQuanChuTri_NgayKy_ChuKy = item.B52_CoQuanChuTri_NgayKy_ChuKy;							
				dbitem.B52_CNDT_NgayKy_Ngay = item.B52_CNDT_NgayKy_Ngay;							
				dbitem.B52_CNDT_NgayKy_Thang = item.B52_CNDT_NgayKy_Thang;							
				dbitem.B52_CNDT_NgayKy_Nam = item.B52_CNDT_NgayKy_Nam;							
				dbitem.B52_CNDT_NgayKy_ChuKy = item.B52_CNDT_NgayKy_ChuKy;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_ThuyetMinhDeTai.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_ThuyetMinhDeTai", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_ThuyetMinhDeTai",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_ThuyetMinhDeTai(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_ThuyetMinhDeTai.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_ThuyetMinhDeTai", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_ThuyetMinhDeTai",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_ThuyetMinhDeTai_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_ThuyetMinhDeTai.Any(e => e.ID == id);
		}
		
    }

}






