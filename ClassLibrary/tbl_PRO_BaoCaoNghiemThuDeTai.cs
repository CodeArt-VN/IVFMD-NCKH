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
    
    
    public partial class tbl_PRO_BaoCaoNghiemThuDeTai
    {
        public int ID { get; set; }
        public Nullable<int> IDDeTai { get; set; }
        public string TenDeTai { get; set; }
        public string ChuNhiemDeTai { get; set; }
        public string JSON_DanhSachThamGia { get; set; }
        public string JSON_TomTat { get; set; }
        public string JSON_Abstract { get; set; }
        public string JSON_LoiCamOn { get; set; }
        public string JSON_MucLuc { get; set; }
        public string JSON_CacChuVietTat { get; set; }
        public string JSON_DanhMucCacBang { get; set; }
        public string JSON_MucTieu { get; set; }
        public string JSON_Chuong1 { get; set; }
        public string JSON_Chuong2 { get; set; }
        public string JSON_VatLieuPhuongPhap { get; set; }
        public string JSON_Chuong3 { get; set; }
        public string JSON_Chuong4 { get; set; }
        public string JSON_Chuong5 { get; set; }
        public string JSON_KetLuan { get; set; }
        public string JSON_TaiLieuThamKhao { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string BaiFulltext { get; set; }
        public string FormConfig { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_BaoCaoNghiemThuDeTai
	{
		public int ID { get; set; }
		public Nullable<int> IDDeTai { get; set; }
		public string TenDeTai { get; set; }
		public string ChuNhiemDeTai { get; set; }
		public string JSON_DanhSachThamGia { get; set; }
		public string JSON_TomTat { get; set; }
		public string JSON_Abstract { get; set; }
		public string JSON_LoiCamOn { get; set; }
		public string JSON_MucLuc { get; set; }
		public string JSON_CacChuVietTat { get; set; }
		public string JSON_DanhMucCacBang { get; set; }
		public string JSON_MucTieu { get; set; }
		public string JSON_Chuong1 { get; set; }
		public string JSON_Chuong2 { get; set; }
		public string JSON_VatLieuPhuongPhap { get; set; }
		public string JSON_Chuong3 { get; set; }
		public string JSON_Chuong4 { get; set; }
		public string JSON_Chuong5 { get; set; }
		public string JSON_KetLuan { get; set; }
		public string JSON_TaiLieuThamKhao { get; set; }
		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public string BaiFulltext { get; set; }
		public string FormConfig { get; set; }
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

    public static partial class BS_PRO_BaoCaoNghiemThuDeTai 
    {
		public static IQueryable<DTO_PRO_BaoCaoNghiemThuDeTai> toDTO(IQueryable<tbl_PRO_BaoCaoNghiemThuDeTai> query)
        {
			return query
			.Select(s => new DTO_PRO_BaoCaoNghiemThuDeTai(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				TenDeTai = s.TenDeTai,							
				ChuNhiemDeTai = s.ChuNhiemDeTai,							
				JSON_DanhSachThamGia = s.JSON_DanhSachThamGia,							
				JSON_TomTat = s.JSON_TomTat,							
				JSON_Abstract = s.JSON_Abstract,							
				JSON_LoiCamOn = s.JSON_LoiCamOn,							
				JSON_MucLuc = s.JSON_MucLuc,							
				JSON_CacChuVietTat = s.JSON_CacChuVietTat,							
				JSON_DanhMucCacBang = s.JSON_DanhMucCacBang,							
				JSON_MucTieu = s.JSON_MucTieu,							
				JSON_Chuong1 = s.JSON_Chuong1,							
				JSON_Chuong2 = s.JSON_Chuong2,							
				JSON_VatLieuPhuongPhap = s.JSON_VatLieuPhuongPhap,							
				JSON_Chuong3 = s.JSON_Chuong3,							
				JSON_Chuong4 = s.JSON_Chuong4,							
				JSON_Chuong5 = s.JSON_Chuong5,							
				JSON_KetLuan = s.JSON_KetLuan,							
				JSON_TaiLieuThamKhao = s.JSON_TaiLieuThamKhao,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				BaiFulltext = s.BaiFulltext,							
				FormConfig = s.FormConfig,					
			});
                              
        }

		public static DTO_PRO_BaoCaoNghiemThuDeTai toDTO(tbl_PRO_BaoCaoNghiemThuDeTai dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_BaoCaoNghiemThuDeTai()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					TenDeTai = dbResult.TenDeTai,							
					ChuNhiemDeTai = dbResult.ChuNhiemDeTai,							
					JSON_DanhSachThamGia = dbResult.JSON_DanhSachThamGia,							
					JSON_TomTat = dbResult.JSON_TomTat,							
					JSON_Abstract = dbResult.JSON_Abstract,							
					JSON_LoiCamOn = dbResult.JSON_LoiCamOn,							
					JSON_MucLuc = dbResult.JSON_MucLuc,							
					JSON_CacChuVietTat = dbResult.JSON_CacChuVietTat,							
					JSON_DanhMucCacBang = dbResult.JSON_DanhMucCacBang,							
					JSON_MucTieu = dbResult.JSON_MucTieu,							
					JSON_Chuong1 = dbResult.JSON_Chuong1,							
					JSON_Chuong2 = dbResult.JSON_Chuong2,							
					JSON_VatLieuPhuongPhap = dbResult.JSON_VatLieuPhuongPhap,							
					JSON_Chuong3 = dbResult.JSON_Chuong3,							
					JSON_Chuong4 = dbResult.JSON_Chuong4,							
					JSON_Chuong5 = dbResult.JSON_Chuong5,							
					JSON_KetLuan = dbResult.JSON_KetLuan,							
					JSON_TaiLieuThamKhao = dbResult.JSON_TaiLieuThamKhao,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					BaiFulltext = dbResult.BaiFulltext,							
					FormConfig = dbResult.FormConfig,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_BaoCaoNghiemThuDeTai> get_PRO_BaoCaoNghiemThuDeTai(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_BaoCaoNghiemThuDeTai.Where(d => d.IsDeleted == false );

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

			//Query IDDeTai (Nullable<int>)
			if (QueryStrings.Any(d => d.Key == "IDDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
					else if (item == "null")
						IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDeTai));
            }

			//Query TenDeTai (string)
			if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d=>d.TenDeTai == keyword);
            }

			//Query ChuNhiemDeTai (string)
			if (QueryStrings.Any(d => d.Key == "ChuNhiemDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ChuNhiemDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ChuNhiemDeTai").Value;
                query = query.Where(d=>d.ChuNhiemDeTai == keyword);
            }

			//Query JSON_DanhSachThamGia (string)
			if (QueryStrings.Any(d => d.Key == "JSON_DanhSachThamGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_DanhSachThamGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_DanhSachThamGia").Value;
                query = query.Where(d=>d.JSON_DanhSachThamGia == keyword);
            }

			//Query JSON_TomTat (string)
			if (QueryStrings.Any(d => d.Key == "JSON_TomTat") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_TomTat").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_TomTat").Value;
                query = query.Where(d=>d.JSON_TomTat == keyword);
            }

			//Query JSON_Abstract (string)
			if (QueryStrings.Any(d => d.Key == "JSON_Abstract") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_Abstract").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_Abstract").Value;
                query = query.Where(d=>d.JSON_Abstract == keyword);
            }

			//Query JSON_LoiCamOn (string)
			if (QueryStrings.Any(d => d.Key == "JSON_LoiCamOn") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_LoiCamOn").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_LoiCamOn").Value;
                query = query.Where(d=>d.JSON_LoiCamOn == keyword);
            }

			//Query JSON_MucLuc (string)
			if (QueryStrings.Any(d => d.Key == "JSON_MucLuc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_MucLuc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_MucLuc").Value;
                query = query.Where(d=>d.JSON_MucLuc == keyword);
            }

			//Query JSON_CacChuVietTat (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CacChuVietTat") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacChuVietTat").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacChuVietTat").Value;
                query = query.Where(d=>d.JSON_CacChuVietTat == keyword);
            }

			//Query JSON_DanhMucCacBang (string)
			if (QueryStrings.Any(d => d.Key == "JSON_DanhMucCacBang") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_DanhMucCacBang").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_DanhMucCacBang").Value;
                query = query.Where(d=>d.JSON_DanhMucCacBang == keyword);
            }

			//Query JSON_MucTieu (string)
			if (QueryStrings.Any(d => d.Key == "JSON_MucTieu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_MucTieu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_MucTieu").Value;
                query = query.Where(d=>d.JSON_MucTieu == keyword);
            }

			//Query JSON_Chuong1 (string)
			if (QueryStrings.Any(d => d.Key == "JSON_Chuong1") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong1").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong1").Value;
                query = query.Where(d=>d.JSON_Chuong1 == keyword);
            }

			//Query JSON_Chuong2 (string)
			if (QueryStrings.Any(d => d.Key == "JSON_Chuong2") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong2").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong2").Value;
                query = query.Where(d=>d.JSON_Chuong2 == keyword);
            }

			//Query JSON_VatLieuPhuongPhap (string)
			if (QueryStrings.Any(d => d.Key == "JSON_VatLieuPhuongPhap") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_VatLieuPhuongPhap").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_VatLieuPhuongPhap").Value;
                query = query.Where(d=>d.JSON_VatLieuPhuongPhap == keyword);
            }

			//Query JSON_Chuong3 (string)
			if (QueryStrings.Any(d => d.Key == "JSON_Chuong3") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong3").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong3").Value;
                query = query.Where(d=>d.JSON_Chuong3 == keyword);
            }

			//Query JSON_Chuong4 (string)
			if (QueryStrings.Any(d => d.Key == "JSON_Chuong4") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong4").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong4").Value;
                query = query.Where(d=>d.JSON_Chuong4 == keyword);
            }

			//Query JSON_Chuong5 (string)
			if (QueryStrings.Any(d => d.Key == "JSON_Chuong5") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong5").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_Chuong5").Value;
                query = query.Where(d=>d.JSON_Chuong5 == keyword);
            }

			//Query JSON_KetLuan (string)
			if (QueryStrings.Any(d => d.Key == "JSON_KetLuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_KetLuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_KetLuan").Value;
                query = query.Where(d=>d.JSON_KetLuan == keyword);
            }

			//Query JSON_TaiLieuThamKhao (string)
			if (QueryStrings.Any(d => d.Key == "JSON_TaiLieuThamKhao") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_TaiLieuThamKhao").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_TaiLieuThamKhao").Value;
                query = query.Where(d=>d.JSON_TaiLieuThamKhao == keyword);
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

			//Query BaiFulltext (string)
			if (QueryStrings.Any(d => d.Key == "BaiFulltext") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BaiFulltext").Value;
                query = query.Where(d=>d.BaiFulltext == keyword);
            }

			//Query FormConfig (string)
			if (QueryStrings.Any(d => d.Key == "FormConfig") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value;
                query = query.Where(d=>d.FormConfig == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_BaoCaoNghiemThuDeTai get_PRO_BaoCaoNghiemThuDeTai(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_BaoCaoNghiemThuDeTai.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_BaoCaoNghiemThuDeTai(AppEntities db, int ID, DTO_PRO_BaoCaoNghiemThuDeTai item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_BaoCaoNghiemThuDeTai.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.ChuNhiemDeTai = item.ChuNhiemDeTai;							
				dbitem.JSON_DanhSachThamGia = item.JSON_DanhSachThamGia;							
				dbitem.JSON_TomTat = item.JSON_TomTat;							
				dbitem.JSON_Abstract = item.JSON_Abstract;							
				dbitem.JSON_LoiCamOn = item.JSON_LoiCamOn;							
				dbitem.JSON_MucLuc = item.JSON_MucLuc;							
				dbitem.JSON_CacChuVietTat = item.JSON_CacChuVietTat;							
				dbitem.JSON_DanhMucCacBang = item.JSON_DanhMucCacBang;							
				dbitem.JSON_MucTieu = item.JSON_MucTieu;							
				dbitem.JSON_Chuong1 = item.JSON_Chuong1;							
				dbitem.JSON_Chuong2 = item.JSON_Chuong2;							
				dbitem.JSON_VatLieuPhuongPhap = item.JSON_VatLieuPhuongPhap;							
				dbitem.JSON_Chuong3 = item.JSON_Chuong3;							
				dbitem.JSON_Chuong4 = item.JSON_Chuong4;							
				dbitem.JSON_Chuong5 = item.JSON_Chuong5;							
				dbitem.JSON_KetLuan = item.JSON_KetLuan;							
				dbitem.JSON_TaiLieuThamKhao = item.JSON_TaiLieuThamKhao;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.BaiFulltext = item.BaiFulltext;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNghiemThuDeTai", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_BaoCaoNghiemThuDeTai",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_BaoCaoNghiemThuDeTai post_PRO_BaoCaoNghiemThuDeTai(AppEntities db, DTO_PRO_BaoCaoNghiemThuDeTai item, string Username)
        {
            tbl_PRO_BaoCaoNghiemThuDeTai dbitem = new tbl_PRO_BaoCaoNghiemThuDeTai();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.ChuNhiemDeTai = item.ChuNhiemDeTai;							
				dbitem.JSON_DanhSachThamGia = item.JSON_DanhSachThamGia;							
				dbitem.JSON_TomTat = item.JSON_TomTat;							
				dbitem.JSON_Abstract = item.JSON_Abstract;							
				dbitem.JSON_LoiCamOn = item.JSON_LoiCamOn;							
				dbitem.JSON_MucLuc = item.JSON_MucLuc;							
				dbitem.JSON_CacChuVietTat = item.JSON_CacChuVietTat;							
				dbitem.JSON_DanhMucCacBang = item.JSON_DanhMucCacBang;							
				dbitem.JSON_MucTieu = item.JSON_MucTieu;							
				dbitem.JSON_Chuong1 = item.JSON_Chuong1;							
				dbitem.JSON_Chuong2 = item.JSON_Chuong2;							
				dbitem.JSON_VatLieuPhuongPhap = item.JSON_VatLieuPhuongPhap;							
				dbitem.JSON_Chuong3 = item.JSON_Chuong3;							
				dbitem.JSON_Chuong4 = item.JSON_Chuong4;							
				dbitem.JSON_Chuong5 = item.JSON_Chuong5;							
				dbitem.JSON_KetLuan = item.JSON_KetLuan;							
				dbitem.JSON_TaiLieuThamKhao = item.JSON_TaiLieuThamKhao;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.BaiFulltext = item.BaiFulltext;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_BaoCaoNghiemThuDeTai.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNghiemThuDeTai", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_BaoCaoNghiemThuDeTai",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_BaoCaoNghiemThuDeTai(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_BaoCaoNghiemThuDeTai.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BaoCaoNghiemThuDeTai", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_BaoCaoNghiemThuDeTai",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_BaoCaoNghiemThuDeTai_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_BaoCaoNghiemThuDeTai.Any(e => e.ID == id);
		}
		
    }

}






