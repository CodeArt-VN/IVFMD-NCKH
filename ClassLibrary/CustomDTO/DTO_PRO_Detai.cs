using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    using System;
    public partial class DTO_PRO_DeTai
    {
        public string TrangThai_HDDD { get; set; }
        public string TrangThai_HDKH { get; set; }
        public string TrangThai_HRCO { get; set; }
        public string TrangThai_NghiemThu { get; set; }
        public List<DTO_PRO_DeTai_TrangThai> ListFormStatus { get; set; }
        public string ActionCode { get; set; }
        public string NCVChinh { get; set; }
        public string ChuNhiemDeTai { get; set; }
    }

    public class DTO_PRO_DeTai_TrangThai
    {
        public int Index { get; set; }
        public int Type { get; set; }
        public string TrangThai { get; set; }
        public string TrangThaiCode { get; set; }
        public string FormCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class DTO_PRO_DeTai_PrinterData
    {
        public int id { get; set; }
        public int type { get; set; }
        public string htmlContent { get; set; }
        public string htmlFooter { get; set; }
        public string htmlHeader { get; set; }
    }
}