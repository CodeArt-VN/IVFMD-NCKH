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
    
    
    public partial class tbl_CAT_Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CAT_Site()
        {
            this.tbl_PRO_BaoCaoNangSuatKhoaHoc = new HashSet<tbl_PRO_BaoCaoNangSuatKhoaHoc>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GhiChu { get; set; }
        public int Sort { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_BaoCaoNangSuatKhoaHoc> tbl_PRO_BaoCaoNangSuatKhoaHoc { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CAT_Site
	{
		public int ID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string GhiChu { get; set; }
		public int Sort { get; set; }
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

    public static partial class BS_CAT_Site 
    {
		public static IQueryable<DTO_CAT_Site> toDTO(IQueryable<tbl_CAT_Site> query)
        {
			return query
			.Select(s => new DTO_CAT_Site(){							
				ID = s.ID,							
				Code = s.Code,							
				Name = s.Name,							
				GhiChu = s.GhiChu,							
				Sort = s.Sort,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_CAT_Site toDTO(tbl_CAT_Site dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CAT_Site()
				{							
					ID = dbResult.ID,							
					Code = dbResult.Code,							
					Name = dbResult.Name,							
					GhiChu = dbResult.GhiChu,							
					Sort = dbResult.Sort,							
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

        public static IQueryable<DTO_CAT_Site> get_CAT_Site(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CAT_Site.Where(d => d.IsDeleted == false );

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

			//Query GhiChu (string)
			if (QueryStrings.Any(d => d.Key == "GhiChu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value;
                query = query.Where(d=>d.GhiChu == keyword);
            }

			//Query Sort (int)
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

		public static DTO_CAT_Site get_CAT_Site(AppEntities db, int id)
        {
            var dbResult = db.tbl_CAT_Site.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_CAT_Site get_CAT_Site(AppEntities db, string code)
        {
            var dbResult = db.tbl_CAT_Site.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_CAT_Site(AppEntities db, int ID, DTO_CAT_Site item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CAT_Site.Find(ID);
            if (dbitem != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.GhiChu = item.GhiChu;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_Site", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CAT_Site",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CAT_Site post_CAT_Site(AppEntities db, DTO_CAT_Site item, string Username)
        {
            tbl_CAT_Site dbitem = new tbl_CAT_Site();
            if (item != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.GhiChu = item.GhiChu;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_CAT_Site.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_Site", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CAT_Site",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CAT_Site(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CAT_Site.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_Site", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CAT_Site",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CAT_Site_Exists(AppEntities db, int id)
		{
			return db.tbl_CAT_Site.Any(e => e.ID == id);
		}
		
		public static bool check_CAT_Site_Exists(AppEntities db, string Code)
		{
			return db.tbl_CAT_Site.Any(e => e.Code == Code);
		}
		
    }

}






