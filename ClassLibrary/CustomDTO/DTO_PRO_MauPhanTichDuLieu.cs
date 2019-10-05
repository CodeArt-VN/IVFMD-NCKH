using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CustomDTO
{
    public partial class DTO_PRO_MauPhanTichDuLieu
    {
        public DTO_PRO_MauPhanTichDuLieu_DacDiemNen DacDiemNen { get; set; }
        public DTO_PRO_MauPhanTichDuLieu_KichThichBuongTrung KichThichBuongTrung { get; set; }
        public DTO_PRO_MauPhanTichDuLieu_LaBo LaBo { get; set; }
        public DTO_PRO_MauPhanTichDuLieu_ChuKyChuyenPhoi ChuKyChuyenPhoi { get; set; }
        public DTO_PRO_MauPhanTichDuLieu_KetQuaThai KetQuaThai { get; set; }
        public DTO_PRO_MauPhanTichDuLieu_BienSoKhac BienSoKhac { get; set; }
    }

    public class DTO_PRO_MauPhanTichDuLieu_DacDiemNen
    {
        public bool TuoiVo { get; set; }
        public bool BMI { get; set; }
        public bool AMHVo { get; set; }
        public bool AFC { get; set; }
        public bool ThoiGianVoSinh { get; set; }
        public bool SoChuKyChocHut { get; set; }
        public bool LoaiVoSinh { get; set; }
        public bool ChiDinhTTTON { get; set; }
    }

    public class DTO_PRO_MauPhanTichDuLieu_KichThichBuongTrung
    {
        public bool E2NgayTrigger { get; set; }
        public bool P4NgayTrigger { get; set; }
        public bool ThoiGianKTBT { get; set; }
        public bool LieuDauFSH { get; set; }
        public bool TongLieuFSH { get; set; }
        public bool SoTrungChocHut { get; set; }
    }

    public class DTO_PRO_MauPhanTichDuLieu_LaBo
    {
        public bool SoTrungICSI { get; set; }
        public bool SoTrungThuTinh { get; set; }
        public bool TyLe2PN { get; set; }
        public bool TyLeTaoPhoi { get; set; }
        public bool SoPhoi { get; set; }
        public bool SoPhoiL1L2 { get; set; }
    }

    public class DTO_PRO_MauPhanTichDuLieu_ChuKyChuyenPhoi
    {
        public bool SoPhoiChuyenTB { get; set; }
        public bool SoPhoiTotChuyenTB { get; set; }
        public bool NMTC { get; set; }
    }

    public class DTO_PRO_MauPhanTichDuLieu_KetQuaThai
    {
        public bool TyLeBeTaDuong { get; set; }
        public bool TyLeThaiLamSang { get; set; }
        public bool TyLeLamTo { get; set; }
        public bool TyLeDaThai2Thai { get; set; }
        public bool TyLeDaThai3Thai { get; set; }
        public bool TyLeSayThaiDuoi12W { get; set; }
        public bool TyLeThaiDienTien12W { get; set; }
        public bool TyLeSayThai1224W { get; set; }
        public bool TyLeThaiDienTien24W { get; set; }
        public bool TyLeSayThaiTren24W { get; set; }
        public bool TyLeSinhSong { get; set; }
        public bool TyLeSinhDoi { get; set; }
        public bool LoaiThaiSinh { get; set; }
        public bool SinhThuong { get; set; }
        public bool SinhMo { get; set; }
        public bool TuanThaiSinh { get; set; }
        public bool CanNangTre { get; set; }
        public bool QuaKichBuongTrung { get; set; }
        public bool BienChungSanKhoa { get; set; }
        public bool CaoHuyetApThaiKy { get; set; }
        public bool TieuDuongThaiKy { get; set; }
    }

    public class DTO_PRO_MauPhanTichDuLieu_BienSoKhac
    {
        public string Dong1 { get; set; }
        public string Dong2 { get; set; }
        public string Dong3 { get; set; }
        public string Dong4 { get; set; }
    }
}
