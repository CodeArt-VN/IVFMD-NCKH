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
    
    
    public partial class tbl_CUS_DOC_File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CUS_DOC_File()
        {
            this.tbl_CUS_DOC_File_Actitity = new HashSet<tbl_CUS_DOC_File_Actitity>();
            this.tbl_CUS_DOC_File_Permission = new HashSet<tbl_CUS_DOC_File_Permission>();
            this.tbl_CUS_DOC_FileInFolder = new HashSet<tbl_CUS_DOC_FileInFolder>();
        }
    
        public int IDPartner { get; set; }
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
        public string Path { get; set; }
        public string Extension { get; set; }
        public bool IsApproved { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public double FileSize { get; set; }
        public string FileVersion { get; set; }
        public Nullable<int> IDDeTai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_DOC_File_Actitity> tbl_CUS_DOC_File_Actitity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_DOC_File_Permission> tbl_CUS_DOC_File_Permission { get; set; }
        public virtual tbl_PAR_Partner tbl_PAR_Partner { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUS_DOC_FileInFolder> tbl_CUS_DOC_FileInFolder { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_CUS_DOC_File
	{
		public int IDPartner { get; set; }
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
		public string Path { get; set; }
		public string Extension { get; set; }
		public bool IsApproved { get; set; }
		public string ApprovedBy { get; set; }
		public Nullable<System.DateTime> ApprovedDate { get; set; }
		public double FileSize { get; set; }
		public string FileVersion { get; set; }
		public Nullable<int> IDDeTai { get; set; }
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

    public static partial class BS_CUS_DOC_File 
    {
		public static IQueryable<DTO_CUS_DOC_File> toDTO(IQueryable<tbl_CUS_DOC_File> query)
        {
			return query
			.Select(s => new DTO_CUS_DOC_File(){							
				IDPartner = s.IDPartner,							
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
				Path = s.Path,							
				Extension = s.Extension,							
				IsApproved = s.IsApproved,							
				ApprovedBy = s.ApprovedBy,							
				ApprovedDate = s.ApprovedDate,							
				FileSize = s.FileSize,							
				FileVersion = s.FileVersion,							
				IDDeTai = s.IDDeTai,					
			}).OrderBy(o => o.Sort == null).ThenBy(u => u.Sort);
                              
        }

		public static DTO_CUS_DOC_File toDTO(tbl_CUS_DOC_File dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_CUS_DOC_File()
				{							
					IDPartner = dbResult.IDPartner,							
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
					Path = dbResult.Path,							
					Extension = dbResult.Extension,							
					IsApproved = dbResult.IsApproved,							
					ApprovedBy = dbResult.ApprovedBy,							
					ApprovedDate = dbResult.ApprovedDate,							
					FileSize = dbResult.FileSize,							
					FileVersion = dbResult.FileVersion,							
					IDDeTai = dbResult.IDDeTai,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_CUS_DOC_File> get_CUS_DOC_File(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_CUS_DOC_File.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);

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

			//Query Path (string)
			if (QueryStrings.Any(d => d.Key == "Path") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Path").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Path").Value;
                query = query.Where(d=>d.Path == keyword);
            }

			//Query Extension (string)
			if (QueryStrings.Any(d => d.Key == "Extension") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Extension").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Extension").Value;
                query = query.Where(d=>d.Extension == keyword);
            }

			//Query IsApproved (bool)
			if (QueryStrings.Any(d => d.Key == "IsApproved"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsApproved").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsApproved);
            }

			//Query ApprovedBy (string)
			if (QueryStrings.Any(d => d.Key == "ApprovedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ApprovedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ApprovedBy").Value;
                query = query.Where(d=>d.ApprovedBy == keyword);
            }

			//Query ApprovedDate (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "ApprovedDateFrom") && QueryStrings.Any(d => d.Key == "ApprovedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ApprovedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ApprovedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ApprovedDate && d.ApprovedDate <= toDate);

			//Query FileSize (double)

			//Query FileVersion (string)
			if (QueryStrings.Any(d => d.Key == "FileVersion") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "FileVersion").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "FileVersion").Value;
                query = query.Where(d=>d.FileVersion == keyword);
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


			return toDTO(query);

        }

		public static DTO_CUS_DOC_File get_CUS_DOC_File(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_CUS_DOC_File.Find(id);

			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }
		
		public static DTO_CUS_DOC_File get_CUS_DOC_File(AppEntities db, int PartnerID, string code)
        {
            var dbResult = db.tbl_CUS_DOC_File.FirstOrDefault(d => d.IsDeleted == false && d.IDPartner == PartnerID && d.Code == code);
			if (dbResult == null || dbResult.IDPartner != PartnerID)
				return null; 
			else 
				return toDTO(dbResult);
			
        }

		public static bool put_CUS_DOC_File(AppEntities db, int PartnerID, int ID, DTO_CUS_DOC_File item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_DOC_File.Find(ID);
            if (dbitem != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Path = item.Path;							
				dbitem.Extension = item.Extension;							
				dbitem.IsApproved = item.IsApproved;							
				dbitem.ApprovedBy = item.ApprovedBy;							
				dbitem.ApprovedDate = item.ApprovedDate;							
				dbitem.FileSize = item.FileSize;							
				dbitem.FileVersion = item.FileVersion;							
				dbitem.IDDeTai = item.IDDeTai;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_File", dbitem.ModifiedDate, Username);
										
				
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_CUS_DOC_File",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_CUS_DOC_File post_CUS_DOC_File(AppEntities db, int PartnerID, DTO_CUS_DOC_File item, string Username)
        {
            tbl_CUS_DOC_File dbitem = new tbl_CUS_DOC_File();
            if (item != null)
            {							
				dbitem.Code = item.Code;							
				dbitem.Name = item.Name;							
				dbitem.Remark = item.Remark;							
				dbitem.Sort = item.Sort;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;							
				dbitem.Path = item.Path;							
				dbitem.Extension = item.Extension;							
				dbitem.IsApproved = item.IsApproved;							
				dbitem.ApprovedBy = item.ApprovedBy;							
				dbitem.ApprovedDate = item.ApprovedDate;							
				dbitem.FileSize = item.FileSize;							
				dbitem.FileVersion = item.FileVersion;							
				dbitem.IDDeTai = item.IDDeTai;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								
				dbitem.IDPartner = PartnerID;
				

                try
                {
					db.tbl_CUS_DOC_File.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_File", dbitem.ModifiedDate, Username);
										
									
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
					item.IDPartner = dbitem.IDPartner;
					
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_CUS_DOC_File",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_CUS_DOC_File(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_CUS_DOC_File.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_File", dbitem.ModifiedDate, Username);
										
				
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_CUS_DOC_File",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_CUS_DOC_File_Exists(AppEntities db, int id)
		{
			return db.tbl_CUS_DOC_File.Any(e => e.ID == id);
		}
		
		public static bool check_CUS_DOC_File_Exists(AppEntities db, string Code)
		{
			return db.tbl_CUS_DOC_File.Any(e => e.Code == Code);
		}
		
    }

}






