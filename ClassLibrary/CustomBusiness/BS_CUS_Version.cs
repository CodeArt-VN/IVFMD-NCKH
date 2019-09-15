
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

    public static partial class BS_CUS_Version
    {
        public static IQueryable<DTO_CUS_Version_View> get_CUS_Version(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings, bool Custom)
        {
            var query = db.tbl_CUS_Version
            .Where(d => d.IsDeleted == false && (d.IDPartner == PartnerID || d.IDPartner==null ));

            return query.Select(s => new DTO_CUS_Version_View() {
                Code = s.Code,
                VersionDate = s.VersionDate
            });

        }
        public static void update_CUS_Version(AppEntities db, int? PartnerID, string Code, DateTime VersionDate, string Username)
        {
            tbl_CUS_Version dbitem = db.tbl_CUS_Version.FirstOrDefault(d => d.IDPartner == PartnerID && d.Code == Code);

            bool isNewItem = dbitem == null;

            if (isNewItem)
            {
                dbitem = new tbl_CUS_Version();
                dbitem.IDPartner = PartnerID;
                dbitem.Code = Code;
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                db.tbl_CUS_Version.Add(dbitem);
            }
            
            dbitem.VersionDate = VersionDate;
            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            try
            {
                
                db.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("update_CUS_Version", e);
            }

        }
    }
}