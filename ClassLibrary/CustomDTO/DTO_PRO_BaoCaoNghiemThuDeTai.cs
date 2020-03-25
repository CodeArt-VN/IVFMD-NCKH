using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_PRO_BaoCaoNghiemThuDeTai : DTO_PRO_FORMBASE
    {
        public List<DTO_PRO_BaoCaoNghiemThuDeTai_CanBo> ListCanBo { get; set; }
    }
    public class DTO_PRO_BaoCaoNghiemThuDeTai_CanBo
    {
        public string HocHamHoTen { get; set; }
        public string ChiuTrachNhiem { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
    }
}
