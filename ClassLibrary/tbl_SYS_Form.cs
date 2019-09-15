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
    
    
    public partial class tbl_SYS_Form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SYS_Form()
        {
            this.tbl_CUS_SYS_PermissionList = new HashSet<tbl_CUS_SYS_PermissionList>();
            this.tbl_SYS_FormDetail = new HashSet<tbl_SYS_FormDetail>();
        }
    
        public int IDFormGroup { get; set; }
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
        public int Type { get; set; }
        public string Icon { get; set; }
        public string BadgeColor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_SYS_PermissionList> tbl_CUS_SYS_PermissionList { get; set; }
        public virtual tbl_SYS_FormGroup tbl_SYS_FormGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SYS_FormDetail> tbl_SYS_FormDetail { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_SYS_Form
	{
		public int IDFormGroup { get; set; }
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
		public int Type { get; set; }
		public string Icon { get; set; }
		public string BadgeColor { get; set; }
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

    public static partial class BS_SYS_Form 
    {
		public static IQueryable<DTO_SYS_Form> toDTO(IQueryable<tbl_SYS_Form> query)
        {
			return query
			.Select(s => new DTO_SYS_Form(){							
				IDFormGroup = s.IDFormGroup,							
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
				Type = s.Type,							
				Icon = s.Icon,							
				BadgeColor = s.BadgeColor,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_SYS_Form toDTO(tbl_SYS_Form dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_SYS_Form()
				{							
					IDFormGroup = dbResult.IDFormGroup,							
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
					Type = dbResult.Type,							
					Icon = dbResult.Icon,							
					BadgeColor = dbResult.BadgeColor,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_SYS_Form> get_SYS_Form(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_SYS_Form
			.Where(d => d.IsDeleted == false );
			

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



			//Query IDFormGroup (int)
			if (QueryStrings.Any(d => d.Key == "IDFormGroup"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDFormGroup").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDFormGroup));
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

			//Query Type (int)
			if (QueryStrings.Any(d => d.Key == "TypeFrom") && QueryStrings.Any(d => d.Key == "TypeTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TypeFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TypeTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.Type && d.Type <= toVal);

			//Query Icon (string)
			if (QueryStrings.Any(d => d.Key == "Icon") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Icon").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Icon").Value;
                query = query.Where(d=>d.Icon == keyword);
            }

			//Query BadgeColor (string)
			if (QueryStrings.Any(d => d.Key == "BadgeColor") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BadgeColor").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BadgeColor").Value;
                query = query.Where(d=>d.BadgeColor == keyword);
            }


			return toDTO(query);

        }

		public static DTO_SYS_Form get_SYS_Form(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_SYS_Form.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_SYS_Form get_SYS_Form(AppEntities db, int PartnerID, string code)
        {
            var dbResult = db.tbl_SYS_Form
			.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );

			return toDTO(dbResult);
			
        }

		public static bool put_SYS_Form(AppEntities db, int PartnerID, int ID, DTO_SYS_Form item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_SYS_Form.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDFormGroup = item.IDFormGroup;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Type = item.Type;							
				dbitem.Icon = item.Icon;							
				dbitem.BadgeColor = item.BadgeColor;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Form", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_SYS_Form",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_SYS_Form post_SYS_Form(AppEntities db, int PartnerID, DTO_SYS_Form item, string Username)
        {
            tbl_SYS_Form dbitem = new tbl_SYS_Form();
            if (item != null)
            {							
				dbitem.IDFormGroup = item.IDFormGroup;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Type = item.Type;							
				dbitem.Icon = item.Icon;							
				dbitem.BadgeColor = item.BadgeColor;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_SYS_Form.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Form", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_SYS_Form",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_SYS_Form(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_SYS_Form.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Form", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_SYS_Form",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_SYS_Form_Exists(AppEntities db, int id)
		{
			return db.tbl_SYS_Form.Any(e => e.ID == id);
		}
		
		public static bool check_SYS_Form_Exists(AppEntities db, string Code)
		{
			return db.tbl_SYS_Form.Any(e => e.Code == Code);
		}
		
    }

}






