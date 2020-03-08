namespace DTOModel
{
    using System;
    public partial class DTO_PRO_HoiNghiHoiThao_DangKy
    {
        public string TenHoiNghi { get; set; }
        public string DiaDiem { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime? ThoiGianHetHan { get; set; }
        public int SoDeTaiDangKy { get; set; }
        public string TenNCV { get; set; }
        public string Error { get; set; }
        public bool CoTheDangKy { get; set; }
        public string ChoPhepDangKy { get; set; }
    }
}