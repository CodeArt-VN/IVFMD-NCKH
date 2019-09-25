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
    
    
    public partial class tbl_PAR_Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PAR_Partner()
        {
            this.tbl_CUS_DOC_File = new HashSet<tbl_CUS_DOC_File>();
            this.tbl_CUS_DOC_Folder = new HashSet<tbl_CUS_DOC_Folder>();
            this.tbl_CUS_HRM_LIST_BoPhan = new HashSet<tbl_CUS_HRM_LIST_BoPhan>();
            this.tbl_CUS_HRM_LIST_ChucDanh = new HashSet<tbl_CUS_HRM_LIST_ChucDanh>();
            this.tbl_CUS_SYS_CauHinhHeThong = new HashSet<tbl_CUS_SYS_CauHinhHeThong>();
            this.tbl_CUS_SYS_Role = new HashSet<tbl_CUS_SYS_Role>();
            this.tbl_CUS_Version = new HashSet<tbl_CUS_Version>();
            this.tbl_PAR_DonHang = new HashSet<tbl_PAR_DonHang>();
            this.tbl_PAR_ThongTinSanPham = new HashSet<tbl_PAR_ThongTinSanPham>();
            this.tbl_CUS_HRM_STAFF_NhanSu = new HashSet<tbl_CUS_HRM_STAFF_NhanSu>();
        }
    
        public Nullable<int> IDTinhThanh { get; set; }
        public Nullable<int> IDQuanHuyen { get; set; }
        public Nullable<int> IDQuyMoDoanhThu { get; set; }
        public Nullable<int> IDQuyMoDoanhNghiep { get; set; }
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
        public string MaSoThue { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string SoDienThoaiCoDinh { get; set; }
        public string Fax { get; set; }
        public string DiaChi { get; set; }
        public string SanPhamDichVu { get; set; }
        public string TemplateHeader { get; set; }
        public string TemplateFooter { get; set; }
        public string TemplateConfig { get; set; }
        public string LogoURL { get; set; }
        public string BannerURL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_DOC_File> tbl_CUS_DOC_File { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_DOC_Folder> tbl_CUS_DOC_Folder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_HRM_LIST_BoPhan> tbl_CUS_HRM_LIST_BoPhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_HRM_LIST_ChucDanh> tbl_CUS_HRM_LIST_ChucDanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_SYS_CauHinhHeThong> tbl_CUS_SYS_CauHinhHeThong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_SYS_Role> tbl_CUS_SYS_Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_Version> tbl_CUS_Version { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PAR_DonHang> tbl_PAR_DonHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PAR_ThongTinSanPham> tbl_PAR_ThongTinSanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_HRM_STAFF_NhanSu> tbl_CUS_HRM_STAFF_NhanSu { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PAR_Partner
	{
		public Nullable<int> IDTinhThanh { get; set; }
		public Nullable<int> IDQuanHuyen { get; set; }
		public Nullable<int> IDQuyMoDoanhThu { get; set; }
		public Nullable<int> IDQuyMoDoanhNghiep { get; set; }
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
		public string MaSoThue { get; set; }
		public string Website { get; set; }
		public string Email { get; set; }
		public string SoDienThoai { get; set; }
		public string SoDienThoaiCoDinh { get; set; }
		public string Fax { get; set; }
		public string DiaChi { get; set; }
		public string SanPhamDichVu { get; set; }
		public string TemplateHeader { get; set; }
		public string TemplateFooter { get; set; }
		public string TemplateConfig { get; set; }
		public string LogoURL { get; set; }
		public string BannerURL { get; set; }
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

    public static partial class BS_PAR_Partner 
    {
		public static IQueryable<DTO_PAR_Partner> toDTO(IQueryable<tbl_PAR_Partner> query)
        {
			return query
			.Select(s => new DTO_PAR_Partner(){							
				IDTinhThanh = s.IDTinhThanh,							
				IDQuanHuyen = s.IDQuanHuyen,							
				IDQuyMoDoanhThu = s.IDQuyMoDoanhThu,							
				IDQuyMoDoanhNghiep = s.IDQuyMoDoanhNghiep,							
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
				MaSoThue = s.MaSoThue,							
				Website = s.Website,							
				Email = s.Email,							
				SoDienThoai = s.SoDienThoai,							
				SoDienThoaiCoDinh = s.SoDienThoaiCoDinh,							
				Fax = s.Fax,							
				DiaChi = s.DiaChi,							
				SanPhamDichVu = s.SanPhamDichVu,							
				TemplateHeader = s.TemplateHeader,							
				TemplateFooter = s.TemplateFooter,							
				TemplateConfig = s.TemplateConfig,							
				LogoURL = s.LogoURL,							
				BannerURL = s.BannerURL,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_PAR_Partner toDTO(tbl_PAR_Partner dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PAR_Partner()
				{							
					IDTinhThanh = dbResult.IDTinhThanh,							
					IDQuanHuyen = dbResult.IDQuanHuyen,							
					IDQuyMoDoanhThu = dbResult.IDQuyMoDoanhThu,							
					IDQuyMoDoanhNghiep = dbResult.IDQuyMoDoanhNghiep,							
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
					MaSoThue = dbResult.MaSoThue,							
					Website = dbResult.Website,							
					Email = dbResult.Email,							
					SoDienThoai = dbResult.SoDienThoai,							
					SoDienThoaiCoDinh = dbResult.SoDienThoaiCoDinh,							
					Fax = dbResult.Fax,							
					DiaChi = dbResult.DiaChi,							
					SanPhamDichVu = dbResult.SanPhamDichVu,							
					TemplateHeader = dbResult.TemplateHeader,							
					TemplateFooter = dbResult.TemplateFooter,							
					TemplateConfig = dbResult.TemplateConfig,							
					LogoURL = dbResult.LogoURL,							
					BannerURL = dbResult.BannerURL,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PAR_Partner> get_PAR_Partner(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PAR_Partner.Where(d => d.IsDeleted == false );

			//Query keyword
			if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d=>d.Name.Contains(keyword) || d.Code.Contains(keyword));
            }



			//Query IDTinhThanh (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDTinhThanh"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTinhThanh").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTinhThanh));
            }

			//Query IDQuanHuyen (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDQuanHuyen"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDQuanHuyen").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDQuanHuyen));
            }

			//Query IDQuyMoDoanhThu (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDQuyMoDoanhThu"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDQuyMoDoanhThu").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDQuyMoDoanhThu));
            }

			//Query IDQuyMoDoanhNghiep (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDQuyMoDoanhNghiep"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDQuyMoDoanhNghiep").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDQuyMoDoanhNghiep));
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

			//Query MaSoThue (string)
			if (QueryStrings.Any(d => d.Key == "MaSoThue") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSoThue").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSoThue").Value;
                query = query.Where(d=>d.MaSoThue == keyword);
            }

			//Query Website (string)
			if (QueryStrings.Any(d => d.Key == "Website") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Website").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Website").Value;
                query = query.Where(d=>d.Website == keyword);
            }

			//Query Email (string)
			if (QueryStrings.Any(d => d.Key == "Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Email").Value;
                query = query.Where(d=>d.Email == keyword);
            }

			//Query SoDienThoai (string)
			if (QueryStrings.Any(d => d.Key == "SoDienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoai").Value;
                query = query.Where(d=>d.SoDienThoai == keyword);
            }

			//Query SoDienThoaiCoDinh (string)
			if (QueryStrings.Any(d => d.Key == "SoDienThoaiCoDinh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoaiCoDinh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoDienThoaiCoDinh").Value;
                query = query.Where(d=>d.SoDienThoaiCoDinh == keyword);
            }

			//Query Fax (string)
			if (QueryStrings.Any(d => d.Key == "Fax") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Fax").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Fax").Value;
                query = query.Where(d=>d.Fax == keyword);
            }

			//Query DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value;
                query = query.Where(d=>d.DiaChi == keyword);
            }

			//Query SanPhamDichVu (string)
			if (QueryStrings.Any(d => d.Key == "SanPhamDichVu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SanPhamDichVu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SanPhamDichVu").Value;
                query = query.Where(d=>d.SanPhamDichVu == keyword);
            }

			//Query TemplateHeader (string)
			if (QueryStrings.Any(d => d.Key == "TemplateHeader") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TemplateHeader").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TemplateHeader").Value;
                query = query.Where(d=>d.TemplateHeader == keyword);
            }

			//Query TemplateFooter (string)
			if (QueryStrings.Any(d => d.Key == "TemplateFooter") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TemplateFooter").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TemplateFooter").Value;
                query = query.Where(d=>d.TemplateFooter == keyword);
            }

			//Query TemplateConfig (string)
			if (QueryStrings.Any(d => d.Key == "TemplateConfig") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TemplateConfig").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TemplateConfig").Value;
                query = query.Where(d=>d.TemplateConfig == keyword);
            }

			//Query LogoURL (string)
			if (QueryStrings.Any(d => d.Key == "LogoURL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LogoURL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LogoURL").Value;
                query = query.Where(d=>d.LogoURL == keyword);
            }

			//Query BannerURL (string)
			if (QueryStrings.Any(d => d.Key == "BannerURL") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BannerURL").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BannerURL").Value;
                query = query.Where(d=>d.BannerURL == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PAR_Partner get_PAR_Partner(AppEntities db, int id)
        {
            var dbResult = db.tbl_PAR_Partner.Find(id);

			return toDTO(dbResult);
			
        }
		
		public static DTO_PAR_Partner get_PAR_Partner(AppEntities db, string code)
        {
            var dbResult = db.tbl_PAR_Partner.FirstOrDefault(d => d.IsDeleted == false && d.Code == code );
			return toDTO(dbResult);
			
        }

		public static bool put_PAR_Partner(AppEntities db, int ID, DTO_PAR_Partner item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PAR_Partner.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDTinhThanh = item.IDTinhThanh;							
				dbitem.IDQuanHuyen = item.IDQuanHuyen;							
				dbitem.IDQuyMoDoanhThu = item.IDQuyMoDoanhThu;							
				dbitem.IDQuyMoDoanhNghiep = item.IDQuyMoDoanhNghiep;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.MaSoThue = item.MaSoThue;							
				dbitem.Website = item.Website;							
				dbitem.Email = item.Email;							
				dbitem.SoDienThoai = item.SoDienThoai;							
				dbitem.SoDienThoaiCoDinh = item.SoDienThoaiCoDinh;							
				dbitem.Fax = item.Fax;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.SanPhamDichVu = item.SanPhamDichVu;							
				dbitem.TemplateHeader = item.TemplateHeader;							
				dbitem.TemplateFooter = item.TemplateFooter;							
				dbitem.TemplateConfig = item.TemplateConfig;							
				dbitem.LogoURL = item.LogoURL;							
				dbitem.BannerURL = item.BannerURL;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PAR_Partner", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PAR_Partner",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PAR_Partner post_PAR_Partner(AppEntities db, DTO_PAR_Partner item, string Username)
        {
            tbl_PAR_Partner dbitem = new tbl_PAR_Partner();
            if (item != null)
            {							
				dbitem.IDTinhThanh = item.IDTinhThanh;							
				dbitem.IDQuanHuyen = item.IDQuanHuyen;							
				dbitem.IDQuyMoDoanhThu = item.IDQuyMoDoanhThu;							
				dbitem.IDQuyMoDoanhNghiep = item.IDQuyMoDoanhNghiep;							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.MaSoThue = item.MaSoThue;							
				dbitem.Website = item.Website;							
				dbitem.Email = item.Email;							
				dbitem.SoDienThoai = item.SoDienThoai;							
				dbitem.SoDienThoaiCoDinh = item.SoDienThoaiCoDinh;							
				dbitem.Fax = item.Fax;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.SanPhamDichVu = item.SanPhamDichVu;							
				dbitem.TemplateHeader = item.TemplateHeader;							
				dbitem.TemplateFooter = item.TemplateFooter;							
				dbitem.TemplateConfig = item.TemplateConfig;							
				dbitem.LogoURL = item.LogoURL;							
				dbitem.BannerURL = item.BannerURL;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PAR_Partner.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PAR_Partner", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PAR_Partner",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PAR_Partner(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PAR_Partner.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PAR_Partner", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PAR_Partner",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PAR_Partner_Exists(AppEntities db, int id)
		{
			return db.tbl_PAR_Partner.Any(e => e.ID == id);
		}
		
		public static bool check_PAR_Partner_Exists(AppEntities db, string Code)
		{
			return db.tbl_PAR_Partner.Any(e => e.Code == Code);
		}
		
    }

}






