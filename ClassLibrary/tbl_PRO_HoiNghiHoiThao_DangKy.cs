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
    
    
    public partial class tbl_PRO_HoiNghiHoiThao_DangKy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PRO_HoiNghiHoiThao_DangKy()
        {
            this.tbl_PRO_HoiNghiHoiThao_DangKyDeTai = new HashSet<tbl_PRO_HoiNghiHoiThao_DangKyDeTai>();
        }
    
        public int ID { get; set; }
        public int IDNhanVien { get; set; }
        public int IDHoiNghiHoiThao { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu { get; set; }
        public virtual tbl_PRO_HoiNghiHoiThao tbl_PRO_HoiNghiHoiThao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_HoiNghiHoiThao_DangKyDeTai> tbl_PRO_HoiNghiHoiThao_DangKyDeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_HoiNghiHoiThao_DangKy
	{
		public int ID { get; set; }
		public int IDNhanVien { get; set; }
		public int IDHoiNghiHoiThao { get; set; }
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

    public static partial class BS_PRO_HoiNghiHoiThao_DangKy 
    {
		public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKy> toDTO(IQueryable<tbl_PRO_HoiNghiHoiThao_DangKy> query)
        {
			return query
			.Select(s => new DTO_PRO_HoiNghiHoiThao_DangKy(){							
				ID = s.ID,							
				IDNhanVien = s.IDNhanVien,							
				IDHoiNghiHoiThao = s.IDHoiNghiHoiThao,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_HoiNghiHoiThao_DangKy toDTO(tbl_PRO_HoiNghiHoiThao_DangKy dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_HoiNghiHoiThao_DangKy()
				{							
					ID = dbResult.ID,							
					IDNhanVien = dbResult.IDNhanVien,							
					IDHoiNghiHoiThao = dbResult.IDHoiNghiHoiThao,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKy> get_PRO_HoiNghiHoiThao_DangKy(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_HoiNghiHoiThao_DangKy.AsQueryable();

			//Query keyword



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

			//Query IDNhanVien (int)
			if (QueryStrings.Any(d => d.Key == "IDNhanVien"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhanVien").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhanVien));
            }

			//Query IDHoiNghiHoiThao (int)
			if (QueryStrings.Any(d => d.Key == "IDHoiNghiHoiThao"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHoiNghiHoiThao").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHoiNghiHoiThao));
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

		public static DTO_PRO_HoiNghiHoiThao_DangKy get_PRO_HoiNghiHoiThao_DangKy(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_HoiNghiHoiThao_DangKy.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_HoiNghiHoiThao_DangKy(AppEntities db, int ID, DTO_PRO_HoiNghiHoiThao_DangKy item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKy.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDNhanVien = item.IDNhanVien;							
				dbitem.IDHoiNghiHoiThao = item.IDHoiNghiHoiThao;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKy", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_HoiNghiHoiThao_DangKy",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_HoiNghiHoiThao_DangKy post_PRO_HoiNghiHoiThao_DangKy(AppEntities db, DTO_PRO_HoiNghiHoiThao_DangKy item, string Username)
        {
            tbl_PRO_HoiNghiHoiThao_DangKy dbitem = new tbl_PRO_HoiNghiHoiThao_DangKy();
            if (item != null)
            {							
				dbitem.IDNhanVien = item.IDNhanVien;							
				dbitem.IDHoiNghiHoiThao = item.IDHoiNghiHoiThao;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_HoiNghiHoiThao_DangKy.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKy", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_HoiNghiHoiThao_DangKy",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_HoiNghiHoiThao_DangKy(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKy.Find(ID);
            if (dbitem != null)
            {
			
				db.tbl_PRO_HoiNghiHoiThao_DangKy.Remove(dbitem);
			                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKy", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_HoiNghiHoiThao_DangKy",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_HoiNghiHoiThao_DangKy_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_HoiNghiHoiThao_DangKy.Any(e => e.ID == id);
		}
		
    }

}






