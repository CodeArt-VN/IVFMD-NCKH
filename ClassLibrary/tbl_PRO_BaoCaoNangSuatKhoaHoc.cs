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
    
    
    public partial class tbl_PRO_BaoCaoNangSuatKhoaHoc
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public Nullable<int> IDNhom { get; set; }
        public Nullable<int> IDSite { get; set; }
        public string TenDeTai { get; set; }
        public System.DateTime NgayBaoCao { get; set; }
        public string TapChiHoiNghi { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_CAT_Nhom tbl_CAT_Nhom { get; set; }
        public virtual tbl_CAT_Site tbl_CAT_Site { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_BaoCaoNangSuatKhoaHoc
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public Nullable<int> IDNhom { get; set; }
		public Nullable<int> IDSite { get; set; }
		public string TenDeTai { get; set; }
		public System.DateTime NgayBaoCao { get; set; }
		public string TapChiHoiNghi { get; set; }
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

    public static partial class BS_PRO_BaoCaoNangSuatKhoaHoc 
    {
		public static IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> toDTO(IQueryable<tbl_PRO_BaoCaoNangSuatKhoaHoc> query)
        {
			return query
			.Select(s => new DTO_PRO_BaoCaoNangSuatKhoaHoc(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				IDNhom = s.IDNhom,							
				IDSite = s.IDSite,							
				TenDeTai = s.TenDeTai,							
				NgayBaoCao = s.NgayBaoCao,							
				TapChiHoiNghi = s.TapChiHoiNghi,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_BaoCaoNangSuatKhoaHoc toDTO(tbl_PRO_BaoCaoNangSuatKhoaHoc dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_BaoCaoNangSuatKhoaHoc()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					IDNhom = dbResult.IDNhom,							
					IDSite = dbResult.IDSite,							
					TenDeTai = dbResult.TenDeTai,							
					NgayBaoCao = dbResult.NgayBaoCao,							
					TapChiHoiNghi = dbResult.TapChiHoiNghi,							
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

        public static IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> get_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Where(d => d.IsDeleted == false );

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

			//Query IDNhom (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDNhom"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhom").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhom));
            }

			//Query IDSite (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDSite"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDSite").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDSite));
            }

			//Query TenDeTai (string)
			if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d=>d.TenDeTai == keyword);
            }

			//Query NgayBaoCao (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "NgayBaoCaoFrom") && QueryStrings.Any(d => d.Key == "NgayBaoCaoTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCaoFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayBaoCaoTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayBaoCao && d.NgayBaoCao <= toDate);

			//Query TapChiHoiNghi (string)
			if (QueryStrings.Any(d => d.Key == "TapChiHoiNghi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TapChiHoiNghi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TapChiHoiNghi").Value;
                query = query.Where(d=>d.TapChiHoiNghi == keyword);
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

		public static DTO_PRO_BaoCaoNangSuatKhoaHoc get_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, int ID, DTO_PRO_BaoCaoNangSuatKhoaHoc item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDNhom = item.IDNhom;							
				dbitem.IDSite = item.IDSite;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.NgayBaoCao = item.NgayBaoCao;							
				dbitem.TapChiHoiNghi = item.TapChiHoiNghi;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNangSuatKhoaHoc", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_BaoCaoNangSuatKhoaHoc",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_BaoCaoNangSuatKhoaHoc post_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, DTO_PRO_BaoCaoNangSuatKhoaHoc item, string Username)
        {
            tbl_PRO_BaoCaoNangSuatKhoaHoc dbitem = new tbl_PRO_BaoCaoNangSuatKhoaHoc();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.IDNhom = item.IDNhom;							
				dbitem.IDSite = item.IDSite;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.NgayBaoCao = item.NgayBaoCao;							
				dbitem.TapChiHoiNghi = item.TapChiHoiNghi;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNangSuatKhoaHoc", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_BaoCaoNangSuatKhoaHoc",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_BaoCaoNangSuatKhoaHoc(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNangSuatKhoaHoc", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_BaoCaoNangSuatKhoaHoc",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_BaoCaoNangSuatKhoaHoc_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Any(e => e.ID == id);
		}
		
    }

}






