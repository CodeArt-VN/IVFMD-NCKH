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
    
    
    public partial class tbl_SYS_Var
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SYS_Var()
        {
            this.tbl_PRO_DeTai = new HashSet<tbl_PRO_DeTai>();
            this.tbl_PRO_DeTai1 = new HashSet<tbl_PRO_DeTai>();
            this.tbl_PRO_DeTai2 = new HashSet<tbl_PRO_DeTai>();
            this.tbl_PRO_DeTai3 = new HashSet<tbl_PRO_DeTai>();
            this.tbl_PRO_DeTai4 = new HashSet<tbl_PRO_DeTai>();
            this.tbl_PRO_HoiNghiHoiThao = new HashSet<tbl_PRO_HoiNghiHoiThao>();
            this.tbl_PRO_TrangThai_Log = new HashSet<tbl_PRO_TrangThai_Log>();
            this.tbl_PRO_TrangThai_Log1 = new HashSet<tbl_PRO_TrangThai_Log>();
            this.tbl_PRO_TrangThai_Log2 = new HashSet<tbl_PRO_TrangThai_Log>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string ValueOfVar { get; set; }
        public Nullable<int> TypeOfVar { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DeTai> tbl_PRO_DeTai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DeTai> tbl_PRO_DeTai1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DeTai> tbl_PRO_DeTai2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DeTai> tbl_PRO_DeTai3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DeTai> tbl_PRO_DeTai4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_HoiNghiHoiThao> tbl_PRO_HoiNghiHoiThao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_TrangThai_Log> tbl_PRO_TrangThai_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_TrangThai_Log> tbl_PRO_TrangThai_Log1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_TrangThai_Log> tbl_PRO_TrangThai_Log2 { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_SYS_Var
	{
		public int ID { get; set; }
		public string Code { get; set; }
		public string ValueOfVar { get; set; }
		public Nullable<int> TypeOfVar { get; set; }
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

    public static partial class BS_SYS_Var 
    {
		public static IQueryable<DTO_SYS_Var> toDTO(IQueryable<tbl_SYS_Var> query)
        {
			return query
			.Select(s => new DTO_SYS_Var(){							
				ID = s.ID,							
				Code = s.Code,							
				ValueOfVar = s.ValueOfVar,							
				TypeOfVar = s.TypeOfVar,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_SYS_Var toDTO(tbl_SYS_Var dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_SYS_Var()
				{							
					ID = dbResult.ID,							
					Code = dbResult.Code,							
					ValueOfVar = dbResult.ValueOfVar,							
					TypeOfVar = dbResult.TypeOfVar,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_SYS_Var> get_SYS_Var(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_SYS_Var.AsQueryable();

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Code.Contains(keyword));
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

			//Query ValueOfVar (string)
			if (QueryStrings.Any(d => d.Key == "ValueOfVar") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ValueOfVar").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ValueOfVar").Value;
                query = query.Where(d=>d.ValueOfVar == keyword);
            }

			//Query TypeOfVar (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "TypeOfVarFrom") && QueryStrings.Any(d => d.Key == "TypeOfVarTo"))
                if (int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TypeOfVarFrom").Value, out int fromVal) && int.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "TypeOfVarTo").Value, out int toVal))
                    query = query.Where(d => fromVal <= d.TypeOfVar && d.TypeOfVar <= toVal);

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

		public static DTO_SYS_Var get_SYS_Var(AppEntities db, int id)
        {
            var dbResult = db.tbl_SYS_Var.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_SYS_Var get_SYS_Var(AppEntities db, string code)
        {
            var dbResult = db.tbl_SYS_Var.FirstOrDefault(d => d.Code == code);
			return toDTO(dbResult);
			
        }

		public static bool put_SYS_Var(AppEntities db, int ID, DTO_SYS_Var item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_SYS_Var.Find(ID);
            if (dbitem != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.ValueOfVar = item.ValueOfVar;							
				dbitem.TypeOfVar = item.TypeOfVar;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Var", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_SYS_Var",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_SYS_Var post_SYS_Var(AppEntities db, DTO_SYS_Var item, string Username)
        {
            tbl_SYS_Var dbitem = new tbl_SYS_Var();
            if (item != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.ValueOfVar = item.ValueOfVar;							
				dbitem.TypeOfVar = item.TypeOfVar;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_SYS_Var.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Var", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_SYS_Var",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_SYS_Var(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_SYS_Var.Find(ID);
            if (dbitem != null)
            {
			
				db.tbl_SYS_Var.Remove(dbitem);
			                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_SYS_Var", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_SYS_Var",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_SYS_Var_Exists(AppEntities db, int id)
		{
			return db.tbl_SYS_Var.Any(e => e.ID == id);
		}
		
		public static bool check_SYS_Var_Exists(AppEntities db, string Code)
		{
			return db.tbl_SYS_Var.Any(e => e.Code == Code);
		}
		
    }

}






