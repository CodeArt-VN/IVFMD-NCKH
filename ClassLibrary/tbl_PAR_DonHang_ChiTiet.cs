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
    
    
    public partial class tbl_PAR_DonHang_ChiTiet
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Sort { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int IDDonHang { get; set; }
        public int IDSanPham { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public int ThoiHan { get; set; }
        public Nullable<System.DateTime> NgayDuyet { get; set; }
        public Nullable<System.DateTime> NgayDuTinhKetThuc { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public int LoaiDonHang { get; set; }
        public virtual tbl_PAR_DonHang tbl_PAR_DonHang { get; set; }
        public virtual tbl_PROD_SanPham tbl_PROD_SanPham { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PAR_DonHang_ChiTiet
	{
		public int ID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Remark { get; set; }
		public Nullable<int> Sort { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public int IDDonHang { get; set; }
		public int IDSanPham { get; set; }
		public decimal DonGia { get; set; }
		public int SoLuong { get; set; }
		public decimal ThanhTien { get; set; }
		public int ThoiHan { get; set; }
		public Nullable<System.DateTime> NgayDuyet { get; set; }
		public Nullable<System.DateTime> NgayDuTinhKetThuc { get; set; }
		public Nullable<System.DateTime> NgayBatDau { get; set; }
		public Nullable<System.DateTime> NgayHetHan { get; set; }
		public int LoaiDonHang { get; set; }
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

    public static partial class BS_PAR_DonHang_ChiTiet 
    {
		public static IQueryable<DTO_PAR_DonHang_ChiTiet> toDTO(IQueryable<tbl_PAR_DonHang_ChiTiet> query)
        {
			return query
			.Select(s => new DTO_PAR_DonHang_ChiTiet(){							
				ID = s.ID,							
				Code = s.Code,							
				Name = s.Name,							
				Remark = s.Remark,							
				Sort = s.Sort,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedBy = s.CreatedBy,							
				ModifiedBy = s.ModifiedBy,							
				CreatedDate = s.CreatedDate,							
				ModifiedDate = s.ModifiedDate,							
				IDDonHang = s.IDDonHang,							
				IDSanPham = s.IDSanPham,							
				DonGia = s.DonGia,							
				SoLuong = s.SoLuong,							
				ThanhTien = s.ThanhTien,							
				ThoiHan = s.ThoiHan,							
				NgayDuyet = s.NgayDuyet,							
				NgayDuTinhKetThuc = s.NgayDuTinhKetThuc,							
				NgayBatDau = s.NgayBatDau,							
				NgayHetHan = s.NgayHetHan,							
				LoaiDonHang = s.LoaiDonHang,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_PAR_DonHang_ChiTiet toDTO(tbl_PAR_DonHang_ChiTiet dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PAR_DonHang_ChiTiet()
				{							
					ID = dbResult.ID,							
					Code = dbResult.Code,							
					Name = dbResult.Name,							
					Remark = dbResult.Remark,							
					Sort = dbResult.Sort,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedBy = dbResult.ModifiedBy,							
					CreatedDate = dbResult.CreatedDate,							
					ModifiedDate = dbResult.ModifiedDate,							
					IDDonHang = dbResult.IDDonHang,							
					IDSanPham = dbResult.IDSanPham,							
					DonGia = dbResult.DonGia,							
					SoLuong = dbResult.SoLuong,							
					ThanhTien = dbResult.ThanhTien,							
					ThoiHan = dbResult.ThoiHan,							
					NgayDuyet = dbResult.NgayDuyet,							
					NgayDuTinhKetThuc = dbResult.NgayDuTinhKetThuc,							
					NgayBatDau = dbResult.NgayBatDau,							
					NgayHetHan = dbResult.NgayHetHan,							
					LoaiDonHang = dbResult.LoaiDonHang,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PAR_DonHang_ChiTiet> get_PAR_DonHang_ChiTiet(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PAR_DonHang_ChiTiet.Where(d => d.IsDeleted == false );

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



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

			//Query Code (string)
			if (QueryStrings.Any(d => d.Key == "Code") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Code").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Code").Value;
                query = query.Where(d=>d.Code == keyword);
            }

			//Query Name (string)
			if (QueryStrings.Any(d => d.Key == "Name") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Name").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Name").Value;
                query = query.Where(d=>d.Name == keyword);
            }

			//Query Remark (string)
			if (QueryStrings.Any(d => d.Key == "Remark") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Remark").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Remark").Value;
                query = query.Where(d=>d.Remark == keyword);
            }

			//Query Sort (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "SortFrom") && QueryStrings.Any(d => d.Key == "SortTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "SortFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "SortTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.Sort && d.Sort <= toVal);

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

			//Query CreatedBy (string)
			if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d=>d.CreatedBy == keyword);
            }

			//Query ModifiedBy (string)
			if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d=>d.ModifiedBy == keyword);
            }

			//Query CreatedDate (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

			//Query ModifiedDate (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

			//Query IDDonHang (int)
			if (QueryStrings.Any(d => d.Key == "IDDonHang"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDonHang").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDonHang));
            }

			//Query IDSanPham (int)
			if (QueryStrings.Any(d => d.Key == "IDSanPham"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDSanPham").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDSanPham));
            }

			//Query DonGia (decimal)
			if (QueryStrings.Any(d => d.Key == "DonGiaFrom") && QueryStrings.Any(d => d.Key == "DonGiaTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "DonGiaFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "DonGiaTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.DonGia && d.DonGia <= toVal);

			//Query SoLuong (int)
			if (QueryStrings.Any(d => d.Key == "SoLuongFrom") && QueryStrings.Any(d => d.Key == "SoLuongTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "SoLuongFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "SoLuongTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.SoLuong && d.SoLuong <= toVal);

			//Query ThanhTien (decimal)
			if (QueryStrings.Any(d => d.Key == "ThanhTienFrom") && QueryStrings.Any(d => d.Key == "ThanhTienTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThanhTienFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThanhTienTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.ThanhTien && d.ThanhTien <= toVal);

			//Query ThoiHan (int)
			if (QueryStrings.Any(d => d.Key == "ThoiHanFrom") && QueryStrings.Any(d => d.Key == "ThoiHanTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiHanFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiHanTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.ThoiHan && d.ThoiHan <= toVal);

			//Query NgayDuyet (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "NgayDuyetFrom") && QueryStrings.Any(d => d.Key == "NgayDuyetTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDuyetFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDuyetTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayDuyet && d.NgayDuyet <= toDate);

			//Query NgayDuTinhKetThuc (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "NgayDuTinhKetThucFrom") && QueryStrings.Any(d => d.Key == "NgayDuTinhKetThucTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDuTinhKetThucFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDuTinhKetThucTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayDuTinhKetThuc && d.NgayDuTinhKetThuc <= toDate);

			//Query NgayBatDau (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "NgayBatDauFrom") && QueryStrings.Any(d => d.Key == "NgayBatDauTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayBatDauFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayBatDauTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayBatDau && d.NgayBatDau <= toDate);

			//Query NgayHetHan (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "NgayHetHanFrom") && QueryStrings.Any(d => d.Key == "NgayHetHanTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHetHanFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHetHanTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayHetHan && d.NgayHetHan <= toDate);

			//Query LoaiDonHang (int)
			if (QueryStrings.Any(d => d.Key == "LoaiDonHangFrom") && QueryStrings.Any(d => d.Key == "LoaiDonHangTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LoaiDonHangFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LoaiDonHangTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.LoaiDonHang && d.LoaiDonHang <= toVal);


			return toDTO(query);

        }

		public static DTO_PAR_DonHang_ChiTiet get_PAR_DonHang_ChiTiet(AppEntities db, int id)
        {
            var dbResult = db.tbl_PAR_DonHang_ChiTiet.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_PAR_DonHang_ChiTiet get_PAR_DonHang_ChiTiet(AppEntities db, string code)
        {
            var dbResult = db.tbl_PAR_DonHang_ChiTiet.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_PAR_DonHang_ChiTiet(AppEntities db, int ID, DTO_PAR_DonHang_ChiTiet item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PAR_DonHang_ChiTiet.Find(ID);
            if (dbitem != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.IDDonHang = item.IDDonHang;							
				dbitem.IDSanPham = item.IDSanPham;							
				dbitem.DonGia = item.DonGia;							
				dbitem.SoLuong = item.SoLuong;							
				dbitem.ThanhTien = item.ThanhTien;							
				dbitem.ThoiHan = item.ThoiHan;							
				dbitem.NgayDuyet = item.NgayDuyet;							
				dbitem.NgayDuTinhKetThuc = item.NgayDuTinhKetThuc;							
				dbitem.NgayBatDau = item.NgayBatDau;							
				dbitem.NgayHetHan = item.NgayHetHan;							
				dbitem.LoaiDonHang = item.LoaiDonHang;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PAR_DonHang_ChiTiet", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PAR_DonHang_ChiTiet",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PAR_DonHang_ChiTiet post_PAR_DonHang_ChiTiet(AppEntities db, DTO_PAR_DonHang_ChiTiet item, string Username)
        {
            tbl_PAR_DonHang_ChiTiet dbitem = new tbl_PAR_DonHang_ChiTiet();
            if (item != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.IDDonHang = item.IDDonHang;							
				dbitem.IDSanPham = item.IDSanPham;							
				dbitem.DonGia = item.DonGia;							
				dbitem.SoLuong = item.SoLuong;							
				dbitem.ThanhTien = item.ThanhTien;							
				dbitem.ThoiHan = item.ThoiHan;							
				dbitem.NgayDuyet = item.NgayDuyet;							
				dbitem.NgayDuTinhKetThuc = item.NgayDuTinhKetThuc;							
				dbitem.NgayBatDau = item.NgayBatDau;							
				dbitem.NgayHetHan = item.NgayHetHan;							
				dbitem.LoaiDonHang = item.LoaiDonHang;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PAR_DonHang_ChiTiet.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PAR_DonHang_ChiTiet", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PAR_DonHang_ChiTiet",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PAR_DonHang_ChiTiet(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PAR_DonHang_ChiTiet.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PAR_DonHang_ChiTiet", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PAR_DonHang_ChiTiet",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PAR_DonHang_ChiTiet_Exists(AppEntities db, int id)
		{
			return db.tbl_PAR_DonHang_ChiTiet.Any(e => e.ID == id);
		}
		
		public static bool check_PAR_DonHang_ChiTiet_Exists(AppEntities db, string Code)
		{
			return db.tbl_PAR_DonHang_ChiTiet.Any(e => e.Code == Code);
		}
		
    }

}






