using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public partial class DTO_PRO_SAE : DTO_PRO_FORMBASE
    {
        public string HoTenBenhNhan { get; set; }
        public List<DTO_PRO_SAE_ThuocThuLamSan> ListThuocThuLamSan { get; set; }
        public List<DTO_PRO_SAE_CanThiepThuocThuLamSan> ListCanThiepThuocThuLamSan { get; set; }
        public List<DTO_PRO_SAE_ThuocSuDungDongThoi> ListThuocSuDungDongThoi { get; set; }
        public List<DTO_PRO_SAE_DanhGiaNCV> ListDanhGiaNCV { get; set; }
    }

    public class DTO_PRO_SAE_ThuocThuLamSan
    {
        public string STT { get; set; }
        public string TenThuoc { get; set; }
        public string DangBaoChe { get; set; }
        public string DuongDung { get; set; }
        public string LieuDung { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
    }

    public class DTO_PRO_SAE_CanThiepThuocThuLamSan
    {
        public string STT { get; set; }
        public bool NgungLieu_Co { get; set; }
        public bool NgungLieu_Khong { get; set; }
        public bool CaiThien_Co { get; set; }
        public bool CaiThien_Khong { get; set; }
        public bool CaiThien_KhongCoThongTin { get; set; }
        public bool XuatHienLai_Co { get; set; }
        public bool XuatHienLai_Khong { get; set; }
        public bool XuatHienLai_KhongCoThongTin { get; set; }
        public bool XuatHienLai_KhongTaiSuDung { get; set; }
    }

    public class DTO_PRO_SAE_ThuocSuDungDongThoi
    {
        public string STT { get; set; }
        public string TenThuoc { get; set; }
        public string DangBaoChe { get; set; }
        public string DuongDung { get; set; }
        public string LieuDung { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
    }

    public class DTO_PRO_SAE_DanhGiaNCV
    {
        public string STT { get; set; }
        public bool KetQua_Co { get; set; }
        public bool KetQua_Khong { get; set; }
        public bool KetQua_ChuaKetLuan { get; set; }
        public bool PhanUng_DuocDuKien { get; set; }
        public bool PhanUng_NgoaiDuKien { get; set; }
    }


}
