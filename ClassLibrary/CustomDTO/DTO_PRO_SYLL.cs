using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CustomDTO
{
    public partial class DTO_PRO_SYLL
    {
        public List<DTO_PRO_SYLL_TrinhDoChuyenMon> ListTrinhDoChuyenMon { get; set; }
        public List<DTO_PRO_SYLL_KinhNghiem> ListKinhNghiem { get; set; }
    }

    public class DTO_PRO_SYLL_TrinhDoChuyenMon
    {
        public string HocVi { get; set; }
        public string NamNhanBang { get; set; }
        public string ChuyenNganhDaoTao { get; set; }
    }

    public class DTO_PRO_SYLL_KinhNghiem
    {
        public string TenDeTai { get; set; }
        public string NhiemVuCaNhan { get; set; }
        public string CoQuanChuTri { get; set; }
        public string NamBatDauKetThuc { get; set; }
    }
}
