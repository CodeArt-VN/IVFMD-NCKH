using ClassLibrary;
using DTOModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_PRO_BangKiemLuaChonQuyTrinhXXDD
    {
        public static DTO_PRO_BangKiemLuaChonQuyTrinhXXDD get_PRO_BangKiemLuaChonQuyTrinhXXDDCustom(AppEntities db, int idDeTai)
        {
            var query = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Where(d => d.IDDeTai == idDeTai && d.IsDeleted == false).Select(s => new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD
            {
                
            }).FirstOrDefault();
       
            if (query == null)
            {
                //New
                query = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD
                {
                    IDDeTai = idDeTai
                };

                query.NCVKhac = new List<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac>() { new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac() };
                query.PhanBa_A = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaA();
                query.PhanBa_B = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaB();
                query.PhanNam = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanNam();
                query.MoTaNCYSH = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_MoTaNCYSH();
    }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.PhanBa_A_JSON))
                {
                    query.PhanBa_A = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaA>(query.PhanBa_A_JSON);
                }
                if (!string.IsNullOrWhiteSpace(query.PhanBa_B_JSON))
                {
                    query.PhanBa_B = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaB>(query.PhanBa_B_JSON);
                }
                if (!string.IsNullOrWhiteSpace(query.PhanNam_JSON))
                {
                    query.PhanNam = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanNam>(query.PhanNam_JSON);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_MoTaNCYSH))
                {
                    query.MoTaNCYSH = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_MoTaNCYSH>(query.JSON_MoTaNCYSH);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NCVKhac))
                {
                    query.NCVKhac = JsonConvert.DeserializeObject<List<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac>>(query.JSON_NCVKhac);
                }
            }

            return query;
        }
    }
}
