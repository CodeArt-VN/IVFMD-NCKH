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
    
    
    public partial class tbl_PROD_SanPham_ChiTiet
    {
        public int IDSanPham { get; set; }
        public Nullable<int> IDApp { get; set; }
        public Nullable<int> IDForm { get; set; }
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
        public virtual tbl_PROD_SanPham tbl_PROD_SanPham { get; set; }
        public virtual tbl_SYS_Apps tbl_SYS_Apps { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PROD_SanPham_ChiTiet
	{
		public int IDSanPham { get; set; }
		public Nullable<int> IDApp { get; set; }
		public Nullable<int> IDForm { get; set; }
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

    public static partial class BS_PROD_SanPham_ChiTiet 
    {
		public static IQueryable<DTO_PROD_SanPham_ChiTiet> toDTO(IQueryable<tbl_PROD_SanPham_ChiTiet> query)
        {
			return query
			.Select(s => new DTO_PROD_SanPham_ChiTiet(){							
				IDSanPham = s.IDSanPham,							
				IDApp = s.IDApp,							
				IDForm = s.IDForm,							
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

		public static DTO_PROD_SanPham_ChiTiet toDTO(tbl_PROD_SanPham_ChiTiet dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PROD_SanPham_ChiTiet()
				{							
					IDSanPham = dbResult.IDSanPham,							
					IDApp = dbResult.IDApp,							
					IDForm = dbResult.IDForm,							
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

        public static IQueryable<DTO_PROD_SanPham_ChiTiet> get_PROD_SanPham_ChiTiet(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PROD_SanPham_ChiTiet.Where(d => d.IsDeleted == false );

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
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

			//Query IDApp (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDApp"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDApp").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDApp));
            }

			//Query IDForm (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDForm"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDForm").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDForm));
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

		public static DTO_PROD_SanPham_ChiTiet get_PROD_SanPham_ChiTiet(AppEntities db, int id)
        {
            var dbResult = db.tbl_PROD_SanPham_ChiTiet.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_PROD_SanPham_ChiTiet get_PROD_SanPham_ChiTiet(AppEntities db, string code)
        {
            var dbResult = db.tbl_PROD_SanPham_ChiTiet.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_PROD_SanPham_ChiTiet(AppEntities db, int ID, DTO_PROD_SanPham_ChiTiet item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PROD_SanPham_ChiTiet.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDSanPham = item.IDSanPham;							
				dbitem.IDApp = item.IDApp;							
				dbitem.IDForm = item.IDForm;							
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
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PROD_SanPham_ChiTiet", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PROD_SanPham_ChiTiet",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PROD_SanPham_ChiTiet post_PROD_SanPham_ChiTiet(AppEntities db, DTO_PROD_SanPham_ChiTiet item, string Username)
        {
            tbl_PROD_SanPham_ChiTiet dbitem = new tbl_PROD_SanPham_ChiTiet();
            if (item != null)
            {							
				dbitem.IDSanPham = item.IDSanPham;							
				dbitem.IDApp = item.IDApp;							
				dbitem.IDForm = item.IDForm;							
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
					db.tbl_PROD_SanPham_ChiTiet.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PROD_SanPham_ChiTiet", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PROD_SanPham_ChiTiet",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PROD_SanPham_ChiTiet(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PROD_SanPham_ChiTiet.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PROD_SanPham_ChiTiet", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PROD_SanPham_ChiTiet",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PROD_SanPham_ChiTiet_Exists(AppEntities db, int id)
		{
			return db.tbl_PROD_SanPham_ChiTiet.Any(e => e.ID == id);
		}
		
		public static bool check_PROD_SanPham_ChiTiet_Exists(AppEntities db, string Code)
		{
			return db.tbl_PROD_SanPham_ChiTiet.Any(e => e.Code == Code);
		}
		
    }

}






