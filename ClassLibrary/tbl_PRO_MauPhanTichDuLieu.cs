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
    
    
    public partial class tbl_PRO_MauPhanTichDuLieu
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string JSON_DacDiemNen { get; set; }
        public string JSON_KichThichBuongTrung { get; set; }
        public string JSON_LaBo { get; set; }
        public string JSON_ChuKyChuyenPhoi { get; set; }
        public string JSON_KetQuaThai { get; set; }
        public string JSON_BienSoKhac { get; set; }
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
	public partial class DTO_PRO_MauPhanTichDuLieu
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string JSON_DacDiemNen { get; set; }
		public string JSON_KichThichBuongTrung { get; set; }
		public string JSON_LaBo { get; set; }
		public string JSON_ChuKyChuyenPhoi { get; set; }
		public string JSON_KetQuaThai { get; set; }
		public string JSON_BienSoKhac { get; set; }
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

    public static partial class BS_PRO_MauPhanTichDuLieu 
    {
		public static IQueryable<DTO_PRO_MauPhanTichDuLieu> toDTO(IQueryable<tbl_PRO_MauPhanTichDuLieu> query)
        {
			return query
			.Select(s => new DTO_PRO_MauPhanTichDuLieu(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				JSON_DacDiemNen = s.JSON_DacDiemNen,							
				JSON_KichThichBuongTrung = s.JSON_KichThichBuongTrung,							
				JSON_LaBo = s.JSON_LaBo,							
				JSON_ChuKyChuyenPhoi = s.JSON_ChuKyChuyenPhoi,							
				JSON_KetQuaThai = s.JSON_KetQuaThai,							
				JSON_BienSoKhac = s.JSON_BienSoKhac,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_MauPhanTichDuLieu toDTO(tbl_PRO_MauPhanTichDuLieu dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_MauPhanTichDuLieu()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					JSON_DacDiemNen = dbResult.JSON_DacDiemNen,							
					JSON_KichThichBuongTrung = dbResult.JSON_KichThichBuongTrung,							
					JSON_LaBo = dbResult.JSON_LaBo,							
					JSON_ChuKyChuyenPhoi = dbResult.JSON_ChuKyChuyenPhoi,							
					JSON_KetQuaThai = dbResult.JSON_KetQuaThai,							
					JSON_BienSoKhac = dbResult.JSON_BienSoKhac,							
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

        public static IQueryable<DTO_PRO_MauPhanTichDuLieu> get_PRO_MauPhanTichDuLieu(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_MauPhanTichDuLieu
			.Where(d => d.IsDeleted == false );
			

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

			//Query JSON_DacDiemNen (string)
			if (QueryStrings.Any(d => d.Key == "JSON_DacDiemNen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_DacDiemNen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_DacDiemNen").Value;
                query = query.Where(d=>d.JSON_DacDiemNen == keyword);
            }

			//Query JSON_KichThichBuongTrung (string)
			if (QueryStrings.Any(d => d.Key == "JSON_KichThichBuongTrung") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_KichThichBuongTrung").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_KichThichBuongTrung").Value;
                query = query.Where(d=>d.JSON_KichThichBuongTrung == keyword);
            }

			//Query JSON_LaBo (string)
			if (QueryStrings.Any(d => d.Key == "JSON_LaBo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_LaBo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_LaBo").Value;
                query = query.Where(d=>d.JSON_LaBo == keyword);
            }

			//Query JSON_ChuKyChuyenPhoi (string)
			if (QueryStrings.Any(d => d.Key == "JSON_ChuKyChuyenPhoi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_ChuKyChuyenPhoi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_ChuKyChuyenPhoi").Value;
                query = query.Where(d=>d.JSON_ChuKyChuyenPhoi == keyword);
            }

			//Query JSON_KetQuaThai (string)
			if (QueryStrings.Any(d => d.Key == "JSON_KetQuaThai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_KetQuaThai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_KetQuaThai").Value;
                query = query.Where(d=>d.JSON_KetQuaThai == keyword);
            }

			//Query JSON_BienSoKhac (string)
			if (QueryStrings.Any(d => d.Key == "JSON_BienSoKhac") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_BienSoKhac").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_BienSoKhac").Value;
                query = query.Where(d=>d.JSON_BienSoKhac == keyword);
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

		public static DTO_PRO_MauPhanTichDuLieu get_PRO_MauPhanTichDuLieu(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PRO_MauPhanTichDuLieu.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_MauPhanTichDuLieu(AppEntities db, int PartnerID, int ID, DTO_PRO_MauPhanTichDuLieu item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_MauPhanTichDuLieu.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.JSON_DacDiemNen = item.JSON_DacDiemNen;							
				dbitem.JSON_KichThichBuongTrung = item.JSON_KichThichBuongTrung;							
				dbitem.JSON_LaBo = item.JSON_LaBo;							
				dbitem.JSON_ChuKyChuyenPhoi = item.JSON_ChuKyChuyenPhoi;							
				dbitem.JSON_KetQuaThai = item.JSON_KetQuaThai;							
				dbitem.JSON_BienSoKhac = item.JSON_BienSoKhac;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_MauPhanTichDuLieu", dbitem.ModifiedDate, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_MauPhanTichDuLieu",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_MauPhanTichDuLieu post_PRO_MauPhanTichDuLieu(AppEntities db, int PartnerID, DTO_PRO_MauPhanTichDuLieu item, string Username)
        {
            tbl_PRO_MauPhanTichDuLieu dbitem = new tbl_PRO_MauPhanTichDuLieu();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.JSON_DacDiemNen = item.JSON_DacDiemNen;							
				dbitem.JSON_KichThichBuongTrung = item.JSON_KichThichBuongTrung;							
				dbitem.JSON_LaBo = item.JSON_LaBo;							
				dbitem.JSON_ChuKyChuyenPhoi = item.JSON_ChuKyChuyenPhoi;							
				dbitem.JSON_KetQuaThai = item.JSON_KetQuaThai;							
				dbitem.JSON_BienSoKhac = item.JSON_BienSoKhac;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_MauPhanTichDuLieu.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_MauPhanTichDuLieu", dbitem.ModifiedDate, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_MauPhanTichDuLieu",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_MauPhanTichDuLieu(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_MauPhanTichDuLieu.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_MauPhanTichDuLieu", dbitem.ModifiedDate, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_MauPhanTichDuLieu",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_MauPhanTichDuLieu_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_MauPhanTichDuLieu.Any(e => e.ID == id);
		}
		
    }

}






