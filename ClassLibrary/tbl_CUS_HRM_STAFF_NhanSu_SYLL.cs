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
    
    
    public partial class tbl_CUS_HRM_STAFF_NhanSu_SYLL
    {
        public int ID { get; set; }
        public int IDNhanSu { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoaiCQ { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public string CoQuanLamViec { get; set; }
        public string ThuTruongCoQuan { get; set; }
        public string DienThoaiThuTruong { get; set; }
        public string DiaChiCoQuan { get; set; }
        public string JSON_TrinhDoChuyenMon { get; set; }
        public string JSON_KinhNghiem { get; set; }
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
        public string DienThoaiNhaRieng { get; set; }
        public string JSON_HocVi { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_HRM_STAFF_NhanSu_SYLL
	{
		public int ID { get; set; }
		public int IDNhanSu { get; set; }
		public string HoTen { get; set; }
		public string GioiTinh { get; set; }
		public string NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public string DienThoaiCQ { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public string ChucVu { get; set; }
		public string CoQuanLamViec { get; set; }
		public string ThuTruongCoQuan { get; set; }
		public string DienThoaiThuTruong { get; set; }
		public string DiaChiCoQuan { get; set; }
		public string JSON_TrinhDoChuyenMon { get; set; }
		public string JSON_KinhNghiem { get; set; }
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
		public string DienThoaiNhaRieng { get; set; }
		public string JSON_HocVi { get; set; }
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

    public static partial class BS_CUS_HRM_STAFF_NhanSu_SYLL 
    {
		public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu_SYLL> toDTO(IQueryable<tbl_CUS_HRM_STAFF_NhanSu_SYLL> query)
        {
			return query
			.Select(s => new DTO_CUS_HRM_STAFF_NhanSu_SYLL(){							
				ID = s.ID,							
				IDNhanSu = s.IDNhanSu,							
				HoTen = s.HoTen,							
				GioiTinh = s.GioiTinh,							
				NgaySinh = s.NgaySinh,							
				DiaChi = s.DiaChi,							
				DienThoaiCQ = s.DienThoaiCQ,							
				Mobile = s.Mobile,							
				Email = s.Email,							
				ChucVu = s.ChucVu,							
				CoQuanLamViec = s.CoQuanLamViec,							
				ThuTruongCoQuan = s.ThuTruongCoQuan,							
				DienThoaiThuTruong = s.DienThoaiThuTruong,							
				DiaChiCoQuan = s.DiaChiCoQuan,							
				JSON_TrinhDoChuyenMon = s.JSON_TrinhDoChuyenMon,							
				JSON_KinhNghiem = s.JSON_KinhNghiem,							
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
				DienThoaiNhaRieng = s.DienThoaiNhaRieng,							
				JSON_HocVi = s.JSON_HocVi,					
			});
                              
        }

		public static DTO_CUS_HRM_STAFF_NhanSu_SYLL toDTO(tbl_CUS_HRM_STAFF_NhanSu_SYLL dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_HRM_STAFF_NhanSu_SYLL()
				{							
					ID = dbResult.ID,							
					IDNhanSu = dbResult.IDNhanSu,							
					HoTen = dbResult.HoTen,							
					GioiTinh = dbResult.GioiTinh,							
					NgaySinh = dbResult.NgaySinh,							
					DiaChi = dbResult.DiaChi,							
					DienThoaiCQ = dbResult.DienThoaiCQ,							
					Mobile = dbResult.Mobile,							
					Email = dbResult.Email,							
					ChucVu = dbResult.ChucVu,							
					CoQuanLamViec = dbResult.CoQuanLamViec,							
					ThuTruongCoQuan = dbResult.ThuTruongCoQuan,							
					DienThoaiThuTruong = dbResult.DienThoaiThuTruong,							
					DiaChiCoQuan = dbResult.DiaChiCoQuan,							
					JSON_TrinhDoChuyenMon = dbResult.JSON_TrinhDoChuyenMon,							
					JSON_KinhNghiem = dbResult.JSON_KinhNghiem,							
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
					DienThoaiNhaRieng = dbResult.DienThoaiNhaRieng,							
					JSON_HocVi = dbResult.JSON_HocVi,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu_SYLL> get_CUS_HRM_STAFF_NhanSu_SYLL(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Where(d => d.IsDeleted == false );

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

			//Query DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value;
                query = query.Where(d=>d.DiaChi == keyword);
            }

			//Query DienThoaiCQ (string)
			if (QueryStrings.Any(d => d.Key == "DienThoaiCQ") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiCQ").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiCQ").Value;
                query = query.Where(d=>d.DienThoaiCQ == keyword);
            }

			//Query Mobile (string)
			if (QueryStrings.Any(d => d.Key == "Mobile") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Mobile").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Mobile").Value;
                query = query.Where(d=>d.Mobile == keyword);
            }

			//Query Email (string)
			if (QueryStrings.Any(d => d.Key == "Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email").Value;
                query = query.Where(d=>d.Email == keyword);
            }

			//Query ChucVu (string)
			if (QueryStrings.Any(d => d.Key == "ChucVu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ChucVu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ChucVu").Value;
                query = query.Where(d=>d.ChucVu == keyword);
            }

			//Query CoQuanLamViec (string)
			if (QueryStrings.Any(d => d.Key == "CoQuanLamViec") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CoQuanLamViec").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CoQuanLamViec").Value;
                query = query.Where(d=>d.CoQuanLamViec == keyword);
            }

			//Query ThuTruongCoQuan (string)
			if (QueryStrings.Any(d => d.Key == "ThuTruongCoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThuTruongCoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThuTruongCoQuan").Value;
                query = query.Where(d=>d.ThuTruongCoQuan == keyword);
            }

			//Query DienThoaiThuTruong (string)
			if (QueryStrings.Any(d => d.Key == "DienThoaiThuTruong") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiThuTruong").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiThuTruong").Value;
                query = query.Where(d=>d.DienThoaiThuTruong == keyword);
            }

			//Query DiaChiCoQuan (string)
			if (QueryStrings.Any(d => d.Key == "DiaChiCoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChiCoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChiCoQuan").Value;
                query = query.Where(d=>d.DiaChiCoQuan == keyword);
            }

			//Query JSON_TrinhDoChuyenMon (string)
			if (QueryStrings.Any(d => d.Key == "JSON_TrinhDoChuyenMon") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_TrinhDoChuyenMon").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_TrinhDoChuyenMon").Value;
                query = query.Where(d=>d.JSON_TrinhDoChuyenMon == keyword);
            }

			//Query JSON_KinhNghiem (string)
			if (QueryStrings.Any(d => d.Key == "JSON_KinhNghiem") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_KinhNghiem").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_KinhNghiem").Value;
                query = query.Where(d=>d.JSON_KinhNghiem == keyword);
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

			//Query DienThoaiNhaRieng (string)
			if (QueryStrings.Any(d => d.Key == "DienThoaiNhaRieng") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiNhaRieng").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiNhaRieng").Value;
                query = query.Where(d=>d.DienThoaiNhaRieng == keyword);
            }

			//Query JSON_HocVi (string)
			if (QueryStrings.Any(d => d.Key == "JSON_HocVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_HocVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_HocVi").Value;
                query = query.Where(d=>d.JSON_HocVi == keyword);
            }


			return toDTO(query);

        }

		public static DTO_CUS_HRM_STAFF_NhanSu_SYLL get_CUS_HRM_STAFF_NhanSu_SYLL(AppEntities db, int id)
        {
            var dbResult = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_CUS_HRM_STAFF_NhanSu_SYLL(AppEntities db, int ID, DTO_CUS_HRM_STAFF_NhanSu_SYLL item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDNhanSu = item.IDNhanSu;							
				dbitem.HoTen = item.HoTen;							
				dbitem.GioiTinh = item.GioiTinh;							
				dbitem.NgaySinh = item.NgaySinh;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoaiCQ = item.DienThoaiCQ;							
				dbitem.Mobile = item.Mobile;							
				dbitem.Email = item.Email;							
				dbitem.ChucVu = item.ChucVu;							
				dbitem.CoQuanLamViec = item.CoQuanLamViec;							
				dbitem.ThuTruongCoQuan = item.ThuTruongCoQuan;							
				dbitem.DienThoaiThuTruong = item.DienThoaiThuTruong;							
				dbitem.DiaChiCoQuan = item.DiaChiCoQuan;							
				dbitem.JSON_TrinhDoChuyenMon = item.JSON_TrinhDoChuyenMon;							
				dbitem.JSON_KinhNghiem = item.JSON_KinhNghiem;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;							
				dbitem.DienThoaiNhaRieng = item.DienThoaiNhaRieng;							
				dbitem.JSON_HocVi = item.JSON_HocVi;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_SYLL", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_HRM_STAFF_NhanSu_SYLL",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_HRM_STAFF_NhanSu_SYLL post_CUS_HRM_STAFF_NhanSu_SYLL(AppEntities db, DTO_CUS_HRM_STAFF_NhanSu_SYLL item, string Username)
        {
            tbl_CUS_HRM_STAFF_NhanSu_SYLL dbitem = new tbl_CUS_HRM_STAFF_NhanSu_SYLL();
            if (item != null)
            {							
				dbitem.IDNhanSu = item.IDNhanSu;							
				dbitem.HoTen = item.HoTen;							
				dbitem.GioiTinh = item.GioiTinh;							
				dbitem.NgaySinh = item.NgaySinh;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoaiCQ = item.DienThoaiCQ;							
				dbitem.Mobile = item.Mobile;							
				dbitem.Email = item.Email;							
				dbitem.ChucVu = item.ChucVu;							
				dbitem.CoQuanLamViec = item.CoQuanLamViec;							
				dbitem.ThuTruongCoQuan = item.ThuTruongCoQuan;							
				dbitem.DienThoaiThuTruong = item.DienThoaiThuTruong;							
				dbitem.DiaChiCoQuan = item.DiaChiCoQuan;							
				dbitem.JSON_TrinhDoChuyenMon = item.JSON_TrinhDoChuyenMon;							
				dbitem.JSON_KinhNghiem = item.JSON_KinhNghiem;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayKy_Ngay = item.NgayKy_Ngay;							
				dbitem.NgayKy_Thang = item.NgayKy_Thang;							
				dbitem.NgayKy_Nam = item.NgayKy_Nam;							
				dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;							
				dbitem.DienThoaiNhaRieng = item.DienThoaiNhaRieng;							
				dbitem.JSON_HocVi = item.JSON_HocVi;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_SYLL", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_HRM_STAFF_NhanSu_SYLL",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_HRM_STAFF_NhanSu_SYLL(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_SYLL", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_HRM_STAFF_NhanSu_SYLL",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_HRM_STAFF_NhanSu_SYLL_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Any(e => e.ID == id);
		}
		
    }

}






