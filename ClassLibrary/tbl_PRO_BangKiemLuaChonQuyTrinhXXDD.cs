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
    
    
    public partial class tbl_PRO_BangKiemLuaChonQuyTrinhXXDD
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string MaSo { get; set; }
        public bool PhanMot_ConNguoi { get; set; }
        public bool PhanMot_DongVat { get; set; }
        public string PhanHai_TenNCYSH { get; set; }
        public string PhanHai_NCVChinh_HoTen { get; set; }
        public string PhanHai_NCVChinh_KhoaPhong { get; set; }
        public string PhanHai_NCVChinh_BenhVien { get; set; }
        public string PhanHai_NCVChinh_DienThoai { get; set; }
        public string PhanHai_NCVChinh_Email { get; set; }
        public string PhanHai_NCVChinh_DiaChiLienHe { get; set; }
        public string PhanHai_NGS_HoTen { get; set; }
        public string PhanHai_NGS_NoiLamViec { get; set; }
        public string PhanHai_NGS_DienThoai { get; set; }
        public string PhanHai_NGS_Email { get; set; }
        public string PhanBa_A_JSON { get; set; }
        public string PhanBa_B_JSON { get; set; }
        public string PhanBon_C1_MoTaQuyTrinh { get; set; }
        public string PhanBon_C1_NoiNhanMau { get; set; }
        public string PhanBon_C1_DanSoChonMau { get; set; }
        public string PhanBon_C1_CoMauNghienCuu { get; set; }
        public string PhanBon_C1_TieuChuanNhanVao { get; set; }
        public string PhanBon_C1_TieuChuanLoaiRa { get; set; }
        public string PhanBon_C2_MoTaQuyTrinh { get; set; }
        public string PhanBon_C2_CachTienHanh { get; set; }
        public string PhanBon_C3_MoTaQuyTrinh { get; set; }
        public string PhanNam_JSON { get; set; }
        public string ThoiGianTienHanh_Ngay { get; set; }
        public string ThoiGianTienHanh_Thang { get; set; }
        public string ThoiGianTienHanh_Nam { get; set; }
        public string ThoiGianThuThap_Ngay { get; set; }
        public string ThoiGianThuThap_Thang { get; set; }
        public string ThoiGianThuThap_Nam { get; set; }
        public string ThoiGianNghienCuu_Ngay { get; set; }
        public string ThoiGianNghienCuu_Thang { get; set; }
        public string ThoiGianNghienCuu_Nam { get; set; }
        public string JSON_NCVKhac { get; set; }
        public bool DaGuiThuDienTu { get; set; }
        public string JSON_MoTaNCYSH { get; set; }
        public bool PhanSau_NCYSH_KhongThuocPhamVi { get; set; }
        public bool PhanSau_NCYSH_DuDieuKienXemXet { get; set; }
        public string PhanSau_NCYSH_HoTen { get; set; }
        public string PhanSau_NCYSH_NgayThangNam { get; set; }
        public bool PhanSau_NCYSH_GuiThongBao_KHTH { get; set; }
        public bool PhanSau_NCYSH_GuiThongBao_TCKT { get; set; }
        public bool PhanSau_NGS_KhongThuocPhamVi { get; set; }
        public bool PhanSau_NGS_DuDieuKienXemXet { get; set; }
        public string PhanSau_NGS_HoTen { get; set; }
        public string PhanSau_NGS_NgayThangNam { get; set; }
        public bool PhanSau_TruongKhoa_KhongThuocPhamVi { get; set; }
        public bool PhanSau_TruongKhoa_DuDieuKienXemXet { get; set; }
        public string PhanSau_TruongKhoa_HoTen { get; set; }
        public string PhanSau_TruongKhoa_ChucVu { get; set; }
        public string PhanSau_TruongKhoa_NgayThangNam { get; set; }
        public bool YKienHDDD_KhongThuocPhamVi { get; set; }
        public bool YKienHDDD_DuocXemXetDaoDuc { get; set; }
        public bool YKienHDDD_DuocXemXetDaoDucRutGon { get; set; }
        public bool YKienHDDD_CanDuocHoiDongXemXet { get; set; }
        public string YKienHDDD_NhanXet { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string YKienHDDD_So { get; set; }
        public string NgayKy_Ngay { get; set; }
        public string NgayKy_Thang { get; set; }
        public string NgayKy_Nam { get; set; }
        public Nullable<bool> PhanSau_NCYSH_KhongThuocPhamVi_Co { get; set; }
        public Nullable<bool> PhanSau_NCYSH_KhongThuocPhamVi_Khong { get; set; }
        public Nullable<bool> PhanSau_NCYSH_GuiThongBao_KHTH_Co { get; set; }
        public Nullable<bool> PhanSau_NCYSH_GuiThongBao_KHTH_Khong { get; set; }
        public Nullable<bool> PhanSau_NCYSH_GuiThongBao_TCKT_Co { get; set; }
        public Nullable<bool> PhanSau_NCYSH_GuiThongBao_TCKT_Khong { get; set; }
        public Nullable<bool> PhanSau_NGS_KhongThuocPhamVi_Co { get; set; }
        public Nullable<bool> PhanSau_NGS_KhongThuocPhamVi_Khong { get; set; }
        public Nullable<bool> PhanSau_TruongKhoa_KhongThuocPhamVi_Co { get; set; }
        public Nullable<bool> PhanSau_TruongKhoa_KhongThuocPhamVi_Khong { get; set; }
        public string ThoiGianTienHanhDenNgay_Ngay { get; set; }
        public string ThoiGianTienHanhDenNgay_Thang { get; set; }
        public string ThoiGianTienHanhDenNgay_Nam { get; set; }
        public string ThoiGianThuThapDenNgay_Ngay { get; set; }
        public string ThoiGianThuThapDenNgay_Thang { get; set; }
        public string ThoiGianThuThapDenNgay_Nam { get; set; }
        public string ThoiGianNghienCuuDenNgay_Ngay { get; set; }
        public string ThoiGianNghienCuuDenNgay_Thang { get; set; }
        public string ThoiGianNghienCuuDenNgay_Nam { get; set; }
        public string FormConfig { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_BangKiemLuaChonQuyTrinhXXDD
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string MaSo { get; set; }
		public bool PhanMot_ConNguoi { get; set; }
		public bool PhanMot_DongVat { get; set; }
		public string PhanHai_TenNCYSH { get; set; }
		public string PhanHai_NCVChinh_HoTen { get; set; }
		public string PhanHai_NCVChinh_KhoaPhong { get; set; }
		public string PhanHai_NCVChinh_BenhVien { get; set; }
		public string PhanHai_NCVChinh_DienThoai { get; set; }
		public string PhanHai_NCVChinh_Email { get; set; }
		public string PhanHai_NCVChinh_DiaChiLienHe { get; set; }
		public string PhanHai_NGS_HoTen { get; set; }
		public string PhanHai_NGS_NoiLamViec { get; set; }
		public string PhanHai_NGS_DienThoai { get; set; }
		public string PhanHai_NGS_Email { get; set; }
		public string PhanBa_A_JSON { get; set; }
		public string PhanBa_B_JSON { get; set; }
		public string PhanBon_C1_MoTaQuyTrinh { get; set; }
		public string PhanBon_C1_NoiNhanMau { get; set; }
		public string PhanBon_C1_DanSoChonMau { get; set; }
		public string PhanBon_C1_CoMauNghienCuu { get; set; }
		public string PhanBon_C1_TieuChuanNhanVao { get; set; }
		public string PhanBon_C1_TieuChuanLoaiRa { get; set; }
		public string PhanBon_C2_MoTaQuyTrinh { get; set; }
		public string PhanBon_C2_CachTienHanh { get; set; }
		public string PhanBon_C3_MoTaQuyTrinh { get; set; }
		public string PhanNam_JSON { get; set; }
		public string ThoiGianTienHanh_Ngay { get; set; }
		public string ThoiGianTienHanh_Thang { get; set; }
		public string ThoiGianTienHanh_Nam { get; set; }
		public string ThoiGianThuThap_Ngay { get; set; }
		public string ThoiGianThuThap_Thang { get; set; }
		public string ThoiGianThuThap_Nam { get; set; }
		public string ThoiGianNghienCuu_Ngay { get; set; }
		public string ThoiGianNghienCuu_Thang { get; set; }
		public string ThoiGianNghienCuu_Nam { get; set; }
		public string JSON_NCVKhac { get; set; }
		public bool DaGuiThuDienTu { get; set; }
		public string JSON_MoTaNCYSH { get; set; }
		public bool PhanSau_NCYSH_KhongThuocPhamVi { get; set; }
		public bool PhanSau_NCYSH_DuDieuKienXemXet { get; set; }
		public string PhanSau_NCYSH_HoTen { get; set; }
		public string PhanSau_NCYSH_NgayThangNam { get; set; }
		public bool PhanSau_NCYSH_GuiThongBao_KHTH { get; set; }
		public bool PhanSau_NCYSH_GuiThongBao_TCKT { get; set; }
		public bool PhanSau_NGS_KhongThuocPhamVi { get; set; }
		public bool PhanSau_NGS_DuDieuKienXemXet { get; set; }
		public string PhanSau_NGS_HoTen { get; set; }
		public string PhanSau_NGS_NgayThangNam { get; set; }
		public bool PhanSau_TruongKhoa_KhongThuocPhamVi { get; set; }
		public bool PhanSau_TruongKhoa_DuDieuKienXemXet { get; set; }
		public string PhanSau_TruongKhoa_HoTen { get; set; }
		public string PhanSau_TruongKhoa_ChucVu { get; set; }
		public string PhanSau_TruongKhoa_NgayThangNam { get; set; }
		public bool YKienHDDD_KhongThuocPhamVi { get; set; }
		public bool YKienHDDD_DuocXemXetDaoDuc { get; set; }
		public bool YKienHDDD_DuocXemXetDaoDucRutGon { get; set; }
		public bool YKienHDDD_CanDuocHoiDongXemXet { get; set; }
		public string YKienHDDD_NhanXet { get; set; }
		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public string YKienHDDD_So { get; set; }
		public string NgayKy_Ngay { get; set; }
		public string NgayKy_Thang { get; set; }
		public string NgayKy_Nam { get; set; }
		public Nullable<bool> PhanSau_NCYSH_KhongThuocPhamVi_Co { get; set; }
		public Nullable<bool> PhanSau_NCYSH_KhongThuocPhamVi_Khong { get; set; }
		public Nullable<bool> PhanSau_NCYSH_GuiThongBao_KHTH_Co { get; set; }
		public Nullable<bool> PhanSau_NCYSH_GuiThongBao_KHTH_Khong { get; set; }
		public Nullable<bool> PhanSau_NCYSH_GuiThongBao_TCKT_Co { get; set; }
		public Nullable<bool> PhanSau_NCYSH_GuiThongBao_TCKT_Khong { get; set; }
		public Nullable<bool> PhanSau_NGS_KhongThuocPhamVi_Co { get; set; }
		public Nullable<bool> PhanSau_NGS_KhongThuocPhamVi_Khong { get; set; }
		public Nullable<bool> PhanSau_TruongKhoa_KhongThuocPhamVi_Co { get; set; }
		public Nullable<bool> PhanSau_TruongKhoa_KhongThuocPhamVi_Khong { get; set; }
		public string ThoiGianTienHanhDenNgay_Ngay { get; set; }
		public string ThoiGianTienHanhDenNgay_Thang { get; set; }
		public string ThoiGianTienHanhDenNgay_Nam { get; set; }
		public string ThoiGianThuThapDenNgay_Ngay { get; set; }
		public string ThoiGianThuThapDenNgay_Thang { get; set; }
		public string ThoiGianThuThapDenNgay_Nam { get; set; }
		public string ThoiGianNghienCuuDenNgay_Ngay { get; set; }
		public string ThoiGianNghienCuuDenNgay_Thang { get; set; }
		public string ThoiGianNghienCuuDenNgay_Nam { get; set; }
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

    public static partial class BS_PRO_BangKiemLuaChonQuyTrinhXXDD 
    {
		public static IQueryable<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD> toDTO(IQueryable<tbl_PRO_BangKiemLuaChonQuyTrinhXXDD> query)
        {
			return query
			.Select(s => new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				MaSo = s.MaSo,							
				PhanMot_ConNguoi = s.PhanMot_ConNguoi,							
				PhanMot_DongVat = s.PhanMot_DongVat,							
				PhanHai_TenNCYSH = s.PhanHai_TenNCYSH,							
				PhanHai_NCVChinh_HoTen = s.PhanHai_NCVChinh_HoTen,							
				PhanHai_NCVChinh_KhoaPhong = s.PhanHai_NCVChinh_KhoaPhong,							
				PhanHai_NCVChinh_BenhVien = s.PhanHai_NCVChinh_BenhVien,							
				PhanHai_NCVChinh_DienThoai = s.PhanHai_NCVChinh_DienThoai,							
				PhanHai_NCVChinh_Email = s.PhanHai_NCVChinh_Email,							
				PhanHai_NCVChinh_DiaChiLienHe = s.PhanHai_NCVChinh_DiaChiLienHe,							
				PhanHai_NGS_HoTen = s.PhanHai_NGS_HoTen,							
				PhanHai_NGS_NoiLamViec = s.PhanHai_NGS_NoiLamViec,							
				PhanHai_NGS_DienThoai = s.PhanHai_NGS_DienThoai,							
				PhanHai_NGS_Email = s.PhanHai_NGS_Email,							
				PhanBa_A_JSON = s.PhanBa_A_JSON,							
				PhanBa_B_JSON = s.PhanBa_B_JSON,							
				PhanBon_C1_MoTaQuyTrinh = s.PhanBon_C1_MoTaQuyTrinh,							
				PhanBon_C1_NoiNhanMau = s.PhanBon_C1_NoiNhanMau,							
				PhanBon_C1_DanSoChonMau = s.PhanBon_C1_DanSoChonMau,							
				PhanBon_C1_CoMauNghienCuu = s.PhanBon_C1_CoMauNghienCuu,							
				PhanBon_C1_TieuChuanNhanVao = s.PhanBon_C1_TieuChuanNhanVao,							
				PhanBon_C1_TieuChuanLoaiRa = s.PhanBon_C1_TieuChuanLoaiRa,							
				PhanBon_C2_MoTaQuyTrinh = s.PhanBon_C2_MoTaQuyTrinh,							
				PhanBon_C2_CachTienHanh = s.PhanBon_C2_CachTienHanh,							
				PhanBon_C3_MoTaQuyTrinh = s.PhanBon_C3_MoTaQuyTrinh,							
				PhanNam_JSON = s.PhanNam_JSON,							
				ThoiGianTienHanh_Ngay = s.ThoiGianTienHanh_Ngay,							
				ThoiGianTienHanh_Thang = s.ThoiGianTienHanh_Thang,							
				ThoiGianTienHanh_Nam = s.ThoiGianTienHanh_Nam,							
				ThoiGianThuThap_Ngay = s.ThoiGianThuThap_Ngay,							
				ThoiGianThuThap_Thang = s.ThoiGianThuThap_Thang,							
				ThoiGianThuThap_Nam = s.ThoiGianThuThap_Nam,							
				ThoiGianNghienCuu_Ngay = s.ThoiGianNghienCuu_Ngay,							
				ThoiGianNghienCuu_Thang = s.ThoiGianNghienCuu_Thang,							
				ThoiGianNghienCuu_Nam = s.ThoiGianNghienCuu_Nam,							
				JSON_NCVKhac = s.JSON_NCVKhac,							
				DaGuiThuDienTu = s.DaGuiThuDienTu,							
				JSON_MoTaNCYSH = s.JSON_MoTaNCYSH,							
				PhanSau_NCYSH_KhongThuocPhamVi = s.PhanSau_NCYSH_KhongThuocPhamVi,							
				PhanSau_NCYSH_DuDieuKienXemXet = s.PhanSau_NCYSH_DuDieuKienXemXet,							
				PhanSau_NCYSH_HoTen = s.PhanSau_NCYSH_HoTen,							
				PhanSau_NCYSH_NgayThangNam = s.PhanSau_NCYSH_NgayThangNam,							
				PhanSau_NCYSH_GuiThongBao_KHTH = s.PhanSau_NCYSH_GuiThongBao_KHTH,							
				PhanSau_NCYSH_GuiThongBao_TCKT = s.PhanSau_NCYSH_GuiThongBao_TCKT,							
				PhanSau_NGS_KhongThuocPhamVi = s.PhanSau_NGS_KhongThuocPhamVi,							
				PhanSau_NGS_DuDieuKienXemXet = s.PhanSau_NGS_DuDieuKienXemXet,							
				PhanSau_NGS_HoTen = s.PhanSau_NGS_HoTen,							
				PhanSau_NGS_NgayThangNam = s.PhanSau_NGS_NgayThangNam,							
				PhanSau_TruongKhoa_KhongThuocPhamVi = s.PhanSau_TruongKhoa_KhongThuocPhamVi,							
				PhanSau_TruongKhoa_DuDieuKienXemXet = s.PhanSau_TruongKhoa_DuDieuKienXemXet,							
				PhanSau_TruongKhoa_HoTen = s.PhanSau_TruongKhoa_HoTen,							
				PhanSau_TruongKhoa_ChucVu = s.PhanSau_TruongKhoa_ChucVu,							
				PhanSau_TruongKhoa_NgayThangNam = s.PhanSau_TruongKhoa_NgayThangNam,							
				YKienHDDD_KhongThuocPhamVi = s.YKienHDDD_KhongThuocPhamVi,							
				YKienHDDD_DuocXemXetDaoDuc = s.YKienHDDD_DuocXemXetDaoDuc,							
				YKienHDDD_DuocXemXetDaoDucRutGon = s.YKienHDDD_DuocXemXetDaoDucRutGon,							
				YKienHDDD_CanDuocHoiDongXemXet = s.YKienHDDD_CanDuocHoiDongXemXet,							
				YKienHDDD_NhanXet = s.YKienHDDD_NhanXet,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				YKienHDDD_So = s.YKienHDDD_So,							
				NgayKy_Ngay = s.NgayKy_Ngay,							
				NgayKy_Thang = s.NgayKy_Thang,							
				NgayKy_Nam = s.NgayKy_Nam,							
				PhanSau_NCYSH_KhongThuocPhamVi_Co = s.PhanSau_NCYSH_KhongThuocPhamVi_Co,							
				PhanSau_NCYSH_KhongThuocPhamVi_Khong = s.PhanSau_NCYSH_KhongThuocPhamVi_Khong,							
				PhanSau_NCYSH_GuiThongBao_KHTH_Co = s.PhanSau_NCYSH_GuiThongBao_KHTH_Co,							
				PhanSau_NCYSH_GuiThongBao_KHTH_Khong = s.PhanSau_NCYSH_GuiThongBao_KHTH_Khong,							
				PhanSau_NCYSH_GuiThongBao_TCKT_Co = s.PhanSau_NCYSH_GuiThongBao_TCKT_Co,							
				PhanSau_NCYSH_GuiThongBao_TCKT_Khong = s.PhanSau_NCYSH_GuiThongBao_TCKT_Khong,							
				PhanSau_NGS_KhongThuocPhamVi_Co = s.PhanSau_NGS_KhongThuocPhamVi_Co,							
				PhanSau_NGS_KhongThuocPhamVi_Khong = s.PhanSau_NGS_KhongThuocPhamVi_Khong,							
				PhanSau_TruongKhoa_KhongThuocPhamVi_Co = s.PhanSau_TruongKhoa_KhongThuocPhamVi_Co,							
				PhanSau_TruongKhoa_KhongThuocPhamVi_Khong = s.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong,							
				ThoiGianTienHanhDenNgay_Ngay = s.ThoiGianTienHanhDenNgay_Ngay,							
				ThoiGianTienHanhDenNgay_Thang = s.ThoiGianTienHanhDenNgay_Thang,							
				ThoiGianTienHanhDenNgay_Nam = s.ThoiGianTienHanhDenNgay_Nam,							
				ThoiGianThuThapDenNgay_Ngay = s.ThoiGianThuThapDenNgay_Ngay,							
				ThoiGianThuThapDenNgay_Thang = s.ThoiGianThuThapDenNgay_Thang,							
				ThoiGianThuThapDenNgay_Nam = s.ThoiGianThuThapDenNgay_Nam,							
				ThoiGianNghienCuuDenNgay_Ngay = s.ThoiGianNghienCuuDenNgay_Ngay,							
				ThoiGianNghienCuuDenNgay_Thang = s.ThoiGianNghienCuuDenNgay_Thang,							
				ThoiGianNghienCuuDenNgay_Nam = s.ThoiGianNghienCuuDenNgay_Nam,							
				FormConfig = s.FormConfig,					
			});
                              
        }

		public static DTO_PRO_BangKiemLuaChonQuyTrinhXXDD toDTO(tbl_PRO_BangKiemLuaChonQuyTrinhXXDD dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					MaSo = dbResult.MaSo,							
					PhanMot_ConNguoi = dbResult.PhanMot_ConNguoi,							
					PhanMot_DongVat = dbResult.PhanMot_DongVat,							
					PhanHai_TenNCYSH = dbResult.PhanHai_TenNCYSH,							
					PhanHai_NCVChinh_HoTen = dbResult.PhanHai_NCVChinh_HoTen,							
					PhanHai_NCVChinh_KhoaPhong = dbResult.PhanHai_NCVChinh_KhoaPhong,							
					PhanHai_NCVChinh_BenhVien = dbResult.PhanHai_NCVChinh_BenhVien,							
					PhanHai_NCVChinh_DienThoai = dbResult.PhanHai_NCVChinh_DienThoai,							
					PhanHai_NCVChinh_Email = dbResult.PhanHai_NCVChinh_Email,							
					PhanHai_NCVChinh_DiaChiLienHe = dbResult.PhanHai_NCVChinh_DiaChiLienHe,							
					PhanHai_NGS_HoTen = dbResult.PhanHai_NGS_HoTen,							
					PhanHai_NGS_NoiLamViec = dbResult.PhanHai_NGS_NoiLamViec,							
					PhanHai_NGS_DienThoai = dbResult.PhanHai_NGS_DienThoai,							
					PhanHai_NGS_Email = dbResult.PhanHai_NGS_Email,							
					PhanBa_A_JSON = dbResult.PhanBa_A_JSON,							
					PhanBa_B_JSON = dbResult.PhanBa_B_JSON,							
					PhanBon_C1_MoTaQuyTrinh = dbResult.PhanBon_C1_MoTaQuyTrinh,							
					PhanBon_C1_NoiNhanMau = dbResult.PhanBon_C1_NoiNhanMau,							
					PhanBon_C1_DanSoChonMau = dbResult.PhanBon_C1_DanSoChonMau,							
					PhanBon_C1_CoMauNghienCuu = dbResult.PhanBon_C1_CoMauNghienCuu,							
					PhanBon_C1_TieuChuanNhanVao = dbResult.PhanBon_C1_TieuChuanNhanVao,							
					PhanBon_C1_TieuChuanLoaiRa = dbResult.PhanBon_C1_TieuChuanLoaiRa,							
					PhanBon_C2_MoTaQuyTrinh = dbResult.PhanBon_C2_MoTaQuyTrinh,							
					PhanBon_C2_CachTienHanh = dbResult.PhanBon_C2_CachTienHanh,							
					PhanBon_C3_MoTaQuyTrinh = dbResult.PhanBon_C3_MoTaQuyTrinh,							
					PhanNam_JSON = dbResult.PhanNam_JSON,							
					ThoiGianTienHanh_Ngay = dbResult.ThoiGianTienHanh_Ngay,							
					ThoiGianTienHanh_Thang = dbResult.ThoiGianTienHanh_Thang,							
					ThoiGianTienHanh_Nam = dbResult.ThoiGianTienHanh_Nam,							
					ThoiGianThuThap_Ngay = dbResult.ThoiGianThuThap_Ngay,							
					ThoiGianThuThap_Thang = dbResult.ThoiGianThuThap_Thang,							
					ThoiGianThuThap_Nam = dbResult.ThoiGianThuThap_Nam,							
					ThoiGianNghienCuu_Ngay = dbResult.ThoiGianNghienCuu_Ngay,							
					ThoiGianNghienCuu_Thang = dbResult.ThoiGianNghienCuu_Thang,							
					ThoiGianNghienCuu_Nam = dbResult.ThoiGianNghienCuu_Nam,							
					JSON_NCVKhac = dbResult.JSON_NCVKhac,							
					DaGuiThuDienTu = dbResult.DaGuiThuDienTu,							
					JSON_MoTaNCYSH = dbResult.JSON_MoTaNCYSH,							
					PhanSau_NCYSH_KhongThuocPhamVi = dbResult.PhanSau_NCYSH_KhongThuocPhamVi,							
					PhanSau_NCYSH_DuDieuKienXemXet = dbResult.PhanSau_NCYSH_DuDieuKienXemXet,							
					PhanSau_NCYSH_HoTen = dbResult.PhanSau_NCYSH_HoTen,							
					PhanSau_NCYSH_NgayThangNam = dbResult.PhanSau_NCYSH_NgayThangNam,							
					PhanSau_NCYSH_GuiThongBao_KHTH = dbResult.PhanSau_NCYSH_GuiThongBao_KHTH,							
					PhanSau_NCYSH_GuiThongBao_TCKT = dbResult.PhanSau_NCYSH_GuiThongBao_TCKT,							
					PhanSau_NGS_KhongThuocPhamVi = dbResult.PhanSau_NGS_KhongThuocPhamVi,							
					PhanSau_NGS_DuDieuKienXemXet = dbResult.PhanSau_NGS_DuDieuKienXemXet,							
					PhanSau_NGS_HoTen = dbResult.PhanSau_NGS_HoTen,							
					PhanSau_NGS_NgayThangNam = dbResult.PhanSau_NGS_NgayThangNam,							
					PhanSau_TruongKhoa_KhongThuocPhamVi = dbResult.PhanSau_TruongKhoa_KhongThuocPhamVi,							
					PhanSau_TruongKhoa_DuDieuKienXemXet = dbResult.PhanSau_TruongKhoa_DuDieuKienXemXet,							
					PhanSau_TruongKhoa_HoTen = dbResult.PhanSau_TruongKhoa_HoTen,							
					PhanSau_TruongKhoa_ChucVu = dbResult.PhanSau_TruongKhoa_ChucVu,							
					PhanSau_TruongKhoa_NgayThangNam = dbResult.PhanSau_TruongKhoa_NgayThangNam,							
					YKienHDDD_KhongThuocPhamVi = dbResult.YKienHDDD_KhongThuocPhamVi,							
					YKienHDDD_DuocXemXetDaoDuc = dbResult.YKienHDDD_DuocXemXetDaoDuc,							
					YKienHDDD_DuocXemXetDaoDucRutGon = dbResult.YKienHDDD_DuocXemXetDaoDucRutGon,							
					YKienHDDD_CanDuocHoiDongXemXet = dbResult.YKienHDDD_CanDuocHoiDongXemXet,							
					YKienHDDD_NhanXet = dbResult.YKienHDDD_NhanXet,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					YKienHDDD_So = dbResult.YKienHDDD_So,							
					NgayKy_Ngay = dbResult.NgayKy_Ngay,							
					NgayKy_Thang = dbResult.NgayKy_Thang,							
					NgayKy_Nam = dbResult.NgayKy_Nam,							
					PhanSau_NCYSH_KhongThuocPhamVi_Co = dbResult.PhanSau_NCYSH_KhongThuocPhamVi_Co,							
					PhanSau_NCYSH_KhongThuocPhamVi_Khong = dbResult.PhanSau_NCYSH_KhongThuocPhamVi_Khong,							
					PhanSau_NCYSH_GuiThongBao_KHTH_Co = dbResult.PhanSau_NCYSH_GuiThongBao_KHTH_Co,							
					PhanSau_NCYSH_GuiThongBao_KHTH_Khong = dbResult.PhanSau_NCYSH_GuiThongBao_KHTH_Khong,							
					PhanSau_NCYSH_GuiThongBao_TCKT_Co = dbResult.PhanSau_NCYSH_GuiThongBao_TCKT_Co,							
					PhanSau_NCYSH_GuiThongBao_TCKT_Khong = dbResult.PhanSau_NCYSH_GuiThongBao_TCKT_Khong,							
					PhanSau_NGS_KhongThuocPhamVi_Co = dbResult.PhanSau_NGS_KhongThuocPhamVi_Co,							
					PhanSau_NGS_KhongThuocPhamVi_Khong = dbResult.PhanSau_NGS_KhongThuocPhamVi_Khong,							
					PhanSau_TruongKhoa_KhongThuocPhamVi_Co = dbResult.PhanSau_TruongKhoa_KhongThuocPhamVi_Co,							
					PhanSau_TruongKhoa_KhongThuocPhamVi_Khong = dbResult.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong,							
					ThoiGianTienHanhDenNgay_Ngay = dbResult.ThoiGianTienHanhDenNgay_Ngay,							
					ThoiGianTienHanhDenNgay_Thang = dbResult.ThoiGianTienHanhDenNgay_Thang,							
					ThoiGianTienHanhDenNgay_Nam = dbResult.ThoiGianTienHanhDenNgay_Nam,							
					ThoiGianThuThapDenNgay_Ngay = dbResult.ThoiGianThuThapDenNgay_Ngay,							
					ThoiGianThuThapDenNgay_Thang = dbResult.ThoiGianThuThapDenNgay_Thang,							
					ThoiGianThuThapDenNgay_Nam = dbResult.ThoiGianThuThapDenNgay_Nam,							
					ThoiGianNghienCuuDenNgay_Ngay = dbResult.ThoiGianNghienCuuDenNgay_Ngay,							
					ThoiGianNghienCuuDenNgay_Thang = dbResult.ThoiGianNghienCuuDenNgay_Thang,							
					ThoiGianNghienCuuDenNgay_Nam = dbResult.ThoiGianNghienCuuDenNgay_Nam,							
					FormConfig = dbResult.FormConfig,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD> get_PRO_BangKiemLuaChonQuyTrinhXXDD(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Where(d => d.IsDeleted == false );

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

			//Query PhanMot_ConNguoi (bool)
			if (QueryStrings.Any(d => d.Key == "PhanMot_ConNguoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanMot_ConNguoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanMot_ConNguoi);
            }

			//Query PhanMot_DongVat (bool)
			if (QueryStrings.Any(d => d.Key == "PhanMot_DongVat"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanMot_DongVat").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanMot_DongVat);
            }

			//Query PhanHai_TenNCYSH (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_TenNCYSH") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_TenNCYSH").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_TenNCYSH").Value;
                query = query.Where(d=>d.PhanHai_TenNCYSH == keyword);
            }

			//Query PhanHai_NCVChinh_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NCVChinh_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_HoTen").Value;
                query = query.Where(d=>d.PhanHai_NCVChinh_HoTen == keyword);
            }

			//Query PhanHai_NCVChinh_KhoaPhong (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NCVChinh_KhoaPhong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_KhoaPhong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_KhoaPhong").Value;
                query = query.Where(d=>d.PhanHai_NCVChinh_KhoaPhong == keyword);
            }

			//Query PhanHai_NCVChinh_BenhVien (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NCVChinh_BenhVien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_BenhVien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_BenhVien").Value;
                query = query.Where(d=>d.PhanHai_NCVChinh_BenhVien == keyword);
            }

			//Query PhanHai_NCVChinh_DienThoai (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NCVChinh_DienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_DienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_DienThoai").Value;
                query = query.Where(d=>d.PhanHai_NCVChinh_DienThoai == keyword);
            }

			//Query PhanHai_NCVChinh_Email (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NCVChinh_Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_Email").Value;
                query = query.Where(d=>d.PhanHai_NCVChinh_Email == keyword);
            }

			//Query PhanHai_NCVChinh_DiaChiLienHe (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NCVChinh_DiaChiLienHe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_DiaChiLienHe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NCVChinh_DiaChiLienHe").Value;
                query = query.Where(d=>d.PhanHai_NCVChinh_DiaChiLienHe == keyword);
            }

			//Query PhanHai_NGS_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NGS_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_HoTen").Value;
                query = query.Where(d=>d.PhanHai_NGS_HoTen == keyword);
            }

			//Query PhanHai_NGS_NoiLamViec (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NGS_NoiLamViec") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_NoiLamViec").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_NoiLamViec").Value;
                query = query.Where(d=>d.PhanHai_NGS_NoiLamViec == keyword);
            }

			//Query PhanHai_NGS_DienThoai (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NGS_DienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_DienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_DienThoai").Value;
                query = query.Where(d=>d.PhanHai_NGS_DienThoai == keyword);
            }

			//Query PhanHai_NGS_Email (string)
			if (QueryStrings.Any(d => d.Key == "PhanHai_NGS_Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanHai_NGS_Email").Value;
                query = query.Where(d=>d.PhanHai_NGS_Email == keyword);
            }

			//Query PhanBa_A_JSON (string)
			if (QueryStrings.Any(d => d.Key == "PhanBa_A_JSON") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBa_A_JSON").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBa_A_JSON").Value;
                query = query.Where(d=>d.PhanBa_A_JSON == keyword);
            }

			//Query PhanBa_B_JSON (string)
			if (QueryStrings.Any(d => d.Key == "PhanBa_B_JSON") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBa_B_JSON").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBa_B_JSON").Value;
                query = query.Where(d=>d.PhanBa_B_JSON == keyword);
            }

			//Query PhanBon_C1_MoTaQuyTrinh (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C1_MoTaQuyTrinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_MoTaQuyTrinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_MoTaQuyTrinh").Value;
                query = query.Where(d=>d.PhanBon_C1_MoTaQuyTrinh == keyword);
            }

			//Query PhanBon_C1_NoiNhanMau (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C1_NoiNhanMau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_NoiNhanMau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_NoiNhanMau").Value;
                query = query.Where(d=>d.PhanBon_C1_NoiNhanMau == keyword);
            }

			//Query PhanBon_C1_DanSoChonMau (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C1_DanSoChonMau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_DanSoChonMau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_DanSoChonMau").Value;
                query = query.Where(d=>d.PhanBon_C1_DanSoChonMau == keyword);
            }

			//Query PhanBon_C1_CoMauNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C1_CoMauNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_CoMauNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_CoMauNghienCuu").Value;
                query = query.Where(d=>d.PhanBon_C1_CoMauNghienCuu == keyword);
            }

			//Query PhanBon_C1_TieuChuanNhanVao (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C1_TieuChuanNhanVao") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_TieuChuanNhanVao").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_TieuChuanNhanVao").Value;
                query = query.Where(d=>d.PhanBon_C1_TieuChuanNhanVao == keyword);
            }

			//Query PhanBon_C1_TieuChuanLoaiRa (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C1_TieuChuanLoaiRa") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_TieuChuanLoaiRa").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C1_TieuChuanLoaiRa").Value;
                query = query.Where(d=>d.PhanBon_C1_TieuChuanLoaiRa == keyword);
            }

			//Query PhanBon_C2_MoTaQuyTrinh (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C2_MoTaQuyTrinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C2_MoTaQuyTrinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C2_MoTaQuyTrinh").Value;
                query = query.Where(d=>d.PhanBon_C2_MoTaQuyTrinh == keyword);
            }

			//Query PhanBon_C2_CachTienHanh (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C2_CachTienHanh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C2_CachTienHanh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C2_CachTienHanh").Value;
                query = query.Where(d=>d.PhanBon_C2_CachTienHanh == keyword);
            }

			//Query PhanBon_C3_MoTaQuyTrinh (string)
			if (QueryStrings.Any(d => d.Key == "PhanBon_C3_MoTaQuyTrinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C3_MoTaQuyTrinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanBon_C3_MoTaQuyTrinh").Value;
                query = query.Where(d=>d.PhanBon_C3_MoTaQuyTrinh == keyword);
            }

			//Query PhanNam_JSON (string)
			if (QueryStrings.Any(d => d.Key == "PhanNam_JSON") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanNam_JSON").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanNam_JSON").Value;
                query = query.Where(d=>d.PhanNam_JSON == keyword);
            }

			//Query ThoiGianTienHanh_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianTienHanh_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanh_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanh_Ngay").Value;
                query = query.Where(d=>d.ThoiGianTienHanh_Ngay == keyword);
            }

			//Query ThoiGianTienHanh_Thang (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianTienHanh_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanh_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanh_Thang").Value;
                query = query.Where(d=>d.ThoiGianTienHanh_Thang == keyword);
            }

			//Query ThoiGianTienHanh_Nam (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianTienHanh_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanh_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanh_Nam").Value;
                query = query.Where(d=>d.ThoiGianTienHanh_Nam == keyword);
            }

			//Query ThoiGianThuThap_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThuThap_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThap_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThap_Ngay").Value;
                query = query.Where(d=>d.ThoiGianThuThap_Ngay == keyword);
            }

			//Query ThoiGianThuThap_Thang (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThuThap_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThap_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThap_Thang").Value;
                query = query.Where(d=>d.ThoiGianThuThap_Thang == keyword);
            }

			//Query ThoiGianThuThap_Nam (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThuThap_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThap_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThap_Nam").Value;
                query = query.Where(d=>d.ThoiGianThuThap_Nam == keyword);
            }

			//Query ThoiGianNghienCuu_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuu_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu_Ngay").Value;
                query = query.Where(d=>d.ThoiGianNghienCuu_Ngay == keyword);
            }

			//Query ThoiGianNghienCuu_Thang (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuu_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu_Thang").Value;
                query = query.Where(d=>d.ThoiGianNghienCuu_Thang == keyword);
            }

			//Query ThoiGianNghienCuu_Nam (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuu_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu_Nam").Value;
                query = query.Where(d=>d.ThoiGianNghienCuu_Nam == keyword);
            }

			//Query JSON_NCVKhac (string)
			if (QueryStrings.Any(d => d.Key == "JSON_NCVKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_NCVKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_NCVKhac").Value;
                query = query.Where(d=>d.JSON_NCVKhac == keyword);
            }

			//Query DaGuiThuDienTu (bool)
			if (QueryStrings.Any(d => d.Key == "DaGuiThuDienTu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DaGuiThuDienTu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DaGuiThuDienTu);
            }

			//Query JSON_MoTaNCYSH (string)
			if (QueryStrings.Any(d => d.Key == "JSON_MoTaNCYSH") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_MoTaNCYSH").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_MoTaNCYSH").Value;
                query = query.Where(d=>d.JSON_MoTaNCYSH == keyword);
            }

			//Query PhanSau_NCYSH_KhongThuocPhamVi (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NCYSH_KhongThuocPhamVi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_KhongThuocPhamVi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_NCYSH_KhongThuocPhamVi);
            }

			//Query PhanSau_NCYSH_DuDieuKienXemXet (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NCYSH_DuDieuKienXemXet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_DuDieuKienXemXet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_NCYSH_DuDieuKienXemXet);
            }

			//Query PhanSau_NCYSH_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NCYSH_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_HoTen").Value;
                query = query.Where(d=>d.PhanSau_NCYSH_HoTen == keyword);
            }

			//Query PhanSau_NCYSH_NgayThangNam (string)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NCYSH_NgayThangNam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_NgayThangNam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_NgayThangNam").Value;
                query = query.Where(d=>d.PhanSau_NCYSH_NgayThangNam == keyword);
            }

			//Query PhanSau_NCYSH_GuiThongBao_KHTH (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NCYSH_GuiThongBao_KHTH"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_GuiThongBao_KHTH").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_NCYSH_GuiThongBao_KHTH);
            }

			//Query PhanSau_NCYSH_GuiThongBao_TCKT (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NCYSH_GuiThongBao_TCKT"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NCYSH_GuiThongBao_TCKT").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_NCYSH_GuiThongBao_TCKT);
            }

			//Query PhanSau_NGS_KhongThuocPhamVi (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NGS_KhongThuocPhamVi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NGS_KhongThuocPhamVi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_NGS_KhongThuocPhamVi);
            }

			//Query PhanSau_NGS_DuDieuKienXemXet (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NGS_DuDieuKienXemXet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NGS_DuDieuKienXemXet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_NGS_DuDieuKienXemXet);
            }

			//Query PhanSau_NGS_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NGS_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NGS_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NGS_HoTen").Value;
                query = query.Where(d=>d.PhanSau_NGS_HoTen == keyword);
            }

			//Query PhanSau_NGS_NgayThangNam (string)
			if (QueryStrings.Any(d => d.Key == "PhanSau_NGS_NgayThangNam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NGS_NgayThangNam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_NGS_NgayThangNam").Value;
                query = query.Where(d=>d.PhanSau_NGS_NgayThangNam == keyword);
            }

			//Query PhanSau_TruongKhoa_KhongThuocPhamVi (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_TruongKhoa_KhongThuocPhamVi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_KhongThuocPhamVi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_TruongKhoa_KhongThuocPhamVi);
            }

			//Query PhanSau_TruongKhoa_DuDieuKienXemXet (bool)
			if (QueryStrings.Any(d => d.Key == "PhanSau_TruongKhoa_DuDieuKienXemXet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_DuDieuKienXemXet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanSau_TruongKhoa_DuDieuKienXemXet);
            }

			//Query PhanSau_TruongKhoa_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "PhanSau_TruongKhoa_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_HoTen").Value;
                query = query.Where(d=>d.PhanSau_TruongKhoa_HoTen == keyword);
            }

			//Query PhanSau_TruongKhoa_ChucVu (string)
			if (QueryStrings.Any(d => d.Key == "PhanSau_TruongKhoa_ChucVu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_ChucVu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_ChucVu").Value;
                query = query.Where(d=>d.PhanSau_TruongKhoa_ChucVu == keyword);
            }

			//Query PhanSau_TruongKhoa_NgayThangNam (string)
			if (QueryStrings.Any(d => d.Key == "PhanSau_TruongKhoa_NgayThangNam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_NgayThangNam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanSau_TruongKhoa_NgayThangNam").Value;
                query = query.Where(d=>d.PhanSau_TruongKhoa_NgayThangNam == keyword);
            }

			//Query YKienHDDD_KhongThuocPhamVi (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_KhongThuocPhamVi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_KhongThuocPhamVi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_KhongThuocPhamVi);
            }

			//Query YKienHDDD_DuocXemXetDaoDuc (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_DuocXemXetDaoDuc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_DuocXemXetDaoDuc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_DuocXemXetDaoDuc);
            }

			//Query YKienHDDD_DuocXemXetDaoDucRutGon (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_DuocXemXetDaoDucRutGon"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_DuocXemXetDaoDucRutGon").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_DuocXemXetDaoDucRutGon);
            }

			//Query YKienHDDD_CanDuocHoiDongXemXet (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_CanDuocHoiDongXemXet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_CanDuocHoiDongXemXet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_CanDuocHoiDongXemXet);
            }

			//Query YKienHDDD_NhanXet (string)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_NhanXet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_NhanXet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_NhanXet").Value;
                query = query.Where(d=>d.YKienHDDD_NhanXet == keyword);
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

			//Query YKienHDDD_So (string)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_So") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_So").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_So").Value;
                query = query.Where(d=>d.YKienHDDD_So == keyword);
            }

			//Query NgayKy_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "NgayKy_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_Ngay").Value;
                query = query.Where(d=>d.NgayKy_Ngay == keyword);
            }

			//Query NgayKy_Thang (string)
			if (QueryStrings.Any(d => d.Key == "NgayKy_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_Thang").Value;
                query = query.Where(d=>d.NgayKy_Thang == keyword);
            }

			//Query NgayKy_Nam (string)
			if (QueryStrings.Any(d => d.Key == "NgayKy_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_Nam").Value;
                query = query.Where(d=>d.NgayKy_Nam == keyword);
            }

			//Query PhanSau_NCYSH_KhongThuocPhamVi_Co (Nullable<bool>)

			//Query PhanSau_NCYSH_KhongThuocPhamVi_Khong (Nullable<bool>)

			//Query PhanSau_NCYSH_GuiThongBao_KHTH_Co (Nullable<bool>)

			//Query PhanSau_NCYSH_GuiThongBao_KHTH_Khong (Nullable<bool>)

			//Query PhanSau_NCYSH_GuiThongBao_TCKT_Co (Nullable<bool>)

			//Query PhanSau_NCYSH_GuiThongBao_TCKT_Khong (Nullable<bool>)

			//Query PhanSau_NGS_KhongThuocPhamVi_Co (Nullable<bool>)

			//Query PhanSau_NGS_KhongThuocPhamVi_Khong (Nullable<bool>)

			//Query PhanSau_TruongKhoa_KhongThuocPhamVi_Co (Nullable<bool>)

			//Query PhanSau_TruongKhoa_KhongThuocPhamVi_Khong (Nullable<bool>)

			//Query ThoiGianTienHanhDenNgay_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianTienHanhDenNgay_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanhDenNgay_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanhDenNgay_Ngay").Value;
                query = query.Where(d=>d.ThoiGianTienHanhDenNgay_Ngay == keyword);
            }

			//Query ThoiGianTienHanhDenNgay_Thang (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianTienHanhDenNgay_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanhDenNgay_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanhDenNgay_Thang").Value;
                query = query.Where(d=>d.ThoiGianTienHanhDenNgay_Thang == keyword);
            }

			//Query ThoiGianTienHanhDenNgay_Nam (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianTienHanhDenNgay_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanhDenNgay_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTienHanhDenNgay_Nam").Value;
                query = query.Where(d=>d.ThoiGianTienHanhDenNgay_Nam == keyword);
            }

			//Query ThoiGianThuThapDenNgay_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThuThapDenNgay_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThapDenNgay_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThapDenNgay_Ngay").Value;
                query = query.Where(d=>d.ThoiGianThuThapDenNgay_Ngay == keyword);
            }

			//Query ThoiGianThuThapDenNgay_Thang (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThuThapDenNgay_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThapDenNgay_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThapDenNgay_Thang").Value;
                query = query.Where(d=>d.ThoiGianThuThapDenNgay_Thang == keyword);
            }

			//Query ThoiGianThuThapDenNgay_Nam (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianThuThapDenNgay_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThapDenNgay_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianThuThapDenNgay_Nam").Value;
                query = query.Where(d=>d.ThoiGianThuThapDenNgay_Nam == keyword);
            }

			//Query ThoiGianNghienCuuDenNgay_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuuDenNgay_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuuDenNgay_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuuDenNgay_Ngay").Value;
                query = query.Where(d=>d.ThoiGianNghienCuuDenNgay_Ngay == keyword);
            }

			//Query ThoiGianNghienCuuDenNgay_Thang (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuuDenNgay_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuuDenNgay_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuuDenNgay_Thang").Value;
                query = query.Where(d=>d.ThoiGianNghienCuuDenNgay_Thang == keyword);
            }

			//Query ThoiGianNghienCuuDenNgay_Nam (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuuDenNgay_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuuDenNgay_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuuDenNgay_Nam").Value;
                query = query.Where(d=>d.ThoiGianNghienCuuDenNgay_Nam == keyword);
            }

			//Query FormConfig (string)
			if (QueryStrings.Any(d => d.Key == "FormConfig") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value;
                query = query.Where(d=>d.FormConfig == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_BangKiemLuaChonQuyTrinhXXDD get_PRO_BangKiemLuaChonQuyTrinhXXDD(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_BangKiemLuaChonQuyTrinhXXDD(AppEntities db, int ID, DTO_PRO_BangKiemLuaChonQuyTrinhXXDD item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.MaSo = item.MaSo;							
				dbitem.PhanMot_ConNguoi = item.PhanMot_ConNguoi;							
				dbitem.PhanMot_DongVat = item.PhanMot_DongVat;							
				dbitem.PhanHai_TenNCYSH = item.PhanHai_TenNCYSH;							
				dbitem.PhanHai_NCVChinh_HoTen = item.PhanHai_NCVChinh_HoTen;							
				dbitem.PhanHai_NCVChinh_KhoaPhong = item.PhanHai_NCVChinh_KhoaPhong;							
				dbitem.PhanHai_NCVChinh_BenhVien = item.PhanHai_NCVChinh_BenhVien;							
				dbitem.PhanHai_NCVChinh_DienThoai = item.PhanHai_NCVChinh_DienThoai;							
				dbitem.PhanHai_NCVChinh_Email = item.PhanHai_NCVChinh_Email;							
				dbitem.PhanHai_NCVChinh_DiaChiLienHe = item.PhanHai_NCVChinh_DiaChiLienHe;							
				dbitem.PhanHai_NGS_HoTen = item.PhanHai_NGS_HoTen;							
				dbitem.PhanHai_NGS_NoiLamViec = item.PhanHai_NGS_NoiLamViec;							
				dbitem.PhanHai_NGS_DienThoai = item.PhanHai_NGS_DienThoai;							
				dbitem.PhanHai_NGS_Email = item.PhanHai_NGS_Email;							
				dbitem.PhanBa_A_JSON = item.PhanBa_A_JSON;							
				dbitem.PhanBa_B_JSON = item.PhanBa_B_JSON;							
				dbitem.PhanBon_C1_MoTaQuyTrinh = item.PhanBon_C1_MoTaQuyTrinh;							
				dbitem.PhanBon_C1_NoiNhanMau = item.PhanBon_C1_NoiNhanMau;							
				dbitem.PhanBon_C1_DanSoChonMau = item.PhanBon_C1_DanSoChonMau;							
				dbitem.PhanBon_C1_CoMauNghienCuu = item.PhanBon_C1_CoMauNghienCuu;							
				dbitem.PhanBon_C1_TieuChuanNhanVao = item.PhanBon_C1_TieuChuanNhanVao;							
				dbitem.PhanBon_C1_TieuChuanLoaiRa = item.PhanBon_C1_TieuChuanLoaiRa;							
				dbitem.PhanBon_C2_MoTaQuyTrinh = item.PhanBon_C2_MoTaQuyTrinh;							
				dbitem.PhanBon_C2_CachTienHanh = item.PhanBon_C2_CachTienHanh;							
				dbitem.PhanBon_C3_MoTaQuyTrinh = item.PhanBon_C3_MoTaQuyTrinh;							
				dbitem.PhanNam_JSON = item.PhanNam_JSON;							
				dbitem.ThoiGianTienHanh_Ngay = item.ThoiGianTienHanh_Ngay;							
				dbitem.ThoiGianTienHanh_Thang = item.ThoiGianTienHanh_Thang;							
				dbitem.ThoiGianTienHanh_Nam = item.ThoiGianTienHanh_Nam;							
				dbitem.ThoiGianThuThap_Ngay = item.ThoiGianThuThap_Ngay;							
				dbitem.ThoiGianThuThap_Thang = item.ThoiGianThuThap_Thang;							
				dbitem.ThoiGianThuThap_Nam = item.ThoiGianThuThap_Nam;							
				dbitem.ThoiGianNghienCuu_Ngay = item.ThoiGianNghienCuu_Ngay;							
				dbitem.ThoiGianNghienCuu_Thang = item.ThoiGianNghienCuu_Thang;							
				dbitem.ThoiGianNghienCuu_Nam = item.ThoiGianNghienCuu_Nam;							
				dbitem.JSON_NCVKhac = item.JSON_NCVKhac;							
				dbitem.DaGuiThuDienTu = item.DaGuiThuDienTu;							
				dbitem.JSON_MoTaNCYSH = item.JSON_MoTaNCYSH;							
				dbitem.PhanSau_NCYSH_KhongThuocPhamVi = item.PhanSau_NCYSH_KhongThuocPhamVi;							
				dbitem.PhanSau_NCYSH_DuDieuKienXemXet = item.PhanSau_NCYSH_DuDieuKienXemXet;							
				dbitem.PhanSau_NCYSH_HoTen = item.PhanSau_NCYSH_HoTen;							
				dbitem.PhanSau_NCYSH_NgayThangNam = item.PhanSau_NCYSH_NgayThangNam;							
				dbitem.PhanSau_NCYSH_GuiThongBao_KHTH = item.PhanSau_NCYSH_GuiThongBao_KHTH;							
				dbitem.PhanSau_NCYSH_GuiThongBao_TCKT = item.PhanSau_NCYSH_GuiThongBao_TCKT;							
				dbitem.PhanSau_NGS_KhongThuocPhamVi = item.PhanSau_NGS_KhongThuocPhamVi;							
				dbitem.PhanSau_NGS_DuDieuKienXemXet = item.PhanSau_NGS_DuDieuKienXemXet;							
				dbitem.PhanSau_NGS_HoTen = item.PhanSau_NGS_HoTen;							
				dbitem.PhanSau_NGS_NgayThangNam = item.PhanSau_NGS_NgayThangNam;							
				dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi = item.PhanSau_TruongKhoa_KhongThuocPhamVi;							
				dbitem.PhanSau_TruongKhoa_DuDieuKienXemXet = item.PhanSau_TruongKhoa_DuDieuKienXemXet;							
				dbitem.PhanSau_TruongKhoa_HoTen = item.PhanSau_TruongKhoa_HoTen;							
				dbitem.PhanSau_TruongKhoa_ChucVu = item.PhanSau_TruongKhoa_ChucVu;							
				dbitem.PhanSau_TruongKhoa_NgayThangNam = item.PhanSau_TruongKhoa_NgayThangNam;							
				dbitem.YKienHDDD_KhongThuocPhamVi = item.YKienHDDD_KhongThuocPhamVi;							
				dbitem.YKienHDDD_DuocXemXetDaoDuc = item.YKienHDDD_DuocXemXetDaoDuc;							
				dbitem.YKienHDDD_DuocXemXetDaoDucRutGon = item.YKienHDDD_DuocXemXetDaoDucRutGon;							
				dbitem.YKienHDDD_CanDuocHoiDongXemXet = item.YKienHDDD_CanDuocHoiDongXemXet;							
				dbitem.YKienHDDD_NhanXet = item.YKienHDDD_NhanXet;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.YKienHDDD_So = item.YKienHDDD_So;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.PhanSau_NCYSH_KhongThuocPhamVi_Co = item.PhanSau_NCYSH_KhongThuocPhamVi_Co;							
				dbitem.PhanSau_NCYSH_KhongThuocPhamVi_Khong = item.PhanSau_NCYSH_KhongThuocPhamVi_Khong;							
				dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Co = item.PhanSau_NCYSH_GuiThongBao_KHTH_Co;							
				dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Khong = item.PhanSau_NCYSH_GuiThongBao_KHTH_Khong;							
				dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Co = item.PhanSau_NCYSH_GuiThongBao_TCKT_Co;							
				dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Khong = item.PhanSau_NCYSH_GuiThongBao_TCKT_Khong;							
				dbitem.PhanSau_NGS_KhongThuocPhamVi_Co = item.PhanSau_NGS_KhongThuocPhamVi_Co;							
				dbitem.PhanSau_NGS_KhongThuocPhamVi_Khong = item.PhanSau_NGS_KhongThuocPhamVi_Khong;							
				dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi_Co = item.PhanSau_TruongKhoa_KhongThuocPhamVi_Co;							
				dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong = item.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong;							
				dbitem.ThoiGianTienHanhDenNgay_Ngay = item.ThoiGianTienHanhDenNgay_Ngay;							
				dbitem.ThoiGianTienHanhDenNgay_Thang = item.ThoiGianTienHanhDenNgay_Thang;							
				dbitem.ThoiGianTienHanhDenNgay_Nam = item.ThoiGianTienHanhDenNgay_Nam;							
				dbitem.ThoiGianThuThapDenNgay_Ngay = item.ThoiGianThuThapDenNgay_Ngay;							
				dbitem.ThoiGianThuThapDenNgay_Thang = item.ThoiGianThuThapDenNgay_Thang;							
				dbitem.ThoiGianThuThapDenNgay_Nam = item.ThoiGianThuThapDenNgay_Nam;							
				dbitem.ThoiGianNghienCuuDenNgay_Ngay = item.ThoiGianNghienCuuDenNgay_Ngay;							
				dbitem.ThoiGianNghienCuuDenNgay_Thang = item.ThoiGianNghienCuuDenNgay_Thang;							
				dbitem.ThoiGianNghienCuuDenNgay_Nam = item.ThoiGianNghienCuuDenNgay_Nam;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKiemLuaChonQuyTrinhXXDD", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_BangKiemLuaChonQuyTrinhXXDD",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_BangKiemLuaChonQuyTrinhXXDD post_PRO_BangKiemLuaChonQuyTrinhXXDD(AppEntities db, DTO_PRO_BangKiemLuaChonQuyTrinhXXDD item, string Username)
        {
            tbl_PRO_BangKiemLuaChonQuyTrinhXXDD dbitem = new tbl_PRO_BangKiemLuaChonQuyTrinhXXDD();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.MaSo = item.MaSo;							
				dbitem.PhanMot_ConNguoi = item.PhanMot_ConNguoi;							
				dbitem.PhanMot_DongVat = item.PhanMot_DongVat;							
				dbitem.PhanHai_TenNCYSH = item.PhanHai_TenNCYSH;							
				dbitem.PhanHai_NCVChinh_HoTen = item.PhanHai_NCVChinh_HoTen;							
				dbitem.PhanHai_NCVChinh_KhoaPhong = item.PhanHai_NCVChinh_KhoaPhong;							
				dbitem.PhanHai_NCVChinh_BenhVien = item.PhanHai_NCVChinh_BenhVien;							
				dbitem.PhanHai_NCVChinh_DienThoai = item.PhanHai_NCVChinh_DienThoai;							
				dbitem.PhanHai_NCVChinh_Email = item.PhanHai_NCVChinh_Email;							
				dbitem.PhanHai_NCVChinh_DiaChiLienHe = item.PhanHai_NCVChinh_DiaChiLienHe;							
				dbitem.PhanHai_NGS_HoTen = item.PhanHai_NGS_HoTen;							
				dbitem.PhanHai_NGS_NoiLamViec = item.PhanHai_NGS_NoiLamViec;							
				dbitem.PhanHai_NGS_DienThoai = item.PhanHai_NGS_DienThoai;							
				dbitem.PhanHai_NGS_Email = item.PhanHai_NGS_Email;							
				dbitem.PhanBa_A_JSON = item.PhanBa_A_JSON;							
				dbitem.PhanBa_B_JSON = item.PhanBa_B_JSON;							
				dbitem.PhanBon_C1_MoTaQuyTrinh = item.PhanBon_C1_MoTaQuyTrinh;							
				dbitem.PhanBon_C1_NoiNhanMau = item.PhanBon_C1_NoiNhanMau;							
				dbitem.PhanBon_C1_DanSoChonMau = item.PhanBon_C1_DanSoChonMau;							
				dbitem.PhanBon_C1_CoMauNghienCuu = item.PhanBon_C1_CoMauNghienCuu;							
				dbitem.PhanBon_C1_TieuChuanNhanVao = item.PhanBon_C1_TieuChuanNhanVao;							
				dbitem.PhanBon_C1_TieuChuanLoaiRa = item.PhanBon_C1_TieuChuanLoaiRa;							
				dbitem.PhanBon_C2_MoTaQuyTrinh = item.PhanBon_C2_MoTaQuyTrinh;							
				dbitem.PhanBon_C2_CachTienHanh = item.PhanBon_C2_CachTienHanh;							
				dbitem.PhanBon_C3_MoTaQuyTrinh = item.PhanBon_C3_MoTaQuyTrinh;							
				dbitem.PhanNam_JSON = item.PhanNam_JSON;							
				dbitem.ThoiGianTienHanh_Ngay = item.ThoiGianTienHanh_Ngay;							
				dbitem.ThoiGianTienHanh_Thang = item.ThoiGianTienHanh_Thang;							
				dbitem.ThoiGianTienHanh_Nam = item.ThoiGianTienHanh_Nam;							
				dbitem.ThoiGianThuThap_Ngay = item.ThoiGianThuThap_Ngay;							
				dbitem.ThoiGianThuThap_Thang = item.ThoiGianThuThap_Thang;							
				dbitem.ThoiGianThuThap_Nam = item.ThoiGianThuThap_Nam;							
				dbitem.ThoiGianNghienCuu_Ngay = item.ThoiGianNghienCuu_Ngay;							
				dbitem.ThoiGianNghienCuu_Thang = item.ThoiGianNghienCuu_Thang;							
				dbitem.ThoiGianNghienCuu_Nam = item.ThoiGianNghienCuu_Nam;							
				dbitem.JSON_NCVKhac = item.JSON_NCVKhac;							
				dbitem.DaGuiThuDienTu = item.DaGuiThuDienTu;							
				dbitem.JSON_MoTaNCYSH = item.JSON_MoTaNCYSH;							
				dbitem.PhanSau_NCYSH_KhongThuocPhamVi = item.PhanSau_NCYSH_KhongThuocPhamVi;							
				dbitem.PhanSau_NCYSH_DuDieuKienXemXet = item.PhanSau_NCYSH_DuDieuKienXemXet;							
				dbitem.PhanSau_NCYSH_HoTen = item.PhanSau_NCYSH_HoTen;							
				dbitem.PhanSau_NCYSH_NgayThangNam = item.PhanSau_NCYSH_NgayThangNam;							
				dbitem.PhanSau_NCYSH_GuiThongBao_KHTH = item.PhanSau_NCYSH_GuiThongBao_KHTH;							
				dbitem.PhanSau_NCYSH_GuiThongBao_TCKT = item.PhanSau_NCYSH_GuiThongBao_TCKT;							
				dbitem.PhanSau_NGS_KhongThuocPhamVi = item.PhanSau_NGS_KhongThuocPhamVi;							
				dbitem.PhanSau_NGS_DuDieuKienXemXet = item.PhanSau_NGS_DuDieuKienXemXet;							
				dbitem.PhanSau_NGS_HoTen = item.PhanSau_NGS_HoTen;							
				dbitem.PhanSau_NGS_NgayThangNam = item.PhanSau_NGS_NgayThangNam;							
				dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi = item.PhanSau_TruongKhoa_KhongThuocPhamVi;							
				dbitem.PhanSau_TruongKhoa_DuDieuKienXemXet = item.PhanSau_TruongKhoa_DuDieuKienXemXet;							
				dbitem.PhanSau_TruongKhoa_HoTen = item.PhanSau_TruongKhoa_HoTen;							
				dbitem.PhanSau_TruongKhoa_ChucVu = item.PhanSau_TruongKhoa_ChucVu;							
				dbitem.PhanSau_TruongKhoa_NgayThangNam = item.PhanSau_TruongKhoa_NgayThangNam;							
				dbitem.YKienHDDD_KhongThuocPhamVi = item.YKienHDDD_KhongThuocPhamVi;							
				dbitem.YKienHDDD_DuocXemXetDaoDuc = item.YKienHDDD_DuocXemXetDaoDuc;							
				dbitem.YKienHDDD_DuocXemXetDaoDucRutGon = item.YKienHDDD_DuocXemXetDaoDucRutGon;							
				dbitem.YKienHDDD_CanDuocHoiDongXemXet = item.YKienHDDD_CanDuocHoiDongXemXet;							
				dbitem.YKienHDDD_NhanXet = item.YKienHDDD_NhanXet;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.YKienHDDD_So = item.YKienHDDD_So;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.PhanSau_NCYSH_KhongThuocPhamVi_Co = item.PhanSau_NCYSH_KhongThuocPhamVi_Co;							
				dbitem.PhanSau_NCYSH_KhongThuocPhamVi_Khong = item.PhanSau_NCYSH_KhongThuocPhamVi_Khong;							
				dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Co = item.PhanSau_NCYSH_GuiThongBao_KHTH_Co;							
				dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Khong = item.PhanSau_NCYSH_GuiThongBao_KHTH_Khong;							
				dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Co = item.PhanSau_NCYSH_GuiThongBao_TCKT_Co;							
				dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Khong = item.PhanSau_NCYSH_GuiThongBao_TCKT_Khong;							
				dbitem.PhanSau_NGS_KhongThuocPhamVi_Co = item.PhanSau_NGS_KhongThuocPhamVi_Co;							
				dbitem.PhanSau_NGS_KhongThuocPhamVi_Khong = item.PhanSau_NGS_KhongThuocPhamVi_Khong;							
				dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi_Co = item.PhanSau_TruongKhoa_KhongThuocPhamVi_Co;							
				dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong = item.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong;							
				dbitem.ThoiGianTienHanhDenNgay_Ngay = item.ThoiGianTienHanhDenNgay_Ngay;							
				dbitem.ThoiGianTienHanhDenNgay_Thang = item.ThoiGianTienHanhDenNgay_Thang;							
				dbitem.ThoiGianTienHanhDenNgay_Nam = item.ThoiGianTienHanhDenNgay_Nam;							
				dbitem.ThoiGianThuThapDenNgay_Ngay = item.ThoiGianThuThapDenNgay_Ngay;							
				dbitem.ThoiGianThuThapDenNgay_Thang = item.ThoiGianThuThapDenNgay_Thang;							
				dbitem.ThoiGianThuThapDenNgay_Nam = item.ThoiGianThuThapDenNgay_Nam;							
				dbitem.ThoiGianNghienCuuDenNgay_Ngay = item.ThoiGianNghienCuuDenNgay_Ngay;							
				dbitem.ThoiGianNghienCuuDenNgay_Thang = item.ThoiGianNghienCuuDenNgay_Thang;							
				dbitem.ThoiGianNghienCuuDenNgay_Nam = item.ThoiGianNghienCuuDenNgay_Nam;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKiemLuaChonQuyTrinhXXDD", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_BangKiemLuaChonQuyTrinhXXDD",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_BangKiemLuaChonQuyTrinhXXDD(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKiemLuaChonQuyTrinhXXDD", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_BangKiemLuaChonQuyTrinhXXDD",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_BangKiemLuaChonQuyTrinhXXDD_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Any(e => e.ID == id);
		}
		
    }

}






