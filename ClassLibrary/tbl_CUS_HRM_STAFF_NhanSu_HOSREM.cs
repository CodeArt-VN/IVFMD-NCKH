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
    
    
    public partial class tbl_CUS_HRM_STAFF_NhanSu_HOSREM
    {
        public int ID { get; set; }
        public int IDNhanSu { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string JSON_DonViCongTac { get; set; }
        public string JSON_HoatDongKhac { get; set; }
        public string JSON_KinhNghiemLamViec { get; set; }
        public string JSON_BaiDangTapChi { get; set; }
        public string HTML { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public string JSON_QuaTrinhDaoTao { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_HRM_STAFF_NhanSu_HOSREM
	{
		public int ID { get; set; }
		public int IDNhanSu { get; set; }
		public string HoTen { get; set; }
		public string Email { get; set; }
		public string JSON_DonViCongTac { get; set; }
		public string JSON_HoatDongKhac { get; set; }
		public string JSON_KinhNghiemLamViec { get; set; }
		public string JSON_BaiDangTapChi { get; set; }
		public string HTML { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public string JSON_QuaTrinhDaoTao { get; set; }
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

    public static partial class BS_CUS_HRM_STAFF_NhanSu_HOSREM 
    {
		public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu_HOSREM> toDTO(IQueryable<tbl_CUS_HRM_STAFF_NhanSu_HOSREM> query)
        {
			return query
			.Select(s => new DTO_CUS_HRM_STAFF_NhanSu_HOSREM(){							
				ID = s.ID,							
				IDNhanSu = s.IDNhanSu,							
				HoTen = s.HoTen,							
				Email = s.Email,							
				JSON_DonViCongTac = s.JSON_DonViCongTac,							
				JSON_HoatDongKhac = s.JSON_HoatDongKhac,							
				JSON_KinhNghiemLamViec = s.JSON_KinhNghiemLamViec,							
				JSON_BaiDangTapChi = s.JSON_BaiDangTapChi,							
				HTML = s.HTML,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				JSON_QuaTrinhDaoTao = s.JSON_QuaTrinhDaoTao,					
			});
                              
        }

		public static DTO_CUS_HRM_STAFF_NhanSu_HOSREM toDTO(tbl_CUS_HRM_STAFF_NhanSu_HOSREM dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_HRM_STAFF_NhanSu_HOSREM()
				{							
					ID = dbResult.ID,							
					IDNhanSu = dbResult.IDNhanSu,							
					HoTen = dbResult.HoTen,							
					Email = dbResult.Email,							
					JSON_DonViCongTac = dbResult.JSON_DonViCongTac,							
					JSON_HoatDongKhac = dbResult.JSON_HoatDongKhac,							
					JSON_KinhNghiemLamViec = dbResult.JSON_KinhNghiemLamViec,							
					JSON_BaiDangTapChi = dbResult.JSON_BaiDangTapChi,							
					HTML = dbResult.HTML,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					JSON_QuaTrinhDaoTao = dbResult.JSON_QuaTrinhDaoTao,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_CUS_HRM_STAFF_NhanSu_HOSREM> get_CUS_HRM_STAFF_NhanSu_HOSREM(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Where(d => d.IsDeleted == false );

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

			//Query IDNhanSu (int)
			if (QueryStrings.Any(d => d.Key == "IDNhanSu"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhanSu").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhanSu));
            }

			//Query HoTen (string)
			if (QueryStrings.Any(d => d.Key == "HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoTen").Value;
                query = query.Where(d=>d.HoTen == keyword);
            }

			//Query Email (string)
			if (QueryStrings.Any(d => d.Key == "Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email").Value;
                query = query.Where(d=>d.Email == keyword);
            }

			//Query JSON_DonViCongTac (string)
			if (QueryStrings.Any(d => d.Key == "JSON_DonViCongTac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_DonViCongTac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_DonViCongTac").Value;
                query = query.Where(d=>d.JSON_DonViCongTac == keyword);
            }

			//Query JSON_HoatDongKhac (string)
			if (QueryStrings.Any(d => d.Key == "JSON_HoatDongKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_HoatDongKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_HoatDongKhac").Value;
                query = query.Where(d=>d.JSON_HoatDongKhac == keyword);
            }

			//Query JSON_KinhNghiemLamViec (string)
			if (QueryStrings.Any(d => d.Key == "JSON_KinhNghiemLamViec") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_KinhNghiemLamViec").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_KinhNghiemLamViec").Value;
                query = query.Where(d=>d.JSON_KinhNghiemLamViec == keyword);
            }

			//Query JSON_BaiDangTapChi (string)
			if (QueryStrings.Any(d => d.Key == "JSON_BaiDangTapChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_BaiDangTapChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_BaiDangTapChi").Value;
                query = query.Where(d=>d.JSON_BaiDangTapChi == keyword);
            }

			//Query HTML (string)
			if (QueryStrings.Any(d => d.Key == "HTML") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value;
                query = query.Where(d=>d.HTML == keyword);
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

			//Query JSON_QuaTrinhDaoTao (string)
			if (QueryStrings.Any(d => d.Key == "JSON_QuaTrinhDaoTao") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_QuaTrinhDaoTao").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_QuaTrinhDaoTao").Value;
                query = query.Where(d=>d.JSON_QuaTrinhDaoTao == keyword);
            }


			return toDTO(query);

        }

		public static DTO_CUS_HRM_STAFF_NhanSu_HOSREM get_CUS_HRM_STAFF_NhanSu_HOSREM(AppEntities db, int id)
        {
            var dbResult = db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_CUS_HRM_STAFF_NhanSu_HOSREM(AppEntities db, int ID, DTO_CUS_HRM_STAFF_NhanSu_HOSREM item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDNhanSu = item.IDNhanSu;							
				dbitem.HoTen = item.HoTen;							
				dbitem.Email = item.Email;							
				dbitem.JSON_DonViCongTac = item.JSON_DonViCongTac;							
				dbitem.JSON_HoatDongKhac = item.JSON_HoatDongKhac;							
				dbitem.JSON_KinhNghiemLamViec = item.JSON_KinhNghiemLamViec;							
				dbitem.JSON_BaiDangTapChi = item.JSON_BaiDangTapChi;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.JSON_QuaTrinhDaoTao = item.JSON_QuaTrinhDaoTao;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_HOSREM", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_HRM_STAFF_NhanSu_HOSREM",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_HRM_STAFF_NhanSu_HOSREM post_CUS_HRM_STAFF_NhanSu_HOSREM(AppEntities db, DTO_CUS_HRM_STAFF_NhanSu_HOSREM item, string Username)
        {
            tbl_CUS_HRM_STAFF_NhanSu_HOSREM dbitem = new tbl_CUS_HRM_STAFF_NhanSu_HOSREM();
            if (item != null)
            {							
				dbitem.IDNhanSu = item.IDNhanSu;							
				dbitem.HoTen = item.HoTen;							
				dbitem.Email = item.Email;							
				dbitem.JSON_DonViCongTac = item.JSON_DonViCongTac;							
				dbitem.JSON_HoatDongKhac = item.JSON_HoatDongKhac;							
				dbitem.JSON_KinhNghiemLamViec = item.JSON_KinhNghiemLamViec;							
				dbitem.JSON_BaiDangTapChi = item.JSON_BaiDangTapChi;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.JSON_QuaTrinhDaoTao = item.JSON_QuaTrinhDaoTao;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_HOSREM", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_HRM_STAFF_NhanSu_HOSREM",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_HRM_STAFF_NhanSu_HOSREM(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_HOSREM", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_HRM_STAFF_NhanSu_HOSREM",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_HRM_STAFF_NhanSu_HOSREM_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Any(e => e.ID == id);
		}
		
    }

}






