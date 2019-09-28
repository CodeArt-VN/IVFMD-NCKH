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
    
    
    public partial class tbl_PRO_SAE
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public int IDBenhNhan { get; set; }
        public string MaSo { get; set; }
        public bool BaoCaoLanDau { get; set; }
        public bool BaoCaoBoSung { get; set; }
        public bool TuVong { get; set; }
        public bool DeDoaTinhMang { get; set; }
        public bool NhapVien { get; set; }
        public bool TanTat { get; set; }
        public bool DiTatBamSinh { get; set; }
        public bool YeuCanCanThiepYKhoa { get; set; }
        public string TenNghienCuu { get; set; }
        public bool ThietKeNghienCuu_NhanMo { get; set; }
        public bool ThietKeNghienCuu_MuDon { get; set; }
        public bool ThietKeNghienCuu_MuDoi { get; set; }
        public bool MoMu_Co { get; set; }
        public bool MoMu_Khong { get; set; }
        public bool MoMu_KhongCoThongTin { get; set; }
        public string NhaTaiTro { get; set; }
        public string HoTenNCV { get; set; }
        public string DiemNghienCuu { get; set; }
        public string ThoiDiemNhanThongTin { get; set; }
        public string ThoiDiemXuatHien { get; set; }
        public string ThoiDiemKetThuc { get; set; }
        public bool DangTiepDien { get; set; }
        public string TenSAE { get; set; }
        public string TenNguoiThuThuoc { get; set; }
        public string MaSoNguoiThuThuoc { get; set; }
        public string MoTaDienBien { get; set; }
        public bool KetQua_HoiPhucKhongDiChung { get; set; }
        public bool KetQua_HoiPhucCoDiChung { get; set; }
        public bool KetQua_DangHoiPhuc { get; set; }
        public bool KetQua_ChuaHoiPhuc { get; set; }
        public bool KetQua_TuVong { get; set; }
        public string KetQua_TuVong_Ngay { get; set; }
        public bool KetQua_KhongCoThongTin { get; set; }
        public string NguoiThamGia_NgaySinh { get; set; }
        public string NguoiThamGia_Tuoi { get; set; }
        public bool NguoiThamGia_GioiTinh_Nam { get; set; }
        public bool NguoiThamGia_GioiTinh_Nu { get; set; }
        public bool NguoiThamGia_GioiTinh_Nu_DangMangThai { get; set; }
        public string NguoiThamGia_GioiTinh_Nu_TuanMangThai { get; set; }
        public string NguoiThamGia_CanNang { get; set; }
        public string NguoiThamGia_TienSuYKhoa { get; set; }
        public string JSON_ThuocThuLamSang { get; set; }
        public string JSON_CanThiepThuocThuLamSang { get; set; }
        public string JSON_ThuocSuDungDongThoi { get; set; }
        public string JSON_DanhGiaNCV { get; set; }
        public string LyDoDanhGia { get; set; }
        public string LyDoDanhGia_SoLuong { get; set; }
        public string LyDoDanhGia_SoLuongNghienCuuKhac { get; set; }
        public bool YKienHDDD_NguoiThamGia_TiepTucThamGia { get; set; }
        public bool YKienHDDD_NguoiThamGia_TamNgungThamGia { get; set; }
        public bool YKienHDDD_NguoiThamGia_RutKhoiNghienCuu { get; set; }
        public bool YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai { get; set; }
        public bool YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai { get; set; }
        public bool YKienHDDD_DeXuatNghienCuu_NgungTrienKhai { get; set; }
        public string YKienHDDD_DeXuatKhac { get; set; }
        public string NguoiBaoCao_ChuKy { get; set; }
        public string NguoiBaoCao_NgayKy { get; set; }
        public string NguoiBaoCao_HoTen { get; set; }
        public string NguoiBaoCao_ChucVu { get; set; }
        public string NguoiBaoCao_DienThoai { get; set; }
        public string NguoiBaoCao_Email { get; set; }
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
	public partial class DTO_PRO_SAE
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public int IDBenhNhan { get; set; }
		public string MaSo { get; set; }
		public bool BaoCaoLanDau { get; set; }
		public bool BaoCaoBoSung { get; set; }
		public bool TuVong { get; set; }
		public bool DeDoaTinhMang { get; set; }
		public bool NhapVien { get; set; }
		public bool TanTat { get; set; }
		public bool DiTatBamSinh { get; set; }
		public bool YeuCanCanThiepYKhoa { get; set; }
		public string TenNghienCuu { get; set; }
		public bool ThietKeNghienCuu_NhanMo { get; set; }
		public bool ThietKeNghienCuu_MuDon { get; set; }
		public bool ThietKeNghienCuu_MuDoi { get; set; }
		public bool MoMu_Co { get; set; }
		public bool MoMu_Khong { get; set; }
		public bool MoMu_KhongCoThongTin { get; set; }
		public string NhaTaiTro { get; set; }
		public string HoTenNCV { get; set; }
		public string DiemNghienCuu { get; set; }
		public string ThoiDiemNhanThongTin { get; set; }
		public string ThoiDiemXuatHien { get; set; }
		public string ThoiDiemKetThuc { get; set; }
		public bool DangTiepDien { get; set; }
		public string TenSAE { get; set; }
		public string TenNguoiThuThuoc { get; set; }
		public string MaSoNguoiThuThuoc { get; set; }
		public string MoTaDienBien { get; set; }
		public bool KetQua_HoiPhucKhongDiChung { get; set; }
		public bool KetQua_HoiPhucCoDiChung { get; set; }
		public bool KetQua_DangHoiPhuc { get; set; }
		public bool KetQua_ChuaHoiPhuc { get; set; }
		public bool KetQua_TuVong { get; set; }
		public string KetQua_TuVong_Ngay { get; set; }
		public bool KetQua_KhongCoThongTin { get; set; }
		public string NguoiThamGia_NgaySinh { get; set; }
		public string NguoiThamGia_Tuoi { get; set; }
		public bool NguoiThamGia_GioiTinh_Nam { get; set; }
		public bool NguoiThamGia_GioiTinh_Nu { get; set; }
		public bool NguoiThamGia_GioiTinh_Nu_DangMangThai { get; set; }
		public string NguoiThamGia_GioiTinh_Nu_TuanMangThai { get; set; }
		public string NguoiThamGia_CanNang { get; set; }
		public string NguoiThamGia_TienSuYKhoa { get; set; }
		public string JSON_ThuocThuLamSang { get; set; }
		public string JSON_CanThiepThuocThuLamSang { get; set; }
		public string JSON_ThuocSuDungDongThoi { get; set; }
		public string JSON_DanhGiaNCV { get; set; }
		public string LyDoDanhGia { get; set; }
		public string LyDoDanhGia_SoLuong { get; set; }
		public string LyDoDanhGia_SoLuongNghienCuuKhac { get; set; }
		public bool YKienHDDD_NguoiThamGia_TiepTucThamGia { get; set; }
		public bool YKienHDDD_NguoiThamGia_TamNgungThamGia { get; set; }
		public bool YKienHDDD_NguoiThamGia_RutKhoiNghienCuu { get; set; }
		public bool YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai { get; set; }
		public bool YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai { get; set; }
		public bool YKienHDDD_DeXuatNghienCuu_NgungTrienKhai { get; set; }
		public string YKienHDDD_DeXuatKhac { get; set; }
		public string NguoiBaoCao_ChuKy { get; set; }
		public string NguoiBaoCao_NgayKy { get; set; }
		public string NguoiBaoCao_HoTen { get; set; }
		public string NguoiBaoCao_ChucVu { get; set; }
		public string NguoiBaoCao_DienThoai { get; set; }
		public string NguoiBaoCao_Email { get; set; }
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

    public static partial class BS_PRO_SAE 
    {
		public static IQueryable<DTO_PRO_SAE> toDTO(IQueryable<tbl_PRO_SAE> query)
        {
			return query
			.Select(s => new DTO_PRO_SAE(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				IDBenhNhan = s.IDBenhNhan,							
				MaSo = s.MaSo,							
				BaoCaoLanDau = s.BaoCaoLanDau,							
				BaoCaoBoSung = s.BaoCaoBoSung,							
				TuVong = s.TuVong,							
				DeDoaTinhMang = s.DeDoaTinhMang,							
				NhapVien = s.NhapVien,							
				TanTat = s.TanTat,							
				DiTatBamSinh = s.DiTatBamSinh,							
				YeuCanCanThiepYKhoa = s.YeuCanCanThiepYKhoa,							
				TenNghienCuu = s.TenNghienCuu,							
				ThietKeNghienCuu_NhanMo = s.ThietKeNghienCuu_NhanMo,							
				ThietKeNghienCuu_MuDon = s.ThietKeNghienCuu_MuDon,							
				ThietKeNghienCuu_MuDoi = s.ThietKeNghienCuu_MuDoi,							
				MoMu_Co = s.MoMu_Co,							
				MoMu_Khong = s.MoMu_Khong,							
				MoMu_KhongCoThongTin = s.MoMu_KhongCoThongTin,							
				NhaTaiTro = s.NhaTaiTro,							
				HoTenNCV = s.HoTenNCV,							
				DiemNghienCuu = s.DiemNghienCuu,							
				ThoiDiemNhanThongTin = s.ThoiDiemNhanThongTin,							
				ThoiDiemXuatHien = s.ThoiDiemXuatHien,							
				ThoiDiemKetThuc = s.ThoiDiemKetThuc,							
				DangTiepDien = s.DangTiepDien,							
				TenSAE = s.TenSAE,							
				TenNguoiThuThuoc = s.TenNguoiThuThuoc,							
				MaSoNguoiThuThuoc = s.MaSoNguoiThuThuoc,							
				MoTaDienBien = s.MoTaDienBien,							
				KetQua_HoiPhucKhongDiChung = s.KetQua_HoiPhucKhongDiChung,							
				KetQua_HoiPhucCoDiChung = s.KetQua_HoiPhucCoDiChung,							
				KetQua_DangHoiPhuc = s.KetQua_DangHoiPhuc,							
				KetQua_ChuaHoiPhuc = s.KetQua_ChuaHoiPhuc,							
				KetQua_TuVong = s.KetQua_TuVong,							
				KetQua_TuVong_Ngay = s.KetQua_TuVong_Ngay,							
				KetQua_KhongCoThongTin = s.KetQua_KhongCoThongTin,							
				NguoiThamGia_NgaySinh = s.NguoiThamGia_NgaySinh,							
				NguoiThamGia_Tuoi = s.NguoiThamGia_Tuoi,							
				NguoiThamGia_GioiTinh_Nam = s.NguoiThamGia_GioiTinh_Nam,							
				NguoiThamGia_GioiTinh_Nu = s.NguoiThamGia_GioiTinh_Nu,							
				NguoiThamGia_GioiTinh_Nu_DangMangThai = s.NguoiThamGia_GioiTinh_Nu_DangMangThai,							
				NguoiThamGia_GioiTinh_Nu_TuanMangThai = s.NguoiThamGia_GioiTinh_Nu_TuanMangThai,							
				NguoiThamGia_CanNang = s.NguoiThamGia_CanNang,							
				NguoiThamGia_TienSuYKhoa = s.NguoiThamGia_TienSuYKhoa,							
				JSON_ThuocThuLamSang = s.JSON_ThuocThuLamSang,							
				JSON_CanThiepThuocThuLamSang = s.JSON_CanThiepThuocThuLamSang,							
				JSON_ThuocSuDungDongThoi = s.JSON_ThuocSuDungDongThoi,							
				JSON_DanhGiaNCV = s.JSON_DanhGiaNCV,							
				LyDoDanhGia = s.LyDoDanhGia,							
				LyDoDanhGia_SoLuong = s.LyDoDanhGia_SoLuong,							
				LyDoDanhGia_SoLuongNghienCuuKhac = s.LyDoDanhGia_SoLuongNghienCuuKhac,							
				YKienHDDD_NguoiThamGia_TiepTucThamGia = s.YKienHDDD_NguoiThamGia_TiepTucThamGia,							
				YKienHDDD_NguoiThamGia_TamNgungThamGia = s.YKienHDDD_NguoiThamGia_TamNgungThamGia,							
				YKienHDDD_NguoiThamGia_RutKhoiNghienCuu = s.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu,							
				YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai = s.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai,							
				YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai = s.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai,							
				YKienHDDD_DeXuatNghienCuu_NgungTrienKhai = s.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai,							
				YKienHDDD_DeXuatKhac = s.YKienHDDD_DeXuatKhac,							
				NguoiBaoCao_ChuKy = s.NguoiBaoCao_ChuKy,							
				NguoiBaoCao_NgayKy = s.NguoiBaoCao_NgayKy,							
				NguoiBaoCao_HoTen = s.NguoiBaoCao_HoTen,							
				NguoiBaoCao_ChucVu = s.NguoiBaoCao_ChucVu,							
				NguoiBaoCao_DienThoai = s.NguoiBaoCao_DienThoai,							
				NguoiBaoCao_Email = s.NguoiBaoCao_Email,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_SAE toDTO(tbl_PRO_SAE dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_SAE()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					IDBenhNhan = dbResult.IDBenhNhan,							
					MaSo = dbResult.MaSo,							
					BaoCaoLanDau = dbResult.BaoCaoLanDau,							
					BaoCaoBoSung = dbResult.BaoCaoBoSung,							
					TuVong = dbResult.TuVong,							
					DeDoaTinhMang = dbResult.DeDoaTinhMang,							
					NhapVien = dbResult.NhapVien,							
					TanTat = dbResult.TanTat,							
					DiTatBamSinh = dbResult.DiTatBamSinh,							
					YeuCanCanThiepYKhoa = dbResult.YeuCanCanThiepYKhoa,							
					TenNghienCuu = dbResult.TenNghienCuu,							
					ThietKeNghienCuu_NhanMo = dbResult.ThietKeNghienCuu_NhanMo,							
					ThietKeNghienCuu_MuDon = dbResult.ThietKeNghienCuu_MuDon,							
					ThietKeNghienCuu_MuDoi = dbResult.ThietKeNghienCuu_MuDoi,							
					MoMu_Co = dbResult.MoMu_Co,							
					MoMu_Khong = dbResult.MoMu_Khong,							
					MoMu_KhongCoThongTin = dbResult.MoMu_KhongCoThongTin,							
					NhaTaiTro = dbResult.NhaTaiTro,							
					HoTenNCV = dbResult.HoTenNCV,							
					DiemNghienCuu = dbResult.DiemNghienCuu,							
					ThoiDiemNhanThongTin = dbResult.ThoiDiemNhanThongTin,							
					ThoiDiemXuatHien = dbResult.ThoiDiemXuatHien,							
					ThoiDiemKetThuc = dbResult.ThoiDiemKetThuc,							
					DangTiepDien = dbResult.DangTiepDien,							
					TenSAE = dbResult.TenSAE,							
					TenNguoiThuThuoc = dbResult.TenNguoiThuThuoc,							
					MaSoNguoiThuThuoc = dbResult.MaSoNguoiThuThuoc,							
					MoTaDienBien = dbResult.MoTaDienBien,							
					KetQua_HoiPhucKhongDiChung = dbResult.KetQua_HoiPhucKhongDiChung,							
					KetQua_HoiPhucCoDiChung = dbResult.KetQua_HoiPhucCoDiChung,							
					KetQua_DangHoiPhuc = dbResult.KetQua_DangHoiPhuc,							
					KetQua_ChuaHoiPhuc = dbResult.KetQua_ChuaHoiPhuc,							
					KetQua_TuVong = dbResult.KetQua_TuVong,							
					KetQua_TuVong_Ngay = dbResult.KetQua_TuVong_Ngay,							
					KetQua_KhongCoThongTin = dbResult.KetQua_KhongCoThongTin,							
					NguoiThamGia_NgaySinh = dbResult.NguoiThamGia_NgaySinh,							
					NguoiThamGia_Tuoi = dbResult.NguoiThamGia_Tuoi,							
					NguoiThamGia_GioiTinh_Nam = dbResult.NguoiThamGia_GioiTinh_Nam,							
					NguoiThamGia_GioiTinh_Nu = dbResult.NguoiThamGia_GioiTinh_Nu,							
					NguoiThamGia_GioiTinh_Nu_DangMangThai = dbResult.NguoiThamGia_GioiTinh_Nu_DangMangThai,							
					NguoiThamGia_GioiTinh_Nu_TuanMangThai = dbResult.NguoiThamGia_GioiTinh_Nu_TuanMangThai,							
					NguoiThamGia_CanNang = dbResult.NguoiThamGia_CanNang,							
					NguoiThamGia_TienSuYKhoa = dbResult.NguoiThamGia_TienSuYKhoa,							
					JSON_ThuocThuLamSang = dbResult.JSON_ThuocThuLamSang,							
					JSON_CanThiepThuocThuLamSang = dbResult.JSON_CanThiepThuocThuLamSang,							
					JSON_ThuocSuDungDongThoi = dbResult.JSON_ThuocSuDungDongThoi,							
					JSON_DanhGiaNCV = dbResult.JSON_DanhGiaNCV,							
					LyDoDanhGia = dbResult.LyDoDanhGia,							
					LyDoDanhGia_SoLuong = dbResult.LyDoDanhGia_SoLuong,							
					LyDoDanhGia_SoLuongNghienCuuKhac = dbResult.LyDoDanhGia_SoLuongNghienCuuKhac,							
					YKienHDDD_NguoiThamGia_TiepTucThamGia = dbResult.YKienHDDD_NguoiThamGia_TiepTucThamGia,							
					YKienHDDD_NguoiThamGia_TamNgungThamGia = dbResult.YKienHDDD_NguoiThamGia_TamNgungThamGia,							
					YKienHDDD_NguoiThamGia_RutKhoiNghienCuu = dbResult.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu,							
					YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai = dbResult.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai,							
					YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai = dbResult.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai,							
					YKienHDDD_DeXuatNghienCuu_NgungTrienKhai = dbResult.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai,							
					YKienHDDD_DeXuatKhac = dbResult.YKienHDDD_DeXuatKhac,							
					NguoiBaoCao_ChuKy = dbResult.NguoiBaoCao_ChuKy,							
					NguoiBaoCao_NgayKy = dbResult.NguoiBaoCao_NgayKy,							
					NguoiBaoCao_HoTen = dbResult.NguoiBaoCao_HoTen,							
					NguoiBaoCao_ChucVu = dbResult.NguoiBaoCao_ChucVu,							
					NguoiBaoCao_DienThoai = dbResult.NguoiBaoCao_DienThoai,							
					NguoiBaoCao_Email = dbResult.NguoiBaoCao_Email,							
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

        public static IQueryable<DTO_PRO_SAE> get_PRO_SAE(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_SAE.Where(d => d.IsDeleted == false );

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

			//Query BaoCaoLanDau (bool)
			if (QueryStrings.Any(d => d.Key == "BaoCaoLanDau"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "BaoCaoLanDau").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.BaoCaoLanDau);
            }

			//Query BaoCaoBoSung (bool)
			if (QueryStrings.Any(d => d.Key == "BaoCaoBoSung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "BaoCaoBoSung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.BaoCaoBoSung);
            }

			//Query TuVong (bool)
			if (QueryStrings.Any(d => d.Key == "TuVong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "TuVong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.TuVong);
            }

			//Query DeDoaTinhMang (bool)
			if (QueryStrings.Any(d => d.Key == "DeDoaTinhMang"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DeDoaTinhMang").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DeDoaTinhMang);
            }

			//Query NhapVien (bool)
			if (QueryStrings.Any(d => d.Key == "NhapVien"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NhapVien").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NhapVien);
            }

			//Query TanTat (bool)
			if (QueryStrings.Any(d => d.Key == "TanTat"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "TanTat").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.TanTat);
            }

			//Query DiTatBamSinh (bool)
			if (QueryStrings.Any(d => d.Key == "DiTatBamSinh"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DiTatBamSinh").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DiTatBamSinh);
            }

			//Query YeuCanCanThiepYKhoa (bool)
			if (QueryStrings.Any(d => d.Key == "YeuCanCanThiepYKhoa"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YeuCanCanThiepYKhoa").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YeuCanCanThiepYKhoa);
            }

			//Query TenNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "TenNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenNghienCuu").Value;
                query = query.Where(d=>d.TenNghienCuu == keyword);
            }

			//Query ThietKeNghienCuu_NhanMo (bool)
			if (QueryStrings.Any(d => d.Key == "ThietKeNghienCuu_NhanMo"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "ThietKeNghienCuu_NhanMo").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.ThietKeNghienCuu_NhanMo);
            }

			//Query ThietKeNghienCuu_MuDon (bool)
			if (QueryStrings.Any(d => d.Key == "ThietKeNghienCuu_MuDon"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "ThietKeNghienCuu_MuDon").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.ThietKeNghienCuu_MuDon);
            }

			//Query ThietKeNghienCuu_MuDoi (bool)
			if (QueryStrings.Any(d => d.Key == "ThietKeNghienCuu_MuDoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "ThietKeNghienCuu_MuDoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.ThietKeNghienCuu_MuDoi);
            }

			//Query MoMu_Co (bool)
			if (QueryStrings.Any(d => d.Key == "MoMu_Co"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "MoMu_Co").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.MoMu_Co);
            }

			//Query MoMu_Khong (bool)
			if (QueryStrings.Any(d => d.Key == "MoMu_Khong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "MoMu_Khong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.MoMu_Khong);
            }

			//Query MoMu_KhongCoThongTin (bool)
			if (QueryStrings.Any(d => d.Key == "MoMu_KhongCoThongTin"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "MoMu_KhongCoThongTin").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.MoMu_KhongCoThongTin);
            }

			//Query NhaTaiTro (string)
			if (QueryStrings.Any(d => d.Key == "NhaTaiTro") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NhaTaiTro").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NhaTaiTro").Value;
                query = query.Where(d=>d.NhaTaiTro == keyword);
            }

			//Query HoTenNCV (string)
			if (QueryStrings.Any(d => d.Key == "HoTenNCV") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoTenNCV").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoTenNCV").Value;
                query = query.Where(d=>d.HoTenNCV == keyword);
            }

			//Query DiemNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "DiemNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiemNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiemNghienCuu").Value;
                query = query.Where(d=>d.DiemNghienCuu == keyword);
            }

			//Query ThoiDiemNhanThongTin (string)
			if (QueryStrings.Any(d => d.Key == "ThoiDiemNhanThongTin") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiDiemNhanThongTin").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiDiemNhanThongTin").Value;
                query = query.Where(d=>d.ThoiDiemNhanThongTin == keyword);
            }

			//Query ThoiDiemXuatHien (string)
			if (QueryStrings.Any(d => d.Key == "ThoiDiemXuatHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiDiemXuatHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiDiemXuatHien").Value;
                query = query.Where(d=>d.ThoiDiemXuatHien == keyword);
            }

			//Query ThoiDiemKetThuc (string)
			if (QueryStrings.Any(d => d.Key == "ThoiDiemKetThuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiDiemKetThuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiDiemKetThuc").Value;
                query = query.Where(d=>d.ThoiDiemKetThuc == keyword);
            }

			//Query DangTiepDien (bool)
			if (QueryStrings.Any(d => d.Key == "DangTiepDien"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DangTiepDien").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DangTiepDien);
            }

			//Query TenSAE (string)
			if (QueryStrings.Any(d => d.Key == "TenSAE") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenSAE").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenSAE").Value;
                query = query.Where(d=>d.TenSAE == keyword);
            }

			//Query TenNguoiThuThuoc (string)
			if (QueryStrings.Any(d => d.Key == "TenNguoiThuThuoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenNguoiThuThuoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenNguoiThuThuoc").Value;
                query = query.Where(d=>d.TenNguoiThuThuoc == keyword);
            }

			//Query MaSoNguoiThuThuoc (string)
			if (QueryStrings.Any(d => d.Key == "MaSoNguoiThuThuoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSoNguoiThuThuoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSoNguoiThuThuoc").Value;
                query = query.Where(d=>d.MaSoNguoiThuThuoc == keyword);
            }

			//Query MoTaDienBien (string)
			if (QueryStrings.Any(d => d.Key == "MoTaDienBien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MoTaDienBien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MoTaDienBien").Value;
                query = query.Where(d=>d.MoTaDienBien == keyword);
            }

			//Query KetQua_HoiPhucKhongDiChung (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_HoiPhucKhongDiChung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_HoiPhucKhongDiChung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_HoiPhucKhongDiChung);
            }

			//Query KetQua_HoiPhucCoDiChung (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_HoiPhucCoDiChung"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_HoiPhucCoDiChung").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_HoiPhucCoDiChung);
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

			//Query KetQua_TuVong (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_TuVong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_TuVong);
            }

			//Query KetQua_TuVong_Ngay (string)
			if (QueryStrings.Any(d => d.Key == "KetQua_TuVong_Ngay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Ngay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_TuVong_Ngay").Value;
                query = query.Where(d=>d.KetQua_TuVong_Ngay == keyword);
            }

			//Query KetQua_KhongCoThongTin (bool)
			if (QueryStrings.Any(d => d.Key == "KetQua_KhongCoThongTin"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KetQua_KhongCoThongTin").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KetQua_KhongCoThongTin);
            }

			//Query NguoiThamGia_NgaySinh (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_NgaySinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_NgaySinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_NgaySinh").Value;
                query = query.Where(d=>d.NguoiThamGia_NgaySinh == keyword);
            }

			//Query NguoiThamGia_Tuoi (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_Tuoi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_Tuoi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_Tuoi").Value;
                query = query.Where(d=>d.NguoiThamGia_Tuoi == keyword);
            }

			//Query NguoiThamGia_GioiTinh_Nam (bool)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_GioiTinh_Nam"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_GioiTinh_Nam").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguoiThamGia_GioiTinh_Nam);
            }

			//Query NguoiThamGia_GioiTinh_Nu (bool)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_GioiTinh_Nu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_GioiTinh_Nu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguoiThamGia_GioiTinh_Nu);
            }

			//Query NguoiThamGia_GioiTinh_Nu_DangMangThai (bool)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_GioiTinh_Nu_DangMangThai"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_GioiTinh_Nu_DangMangThai").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguoiThamGia_GioiTinh_Nu_DangMangThai);
            }

			//Query NguoiThamGia_GioiTinh_Nu_TuanMangThai (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_GioiTinh_Nu_TuanMangThai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_GioiTinh_Nu_TuanMangThai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_GioiTinh_Nu_TuanMangThai").Value;
                query = query.Where(d=>d.NguoiThamGia_GioiTinh_Nu_TuanMangThai == keyword);
            }

			//Query NguoiThamGia_CanNang (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_CanNang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_CanNang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_CanNang").Value;
                query = query.Where(d=>d.NguoiThamGia_CanNang == keyword);
            }

			//Query NguoiThamGia_TienSuYKhoa (string)
			if (QueryStrings.Any(d => d.Key == "NguoiThamGia_TienSuYKhoa") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_TienSuYKhoa").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiThamGia_TienSuYKhoa").Value;
                query = query.Where(d=>d.NguoiThamGia_TienSuYKhoa == keyword);
            }

			//Query JSON_ThuocThuLamSang (string)
			if (QueryStrings.Any(d => d.Key == "JSON_ThuocThuLamSang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThuocThuLamSang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThuocThuLamSang").Value;
                query = query.Where(d=>d.JSON_ThuocThuLamSang == keyword);
            }

			//Query JSON_CanThiepThuocThuLamSang (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CanThiepThuocThuLamSang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CanThiepThuocThuLamSang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CanThiepThuocThuLamSang").Value;
                query = query.Where(d=>d.JSON_CanThiepThuocThuLamSang == keyword);
            }

			//Query JSON_ThuocSuDungDongThoi (string)
			if (QueryStrings.Any(d => d.Key == "JSON_ThuocSuDungDongThoi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThuocSuDungDongThoi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThuocSuDungDongThoi").Value;
                query = query.Where(d=>d.JSON_ThuocSuDungDongThoi == keyword);
            }

			//Query JSON_DanhGiaNCV (string)
			if (QueryStrings.Any(d => d.Key == "JSON_DanhGiaNCV") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_DanhGiaNCV").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_DanhGiaNCV").Value;
                query = query.Where(d=>d.JSON_DanhGiaNCV == keyword);
            }

			//Query LyDoDanhGia (string)
			if (QueryStrings.Any(d => d.Key == "LyDoDanhGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LyDoDanhGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LyDoDanhGia").Value;
                query = query.Where(d=>d.LyDoDanhGia == keyword);
            }

			//Query LyDoDanhGia_SoLuong (string)
			if (QueryStrings.Any(d => d.Key == "LyDoDanhGia_SoLuong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LyDoDanhGia_SoLuong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LyDoDanhGia_SoLuong").Value;
                query = query.Where(d=>d.LyDoDanhGia_SoLuong == keyword);
            }

			//Query LyDoDanhGia_SoLuongNghienCuuKhac (string)
			if (QueryStrings.Any(d => d.Key == "LyDoDanhGia_SoLuongNghienCuuKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LyDoDanhGia_SoLuongNghienCuuKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LyDoDanhGia_SoLuongNghienCuuKhac").Value;
                query = query.Where(d=>d.LyDoDanhGia_SoLuongNghienCuuKhac == keyword);
            }

			//Query YKienHDDD_NguoiThamGia_TiepTucThamGia (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_NguoiThamGia_TiepTucThamGia"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_NguoiThamGia_TiepTucThamGia").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_NguoiThamGia_TiepTucThamGia);
            }

			//Query YKienHDDD_NguoiThamGia_TamNgungThamGia (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_NguoiThamGia_TamNgungThamGia"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_NguoiThamGia_TamNgungThamGia").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_NguoiThamGia_TamNgungThamGia);
            }

			//Query YKienHDDD_NguoiThamGia_RutKhoiNghienCuu (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_NguoiThamGia_RutKhoiNghienCuu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_NguoiThamGia_RutKhoiNghienCuu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu);
            }

			//Query YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai);
            }

			//Query YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai);
            }

			//Query YKienHDDD_DeXuatNghienCuu_NgungTrienKhai (bool)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_DeXuatNghienCuu_NgungTrienKhai"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_DeXuatNghienCuu_NgungTrienKhai").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai);
            }

			//Query YKienHDDD_DeXuatKhac (string)
			if (QueryStrings.Any(d => d.Key == "YKienHDDD_DeXuatKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_DeXuatKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YKienHDDD_DeXuatKhac").Value;
                query = query.Where(d=>d.YKienHDDD_DeXuatKhac == keyword);
            }

			//Query NguoiBaoCao_ChuKy (string)
			if (QueryStrings.Any(d => d.Key == "NguoiBaoCao_ChuKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_ChuKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_ChuKy").Value;
                query = query.Where(d=>d.NguoiBaoCao_ChuKy == keyword);
            }

			//Query NguoiBaoCao_NgayKy (string)
			if (QueryStrings.Any(d => d.Key == "NguoiBaoCao_NgayKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_NgayKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_NgayKy").Value;
                query = query.Where(d=>d.NguoiBaoCao_NgayKy == keyword);
            }

			//Query NguoiBaoCao_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "NguoiBaoCao_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_HoTen").Value;
                query = query.Where(d=>d.NguoiBaoCao_HoTen == keyword);
            }

			//Query NguoiBaoCao_ChucVu (string)
			if (QueryStrings.Any(d => d.Key == "NguoiBaoCao_ChucVu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_ChucVu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_ChucVu").Value;
                query = query.Where(d=>d.NguoiBaoCao_ChucVu == keyword);
            }

			//Query NguoiBaoCao_DienThoai (string)
			if (QueryStrings.Any(d => d.Key == "NguoiBaoCao_DienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_DienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_DienThoai").Value;
                query = query.Where(d=>d.NguoiBaoCao_DienThoai == keyword);
            }

			//Query NguoiBaoCao_Email (string)
			if (QueryStrings.Any(d => d.Key == "NguoiBaoCao_Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiBaoCao_Email").Value;
                query = query.Where(d=>d.NguoiBaoCao_Email == keyword);
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

		public static DTO_PRO_SAE get_PRO_SAE(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_SAE.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_SAE(AppEntities db, int ID, DTO_PRO_SAE item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_SAE.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDBenhNhan = item.IDBenhNhan;							
				dbitem.MaSo = item.MaSo;							
				dbitem.BaoCaoLanDau = item.BaoCaoLanDau;							
				dbitem.BaoCaoBoSung = item.BaoCaoBoSung;							
				dbitem.TuVong = item.TuVong;							
				dbitem.DeDoaTinhMang = item.DeDoaTinhMang;							
				dbitem.NhapVien = item.NhapVien;							
				dbitem.TanTat = item.TanTat;							
				dbitem.DiTatBamSinh = item.DiTatBamSinh;							
				dbitem.YeuCanCanThiepYKhoa = item.YeuCanCanThiepYKhoa;							
				dbitem.TenNghienCuu = item.TenNghienCuu;							
				dbitem.ThietKeNghienCuu_NhanMo = item.ThietKeNghienCuu_NhanMo;							
				dbitem.ThietKeNghienCuu_MuDon = item.ThietKeNghienCuu_MuDon;							
				dbitem.ThietKeNghienCuu_MuDoi = item.ThietKeNghienCuu_MuDoi;							
				dbitem.MoMu_Co = item.MoMu_Co;							
				dbitem.MoMu_Khong = item.MoMu_Khong;							
				dbitem.MoMu_KhongCoThongTin = item.MoMu_KhongCoThongTin;							
				dbitem.NhaTaiTro = item.NhaTaiTro;							
				dbitem.HoTenNCV = item.HoTenNCV;							
				dbitem.DiemNghienCuu = item.DiemNghienCuu;							
				dbitem.ThoiDiemNhanThongTin = item.ThoiDiemNhanThongTin;							
				dbitem.ThoiDiemXuatHien = item.ThoiDiemXuatHien;							
				dbitem.ThoiDiemKetThuc = item.ThoiDiemKetThuc;							
				dbitem.DangTiepDien = item.DangTiepDien;							
				dbitem.TenSAE = item.TenSAE;							
				dbitem.TenNguoiThuThuoc = item.TenNguoiThuThuoc;							
				dbitem.MaSoNguoiThuThuoc = item.MaSoNguoiThuThuoc;							
				dbitem.MoTaDienBien = item.MoTaDienBien;							
				dbitem.KetQua_HoiPhucKhongDiChung = item.KetQua_HoiPhucKhongDiChung;							
				dbitem.KetQua_HoiPhucCoDiChung = item.KetQua_HoiPhucCoDiChung;							
				dbitem.KetQua_DangHoiPhuc = item.KetQua_DangHoiPhuc;							
				dbitem.KetQua_ChuaHoiPhuc = item.KetQua_ChuaHoiPhuc;							
				dbitem.KetQua_TuVong = item.KetQua_TuVong;							
				dbitem.KetQua_TuVong_Ngay = item.KetQua_TuVong_Ngay;							
				dbitem.KetQua_KhongCoThongTin = item.KetQua_KhongCoThongTin;							
				dbitem.NguoiThamGia_NgaySinh = item.NguoiThamGia_NgaySinh;							
				dbitem.NguoiThamGia_Tuoi = item.NguoiThamGia_Tuoi;							
				dbitem.NguoiThamGia_GioiTinh_Nam = item.NguoiThamGia_GioiTinh_Nam;							
				dbitem.NguoiThamGia_GioiTinh_Nu = item.NguoiThamGia_GioiTinh_Nu;							
				dbitem.NguoiThamGia_GioiTinh_Nu_DangMangThai = item.NguoiThamGia_GioiTinh_Nu_DangMangThai;							
				dbitem.NguoiThamGia_GioiTinh_Nu_TuanMangThai = item.NguoiThamGia_GioiTinh_Nu_TuanMangThai;							
				dbitem.NguoiThamGia_CanNang = item.NguoiThamGia_CanNang;							
				dbitem.NguoiThamGia_TienSuYKhoa = item.NguoiThamGia_TienSuYKhoa;							
				dbitem.JSON_ThuocThuLamSang = item.JSON_ThuocThuLamSang;							
				dbitem.JSON_CanThiepThuocThuLamSang = item.JSON_CanThiepThuocThuLamSang;							
				dbitem.JSON_ThuocSuDungDongThoi = item.JSON_ThuocSuDungDongThoi;							
				dbitem.JSON_DanhGiaNCV = item.JSON_DanhGiaNCV;							
				dbitem.LyDoDanhGia = item.LyDoDanhGia;							
				dbitem.LyDoDanhGia_SoLuong = item.LyDoDanhGia_SoLuong;							
				dbitem.LyDoDanhGia_SoLuongNghienCuuKhac = item.LyDoDanhGia_SoLuongNghienCuuKhac;							
				dbitem.YKienHDDD_NguoiThamGia_TiepTucThamGia = item.YKienHDDD_NguoiThamGia_TiepTucThamGia;							
				dbitem.YKienHDDD_NguoiThamGia_TamNgungThamGia = item.YKienHDDD_NguoiThamGia_TamNgungThamGia;							
				dbitem.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu = item.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu;							
				dbitem.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai = item.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai;							
				dbitem.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai = item.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai;							
				dbitem.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai = item.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai;							
				dbitem.YKienHDDD_DeXuatKhac = item.YKienHDDD_DeXuatKhac;							
				dbitem.NguoiBaoCao_ChuKy = item.NguoiBaoCao_ChuKy;							
				dbitem.NguoiBaoCao_NgayKy = item.NguoiBaoCao_NgayKy;							
				dbitem.NguoiBaoCao_HoTen = item.NguoiBaoCao_HoTen;							
				dbitem.NguoiBaoCao_ChucVu = item.NguoiBaoCao_ChucVu;							
				dbitem.NguoiBaoCao_DienThoai = item.NguoiBaoCao_DienThoai;							
				dbitem.NguoiBaoCao_Email = item.NguoiBaoCao_Email;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_SAE", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_SAE",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_SAE post_PRO_SAE(AppEntities db, DTO_PRO_SAE item, string Username)
        {
            tbl_PRO_SAE dbitem = new tbl_PRO_SAE();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDBenhNhan = item.IDBenhNhan;							
				dbitem.MaSo = item.MaSo;							
				dbitem.BaoCaoLanDau = item.BaoCaoLanDau;							
				dbitem.BaoCaoBoSung = item.BaoCaoBoSung;							
				dbitem.TuVong = item.TuVong;							
				dbitem.DeDoaTinhMang = item.DeDoaTinhMang;							
				dbitem.NhapVien = item.NhapVien;							
				dbitem.TanTat = item.TanTat;							
				dbitem.DiTatBamSinh = item.DiTatBamSinh;							
				dbitem.YeuCanCanThiepYKhoa = item.YeuCanCanThiepYKhoa;							
				dbitem.TenNghienCuu = item.TenNghienCuu;							
				dbitem.ThietKeNghienCuu_NhanMo = item.ThietKeNghienCuu_NhanMo;							
				dbitem.ThietKeNghienCuu_MuDon = item.ThietKeNghienCuu_MuDon;							
				dbitem.ThietKeNghienCuu_MuDoi = item.ThietKeNghienCuu_MuDoi;							
				dbitem.MoMu_Co = item.MoMu_Co;							
				dbitem.MoMu_Khong = item.MoMu_Khong;							
				dbitem.MoMu_KhongCoThongTin = item.MoMu_KhongCoThongTin;							
				dbitem.NhaTaiTro = item.NhaTaiTro;							
				dbitem.HoTenNCV = item.HoTenNCV;							
				dbitem.DiemNghienCuu = item.DiemNghienCuu;							
				dbitem.ThoiDiemNhanThongTin = item.ThoiDiemNhanThongTin;							
				dbitem.ThoiDiemXuatHien = item.ThoiDiemXuatHien;							
				dbitem.ThoiDiemKetThuc = item.ThoiDiemKetThuc;							
				dbitem.DangTiepDien = item.DangTiepDien;							
				dbitem.TenSAE = item.TenSAE;							
				dbitem.TenNguoiThuThuoc = item.TenNguoiThuThuoc;							
				dbitem.MaSoNguoiThuThuoc = item.MaSoNguoiThuThuoc;							
				dbitem.MoTaDienBien = item.MoTaDienBien;							
				dbitem.KetQua_HoiPhucKhongDiChung = item.KetQua_HoiPhucKhongDiChung;							
				dbitem.KetQua_HoiPhucCoDiChung = item.KetQua_HoiPhucCoDiChung;							
				dbitem.KetQua_DangHoiPhuc = item.KetQua_DangHoiPhuc;							
				dbitem.KetQua_ChuaHoiPhuc = item.KetQua_ChuaHoiPhuc;							
				dbitem.KetQua_TuVong = item.KetQua_TuVong;							
				dbitem.KetQua_TuVong_Ngay = item.KetQua_TuVong_Ngay;							
				dbitem.KetQua_KhongCoThongTin = item.KetQua_KhongCoThongTin;							
				dbitem.NguoiThamGia_NgaySinh = item.NguoiThamGia_NgaySinh;							
				dbitem.NguoiThamGia_Tuoi = item.NguoiThamGia_Tuoi;							
				dbitem.NguoiThamGia_GioiTinh_Nam = item.NguoiThamGia_GioiTinh_Nam;							
				dbitem.NguoiThamGia_GioiTinh_Nu = item.NguoiThamGia_GioiTinh_Nu;							
				dbitem.NguoiThamGia_GioiTinh_Nu_DangMangThai = item.NguoiThamGia_GioiTinh_Nu_DangMangThai;							
				dbitem.NguoiThamGia_GioiTinh_Nu_TuanMangThai = item.NguoiThamGia_GioiTinh_Nu_TuanMangThai;							
				dbitem.NguoiThamGia_CanNang = item.NguoiThamGia_CanNang;							
				dbitem.NguoiThamGia_TienSuYKhoa = item.NguoiThamGia_TienSuYKhoa;							
				dbitem.JSON_ThuocThuLamSang = item.JSON_ThuocThuLamSang;							
				dbitem.JSON_CanThiepThuocThuLamSang = item.JSON_CanThiepThuocThuLamSang;							
				dbitem.JSON_ThuocSuDungDongThoi = item.JSON_ThuocSuDungDongThoi;							
				dbitem.JSON_DanhGiaNCV = item.JSON_DanhGiaNCV;							
				dbitem.LyDoDanhGia = item.LyDoDanhGia;							
				dbitem.LyDoDanhGia_SoLuong = item.LyDoDanhGia_SoLuong;							
				dbitem.LyDoDanhGia_SoLuongNghienCuuKhac = item.LyDoDanhGia_SoLuongNghienCuuKhac;							
				dbitem.YKienHDDD_NguoiThamGia_TiepTucThamGia = item.YKienHDDD_NguoiThamGia_TiepTucThamGia;							
				dbitem.YKienHDDD_NguoiThamGia_TamNgungThamGia = item.YKienHDDD_NguoiThamGia_TamNgungThamGia;							
				dbitem.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu = item.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu;							
				dbitem.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai = item.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai;							
				dbitem.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai = item.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai;							
				dbitem.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai = item.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai;							
				dbitem.YKienHDDD_DeXuatKhac = item.YKienHDDD_DeXuatKhac;							
				dbitem.NguoiBaoCao_ChuKy = item.NguoiBaoCao_ChuKy;							
				dbitem.NguoiBaoCao_NgayKy = item.NguoiBaoCao_NgayKy;							
				dbitem.NguoiBaoCao_HoTen = item.NguoiBaoCao_HoTen;							
				dbitem.NguoiBaoCao_ChucVu = item.NguoiBaoCao_ChucVu;							
				dbitem.NguoiBaoCao_DienThoai = item.NguoiBaoCao_DienThoai;							
				dbitem.NguoiBaoCao_Email = item.NguoiBaoCao_Email;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_SAE.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_SAE", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_SAE",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_SAE(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_SAE.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_SAE", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_SAE",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_SAE_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_SAE.Any(e => e.ID == id);
		}
		
    }

}






