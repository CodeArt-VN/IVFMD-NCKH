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

    public static partial class BS_CUS_DOC_Folder
    {
        public static List<DTO_CUS_DOC_RPT_Folder> RPT_FileInFolder(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_CUS_DOC_File
                .Where(d => d.IsDeleted == false && d.IDPartner == PartnerID)
                .Select(s => new {
                    s.ID,
                    IDFolder = s.tbl_CUS_DOC_FileInFolder.Any()? s.tbl_CUS_DOC_FileInFolder.FirstOrDefault().IDFolder : null,
                    s.IsApproved,
                    s.ApprovedBy
                }).ToList();
            
            return
            query.GroupBy(g => g.IDFolder)
            .Select(s => new DTO_CUS_DOC_RPT_Folder()
            {
                ID = s.Key,
                CountFile = s.Count(),
                CountApproved = s.Count(d=>d.IsApproved),
                CountWaitApprove = s.Count(d => d.ApprovedBy == "Chờ duyệt"),

            }).ToList();


            //var results = ctx.Rs.Where(r => r.QK != null)
            //.GroupBy(r => r.QK)
            //.Select(gr => new { Key = (int)gr.Key, Count = gr.Count() }
            //.ToList();

            //https://stackoverflow.com/questions/15571878/entity-framework-linq-query-with-order-by-and-group-by
            //https://stackoverflow.com/questions/11564311/sql-to-entity-framework-count-group-by

        }

        public static List<DTO_CUS_DOC_RPT_FileExtention> RPT_FileByType(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_CUS_DOC_File
                .Where(d => d.IsDeleted == false && d.IDPartner == PartnerID)
                .Select(s => new {
                    s.ID,
                    s.IsApproved,
                    s.Extension,
                    s.FileSize,
                }).ToList();

            return
            query.GroupBy(g => g.Extension)
            .Select(s => new DTO_CUS_DOC_RPT_FileExtention()
            {
                Extension = s.Key,
                CountFile = s.Count(),
                CountApproved = s.Count(d => d.IsApproved)
            }).ToList();
            
        }

        public static string delete_CUS_DOC_FolderCustom(AppEntities db, int ID, string Username)
        {
            string result = string.Empty;
            var dbitem = db.tbl_CUS_DOC_Folder.Find(ID);
            if (dbitem != null)
            {

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
                dbitem.IsDeleted = true;

                if (dbitem.IDLinhVuc > 0)
                    result = "Không được xóa thư mục Lĩnh vực";

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_CUS_DOC_Folder", dbitem.ModifiedDate, Username);




                    
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("delete_CUS_DOC_Folder", e);
                    result = e.InnerException.Message;
                }
            }
            return result;
        }


    }
}
