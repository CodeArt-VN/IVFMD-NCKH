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
    
    
    public partial class tbl_PRO_DonXinDanhGiaDaoDuc
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string HoTenChuNhiem { get; set; }
        public string DonVi { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenDeTai { get; set; }
        public string TenDonViChuTri { get; set; }
        public string DiaChiDonVi { get; set; }
        public string DienThoaiDonVi { get; set; }
        public string DiaDiemNghienCuu { get; set; }
        public string ThoiGianNghienCuu { get; set; }
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        public bool BangKiemLuaChon { get; set; }
        public bool PhieuThongTinXemXet { get; set; }
        public bool DeCuongNCYSH { get; set; }
        public bool CacBangCauHoi { get; set; }
        public bool MauPhieuChapThuanTinhNguyen { get; set; }
        public bool TrangThongTinGioiThieu { get; set; }
        public bool SYLLChuNhiem { get; set; }
        public bool GiayToKhac { get; set; }
        public string GhiChuGiayToKhac { get; set; }
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
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_DonXinDanhGiaDaoDuc
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string HoTenChuNhiem { get; set; }
		public string DonVi { get; set; }
		public string DiaChi { get; set; }
		public string DienThoai { get; set; }
		public string TenDeTai { get; set; }
		public string TenDonViChuTri { get; set; }
		public string DiaChiDonVi { get; set; }
		public string DienThoaiDonVi { get; set; }
		public string DiaDiemNghienCuu { get; set; }
		public string ThoiGianNghienCuu { get; set; }
		public string TuNgay { get; set; }
		public string DenNgay { get; set; }
		public bool BangKiemLuaChon { get; set; }
		public bool PhieuThongTinXemXet { get; set; }
		public bool DeCuongNCYSH { get; set; }
		public bool CacBangCauHoi { get; set; }
		public bool MauPhieuChapThuanTinhNguyen { get; set; }
		public bool TrangThongTinGioiThieu { get; set; }
		public bool SYLLChuNhiem { get; set; }
		public bool GiayToKhac { get; set; }
		public string GhiChuGiayToKhac { get; set; }
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

    public static partial class BS_PRO_DonXinDanhGiaDaoDuc 
    {
		public static IQueryable<DTO_PRO_DonXinDanhGiaDaoDuc> toDTO(IQueryable<tbl_PRO_DonXinDanhGiaDaoDuc> query)
        {
			return query
			.Select(s => new DTO_PRO_DonXinDanhGiaDaoDuc(){							
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
				BangKiemLuaChon = s.BangKiemLuaChon,							
				PhieuThongTinXemXet = s.PhieuThongTinXemXet,							
				DeCuongNCYSH = s.DeCuongNCYSH,							
				CacBangCauHoi = s.CacBangCauHoi,							
				MauPhieuChapThuanTinhNguyen = s.MauPhieuChapThuanTinhNguyen,							
				TrangThongTinGioiThieu = s.TrangThongTinGioiThieu,							
				SYLLChuNhiem = s.SYLLChuNhiem,							
				GiayToKhac = s.GiayToKhac,							
				GhiChuGiayToKhac = s.GhiChuGiayToKhac,							
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
			});
                              
        }

		public static DTO_PRO_DonXinDanhGiaDaoDuc toDTO(tbl_PRO_DonXinDanhGiaDaoDuc dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_DonXinDanhGiaDaoDuc()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					HoTenChuNhiem = dbResult.HoTenChuNhiem,							
					DonVi = dbResult.DonVi,							
					DiaChi = dbResult.DiaChi,							
					DienThoai = dbResult.DienThoai,							
					TenDeTai = dbResult.TenDeTai,							
					TenDonViChuTri = dbResult.TenDonViChuTri,							
					DiaChiDonVi = dbResult.DiaChiDonVi,							
					DienThoaiDonVi = dbResult.DienThoaiDonVi,							
					DiaDiemNghienCuu = dbResult.DiaDiemNghienCuu,							
					ThoiGianNghienCuu = dbResult.ThoiGianNghienCuu,							
					TuNgay = dbResult.TuNgay,							
					DenNgay = dbResult.DenNgay,							
					BangKiemLuaChon = dbResult.BangKiemLuaChon,							
					PhieuThongTinXemXet = dbResult.PhieuThongTinXemXet,							
					DeCuongNCYSH = dbResult.DeCuongNCYSH,							
					CacBangCauHoi = dbResult.CacBangCauHoi,							
					MauPhieuChapThuanTinhNguyen = dbResult.MauPhieuChapThuanTinhNguyen,							
					TrangThongTinGioiThieu = dbResult.TrangThongTinGioiThieu,							
					SYLLChuNhiem = dbResult.SYLLChuNhiem,							
					GiayToKhac = dbResult.GiayToKhac,							
					GhiChuGiayToKhac = dbResult.GhiChuGiayToKhac,							
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
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_DonXinDanhGiaDaoDuc> get_PRO_DonXinDanhGiaDaoDuc(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_DonXinDanhGiaDaoDuc.Where(d => d.IsDeleted == false );

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

			//Query HoTenChuNhiem (string)
			if (QueryStrings.Any(d => d.Key == "HoTenChuNhiem") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoTenChuNhiem").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoTenChuNhiem").Value;
                query = query.Where(d=>d.HoTenChuNhiem == keyword);
            }

			//Query DonVi (string)
			if (QueryStrings.Any(d => d.Key == "DonVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DonVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DonVi").Value;
                query = query.Where(d=>d.DonVi == keyword);
            }

			//Query DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value;
                query = query.Where(d=>d.DiaChi == keyword);
            }

			//Query DienThoai (string)
			if (QueryStrings.Any(d => d.Key == "DienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoai").Value;
                query = query.Where(d=>d.DienThoai == keyword);
            }

			//Query TenDeTai (string)
			if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d=>d.TenDeTai == keyword);
            }

			//Query TenDonViChuTri (string)
			if (QueryStrings.Any(d => d.Key == "TenDonViChuTri") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDonViChuTri").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDonViChuTri").Value;
                query = query.Where(d=>d.TenDonViChuTri == keyword);
            }

			//Query DiaChiDonVi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChiDonVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChiDonVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChiDonVi").Value;
                query = query.Where(d=>d.DiaChiDonVi == keyword);
            }

			//Query DienThoaiDonVi (string)
			if (QueryStrings.Any(d => d.Key == "DienThoaiDonVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiDonVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiDonVi").Value;
                query = query.Where(d=>d.DienThoaiDonVi == keyword);
            }

			//Query DiaDiemNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "DiaDiemNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaDiemNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaDiemNghienCuu").Value;
                query = query.Where(d=>d.DiaDiemNghienCuu == keyword);
            }

			//Query ThoiGianNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu").Value;
                query = query.Where(d=>d.ThoiGianNghienCuu == keyword);
            }

			//Query TuNgay (string)
			if (QueryStrings.Any(d => d.Key == "TuNgay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TuNgay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TuNgay").Value;
                query = query.Where(d=>d.TuNgay == keyword);
            }

			//Query DenNgay (string)
			if (QueryStrings.Any(d => d.Key == "DenNgay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DenNgay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DenNgay").Value;
                query = query.Where(d=>d.DenNgay == keyword);
            }

			//Query BangKiemLuaChon (bool)
			if (QueryStrings.Any(d => d.Key == "BangKiemLuaChon"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "BangKiemLuaChon").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.BangKiemLuaChon);
            }

			//Query PhieuThongTinXemXet (bool)
			if (QueryStrings.Any(d => d.Key == "PhieuThongTinXemXet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "PhieuThongTinXemXet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.PhieuThongTinXemXet);
            }

			//Query DeCuongNCYSH (bool)
			if (QueryStrings.Any(d => d.Key == "DeCuongNCYSH"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DeCuongNCYSH").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DeCuongNCYSH);
            }

			//Query CacBangCauHoi (bool)
			if (QueryStrings.Any(d => d.Key == "CacBangCauHoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "CacBangCauHoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.CacBangCauHoi);
            }

			//Query MauPhieuChapThuanTinhNguyen (bool)
			if (QueryStrings.Any(d => d.Key == "MauPhieuChapThuanTinhNguyen"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "MauPhieuChapThuanTinhNguyen").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.MauPhieuChapThuanTinhNguyen);
            }

			//Query TrangThongTinGioiThieu (bool)
			if (QueryStrings.Any(d => d.Key == "TrangThongTinGioiThieu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "TrangThongTinGioiThieu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.TrangThongTinGioiThieu);
            }

			//Query SYLLChuNhiem (bool)
			if (QueryStrings.Any(d => d.Key == "SYLLChuNhiem"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "SYLLChuNhiem").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.SYLLChuNhiem);
            }

			//Query GiayToKhac (bool)
			if (QueryStrings.Any(d => d.Key == "GiayToKhac"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "GiayToKhac").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.GiayToKhac);
            }

			//Query GhiChuGiayToKhac (string)
			if (QueryStrings.Any(d => d.Key == "GhiChuGiayToKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GhiChuGiayToKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GhiChuGiayToKhac").Value;
                query = query.Where(d=>d.GhiChuGiayToKhac == keyword);
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


			return toDTO(query);

        }

		public static DTO_PRO_DonXinDanhGiaDaoDuc get_PRO_DonXinDanhGiaDaoDuc(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_DonXinDanhGiaDaoDuc.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_DonXinDanhGiaDaoDuc(AppEntities db, int ID, DTO_PRO_DonXinDanhGiaDaoDuc item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_DonXinDanhGiaDaoDuc.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.HoTenChuNhiem = item.HoTenChuNhiem;							
				dbitem.DonVi = item.DonVi;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoai = item.DienThoai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.TenDonViChuTri = item.TenDonViChuTri;							
				dbitem.DiaChiDonVi = item.DiaChiDonVi;							
				dbitem.DienThoaiDonVi = item.DienThoaiDonVi;							
				dbitem.DiaDiemNghienCuu = item.DiaDiemNghienCuu;							
				dbitem.ThoiGianNghienCuu = item.ThoiGianNghienCuu;							
				dbitem.TuNgay = item.TuNgay;							
				dbitem.DenNgay = item.DenNgay;							
				dbitem.BangKiemLuaChon = item.BangKiemLuaChon;							
				dbitem.PhieuThongTinXemXet = item.PhieuThongTinXemXet;							
				dbitem.DeCuongNCYSH = item.DeCuongNCYSH;							
				dbitem.CacBangCauHoi = item.CacBangCauHoi;							
				dbitem.MauPhieuChapThuanTinhNguyen = item.MauPhieuChapThuanTinhNguyen;							
				dbitem.TrangThongTinGioiThieu = item.TrangThongTinGioiThieu;							
				dbitem.SYLLChuNhiem = item.SYLLChuNhiem;							
				dbitem.GiayToKhac = item.GiayToKhac;							
				dbitem.GhiChuGiayToKhac = item.GhiChuGiayToKhac;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinDanhGiaDaoDuc", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_DonXinDanhGiaDaoDuc",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_DonXinDanhGiaDaoDuc post_PRO_DonXinDanhGiaDaoDuc(AppEntities db, DTO_PRO_DonXinDanhGiaDaoDuc item, string Username)
        {
            tbl_PRO_DonXinDanhGiaDaoDuc dbitem = new tbl_PRO_DonXinDanhGiaDaoDuc();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.HoTenChuNhiem = item.HoTenChuNhiem;							
				dbitem.DonVi = item.DonVi;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoai = item.DienThoai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.TenDonViChuTri = item.TenDonViChuTri;							
				dbitem.DiaChiDonVi = item.DiaChiDonVi;							
				dbitem.DienThoaiDonVi = item.DienThoaiDonVi;							
				dbitem.DiaDiemNghienCuu = item.DiaDiemNghienCuu;							
				dbitem.ThoiGianNghienCuu = item.ThoiGianNghienCuu;							
				dbitem.TuNgay = item.TuNgay;							
				dbitem.DenNgay = item.DenNgay;							
				dbitem.BangKiemLuaChon = item.BangKiemLuaChon;							
				dbitem.PhieuThongTinXemXet = item.PhieuThongTinXemXet;							
				dbitem.DeCuongNCYSH = item.DeCuongNCYSH;							
				dbitem.CacBangCauHoi = item.CacBangCauHoi;							
				dbitem.MauPhieuChapThuanTinhNguyen = item.MauPhieuChapThuanTinhNguyen;							
				dbitem.TrangThongTinGioiThieu = item.TrangThongTinGioiThieu;							
				dbitem.SYLLChuNhiem = item.SYLLChuNhiem;							
				dbitem.GiayToKhac = item.GiayToKhac;							
				dbitem.GhiChuGiayToKhac = item.GhiChuGiayToKhac;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_DonXinDanhGiaDaoDuc.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinDanhGiaDaoDuc", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_DonXinDanhGiaDaoDuc",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_DonXinDanhGiaDaoDuc(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_DonXinDanhGiaDaoDuc.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinDanhGiaDaoDuc", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_DonXinDanhGiaDaoDuc",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_DonXinDanhGiaDaoDuc_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_DonXinDanhGiaDaoDuc.Any(e => e.ID == id);
		}
		
    }

}






