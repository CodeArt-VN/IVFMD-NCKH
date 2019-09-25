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
    
    
    public partial class tbl_WEB_BaiViet_DanhMuc
    {
        public int IDDanhMuc { get; set; }
        public int IDBaiViet { get; set; }
        public int ID { get; set; }
        public string URL { get; set; }
        public Nullable<int> Sort { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_WEB_BaiViet_DanhMuc
	{
		public int IDDanhMuc { get; set; }
		public int IDBaiViet { get; set; }
		public int ID { get; set; }
		public string URL { get; set; }
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

    public static partial class BS_WEB_BaiViet_DanhMuc 
    {
		public static IQueryable<DTO_WEB_BaiViet_DanhMuc> toDTO(IQueryable<tbl_WEB_BaiViet_DanhMuc> query)
        {
			return query
			.Select(s => new DTO_WEB_BaiViet_DanhMuc(){							
				IDDanhMuc = s.IDDanhMuc,							
				IDBaiViet = s.IDBaiViet,							
				ID = s.ID,							
				URL = s.URL,							
				Sort = s.Sort,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedBy = s.CreatedBy,							
				ModifiedBy = s.ModifiedBy,							
				CreatedDate = s.CreatedDate,							
				ModifiedDate = s.ModifiedDate,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_WEB_BaiViet_DanhMuc toDTO(tbl_WEB_BaiViet_DanhMuc dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_WEB_BaiViet_DanhMuc()
				{							
					IDDanhMuc = dbResult.IDDanhMuc,							
					IDBaiViet = dbResult.IDBaiViet,							
					ID = dbResult.ID,							
					URL = dbResult.URL,							
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

        public static IQueryable<DTO_WEB_BaiViet_DanhMuc> get_WEB_BaiViet_DanhMuc(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_WEB_BaiViet_DanhMuc.Where(d => d.IsDeleted == false );

			//Query keyword



			//Query IDDanhMuc (int)
			if (QueryStrings.Any(d => d.Key == "IDDanhMuc"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDanhMuc").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDanhMuc));
            }

			//Query IDBaiViet (int)
			if (QueryStrings.Any(d => d.Key == "IDBaiViet"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDBaiViet").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDBaiViet));
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

			//Query URL (string)
			if (QueryStrings.Any(d => d.Key == "URL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "URL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "URL").Value;
                query = query.Where(d=>d.URL == keyword);
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

		public static DTO_WEB_BaiViet_DanhMuc get_WEB_BaiViet_DanhMuc(AppEntities db, int id)
        {
            var dbResult = db.tbl_WEB_BaiViet_DanhMuc.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_WEB_BaiViet_DanhMuc(AppEntities db, int ID, DTO_WEB_BaiViet_DanhMuc item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_WEB_BaiViet_DanhMuc.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDanhMuc = item.IDDanhMuc;							
				dbitem.IDBaiViet = item.IDBaiViet;							
				dbitem.URL = item.URL;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_BaiViet_DanhMuc", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_WEB_BaiViet_DanhMuc",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_WEB_BaiViet_DanhMuc post_WEB_BaiViet_DanhMuc(AppEntities db, DTO_WEB_BaiViet_DanhMuc item, string Username)
        {
            tbl_WEB_BaiViet_DanhMuc dbitem = new tbl_WEB_BaiViet_DanhMuc();
            if (item != null)
            {							
				dbitem.IDDanhMuc = item.IDDanhMuc;							
				dbitem.IDBaiViet = item.IDBaiViet;							
				dbitem.URL = item.URL;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_WEB_BaiViet_DanhMuc.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_BaiViet_DanhMuc", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_WEB_BaiViet_DanhMuc",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_WEB_BaiViet_DanhMuc(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_WEB_BaiViet_DanhMuc.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_BaiViet_DanhMuc", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_WEB_BaiViet_DanhMuc",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_WEB_BaiViet_DanhMuc_Exists(AppEntities db, int id)
		{
			return db.tbl_WEB_BaiViet_DanhMuc.Any(e => e.ID == id);
		}
		
    }

}






