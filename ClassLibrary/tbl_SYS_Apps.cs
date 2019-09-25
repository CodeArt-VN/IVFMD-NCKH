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
    
    
    public partial class tbl_SYS_Apps
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SYS_Apps()
        {
            this.tbl_PROD_SanPham_ChiTiet = new HashSet<tbl_PROD_SanPham_ChiTiet>();
            this.tbl_SYS_FormGroup = new HashSet<tbl_SYS_FormGroup>();
        }
    
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
        public string AppSecret { get; set; }
        public Nullable<int> IdentityTokenLifetime { get; set; }
        public Nullable<int> AccessTokenLifetime { get; set; }
        public bool RequireConsent { get; set; }
        public string AppColor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PROD_SanPham_ChiTiet> tbl_PROD_SanPham_ChiTiet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SYS_FormGroup> tbl_SYS_FormGroup { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_SYS_Apps
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
		public string AppSecret { get; set; }
		public Nullable<int> IdentityTokenLifetime { get; set; }
		public Nullable<int> AccessTokenLifetime { get; set; }
		public bool RequireConsent { get; set; }
		public string AppColor { get; set; }
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

    public static partial class BS_SYS_Apps 
    {
		public static IQueryable<DTO_SYS_Apps> toDTO(IQueryable<tbl_SYS_Apps> query)
        {
			return query
			.Select(s => new DTO_SYS_Apps(){							
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
				AppSecret = s.AppSecret,							
				IdentityTokenLifetime = s.IdentityTokenLifetime,							
				AccessTokenLifetime = s.AccessTokenLifetime,							
				RequireConsent = s.RequireConsent,							
				AppColor = s.AppColor,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_SYS_Apps toDTO(tbl_SYS_Apps dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_SYS_Apps()
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
					AppSecret = dbResult.AppSecret,							
					IdentityTokenLifetime = dbResult.IdentityTokenLifetime,							
					AccessTokenLifetime = dbResult.AccessTokenLifetime,							
					RequireConsent = dbResult.RequireConsent,							
					AppColor = dbResult.AppColor,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_SYS_Apps> get_SYS_Apps(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_SYS_Apps.Where(d => d.IsDeleted == false );

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

			//Query AppSecret (string)
			if (QueryStrings.Any(d => d.Key == "AppSecret") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "AppSecret").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "AppSecret").Value;
                query = query.Where(d=>d.AppSecret == keyword);
            }

			//Query IdentityTokenLifetime (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IdentityTokenLifetimeFrom") && QueryStrings.Any(d => d.Key == "IdentityTokenLifetimeTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "IdentityTokenLifetimeFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "IdentityTokenLifetimeTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.IdentityTokenLifetime && d.IdentityTokenLifetime <= toVal);

			//Query AccessTokenLifetime (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "AccessTokenLifetimeFrom") && QueryStrings.Any(d => d.Key == "AccessTokenLifetimeTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "AccessTokenLifetimeFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "AccessTokenLifetimeTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.AccessTokenLifetime && d.AccessTokenLifetime <= toVal);

			//Query RequireConsent (bool)
			if (QueryStrings.Any(d => d.Key == "RequireConsent"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "RequireConsent").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.RequireConsent);
            }

			//Query AppColor (string)
			if (QueryStrings.Any(d => d.Key == "AppColor") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "AppColor").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "AppColor").Value;
                query = query.Where(d=>d.AppColor == keyword);
            }


			return toDTO(query);

        }

		public static DTO_SYS_Apps get_SYS_Apps(AppEntities db, int id)
        {
            var dbResult = db.tbl_SYS_Apps.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_SYS_Apps get_SYS_Apps(AppEntities db, string code)
        {
            var dbResult = db.tbl_SYS_Apps.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_SYS_Apps(AppEntities db, int ID, DTO_SYS_Apps item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_SYS_Apps.Find(ID);
            if (dbitem != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.AppSecret = item.AppSecret;							
				dbitem.IdentityTokenLifetime = item.IdentityTokenLifetime;							
				dbitem.AccessTokenLifetime = item.AccessTokenLifetime;							
				dbitem.RequireConsent = item.RequireConsent;							
				dbitem.AppColor = item.AppColor;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Apps", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_SYS_Apps",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_SYS_Apps post_SYS_Apps(AppEntities db, DTO_SYS_Apps item, string Username)
        {
            tbl_SYS_Apps dbitem = new tbl_SYS_Apps();
            if (item != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.AppSecret = item.AppSecret;							
				dbitem.IdentityTokenLifetime = item.IdentityTokenLifetime;							
				dbitem.AccessTokenLifetime = item.AccessTokenLifetime;							
				dbitem.RequireConsent = item.RequireConsent;							
				dbitem.AppColor = item.AppColor;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_SYS_Apps.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Apps", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_SYS_Apps",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_SYS_Apps(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_SYS_Apps.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Apps", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_SYS_Apps",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_SYS_Apps_Exists(AppEntities db, int id)
		{
			return db.tbl_SYS_Apps.Any(e => e.ID == id);
		}
		
		public static bool check_SYS_Apps_Exists(AppEntities db, string Code)
		{
			return db.tbl_SYS_Apps.Any(e => e.Code == Code);
		}
		
    }

}






