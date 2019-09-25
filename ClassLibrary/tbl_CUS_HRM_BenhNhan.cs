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
    
    
    public partial class tbl_CUS_HRM_BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CUS_HRM_BenhNhan()
        {
            this.tbl_PRO_BenhNhan = new HashSet<tbl_PRO_BenhNhan>();
        }
    
        public int ID { get; set; }
        public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoaiCQ { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string CMND { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_BenhNhan> tbl_PRO_BenhNhan { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_HRM_BenhNhan
	{
		public int ID { get; set; }
		public string MaBenhNhan { get; set; }
		public string HoTen { get; set; }
		public string GioiTinh { get; set; }
		public Nullable<System.DateTime> NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public string DienThoaiCQ { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public string CMND { get; set; }
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

    public static partial class BS_CUS_HRM_BenhNhan 
    {
		public static IQueryable<DTO_CUS_HRM_BenhNhan> toDTO(IQueryable<tbl_CUS_HRM_BenhNhan> query)
        {
			return query
			.Select(s => new DTO_CUS_HRM_BenhNhan(){							
				ID = s.ID,							
				MaBenhNhan = s.MaBenhNhan,							
				HoTen = s.HoTen,							
				GioiTinh = s.GioiTinh,							
				NgaySinh = s.NgaySinh,							
				DiaChi = s.DiaChi,							
				DienThoaiCQ = s.DienThoaiCQ,							
				Mobile = s.Mobile,							
				Email = s.Email,							
				CMND = s.CMND,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_CUS_HRM_BenhNhan toDTO(tbl_CUS_HRM_BenhNhan dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_HRM_BenhNhan()
				{							
					ID = dbResult.ID,							
					MaBenhNhan = dbResult.MaBenhNhan,							
					HoTen = dbResult.HoTen,							
					GioiTinh = dbResult.GioiTinh,							
					NgaySinh = dbResult.NgaySinh,							
					DiaChi = dbResult.DiaChi,							
					DienThoaiCQ = dbResult.DienThoaiCQ,							
					Mobile = dbResult.Mobile,							
					Email = dbResult.Email,							
					CMND = dbResult.CMND,							
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

        public static IQueryable<DTO_CUS_HRM_BenhNhan> get_CUS_HRM_BenhNhan(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_HRM_BenhNhan.Where(d => d.IsDeleted == false );

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

			//Query MaBenhNhan (string)
			if (QueryStrings.Any(d => d.Key == "MaBenhNhan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaBenhNhan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaBenhNhan").Value;
                query = query.Where(d=>d.MaBenhNhan == keyword);
            }

			//Query HoTen (string)
			if (QueryStrings.Any(d => d.Key == "HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoTen").Value;
                query = query.Where(d=>d.HoTen == keyword);
            }

			//Query GioiTinh (string)
			if (QueryStrings.Any(d => d.Key == "GioiTinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GioiTinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GioiTinh").Value;
                query = query.Where(d=>d.GioiTinh == keyword);
            }

			//Query NgaySinh (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "NgaySinhFrom") && QueryStrings.Any(d => d.Key == "NgaySinhTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgaySinhFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgaySinhTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgaySinh && d.NgaySinh <= toDate);

			//Query DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value;
                query = query.Where(d=>d.DiaChi == keyword);
            }

			//Query DienThoaiCQ (string)
			if (QueryStrings.Any(d => d.Key == "DienThoaiCQ") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiCQ").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiCQ").Value;
                query = query.Where(d=>d.DienThoaiCQ == keyword);
            }

			//Query Mobile (string)
			if (QueryStrings.Any(d => d.Key == "Mobile") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Mobile").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Mobile").Value;
                query = query.Where(d=>d.Mobile == keyword);
            }

			//Query Email (string)
			if (QueryStrings.Any(d => d.Key == "Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email").Value;
                query = query.Where(d=>d.Email == keyword);
            }

			//Query CMND (string)
			if (QueryStrings.Any(d => d.Key == "CMND") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CMND").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CMND").Value;
                query = query.Where(d=>d.CMND == keyword);
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

		public static DTO_CUS_HRM_BenhNhan get_CUS_HRM_BenhNhan(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_CUS_HRM_BenhNhan.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_CUS_HRM_BenhNhan(AppEntities db, int PartnerID, int ID, DTO_CUS_HRM_BenhNhan item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_HRM_BenhNhan.Find(ID);
            if (dbitem != null)
            {							
				dbitem.MaBenhNhan = item.MaBenhNhan;							
				dbitem.HoTen = item.HoTen;							
				dbitem.GioiTinh = item.GioiTinh;							
				dbitem.NgaySinh = item.NgaySinh;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoaiCQ = item.DienThoaiCQ;							
				dbitem.Mobile = item.Mobile;							
				dbitem.Email = item.Email;							
				dbitem.CMND = item.CMND;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_BenhNhan", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_HRM_BenhNhan",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_HRM_BenhNhan post_CUS_HRM_BenhNhan(AppEntities db, int PartnerID, DTO_CUS_HRM_BenhNhan item, string Username)
        {
            tbl_CUS_HRM_BenhNhan dbitem = new tbl_CUS_HRM_BenhNhan();
            if (item != null)
            {							
				dbitem.MaBenhNhan = item.MaBenhNhan;							
				dbitem.HoTen = item.HoTen;							
				dbitem.GioiTinh = item.GioiTinh;							
				dbitem.NgaySinh = item.NgaySinh;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoaiCQ = item.DienThoaiCQ;							
				dbitem.Mobile = item.Mobile;							
				dbitem.Email = item.Email;							
				dbitem.CMND = item.CMND;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_CUS_HRM_BenhNhan.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_BenhNhan", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_HRM_BenhNhan",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_HRM_BenhNhan(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_HRM_BenhNhan.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_BenhNhan", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_HRM_BenhNhan",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_HRM_BenhNhan_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_HRM_BenhNhan.Any(e => e.ID == id);
		}
		
    }

}






