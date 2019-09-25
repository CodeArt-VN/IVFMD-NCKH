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
    
    
    public partial class tbl_PROD_SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PROD_SanPham()
        {
            this.tbl_PAR_DonHang_ChiTiet = new HashSet<tbl_PAR_DonHang_ChiTiet>();
            this.tbl_PAR_ThongTinSanPham = new HashSet<tbl_PAR_ThongTinSanPham>();
            this.tbl_PROD_SanPham_ChiTiet = new HashSet<tbl_PROD_SanPham_ChiTiet>();
        }
    
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
        public string Keywords { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public string Video { get; set; }
        public string URLBaiViet { get; set; }
        public string PhienBan { get; set; }
        public string ReleaseNotes { get; set; }
        public string BrowserRequirements { get; set; }
        public string AvailableOnDevice { get; set; }
        public string SoftwareHelpURL { get; set; }
        public bool DaDuyet { get; set; }
        public Nullable<decimal> ThoiHanSuDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PAR_DonHang_ChiTiet> tbl_PAR_DonHang_ChiTiet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PAR_ThongTinSanPham> tbl_PAR_ThongTinSanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PROD_SanPham_ChiTiet> tbl_PROD_SanPham_ChiTiet { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PROD_SanPham
	{
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
		public string Keywords { get; set; }
		public string Image { get; set; }
		public string Thumbnail { get; set; }
		public string Video { get; set; }
		public string URLBaiViet { get; set; }
		public string PhienBan { get; set; }
		public string ReleaseNotes { get; set; }
		public string BrowserRequirements { get; set; }
		public string AvailableOnDevice { get; set; }
		public string SoftwareHelpURL { get; set; }
		public bool DaDuyet { get; set; }
		public Nullable<decimal> ThoiHanSuDung { get; set; }
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

    public static partial class BS_PROD_SanPham 
    {
		public static IQueryable<DTO_PROD_SanPham> toDTO(IQueryable<tbl_PROD_SanPham> query)
        {
			return query
			.Select(s => new DTO_PROD_SanPham(){							
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
				Keywords = s.Keywords,							
				Image = s.Image,							
				Thumbnail = s.Thumbnail,							
				Video = s.Video,							
				URLBaiViet = s.URLBaiViet,							
				PhienBan = s.PhienBan,							
				ReleaseNotes = s.ReleaseNotes,							
				BrowserRequirements = s.BrowserRequirements,							
				AvailableOnDevice = s.AvailableOnDevice,							
				SoftwareHelpURL = s.SoftwareHelpURL,							
				DaDuyet = s.DaDuyet,							
				ThoiHanSuDung = s.ThoiHanSuDung,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_PROD_SanPham toDTO(tbl_PROD_SanPham dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PROD_SanPham()
				{							
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
					Keywords = dbResult.Keywords,							
					Image = dbResult.Image,							
					Thumbnail = dbResult.Thumbnail,							
					Video = dbResult.Video,							
					URLBaiViet = dbResult.URLBaiViet,							
					PhienBan = dbResult.PhienBan,							
					ReleaseNotes = dbResult.ReleaseNotes,							
					BrowserRequirements = dbResult.BrowserRequirements,							
					AvailableOnDevice = dbResult.AvailableOnDevice,							
					SoftwareHelpURL = dbResult.SoftwareHelpURL,							
					DaDuyet = dbResult.DaDuyet,							
					ThoiHanSuDung = dbResult.ThoiHanSuDung,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PROD_SanPham> get_PROD_SanPham(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PROD_SanPham.Where(d => d.IsDeleted == false );

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
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

			//Query Keywords (string)
			if (QueryStrings.Any(d => d.Key == "Keywords") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywords").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywords").Value;
                query = query.Where(d=>d.Keywords == keyword);
            }

			//Query Image (string)
			if (QueryStrings.Any(d => d.Key == "Image") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Image").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Image").Value;
                query = query.Where(d=>d.Image == keyword);
            }

			//Query Thumbnail (string)
			if (QueryStrings.Any(d => d.Key == "Thumbnail") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Thumbnail").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Thumbnail").Value;
                query = query.Where(d=>d.Thumbnail == keyword);
            }

			//Query Video (string)
			if (QueryStrings.Any(d => d.Key == "Video") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Video").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Video").Value;
                query = query.Where(d=>d.Video == keyword);
            }

			//Query URLBaiViet (string)
			if (QueryStrings.Any(d => d.Key == "URLBaiViet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "URLBaiViet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "URLBaiViet").Value;
                query = query.Where(d=>d.URLBaiViet == keyword);
            }

			//Query PhienBan (string)
			if (QueryStrings.Any(d => d.Key == "PhienBan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhienBan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhienBan").Value;
                query = query.Where(d=>d.PhienBan == keyword);
            }

			//Query ReleaseNotes (string)
			if (QueryStrings.Any(d => d.Key == "ReleaseNotes") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ReleaseNotes").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ReleaseNotes").Value;
                query = query.Where(d=>d.ReleaseNotes == keyword);
            }

			//Query BrowserRequirements (string)
			if (QueryStrings.Any(d => d.Key == "BrowserRequirements") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BrowserRequirements").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BrowserRequirements").Value;
                query = query.Where(d=>d.BrowserRequirements == keyword);
            }

			//Query AvailableOnDevice (string)
			if (QueryStrings.Any(d => d.Key == "AvailableOnDevice") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "AvailableOnDevice").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "AvailableOnDevice").Value;
                query = query.Where(d=>d.AvailableOnDevice == keyword);
            }

			//Query SoftwareHelpURL (string)
			if (QueryStrings.Any(d => d.Key == "SoftwareHelpURL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoftwareHelpURL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoftwareHelpURL").Value;
                query = query.Where(d=>d.SoftwareHelpURL == keyword);
            }

			//Query DaDuyet (bool)
			if (QueryStrings.Any(d => d.Key == "DaDuyet"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DaDuyet").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DaDuyet);
            }

			//Query ThoiHanSuDung (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "ThoiHanSuDungFrom") && QueryStrings.Any(d => d.Key == "ThoiHanSuDungTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiHanSuDungFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiHanSuDungTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.ThoiHanSuDung && d.ThoiHanSuDung <= toVal);


			return toDTO(query);

        }

		public static DTO_PROD_SanPham get_PROD_SanPham(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PROD_SanPham.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_PROD_SanPham get_PROD_SanPham(AppEntities db, int PartnerID, string code)
        {
            var dbResult = db.tbl_PROD_SanPham.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_PROD_SanPham(AppEntities db, int PartnerID, int ID, DTO_PROD_SanPham item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PROD_SanPham.Find(ID);
            if (dbitem != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Keywords = item.Keywords;							
				dbitem.Image = item.Image;							
				dbitem.Thumbnail = item.Thumbnail;							
				dbitem.Video = item.Video;							
				dbitem.URLBaiViet = item.URLBaiViet;							
				dbitem.PhienBan = item.PhienBan;							
				dbitem.ReleaseNotes = item.ReleaseNotes;							
				dbitem.BrowserRequirements = item.BrowserRequirements;							
				dbitem.AvailableOnDevice = item.AvailableOnDevice;							
				dbitem.SoftwareHelpURL = item.SoftwareHelpURL;							
				dbitem.DaDuyet = item.DaDuyet;							
				dbitem.ThoiHanSuDung = item.ThoiHanSuDung;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PROD_SanPham", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PROD_SanPham",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PROD_SanPham post_PROD_SanPham(AppEntities db, int PartnerID, DTO_PROD_SanPham item, string Username)
        {
            tbl_PROD_SanPham dbitem = new tbl_PROD_SanPham();
            if (item != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Keywords = item.Keywords;							
				dbitem.Image = item.Image;							
				dbitem.Thumbnail = item.Thumbnail;							
				dbitem.Video = item.Video;							
				dbitem.URLBaiViet = item.URLBaiViet;							
				dbitem.PhienBan = item.PhienBan;							
				dbitem.ReleaseNotes = item.ReleaseNotes;							
				dbitem.BrowserRequirements = item.BrowserRequirements;							
				dbitem.AvailableOnDevice = item.AvailableOnDevice;							
				dbitem.SoftwareHelpURL = item.SoftwareHelpURL;							
				dbitem.DaDuyet = item.DaDuyet;							
				dbitem.ThoiHanSuDung = item.ThoiHanSuDung;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PROD_SanPham.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PROD_SanPham", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PROD_SanPham",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PROD_SanPham(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PROD_SanPham.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PROD_SanPham", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PROD_SanPham",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PROD_SanPham_Exists(AppEntities db, int id)
		{
			return db.tbl_PROD_SanPham.Any(e => e.ID == id);
		}
		
		public static bool check_PROD_SanPham_Exists(AppEntities db, string Code)
		{
			return db.tbl_PROD_SanPham.Any(e => e.Code == Code);
		}
		
    }

}






