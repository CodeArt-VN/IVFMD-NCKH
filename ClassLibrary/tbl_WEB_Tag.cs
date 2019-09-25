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
    
    
    public partial class tbl_WEB_Tag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_WEB_Tag()
        {
            this.tbl_WEB_BaiViet_Tag = new HashSet<tbl_WEB_BaiViet_Tag>();
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WEB_BaiViet_Tag> tbl_WEB_BaiViet_Tag { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_WEB_Tag
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

    public static partial class BS_WEB_Tag 
    {
		public static IQueryable<DTO_WEB_Tag> toDTO(IQueryable<tbl_WEB_Tag> query)
        {
			return query
			.Select(s => new DTO_WEB_Tag(){							
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
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_WEB_Tag toDTO(tbl_WEB_Tag dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_WEB_Tag()
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
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_WEB_Tag> get_WEB_Tag(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_WEB_Tag.Where(d => d.IsDeleted == false );

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


			return toDTO(query);

        }

		public static DTO_WEB_Tag get_WEB_Tag(AppEntities db, int id)
        {
            var dbResult = db.tbl_WEB_Tag.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_WEB_Tag get_WEB_Tag(AppEntities db, string code)
        {
            var dbResult = db.tbl_WEB_Tag.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_WEB_Tag(AppEntities db, int ID, DTO_WEB_Tag item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_WEB_Tag.Find(ID);
            if (dbitem != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_Tag", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_WEB_Tag",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_WEB_Tag post_WEB_Tag(AppEntities db, DTO_WEB_Tag item, string Username)
        {
            tbl_WEB_Tag dbitem = new tbl_WEB_Tag();
            if (item != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_WEB_Tag.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_Tag", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_WEB_Tag",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_WEB_Tag(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_WEB_Tag.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_Tag", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_WEB_Tag",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_WEB_Tag_Exists(AppEntities db, int id)
		{
			return db.tbl_WEB_Tag.Any(e => e.ID == id);
		}
		
		public static bool check_WEB_Tag_Exists(AppEntities db, string Code)
		{
			return db.tbl_WEB_Tag.Any(e => e.Code == Code);
		}
		
    }

}






