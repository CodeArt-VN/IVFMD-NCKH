﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CustomDTO
{
    public partial class DTO_PRO_LLKH
    {
        public List<DTO_PRO_LLKH_NgoaiNgu> ListNgoaiNgu { get; set; }
        public List<DTO_PRO_LLKH_ThoiGianCongTac> ListThoiGianCongTac { get; set; }
        public List<DTO_PRO_LLKH_QuaTrinhDaoTao> ListQuaTrinhDaoTao { get; set; }
        public List<DTO_PRO_LLKH_DeTai> ListDeTai { get; set; }
        public List<DTO_PRO_LLKH_HuongDan> ListHuongDan { get; set; }
        public List<DTO_PRO_LLKH_CongTrinhDaCongBo_Sach> ListSachQuocTe { get; set; }
        public List<DTO_PRO_LLKH_CongTrinhDaCongBo_Sach> ListSachTrongNuoc { get; set; }
        public List<DTO_PRO_LLKH_CongTrinhDaCongBo_TapChi> ListTapChiQuocTe { get; set; }
        public List<DTO_PRO_LLKH_CongTrinhDaCongBo_TapChi> ListTapChiTrongNuoc { get; set; }
        public List<DTO_PRO_LLKH_CongTrinhDaCongBo_HoiNghi> ListHoiNghiQuocTe { get; set; }
        public List<DTO_PRO_LLKH_CongTrinhDaCongBo_HoiNghi> ListHoiNghiTrongNuoc { get; set; }
        public List<DTO_PRO_LLKH_GiaiThuong> ListGiaiThuong { get; set; }
        public List<DTO_PRO_LLKH_ThongTinKhac_HiepHoiKhoaHoc> ListHiepHoiKhoaHoc { get; set; }
        public List<DTO_PRO_LLKH_ThongTinKhac_TruongDaiHoc> ListTruongDaiHoc { get; set; }
    }

    public class DTO_PRO_LLKH_NgoaiNgu
    {
        public string NgoaiNgu { get; set; }
        public DTO_PRO_LLKH_NgoaiNgu_ChiTiet Nghe { get; set; }
        public DTO_PRO_LLKH_NgoaiNgu_ChiTiet Noi { get; set; }
        public DTO_PRO_LLKH_NgoaiNgu_ChiTiet Viet { get; set; }
        public DTO_PRO_LLKH_NgoaiNgu_ChiTiet Doc { get; set; }
    }

    public class DTO_PRO_LLKH_NgoaiNgu_ChiTiet
    {
        public bool Tot { get; set; }
        public bool Kha { get; set; }
        public bool TB { get; set; }
    }

    public class DTO_PRO_LLKH_ThoiGianCongTac
    {
        public string ThoiGian { get; set; }
        public string NoiCongTac { get; set; }
        public string ChucVu { get; set; }
    }

    public class DTO_PRO_LLKH_QuaTrinhDaoTao
    {
        public string Bac { get; set; }
        public string ThoiGian { get; set; }
        public string NoiDaoTao { get; set; }
        public string ChuyenNganh { get; set; }
        public string TenLuanAnTotNghiep { get; set; }
    }

    public class DTO_PRO_LLKH_DeTai
    {
        public string TT { get; set; }
        public string TenDeTai { get; set; }
        public string MaSoQuanLy { get; set; }
        public string ThoiGianThucHien { get; set; }
        public string ChuNhiem { get; set; }
        public string NgayNghiemThu { get; set; }
        public string KetQua { get; set; }
    }

    public class DTO_PRO_LLKH_HuongDan
    {
        public string TT { get; set; }
        public string TenSV { get; set; }
        public string TenLuanAn { get; set; }
        public string NamTot { get; set; }
        public string BacDaoTao { get; set; }
        public string SanPham { get; set; }
    }

    public class DTO_PRO_LLKH_CongTrinhDaCongBo_Sach
    {
        public string TT { get; set; }
        public string TenSach { get; set; }
        public string SanPham { get; set; }
        public string NhaXuatBan { get; set; }
        public string NamXuatBan { get; set; }
        public string TacGia { get; set; }
        public string ButDanh { get; set; }
    }

    public class DTO_PRO_LLKH_CongTrinhDaCongBo_TapChi
    {
        public string TT { get; set; }
        public string TenBaiViet { get; set; }
        public string SanPham { get; set; }
        public string SoHieu { get; set; }
        public string DiemIF { get; set; }
    }

    public class DTO_PRO_LLKH_CongTrinhDaCongBo_HoiNghi
    {
        public string TT { get; set; }
        public string TenBaiViet { get; set; }
        public string SanPham { get; set; }
        public string SoHieu { get; set; }
        public string DiemIF { get; set; }
    }

    public class DTO_PRO_LLKH_GiaiThuong
    {
        public string TT { get; set; }
        public string TenGiaiThuong { get; set; }
        public string NoiDungGiaiThuong { get; set; }
        public string NoiCap { get; set; }
        public string NamCap { get; set; }
    }

    public class DTO_PRO_LLKH_ThongTinKhac_HiepHoiKhoaHoc
    {
        public string TT { get; set; }
        public string ThoiGian { get; set; }
        public string TenHiepHoi { get; set; }
        public string ChucDanh { get; set; }
    }

    public class DTO_PRO_LLKH_ThongTinKhac_TruongDaiHoc
    {
        public string TT { get; set; }
        public string ThoiGian { get; set; }
        public string TenTruong { get; set; }
        public string NoiDungThamGia { get; set; }
    }
}