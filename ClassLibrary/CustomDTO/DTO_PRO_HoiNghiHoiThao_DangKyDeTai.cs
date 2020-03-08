namespace DTOModel
{
    using System;
    public partial class DTO_PRO_HoiNghiHoiThao_DangKyDeTai
    {
        public string TenNCV { get; set; }
        public string TenHoiNghi { get; set; }
        public string DiaDiem { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime? ThoiGianHetHan { get; set; }
        public string HinhThucDangKy { get; set; }
        public string TrangThai { get; set; }
        public string UploadBaiAbstract { get; set; }
        public string UploadBaiFulltext { get; set; }
        public string Error { get; set; }
        public int TongSoNguoiDangKy { get; set; }
        public int TongSoDeTaiDangKy { get; set; }
        public int Sort { get; set; }
    }
}