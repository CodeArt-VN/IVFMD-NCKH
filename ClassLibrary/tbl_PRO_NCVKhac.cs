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
    
    
    public partial class tbl_PRO_NCVKhac
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public int IDNCV { get; set; }
        public string ChucDanh { get; set; }
        public string ChucVu { get; set; }
        public bool IsCanView { get; set; }
        public bool IsCanChange { get; set; }
        public bool IsCanApprove { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_NCVKhac
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public int IDNCV { get; set; }
		public string ChucDanh { get; set; }
		public string ChucVu { get; set; }
		public bool IsCanView { get; set; }
		public bool IsCanChange { get; set; }
		public bool IsCanApprove { get; set; }
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

    public static partial class BS_PRO_NCVKhac 
    {
		public static IQueryable<DTO_PRO_NCVKhac> toDTO(IQueryable<tbl_PRO_NCVKhac> query)
        {
			return query
			.Select(s => new DTO_PRO_NCVKhac(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				IDNCV = s.IDNCV,							
				ChucDanh = s.ChucDanh,							
				ChucVu = s.ChucVu,							
				IsCanView = s.IsCanView,							
				IsCanChange = s.IsCanChange,							
				IsCanApprove = s.IsCanApprove,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_NCVKhac toDTO(tbl_PRO_NCVKhac dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_NCVKhac()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					IDNCV = dbResult.IDNCV,							
					ChucDanh = dbResult.ChucDanh,							
					ChucVu = dbResult.ChucVu,							
					IsCanView = dbResult.IsCanView,							
					IsCanChange = dbResult.IsCanChange,							
					IsCanApprove = dbResult.IsCanApprove,							
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

        public static IQueryable<DTO_PRO_NCVKhac> get_PRO_NCVKhac(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_NCVKhac
			.Where(d => d.IsDeleted == false );
			

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

			//Query IDNCV (int)
			if (QueryStrings.Any(d => d.Key == "IDNCV"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNCV").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNCV));
            }

			//Query ChucDanh (string)
			if (QueryStrings.Any(d => d.Key == "ChucDanh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ChucDanh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ChucDanh").Value;
                query = query.Where(d=>d.ChucDanh == keyword);
            }

			//Query ChucVu (string)
			if (QueryStrings.Any(d => d.Key == "ChucVu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ChucVu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ChucVu").Value;
                query = query.Where(d=>d.ChucVu == keyword);
            }

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

		public static DTO_PRO_NCVKhac get_PRO_NCVKhac(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PRO_NCVKhac.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_NCVKhac(AppEntities db, int PartnerID, int ID, DTO_PRO_NCVKhac item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_NCVKhac.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDNCV = item.IDNCV;							
				dbitem.ChucDanh = item.ChucDanh;							
				dbitem.ChucVu = item.ChucVu;							
				dbitem.IsCanView = item.IsCanView;							
				dbitem.IsCanChange = item.IsCanChange;							
				dbitem.IsCanApprove = item.IsCanApprove;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_NCVKhac", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_NCVKhac",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_NCVKhac post_PRO_NCVKhac(AppEntities db, int PartnerID, DTO_PRO_NCVKhac item, string Username)
        {
            tbl_PRO_NCVKhac dbitem = new tbl_PRO_NCVKhac();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDNCV = item.IDNCV;							
				dbitem.ChucDanh = item.ChucDanh;							
				dbitem.ChucVu = item.ChucVu;							
				dbitem.IsCanView = item.IsCanView;							
				dbitem.IsCanChange = item.IsCanChange;							
				dbitem.IsCanApprove = item.IsCanApprove;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_NCVKhac.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_NCVKhac", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_NCVKhac",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_NCVKhac(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_NCVKhac.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_NCVKhac", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_NCVKhac",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_NCVKhac_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_NCVKhac.Any(e => e.ID == id);
		}
		
    }

}






