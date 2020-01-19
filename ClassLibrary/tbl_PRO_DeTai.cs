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
    
    
    public partial class tbl_PRO_DeTai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PRO_DeTai()
        {
            this.tbl_PRO_AE = new HashSet<tbl_PRO_AE>();
            this.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD = new HashSet<tbl_PRO_BangKiemLuaChonQuyTrinhXXDD>();
            this.tbl_PRO_BenhNhan = new HashSet<tbl_PRO_BenhNhan>();
            this.tbl_PRO_DonXinDanhGiaDaoDuc = new HashSet<tbl_PRO_DonXinDanhGiaDaoDuc>();
            this.tbl_PRO_DonXinNghiemThu = new HashSet<tbl_PRO_DonXinNghiemThu>();
            this.tbl_PRO_DonXinXetDuyet = new HashSet<tbl_PRO_DonXinXetDuyet>();
            this.tbl_PRO_LLKH = new HashSet<tbl_PRO_LLKH>();
            this.tbl_PRO_MauPhanTichDuLieu = new HashSet<tbl_PRO_MauPhanTichDuLieu>();
            this.tbl_PRO_NCVKhac = new HashSet<tbl_PRO_NCVKhac>();
            this.tbl_PRO_PhieuXemXetDaoDuc = new HashSet<tbl_PRO_PhieuXemXetDaoDuc>();
            this.tbl_PRO_SAE = new HashSet<tbl_PRO_SAE>();
            this.tbl_PRO_SYLL = new HashSet<tbl_PRO_SYLL>();
            this.tbl_PRO_Sysnopsis = new HashSet<tbl_PRO_Sysnopsis>();
            this.tbl_PRO_Tags = new HashSet<tbl_PRO_Tags>();
            this.tbl_PRO_ThuyetMinhDeTai = new HashSet<tbl_PRO_ThuyetMinhDeTai>();
            this.tbl_PRO_TrangThai_Log = new HashSet<tbl_PRO_TrangThai_Log>();
            this.tbl_PRO_HRCO = new HashSet<tbl_PRO_HRCO>();
            this.tbl_PRO_BaoCaoTienDoNghienCuu = new HashSet<tbl_PRO_BaoCaoTienDoNghienCuu>();
            this.tbl_PRO_BaoCaoNghiemThuDeTai = new HashSet<tbl_PRO_BaoCaoNghiemThuDeTai>();
        }
    
        public int ID { get; set; }
        public int IDPartner { get; set; }
        public int IDNCV { get; set; }
        public Nullable<int> IDChuNhiem { get; set; }
        public Nullable<int> IDHRCO { get; set; }
        public int IDPhanLoaiDeTai { get; set; }
        public int IDTrangThai_HDDD { get; set; }
        public int IDTrangThai_HDKH { get; set; }
        public int IDTrangThai_HRCO { get; set; }
        public int IDTrangThai_NghiemThu { get; set; }
        public string DeTai { get; set; }
        public string GhiChu { get; set; }
        public string SoNCT { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MaSo { get; set; }
        public string TenTiengViet { get; set; }
        public string TenTiengAnh { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_AE> tbl_PRO_AE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_BangKiemLuaChonQuyTrinhXXDD> tbl_PRO_BangKiemLuaChonQuyTrinhXXDD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_BenhNhan> tbl_PRO_BenhNhan { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var1 { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var2 { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var3 { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DonXinDanhGiaDaoDuc> tbl_PRO_DonXinDanhGiaDaoDuc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DonXinNghiemThu> tbl_PRO_DonXinNghiemThu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_DonXinXetDuyet> tbl_PRO_DonXinXetDuyet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_LLKH> tbl_PRO_LLKH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_MauPhanTichDuLieu> tbl_PRO_MauPhanTichDuLieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_NCVKhac> tbl_PRO_NCVKhac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_PhieuXemXetDaoDuc> tbl_PRO_PhieuXemXetDaoDuc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_SAE> tbl_PRO_SAE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_SYLL> tbl_PRO_SYLL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_Sysnopsis> tbl_PRO_Sysnopsis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_Tags> tbl_PRO_Tags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_ThuyetMinhDeTai> tbl_PRO_ThuyetMinhDeTai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_TrangThai_Log> tbl_PRO_TrangThai_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_HRCO> tbl_PRO_HRCO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_BaoCaoTienDoNghienCuu> tbl_PRO_BaoCaoTienDoNghienCuu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_BaoCaoNghiemThuDeTai> tbl_PRO_BaoCaoNghiemThuDeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_DeTai
	{
		public int ID { get; set; }
		public int IDPartner { get; set; }
		public int IDNCV { get; set; }
		public Nullable<int> IDChuNhiem { get; set; }
		public Nullable<int> IDHRCO { get; set; }
		public int IDPhanLoaiDeTai { get; set; }
		public int IDTrangThai_HDDD { get; set; }
		public int IDTrangThai_HDKH { get; set; }
		public int IDTrangThai_HRCO { get; set; }
		public int IDTrangThai_NghiemThu { get; set; }
		public string DeTai { get; set; }
		public string GhiChu { get; set; }
		public string SoNCT { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public string MaSo { get; set; }
		public string TenTiengViet { get; set; }
		public string TenTiengAnh { get; set; }
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

    public static partial class BS_PRO_DeTai 
    {
		public static IQueryable<DTO_PRO_DeTai> toDTO(IQueryable<tbl_PRO_DeTai> query)
        {
			return query
			.Select(s => new DTO_PRO_DeTai(){							
				ID = s.ID,							
				IDPartner = s.IDPartner,							
				IDNCV = s.IDNCV,							
				IDChuNhiem = s.IDChuNhiem,							
				IDHRCO = s.IDHRCO,							
				IDPhanLoaiDeTai = s.IDPhanLoaiDeTai,							
				IDTrangThai_HDDD = s.IDTrangThai_HDDD,							
				IDTrangThai_HDKH = s.IDTrangThai_HDKH,							
				IDTrangThai_HRCO = s.IDTrangThai_HRCO,							
				IDTrangThai_NghiemThu = s.IDTrangThai_NghiemThu,							
				DeTai = s.DeTai,							
				GhiChu = s.GhiChu,							
				SoNCT = s.SoNCT,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				MaSo = s.MaSo,							
				TenTiengViet = s.TenTiengViet,							
				TenTiengAnh = s.TenTiengAnh,					
			});
                              
        }

		public static DTO_PRO_DeTai toDTO(tbl_PRO_DeTai dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_DeTai()
				{							
					ID = dbResult.ID,							
					IDPartner = dbResult.IDPartner,							
					IDNCV = dbResult.IDNCV,							
					IDChuNhiem = dbResult.IDChuNhiem,							
					IDHRCO = dbResult.IDHRCO,							
					IDPhanLoaiDeTai = dbResult.IDPhanLoaiDeTai,							
					IDTrangThai_HDDD = dbResult.IDTrangThai_HDDD,							
					IDTrangThai_HDKH = dbResult.IDTrangThai_HDKH,							
					IDTrangThai_HRCO = dbResult.IDTrangThai_HRCO,							
					IDTrangThai_NghiemThu = dbResult.IDTrangThai_NghiemThu,							
					DeTai = dbResult.DeTai,							
					GhiChu = dbResult.GhiChu,							
					SoNCT = dbResult.SoNCT,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					MaSo = dbResult.MaSo,							
					TenTiengViet = dbResult.TenTiengViet,							
					TenTiengAnh = dbResult.TenTiengAnh,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_DeTai> get_PRO_DeTai(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_DeTai.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);

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

			//Query IDChuNhiem (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDChuNhiem"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDChuNhiem").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDChuNhiem));
            }

			//Query IDHRCO (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDHRCO"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHRCO").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHRCO));
            }

			//Query IDPhanLoaiDeTai (int)
			if (QueryStrings.Any(d => d.Key == "IDPhanLoaiDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPhanLoaiDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPhanLoaiDeTai));
            }

			//Query IDTrangThai_HDDD (int)
			if (QueryStrings.Any(d => d.Key == "IDTrangThai_HDDD"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HDDD").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HDDD));
            }

			//Query IDTrangThai_HDKH (int)
			if (QueryStrings.Any(d => d.Key == "IDTrangThai_HDKH"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HDKH").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HDKH));
            }

			//Query IDTrangThai_HRCO (int)
			if (QueryStrings.Any(d => d.Key == "IDTrangThai_HRCO"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HRCO").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HRCO));
            }

			//Query IDTrangThai_NghiemThu (int)
			if (QueryStrings.Any(d => d.Key == "IDTrangThai_NghiemThu"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_NghiemThu").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_NghiemThu));
            }

			//Query DeTai (string)
			if (QueryStrings.Any(d => d.Key == "DeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DeTai").Value;
                query = query.Where(d=>d.DeTai == keyword);
            }

			//Query GhiChu (string)
			if (QueryStrings.Any(d => d.Key == "GhiChu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value;
                query = query.Where(d=>d.GhiChu == keyword);
            }

			//Query SoNCT (string)
			if (QueryStrings.Any(d => d.Key == "SoNCT") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoNCT").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoNCT").Value;
                query = query.Where(d=>d.SoNCT == keyword);
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

			//Query MaSo (string)
			if (QueryStrings.Any(d => d.Key == "MaSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value;
                query = query.Where(d=>d.MaSo == keyword);
            }

			//Query TenTiengViet (string)
			if (QueryStrings.Any(d => d.Key == "TenTiengViet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenTiengViet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenTiengViet").Value;
                query = query.Where(d=>d.TenTiengViet == keyword);
            }

			//Query TenTiengAnh (string)
			if (QueryStrings.Any(d => d.Key == "TenTiengAnh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenTiengAnh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenTiengAnh").Value;
                query = query.Where(d=>d.TenTiengAnh == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_DeTai get_PRO_DeTai(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PRO_DeTai.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_DeTai(AppEntities db, int PartnerID, int ID, DTO_PRO_DeTai item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_DeTai.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDNCV = item.IDNCV;							
				dbitem.IDChuNhiem = item.IDChuNhiem;							
				dbitem.IDHRCO = item.IDHRCO;							
				dbitem.IDPhanLoaiDeTai = item.IDPhanLoaiDeTai;							
				dbitem.IDTrangThai_HDDD = item.IDTrangThai_HDDD;							
				dbitem.IDTrangThai_HDKH = item.IDTrangThai_HDKH;							
				dbitem.IDTrangThai_HRCO = item.IDTrangThai_HRCO;							
				dbitem.IDTrangThai_NghiemThu = item.IDTrangThai_NghiemThu;							
				dbitem.DeTai = item.DeTai;							
				dbitem.GhiChu = item.GhiChu;							
				dbitem.SoNCT = item.SoNCT;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.MaSo = item.MaSo;							
				dbitem.TenTiengViet = item.TenTiengViet;							
				dbitem.TenTiengAnh = item.TenTiengAnh;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PRO_DeTai", DateTime.Now, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_DeTai",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_DeTai post_PRO_DeTai(AppEntities db, int PartnerID, DTO_PRO_DeTai item, string Username)
        {
            tbl_PRO_DeTai dbitem = new tbl_PRO_DeTai();
            if (item != null)
            {							
				dbitem.IDNCV = item.IDNCV;							
				dbitem.IDChuNhiem = item.IDChuNhiem;							
				dbitem.IDHRCO = item.IDHRCO;							
				dbitem.IDPhanLoaiDeTai = item.IDPhanLoaiDeTai;							
				dbitem.IDTrangThai_HDDD = item.IDTrangThai_HDDD;							
				dbitem.IDTrangThai_HDKH = item.IDTrangThai_HDKH;							
				dbitem.IDTrangThai_HRCO = item.IDTrangThai_HRCO;							
				dbitem.IDTrangThai_NghiemThu = item.IDTrangThai_NghiemThu;							
				dbitem.DeTai = item.DeTai;							
				dbitem.GhiChu = item.GhiChu;							
				dbitem.SoNCT = item.SoNCT;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.MaSo = item.MaSo;							
				dbitem.TenTiengViet = item.TenTiengViet;							
				dbitem.TenTiengAnh = item.TenTiengAnh;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_PRO_DeTai.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PRO_DeTai", DateTime.Now, Username);
										
									
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_DeTai",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_DeTai(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_DeTai.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PRO_DeTai", DateTime.Now, Username);
										
				
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_DeTai",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_DeTai_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_DeTai.Any(e => e.ID == id);
		}
		
    }

}






