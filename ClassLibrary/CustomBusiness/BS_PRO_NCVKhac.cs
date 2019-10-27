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
    public static partial class BS_PRO_NCVKhac
    {
        public static IQueryable<DTO_PRO_NCVKhac> get_PRO_NCVKhacByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_NCVKhac.AsQueryable();

            query = query.Where(d => d.IDDeTai == deTaiId);

            return toDTO(query);
        }
    }
}
