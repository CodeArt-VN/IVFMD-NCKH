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
    
    
    public partial class tbl_PRO_DonXinXetDuyet
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string HoTenChuNhiem { get; set; }
        public string DonVi { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenDeTai { get; set; }
        public string TenDonViChuTri { get; set; }
        public string DiaChiDonVi { get; set; }
        public string DienThoaiDonVi { get; set; }
        public string DiaDiemNghienCuu { get; set; }
        public string ThoiGianNghienCuu { get; set; }
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        public bool ThuyetMinhDeCuong { get; set; }
        public bool LLKHChuNhiem { get; set; }
        public bool LLKHNCV { get; set; }
        public bool GiayToKhac { get; set; }
        public string GhiChuGiayToKha { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_DonXinXetDuyet
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string HoTenChuNhiem { get; set; }
		public string DonVi { get; set; }
		public string DiaChi { get; set; }
		public string DienThoai { get; set; }
		public string TenDeTai { get; set; }
		public string TenDonViChuTri { get; set; }
		public string DiaChiDonVi { get; set; }
		public string DienThoaiDonVi { get; set; }
		public string DiaDiemNghienCuu { get; set; }
		public string ThoiGianNghienCuu { get; set; }
		public string TuNgay { get; set; }
		public string DenNgay { get; set; }
		public bool ThuyetMinhDeCuong { get; set; }
		public bool LLKHChuNhiem { get; set; }
		public bool LLKHNCV { get; set; }
		public bool GiayToKhac { get; set; }
		public string GhiChuGiayToKha { get; set; }
		public string HTML { get; set; }
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

    public static partial class BS_PRO_DonXinXetDuyet 
    {
		public static IQueryable<DTO_PRO_DonXinXetDuyet> toDTO(IQueryable<tbl_PRO_DonXinXetDuyet> query)
        {
			return query
			.Select(s => new DTO_PRO_DonXinXetDuyet(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				HoTenChuNhiem = s.HoTenChuNhiem,							
				DonVi = s.DonVi,							
				DiaChi = s.DiaChi,							
				DienThoai = s.DienThoai,							
				TenDeTai = s.TenDeTai,							
				TenDonViChuTri = s.TenDonViChuTri,							
				DiaChiDonVi = s.DiaChiDonVi,							
				DienThoaiDonVi = s.DienThoaiDonVi,							
				DiaDiemNghienCuu = s.DiaDiemNghienCuu,							
				ThoiGianNghienCuu = s.ThoiGianNghienCuu,							
				TuNgay = s.TuNgay,							
				DenNgay = s.DenNgay,							
				ThuyetMinhDeCuong = s.ThuyetMinhDeCuong,							
				LLKHChuNhiem = s.LLKHChuNhiem,							
				LLKHNCV = s.LLKHNCV,							
				GiayToKhac = s.GiayToKhac,							
				GhiChuGiayToKha = s.GhiChuGiayToKha,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_DonXinXetDuyet toDTO(tbl_PRO_DonXinXetDuyet dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_DonXinXetDuyet()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					HoTenChuNhiem = dbResult.HoTenChuNhiem,							
					DonVi = dbResult.DonVi,							
					DiaChi = dbResult.DiaChi,							
					DienThoai = dbResult.DienThoai,							
					TenDeTai = dbResult.TenDeTai,							
					TenDonViChuTri = dbResult.TenDonViChuTri,							
					DiaChiDonVi = dbResult.DiaChiDonVi,							
					DienThoaiDonVi = dbResult.DienThoaiDonVi,							
					DiaDiemNghienCuu = dbResult.DiaDiemNghienCuu,							
					ThoiGianNghienCuu = dbResult.ThoiGianNghienCuu,							
					TuNgay = dbResult.TuNgay,							
					DenNgay = dbResult.DenNgay,							
					ThuyetMinhDeCuong = dbResult.ThuyetMinhDeCuong,							
					LLKHChuNhiem = dbResult.LLKHChuNhiem,							
					LLKHNCV = dbResult.LLKHNCV,							
					GiayToKhac = dbResult.GiayToKhac,							
					GhiChuGiayToKha = dbResult.GhiChuGiayToKha,							
					HTML = dbResult.HTML,							
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

        public static IQueryable<DTO_PRO_DonXinXetDuyet> get_PRO_DonXinXetDuyet(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_DonXinXetDuyet.Where(d => d.IsDeleted == false );

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

			//Query HoTenChuNhiem (string)
			if (QueryStrings.Any(d => d.Key == "HoTenChuNhiem") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HoTenChuNhiem").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HoTenChuNhiem").Value;
                query = query.Where(d=>d.HoTenChuNhiem == keyword);
            }

			//Query DonVi (string)
			if (QueryStrings.Any(d => d.Key == "DonVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DonVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DonVi").Value;
                query = query.Where(d=>d.DonVi == keyword);
            }

			//Query DiaChi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChi").Value;
                query = query.Where(d=>d.DiaChi == keyword);
            }

			//Query DienThoai (string)
			if (QueryStrings.Any(d => d.Key == "DienThoai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoai").Value;
                query = query.Where(d=>d.DienThoai == keyword);
            }

			//Query TenDeTai (string)
			if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d=>d.TenDeTai == keyword);
            }

			//Query TenDonViChuTri (string)
			if (QueryStrings.Any(d => d.Key == "TenDonViChuTri") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDonViChuTri").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDonViChuTri").Value;
                query = query.Where(d=>d.TenDonViChuTri == keyword);
            }

			//Query DiaChiDonVi (string)
			if (QueryStrings.Any(d => d.Key == "DiaChiDonVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaChiDonVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaChiDonVi").Value;
                query = query.Where(d=>d.DiaChiDonVi == keyword);
            }

			//Query DienThoaiDonVi (string)
			if (QueryStrings.Any(d => d.Key == "DienThoaiDonVi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiDonVi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DienThoaiDonVi").Value;
                query = query.Where(d=>d.DienThoaiDonVi == keyword);
            }

			//Query DiaDiemNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "DiaDiemNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DiaDiemNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DiaDiemNghienCuu").Value;
                query = query.Where(d=>d.DiaDiemNghienCuu == keyword);
            }

			//Query ThoiGianNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "ThoiGianNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThoiGianNghienCuu").Value;
                query = query.Where(d=>d.ThoiGianNghienCuu == keyword);
            }

			//Query TuNgay (string)
			if (QueryStrings.Any(d => d.Key == "TuNgay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TuNgay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TuNgay").Value;
                query = query.Where(d=>d.TuNgay == keyword);
            }

			//Query DenNgay (string)
			if (QueryStrings.Any(d => d.Key == "DenNgay") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DenNgay").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DenNgay").Value;
                query = query.Where(d=>d.DenNgay == keyword);
            }

			//Query ThuyetMinhDeCuong (bool)
			if (QueryStrings.Any(d => d.Key == "ThuyetMinhDeCuong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "ThuyetMinhDeCuong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.ThuyetMinhDeCuong);
            }

			//Query LLKHChuNhiem (bool)
			if (QueryStrings.Any(d => d.Key == "LLKHChuNhiem"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "LLKHChuNhiem").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.LLKHChuNhiem);
            }

			//Query LLKHNCV (bool)
			if (QueryStrings.Any(d => d.Key == "LLKHNCV"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "LLKHNCV").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.LLKHNCV);
            }

			//Query GiayToKhac (bool)
			if (QueryStrings.Any(d => d.Key == "GiayToKhac"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "GiayToKhac").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.GiayToKhac);
            }

			//Query GhiChuGiayToKha (string)
			if (QueryStrings.Any(d => d.Key == "GhiChuGiayToKha") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GhiChuGiayToKha").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GhiChuGiayToKha").Value;
                query = query.Where(d=>d.GhiChuGiayToKha == keyword);
            }

			//Query HTML (string)
			if (QueryStrings.Any(d => d.Key == "HTML") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value;
                query = query.Where(d=>d.HTML == keyword);
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

		public static DTO_PRO_DonXinXetDuyet get_PRO_DonXinXetDuyet(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_DonXinXetDuyet.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_DonXinXetDuyet(AppEntities db, int ID, DTO_PRO_DonXinXetDuyet item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_DonXinXetDuyet.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.HoTenChuNhiem = item.HoTenChuNhiem;							
				dbitem.DonVi = item.DonVi;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoai = item.DienThoai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.TenDonViChuTri = item.TenDonViChuTri;							
				dbitem.DiaChiDonVi = item.DiaChiDonVi;							
				dbitem.DienThoaiDonVi = item.DienThoaiDonVi;							
				dbitem.DiaDiemNghienCuu = item.DiaDiemNghienCuu;							
				dbitem.ThoiGianNghienCuu = item.ThoiGianNghienCuu;							
				dbitem.TuNgay = item.TuNgay;							
				dbitem.DenNgay = item.DenNgay;							
				dbitem.ThuyetMinhDeCuong = item.ThuyetMinhDeCuong;							
				dbitem.LLKHChuNhiem = item.LLKHChuNhiem;							
				dbitem.LLKHNCV = item.LLKHNCV;							
				dbitem.GiayToKhac = item.GiayToKhac;							
				dbitem.GhiChuGiayToKha = item.GhiChuGiayToKha;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinXetDuyet", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_DonXinXetDuyet",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_DonXinXetDuyet post_PRO_DonXinXetDuyet(AppEntities db, DTO_PRO_DonXinXetDuyet item, string Username)
        {
            tbl_PRO_DonXinXetDuyet dbitem = new tbl_PRO_DonXinXetDuyet();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.HoTenChuNhiem = item.HoTenChuNhiem;							
				dbitem.DonVi = item.DonVi;							
				dbitem.DiaChi = item.DiaChi;							
				dbitem.DienThoai = item.DienThoai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.TenDonViChuTri = item.TenDonViChuTri;							
				dbitem.DiaChiDonVi = item.DiaChiDonVi;							
				dbitem.DienThoaiDonVi = item.DienThoaiDonVi;							
				dbitem.DiaDiemNghienCuu = item.DiaDiemNghienCuu;							
				dbitem.ThoiGianNghienCuu = item.ThoiGianNghienCuu;							
				dbitem.TuNgay = item.TuNgay;							
				dbitem.DenNgay = item.DenNgay;							
				dbitem.ThuyetMinhDeCuong = item.ThuyetMinhDeCuong;							
				dbitem.LLKHChuNhiem = item.LLKHChuNhiem;							
				dbitem.LLKHNCV = item.LLKHNCV;							
				dbitem.GiayToKhac = item.GiayToKhac;							
				dbitem.GhiChuGiayToKha = item.GhiChuGiayToKha;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_DonXinXetDuyet.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinXetDuyet", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_DonXinXetDuyet",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_DonXinXetDuyet(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_DonXinXetDuyet.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DonXinXetDuyet", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_DonXinXetDuyet",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_DonXinXetDuyet_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_DonXinXetDuyet.Any(e => e.ID == id);
		}
		
    }

}






