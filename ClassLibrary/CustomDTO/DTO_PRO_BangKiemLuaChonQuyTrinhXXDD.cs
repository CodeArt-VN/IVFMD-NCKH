using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_PRO_BangKiemLuaChonQuyTrinhXXDD
    {
        public string HTMLPrint { get; set; }
        public DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaA PhanBa_A { get; set; }
        public DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaB PhanBa_B { get; set; }
        public DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanNam PhanNam { get; set; }
        public List<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac> NCVKhac { get; set; }
        public DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_MoTaNCYSH MoTaNCYSH { get; set; }
    }

    public class DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaA
    {
        public bool DuocPham { get; set; }
        public bool ChePhamSinhHoc { get; set; }
        public bool CacPhuongPhapChePham { get; set; }
        public bool CacThietBiYTe { get; set; }
        public bool PhuongPhapXaTri { get; set; }
        public bool PhuongPhapKhongDungThuoc { get; set; }
        public bool CacThuThuat { get; set; }
        public bool CacMauSinhHoc { get; set; }
        public bool DieuTraDichTeHoc { get; set; }
        public bool XaHoiHoc { get; set; }
    }

    public class DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaB
    {
        public bool GhiThongTin { get; set; }
        public bool NguoiKhongCoNangLucHanhVi { get; set; }
        public bool ViThanhNien { get; set; }
        public bool NguoiCoQuanHePhuThuoc { get; set; }
        public bool CacVanDeNhayCamVeVanHoa { get; set; }
        public bool GayDauDon { get; set; }
        public bool ChiTraKhuyenKhich { get; set; }
        public bool ThongTinNhayCam { get; set; }
        public bool BiMatCaNhan { get; set; }
        public bool TrachNhiemPhapLy { get; set; }
        public bool NguoiThieuSo { get; set; }
    }

    public class DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanNam
    {
        public bool ThuNghiemThuocThuNghiem { get; set; }
        public bool SuDungCongCuChuan { get; set; }
        public bool DeDangQuanLyNguyCo { get; set; }
        public bool NghienCuuLuongGia { get; set; }
        public bool NhieuCoQuanThamGia { get; set; }
        public bool XinGiaHan { get; set; }
    }

    public class DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac
    {
        public string ThongTin { get; set; }
    }

    public class DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_MoTaNCYSH
    {
        public string ThongTin { get; set; }
    }
}
