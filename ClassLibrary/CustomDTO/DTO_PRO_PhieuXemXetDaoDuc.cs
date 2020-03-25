using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_PRO_PhieuXemXetDaoDuc : DTO_PRO_FORMBASE
    {
        public List<DTO_PRO_PhieuXemXetDaoDuc_ChuKy> CanKet_ListChuKy { get; set; }
        public List<DTO_PRO_PhieuXemXetDaoDuc_NCV> ListNCV { get; set; }
        public List<DTO_PRO_PhieuXemXetDaoDuc_CoQuan> ListCoQuan { get; set; }
    }

    public class DTO_PRO_PhieuXemXetDaoDuc_NCV
    {
        public string HoTen { get; set; }
        public string ChucDanh { get; set; }
        public string ChucVu { get; set; }
    }

    public class DTO_PRO_PhieuXemXetDaoDuc_CoQuan
    {
        public string CoQuan { get; set; }
        public bool DuocCapPhep { get; set; }
        public bool ChoCapPhep { get; set; }
        public bool ChuaXinPhep { get; set; }
        public bool GhiChuKhac { get; set; }
    }

    public class DTO_PRO_PhieuXemXetDaoDuc_ChuKy
    {
        public string BoMon { get; set; }
        public string NgayKy { get; set; }
        public string ThangKy { get; set; }
        public string NamKy { get; set; }
        public string HoTenVaChucDanh { get; set; }
    }
}
