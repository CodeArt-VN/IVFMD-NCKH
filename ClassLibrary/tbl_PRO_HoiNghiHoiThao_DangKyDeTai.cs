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
    
    
    public partial class tbl_PRO_HoiNghiHoiThao_DangKyDeTai
    {
        public int ID { get; set; }
        public int IDDangKy { get; set; }
        public int IDHoiNghiHoiThao { get; set; }
        public int IDHinhThucDangKy { get; set; }
        public int IDTrangThai { get; set; }
        public string TenDeTai { get; set; }
        public string BaiAbstract { get; set; }
        public string BaiFulltext { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_PRO_HoiNghiHoiThao tbl_PRO_HoiNghiHoiThao { get; set; }
        public virtual tbl_PRO_HoiNghiHoiThao_DangKy tbl_PRO_HoiNghiHoiThao_DangKy { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var { get; set; }
        public virtual tbl_SYS_Var tbl_SYS_Var1 { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_HoiNghiHoiThao_DangKyDeTai
	{
		public int ID { get; set; }
		public int IDDangKy { get; set; }
		public int IDHoiNghiHoiThao { get; set; }
		public int IDHinhThucDangKy { get; set; }
		public int IDTrangThai { get; set; }
		public string TenDeTai { get; set; }
		public string BaiAbstract { get; set; }
		public string BaiFulltext { get; set; }
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

    public static partial class BS_PRO_HoiNghiHoiThao_DangKyDeTai 
    {
		public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> toDTO(IQueryable<tbl_PRO_HoiNghiHoiThao_DangKyDeTai> query)
        {
			return query
			.Select(s => new DTO_PRO_HoiNghiHoiThao_DangKyDeTai(){							
				ID = s.ID,							
				IDDangKy = s.IDDangKy,							
				IDHoiNghiHoiThao = s.IDHoiNghiHoiThao,							
				IDHinhThucDangKy = s.IDHinhThucDangKy,							
				IDTrangThai = s.IDTrangThai,							
				TenDeTai = s.TenDeTai,							
				BaiAbstract = s.BaiAbstract,							
				BaiFulltext = s.BaiFulltext,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_HoiNghiHoiThao_DangKyDeTai toDTO(tbl_PRO_HoiNghiHoiThao_DangKyDeTai dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_HoiNghiHoiThao_DangKyDeTai()
				{							
					ID = dbResult.ID,							
					IDDangKy = dbResult.IDDangKy,							
					IDHoiNghiHoiThao = dbResult.IDHoiNghiHoiThao,							
					IDHinhThucDangKy = dbResult.IDHinhThucDangKy,							
					IDTrangThai = dbResult.IDTrangThai,							
					TenDeTai = dbResult.TenDeTai,							
					BaiAbstract = dbResult.BaiAbstract,							
					BaiFulltext = dbResult.BaiFulltext,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> get_PRO_HoiNghiHoiThao_DangKyDeTai(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.AsQueryable();

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

			//Query IDDangKy (int)
			if (QueryStrings.Any(d => d.Key == "IDDangKy"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDangKy").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDangKy));
            }

			//Query IDHoiNghiHoiThao (int)
			if (QueryStrings.Any(d => d.Key == "IDHoiNghiHoiThao"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHoiNghiHoiThao").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHoiNghiHoiThao));
            }

			//Query IDHinhThucDangKy (int)
			if (QueryStrings.Any(d => d.Key == "IDHinhThucDangKy"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHinhThucDangKy").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHinhThucDangKy));
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

			//Query TenDeTai (string)
			if (QueryStrings.Any(d => d.Key == "TenDeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenDeTai").Value;
                query = query.Where(d=>d.TenDeTai == keyword);
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

		public static DTO_PRO_HoiNghiHoiThao_DangKyDeTai get_PRO_HoiNghiHoiThao_DangKyDeTai(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_HoiNghiHoiThao_DangKyDeTai(AppEntities db, int ID, DTO_PRO_HoiNghiHoiThao_DangKyDeTai item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDangKy = item.IDDangKy;							
				dbitem.IDHoiNghiHoiThao = item.IDHoiNghiHoiThao;							
				dbitem.IDHinhThucDangKy = item.IDHinhThucDangKy;							
				dbitem.IDTrangThai = item.IDTrangThai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.BaiAbstract = item.BaiAbstract;							
				dbitem.BaiFulltext = item.BaiFulltext;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKyDeTai", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_HoiNghiHoiThao_DangKyDeTai",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_HoiNghiHoiThao_DangKyDeTai post_PRO_HoiNghiHoiThao_DangKyDeTai(AppEntities db, DTO_PRO_HoiNghiHoiThao_DangKyDeTai item, string Username)
        {
            tbl_PRO_HoiNghiHoiThao_DangKyDeTai dbitem = new tbl_PRO_HoiNghiHoiThao_DangKyDeTai();
            if (item != null)
            {							
				dbitem.IDDangKy = item.IDDangKy;							
				dbitem.IDHoiNghiHoiThao = item.IDHoiNghiHoiThao;							
				dbitem.IDHinhThucDangKy = item.IDHinhThucDangKy;							
				dbitem.IDTrangThai = item.IDTrangThai;							
				dbitem.TenDeTai = item.TenDeTai;							
				dbitem.BaiAbstract = item.BaiAbstract;							
				dbitem.BaiFulltext = item.BaiFulltext;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKyDeTai", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_HoiNghiHoiThao_DangKyDeTai",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_HoiNghiHoiThao_DangKyDeTai(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Find(ID);
            if (dbitem != null)
            {
			
				db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Remove(dbitem);
			                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_HoiNghiHoiThao_DangKyDeTai", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_HoiNghiHoiThao_DangKyDeTai",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_HoiNghiHoiThao_DangKyDeTai_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_HoiNghiHoiThao_DangKyDeTai.Any(e => e.ID == id);
		}
		
    }

}






