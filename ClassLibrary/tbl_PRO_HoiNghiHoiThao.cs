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
    
    
    public partial class tbl_PRO_HoiNghiHoiThao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PRO_HoiNghiHoiThao()
        {
            this.tbl_PRO_HoiNghiHoiThao_DangKy = new HashSet<tbl_PRO_HoiNghiHoiThao_DangKy>();
            this.tbl_PRO_HoiNghiHoiThao_DangKyDeTai = new HashSet<tbl_PRO_HoiNghiHoiThao_DangKyDeTai>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IDNhanVien { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public string DiaDiem { get; set; }
        public string TenHoiNghi { get; set; }
        public string CVBaoCaoVien { get; set; }
        public string BaiAbstract { get; set; }
        public string BaiFulltext { get; set; }
        public string HTMLHosrem { get; set; }
        public int IDTrangThai { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ThoiGianHetHan { get; set; }
        public virtual tbl_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_HoiNghiHoiThao_DangKy> tbl_PRO_HoiNghiHoiThao_DangKy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRO_HoiNghiHoiThao_DangKyDeTai> tbl_PRO_HoiNghiHoiThao_DangKyDeTai { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_HoiNghiHoiThao
	{
		public int ID { get; set; }
		public Nullable<int> IDNhanVien { get; set; }
		public Nullable<System.DateTime> ThoiGian { get; set; }
		public string DiaDiem { get; set; }
		public string TenHoiNghi { get; set; }
		public string CVBaoCaoVien { get; set; }
		public string BaiAbstract { get; set; }
		public string BaiFulltext { get; set; }
		public string HTMLHosrem { get; set; }
		public int IDTrangThai { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public Nullable<System.DateTime> ThoiGianHetHan { get; set; }
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

    public static partial class BS_PRO_HoiNghiHoiThao 
    {
		public static IQueryable<DTO_PRO_HoiNghiHoiThao> toDTO(IQueryable<tbl_PRO_HoiNghiHoiThao> query)
        {
			return query
			.Select(s => new DTO_PRO_HoiNghiHoiThao(){							
				ID = s.ID,							
				IDNhanVien = s.IDNhanVien,							
				ThoiGian = s.ThoiGian,							
				DiaDiem = s.DiaDiem,							
				TenHoiNghi = s.TenHoiNghi,							
				CVBaoCaoVien = s.CVBaoCaoVien,							
				BaiAbstract = s.BaiAbstract,							
				BaiFulltext = s.BaiFulltext,							
				HTMLHosrem = s.HTMLHosrem,							
				IDTrangThai = s.IDTrangThai,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				ThoiGianHetHan = s.ThoiGianHetHan,					
			});
                              
        }

		public static DTO_PRO_HoiNghiHoiThao toDTO(tbl_PRO_HoiNghiHoiThao dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_HoiNghiHoiThao()
				{							
					ID = dbResult.ID,							
					IDNhanVien = dbResult.IDNhanVien,							
					ThoiGian = dbResult.ThoiGian,							
					DiaDiem = dbResult.DiaDiem,							
					TenHoiNghi = dbResult.TenHoiNghi,							
					CVBaoCaoVien = dbResult.CVBaoCaoVien,							
					BaiAbstract = dbResult.BaiAbstract,							
					BaiFulltext = dbResult.BaiFulltext,							
					HTMLHosrem = dbResult.HTMLHosrem,							
					IDTrangThai = dbResult.IDTrangThai,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					ThoiGianHetHan = dbResult.ThoiGianHetHan,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao> get_PRO_HoiNghiHoiThao(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_HoiNghiHoiThao.Where(d => d.IsDeleted == false );

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

			//Query IDNhanVien (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDNhanVien"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNhanVien").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNhanVien));
            }

			//Query ThoiGian (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "ThoiGianFrom") && QueryStrings.Any(d => d.Key == "ThoiGianTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ThoiGian && d.ThoiGian <= toDate);

			//Query DiaDiem (string)
			if (QueryStrings.Any(d => d.Key == "DiaDiem") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaDiem").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaDiem").Value;
                query = query.Where(d=>d.DiaDiem == keyword);
            }

			//Query TenHoiNghi (string)
			if (QueryStrings.Any(d => d.Key == "TenHoiNghi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenHoiNghi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenHoiNghi").Value;
                query = query.Where(d=>d.TenHoiNghi == keyword);
            }

			//Query CVBaoCaoVien (string)
			if (QueryStrings.Any(d => d.Key == "CVBaoCaoVien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CVBaoCaoVien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CVBaoCaoVien").Value;
                query = query.Where(d=>d.CVBaoCaoVien == keyword);
            }

			//Query BaiAbstract (string)
			if (QueryStrings.Any(d => d.Key == "BaiAbstract") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BaiAbstract").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BaiAbstract").Value;
                query = query.Where(d=>d.BaiAbstract == keyword);
            }

			//Query BaiFulltext (string)
			if (QueryStrings.Any(d => d.Key == "BaiFulltext") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value;
                query = query.Where(d=>d.BaiFulltext == keyword);
            }

			//Query HTMLHosrem (string)
			if (QueryStrings.Any(d => d.Key == "HTMLHosrem") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HTMLHosrem").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HTMLHosrem").Value;
                query = query.Where(d=>d.HTMLHosrem == keyword);
            }

			//Query IDTrangThai (int)
			if (QueryStrings.Any(d => d.Key == "IDTrangThai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai));
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

			//Query ThoiGianHetHan (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "ThoiGianHetHanFrom") && QueryStrings.Any(d => d.Key == "ThoiGianHetHanTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianHetHanFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianHetHanTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ThoiGianHetHan && d.ThoiGianHetHan <= toDate);


			return toDTO(query);

        }

		public static DTO_PRO_HoiNghiHoiThao get_PRO_HoiNghiHoiThao(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_HoiNghiHoiThao.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_HoiNghiHoiThao(AppEntities db, int ID, DTO_PRO_HoiNghiHoiThao item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDNhanVien = item.IDNhanVien;							
				dbitem.ThoiGian = item.ThoiGian;							
				dbitem.DiaDiem = item.DiaDiem;							
				dbitem.TenHoiNghi = item.TenHoiNghi;							
				dbitem.CVBaoCaoVien = item.CVBaoCaoVien;							
				dbitem.BaiAbstract = item.BaiAbstract;							
				dbitem.BaiFulltext = item.BaiFulltext;							
				dbitem.HTMLHosrem = item.HTMLHosrem;							
				dbitem.IDTrangThai = item.IDTrangThai;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.ThoiGianHetHan = item.ThoiGianHetHan;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_HoiNghiHoiThao",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_HoiNghiHoiThao post_PRO_HoiNghiHoiThao(AppEntities db, DTO_PRO_HoiNghiHoiThao item, string Username)
        {
            tbl_PRO_HoiNghiHoiThao dbitem = new tbl_PRO_HoiNghiHoiThao();
            if (item != null)
            {							
				dbitem.IDNhanVien = item.IDNhanVien;							
				dbitem.ThoiGian = item.ThoiGian;							
				dbitem.DiaDiem = item.DiaDiem;							
				dbitem.TenHoiNghi = item.TenHoiNghi;							
				dbitem.CVBaoCaoVien = item.CVBaoCaoVien;							
				dbitem.BaiAbstract = item.BaiAbstract;							
				dbitem.BaiFulltext = item.BaiFulltext;							
				dbitem.HTMLHosrem = item.HTMLHosrem;							
				dbitem.IDTrangThai = item.IDTrangThai;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.ThoiGianHetHan = item.ThoiGianHetHan;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_HoiNghiHoiThao.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_HoiNghiHoiThao",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_HoiNghiHoiThao(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_HoiNghiHoiThao",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_HoiNghiHoiThao_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_HoiNghiHoiThao.Any(e => e.ID == id);
		}
		
    }

}






