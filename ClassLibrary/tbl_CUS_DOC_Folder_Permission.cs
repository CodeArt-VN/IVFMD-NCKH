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
    
    
    public partial class tbl_CUS_DOC_Folder_Permission
    {
        public int IDPartner { get; set; }
        public int IDFolder { get; set; }
        public int IDRole { get; set; }
        public int ID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsCanView { get; set; }
        public bool IsCanChange { get; set; }
        public bool IsCanApprove { get; set; }
        public virtual tbl_CUS_DOC_Folder tbl_CUS_DOC_Folder { get; set; }
        public virtual tbl_CUS_SYS_Role tbl_CUS_SYS_Role { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_DOC_Folder_Permission
	{
		public int IDPartner { get; set; }
		public int IDFolder { get; set; }
		public int IDRole { get; set; }
		public int ID { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public bool IsCanView { get; set; }
		public bool IsCanChange { get; set; }
		public bool IsCanApprove { get; set; }
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

    public static partial class BS_CUS_DOC_Folder_Permission 
    {
		public static IQueryable<DTO_CUS_DOC_Folder_Permission> toDTO(IQueryable<tbl_CUS_DOC_Folder_Permission> query)
        {
			return query
			.Select(s => new DTO_CUS_DOC_Folder_Permission(){							
				IDPartner = s.IDPartner,							
				IDFolder = s.IDFolder,							
				IDRole = s.IDRole,							
				ID = s.ID,							
				ModifiedDate = s.ModifiedDate,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedBy = s.CreatedBy,							
				ModifiedBy = s.ModifiedBy,							
				CreatedDate = s.CreatedDate,							
				IsCanView = s.IsCanView,							
				IsCanChange = s.IsCanChange,							
				IsCanApprove = s.IsCanApprove,					
			});
                              
        }

		public static DTO_CUS_DOC_Folder_Permission toDTO(tbl_CUS_DOC_Folder_Permission dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_DOC_Folder_Permission()
				{							
					IDPartner = dbResult.IDPartner,							
					IDFolder = dbResult.IDFolder,							
					IDRole = dbResult.IDRole,							
					ID = dbResult.ID,							
					ModifiedDate = dbResult.ModifiedDate,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedBy = dbResult.ModifiedBy,							
					CreatedDate = dbResult.CreatedDate,							
					IsCanView = dbResult.IsCanView,							
					IsCanChange = dbResult.IsCanChange,							
					IsCanApprove = dbResult.IsCanApprove,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_CUS_DOC_Folder_Permission> get_CUS_DOC_Folder_Permission(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_DOC_Folder_Permission.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);

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

			//Query IDFolder (int)
			if (QueryStrings.Any(d => d.Key == "IDFolder"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDFolder").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDFolder));
            }

			//Query IDRole (int)
			if (QueryStrings.Any(d => d.Key == "IDRole"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDRole").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
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

			//Query ModifiedDate (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

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

			//Query IsCanView (bool)
			if (QueryStrings.Any(d => d.Key == "IsCanView"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsCanView").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsCanView);
            }

			//Query IsCanChange (bool)
			if (QueryStrings.Any(d => d.Key == "IsCanChange"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsCanChange").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsCanChange);
            }

			//Query IsCanApprove (bool)
			if (QueryStrings.Any(d => d.Key == "IsCanApprove"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsCanApprove").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsCanApprove);
            }


			return toDTO(query);

        }

		public static DTO_CUS_DOC_Folder_Permission get_CUS_DOC_Folder_Permission(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_CUS_DOC_Folder_Permission.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		

		public static bool put_CUS_DOC_Folder_Permission(AppEntities db, int PartnerID, int ID, DTO_CUS_DOC_Folder_Permission item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_DOC_Folder_Permission.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDFolder = item.IDFolder;							
				dbitem.IDRole = item.IDRole;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.IsCanView = item.IsCanView;							
				dbitem.IsCanChange = item.IsCanChange;							
				dbitem.IsCanApprove = item.IsCanApprove;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_Folder_Permission", dbitem.ModifiedDate, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_DOC_Folder_Permission",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_DOC_Folder_Permission post_CUS_DOC_Folder_Permission(AppEntities db, int PartnerID, DTO_CUS_DOC_Folder_Permission item, string Username)
        {
            tbl_CUS_DOC_Folder_Permission dbitem = new tbl_CUS_DOC_Folder_Permission();
            if (item != null)
            {							
				dbitem.IDFolder = item.IDFolder;							
				dbitem.IDRole = item.IDRole;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.IsCanView = item.IsCanView;							
				dbitem.IsCanChange = item.IsCanChange;							
				dbitem.IsCanApprove = item.IsCanApprove;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_CUS_DOC_Folder_Permission.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_Folder_Permission", dbitem.ModifiedDate, Username);
										
									
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_DOC_Folder_Permission",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_DOC_Folder_Permission(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_DOC_Folder_Permission.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_Folder_Permission", dbitem.ModifiedDate, Username);
										
				
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_DOC_Folder_Permission",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_DOC_Folder_Permission_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_DOC_Folder_Permission.Any(e => e.ID == id);
		}
		
    }

}






