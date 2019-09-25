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
    
    
    public partial class tbl_PAR_ThongTinSanPham
    {
        public int IDPartner { get; set; }
        public int IDSanPham { get; set; }
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
        public System.DateTime NgayDangKy { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public Nullable<System.DateTime> NgayGiaHan { get; set; }
        public virtual tbl_PAR_Partner tbl_PAR_Partner { get; set; }
        public virtual tbl_PROD_SanPham tbl_PROD_SanPham { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PAR_ThongTinSanPham
	{
		public int IDPartner { get; set; }
		public int IDSanPham { get; set; }
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
		public System.DateTime NgayDangKy { get; set; }
		public Nullable<System.DateTime> NgayHetHan { get; set; }
		public Nullable<System.DateTime> NgayGiaHan { get; set; }
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

    public static partial class BS_PAR_ThongTinSanPham 
    {
		public static IQueryable<DTO_PAR_ThongTinSanPham> toDTO(IQueryable<tbl_PAR_ThongTinSanPham> query)
        {
			return query
			.Select(s => new DTO_PAR_ThongTinSanPham(){							
				IDPartner = s.IDPartner,							
				IDSanPham = s.IDSanPham,							
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
				NgayDangKy = s.NgayDangKy,							
				NgayHetHan = s.NgayHetHan,							
				NgayGiaHan = s.NgayGiaHan,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_PAR_ThongTinSanPham toDTO(tbl_PAR_ThongTinSanPham dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PAR_ThongTinSanPham()
				{							
					IDPartner = dbResult.IDPartner,							
					IDSanPham = dbResult.IDSanPham,							
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
					NgayDangKy = dbResult.NgayDangKy,							
					NgayHetHan = dbResult.NgayHetHan,							
					NgayGiaHan = dbResult.NgayGiaHan,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PAR_ThongTinSanPham> get_PAR_ThongTinSanPham(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PAR_ThongTinSanPham.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



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

			//Query IDSanPham (int)
			if (QueryStrings.Any(d => d.Key == "IDSanPham"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDSanPham").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDSanPham));
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

			//Query NgayDangKy (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "NgayDangKyFrom") && QueryStrings.Any(d => d.Key == "NgayDangKyTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDangKyFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayDangKyTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayDangKy && d.NgayDangKy <= toDate);

			//Query NgayHetHan (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "NgayHetHanFrom") && QueryStrings.Any(d => d.Key == "NgayHetHanTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHetHanFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayHetHanTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayHetHan && d.NgayHetHan <= toDate);

			//Query NgayGiaHan (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "NgayGiaHanFrom") && QueryStrings.Any(d => d.Key == "NgayGiaHanTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayGiaHanFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NgayGiaHanTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.NgayGiaHan && d.NgayGiaHan <= toDate);


			return toDTO(query);

        }

		public static DTO_PAR_ThongTinSanPham get_PAR_ThongTinSanPham(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PAR_ThongTinSanPham.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		
		public static DTO_PAR_ThongTinSanPham get_PAR_ThongTinSanPham(AppEntities db, int PartnerID, string code)
        {
            var dbResult = db.tbl_PAR_ThongTinSanPham.FirstOrDefault(d => d.IsDeleted == false && d.IDPartner == PartnerID && d.Code == code);
			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }

		public static bool put_PAR_ThongTinSanPham(AppEntities db, int PartnerID, int ID, DTO_PAR_ThongTinSanPham item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PAR_ThongTinSanPham.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDSanPham = item.IDSanPham;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayDangKy = item.NgayDangKy;							
				dbitem.NgayHetHan = item.NgayHetHan;							
				dbitem.NgayGiaHan = item.NgayGiaHan;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PAR_ThongTinSanPham", dbitem.ModifiedDate, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PAR_ThongTinSanPham",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PAR_ThongTinSanPham post_PAR_ThongTinSanPham(AppEntities db, int PartnerID, DTO_PAR_ThongTinSanPham item, string Username)
        {
            tbl_PAR_ThongTinSanPham dbitem = new tbl_PAR_ThongTinSanPham();
            if (item != null)
            {							
				dbitem.IDSanPham = item.IDSanPham;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.NgayDangKy = item.NgayDangKy;							
				dbitem.NgayHetHan = item.NgayHetHan;							
				dbitem.NgayGiaHan = item.NgayGiaHan;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_PAR_ThongTinSanPham.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PAR_ThongTinSanPham", dbitem.ModifiedDate, Username);
										
									
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PAR_ThongTinSanPham",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PAR_ThongTinSanPham(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PAR_ThongTinSanPham.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PAR_ThongTinSanPham", dbitem.ModifiedDate, Username);
										
				
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PAR_ThongTinSanPham",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PAR_ThongTinSanPham_Exists(AppEntities db, int id)
		{
			return db.tbl_PAR_ThongTinSanPham.Any(e => e.ID == id);
		}
		
		public static bool check_PAR_ThongTinSanPham_Exists(AppEntities db, string Code)
		{
			return db.tbl_PAR_ThongTinSanPham.Any(e => e.Code == Code);
		}
		
    }

}






