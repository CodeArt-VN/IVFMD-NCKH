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
        public static IQueryable<DTO_CUS_DOC_File> ctoDTO(IQueryable<tbl_CUS_DOC_File> query)
        {
            return query
            .Select(s => new DTO_CUS_DOC_File()
            {
                IDFolder = s.tbl_CUS_DOC_FileInFolder.FirstOrDefault() == null ? null : s.tbl_CUS_DOC_FileInFolder.FirstOrDefault().IDFolder,
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
                TenDeTai = s.IDDeTai > 0 ? s.tbl_PRO_DeTai.TenTiengViet : "",
                CNDT = s.IDDeTai > 0 ? s.tbl_PRO_DeTai.tbl_CUS_HRM_STAFF_NhanSu1.Ho + " " + s.tbl_PRO_DeTai.tbl_CUS_HRM_STAFF_NhanSu1.Name : "",
                NCVChinh = s.IDDeTai > 0 ? s.tbl_PRO_DeTai.tbl_CUS_HRM_STAFF_NhanSu.Ho + " " + s.tbl_PRO_DeTai.tbl_CUS_HRM_STAFF_NhanSu.Name : "",
            }).OrderBy(o => o.Sort);
        }

        public static DTO_CUS_DOC_File ctoDTO(tbl_CUS_DOC_File dbResult)
        {
            if (dbResult != null)
            {
                return new DTO_CUS_DOC_File()
                {
                    IDFolder = dbResult.tbl_CUS_DOC_FileInFolder.FirstOrDefault() == null ? null : dbResult.tbl_CUS_DOC_FileInFolder.FirstOrDefault().IDFolder,
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
                };
            }
            else
                return null;
        }

        public static IQueryable<DTO_CUS_DOC_File> get_CUS_DOC_File(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings,  bool custom)
        {
            var query = db.tbl_CUS_DOC_File
            .Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);


            //Query keyword
            if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d => d.Name.Contains(keyword) || d.Code.Contains(keyword) || d.Remark.Contains(keyword));
            }

            //Query IDPartner (int)
            if (QueryStrings.Any(d => d.Key == "IDFolder") && (!QueryStrings.Any(d => d.Key == "Keywork") || string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value) ))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDFolder").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                {
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if(item == "null")
                    {
                        query = query.Where(d => !d.tbl_CUS_DOC_FileInFolder.Any());
                    }
                }
                if (IDs.Count > 0)
                    query = query.Where(d => d.tbl_CUS_DOC_FileInFolder.Any(c=> c.IDFolder.HasValue && IDs.Contains(c.IDFolder.Value)) );
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
                query = query.Where(d => d.Code == keyword);
            }

            //Query Name (string)
            if (QueryStrings.Any(d => d.Key == "Name") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Name").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Name").Value;
                query = query.Where(d => d.Name == keyword);
            }

            //Query Remark (string)
            if (QueryStrings.Any(d => d.Key == "Remark") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Remark").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Remark").Value;
                query = query.Where(d => d.Remark == keyword);
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
                query = query.Where(d => d.CreatedBy == keyword);
            }

            //Query ModifiedBy (string)
            if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d => d.ModifiedBy == keyword);
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
                query = query.Where(d => d.Path == keyword);
            }

            //Query Extension (string)
            if (QueryStrings.Any(d => d.Key == "Extension") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Extension").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Extension").Value;
                query = query.Where(d => d.Extension == keyword);
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
                query = query.Where(d => d.ApprovedBy == keyword);
            }

            //Query ApprovedDate (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ApprovedDateFrom") && QueryStrings.Any(d => d.Key == "ApprovedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ApprovedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ApprovedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ApprovedDate && d.ApprovedDate <= toDate);

            //Query FileSize (double)


            return ctoDTO(query);

        }

        public static DTO_CUS_DOC_File get_CUS_DOC_File(AppEntities db, int PartnerID, int id, bool custom)
        {
            var dbResult = db.tbl_CUS_DOC_File.Find(id);

            if (dbResult == null || dbResult.IDPartner != PartnerID)
                return null;
            else
                return ctoDTO(dbResult);

        }

        public static bool put_CUS_DOC_File(AppEntities db, int PartnerID, int ID, DTO_CUS_DOC_File item, string Username, bool custom)
        {
            bool result = false;
            var dbitem = db.tbl_CUS_DOC_File.Find(ID);
            string changes = "";
            string oldName = "";
            if (dbitem != null)
            {
                string format = "\"{0}\": {{\"old\":\"{1}\", \"new\":\"{2}\"}},";
                if (dbitem.Code != item.Code)
                    changes += string.Format(format, "Code", dbitem.Code, item.Code);
                dbitem.Code = item.Code;

                if (dbitem.Name != item.Name)
                    changes += string.Format(format, "Name", dbitem.Name, item.Name);
                
                oldName = dbitem.Name;
                dbitem.Name = item.Name;

                if (dbitem.Remark != item.Remark)
                    changes += string.Format(format, "Remark", dbitem.Remark, item.Remark);
                dbitem.Remark = item.Remark;

                if (dbitem.FileVersion != item.FileVersion)
                    changes += string.Format(format, "FileVersion", dbitem.FileVersion, item.FileVersion);
                dbitem.FileVersion = item.FileVersion;

                dbitem.Sort = item.Sort;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;
                dbitem.ModifiedBy = item.ModifiedBy;
                dbitem.ModifiedDate = item.ModifiedDate;

                if (dbitem.Path != item.Path)
                    changes += string.Format(format, "Path", dbitem.Path, item.Path);
                dbitem.Path = item.Path;

                if (dbitem.Extension != item.Extension)
                    changes += string.Format(format, "Extension", dbitem.Extension, item.Extension);
                dbitem.Extension = item.Extension;

                if (dbitem.FileSize != item.FileSize)
                    changes += string.Format(format, "FileSize", dbitem.FileSize, item.FileSize);
                dbitem.FileSize = item.FileSize;

                if (dbitem.IsApproved != item.IsApproved)
                    changes += string.Format(format, "IsApproved", dbitem.IsApproved, item.IsApproved);
                dbitem.IsApproved = item.IsApproved;

                if (dbitem.ApprovedBy != item.ApprovedBy)
                    changes += string.Format(format, "ApprovedBy", dbitem.ApprovedBy, item.ApprovedBy);
                dbitem.ApprovedBy = item.ApprovedBy;

                dbitem.ApprovedDate = item.ApprovedDate;

                

                

                

                try
                {
                    var folder = dbitem.tbl_CUS_DOC_FileInFolder.FirstOrDefault();

                    if (folder == null && item.IDFolder != null)
                    {
                        dbitem.tbl_CUS_DOC_FileInFolder.Add(new tbl_CUS_DOC_FileInFolder() { IDFolder = item.IDFolder, IDPartner = item.IDPartner, CreatedBy = dbitem.CreatedBy, CreatedDate = dbitem.CreatedDate, ModifiedBy = dbitem.ModifiedBy, ModifiedDate = dbitem.ModifiedDate });
                    }
                    else if(folder != null && folder.IDFolder != item.IDFolder && item.IDFolder != null) {
                        folder.IDFolder = item.IDFolder;
                    }
                    else if(folder!= null && item.IDFolder == null)
                    {
                        db.tbl_CUS_DOC_FileInFolder.Remove(folder);
                    }

                    //check change to save activities

                    tbl_CUS_DOC_File_Actitity activity = new tbl_CUS_DOC_File_Actitity();
                    if (!db.tbl_CUS_DOC_File_Actitity.Any(d => d.IDPartner == PartnerID && d.IDFile == dbitem.ID))
                    {
                        activity.Code = "Add";
                        activity.Name = dbitem.Name;
                        changes = string.Format(format, "Name", "", "Thêm tài liệu mới");
                        
                    }
                    else if(changes!="")
                    {
                        activity.Code = "Update";
                        activity.Name = oldName;
                        
                    }
                    if(!string.IsNullOrEmpty(changes))
                        activity.Remark = "{" + changes.Substring(0, changes.Length - 1) + "}";

                    activity.IDFile = dbitem.ID;
                    activity.IDPartner = dbitem.IDPartner;
                    activity.CreatedBy = Username;
                    activity.CreatedDate = DateTime.Now;
                    activity.ModifiedBy = dbitem.ModifiedBy;
                    activity.ModifiedDate = dbitem.ModifiedDate;

                    if (!string.IsNullOrEmpty(activity.Code))
                    {
                        db.tbl_CUS_DOC_File_Actitity.Add(activity);
                    }


                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_File", dbitem.ModifiedDate, Username);




                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("put_CUS_DOC_File", e);
                    result = false;
                }
            }
            return result;
        }

        public static DTO_CUS_DOC_File post_CUS_DOC_File(AppEntities db, int PartnerID, DTO_CUS_DOC_File item, string Username, bool custom)
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
                dbitem.IsHidden = item.IsHidden;

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



                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                    item.IDPartner = dbitem.IDPartner;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_CUS_DOC_File", e);
                    item = null;
                }
            }
            return item;
        }




    }
}
