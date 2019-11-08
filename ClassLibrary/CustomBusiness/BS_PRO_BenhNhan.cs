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
                TenBenhNhan = s.tbl_CUS_HRM_BenhNhan.HoTen,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            });

        }
    }
}
