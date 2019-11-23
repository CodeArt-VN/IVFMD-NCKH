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
    
    
    public partial class tbl_PRO_BaoCaoTienDoNghienCuu
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string SoCaThuThapHopLe { get; set; }
        public string TienDoThuNhanMau { get; set; }
        public string KhoKhan { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_BaoCaoTienDoNghienCuu
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string SoCaThuThapHopLe { get; set; }
		public string TienDoThuNhanMau { get; set; }
		public string KhoKhan { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
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

    public static partial class BS_PRO_BaoCaoTienDoNghienCuu 
    {
		public static IQueryable<DTO_PRO_BaoCaoTienDoNghienCuu> toDTO(IQueryable<tbl_PRO_BaoCaoTienDoNghienCuu> query)
        {
			return query
			.Select(s => new DTO_PRO_BaoCaoTienDoNghienCuu(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				SoCaThuThapHopLe = s.SoCaThuThapHopLe,							
				TienDoThuNhanMau = s.TienDoThuNhanMau,							
				KhoKhan = s.KhoKhan,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,					
			});
                              
        }

		public static DTO_PRO_BaoCaoTienDoNghienCuu toDTO(tbl_PRO_BaoCaoTienDoNghienCuu dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_BaoCaoTienDoNghienCuu()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					SoCaThuThapHopLe = dbResult.SoCaThuThapHopLe,							
					TienDoThuNhanMau = dbResult.TienDoThuNhanMau,							
					KhoKhan = dbResult.KhoKhan,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_BaoCaoTienDoNghienCuu> get_PRO_BaoCaoTienDoNghienCuu(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_BaoCaoTienDoNghienCuu.Where(d => d.IsDeleted == false );

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

			//Query IDDeTai (int)
			if (QueryStrings.Any(d => d.Key == "IDDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDeTai));
            }

			//Query SoCaThuThapHopLe (string)
			if (QueryStrings.Any(d => d.Key == "SoCaThuThapHopLe") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoCaThuThapHopLe").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoCaThuThapHopLe").Value;
                query = query.Where(d=>d.SoCaThuThapHopLe == keyword);
            }

			//Query TienDoThuNhanMau (string)
			if (QueryStrings.Any(d => d.Key == "TienDoThuNhanMau") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TienDoThuNhanMau").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TienDoThuNhanMau").Value;
                query = query.Where(d=>d.TienDoThuNhanMau == keyword);
            }

			//Query KhoKhan (string)
			if (QueryStrings.Any(d => d.Key == "KhoKhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "KhoKhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "KhoKhan").Value;
                query = query.Where(d=>d.KhoKhan == keyword);
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


			return toDTO(query);

        }

		public static DTO_PRO_BaoCaoTienDoNghienCuu get_PRO_BaoCaoTienDoNghienCuu(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_BaoCaoTienDoNghienCuu.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_BaoCaoTienDoNghienCuu(AppEntities db, int ID, DTO_PRO_BaoCaoTienDoNghienCuu item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_BaoCaoTienDoNghienCuu.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.SoCaThuThapHopLe = item.SoCaThuThapHopLe;							
				dbitem.TienDoThuNhanMau = item.TienDoThuNhanMau;							
				dbitem.KhoKhan = item.KhoKhan;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoTienDoNghienCuu", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_BaoCaoTienDoNghienCuu",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_BaoCaoTienDoNghienCuu post_PRO_BaoCaoTienDoNghienCuu(AppEntities db, DTO_PRO_BaoCaoTienDoNghienCuu item, string Username)
        {
            tbl_PRO_BaoCaoTienDoNghienCuu dbitem = new tbl_PRO_BaoCaoTienDoNghienCuu();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.SoCaThuThapHopLe = item.SoCaThuThapHopLe;							
				dbitem.TienDoThuNhanMau = item.TienDoThuNhanMau;							
				dbitem.KhoKhan = item.KhoKhan;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_BaoCaoTienDoNghienCuu.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoTienDoNghienCuu", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_BaoCaoTienDoNghienCuu",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_BaoCaoTienDoNghienCuu(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_BaoCaoTienDoNghienCuu.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoTienDoNghienCuu", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_BaoCaoTienDoNghienCuu",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_BaoCaoTienDoNghienCuu_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_BaoCaoTienDoNghienCuu.Any(e => e.ID == id);
		}
		
    }

}






