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
    
    
    public partial class tbl_CUS_SYS_PermissionList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CUS_SYS_PermissionList()
        {
            this.tbl_CUS_SYS_PermissionListDetailData = new HashSet<tbl_CUS_SYS_PermissionListDetailData>();
        }
    
        public int IDPartner { get; set; }
        public int IDRole { get; set; }
        public int IDForm { get; set; }
        public int ID { get; set; }
        public int Value { get; set; }
        public bool Visible { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_SYS_PermissionListDetailData> tbl_CUS_SYS_PermissionListDetailData { get; set; }
        public virtual tbl_CUS_SYS_Role tbl_CUS_SYS_Role { get; set; }
        public virtual tbl_SYS_Form tbl_SYS_Form { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_SYS_PermissionList
	{
		public int IDPartner { get; set; }
		public int IDRole { get; set; }
		public int IDForm { get; set; }
		public int ID { get; set; }
		public int Value { get; set; }
		public bool Visible { get; set; }
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

    public static partial class BS_CUS_SYS_PermissionList 
    {
		public static IQueryable<DTO_CUS_SYS_PermissionList> toDTO(IQueryable<tbl_CUS_SYS_PermissionList> query)
        {
			return query
			.Select(s => new DTO_CUS_SYS_PermissionList(){							
				IDPartner = s.IDPartner,							
				IDRole = s.IDRole,							
				IDForm = s.IDForm,							
				ID = s.ID,							
				Value = s.Value,							
				Visible = s.Visible,					
			});
                              
        }

		public static DTO_CUS_SYS_PermissionList toDTO(tbl_CUS_SYS_PermissionList dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_SYS_PermissionList()
				{							
					IDPartner = dbResult.IDPartner,							
					IDRole = dbResult.IDRole,							
					IDForm = dbResult.IDForm,							
					ID = dbResult.ID,							
					Value = dbResult.Value,							
					Visible = dbResult.Visible,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_CUS_SYS_PermissionList> get_CUS_SYS_PermissionList(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_SYS_PermissionList
			.Where(d => d.IDPartner == PartnerID);
			

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

			//Query IDForm (int)
			if (QueryStrings.Any(d => d.Key == "IDForm"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDForm").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
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

			//Query Value (int)
			if (QueryStrings.Any(d => d.Key == "ValueFrom") && QueryStrings.Any(d => d.Key == "ValueTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ValueFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ValueTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.Value && d.Value <= toVal);

			//Query Visible (bool)
			if (QueryStrings.Any(d => d.Key == "Visible"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "Visible").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.Visible);
            }


			return toDTO(query);

        }

		public static DTO_CUS_SYS_PermissionList get_CUS_SYS_PermissionList(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_CUS_SYS_PermissionList.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		

		public static bool put_CUS_SYS_PermissionList(AppEntities db, int PartnerID, int ID, DTO_CUS_SYS_PermissionList item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_SYS_PermissionList.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDRole = item.IDRole;							
				dbitem.IDForm = item.IDForm;							
				dbitem.Value = item.Value;							
				dbitem.Visible = item.Visible;                
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_SYS_PermissionList", DateTime.Now, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_SYS_PermissionList",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_SYS_PermissionList post_CUS_SYS_PermissionList(AppEntities db, int PartnerID, DTO_CUS_SYS_PermissionList item, string Username)
        {
            tbl_CUS_SYS_PermissionList dbitem = new tbl_CUS_SYS_PermissionList();
            if (item != null)
            {							
				dbitem.IDRole = item.IDRole;							
				dbitem.IDForm = item.IDForm;							
				dbitem.Value = item.Value;							
				dbitem.Visible = item.Visible;                
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_CUS_SYS_PermissionList.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_SYS_PermissionList", DateTime.Now, Username);
										
									
					
                    item.ID =  dbitem.ID;
															
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_SYS_PermissionList",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_SYS_PermissionList(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_SYS_PermissionList.Find(ID);
            if (dbitem != null)
            {
			
				db.tbl_CUS_SYS_PermissionList.Remove(dbitem);
			                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_SYS_PermissionList", DateTime.Now, Username);
										
				
					
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_SYS_PermissionList",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_SYS_PermissionList_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_SYS_PermissionList.Any(e => e.ID == id);
		}
		
    }

}






