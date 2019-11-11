using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_PRO_ThuyetMinhDeTai
    {
        public List<DTO_PRO_ThuyetMinhDeTai_NhanLucNghienCuu> ListNhanLucNghienCuu { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_GioiThieuChuyenGia> ListGioiThieuChuyenGia { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap> ListBienSoNen { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap> ListBienSoDocLap { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap> ListBienSoPhuThuoc { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_NhanLucNghienCuu
    {
        public string TT { get; set; }
        public string HoTen { get; set; }
        public string DonVi { get; set; }
        public string SoThangLamViec { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_GioiThieuChuyenGia
    {
        public string TT { get; set; }
        public string HoTen { get; set; }
        public string HuongNghienCuu { get; set; }
        public string CoQuan { get; set; }
        public string DienThoai { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap
    {
        public string Ten { get; set; }
        public string PhanLoai { get; set; }
        public string GiaTri { get; set; }
        public string CachThuThap { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi
    {
        public string TraCongLaoDong_KinhPhi { get; set; }
        public string TraCongLaoDong_KhoanChi { get; set; }
        public string TraCongLaoDong_PhanTram { get; set; }

        public string NguyenVatLieu_KinhPhi { get; set; }
        public string NguyenVatLieu_KhoanChi { get; set; }
        public string NguyenVatLieu_PhanTram { get; set; }

        public string ThietBi_KinhPhi { get; set; }
        public string ThietBi_KhoanChi { get; set; }
        public string ThietBi_PhanTram { get; set; }

        public string ChiKhac_KinhPhi { get; set; }
        public string ChiKhac_KhoanChi { get; set; }
        public string ChiKhac_PhanTram { get; set; }

        public string TongCong_KinhPhi { get; set; }
        public string TongCong_KhoanChi { get; set; }
        public string TongCong_PhanTram { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_CongLaoDong
    {
        public string VietDeCuong_KinhPhi { get; set; }
        public string VietDeCuong_KhoanChi { get; set; }
        public string VietDeCuong_GhiChu { get; set; }

        public string ThuThapDuLieu_KinhPhi { get; set; }
        public string ThuThapDuLieu_KhoanChi { get; set; }
        public string ThuThapDuLieu_GhiChu { get; set; }

        public string XuLyPhanTich_KinhPhi { get; set; }
        public string XuLyPhanTich_KhoanChi { get; set; }
        public string XuLyPhanTich_GhiChu { get; set; }

        public string DieuPhoiNghienCuu_KinhPhi { get; set; }
        public string DieuPhoiNghienCuu_KhoanChi { get; set; }
        public string DieuPhoiNghienCuu_GhiChu { get; set; }

        public string VietBaiBao_KinhPhi { get; set; }
        public string VietBaiBao_KhoanChi { get; set; }
        public string VietBaiBao_GhiChu { get; set; }

        public string TongCong_KinhPhi { get; set; }
        public string TongCong_KhoanChi { get; set; }
        public string TongCong_GhiChu { get; set; }
    }
}
