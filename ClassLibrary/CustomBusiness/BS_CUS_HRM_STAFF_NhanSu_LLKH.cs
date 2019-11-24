using ClassLibrary;
using DTOModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_CUS_HRM_STAFF_NhanSu_LLKH
    {
        public static DTO_CUS_HRM_STAFF_NhanSu_LLKH get_CUS_HRM_STAFF_NhanSu_LLKHByNhanSu(AppEntities db, int nhanSuId)
        {
            var query = db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.Where(d => d.IDNhanSu == nhanSuId && d.IsDeleted == false).Select(s => new DTO_CUS_HRM_STAFF_NhanSu_LLKH
            {
                ID = s.ID,
                IDNhanSu = s.IDNhanSu,
                ImageURL = s.ImageURL,
                HoTen = s.HoTen,
                GioiTinh = s.GioiTinh,
                NgaySinh = s.NgaySinh,
                TruongVien = s.TruongVien,
                PhongKhoa = s.PhongKhoa,
                ChucVu = s.ChucVu,
                CMND = s.CMND,
                CMND_NgayCap = s.CMND_NgayCap,
                CMND_NoiCap = s.CMND_NoiCap,
                HocVi = s.HocVi,
                HocHam = s.HocHam,
                DiaChi_CoQuan = s.DiaChi_CoQuan,
                DiaChi_CaNhan = s.DiaChi_CaNhan,
                DienThoai_CoQuan = s.DienThoai_CoQuan,
                DienThoai_CaNhan = s.DienThoai_CaNhan,
                Email_CoQuan = s.Email_CoQuan,
                Email_CaNhan = s.Email_CaNhan,
                TaiKhoan_MST = s.TaiKhoan_MST,
                TaiKhoan_STK = s.TaiKhoan_STK,
                TaiKhoan_NganHang = s.TaiKhoan_NganHang,
                LinhVucChuyenMon = s.LinhVucChuyenMon,
                LinhVuc = s.LinhVuc,
                ChuyenNganh = s.ChuyenNganh,
                HuongNghienCuu = s.HuongNghienCuu,
                HoatDongKhac = s.HoatDongKhac,
                JSON_NgoaiNgu = s.JSON_NgoaiNgu,
                JSON_ThoiGianCongTac = s.JSON_ThoiGianCongTac,
                JSON_QuaTrinhDaoTao = s.JSON_QuaTrinhDaoTao,
                JSON_DeTai = s.JSON_DeTai,
                JSON_HuongDan = s.JSON_HuongDan,
                JSON_CongTrinhDaCongBo_SachQuocTe = s.JSON_CongTrinhDaCongBo_SachQuocTe,
                JSON_CongTrinhDaCongBo_SachTrongNuoc = s.JSON_CongTrinhDaCongBo_SachTrongNuoc,
                JSON_CongTrinhDaCongBo_TapChiQuocTe = s.JSON_CongTrinhDaCongBo_TapChiQuocTe,
                JSON_CongTrinhDaCongBo_TapChiTrongNuoc = s.JSON_CongTrinhDaCongBo_TapChiTrongNuoc,
                JSON_CongTrinhDaCongBo_HoiNghiQuocTe = s.JSON_CongTrinhDaCongBo_HoiNghiQuocTe,
                JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc = s.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc,
                JSON_GiaiThuong = s.JSON_GiaiThuong,
                JSON_ThongTinKhac_HiepHoiKhoaHoc = s.JSON_ThongTinKhac_HiepHoiKhoaHoc,
                JSON_ThongTinKhac_TruongDaiHoc = s.JSON_ThongTinKhac_TruongDaiHoc,
                HTML = s.HTML,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            }).FirstOrDefault();

            if (query == null)
            {
                //New
                query = new DTO_CUS_HRM_STAFF_NhanSu_LLKH
                {
                    IDNhanSu = nhanSuId
                };

                query.ListNgoaiNgu = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_NgoaiNgu>();
                query.ListThoiGianCongTac = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThoiGianCongTac>();
                query.ListQuaTrinhDaoTao = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_QuaTrinhDaoTao>();
                query.ListDeTai = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_DeTai>();
                query.ListHuongDan = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_HuongDan>();
                query.ListSachQuocTe = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>();
                query.ListSachTrongNuoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>();
                query.ListTapChiQuocTe = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>();
                query.ListTapChiTrongNuoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>();
                query.ListHoiNghiQuocTe = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>();
                query.ListHoiNghiTrongNuoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>();
                query.ListGiaiThuong = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_GiaiThuong>();
                query.ListHiepHoiKhoaHoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_HiepHoiKhoaHoc>();
                query.ListTruongDaiHoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_TruongDaiHoc>();
            }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListNgoaiNgu = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_NgoaiNgu>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListThoiGianCongTac = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThoiGianCongTac>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListQuaTrinhDaoTao = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_QuaTrinhDaoTao>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListDeTai = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_DeTai>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListHuongDan = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_HuongDan>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListSachQuocTe = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListSachTrongNuoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListTapChiQuocTe = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListTapChiTrongNuoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListHoiNghiQuocTe = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListHoiNghiTrongNuoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListGiaiThuong = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_GiaiThuong>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListHiepHoiKhoaHoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_HiepHoiKhoaHoc>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListTruongDaiHoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_TruongDaiHoc>>(query.JSON_NgoaiNgu);
                }
            }

            return query;
        }
    }
}
