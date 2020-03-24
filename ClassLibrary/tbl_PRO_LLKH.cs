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
    
    
    public partial class tbl_PRO_LLKH
    {
        public int ID { get; set; }
        public int IDDetai { get; set; }
        public int IDNhanSu { get; set; }
        public string ImageURL { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string TruongVien { get; set; }
        public string PhongKhoa { get; set; }
        public string ChucVu { get; set; }
        public string CMND { get; set; }
        public string CMND_NgayCap { get; set; }
        public string CMND_NoiCap { get; set; }
        public string HocVi { get; set; }
        public string HocHam { get; set; }
        public string DiaChi_CoQuan { get; set; }
        public string DiaChi_CaNhan { get; set; }
        public string DienThoai_CoQuan { get; set; }
        public string DienThoai_CaNhan { get; set; }
        public string Email_CoQuan { get; set; }
        public string Email_CaNhan { get; set; }
        public string TaiKhoan_MST { get; set; }
        public string TaiKhoan_STK { get; set; }
        public string TaiKhoan_NganHang { get; set; }
        public string LinhVucChuyenMon { get; set; }
        public string LinhVuc { get; set; }
        public string ChuyenNganh { get; set; }
        public string HuongNghienCuu { get; set; }
        public string HoatDongKhac { get; set; }
        public string JSON_NgoaiNgu { get; set; }
        public string JSON_ThoiGianCongTac { get; set; }
        public string JSON_QuaTrinhDaoTao { get; set; }
        public string JSON_DeTai { get; set; }
        public string JSON_HuongDan { get; set; }
        public string JSON_CongTrinhDaCongBo_SachQuocTe { get; set; }
        public string JSON_CongTrinhDaCongBo_SachTrongNuoc { get; set; }
        public string JSON_CongTrinhDaCongBo_TapChiQuocTe { get; set; }
        public string JSON_CongTrinhDaCongBo_TapChiTrongNuoc { get; set; }
        public string JSON_CongTrinhDaCongBo_HoiNghiQuocTe { get; set; }
        public string JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc { get; set; }
        public string JSON_GiaiThuong { get; set; }
        public string JSON_ThongTinKhac_HiepHoiKhoaHoc { get; set; }
        public string JSON_ThongTinKhac_TruongDaiHoc { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string NgayKy_Ngay { get; set; }
        public string NgayKy_Thang { get; set; }
        public string NgayKy_Nam { get; set; }
        public string NgayKy_ChuKy { get; set; }
        public string NamPhongHocHam { get; set; }
        public string HocViThacSy { get; set; }
        public string NamHocViThacSy { get; set; }
        public string HocViTienSy { get; set; }
        public string NamHocViTienSy { get; set; }
        public string FormConfig { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_LLKH
	{
		public int ID { get; set; }
		public int IDDetai { get; set; }
		public int IDNhanSu { get; set; }
		public string ImageURL { get; set; }
		public string HoTen { get; set; }
		public string GioiTinh { get; set; }
		public string NgaySinh { get; set; }
		public string TruongVien { get; set; }
		public string PhongKhoa { get; set; }
		public string ChucVu { get; set; }
		public string CMND { get; set; }
		public string CMND_NgayCap { get; set; }
		public string CMND_NoiCap { get; set; }
		public string HocVi { get; set; }
		public string HocHam { get; set; }
		public string DiaChi_CoQuan { get; set; }
		public string DiaChi_CaNhan { get; set; }
		public string DienThoai_CoQuan { get; set; }
		public string DienThoai_CaNhan { get; set; }
		public string Email_CoQuan { get; set; }
		public string Email_CaNhan { get; set; }
		public string TaiKhoan_MST { get; set; }
		public string TaiKhoan_STK { get; set; }
		public string TaiKhoan_NganHang { get; set; }
		public string LinhVucChuyenMon { get; set; }
		public string LinhVuc { get; set; }
		public string ChuyenNganh { get; set; }
		public string HuongNghienCuu { get; set; }
		public string HoatDongKhac { get; set; }
		public string JSON_NgoaiNgu { get; set; }
		public string JSON_ThoiGianCongTac { get; set; }
		public string JSON_QuaTrinhDaoTao { get; set; }
		public string JSON_DeTai { get; set; }
		public string JSON_HuongDan { get; set; }
		public string JSON_CongTrinhDaCongBo_SachQuocTe { get; set; }
		public string JSON_CongTrinhDaCongBo_SachTrongNuoc { get; set; }
		public string JSON_CongTrinhDaCongBo_TapChiQuocTe { get; set; }
		public string JSON_CongTrinhDaCongBo_TapChiTrongNuoc { get; set; }
		public string JSON_CongTrinhDaCongBo_HoiNghiQuocTe { get; set; }
		public string JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc { get; set; }
		public string JSON_GiaiThuong { get; set; }
		public string JSON_ThongTinKhac_HiepHoiKhoaHoc { get; set; }
		public string JSON_ThongTinKhac_TruongDaiHoc { get; set; }
		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public string NgayKy_Ngay { get; set; }
		public string NgayKy_Thang { get; set; }
		public string NgayKy_Nam { get; set; }
		public string NgayKy_ChuKy { get; set; }
		public string NamPhongHocHam { get; set; }
		public string HocViThacSy { get; set; }
		public string NamHocViThacSy { get; set; }
		public string HocViTienSy { get; set; }
		public string NamHocViTienSy { get; set; }
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

    public static partial class BS_PRO_LLKH 
    {
		public static IQueryable<DTO_PRO_LLKH> toDTO(IQueryable<tbl_PRO_LLKH> query)
        {
			return query
			.Select(s => new DTO_PRO_LLKH(){							
				ID = s.ID,							
				IDDetai = s.IDDetai,							
				IDNhanSu = s.IDNhanSu,							
				ImageURL = s.ImageURL,							
				HoTen = s.HoTen,							
				GioiTinh = s.GioiTinh,							
				NgaySinh = s.NgaySinh,							
				TruongVien = s.TruongVien,							
				PhongKhoa = s.PhongKhoa,							
				ChucVu = s.ChucVu,							
				CMND = s.CMND,							
				CMND_NgayCap = s.CMND_NgayCap,							
				CMND_NoiCap = s.CMND_NoiCap,							
				HocVi = s.HocVi,							
				HocHam = s.HocHam,							
				DiaChi_CoQuan = s.DiaChi_CoQuan,							
				DiaChi_CaNhan = s.DiaChi_CaNhan,							
				DienThoai_CoQuan = s.DienThoai_CoQuan,							
				DienThoai_CaNhan = s.DienThoai_CaNhan,							
				Email_CoQuan = s.Email_CoQuan,							
				Email_CaNhan = s.Email_CaNhan,							
				TaiKhoan_MST = s.TaiKhoan_MST,							
				TaiKhoan_STK = s.TaiKhoan_STK,							
				TaiKhoan_NganHang = s.TaiKhoan_NganHang,							
				LinhVucChuyenMon = s.LinhVucChuyenMon,							
				LinhVuc = s.LinhVuc,							
				ChuyenNganh = s.ChuyenNganh,							
				HuongNghienCuu = s.HuongNghienCuu,							
				HoatDongKhac = s.HoatDongKhac,							
				JSON_NgoaiNgu = s.JSON_NgoaiNgu,							
				JSON_ThoiGianCongTac = s.JSON_ThoiGianCongTac,							
				JSON_QuaTrinhDaoTao = s.JSON_QuaTrinhDaoTao,							
				JSON_DeTai = s.JSON_DeTai,							
				JSON_HuongDan = s.JSON_HuongDan,							
				JSON_CongTrinhDaCongBo_SachQuocTe = s.JSON_CongTrinhDaCongBo_SachQuocTe,							
				JSON_CongTrinhDaCongBo_SachTrongNuoc = s.JSON_CongTrinhDaCongBo_SachTrongNuoc,							
				JSON_CongTrinhDaCongBo_TapChiQuocTe = s.JSON_CongTrinhDaCongBo_TapChiQuocTe,							
				JSON_CongTrinhDaCongBo_TapChiTrongNuoc = s.JSON_CongTrinhDaCongBo_TapChiTrongNuoc,							
				JSON_CongTrinhDaCongBo_HoiNghiQuocTe = s.JSON_CongTrinhDaCongBo_HoiNghiQuocTe,							
				JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc = s.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc,							
				JSON_GiaiThuong = s.JSON_GiaiThuong,							
				JSON_ThongTinKhac_HiepHoiKhoaHoc = s.JSON_ThongTinKhac_HiepHoiKhoaHoc,							
				JSON_ThongTinKhac_TruongDaiHoc = s.JSON_ThongTinKhac_TruongDaiHoc,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				NgayKy_Ngay = s.NgayKy_Ngay,							
				NgayKy_Thang = s.NgayKy_Thang,							
				NgayKy_Nam = s.NgayKy_Nam,							
				NgayKy_ChuKy = s.NgayKy_ChuKy,							
				NamPhongHocHam = s.NamPhongHocHam,							
				HocViThacSy = s.HocViThacSy,							
				NamHocViThacSy = s.NamHocViThacSy,							
				HocViTienSy = s.HocViTienSy,							
				NamHocViTienSy = s.NamHocViTienSy,							
				FormConfig = s.FormConfig,					
			});
                              
        }

		public static DTO_PRO_LLKH toDTO(tbl_PRO_LLKH dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_LLKH()
				{							
					ID = dbResult.ID,							
					IDDetai = dbResult.IDDetai,							
					IDNhanSu = dbResult.IDNhanSu,							
					ImageURL = dbResult.ImageURL,							
					HoTen = dbResult.HoTen,							
					GioiTinh = dbResult.GioiTinh,							
					NgaySinh = dbResult.NgaySinh,							
					TruongVien = dbResult.TruongVien,							
					PhongKhoa = dbResult.PhongKhoa,							
					ChucVu = dbResult.ChucVu,							
					CMND = dbResult.CMND,							
					CMND_NgayCap = dbResult.CMND_NgayCap,							
					CMND_NoiCap = dbResult.CMND_NoiCap,							
					HocVi = dbResult.HocVi,							
					HocHam = dbResult.HocHam,							
					DiaChi_CoQuan = dbResult.DiaChi_CoQuan,							
					DiaChi_CaNhan = dbResult.DiaChi_CaNhan,							
					DienThoai_CoQuan = dbResult.DienThoai_CoQuan,							
					DienThoai_CaNhan = dbResult.DienThoai_CaNhan,							
					Email_CoQuan = dbResult.Email_CoQuan,							
					Email_CaNhan = dbResult.Email_CaNhan,							
					TaiKhoan_MST = dbResult.TaiKhoan_MST,							
					TaiKhoan_STK = dbResult.TaiKhoan_STK,							
					TaiKhoan_NganHang = dbResult.TaiKhoan_NganHang,							
					LinhVucChuyenMon = dbResult.LinhVucChuyenMon,							
					LinhVuc = dbResult.LinhVuc,							
					ChuyenNganh = dbResult.ChuyenNganh,							
					HuongNghienCuu = dbResult.HuongNghienCuu,							
					HoatDongKhac = dbResult.HoatDongKhac,							
					JSON_NgoaiNgu = dbResult.JSON_NgoaiNgu,							
					JSON_ThoiGianCongTac = dbResult.JSON_ThoiGianCongTac,							
					JSON_QuaTrinhDaoTao = dbResult.JSON_QuaTrinhDaoTao,							
					JSON_DeTai = dbResult.JSON_DeTai,							
					JSON_HuongDan = dbResult.JSON_HuongDan,							
					JSON_CongTrinhDaCongBo_SachQuocTe = dbResult.JSON_CongTrinhDaCongBo_SachQuocTe,							
					JSON_CongTrinhDaCongBo_SachTrongNuoc = dbResult.JSON_CongTrinhDaCongBo_SachTrongNuoc,							
					JSON_CongTrinhDaCongBo_TapChiQuocTe = dbResult.JSON_CongTrinhDaCongBo_TapChiQuocTe,							
					JSON_CongTrinhDaCongBo_TapChiTrongNuoc = dbResult.JSON_CongTrinhDaCongBo_TapChiTrongNuoc,							
					JSON_CongTrinhDaCongBo_HoiNghiQuocTe = dbResult.JSON_CongTrinhDaCongBo_HoiNghiQuocTe,							
					JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc = dbResult.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc,							
					JSON_GiaiThuong = dbResult.JSON_GiaiThuong,							
					JSON_ThongTinKhac_HiepHoiKhoaHoc = dbResult.JSON_ThongTinKhac_HiepHoiKhoaHoc,							
					JSON_ThongTinKhac_TruongDaiHoc = dbResult.JSON_ThongTinKhac_TruongDaiHoc,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					NgayKy_Ngay = dbResult.NgayKy_Ngay,							
					NgayKy_Thang = dbResult.NgayKy_Thang,							
					NgayKy_Nam = dbResult.NgayKy_Nam,							
					NgayKy_ChuKy = dbResult.NgayKy_ChuKy,							
					NamPhongHocHam = dbResult.NamPhongHocHam,							
					HocViThacSy = dbResult.HocViThacSy,							
					NamHocViThacSy = dbResult.NamHocViThacSy,							
					HocViTienSy = dbResult.HocViTienSy,							
					NamHocViTienSy = dbResult.NamHocViTienSy,							
					FormConfig = dbResult.FormConfig,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_LLKH> get_PRO_LLKH(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_LLKH.Where(d => d.IsDeleted == false );

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

			//Query IDDetai (int)
			if (QueryStrings.Any(d => d.Key == "IDDetai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDetai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDetai));
            }

			//Query IDNhanSu (int)
			if (QueryStrings.Any(d => d.Key == "IDNhanSu"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhanSu").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhanSu));
            }

			//Query ImageURL (string)
			if (QueryStrings.Any(d => d.Key == "ImageURL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ImageURL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ImageURL").Value;
                query = query.Where(d=>d.ImageURL == keyword);
            }

			//Query HoTen (string)
			if (QueryStrings.Any(d => d.Key == "HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoTen").Value;
                query = query.Where(d=>d.HoTen == keyword);
            }

			//Query GioiTinh (string)
			if (QueryStrings.Any(d => d.Key == "GioiTinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GioiTinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GioiTinh").Value;
                query = query.Where(d=>d.GioiTinh == keyword);
            }

			//Query NgaySinh (string)
			if (QueryStrings.Any(d => d.Key == "NgaySinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgaySinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgaySinh").Value;
                query = query.Where(d=>d.NgaySinh == keyword);
            }

			//Query TruongVien (string)
			if (QueryStrings.Any(d => d.Key == "TruongVien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TruongVien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TruongVien").Value;
                query = query.Where(d=>d.TruongVien == keyword);
            }

			//Query PhongKhoa (string)
			if (QueryStrings.Any(d => d.Key == "PhongKhoa") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhongKhoa").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhongKhoa").Value;
                query = query.Where(d=>d.PhongKhoa == keyword);
            }

			//Query ChucVu (string)
			if (QueryStrings.Any(d => d.Key == "ChucVu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ChucVu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ChucVu").Value;
                query = query.Where(d=>d.ChucVu == keyword);
            }

			//Query CMND (string)
			if (QueryStrings.Any(d => d.Key == "CMND") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CMND").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CMND").Value;
                query = query.Where(d=>d.CMND == keyword);
            }

			//Query CMND_NgayCap (string)
			if (QueryStrings.Any(d => d.Key == "CMND_NgayCap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CMND_NgayCap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CMND_NgayCap").Value;
                query = query.Where(d=>d.CMND_NgayCap == keyword);
            }

			//Query CMND_NoiCap (string)
			if (QueryStrings.Any(d => d.Key == "CMND_NoiCap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CMND_NoiCap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CMND_NoiCap").Value;
                query = query.Where(d=>d.CMND_NoiCap == keyword);
            }

			//Query HocVi (string)
			if (QueryStrings.Any(d => d.Key == "HocVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HocVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HocVi").Value;
                query = query.Where(d=>d.HocVi == keyword);
            }

			//Query HocHam (string)
			if (QueryStrings.Any(d => d.Key == "HocHam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HocHam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HocHam").Value;
                query = query.Where(d=>d.HocHam == keyword);
            }

			//Query DiaChi_CoQuan (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi_CoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi_CoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi_CoQuan").Value;
                query = query.Where(d=>d.DiaChi_CoQuan == keyword);
            }

			//Query DiaChi_CaNhan (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi_CaNhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi_CaNhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi_CaNhan").Value;
                query = query.Where(d=>d.DiaChi_CaNhan == keyword);
            }

			//Query DienThoai_CoQuan (string)
			if (QueryStrings.Any(d => d.Key == "DienThoai_CoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoai_CoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoai_CoQuan").Value;
                query = query.Where(d=>d.DienThoai_CoQuan == keyword);
            }

			//Query DienThoai_CaNhan (string)
			if (QueryStrings.Any(d => d.Key == "DienThoai_CaNhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoai_CaNhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoai_CaNhan").Value;
                query = query.Where(d=>d.DienThoai_CaNhan == keyword);
            }

			//Query Email_CoQuan (string)
			if (QueryStrings.Any(d => d.Key == "Email_CoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email_CoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email_CoQuan").Value;
                query = query.Where(d=>d.Email_CoQuan == keyword);
            }

			//Query Email_CaNhan (string)
			if (QueryStrings.Any(d => d.Key == "Email_CaNhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email_CaNhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email_CaNhan").Value;
                query = query.Where(d=>d.Email_CaNhan == keyword);
            }

			//Query TaiKhoan_MST (string)
			if (QueryStrings.Any(d => d.Key == "TaiKhoan_MST") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TaiKhoan_MST").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TaiKhoan_MST").Value;
                query = query.Where(d=>d.TaiKhoan_MST == keyword);
            }

			//Query TaiKhoan_STK (string)
			if (QueryStrings.Any(d => d.Key == "TaiKhoan_STK") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TaiKhoan_STK").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TaiKhoan_STK").Value;
                query = query.Where(d=>d.TaiKhoan_STK == keyword);
            }

			//Query TaiKhoan_NganHang (string)
			if (QueryStrings.Any(d => d.Key == "TaiKhoan_NganHang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TaiKhoan_NganHang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TaiKhoan_NganHang").Value;
                query = query.Where(d=>d.TaiKhoan_NganHang == keyword);
            }

			//Query LinhVucChuyenMon (string)
			if (QueryStrings.Any(d => d.Key == "LinhVucChuyenMon") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LinhVucChuyenMon").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LinhVucChuyenMon").Value;
                query = query.Where(d=>d.LinhVucChuyenMon == keyword);
            }

			//Query LinhVuc (string)
			if (QueryStrings.Any(d => d.Key == "LinhVuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LinhVuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LinhVuc").Value;
                query = query.Where(d=>d.LinhVuc == keyword);
            }

			//Query ChuyenNganh (string)
			if (QueryStrings.Any(d => d.Key == "ChuyenNganh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ChuyenNganh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ChuyenNganh").Value;
                query = query.Where(d=>d.ChuyenNganh == keyword);
            }

			//Query HuongNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "HuongNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HuongNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HuongNghienCuu").Value;
                query = query.Where(d=>d.HuongNghienCuu == keyword);
            }

			//Query HoatDongKhac (string)
			if (QueryStrings.Any(d => d.Key == "HoatDongKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoatDongKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoatDongKhac").Value;
                query = query.Where(d=>d.HoatDongKhac == keyword);
            }

			//Query JSON_NgoaiNgu (string)
			if (QueryStrings.Any(d => d.Key == "JSON_NgoaiNgu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_NgoaiNgu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_NgoaiNgu").Value;
                query = query.Where(d=>d.JSON_NgoaiNgu == keyword);
            }

			//Query JSON_ThoiGianCongTac (string)
			if (QueryStrings.Any(d => d.Key == "JSON_ThoiGianCongTac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThoiGianCongTac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThoiGianCongTac").Value;
                query = query.Where(d=>d.JSON_ThoiGianCongTac == keyword);
            }

			//Query JSON_QuaTrinhDaoTao (string)
			if (QueryStrings.Any(d => d.Key == "JSON_QuaTrinhDaoTao") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_QuaTrinhDaoTao").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_QuaTrinhDaoTao").Value;
                query = query.Where(d=>d.JSON_QuaTrinhDaoTao == keyword);
            }

			//Query JSON_DeTai (string)
			if (QueryStrings.Any(d => d.Key == "JSON_DeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_DeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_DeTai").Value;
                query = query.Where(d=>d.JSON_DeTai == keyword);
            }

			//Query JSON_HuongDan (string)
			if (QueryStrings.Any(d => d.Key == "JSON_HuongDan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_HuongDan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_HuongDan").Value;
                query = query.Where(d=>d.JSON_HuongDan == keyword);
            }

			//Query JSON_CongTrinhDaCongBo_SachQuocTe (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CongTrinhDaCongBo_SachQuocTe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_SachQuocTe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_SachQuocTe").Value;
                query = query.Where(d=>d.JSON_CongTrinhDaCongBo_SachQuocTe == keyword);
            }

			//Query JSON_CongTrinhDaCongBo_SachTrongNuoc (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CongTrinhDaCongBo_SachTrongNuoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_SachTrongNuoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_SachTrongNuoc").Value;
                query = query.Where(d=>d.JSON_CongTrinhDaCongBo_SachTrongNuoc == keyword);
            }

			//Query JSON_CongTrinhDaCongBo_TapChiQuocTe (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CongTrinhDaCongBo_TapChiQuocTe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_TapChiQuocTe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_TapChiQuocTe").Value;
                query = query.Where(d=>d.JSON_CongTrinhDaCongBo_TapChiQuocTe == keyword);
            }

			//Query JSON_CongTrinhDaCongBo_TapChiTrongNuoc (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CongTrinhDaCongBo_TapChiTrongNuoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_TapChiTrongNuoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_TapChiTrongNuoc").Value;
                query = query.Where(d=>d.JSON_CongTrinhDaCongBo_TapChiTrongNuoc == keyword);
            }

			//Query JSON_CongTrinhDaCongBo_HoiNghiQuocTe (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CongTrinhDaCongBo_HoiNghiQuocTe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_HoiNghiQuocTe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_HoiNghiQuocTe").Value;
                query = query.Where(d=>d.JSON_CongTrinhDaCongBo_HoiNghiQuocTe == keyword);
            }

			//Query JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc").Value;
                query = query.Where(d=>d.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc == keyword);
            }

			//Query JSON_GiaiThuong (string)
			if (QueryStrings.Any(d => d.Key == "JSON_GiaiThuong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_GiaiThuong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_GiaiThuong").Value;
                query = query.Where(d=>d.JSON_GiaiThuong == keyword);
            }

			//Query JSON_ThongTinKhac_HiepHoiKhoaHoc (string)
			if (QueryStrings.Any(d => d.Key == "JSON_ThongTinKhac_HiepHoiKhoaHoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThongTinKhac_HiepHoiKhoaHoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThongTinKhac_HiepHoiKhoaHoc").Value;
                query = query.Where(d=>d.JSON_ThongTinKhac_HiepHoiKhoaHoc == keyword);
            }

			//Query JSON_ThongTinKhac_TruongDaiHoc (string)
			if (QueryStrings.Any(d => d.Key == "JSON_ThongTinKhac_TruongDaiHoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThongTinKhac_TruongDaiHoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_ThongTinKhac_TruongDaiHoc").Value;
                query = query.Where(d=>d.JSON_ThongTinKhac_TruongDaiHoc == keyword);
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

			//Query NgayKy_ChuKy (string)
			if (QueryStrings.Any(d => d.Key == "NgayKy_ChuKy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_ChuKy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgayKy_ChuKy").Value;
                query = query.Where(d=>d.NgayKy_ChuKy == keyword);
            }

			//Query NamPhongHocHam (string)
			if (QueryStrings.Any(d => d.Key == "NamPhongHocHam") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NamPhongHocHam").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NamPhongHocHam").Value;
                query = query.Where(d=>d.NamPhongHocHam == keyword);
            }

			//Query HocViThacSy (string)
			if (QueryStrings.Any(d => d.Key == "HocViThacSy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HocViThacSy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HocViThacSy").Value;
                query = query.Where(d=>d.HocViThacSy == keyword);
            }

			//Query NamHocViThacSy (string)
			if (QueryStrings.Any(d => d.Key == "NamHocViThacSy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NamHocViThacSy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NamHocViThacSy").Value;
                query = query.Where(d=>d.NamHocViThacSy == keyword);
            }

			//Query HocViTienSy (string)
			if (QueryStrings.Any(d => d.Key == "HocViTienSy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HocViTienSy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HocViTienSy").Value;
                query = query.Where(d=>d.HocViTienSy == keyword);
            }

			//Query NamHocViTienSy (string)
			if (QueryStrings.Any(d => d.Key == "NamHocViTienSy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NamHocViTienSy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NamHocViTienSy").Value;
                query = query.Where(d=>d.NamHocViTienSy == keyword);
            }

			//Query FormConfig (string)
			if (QueryStrings.Any(d => d.Key == "FormConfig") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value;
                query = query.Where(d=>d.FormConfig == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_LLKH get_PRO_LLKH(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_LLKH.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_LLKH(AppEntities db, int ID, DTO_PRO_LLKH item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_LLKH.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDetai = item.IDDetai;							
				dbitem.IDNhanSu = item.IDNhanSu;							
				dbitem.ImageURL = item.ImageURL;							
				dbitem.HoTen = item.HoTen;							
				dbitem.GioiTinh = item.GioiTinh;							
				dbitem.NgaySinh = item.NgaySinh;							
				dbitem.TruongVien = item.TruongVien;							
				dbitem.PhongKhoa = item.PhongKhoa;							
				dbitem.ChucVu = item.ChucVu;							
				dbitem.CMND = item.CMND;							
				dbitem.CMND_NgayCap = item.CMND_NgayCap;							
				dbitem.CMND_NoiCap = item.CMND_NoiCap;							
				dbitem.HocVi = item.HocVi;							
				dbitem.HocHam = item.HocHam;							
				dbitem.DiaChi_CoQuan = item.DiaChi_CoQuan;							
				dbitem.DiaChi_CaNhan = item.DiaChi_CaNhan;							
				dbitem.DienThoai_CoQuan = item.DienThoai_CoQuan;							
				dbitem.DienThoai_CaNhan = item.DienThoai_CaNhan;							
				dbitem.Email_CoQuan = item.Email_CoQuan;							
				dbitem.Email_CaNhan = item.Email_CaNhan;							
				dbitem.TaiKhoan_MST = item.TaiKhoan_MST;							
				dbitem.TaiKhoan_STK = item.TaiKhoan_STK;							
				dbitem.TaiKhoan_NganHang = item.TaiKhoan_NganHang;							
				dbitem.LinhVucChuyenMon = item.LinhVucChuyenMon;							
				dbitem.LinhVuc = item.LinhVuc;							
				dbitem.ChuyenNganh = item.ChuyenNganh;							
				dbitem.HuongNghienCuu = item.HuongNghienCuu;							
				dbitem.HoatDongKhac = item.HoatDongKhac;							
				dbitem.JSON_NgoaiNgu = item.JSON_NgoaiNgu;							
				dbitem.JSON_ThoiGianCongTac = item.JSON_ThoiGianCongTac;							
				dbitem.JSON_QuaTrinhDaoTao = item.JSON_QuaTrinhDaoTao;							
				dbitem.JSON_DeTai = item.JSON_DeTai;							
				dbitem.JSON_HuongDan = item.JSON_HuongDan;							
				dbitem.JSON_CongTrinhDaCongBo_SachQuocTe = item.JSON_CongTrinhDaCongBo_SachQuocTe;							
				dbitem.JSON_CongTrinhDaCongBo_SachTrongNuoc = item.JSON_CongTrinhDaCongBo_SachTrongNuoc;							
				dbitem.JSON_CongTrinhDaCongBo_TapChiQuocTe = item.JSON_CongTrinhDaCongBo_TapChiQuocTe;							
				dbitem.JSON_CongTrinhDaCongBo_TapChiTrongNuoc = item.JSON_CongTrinhDaCongBo_TapChiTrongNuoc;							
				dbitem.JSON_CongTrinhDaCongBo_HoiNghiQuocTe = item.JSON_CongTrinhDaCongBo_HoiNghiQuocTe;							
				dbitem.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc = item.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc;							
				dbitem.JSON_GiaiThuong = item.JSON_GiaiThuong;							
				dbitem.JSON_ThongTinKhac_HiepHoiKhoaHoc = item.JSON_ThongTinKhac_HiepHoiKhoaHoc;							
				dbitem.JSON_ThongTinKhac_TruongDaiHoc = item.JSON_ThongTinKhac_TruongDaiHoc;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;							
				dbitem.NamPhongHocHam = item.NamPhongHocHam;							
				dbitem.HocViThacSy = item.HocViThacSy;							
				dbitem.NamHocViThacSy = item.NamHocViThacSy;							
				dbitem.HocViTienSy = item.HocViTienSy;							
				dbitem.NamHocViTienSy = item.NamHocViTienSy;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_LLKH", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_LLKH",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_LLKH post_PRO_LLKH(AppEntities db, DTO_PRO_LLKH item, string Username)
        {
            tbl_PRO_LLKH dbitem = new tbl_PRO_LLKH();
            if (item != null)
            {							
				dbitem.IDDetai = item.IDDetai;							
				dbitem.IDNhanSu = item.IDNhanSu;							
				dbitem.ImageURL = item.ImageURL;							
				dbitem.HoTen = item.HoTen;							
				dbitem.GioiTinh = item.GioiTinh;							
				dbitem.NgaySinh = item.NgaySinh;							
				dbitem.TruongVien = item.TruongVien;							
				dbitem.PhongKhoa = item.PhongKhoa;							
				dbitem.ChucVu = item.ChucVu;							
				dbitem.CMND = item.CMND;							
				dbitem.CMND_NgayCap = item.CMND_NgayCap;							
				dbitem.CMND_NoiCap = item.CMND_NoiCap;							
				dbitem.HocVi = item.HocVi;							
				dbitem.HocHam = item.HocHam;							
				dbitem.DiaChi_CoQuan = item.DiaChi_CoQuan;							
				dbitem.DiaChi_CaNhan = item.DiaChi_CaNhan;							
				dbitem.DienThoai_CoQuan = item.DienThoai_CoQuan;							
				dbitem.DienThoai_CaNhan = item.DienThoai_CaNhan;							
				dbitem.Email_CoQuan = item.Email_CoQuan;							
				dbitem.Email_CaNhan = item.Email_CaNhan;							
				dbitem.TaiKhoan_MST = item.TaiKhoan_MST;							
				dbitem.TaiKhoan_STK = item.TaiKhoan_STK;							
				dbitem.TaiKhoan_NganHang = item.TaiKhoan_NganHang;							
				dbitem.LinhVucChuyenMon = item.LinhVucChuyenMon;							
				dbitem.LinhVuc = item.LinhVuc;							
				dbitem.ChuyenNganh = item.ChuyenNganh;							
				dbitem.HuongNghienCuu = item.HuongNghienCuu;							
				dbitem.HoatDongKhac = item.HoatDongKhac;							
				dbitem.JSON_NgoaiNgu = item.JSON_NgoaiNgu;							
				dbitem.JSON_ThoiGianCongTac = item.JSON_ThoiGianCongTac;							
				dbitem.JSON_QuaTrinhDaoTao = item.JSON_QuaTrinhDaoTao;							
				dbitem.JSON_DeTai = item.JSON_DeTai;							
				dbitem.JSON_HuongDan = item.JSON_HuongDan;							
				dbitem.JSON_CongTrinhDaCongBo_SachQuocTe = item.JSON_CongTrinhDaCongBo_SachQuocTe;							
				dbitem.JSON_CongTrinhDaCongBo_SachTrongNuoc = item.JSON_CongTrinhDaCongBo_SachTrongNuoc;							
				dbitem.JSON_CongTrinhDaCongBo_TapChiQuocTe = item.JSON_CongTrinhDaCongBo_TapChiQuocTe;							
				dbitem.JSON_CongTrinhDaCongBo_TapChiTrongNuoc = item.JSON_CongTrinhDaCongBo_TapChiTrongNuoc;							
				dbitem.JSON_CongTrinhDaCongBo_HoiNghiQuocTe = item.JSON_CongTrinhDaCongBo_HoiNghiQuocTe;							
				dbitem.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc = item.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc;							
				dbitem.JSON_GiaiThuong = item.JSON_GiaiThuong;							
				dbitem.JSON_ThongTinKhac_HiepHoiKhoaHoc = item.JSON_ThongTinKhac_HiepHoiKhoaHoc;							
				dbitem.JSON_ThongTinKhac_TruongDaiHoc = item.JSON_ThongTinKhac_TruongDaiHoc;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;							
				dbitem.NamPhongHocHam = item.NamPhongHocHam;							
				dbitem.HocViThacSy = item.HocViThacSy;							
				dbitem.NamHocViThacSy = item.NamHocViThacSy;							
				dbitem.HocViTienSy = item.HocViTienSy;							
				dbitem.NamHocViTienSy = item.NamHocViTienSy;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_LLKH.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_LLKH", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_LLKH",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_LLKH(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_LLKH.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_LLKH", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_LLKH",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_LLKH_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_LLKH.Any(e => e.ID == id);
		}
		
    }

}






