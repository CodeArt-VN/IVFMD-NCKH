using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_CAT_LinhVuc
    {
        public static IQueryable<DTO_CAT_LinhVuc> toDTOCustom(IQueryable<tbl_CAT_LinhVuc> query)
        {
            return query
            .Select(s => new DTO_CAT_LinhVuc()
            {
                ID = s.ID,
                ParentID = s.ParentID,
                ParentName = s.ParentID > 0 ? s.tbl_CAT_LinhVuc2.Name : "",
                Name = s.Name,
                Note = s.Note,
                Sort = s.Sort,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            }).OrderBy(o => o.Sort);

        }

        public static IQueryable<DTO_CAT_LinhVuc> get_CAT_LinhVucCustom(AppEntities db, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_CAT_LinhVuc.Where(d => d.IsDeleted == false);

            //Query keyword
            if (QueryStrings.Any(d => d.Key == "Keywork") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Keywork").Value;
                query = query.Where(d => d.Name.Contains(keyword));
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

            //Query ParentID (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "ParentID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ParentID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ParentID));
            }

            //Query Name (string)
            if (QueryStrings.Any(d => d.Key == "Name") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Name").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Name").Value;
                query = query.Where(d => d.Name == keyword);
            }

            //Query Note (string)
            if (QueryStrings.Any(d => d.Key == "Note") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Note").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Note").Value;
                query = query.Where(d => d.Note == keyword);
            }

            //Query Sort (int)
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

            //Query CreatedDate (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

            //Query CreatedBy (string)
            if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d => d.CreatedBy == keyword);
            }

            //Query ModifiedDate (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

            //Query ModifiedBy (string)
            if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d => d.ModifiedBy == keyword);
            }


            return toDTOCustom(query);

        }

        public static bool put_CAT_LinhVucCustom(AppEntities db, int ID, DTO_CAT_LinhVuc item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_CAT_LinhVuc.Find(ID);
            if (dbitem != null)
            {
                bool isChangeParent = dbitem.ParentID != item.ParentID;
                dbitem.ParentID = item.ParentID;
                dbitem.Name = item.Name;
                dbitem.Note = item.Note;
                dbitem.Sort = item.Sort;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    var folder = db.tbl_CUS_DOC_Folder.FirstOrDefault(c => c.IDLinhVuc == ID);
                    if (folder == null)
                    {
                        folder = new tbl_CUS_DOC_Folder
                        {
                            CreatedBy = Username,
                            CreatedDate = DateTime.Now,
                            IDLinhVuc = ID,
                        };
                        db.tbl_CUS_DOC_Folder.Add(folder);
                    }
                    folder.IDPartner = 1;
                    folder.Name = item.Name;
                    folder.Sort = item.Sort;
                    folder.ModifiedBy = Username;
                    folder.ModifiedDate = DateTime.Now;
                    if (item.ParentID == null)
                        folder.IDParent = null;

                    if (isChangeParent && item.ParentID > 0)
                    {
                        var folderParent = db.tbl_CUS_DOC_Folder.FirstOrDefault(c => c.IDLinhVuc == item.ParentID);
                        if (folderParent != null)
                            folder.IDParent = folderParent.ID;
                    }

                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_LinhVuc", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("put_CAT_LinhVuc", e);
                    result = false;
                }
            }
            return result;
        }

        public static DTO_CAT_LinhVuc post_CAT_LinhVucCustom(AppEntities db, DTO_CAT_LinhVuc item, string Username)
        {
            tbl_CAT_LinhVuc dbitem = new tbl_CAT_LinhVuc();
            if (item != null)
            {
                dbitem.ParentID = item.ParentID;
                dbitem.Name = item.Name;
                dbitem.Note = item.Note;
                dbitem.Sort = item.Sort;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;


                try
                {
                    db.tbl_CAT_LinhVuc.Add(dbitem);
                    db.SaveChanges();

                    // Tạo thư mục
                    var folder = db.tbl_CUS_DOC_Folder.FirstOrDefault(c => c.IDLinhVuc == dbitem.ID);
                    if (folder == null)
                    {
                        folder = new tbl_CUS_DOC_Folder
                        {
                            CreatedBy = Username,
                            CreatedDate = DateTime.Now,
                            IDLinhVuc = dbitem.ID,
                        };
                        db.tbl_CUS_DOC_Folder.Add(folder);
                    }
                    folder.IDPartner = 1;
                    folder.Name = item.Name;
                    folder.Sort = item.Sort;
                    folder.ModifiedBy = Username;
                    folder.ModifiedDate = DateTime.Now;

                    if (item.ParentID > 0)
                    {
                        var folderParent = db.tbl_CUS_DOC_Folder.FirstOrDefault(c => c.IDLinhVuc == item.ParentID);
                        if (folderParent != null)
                            folder.IDParent = folderParent.ID;
                    }

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_CAT_LinhVuc", DateTime.Now, Username);
                    db.SaveChanges();

                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_CAT_LinhVuc", e);
                    item = null;
                }
            }
            return item;
        }

    }
}
