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
    
    
    public partial class tbl_PAR_DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PAR_DonHang()
        {
            this.tbl_PAR_DonHang_ChiTiet = new HashSet<tbl_PAR_DonHang_ChiTiet>();
        }
    
        public int IDPartner { get; set; }
        public Nullable<int> IDLoaiKhachHang { get; set; }
        public Nullable<int> IDTinhTrang { get; set; }
        public Nullable<int> IDLoaiDonHang { get; set; }
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
        public System.DateTime NgayMua { get; set; }
        public decimal TongCong { get; set; }
        public decimal Thue { get; set; }
        public decimal ChietKhau { get; set; }
        public string MaGiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PAR_DonHang_ChiTiet> tbl_PAR_DonHang_ChiTiet { get; set; }
        public virtual tbl_PAR_Partner tbl_PAR_Partner { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PAR_DonHang
	{
		public int IDPartner { get; set; }
		public Nullable<int> IDLoaiKhachHang { get; set; }
		public Nullable<int> IDTinhTrang { get; set; }
		public Nullable<int> IDLoaiDonHang { get; set; }
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
		public System.DateTime NgayMua { get; set; }
		public decimal TongCong { get; set; }
		public decimal Thue { get; set; }
		public decimal ChietKhau { get; set; }
		public string MaGiamGia { get; set; }
		public decimal ThanhTien { get; set; }
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

    public static partial class BS_PAR_DonHang 
    {
		public static IQueryable<DTO_PAR_DonHang> toDTO(IQueryable<tbl_PAR_DonHang> query)
        {
			return query
			.Select(s => new DTO_PAR_DonHang(){							
				IDPartner = s.IDPartner,							
				IDLoaiKhachHang = s.IDLoaiKhachHang,							
				IDTinhTrang = s.IDTinhTrang,							
				IDLoaiDonHang = s.IDLoaiDonHang,							
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
				NgayMua = s.NgayMua,							
				TongCong = s.TongCong,							
				Thue = s.Thue,							
				ChietKhau = s.ChietKhau,							
				MaGiamGia = s.MaGiamGia,							
				ThanhTien = s.ThanhTien,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_PAR_DonHang toDTO(tbl_PAR_DonHang dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PAR_DonHang()
				{							
					IDPartner = dbResult.IDPartner,							
					IDLoaiKhachHang = dbResult.IDLoaiKhachHang,							
					IDTinhTrang = dbResult.IDTinhTrang,							
					IDLoaiDonHang = dbResult.IDLoaiDonHang,							
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
					NgayMua = dbResult.NgayMua,							
					TongCong = dbResult.TongCong,							
					Thue = dbResult.Thue,							
					ChietKhau = dbResult.ChietKhau,							
					MaGiamGia = dbResult.MaGiamGia,							
					ThanhTien = dbResult.ThanhTien,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PAR_DonHang> get_PAR_DonHang(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PAR_DonHang
			.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);
			

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



			//Query IDPartner (int)
			if (QueryStrings.Any(d => d.Key == "IDPartner"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPartner").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPartner));
            }

			//Query IDLoaiKhachHang (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDLoaiKhachHang"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDLoaiKhachHang").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDLoaiKhachHang));
            }

			//Query IDTinhTrang (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDTinhTrang"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTinhTrang").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTinhTrang));
            }

			//Query IDLoaiDonHang (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDLoaiDonHang"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDLoaiDonHang").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDLoaiDonHang));
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

			//Query NgayMua (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "NgayMuaFrom") && QueryStrings.Any(d => d.Key == "NgayMuaTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayMuaFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayMuaTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayMua && d.NgayMua <= toDate);

			//Query TongCong (decimal)
			if (QueryStrings.Any(d => d.Key == "TongCongFrom") && QueryStrings.Any(d => d.Key == "TongCongTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TongCongFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TongCongTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.TongCong && d.TongCong <= toVal);

			//Query Thue (decimal)
			if (QueryStrings.Any(d => d.Key == "ThueFrom") && QueryStrings.Any(d => d.Key == "ThueTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThueFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThueTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.Thue && d.Thue <= toVal);

			//Query ChietKhau (decimal)
			if (QueryStrings.Any(d => d.Key == "ChietKhauFrom") && QueryStrings.Any(d => d.Key == "ChietKhauTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ChietKhauFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ChietKhauTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.ChietKhau && d.ChietKhau <= toVal);

			//Query MaGiamGia (string)
			if (QueryStrings.Any(d => d.Key == "MaGiamGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaGiamGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaGiamGia").Value;
                query = query.Where(d=>d.MaGiamGia == keyword);
            }

			//Query ThanhTien (decimal)
			if (QueryStrings.Any(d => d.Key == "ThanhTienFrom") && QueryStrings.Any(d => d.Key == "ThanhTienTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThanhTienFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThanhTienTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.ThanhTien && d.ThanhTien <= toVal);


			return toDTO(query);

        }

		public static DTO_PAR_DonHang get_PAR_DonHang(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PAR_DonHang.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		
		public static DTO_PAR_DonHang get_PAR_DonHang(AppEntities db, int PartnerID, string code)
        {
            var dbResult = db.tbl_PAR_DonHang
			.FirstOrDefault(d => d.IsDeleted == false && d.IDPartner == PartnerID && d.Code == code);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }

		public static bool put_PAR_DonHang(AppEntities db, int PartnerID, int ID, DTO_PAR_DonHang item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PAR_DonHang.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDLoaiKhachHang = item.IDLoaiKhachHang;							
				dbitem.IDTinhTrang = item.IDTinhTrang;							
				dbitem.IDLoaiDonHang = item.IDLoaiDonHang;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayMua = item.NgayMua;							
				dbitem.TongCong = item.TongCong;							
				dbitem.Thue = item.Thue;							
				dbitem.ChietKhau = item.ChietKhau;							
				dbitem.MaGiamGia = item.MaGiamGia;							
				dbitem.ThanhTien = item.ThanhTien;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PAR_DonHang", dbitem.ModifiedDate, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PAR_DonHang",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PAR_DonHang post_PAR_DonHang(AppEntities db, int PartnerID, DTO_PAR_DonHang item, string Username)
        {
            tbl_PAR_DonHang dbitem = new tbl_PAR_DonHang();
            if (item != null)
            {							
				dbitem.IDLoaiKhachHang = item.IDLoaiKhachHang;							
				dbitem.IDTinhTrang = item.IDTinhTrang;							
				dbitem.IDLoaiDonHang = item.IDLoaiDonHang;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayMua = item.NgayMua;							
				dbitem.TongCong = item.TongCong;							
				dbitem.Thue = item.Thue;							
				dbitem.ChietKhau = item.ChietKhau;							
				dbitem.MaGiamGia = item.MaGiamGia;							
				dbitem.ThanhTien = item.ThanhTien;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_PAR_DonHang.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PAR_DonHang", dbitem.ModifiedDate, Username);
										
									
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PAR_DonHang",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PAR_DonHang(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PAR_DonHang.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PAR_DonHang", dbitem.ModifiedDate, Username);
										
				
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PAR_DonHang",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PAR_DonHang_Exists(AppEntities db, int id)
		{
			return db.tbl_PAR_DonHang.Any(e => e.ID == id);
		}
		
		public static bool check_PAR_DonHang_Exists(AppEntities db, string Code)
		{
			return db.tbl_PAR_DonHang.Any(e => e.Code == Code);
		}
		
    }

}






