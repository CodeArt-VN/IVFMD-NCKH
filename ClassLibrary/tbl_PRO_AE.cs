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
    
    
    public partial class tbl_PRO_AE
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public int IDBenhNhan { get; set; }
        public string MaSo { get; set; }
        public string MaSoBenhNhan { get; set; }
        public string TenBienCo { get; set; }
        public string NgayKhoiPhat_Ngay { get; set; }
        public string NgayKhoiPhat_Thang { get; set; }
        public string NgayKhoiPhat_Nam { get; set; }
        public string NgayKhoiPhat_Gio { get; set; }
        public string NgayKhoiPhat_Phut { get; set; }
        public bool NgayKhoiPhat_DangTiepDien { get; set; }
        public bool PhanDoNang_Nghe { get; set; }
        public bool PhanDoNang_TrungBinh { get; set; }
        public bool PhanDoNang_Nang { get; set; }
        public bool CanDieuTri_Khong { get; set; }
        public bool CanDieuTri_Co { get; set; }
        public bool HDThuocNghienCuu_KhongApDung { get; set; }
        public bool HDThuocNghienCuu_NgungSuDung { get; set; }
        public bool HDThuocDungKem_KhongApDung { get; set; }
        public bool HDThuocDungKem_NgungSuDung { get; set; }
        public bool LyDoThuocNghienCuu_Khong { get; set; }
        public bool LyDoThuocNghienCuu_Co { get; set; }
        public bool LyDoThuocDungKem_Khong { get; set; }
        public bool LyDoThuocDungKem_Co { get; set; }
        public bool KetQua_HoiPhucKhongDiChung { get; set; }
        public bool KetQua_CoDiChung { get; set; }
        public bool KetQua_DangHoiPhuc { get; set; }
        public bool KetQua_ChuaHoiPhuc { get; set; }
        public bool KetQua_KhongBiet { get; set; }
        public string KetQua_TuVong_Ngay { get; set; }
        public string KetQua_TuVong_Thang { get; set; }
        public string KetQua_TuVong_Nam { get; set; }
        public bool NghiemTrong_Khong { get; set; }
        public bool NghiemTrong_Co { get; set; }
        public bool NghiemTrong_TuVong { get; set; }
        public bool NghiemTrong_DeDoaTinhMang { get; set; }
        public bool NghiemTrong_NhapVien { get; set; }
        public bool NghiemTrong_TanTat { get; set; }
        public bool NghiemTrong_BatThuong { get; set; }
        public bool NghiemTrong_BienCoKhac { get; set; }
        public bool TienHanhSAE_Khong { get; set; }
        public bool TienHanhSAE_Co { get; set; }
        public string HoTenThucHien { get; set; }
        public string NgayBaoCao_Ngay { get; set; }
        public string NgayBaoCao_Thang { get; set; }
        public string NgayBaoCao_Nam { get; set; }
        public string NT_NgayGioTangDoNang_Ngay { get; set; }
        public string NT_NgayGioTangDoNang_Thang { get; set; }
        public string NT_NgayGioTangDoNang_Nam { get; set; }
        public string NT_NgayGioTangDoNang_Gio { get; set; }
        public string NT_NgayGioTangDoNang_Phut { get; set; }
        public bool NT_DoNangAE_Nhe { get; set; }
        public bool NT_DoNangAE_TrungBinh { get; set; }
        public bool NT_DoNangAE_Nang { get; set; }
        public bool NT_YeuCauDieuTri_Khong { get; set; }
        public bool NT_YeuCauDieuTri_Co { get; set; }
        public bool NT_HDThuocNghienCuu_KhongApDung { get; set; }
        public bool NT_HDThuocNghienCuu_NgungSuDung { get; set; }
        public bool NT_HDThuocDungKem_KhongApDung { get; set; }
        public bool NT_HDThuocDungKem_NgungSuDung { get; set; }
        public bool NT_LyDoThuocNghienCuu_Khong { get; set; }
        public bool NT_LyDoThuocNghienCuu_Co { get; set; }
        public bool NT_LyDoThuocDungKem_Khong { get; set; }
        public bool NT_LyDoThuocDungKem_Co { get; set; }
        public bool NT_NghiemTrong_Khong { get; set; }
        public bool NT_NghiemTrong_Co { get; set; }
        public bool NT_NghiemTrong_TuVong { get; set; }
        public bool NT_NghiemTrong_DeDoaTinhMang { get; set; }
        public bool NT_NghiemTrong_NhapVien { get; set; }
        public bool NT_NghiemTrong_TanTat { get; set; }
        public bool NT_NghiemTrong_BatThuong { get; set; }
        public bool NT_NghiemTrong_BienCoKhac { get; set; }
        public string NT_HoTenThucHien { get; set; }
        public string NT_NgayBaoCao_Ngay { get; set; }
        public string NT_NgayBaoCao_Thang { get; set; }
        public string NT_NgayBaoCao_Nam { get; set; }
        public string NT_GhiChu { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_CUS_HRM_BenhNhan tbl_CUS_HRM_BenhNhan { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_AE
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public int IDBenhNhan { get; set; }
		public string MaSo { get; set; }
		public string MaSoBenhNhan { get; set; }
		public string TenBienCo { get; set; }
		public string NgayKhoiPhat_Ngay { get; set; }
		public string NgayKhoiPhat_Thang { get; set; }
		public string NgayKhoiPhat_Nam { get; set; }
		public string NgayKhoiPhat_Gio { get; set; }
		public string NgayKhoiPhat_Phut { get; set; }
		public bool NgayKhoiPhat_DangTiepDien { get; set; }
		public bool PhanDoNang_Nghe { get; set; }
		public bool PhanDoNang_TrungBinh { get; set; }
		public bool PhanDoNang_Nang { get; set; }
		public bool CanDieuTri_Khong { get; set; }
		public bool CanDieuTri_Co { get; set; }
		public bool HDThuocNghienCuu_KhongApDung { get; set; }
		public bool HDThuocNghienCuu_NgungSuDung { get; set; }
		public bool HDThuocDungKem_KhongApDung { get; set; }
		public bool HDThuocDungKem_NgungSuDung { get; set; }
		public bool LyDoThuocNghienCuu_Khong { get; set; }
		public bool LyDoThuocNghienCuu_Co { get; set; }
		public bool LyDoThuocDungKem_Khong { get; set; }
		public bool LyDoThuocDungKem_Co { get; set; }
		public bool KetQua_HoiPhucKhongDiChung { get; set; }
		public bool KetQua_CoDiChung { get; set; }
		public bool KetQua_DangHoiPhuc { get; set; }
		public bool KetQua_ChuaHoiPhuc { get; set; }
		public bool KetQua_KhongBiet { get; set; }
		public string KetQua_TuVong_Ngay { get; set; }
		public string KetQua_TuVong_Thang { get; set; }
		public string KetQua_TuVong_Nam { get; set; }
		public bool NghiemTrong_Khong { get; set; }
		public bool NghiemTrong_Co { get; set; }
		public bool NghiemTrong_TuVong { get; set; }
		public bool NghiemTrong_DeDoaTinhMang { get; set; }
		public bool NghiemTrong_NhapVien { get; set; }
		public bool NghiemTrong_TanTat { get; set; }
		public bool NghiemTrong_BatThuong { get; set; }
		public bool NghiemTrong_BienCoKhac { get; set; }
		public bool TienHanhSAE_Khong { get; set; }
		public bool TienHanhSAE_Co { get; set; }
		public string HoTenThucHien { get; set; }
		public string NgayBaoCao_Ngay { get; set; }
		public string NgayBaoCao_Thang { get; set; }
		public string NgayBaoCao_Nam { get; set; }
		public string NT_NgayGioTangDoNang_Ngay { get; set; }
		public string NT_NgayGioTangDoNang_Thang { get; set; }
		public string NT_NgayGioTangDoNang_Nam { get; set; }
		public string NT_NgayGioTangDoNang_Gio { get; set; }
		public string NT_NgayGioTangDoNang_Phut { get; set; }
		public bool NT_DoNangAE_Nhe { get; set; }
		public bool NT_DoNangAE_TrungBinh { get; set; }
		public bool NT_DoNangAE_Nang { get; set; }
		public bool NT_YeuCauDieuTri_Khong { get; set; }
		public bool NT_YeuCauDieuTri_Co { get; set; }
		public bool NT_HDThuocNghienCuu_KhongApDung { get; set; }
		public bool NT_HDThuocNghienCuu_NgungSuDung { get; set; }
		public bool NT_HDThuocDungKem_KhongApDung { get; set; }
		public bool NT_HDThuocDungKem_NgungSuDung { get; set; }
		public bool NT_LyDoThuocNghienCuu_Khong { get; set; }
		public bool NT_LyDoThuocNghienCuu_Co { get; set; }
		public bool NT_LyDoThuocDungKem_Khong { get; set; }
		public bool NT_LyDoThuocDungKem_Co { get; set; }
		public bool NT_NghiemTrong_Khong { get; set; }
		public bool NT_NghiemTrong_Co { get; set; }
		public bool NT_NghiemTrong_TuVong { get; set; }
		public bool NT_NghiemTrong_DeDoaTinhMang { get; set; }
		public bool NT_NghiemTrong_NhapVien { get; set; }
		public bool NT_NghiemTrong_TanTat { get; set; }
		public bool NT_NghiemTrong_BatThuong { get; set; }
		public bool NT_NghiemTrong_BienCoKhac { get; set; }
		public string NT_HoTenThucHien { get; set; }
		public string NT_NgayBaoCao_Ngay { get; set; }
		public string NT_NgayBaoCao_Thang { get; set; }
		public string NT_NgayBaoCao_Nam { get; set; }
		public string NT_GhiChu { get; set; }
		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
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

    public static partial class BS_PRO_AE 
    {
		public static IQueryable<DTO_PRO_AE> toDTO(IQueryable<tbl_PRO_AE> query)
        {
			return query
			.Select(s => new DTO_PRO_AE(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				IDBenhNhan = s.IDBenhNhan,							
				MaSo = s.MaSo,							
				MaSoBenhNhan = s.MaSoBenhNhan,							
				TenBienCo = s.TenBienCo,							
				NgayKhoiPhat_Ngay = s.NgayKhoiPhat_Ngay,							
				NgayKhoiPhat_Thang = s.NgayKhoiPhat_Thang,							
				NgayKhoiPhat_Nam = s.NgayKhoiPhat_Nam,							
				NgayKhoiPhat_Gio = s.NgayKhoiPhat_Gio,							
				NgayKhoiPhat_Phut = s.NgayKhoiPhat_Phut,							
				NgayKhoiPhat_DangTiepDien = s.NgayKhoiPhat_DangTiepDien,							
				PhanDoNang_Nghe = s.PhanDoNang_Nghe,							
				PhanDoNang_TrungBinh = s.PhanDoNang_TrungBinh,							
				PhanDoNang_Nang = s.PhanDoNang_Nang,							
				CanDieuTri_Khong = s.CanDieuTri_Khong,							
				CanDieuTri_Co = s.CanDieuTri_Co,							
				HDThuocNghienCuu_KhongApDung = s.HDThuocNghienCuu_KhongApDung,							
				HDThuocNghienCuu_NgungSuDung = s.HDThuocNghienCuu_NgungSuDung,							
				HDThuocDungKem_KhongApDung = s.HDThuocDungKem_KhongApDung,							
				HDThuocDungKem_NgungSuDung = s.HDThuocDungKem_NgungSuDung,							
				LyDoThuocNghienCuu_Khong = s.LyDoThuocNghienCuu_Khong,							
				LyDoThuocNghienCuu_Co = s.LyDoThuocNghienCuu_Co,							
				LyDoThuocDungKem_Khong = s.LyDoThuocDungKem_Khong,							
				LyDoThuocDungKem_Co = s.LyDoThuocDungKem_Co,							
				KetQua_HoiPhucKhongDiChung = s.KetQua_HoiPhucKhongDiChung,							
				KetQua_CoDiChung = s.KetQua_CoDiChung,							
				KetQua_DangHoiPhuc = s.KetQua_DangHoiPhuc,							
				KetQua_ChuaHoiPhuc = s.KetQua_ChuaHoiPhuc,							
				KetQua_KhongBiet = s.KetQua_KhongBiet,							
				KetQua_TuVong_Ngay = s.KetQua_TuVong_Ngay,							
				KetQua_TuVong_Thang = s.KetQua_TuVong_Thang,							
				KetQua_TuVong_Nam = s.KetQua_TuVong_Nam,							
				NghiemTrong_Khong = s.NghiemTrong_Khong,							
				NghiemTrong_Co = s.NghiemTrong_Co,							
				NghiemTrong_TuVong = s.NghiemTrong_TuVong,							
				NghiemTrong_DeDoaTinhMang = s.NghiemTrong_DeDoaTinhMang,							
				NghiemTrong_NhapVien = s.NghiemTrong_NhapVien,							
				NghiemTrong_TanTat = s.NghiemTrong_TanTat,							
				NghiemTrong_BatThuong = s.NghiemTrong_BatThuong,							
				NghiemTrong_BienCoKhac = s.NghiemTrong_BienCoKhac,							
				TienHanhSAE_Khong = s.TienHanhSAE_Khong,							
				TienHanhSAE_Co = s.TienHanhSAE_Co,							
				HoTenThucHien = s.HoTenThucHien,							
				NgayBaoCao_Ngay = s.NgayBaoCao_Ngay,							
				NgayBaoCao_Thang = s.NgayBaoCao_Thang,							
				NgayBaoCao_Nam = s.NgayBaoCao_Nam,							
				NT_NgayGioTangDoNang_Ngay = s.NT_NgayGioTangDoNang_Ngay,							
				NT_NgayGioTangDoNang_Thang = s.NT_NgayGioTangDoNang_Thang,							
				NT_NgayGioTangDoNang_Nam = s.NT_NgayGioTangDoNang_Nam,							
				NT_NgayGioTangDoNang_Gio = s.NT_NgayGioTangDoNang_Gio,							
				NT_NgayGioTangDoNang_Phut = s.NT_NgayGioTangDoNang_Phut,							
				NT_DoNangAE_Nhe = s.NT_DoNangAE_Nhe,							
				NT_DoNangAE_TrungBinh = s.NT_DoNangAE_TrungBinh,							
				NT_DoNangAE_Nang = s.NT_DoNangAE_Nang,							
				NT_YeuCauDieuTri_Khong = s.NT_YeuCauDieuTri_Khong,							
				NT_YeuCauDieuTri_Co = s.NT_YeuCauDieuTri_Co,							
				NT_HDThuocNghienCuu_KhongApDung = s.NT_HDThuocNghienCuu_KhongApDung,							
				NT_HDThuocNghienCuu_NgungSuDung = s.NT_HDThuocNghienCuu_NgungSuDung,							
				NT_HDThuocDungKem_KhongApDung = s.NT_HDThuocDungKem_KhongApDung,							
				NT_HDThuocDungKem_NgungSuDung = s.NT_HDThuocDungKem_NgungSuDung,							
				NT_LyDoThuocNghienCuu_Khong = s.NT_LyDoThuocNghienCuu_Khong,							
				NT_LyDoThuocNghienCuu_Co = s.NT_LyDoThuocNghienCuu_Co,							
				NT_LyDoThuocDungKem_Khong = s.NT_LyDoThuocDungKem_Khong,							
				NT_LyDoThuocDungKem_Co = s.NT_LyDoThuocDungKem_Co,							
				NT_NghiemTrong_Khong = s.NT_NghiemTrong_Khong,							
				NT_NghiemTrong_Co = s.NT_NghiemTrong_Co,							
				NT_NghiemTrong_TuVong = s.NT_NghiemTrong_TuVong,							
				NT_NghiemTrong_DeDoaTinhMang = s.NT_NghiemTrong_DeDoaTinhMang,							
				NT_NghiemTrong_NhapVien = s.NT_NghiemTrong_NhapVien,							
				NT_NghiemTrong_TanTat = s.NT_NghiemTrong_TanTat,							
				NT_NghiemTrong_BatThuong = s.NT_NghiemTrong_BatThuong,							
				NT_NghiemTrong_BienCoKhac = s.NT_NghiemTrong_BienCoKhac,							
				NT_HoTenThucHien = s.NT_HoTenThucHien,							
				NT_NgayBaoCao_Ngay = s.NT_NgayBaoCao_Ngay,							
				NT_NgayBaoCao_Thang = s.NT_NgayBaoCao_Thang,							
				NT_NgayBaoCao_Nam = s.NT_NgayBaoCao_Nam,							
				NT_GhiChu = s.NT_GhiChu,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_AE toDTO(tbl_PRO_AE dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_AE()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					IDBenhNhan = dbResult.IDBenhNhan,							
					MaSo = dbResult.MaSo,							
					MaSoBenhNhan = dbResult.MaSoBenhNhan,							
					TenBienCo = dbResult.TenBienCo,							
					NgayKhoiPhat_Ngay = dbResult.NgayKhoiPhat_Ngay,							
					NgayKhoiPhat_Thang = dbResult.NgayKhoiPhat_Thang,							
					NgayKhoiPhat_Nam = dbResult.NgayKhoiPhat_Nam,							
					NgayKhoiPhat_Gio = dbResult.NgayKhoiPhat_Gio,							
					NgayKhoiPhat_Phut = dbResult.NgayKhoiPhat_Phut,							
					NgayKhoiPhat_DangTiepDien = dbResult.NgayKhoiPhat_DangTiepDien,							
					PhanDoNang_Nghe = dbResult.PhanDoNang_Nghe,							
					PhanDoNang_TrungBinh = dbResult.PhanDoNang_TrungBinh,							
					PhanDoNang_Nang = dbResult.PhanDoNang_Nang,							
					CanDieuTri_Khong = dbResult.CanDieuTri_Khong,							
					CanDieuTri_Co = dbResult.CanDieuTri_Co,							
					HDThuocNghienCuu_KhongApDung = dbResult.HDThuocNghienCuu_KhongApDung,							
					HDThuocNghienCuu_NgungSuDung = dbResult.HDThuocNghienCuu_NgungSuDung,							
					HDThuocDungKem_KhongApDung = dbResult.HDThuocDungKem_KhongApDung,							
					HDThuocDungKem_NgungSuDung = dbResult.HDThuocDungKem_NgungSuDung,							
					LyDoThuocNghienCuu_Khong = dbResult.LyDoThuocNghienCuu_Khong,							
					LyDoThuocNghienCuu_Co = dbResult.LyDoThuocNghienCuu_Co,							
					LyDoThuocDungKem_Khong = dbResult.LyDoThuocDungKem_Khong,							
					LyDoThuocDungKem_Co = dbResult.LyDoThuocDungKem_Co,							
					KetQua_HoiPhucKhongDiChung = dbResult.KetQua_HoiPhucKhongDiChung,							
					KetQua_CoDiChung = dbResult.KetQua_CoDiChung,							
					KetQua_DangHoiPhuc = dbResult.KetQua_DangHoiPhuc,							
					KetQua_ChuaHoiPhuc = dbResult.KetQua_ChuaHoiPhuc,							
					KetQua_KhongBiet = dbResult.KetQua_KhongBiet,							
					KetQua_TuVong_Ngay = dbResult.KetQua_TuVong_Ngay,							
					KetQua_TuVong_Thang = dbResult.KetQua_TuVong_Thang,							
					KetQua_TuVong_Nam = dbResult.KetQua_TuVong_Nam,							
					NghiemTrong_Khong = dbResult.NghiemTrong_Khong,							
					NghiemTrong_Co = dbResult.NghiemTrong_Co,							
					NghiemTrong_TuVong = dbResult.NghiemTrong_TuVong,							
					NghiemTrong_DeDoaTinhMang = dbResult.NghiemTrong_DeDoaTinhMang,							
					NghiemTrong_NhapVien = dbResult.NghiemTrong_NhapVien,							
					NghiemTrong_TanTat = dbResult.NghiemTrong_TanTat,							
					NghiemTrong_BatThuong = dbResult.NghiemTrong_BatThuong,							
					NghiemTrong_BienCoKhac = dbResult.NghiemTrong_BienCoKhac,							
					TienHanhSAE_Khong = dbResult.TienHanhSAE_Khong,							
					TienHanhSAE_Co = dbResult.TienHanhSAE_Co,							
					HoTenThucHien = dbResult.HoTenThucHien,							
					NgayBaoCao_Ngay = dbResult.NgayBaoCao_Ngay,							
					NgayBaoCao_Thang = dbResult.NgayBaoCao_Thang,							
					NgayBaoCao_Nam = dbResult.NgayBaoCao_Nam,							
					NT_NgayGioTangDoNang_Ngay = dbResult.NT_NgayGioTangDoNang_Ngay,							
					NT_NgayGioTangDoNang_Thang = dbResult.NT_NgayGioTangDoNang_Thang,							
					NT_NgayGioTangDoNang_Nam = dbResult.NT_NgayGioTangDoNang_Nam,							
					NT_NgayGioTangDoNang_Gio = dbResult.NT_NgayGioTangDoNang_Gio,							
					NT_NgayGioTangDoNang_Phut = dbResult.NT_NgayGioTangDoNang_Phut,							
					NT_DoNangAE_Nhe = dbResult.NT_DoNangAE_Nhe,							
					NT_DoNangAE_TrungBinh = dbResult.NT_DoNangAE_TrungBinh,							
					NT_DoNangAE_Nang = dbResult.NT_DoNangAE_Nang,							
					NT_YeuCauDieuTri_Khong = dbResult.NT_YeuCauDieuTri_Khong,							
					NT_YeuCauDieuTri_Co = dbResult.NT_YeuCauDieuTri_Co,							
					NT_HDThuocNghienCuu_KhongApDung = dbResult.NT_HDThuocNghienCuu_KhongApDung,							
					NT_HDThuocNghienCuu_NgungSuDung = dbResult.NT_HDThuocNghienCuu_NgungSuDung,							
					NT_HDThuocDungKem_KhongApDung = dbResult.NT_HDThuocDungKem_KhongApDung,							
					NT_HDThuocDungKem_NgungSuDung = dbResult.NT_HDThuocDungKem_NgungSuDung,							
					NT_LyDoThuocNghienCuu_Khong = dbResult.NT_LyDoThuocNghienCuu_Khong,							
					NT_LyDoThuocNghienCuu_Co = dbResult.NT_LyDoThuocNghienCuu_Co,							
					NT_LyDoThuocDungKem_Khong = dbResult.NT_LyDoThuocDungKem_Khong,							
					NT_LyDoThuocDungKem_Co = dbResult.NT_LyDoThuocDungKem_Co,							
					NT_NghiemTrong_Khong = dbResult.NT_NghiemTrong_Khong,							
					NT_NghiemTrong_Co = dbResult.NT_NghiemTrong_Co,							
					NT_NghiemTrong_TuVong = dbResult.NT_NghiemTrong_TuVong,							
					NT_NghiemTrong_DeDoaTinhMang = dbResult.NT_NghiemTrong_DeDoaTinhMang,							
					NT_NghiemTrong_NhapVien = dbResult.NT_NghiemTrong_NhapVien,							
					NT_NghiemTrong_TanTat = dbResult.NT_NghiemTrong_TanTat,							
					NT_NghiemTrong_BatThuong = dbResult.NT_NghiemTrong_BatThuong,							
					NT_NghiemTrong_BienCoKhac = dbResult.NT_NghiemTrong_BienCoKhac,							
					NT_HoTenThucHien = dbResult.NT_HoTenThucHien,							
					NT_NgayBaoCao_Ngay = dbResult.NT_NgayBaoCao_Ngay,							
					NT_NgayBaoCao_Thang = dbResult.NT_NgayBaoCao_Thang,							
					NT_NgayBaoCao_Nam = dbResult.NT_NgayBaoCao_Nam,							
					NT_GhiChu = dbResult.NT_GhiChu,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_AE> get_PRO_AE(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_AE.Where(d => d.IsDeleted == false );

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

			//Query IDBenhNhan (int)
			if (QueryStrings.Any(d => d.Key == "IDBenhNhan"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDBenhNhan").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDBenhNhan));
            }

			//Query MaSo (string)
			if (QueryStrings.Any(d => d.Key == "MaSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value;
                query = query.Where(d=>d.MaSo == keyword);
            }

			//Query MaSoBenhNhan (string)
			if (QueryStrings.Any(d => d.Key == "MaSoBenhNhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSoBenhNhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSoBenhNhan").Value;
                query = query.Where(d=>d.MaSoBenhNhan == keyword);
            }

			//Query TenBienCo (string)
			if (QueryStrings.Any(d => d.Key == "TenBienCo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenBienCo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenBienCo").Value;
                query = query.Where(d=>d.TenBienCo == keyword);
            }

			//Query NgayKhoiPhat_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "NgayKhoiPhat_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Ngay").Value;
                query = query.Where(d=>d.NgayKhoiPhat_Ngay == keyword);
            }

			//Query NgayKhoiPhat_Thang (string)
			if (QueryStrings.Any(d => d.Key == "NgayKhoiPhat_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Thang").Value;
                query = query.Where(d=>d.NgayKhoiPhat_Thang == keyword);
            }

			//Query NgayKhoiPhat_Nam (string)
			if (QueryStrings.Any(d => d.Key == "NgayKhoiPhat_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Nam").Value;
                query = query.Where(d=>d.NgayKhoiPhat_Nam == keyword);
            }

			//Query NgayKhoiPhat_Gio (string)
			if (QueryStrings.Any(d => d.Key == "NgayKhoiPhat_Gio") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Gio").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Gio").Value;
                query = query.Where(d=>d.NgayKhoiPhat_Gio == keyword);
            }

			//Query NgayKhoiPhat_Phut (string)
			if (QueryStrings.Any(d => d.Key == "NgayKhoiPhat_Phut") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Phut").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_Phut").Value;
                query = query.Where(d=>d.NgayKhoiPhat_Phut == keyword);
            }

			//Query NgayKhoiPhat_DangTiepDien (bool)
			if (QueryStrings.Any(d => d.Key == "NgayKhoiPhat_DangTiepDien"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NgayKhoiPhat_DangTiepDien").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NgayKhoiPhat_DangTiepDien);
            }

			//Query PhanDoNang_Nghe (bool)
			if (QueryStrings.Any(d => d.Key == "PhanDoNang_Nghe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanDoNang_Nghe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanDoNang_Nghe);
            }

			//Query PhanDoNang_TrungBinh (bool)
			if (QueryStrings.Any(d => d.Key == "PhanDoNang_TrungBinh"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanDoNang_TrungBinh").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanDoNang_TrungBinh);
            }

			//Query PhanDoNang_Nang (bool)
			if (QueryStrings.Any(d => d.Key == "PhanDoNang_Nang"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhanDoNang_Nang").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhanDoNang_Nang);
            }

			//Query CanDieuTri_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "CanDieuTri_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "CanDieuTri_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.CanDieuTri_Khong);
            }

			//Query CanDieuTri_Co (bool)
			if (QueryStrings.Any(d => d.Key == "CanDieuTri_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "CanDieuTri_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.CanDieuTri_Co);
            }

			//Query HDThuocNghienCuu_KhongApDung (bool)
			if (QueryStrings.Any(d => d.Key == "HDThuocNghienCuu_KhongApDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "HDThuocNghienCuu_KhongApDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.HDThuocNghienCuu_KhongApDung);
            }

			//Query HDThuocNghienCuu_NgungSuDung (bool)
			if (QueryStrings.Any(d => d.Key == "HDThuocNghienCuu_NgungSuDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "HDThuocNghienCuu_NgungSuDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.HDThuocNghienCuu_NgungSuDung);
            }

			//Query HDThuocDungKem_KhongApDung (bool)
			if (QueryStrings.Any(d => d.Key == "HDThuocDungKem_KhongApDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "HDThuocDungKem_KhongApDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.HDThuocDungKem_KhongApDung);
            }

			//Query HDThuocDungKem_NgungSuDung (bool)
			if (QueryStrings.Any(d => d.Key == "HDThuocDungKem_NgungSuDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "HDThuocDungKem_NgungSuDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.HDThuocDungKem_NgungSuDung);
            }

			//Query LyDoThuocNghienCuu_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "LyDoThuocNghienCuu_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "LyDoThuocNghienCuu_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.LyDoThuocNghienCuu_Khong);
            }

			//Query LyDoThuocNghienCuu_Co (bool)
			if (QueryStrings.Any(d => d.Key == "LyDoThuocNghienCuu_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "LyDoThuocNghienCuu_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.LyDoThuocNghienCuu_Co);
            }

			//Query LyDoThuocDungKem_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "LyDoThuocDungKem_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "LyDoThuocDungKem_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.LyDoThuocDungKem_Khong);
            }

			//Query LyDoThuocDungKem_Co (bool)
			if (QueryStrings.Any(d => d.Key == "LyDoThuocDungKem_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "LyDoThuocDungKem_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.LyDoThuocDungKem_Co);
            }

			//Query KetQua_HoiPhucKhongDiChung (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_HoiPhucKhongDiChung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_HoiPhucKhongDiChung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_HoiPhucKhongDiChung);
            }

			//Query KetQua_CoDiChung (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_CoDiChung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_CoDiChung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_CoDiChung);
            }

			//Query KetQua_DangHoiPhuc (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_DangHoiPhuc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_DangHoiPhuc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_DangHoiPhuc);
            }

			//Query KetQua_ChuaHoiPhuc (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_ChuaHoiPhuc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_ChuaHoiPhuc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_ChuaHoiPhuc);
            }

			//Query KetQua_KhongBiet (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_KhongBiet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_KhongBiet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_KhongBiet);
            }

			//Query KetQua_TuVong_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "KetQua_TuVong_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Ngay").Value;
                query = query.Where(d=>d.KetQua_TuVong_Ngay == keyword);
            }

			//Query KetQua_TuVong_Thang (string)
			if (QueryStrings.Any(d => d.Key == "KetQua_TuVong_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Thang").Value;
                query = query.Where(d=>d.KetQua_TuVong_Thang == keyword);
            }

			//Query KetQua_TuVong_Nam (string)
			if (QueryStrings.Any(d => d.Key == "KetQua_TuVong_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Nam").Value;
                query = query.Where(d=>d.KetQua_TuVong_Nam == keyword);
            }

			//Query NghiemTrong_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_Khong);
            }

			//Query NghiemTrong_Co (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_Co);
            }

			//Query NghiemTrong_TuVong (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_TuVong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_TuVong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_TuVong);
            }

			//Query NghiemTrong_DeDoaTinhMang (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_DeDoaTinhMang"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_DeDoaTinhMang").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_DeDoaTinhMang);
            }

			//Query NghiemTrong_NhapVien (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_NhapVien"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_NhapVien").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_NhapVien);
            }

			//Query NghiemTrong_TanTat (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_TanTat"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_TanTat").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_TanTat);
            }

			//Query NghiemTrong_BatThuong (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_BatThuong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_BatThuong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_BatThuong);
            }

			//Query NghiemTrong_BienCoKhac (bool)
			if (QueryStrings.Any(d => d.Key == "NghiemTrong_BienCoKhac"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghiemTrong_BienCoKhac").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghiemTrong_BienCoKhac);
            }

			//Query TienHanhSAE_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "TienHanhSAE_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "TienHanhSAE_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.TienHanhSAE_Khong);
            }

			//Query TienHanhSAE_Co (bool)
			if (QueryStrings.Any(d => d.Key == "TienHanhSAE_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "TienHanhSAE_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.TienHanhSAE_Co);
            }

			//Query HoTenThucHien (string)
			if (QueryStrings.Any(d => d.Key == "HoTenThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoTenThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoTenThucHien").Value;
                query = query.Where(d=>d.HoTenThucHien == keyword);
            }

			//Query NgayBaoCao_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "NgayBaoCao_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCao_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCao_Ngay").Value;
                query = query.Where(d=>d.NgayBaoCao_Ngay == keyword);
            }

			//Query NgayBaoCao_Thang (string)
			if (QueryStrings.Any(d => d.Key == "NgayBaoCao_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCao_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCao_Thang").Value;
                query = query.Where(d=>d.NgayBaoCao_Thang == keyword);
            }

			//Query NgayBaoCao_Nam (string)
			if (QueryStrings.Any(d => d.Key == "NgayBaoCao_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCao_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCao_Nam").Value;
                query = query.Where(d=>d.NgayBaoCao_Nam == keyword);
            }

			//Query NT_NgayGioTangDoNang_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayGioTangDoNang_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Ngay").Value;
                query = query.Where(d=>d.NT_NgayGioTangDoNang_Ngay == keyword);
            }

			//Query NT_NgayGioTangDoNang_Thang (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayGioTangDoNang_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Thang").Value;
                query = query.Where(d=>d.NT_NgayGioTangDoNang_Thang == keyword);
            }

			//Query NT_NgayGioTangDoNang_Nam (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayGioTangDoNang_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Nam").Value;
                query = query.Where(d=>d.NT_NgayGioTangDoNang_Nam == keyword);
            }

			//Query NT_NgayGioTangDoNang_Gio (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayGioTangDoNang_Gio") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Gio").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Gio").Value;
                query = query.Where(d=>d.NT_NgayGioTangDoNang_Gio == keyword);
            }

			//Query NT_NgayGioTangDoNang_Phut (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayGioTangDoNang_Phut") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Phut").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayGioTangDoNang_Phut").Value;
                query = query.Where(d=>d.NT_NgayGioTangDoNang_Phut == keyword);
            }

			//Query NT_DoNangAE_Nhe (bool)
			if (QueryStrings.Any(d => d.Key == "NT_DoNangAE_Nhe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_DoNangAE_Nhe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_DoNangAE_Nhe);
            }

			//Query NT_DoNangAE_TrungBinh (bool)
			if (QueryStrings.Any(d => d.Key == "NT_DoNangAE_TrungBinh"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_DoNangAE_TrungBinh").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_DoNangAE_TrungBinh);
            }

			//Query NT_DoNangAE_Nang (bool)
			if (QueryStrings.Any(d => d.Key == "NT_DoNangAE_Nang"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_DoNangAE_Nang").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_DoNangAE_Nang);
            }

			//Query NT_YeuCauDieuTri_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "NT_YeuCauDieuTri_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_YeuCauDieuTri_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_YeuCauDieuTri_Khong);
            }

			//Query NT_YeuCauDieuTri_Co (bool)
			if (QueryStrings.Any(d => d.Key == "NT_YeuCauDieuTri_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_YeuCauDieuTri_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_YeuCauDieuTri_Co);
            }

			//Query NT_HDThuocNghienCuu_KhongApDung (bool)
			if (QueryStrings.Any(d => d.Key == "NT_HDThuocNghienCuu_KhongApDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_HDThuocNghienCuu_KhongApDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_HDThuocNghienCuu_KhongApDung);
            }

			//Query NT_HDThuocNghienCuu_NgungSuDung (bool)
			if (QueryStrings.Any(d => d.Key == "NT_HDThuocNghienCuu_NgungSuDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_HDThuocNghienCuu_NgungSuDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_HDThuocNghienCuu_NgungSuDung);
            }

			//Query NT_HDThuocDungKem_KhongApDung (bool)
			if (QueryStrings.Any(d => d.Key == "NT_HDThuocDungKem_KhongApDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_HDThuocDungKem_KhongApDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_HDThuocDungKem_KhongApDung);
            }

			//Query NT_HDThuocDungKem_NgungSuDung (bool)
			if (QueryStrings.Any(d => d.Key == "NT_HDThuocDungKem_NgungSuDung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_HDThuocDungKem_NgungSuDung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_HDThuocDungKem_NgungSuDung);
            }

			//Query NT_LyDoThuocNghienCuu_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "NT_LyDoThuocNghienCuu_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_LyDoThuocNghienCuu_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_LyDoThuocNghienCuu_Khong);
            }

			//Query NT_LyDoThuocNghienCuu_Co (bool)
			if (QueryStrings.Any(d => d.Key == "NT_LyDoThuocNghienCuu_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_LyDoThuocNghienCuu_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_LyDoThuocNghienCuu_Co);
            }

			//Query NT_LyDoThuocDungKem_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "NT_LyDoThuocDungKem_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_LyDoThuocDungKem_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_LyDoThuocDungKem_Khong);
            }

			//Query NT_LyDoThuocDungKem_Co (bool)
			if (QueryStrings.Any(d => d.Key == "NT_LyDoThuocDungKem_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_LyDoThuocDungKem_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_LyDoThuocDungKem_Co);
            }

			//Query NT_NghiemTrong_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_Khong);
            }

			//Query NT_NghiemTrong_Co (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_Co);
            }

			//Query NT_NghiemTrong_TuVong (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_TuVong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_TuVong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_TuVong);
            }

			//Query NT_NghiemTrong_DeDoaTinhMang (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_DeDoaTinhMang"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_DeDoaTinhMang").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_DeDoaTinhMang);
            }

			//Query NT_NghiemTrong_NhapVien (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_NhapVien"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_NhapVien").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_NhapVien);
            }

			//Query NT_NghiemTrong_TanTat (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_TanTat"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_TanTat").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_TanTat);
            }

			//Query NT_NghiemTrong_BatThuong (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_BatThuong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_BatThuong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_BatThuong);
            }

			//Query NT_NghiemTrong_BienCoKhac (bool)
			if (QueryStrings.Any(d => d.Key == "NT_NghiemTrong_BienCoKhac"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NT_NghiemTrong_BienCoKhac").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NT_NghiemTrong_BienCoKhac);
            }

			//Query NT_HoTenThucHien (string)
			if (QueryStrings.Any(d => d.Key == "NT_HoTenThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_HoTenThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_HoTenThucHien").Value;
                query = query.Where(d=>d.NT_HoTenThucHien == keyword);
            }

			//Query NT_NgayBaoCao_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayBaoCao_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayBaoCao_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayBaoCao_Ngay").Value;
                query = query.Where(d=>d.NT_NgayBaoCao_Ngay == keyword);
            }

			//Query NT_NgayBaoCao_Thang (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayBaoCao_Thang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayBaoCao_Thang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayBaoCao_Thang").Value;
                query = query.Where(d=>d.NT_NgayBaoCao_Thang == keyword);
            }

			//Query NT_NgayBaoCao_Nam (string)
			if (QueryStrings.Any(d => d.Key == "NT_NgayBaoCao_Nam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayBaoCao_Nam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_NgayBaoCao_Nam").Value;
                query = query.Where(d=>d.NT_NgayBaoCao_Nam == keyword);
            }

			//Query NT_GhiChu (string)
			if (QueryStrings.Any(d => d.Key == "NT_GhiChu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NT_GhiChu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NT_GhiChu").Value;
                query = query.Where(d=>d.NT_GhiChu == keyword);
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


			return toDTO(query);

        }

		public static DTO_PRO_AE get_PRO_AE(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_AE.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_AE(AppEntities db, int ID, DTO_PRO_AE item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_AE.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDBenhNhan = item.IDBenhNhan;							
				dbitem.MaSo = item.MaSo;							
				dbitem.MaSoBenhNhan = item.MaSoBenhNhan;							
				dbitem.TenBienCo = item.TenBienCo;							
				dbitem.NgayKhoiPhat_Ngay = item.NgayKhoiPhat_Ngay;							
				dbitem.NgayKhoiPhat_Thang = item.NgayKhoiPhat_Thang;							
				dbitem.NgayKhoiPhat_Nam = item.NgayKhoiPhat_Nam;							
				dbitem.NgayKhoiPhat_Gio = item.NgayKhoiPhat_Gio;							
				dbitem.NgayKhoiPhat_Phut = item.NgayKhoiPhat_Phut;							
				dbitem.NgayKhoiPhat_DangTiepDien = item.NgayKhoiPhat_DangTiepDien;							
				dbitem.PhanDoNang_Nghe = item.PhanDoNang_Nghe;							
				dbitem.PhanDoNang_TrungBinh = item.PhanDoNang_TrungBinh;							
				dbitem.PhanDoNang_Nang = item.PhanDoNang_Nang;							
				dbitem.CanDieuTri_Khong = item.CanDieuTri_Khong;							
				dbitem.CanDieuTri_Co = item.CanDieuTri_Co;							
				dbitem.HDThuocNghienCuu_KhongApDung = item.HDThuocNghienCuu_KhongApDung;							
				dbitem.HDThuocNghienCuu_NgungSuDung = item.HDThuocNghienCuu_NgungSuDung;							
				dbitem.HDThuocDungKem_KhongApDung = item.HDThuocDungKem_KhongApDung;							
				dbitem.HDThuocDungKem_NgungSuDung = item.HDThuocDungKem_NgungSuDung;							
				dbitem.LyDoThuocNghienCuu_Khong = item.LyDoThuocNghienCuu_Khong;							
				dbitem.LyDoThuocNghienCuu_Co = item.LyDoThuocNghienCuu_Co;							
				dbitem.LyDoThuocDungKem_Khong = item.LyDoThuocDungKem_Khong;							
				dbitem.LyDoThuocDungKem_Co = item.LyDoThuocDungKem_Co;							
				dbitem.KetQua_HoiPhucKhongDiChung = item.KetQua_HoiPhucKhongDiChung;							
				dbitem.KetQua_CoDiChung = item.KetQua_CoDiChung;							
				dbitem.KetQua_DangHoiPhuc = item.KetQua_DangHoiPhuc;							
				dbitem.KetQua_ChuaHoiPhuc = item.KetQua_ChuaHoiPhuc;							
				dbitem.KetQua_KhongBiet = item.KetQua_KhongBiet;							
				dbitem.KetQua_TuVong_Ngay = item.KetQua_TuVong_Ngay;							
				dbitem.KetQua_TuVong_Thang = item.KetQua_TuVong_Thang;							
				dbitem.KetQua_TuVong_Nam = item.KetQua_TuVong_Nam;							
				dbitem.NghiemTrong_Khong = item.NghiemTrong_Khong;							
				dbitem.NghiemTrong_Co = item.NghiemTrong_Co;							
				dbitem.NghiemTrong_TuVong = item.NghiemTrong_TuVong;							
				dbitem.NghiemTrong_DeDoaTinhMang = item.NghiemTrong_DeDoaTinhMang;							
				dbitem.NghiemTrong_NhapVien = item.NghiemTrong_NhapVien;							
				dbitem.NghiemTrong_TanTat = item.NghiemTrong_TanTat;							
				dbitem.NghiemTrong_BatThuong = item.NghiemTrong_BatThuong;							
				dbitem.NghiemTrong_BienCoKhac = item.NghiemTrong_BienCoKhac;							
				dbitem.TienHanhSAE_Khong = item.TienHanhSAE_Khong;							
				dbitem.TienHanhSAE_Co = item.TienHanhSAE_Co;							
				dbitem.HoTenThucHien = item.HoTenThucHien;							
				dbitem.NgayBaoCao_Ngay = item.NgayBaoCao_Ngay;							
				dbitem.NgayBaoCao_Thang = item.NgayBaoCao_Thang;							
				dbitem.NgayBaoCao_Nam = item.NgayBaoCao_Nam;							
				dbitem.NT_NgayGioTangDoNang_Ngay = item.NT_NgayGioTangDoNang_Ngay;							
				dbitem.NT_NgayGioTangDoNang_Thang = item.NT_NgayGioTangDoNang_Thang;							
				dbitem.NT_NgayGioTangDoNang_Nam = item.NT_NgayGioTangDoNang_Nam;							
				dbitem.NT_NgayGioTangDoNang_Gio = item.NT_NgayGioTangDoNang_Gio;							
				dbitem.NT_NgayGioTangDoNang_Phut = item.NT_NgayGioTangDoNang_Phut;							
				dbitem.NT_DoNangAE_Nhe = item.NT_DoNangAE_Nhe;							
				dbitem.NT_DoNangAE_TrungBinh = item.NT_DoNangAE_TrungBinh;							
				dbitem.NT_DoNangAE_Nang = item.NT_DoNangAE_Nang;							
				dbitem.NT_YeuCauDieuTri_Khong = item.NT_YeuCauDieuTri_Khong;							
				dbitem.NT_YeuCauDieuTri_Co = item.NT_YeuCauDieuTri_Co;							
				dbitem.NT_HDThuocNghienCuu_KhongApDung = item.NT_HDThuocNghienCuu_KhongApDung;							
				dbitem.NT_HDThuocNghienCuu_NgungSuDung = item.NT_HDThuocNghienCuu_NgungSuDung;							
				dbitem.NT_HDThuocDungKem_KhongApDung = item.NT_HDThuocDungKem_KhongApDung;							
				dbitem.NT_HDThuocDungKem_NgungSuDung = item.NT_HDThuocDungKem_NgungSuDung;							
				dbitem.NT_LyDoThuocNghienCuu_Khong = item.NT_LyDoThuocNghienCuu_Khong;							
				dbitem.NT_LyDoThuocNghienCuu_Co = item.NT_LyDoThuocNghienCuu_Co;							
				dbitem.NT_LyDoThuocDungKem_Khong = item.NT_LyDoThuocDungKem_Khong;							
				dbitem.NT_LyDoThuocDungKem_Co = item.NT_LyDoThuocDungKem_Co;							
				dbitem.NT_NghiemTrong_Khong = item.NT_NghiemTrong_Khong;							
				dbitem.NT_NghiemTrong_Co = item.NT_NghiemTrong_Co;							
				dbitem.NT_NghiemTrong_TuVong = item.NT_NghiemTrong_TuVong;							
				dbitem.NT_NghiemTrong_DeDoaTinhMang = item.NT_NghiemTrong_DeDoaTinhMang;							
				dbitem.NT_NghiemTrong_NhapVien = item.NT_NghiemTrong_NhapVien;							
				dbitem.NT_NghiemTrong_TanTat = item.NT_NghiemTrong_TanTat;							
				dbitem.NT_NghiemTrong_BatThuong = item.NT_NghiemTrong_BatThuong;							
				dbitem.NT_NghiemTrong_BienCoKhac = item.NT_NghiemTrong_BienCoKhac;							
				dbitem.NT_HoTenThucHien = item.NT_HoTenThucHien;							
				dbitem.NT_NgayBaoCao_Ngay = item.NT_NgayBaoCao_Ngay;							
				dbitem.NT_NgayBaoCao_Thang = item.NT_NgayBaoCao_Thang;							
				dbitem.NT_NgayBaoCao_Nam = item.NT_NgayBaoCao_Nam;							
				dbitem.NT_GhiChu = item.NT_GhiChu;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_AE", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_AE",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_AE post_PRO_AE(AppEntities db, DTO_PRO_AE item, string Username)
        {
            tbl_PRO_AE dbitem = new tbl_PRO_AE();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDBenhNhan = item.IDBenhNhan;							
				dbitem.MaSo = item.MaSo;							
				dbitem.MaSoBenhNhan = item.MaSoBenhNhan;							
				dbitem.TenBienCo = item.TenBienCo;							
				dbitem.NgayKhoiPhat_Ngay = item.NgayKhoiPhat_Ngay;							
				dbitem.NgayKhoiPhat_Thang = item.NgayKhoiPhat_Thang;							
				dbitem.NgayKhoiPhat_Nam = item.NgayKhoiPhat_Nam;							
				dbitem.NgayKhoiPhat_Gio = item.NgayKhoiPhat_Gio;							
				dbitem.NgayKhoiPhat_Phut = item.NgayKhoiPhat_Phut;							
				dbitem.NgayKhoiPhat_DangTiepDien = item.NgayKhoiPhat_DangTiepDien;							
				dbitem.PhanDoNang_Nghe = item.PhanDoNang_Nghe;							
				dbitem.PhanDoNang_TrungBinh = item.PhanDoNang_TrungBinh;							
				dbitem.PhanDoNang_Nang = item.PhanDoNang_Nang;							
				dbitem.CanDieuTri_Khong = item.CanDieuTri_Khong;							
				dbitem.CanDieuTri_Co = item.CanDieuTri_Co;							
				dbitem.HDThuocNghienCuu_KhongApDung = item.HDThuocNghienCuu_KhongApDung;							
				dbitem.HDThuocNghienCuu_NgungSuDung = item.HDThuocNghienCuu_NgungSuDung;							
				dbitem.HDThuocDungKem_KhongApDung = item.HDThuocDungKem_KhongApDung;							
				dbitem.HDThuocDungKem_NgungSuDung = item.HDThuocDungKem_NgungSuDung;							
				dbitem.LyDoThuocNghienCuu_Khong = item.LyDoThuocNghienCuu_Khong;							
				dbitem.LyDoThuocNghienCuu_Co = item.LyDoThuocNghienCuu_Co;							
				dbitem.LyDoThuocDungKem_Khong = item.LyDoThuocDungKem_Khong;							
				dbitem.LyDoThuocDungKem_Co = item.LyDoThuocDungKem_Co;							
				dbitem.KetQua_HoiPhucKhongDiChung = item.KetQua_HoiPhucKhongDiChung;							
				dbitem.KetQua_CoDiChung = item.KetQua_CoDiChung;							
				dbitem.KetQua_DangHoiPhuc = item.KetQua_DangHoiPhuc;							
				dbitem.KetQua_ChuaHoiPhuc = item.KetQua_ChuaHoiPhuc;							
				dbitem.KetQua_KhongBiet = item.KetQua_KhongBiet;							
				dbitem.KetQua_TuVong_Ngay = item.KetQua_TuVong_Ngay;							
				dbitem.KetQua_TuVong_Thang = item.KetQua_TuVong_Thang;							
				dbitem.KetQua_TuVong_Nam = item.KetQua_TuVong_Nam;							
				dbitem.NghiemTrong_Khong = item.NghiemTrong_Khong;							
				dbitem.NghiemTrong_Co = item.NghiemTrong_Co;							
				dbitem.NghiemTrong_TuVong = item.NghiemTrong_TuVong;							
				dbitem.NghiemTrong_DeDoaTinhMang = item.NghiemTrong_DeDoaTinhMang;							
				dbitem.NghiemTrong_NhapVien = item.NghiemTrong_NhapVien;							
				dbitem.NghiemTrong_TanTat = item.NghiemTrong_TanTat;							
				dbitem.NghiemTrong_BatThuong = item.NghiemTrong_BatThuong;							
				dbitem.NghiemTrong_BienCoKhac = item.NghiemTrong_BienCoKhac;							
				dbitem.TienHanhSAE_Khong = item.TienHanhSAE_Khong;							
				dbitem.TienHanhSAE_Co = item.TienHanhSAE_Co;							
				dbitem.HoTenThucHien = item.HoTenThucHien;							
				dbitem.NgayBaoCao_Ngay = item.NgayBaoCao_Ngay;							
				dbitem.NgayBaoCao_Thang = item.NgayBaoCao_Thang;							
				dbitem.NgayBaoCao_Nam = item.NgayBaoCao_Nam;							
				dbitem.NT_NgayGioTangDoNang_Ngay = item.NT_NgayGioTangDoNang_Ngay;							
				dbitem.NT_NgayGioTangDoNang_Thang = item.NT_NgayGioTangDoNang_Thang;							
				dbitem.NT_NgayGioTangDoNang_Nam = item.NT_NgayGioTangDoNang_Nam;							
				dbitem.NT_NgayGioTangDoNang_Gio = item.NT_NgayGioTangDoNang_Gio;							
				dbitem.NT_NgayGioTangDoNang_Phut = item.NT_NgayGioTangDoNang_Phut;							
				dbitem.NT_DoNangAE_Nhe = item.NT_DoNangAE_Nhe;							
				dbitem.NT_DoNangAE_TrungBinh = item.NT_DoNangAE_TrungBinh;							
				dbitem.NT_DoNangAE_Nang = item.NT_DoNangAE_Nang;							
				dbitem.NT_YeuCauDieuTri_Khong = item.NT_YeuCauDieuTri_Khong;							
				dbitem.NT_YeuCauDieuTri_Co = item.NT_YeuCauDieuTri_Co;							
				dbitem.NT_HDThuocNghienCuu_KhongApDung = item.NT_HDThuocNghienCuu_KhongApDung;							
				dbitem.NT_HDThuocNghienCuu_NgungSuDung = item.NT_HDThuocNghienCuu_NgungSuDung;							
				dbitem.NT_HDThuocDungKem_KhongApDung = item.NT_HDThuocDungKem_KhongApDung;							
				dbitem.NT_HDThuocDungKem_NgungSuDung = item.NT_HDThuocDungKem_NgungSuDung;							
				dbitem.NT_LyDoThuocNghienCuu_Khong = item.NT_LyDoThuocNghienCuu_Khong;							
				dbitem.NT_LyDoThuocNghienCuu_Co = item.NT_LyDoThuocNghienCuu_Co;							
				dbitem.NT_LyDoThuocDungKem_Khong = item.NT_LyDoThuocDungKem_Khong;							
				dbitem.NT_LyDoThuocDungKem_Co = item.NT_LyDoThuocDungKem_Co;							
				dbitem.NT_NghiemTrong_Khong = item.NT_NghiemTrong_Khong;							
				dbitem.NT_NghiemTrong_Co = item.NT_NghiemTrong_Co;							
				dbitem.NT_NghiemTrong_TuVong = item.NT_NghiemTrong_TuVong;							
				dbitem.NT_NghiemTrong_DeDoaTinhMang = item.NT_NghiemTrong_DeDoaTinhMang;							
				dbitem.NT_NghiemTrong_NhapVien = item.NT_NghiemTrong_NhapVien;							
				dbitem.NT_NghiemTrong_TanTat = item.NT_NghiemTrong_TanTat;							
				dbitem.NT_NghiemTrong_BatThuong = item.NT_NghiemTrong_BatThuong;							
				dbitem.NT_NghiemTrong_BienCoKhac = item.NT_NghiemTrong_BienCoKhac;							
				dbitem.NT_HoTenThucHien = item.NT_HoTenThucHien;							
				dbitem.NT_NgayBaoCao_Ngay = item.NT_NgayBaoCao_Ngay;							
				dbitem.NT_NgayBaoCao_Thang = item.NT_NgayBaoCao_Thang;							
				dbitem.NT_NgayBaoCao_Nam = item.NT_NgayBaoCao_Nam;							
				dbitem.NT_GhiChu = item.NT_GhiChu;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_AE.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_AE", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_AE",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_AE(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_AE.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_AE", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_AE",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_AE_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_AE.Any(e => e.ID == id);
		}
		
    }

}






