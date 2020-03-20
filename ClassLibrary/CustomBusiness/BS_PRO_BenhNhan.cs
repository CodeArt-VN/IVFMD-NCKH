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
    public static partial class BS_PRO_BenhNhan
    {
        public static IQueryable<DTO_PRO_BenhNhan> get_PRO_BenhNhanByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_BenhNhan.AsQueryable();

            query = query.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false);

            return toDTOCustom(query);
        }

        public static IQueryable<DTO_PRO_BenhNhan> toDTOCustom(IQueryable<tbl_PRO_BenhNhan> query)
        {
            return query
            .Select(s => new DTO_PRO_BenhNhan()
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                IDBenhNhan = s.IDBenhNhan,
                MaBenhNhan = s.tbl_CUS_HRM_BenhNhan.MaBenhNhan,
                TenBenhNhan = s.tbl_CUS_HRM_BenhNhan.HoTen,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            });

        }

        public static DTO_PRO_BenhNhan save_PRO_BenhNhan(AppEntities db, DTO_PRO_BenhNhan item, string Username)
        {
            tbl_PRO_BenhNhan dbitem = new tbl_PRO_BenhNhan();
            if (item != null)
            {
                tbl_CUS_HRM_BenhNhan dbitem1 = new tbl_CUS_HRM_BenhNhan();
                dbitem1.MaBenhNhan = item.MaBenhNhan;
                dbitem1.HoTen = item.MaBenhNhan;
                dbitem1.GioiTinh = item.GioiTinh;
                dbitem1.IsDisabled = item.IsDisabled;
                dbitem1.IsDeleted = item.IsDeleted;

                dbitem1.CreatedBy = Username;
                dbitem1.CreatedDate = DateTime.Now;

                dbitem1.ModifiedBy = Username;
                dbitem1.ModifiedDate = DateTime.Now;

                db.tbl_CUS_HRM_BenhNhan.Add(dbitem1);
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_BenhNhan", DateTime.Now, Username);

                dbitem.IDDeTai = item.IDDeTai;
                dbitem.IDBenhNhan = dbitem1.ID;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;


                try
                {
                    db.tbl_PRO_BenhNhan.Add(dbitem);
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BenhNhan", DateTime.Now, Username);


                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_PRO_BenhNhan", e);
                    item = null;
                }
            }
            return item;
        }

    }
}
