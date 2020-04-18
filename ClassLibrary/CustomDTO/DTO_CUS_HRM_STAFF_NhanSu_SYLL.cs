using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_CUS_HRM_STAFF_NhanSu_SYLL
    {
        public List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon> ListTrinhDoChuyenMon { get; set; }
        public List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_KinhNghiem> ListKinhNghiem { get; set; }
        public bool IsCNDT { get; set; }
    }

    public class DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon
    {
        public string HocVi { get; set; }
        public string NamNhanBang { get; set; }
        public string ChuyenNganhDaoTao { get; set; }
    }

    public class DTO_CUS_HRM_STAFF_NhanSu_SYLL_KinhNghiem
    {
        public string TenDeTai { get; set; }
        public string NhiemVuCaNhan { get; set; }
        public string CoQuanChuTri { get; set; }
        public string NamBatDauKetThuc { get; set; }
    }
}
