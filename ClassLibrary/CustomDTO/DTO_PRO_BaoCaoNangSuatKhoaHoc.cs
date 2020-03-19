namespace DTOModel
{
    using System;
    public partial class DTO_PRO_BaoCaoNangSuatKhoaHoc
    {
        public string TenSite { get; set; }
        public string TenNhom { get; set; }
        public string TenKinhPhi { get; set; }
        public string NCVChinh { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string Error { get; set; }
        public string GhiChuKinhPhi { get; set; }
        public bool IsKinhPhiManual { get; set; }
        public int Sort { get; set; }
    }
}