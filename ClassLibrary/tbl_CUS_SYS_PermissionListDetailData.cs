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
    
    
    public partial class tbl_CUS_SYS_PermissionListDetailData
    {
        public int IDPartner { get; set; }
        public int IDPermission { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public Nullable<int> Sort { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual tbl_CUS_SYS_PermissionList tbl_CUS_SYS_PermissionList { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_SYS_PermissionListDetailData
	{
		public int IDPartner { get; set; }
		public int IDPermission { get; set; }
		public int ID { get; set; }
		public string Type { get; set; }
		public string Value { get; set; }
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

    public static partial class BS_CUS_SYS_PermissionListDetailData 
    {
		public static IQueryable<DTO_CUS_SYS_PermissionListDetailData> toDTO(IQueryable<tbl_CUS_SYS_PermissionListDetailData> query)
        {
			return query
			.Select(s => new DTO_CUS_SYS_PermissionListDetailData(){							
				IDPartner = s.IDPartner,							
				IDPermission = s.IDPermission,							
				ID = s.ID,							
				Type = s.Type,							
				Value = s.Value,							
				Sort = s.Sort,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedBy = s.CreatedBy,							
				ModifiedBy = s.ModifiedBy,							
				CreatedDate = s.CreatedDate,							
				ModifiedDate = s.ModifiedDate,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_CUS_SYS_PermissionListDetailData toDTO(tbl_CUS_SYS_PermissionListDetailData dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_SYS_PermissionListDetailData()
				{							
					IDPartner = dbResult.IDPartner,							
					IDPermission = dbResult.IDPermission,							
					ID = dbResult.ID,							
					Type = dbResult.Type,							
					Value = dbResult.Value,							
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

        public static IQueryable<DTO_CUS_SYS_PermissionListDetailData> get_CUS_SYS_PermissionListDetailData(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_SYS_PermissionListDetailData
			.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);
			

			//Query keyword



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

			//Query IDPermission (int)
			if (QueryStrings.Any(d => d.Key == "IDPermission"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPermission").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPermission));
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

			//Query Type (string)
			if (QueryStrings.Any(d => d.Key == "Type") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Type").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Type").Value;
                query = query.Where(d=>d.Type == keyword);
            }

			//Query Value (string)
			if (QueryStrings.Any(d => d.Key == "Value") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Value").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Value").Value;
                query = query.Where(d=>d.Value == keyword);
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

		public static DTO_CUS_SYS_PermissionListDetailData get_CUS_SYS_PermissionListDetailData(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_CUS_SYS_PermissionListDetailData.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		

		public static bool put_CUS_SYS_PermissionListDetailData(AppEntities db, int PartnerID, int ID, DTO_CUS_SYS_PermissionListDetailData item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_SYS_PermissionListDetailData.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDPermission = item.IDPermission;							
				dbitem.Type = item.Type;							
				dbitem.Value = item.Value;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_SYS_PermissionListDetailData", dbitem.ModifiedDate, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_SYS_PermissionListDetailData",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_SYS_PermissionListDetailData post_CUS_SYS_PermissionListDetailData(AppEntities db, int PartnerID, DTO_CUS_SYS_PermissionListDetailData item, string Username)
        {
            tbl_CUS_SYS_PermissionListDetailData dbitem = new tbl_CUS_SYS_PermissionListDetailData();
            if (item != null)
            {							
				dbitem.IDPermission = item.IDPermission;							
				dbitem.Type = item.Type;							
				dbitem.Value = item.Value;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_CUS_SYS_PermissionListDetailData.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_SYS_PermissionListDetailData", dbitem.ModifiedDate, Username);
										
									
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_SYS_PermissionListDetailData",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_SYS_PermissionListDetailData(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_SYS_PermissionListDetailData.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_SYS_PermissionListDetailData", dbitem.ModifiedDate, Username);
										
				
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_SYS_PermissionListDetailData",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_SYS_PermissionListDetailData_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_SYS_PermissionListDetailData.Any(e => e.ID == id);
		}
		
    }

}






