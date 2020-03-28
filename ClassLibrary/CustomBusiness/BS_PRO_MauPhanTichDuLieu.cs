using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace BaseBusiness
{
    public static partial class BS_PRO_MauPhanTichDuLieu
    {
        public static DTO_PRO_MauPhanTichDuLieu get_PRO_MauPhanTichDuLieuByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_MauPhanTichDuLieu.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false).Select(s => new
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                JSON_DacDiemNen = s.JSON_DacDiemNen,
                s.JSON_ChuKyChuyenPhoi,
                s.JSON_KetQuaThai,
                s.JSON_KichThichBuongTrung,
                s.JSON_LaBo,
                s.JSON_BienSoKhac,
                HTML = s.HTML,
                FormConfig = s.FormConfig,
                IsDisabled = s.tbl_PRO_DeTai.IsDisabledHRCO ?? false,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            }).FirstOrDefault();

            if (query != null)
            {
                DTO_PRO_MauPhanTichDuLieu item = new DTO_PRO_MauPhanTichDuLieu
                {
                    ID = query.ID,
                    IDDeTai = query.IDDeTai,
                    JSON_BienSoKhac = query.JSON_BienSoKhac,
                    BienSoKhac = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_MauPhanTichDuLieu_BienSoKhac>(query.JSON_BienSoKhac),
                    JSON_DacDiemNen = query.JSON_DacDiemNen,
                    DacDiemNen = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_MauPhanTichDuLieu_DacDiemNen>(query.JSON_DacDiemNen),
                    JSON_ChuKyChuyenPhoi = query.JSON_ChuKyChuyenPhoi,
                    ChuKyChuyenPhoi = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_MauPhanTichDuLieu_ChuKyChuyenPhoi>(query.JSON_ChuKyChuyenPhoi),
                    JSON_KetQuaThai = query.JSON_KetQuaThai,
                    KetQuaThai = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_MauPhanTichDuLieu_KetQuaThai>(query.JSON_KetQuaThai),
                    JSON_KichThichBuongTrung = query.JSON_KichThichBuongTrung,
                    KichThichBuongTrung = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_MauPhanTichDuLieu_KichThichBuongTrung>(query.JSON_KichThichBuongTrung),
                    JSON_LaBo = query.JSON_LaBo,
                    LaBo = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_MauPhanTichDuLieu_LaBo>(query.JSON_LaBo),
                    HTML = query.HTML,
                    FormConfig = query.FormConfig,
                    IsDisabled = query.IsDisabled,
                    IsDeleted = query.IsDeleted,
                    CreatedDate = query.CreatedDate,
                    CreatedBy = query.CreatedBy,
                    ModifiedDate = query.ModifiedDate,
                    ModifiedBy = query.ModifiedBy,
                };

                return item;
            }
            else
            {
                DTO_PRO_MauPhanTichDuLieu item = new DTO_PRO_MauPhanTichDuLieu
                {
                    IDDeTai = deTaiId,
                    KetQuaThai = new DTO_PRO_MauPhanTichDuLieu_KetQuaThai(),
                    DacDiemNen = new DTO_PRO_MauPhanTichDuLieu_DacDiemNen(),
                    KichThichBuongTrung = new DTO_PRO_MauPhanTichDuLieu_KichThichBuongTrung(),
                    LaBo = new DTO_PRO_MauPhanTichDuLieu_LaBo(),
                    ChuKyChuyenPhoi = new DTO_PRO_MauPhanTichDuLieu_ChuKyChuyenPhoi(),
                    BienSoKhac = new DTO_PRO_MauPhanTichDuLieu_BienSoKhac()
                };
                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == deTaiId);
                if (detai != null)
                    item.IsDisabled = detai.IsDisabledHRCO ?? false;

                return item;
            }
            return null;
        }
    }
}
