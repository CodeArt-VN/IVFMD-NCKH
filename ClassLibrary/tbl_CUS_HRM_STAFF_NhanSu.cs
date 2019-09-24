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
    
    
    public partial class tbl_CUS_HRM_STAFF_NhanSu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CUS_HRM_STAFF_NhanSu()
        {
            this.tbl_CUS_HRM_STAFF_NhanSu_LLKH = new HashSet<tbl_CUS_HRM_STAFF_NhanSu_LLKH>();
            this.tbl_CUS_HRM_STAFF_NhanSu_SYLL = new HashSet<tbl_CUS_HRM_STAFF_NhanSu_SYLL>();
            this.tbl_PRO_DeTai = new HashSet<tbl_PRO_DeTai>();
            this.tbl_PRO_DeTai1 = new HashSet<tbl_PRO_DeTai>();
            this.tbl_PRO_LLKH = new HashSet<tbl_PRO_LLKH>();
            this.tbl_PRO_NCVKhac = new HashSet<tbl_PRO_NCVKhac>();
            this.tbl_PRO_SYLL = new HashSet<tbl_PRO_SYLL>();
        }
    
        public int IDPartner { get; set; }
        public Nullable<int> IDChucDanh { get; set; }
        public Nullable<int> IDBoPhan { get; set; }
        public Nullable<int> IDRole { get; set; }
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
        public string Ten { get; set; }
        public string Ho { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public virtual tbl_CUS_HRM_LIST_BoPhan tbl_CUS_HRM_LIST_BoPhan { get; set; }
        public virtual tbl_CUS_HRM_LIST_ChucDanh tbl_CUS_HRM_LIST_ChucDanh { get; set; }
        public virtual tbl_PAR_Partner tbl_PAR_Partner { get; set; }
        public virtual tbl_CUS_SYS_Role tbl_CUS_SYS_Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_HRM_STAFF_NhanSu_LLKH> tbl_CUS_HRM_STAFF_NhanSu_LLKH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_HRM_STAFF_NhanSu_SYLL> tbl_CUS_HRM_STAFF_NhanSu_SYLL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DeTai> tbl_PRO_DeTai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DeTai> tbl_PRO_DeTai1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_LLKH> tbl_PRO_LLKH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_NCVKhac> tbl_PRO_NCVKhac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_SYLL> tbl_PRO_SYLL { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_HRM_STAFF_NhanSu
	{
		public int IDPartner { get; set; }
		public Nullable<int> IDChucDanh { get; set; }
		public Nullable<int> IDBoPhan { get; set; }
		public Nullable<int> IDRole { get; set; }
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
		public string Ten { get; set; }
		public string Ho { get; set; }
		public string Email { get; set; }
		public string SoDienThoai { get; set; }
		public string DiaChi { get; set; }
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

    public static partial class BS_CUS_HRM_STAFF_NhanSu 
    {
		public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu> toDTO(IQueryable<tbl_CUS_HRM_STAFF_NhanSu> query)
        {
			return query
			.Select(s => new DTO_CUS_HRM_STAFF_NhanSu(){							
				IDPartner = s.IDPartner,							
				IDChucDanh = s.IDChucDanh,							
				IDBoPhan = s.IDBoPhan,							
				IDRole = s.IDRole,							
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
				Ten = s.Ten,							
				Ho = s.Ho,							
				Email = s.Email,							
				SoDienThoai = s.SoDienThoai,							
				DiaChi = s.DiaChi,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_CUS_HRM_STAFF_NhanSu toDTO(tbl_CUS_HRM_STAFF_NhanSu dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_HRM_STAFF_NhanSu()
				{							
					IDPartner = dbResult.IDPartner,							
					IDChucDanh = dbResult.IDChucDanh,							
					IDBoPhan = dbResult.IDBoPhan,							
					IDRole = dbResult.IDRole,							
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
					Ten = dbResult.Ten,							
					Ho = dbResult.Ho,							
					Email = dbResult.Email,							
					SoDienThoai = dbResult.SoDienThoai,							
					DiaChi = dbResult.DiaChi,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu> get_CUS_HRM_STAFF_NhanSu(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_HRM_STAFF_NhanSu
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

			//Query IDChucDanh (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDChucDanh"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDChucDanh").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDChucDanh));
            }

			//Query IDBoPhan (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDBoPhan"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDBoPhan").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDBoPhan));
            }

			//Query IDRole (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDRole"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDRole").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDRole));
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

			//Query Ten (string)
			if (QueryStrings.Any(d => d.Key == "Ten") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Ten").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Ten").Value;
                query = query.Where(d=>d.Ten == keyword);
            }

			//Query Ho (string)
			if (QueryStrings.Any(d => d.Key == "Ho") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Ho").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Ho").Value;
                query = query.Where(d=>d.Ho == keyword);
            }

			//Query Email (string)
			if (QueryStrings.Any(d => d.Key == "Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email").Value;
                query = query.Where(d=>d.Email == keyword);
            }

			//Query SoDienThoai (string)
			if (QueryStrings.Any(d => d.Key == "SoDienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoai").Value;
                query = query.Where(d=>d.SoDienThoai == keyword);
            }

			//Query DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value;
                query = query.Where(d=>d.DiaChi == keyword);
            }


			return toDTO(query);

        }

		public static DTO_CUS_HRM_STAFF_NhanSu get_CUS_HRM_STAFF_NhanSu(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_CUS_HRM_STAFF_NhanSu.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		
		public static DTO_CUS_HRM_STAFF_NhanSu get_CUS_HRM_STAFF_NhanSu(AppEntities db, int PartnerID, string code)
        {
            var dbResult = db.tbl_CUS_HRM_STAFF_NhanSu
			.FirstOrDefault(d => d.IsDeleted == false && d.IDPartner == PartnerID && d.Code == code);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }

		public static bool put_CUS_HRM_STAFF_NhanSu(AppEntities db, int PartnerID, int ID, DTO_CUS_HRM_STAFF_NhanSu item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDChucDanh = item.IDChucDanh;							
				dbitem.IDBoPhan = item.IDBoPhan;							
				dbitem.IDRole = item.IDRole;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Ten = item.Ten;							
				dbitem.Ho = item.Ho;							
				dbitem.Email = item.Email;							
				dbitem.SoDienThoai = item.SoDienThoai;							
				dbitem.DiaChi = item.DiaChi;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_HRM_STAFF_NhanSu", dbitem.ModifiedDate, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_HRM_STAFF_NhanSu",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_HRM_STAFF_NhanSu post_CUS_HRM_STAFF_NhanSu(AppEntities db, int PartnerID, DTO_CUS_HRM_STAFF_NhanSu item, string Username)
        {
            tbl_CUS_HRM_STAFF_NhanSu dbitem = new tbl_CUS_HRM_STAFF_NhanSu();
            if (item != null)
            {							
				dbitem.IDChucDanh = item.IDChucDanh;							
				dbitem.IDBoPhan = item.IDBoPhan;							
				dbitem.IDRole = item.IDRole;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Ten = item.Ten;							
				dbitem.Ho = item.Ho;							
				dbitem.Email = item.Email;							
				dbitem.SoDienThoai = item.SoDienThoai;							
				dbitem.DiaChi = item.DiaChi;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_CUS_HRM_STAFF_NhanSu.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_HRM_STAFF_NhanSu", dbitem.ModifiedDate, Username);
										
									
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_HRM_STAFF_NhanSu",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_HRM_STAFF_NhanSu(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_HRM_STAFF_NhanSu", dbitem.ModifiedDate, Username);
										
				
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_HRM_STAFF_NhanSu",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_HRM_STAFF_NhanSu_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_HRM_STAFF_NhanSu.Any(e => e.ID == id);
		}
		
		public static bool check_CUS_HRM_STAFF_NhanSu_Exists(AppEntities db, string Code)
		{
			return db.tbl_CUS_HRM_STAFF_NhanSu.Any(e => e.Code == Code);
		}
		
    }

}






