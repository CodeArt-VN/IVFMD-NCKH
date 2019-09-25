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
    
    
    public partial class tbl_WEB_DanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_WEB_DanhMuc()
        {
            this.tbl_WEB_BaiViet = new HashSet<tbl_WEB_BaiViet>();
            this.tbl_WEB_DanhMuc1 = new HashSet<tbl_WEB_DanhMuc>();
        }
    
        public Nullable<int> IDParent { get; set; }
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
        public string ThumbnailImage { get; set; }
        public bool Duyet { get; set; }
        public string NgonNgu { get; set; }
        public string Summary { get; set; }
        public string URL { get; set; }
        public string SEO1 { get; set; }
        public string SEO2 { get; set; }
        public bool IsBuildIn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WEB_BaiViet> tbl_WEB_BaiViet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WEB_DanhMuc> tbl_WEB_DanhMuc1 { get; set; }
        public virtual tbl_WEB_DanhMuc tbl_WEB_DanhMuc2 { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_WEB_DanhMuc
	{
		public Nullable<int> IDParent { get; set; }
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
		public string ThumbnailImage { get; set; }
		public bool Duyet { get; set; }
		public string NgonNgu { get; set; }
		public string Summary { get; set; }
		public string URL { get; set; }
		public string SEO1 { get; set; }
		public string SEO2 { get; set; }
		public bool IsBuildIn { get; set; }
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

    public static partial class BS_WEB_DanhMuc 
    {
		public static IQueryable<DTO_WEB_DanhMuc> toDTO(IQueryable<tbl_WEB_DanhMuc> query)
        {
			return query
			.Select(s => new DTO_WEB_DanhMuc(){							
				IDParent = s.IDParent,							
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
				ThumbnailImage = s.ThumbnailImage,							
				Duyet = s.Duyet,							
				NgonNgu = s.NgonNgu,							
				Summary = s.Summary,							
				URL = s.URL,							
				SEO1 = s.SEO1,							
				SEO2 = s.SEO2,							
				IsBuildIn = s.IsBuildIn,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_WEB_DanhMuc toDTO(tbl_WEB_DanhMuc dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_WEB_DanhMuc()
				{							
					IDParent = dbResult.IDParent,							
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
					ThumbnailImage = dbResult.ThumbnailImage,							
					Duyet = dbResult.Duyet,							
					NgonNgu = dbResult.NgonNgu,							
					Summary = dbResult.Summary,							
					URL = dbResult.URL,							
					SEO1 = dbResult.SEO1,							
					SEO2 = dbResult.SEO2,							
					IsBuildIn = dbResult.IsBuildIn,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_WEB_DanhMuc> get_WEB_DanhMuc(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_WEB_DanhMuc.Where(d => d.IsDeleted == false );

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



			//Query IDParent (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDParent"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDParent").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDParent));
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

			//Query ThumbnailImage (string)
			if (QueryStrings.Any(d => d.Key == "ThumbnailImage") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThumbnailImage").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThumbnailImage").Value;
                query = query.Where(d=>d.ThumbnailImage == keyword);
            }

			//Query Duyet (bool)
			if (QueryStrings.Any(d => d.Key == "Duyet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "Duyet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.Duyet);
            }

			//Query NgonNgu (string)
			if (QueryStrings.Any(d => d.Key == "NgonNgu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NgonNgu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NgonNgu").Value;
                query = query.Where(d=>d.NgonNgu == keyword);
            }

			//Query Summary (string)
			if (QueryStrings.Any(d => d.Key == "Summary") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Summary").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Summary").Value;
                query = query.Where(d=>d.Summary == keyword);
            }

			//Query URL (string)
			if (QueryStrings.Any(d => d.Key == "URL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "URL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "URL").Value;
                query = query.Where(d=>d.URL == keyword);
            }

			//Query SEO1 (string)
			if (QueryStrings.Any(d => d.Key == "SEO1") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SEO1").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SEO1").Value;
                query = query.Where(d=>d.SEO1 == keyword);
            }

			//Query SEO2 (string)
			if (QueryStrings.Any(d => d.Key == "SEO2") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SEO2").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SEO2").Value;
                query = query.Where(d=>d.SEO2 == keyword);
            }

			//Query IsBuildIn (bool)
			if (QueryStrings.Any(d => d.Key == "IsBuildIn"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsBuildIn").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsBuildIn);
            }


			return toDTO(query);

        }

		public static DTO_WEB_DanhMuc get_WEB_DanhMuc(AppEntities db, int id)
        {
            var dbResult = db.tbl_WEB_DanhMuc.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_WEB_DanhMuc get_WEB_DanhMuc(AppEntities db, string code)
        {
            var dbResult = db.tbl_WEB_DanhMuc.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_WEB_DanhMuc(AppEntities db, int ID, DTO_WEB_DanhMuc item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_WEB_DanhMuc.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDParent = item.IDParent;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.ThumbnailImage = item.ThumbnailImage;							
				dbitem.Duyet = item.Duyet;							
				dbitem.NgonNgu = item.NgonNgu;							
				dbitem.Summary = item.Summary;							
				dbitem.URL = item.URL;							
				dbitem.SEO1 = item.SEO1;							
				dbitem.SEO2 = item.SEO2;							
				dbitem.IsBuildIn = item.IsBuildIn;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_DanhMuc", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_WEB_DanhMuc",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_WEB_DanhMuc post_WEB_DanhMuc(AppEntities db, DTO_WEB_DanhMuc item, string Username)
        {
            tbl_WEB_DanhMuc dbitem = new tbl_WEB_DanhMuc();
            if (item != null)
            {							
				dbitem.IDParent = item.IDParent;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.ThumbnailImage = item.ThumbnailImage;							
				dbitem.Duyet = item.Duyet;							
				dbitem.NgonNgu = item.NgonNgu;							
				dbitem.Summary = item.Summary;							
				dbitem.URL = item.URL;							
				dbitem.SEO1 = item.SEO1;							
				dbitem.SEO2 = item.SEO2;							
				dbitem.IsBuildIn = item.IsBuildIn;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_WEB_DanhMuc.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_DanhMuc", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_WEB_DanhMuc",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_WEB_DanhMuc(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_WEB_DanhMuc.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_WEB_DanhMuc", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_WEB_DanhMuc",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_WEB_DanhMuc_Exists(AppEntities db, int id)
		{
			return db.tbl_WEB_DanhMuc.Any(e => e.ID == id);
		}
		
		public static bool check_WEB_DanhMuc_Exists(AppEntities db, string Code)
		{
			return db.tbl_WEB_DanhMuc.Any(e => e.Code == Code);
		}
		
    }

}






