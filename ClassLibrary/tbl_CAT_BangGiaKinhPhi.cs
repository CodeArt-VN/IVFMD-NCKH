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
    
    
    public partial class tbl_CAT_BangGiaKinhPhi
    {
        public int ID { get; set; }
        public int IDKinhPhi { get; set; }
        public System.DateTime NgayHieuLuc { get; set; }
        public decimal Gia { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_CAT_KinhPhi tbl_CAT_KinhPhi { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CAT_BangGiaKinhPhi
	{
		public int ID { get; set; }
		public int IDKinhPhi { get; set; }
		public System.DateTime NgayHieuLuc { get; set; }
		public decimal Gia { get; set; }
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

    public static partial class BS_CAT_BangGiaKinhPhi 
    {
		public static IQueryable<DTO_CAT_BangGiaKinhPhi> toDTO(IQueryable<tbl_CAT_BangGiaKinhPhi> query)
        {
			return query
			.Select(s => new DTO_CAT_BangGiaKinhPhi(){							
				ID = s.ID,							
				IDKinhPhi = s.IDKinhPhi,							
				NgayHieuLuc = s.NgayHieuLuc,							
				Gia = s.Gia,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_CAT_BangGiaKinhPhi toDTO(tbl_CAT_BangGiaKinhPhi dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CAT_BangGiaKinhPhi()
				{							
					ID = dbResult.ID,							
					IDKinhPhi = dbResult.IDKinhPhi,							
					NgayHieuLuc = dbResult.NgayHieuLuc,							
					Gia = dbResult.Gia,							
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

        public static IQueryable<DTO_CAT_BangGiaKinhPhi> get_CAT_BangGiaKinhPhi(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CAT_BangGiaKinhPhi.Where(d => d.IsDeleted == false );

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

			//Query IDKinhPhi (int)
			if (QueryStrings.Any(d => d.Key == "IDKinhPhi"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDKinhPhi").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDKinhPhi));
            }

			//Query NgayHieuLuc (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "NgayHieuLucFrom") && QueryStrings.Any(d => d.Key == "NgayHieuLucTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHieuLucFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHieuLucTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayHieuLuc && d.NgayHieuLuc <= toDate);

			//Query Gia (decimal)
			if (QueryStrings.Any(d => d.Key == "GiaFrom") && QueryStrings.Any(d => d.Key == "GiaTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "GiaFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "GiaTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.Gia && d.Gia <= toVal);

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

		public static DTO_CAT_BangGiaKinhPhi get_CAT_BangGiaKinhPhi(AppEntities db, int id)
        {
            var dbResult = db.tbl_CAT_BangGiaKinhPhi.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_CAT_BangGiaKinhPhi(AppEntities db, int ID, DTO_CAT_BangGiaKinhPhi item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CAT_BangGiaKinhPhi.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDKinhPhi = item.IDKinhPhi;							
				dbitem.NgayHieuLuc = item.NgayHieuLuc.ToLocalTime();							
				dbitem.Gia = item.Gia;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_BangGiaKinhPhi", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CAT_BangGiaKinhPhi",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CAT_BangGiaKinhPhi post_CAT_BangGiaKinhPhi(AppEntities db, DTO_CAT_BangGiaKinhPhi item, string Username)
        {
            tbl_CAT_BangGiaKinhPhi dbitem = new tbl_CAT_BangGiaKinhPhi();
            if (item != null)
            {							
				dbitem.IDKinhPhi = item.IDKinhPhi;							
				dbitem.NgayHieuLuc = item.NgayHieuLuc.ToLocalTime();							
				dbitem.Gia = item.Gia;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_CAT_BangGiaKinhPhi.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_BangGiaKinhPhi", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CAT_BangGiaKinhPhi",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CAT_BangGiaKinhPhi(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CAT_BangGiaKinhPhi.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_BangGiaKinhPhi", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CAT_BangGiaKinhPhi",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CAT_BangGiaKinhPhi_Exists(AppEntities db, int id)
		{
			return db.tbl_CAT_BangGiaKinhPhi.Any(e => e.ID == id);
		}
		
    }

}






