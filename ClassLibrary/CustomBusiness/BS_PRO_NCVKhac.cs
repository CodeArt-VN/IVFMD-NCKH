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

            query = query.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false);

            return toDTOCustom(query);
        }

        public static IQueryable<DTO_PRO_NCVKhac> toDTOCustom(IQueryable<tbl_PRO_NCVKhac> query)
        {
            return query
            .Select(s => new DTO_PRO_NCVKhac()
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                IDNCV = s.IDNCV,
                TenNCV = s.tbl_CUS_HRM_STAFF_NhanSu.Ho + " " + s.tbl_CUS_HRM_STAFF_NhanSu.Ten,
                ChucDanh = s.ChucDanh,
                ChucVu = s.ChucVu,
                IsCanView = s.IsCanView,
                IsCanChange = s.IsCanChange,
                IsCanApprove = s.IsCanApprove,
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
