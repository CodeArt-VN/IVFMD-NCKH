using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_PRO_ThuyetMinhDeTai
    {
        public DTO_PRO_ThuyetMinhDeTai_NhanLucNghienCuu ChuNhiemDeTai { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_NhanLucNghienCuu> ListNhanLucNghienCuu { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_GioiThieuChuyenGia> ListGioiThieuChuyenGia { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien> ListKeHoachThucHien { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap> ListBienSo { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi> ListKinhPhiTongHop { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_KinhPhi> ListKinhPhiCongLaoDong { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_KinhPhi> ListKinhPhiNguyenVatLieu { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_KinhPhi> ListKinhPhiThietBi { get; set; }
        public List<DTO_PRO_ThuyetMinhDeTai_KinhPhi> ListKinhPhiKhac { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien
    {
        public static string VietDeCuong = "Viết đề cương";
        public static string ThongQuaHDKH = "Thông qua Hội đồng khoa học và Hội đồng đạo đức";
        public static string ThuThapSoLieu = "Thu thập số liệu";
        public static string PhanTichSoLieuGiuaKy = "Phân tích số liệu giữa kỳ";
        public static string PhanTichSoLieuCuoiCung = "Phân tích số liệu cuối cùng";
        public static string VietBaiDangBaoTrongNuoc = "Viết bài đăng báo (Tạp chí trong nước)";
        public static string NghiemThuDeTai = "Nghiệm thu đề tài";
        public static string VietBaiDangBaoQuocTe = "Viết bài đăng báo (tạp chí quốc tế)";

        public DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien()
        {

        }
        public DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(string noidung)
        {
            this.NoiDung = noidung;
        }

        public string NoiDung { get; set; }
        public string ThoiGianThucHien { get; set; }
        public string DuKienKetQua { get; set; }
        public string NguoiThucHien { get; set; }
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
        public enum BienSo
        {
            BSNen = 0,
            BSDocLap = 1,
            BSPhuThuoc = 2
        }
        public string Ten { get; set; }
        public string PhanLoai { get; set; }
        /// <summary>
        /// 0:Biến số nền
        /// 1:Biến số độc lập
        /// 2:Biến phụ thuộc
        /// </summary>
        public int LoaiBienSo { get; set; }
        public string GiaTri { get; set; }
        public string CachThuThap { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi
    {
        public enum NoiDungKinhPhi
        {
            Khoan1TraCongLaoDong = 1,
            Khoan2NguyenLieu,
            Khoan3ThietBi,
            Khoan4Khac,
            Cong = 0
        }
        public static string Khoan1TraCongLaoDong = "Khoản 1: Trả công lao động";
        public static string Khoan2NguyenLieu = "Khoản 2: Nguyên vật liệu, năng lượng";
        public static string Khoan3ThietBi = "Khoản 3: Thiết bị, máy móc";
        public static string Khoan4Khac = "Khoản 4: Chi khác";
        public static string Cong = "Cộng:";

        public DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi()
        {

        }
        public DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi(NoiDungKinhPhi loaiKinhPhi)
        {
            this.LoaiKinhPhi = loaiKinhPhi;
            switch (loaiKinhPhi)
            {
                case NoiDungKinhPhi.Khoan1TraCongLaoDong:
                    this.NoiDung = Khoan1TraCongLaoDong;
                    break;
                case NoiDungKinhPhi.Khoan2NguyenLieu:
                    this.NoiDung = Khoan2NguyenLieu;
                    break;
                case NoiDungKinhPhi.Khoan3ThietBi:
                    this.NoiDung = Khoan3ThietBi;
                    break;
                case NoiDungKinhPhi.Khoan4Khac:
                    this.NoiDung = Khoan4Khac;
                    break;
                case NoiDungKinhPhi.Cong:
                    this.NoiDung = Cong;
                    break;
            }
        }

        public NoiDungKinhPhi LoaiKinhPhi { get; set; }
        public string NoiDung { get; set; }
        public string KinhPhi { get; set; }
        public string KhoanChi { get; set; }
        public string PhanTram { get; set; }
    }

    public class DTO_PRO_ThuyetMinhDeTai_KinhPhi
    {
        public enum NoiDungKinhPhi
        {
            Cong = 0,
            Khoan1VietDeCuong = 1,
            Khoan2ThuThapDL,
            Khoan3XLVaPTSoLieu,
            Khoan4DieuPhoiNghienCuu,
            Khoan5VietBaiDangBao,

            Khoan1NguyenVatLieu = 11,
            Khoan2DungCuPhuTungReTien,
            Khoan3NangLuong,
            Khoan4SachTaiLieu,

            Khoan1MuaThietBi = 21,
            Khoan2ThueThietBi,
            Khoan3VanChuyenLapDat,

            Khoan1HopTacTrongNuoc = 31,
            Khoan2HDDD,
            Khoan3HDKH,
            Khoan4DuPhong
        }
        public static string Cong = "Cộng:";
        public static string VietDeCuong = "Viết đề cương nghiên cứu";
        public static string ThuThapDL = "Thu thập dữ liệu nghiên cứu";
        public static string XLVaPTSoLieu = "Xử lý và phân tích số liệu";
        public static string DieuPhoiNghienCuu = "Điều phối nghiên cứu";
        public static string VietBaiDangBao = "Viết bài đăng báo và báo cáo tổng kết";


        public static string NguyenVatLieu = "Nguyên, vật liệu";
        public static string DungCuPhuTungReTien = "Dụng cụ, phụ tùng, vật rẻ tiền mau hỏng";
        public static string NangLuong = "Năng lượng, nhiên liệu";
        public static string SachTaiLieu = "Mua sách, tài liệu, số liệu";


        public static string MuaThietBi = "Mua thiết bị";
        public static string ThueThietBi = "Thuê thiết bị";
        public static string VanChuyenLapDat = "Vận chuyển lắp đặt";


        public static string HopTacTrongNuoc = "Hợp tác trong nước";
        public static string HDDD = "Hội đồng đạo đức";
        public static string HDKH = "Hội đồng khoa học";
        public static string DuPhong = "Dự phòng (Đăng ký sở hữu trí tuệ, tổ chức hội thảo, liên lạc, văn phòng phẩm, in ấn, dịch tài liệu…)";

        public DTO_PRO_ThuyetMinhDeTai_KinhPhi()
        {

        }
        public DTO_PRO_ThuyetMinhDeTai_KinhPhi(NoiDungKinhPhi kinhPhi)
        {
            this.LoaiKinhPhi = kinhPhi;
            switch (kinhPhi)
            {
                case NoiDungKinhPhi.Cong:
                    this.NoiDung = Cong;
                    break;

                case NoiDungKinhPhi.Khoan1VietDeCuong:
                    this.NoiDung = VietDeCuong;
                    break;
                case NoiDungKinhPhi.Khoan2ThuThapDL:
                    this.NoiDung = ThuThapDL;
                    break;
                case NoiDungKinhPhi.Khoan3XLVaPTSoLieu:
                    this.NoiDung = XLVaPTSoLieu;
                    break;
                case NoiDungKinhPhi.Khoan4DieuPhoiNghienCuu:
                    this.NoiDung = DieuPhoiNghienCuu;
                    break;
                case NoiDungKinhPhi.Khoan5VietBaiDangBao:
                    this.NoiDung = VietBaiDangBao;
                    break;

                case NoiDungKinhPhi.Khoan1NguyenVatLieu:
                    this.NoiDung = NguyenVatLieu;
                    break;
                case NoiDungKinhPhi.Khoan2DungCuPhuTungReTien:
                    this.NoiDung = DungCuPhuTungReTien;
                    break;
                case NoiDungKinhPhi.Khoan3NangLuong:
                    this.NoiDung = NangLuong;
                    break;
                case NoiDungKinhPhi.Khoan4SachTaiLieu:
                    this.NoiDung = SachTaiLieu;
                    break;

                case NoiDungKinhPhi.Khoan1MuaThietBi:
                    this.NoiDung = MuaThietBi;
                    break;
                case NoiDungKinhPhi.Khoan2ThueThietBi:
                    this.NoiDung = ThueThietBi;
                    break;
                case NoiDungKinhPhi.Khoan3VanChuyenLapDat:
                    this.NoiDung = VanChuyenLapDat;
                    break;

                case NoiDungKinhPhi.Khoan1HopTacTrongNuoc:
                    this.NoiDung = HopTacTrongNuoc;
                    break;
                case NoiDungKinhPhi.Khoan2HDDD:
                    this.NoiDung = HDDD;
                    break;
                case NoiDungKinhPhi.Khoan3HDKH:
                    this.NoiDung = HDKH;
                    break;
                case NoiDungKinhPhi.Khoan4DuPhong:
                    this.NoiDung = DuPhong;
                    break;
            }
        }

        public NoiDungKinhPhi LoaiKinhPhi { get; set; }
        public string NoiDung { get; set; }
        public string KinhPhi { get; set; }
        public string KhoanChi { get; set; }
        public string GhiChu { get; set; }
    }
}
