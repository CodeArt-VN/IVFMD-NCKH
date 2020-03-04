namespace DTOModel
{
    using System;
    public partial class DTO_PRO_BaoCaoTienDoNghienCuu
    {
        public string Error { get; set; }
        public string TinhTrangNghienCuu { get; set; }
    }

    public class DTO_PRO_BaoCaoTienDoNghienCuu_DeTai
    {
        public string Error { get; set; }
        public int IDDeTai { get; set; }
        public string TenDeTai { get; set; }
        public string ChuNhiemDeTai { get; set; }
        public string NCVChinh { get; set; }
        public string NgayDuyetNghienCuu { get; set; }
        public string SoNCT { get; set; }
        public string ThoiGianTienHanh { get; set; }
        public int SoLanDaBaoCao { get; set; }
        public int CompletePercent { get; set; }
        public DateTime? LastReportDate { get; set; }
        public string LastReportBy { get; set; }
    }
}