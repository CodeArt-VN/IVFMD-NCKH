﻿using ClassLibrary;
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
                FormConfig = s.FormConfig,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                JSON_HocVi = s.JSON_HocVi,
                NgayKy_Ngay = s.NgayKy_Ngay,
                NgayKy_Thang = s.NgayKy_Thang,
                NgayKy_Nam = s.NgayKy_Nam,
                NgayKy_ChuKy = s.NgayKy_ChuKy,
                NamPhongHocHam = s.NamPhongHocHam,
                HocViThacSy = s.HocViThacSy,
                NamHocViThacSy = s.NamHocViThacSy,
                HocViTienSy = s.HocViTienSy,
                NamHocViTienSy = s.NamHocViTienSy,
                IsCNDT = s.tbl_CUS_HRM_STAFF_NhanSu.IsCNDT == true
            }).FirstOrDefault();

            if (query == null)
            {
                //New
                query = new DTO_CUS_HRM_STAFF_NhanSu_LLKH
                {
                    IDNhanSu = nhanSuId
                };

                var objNhanSu = db.tbl_CUS_HRM_STAFF_NhanSu.Where(c => c.ID == nhanSuId).FirstOrDefault();
                if (objNhanSu != null)
                {
                    query.HoTen = objNhanSu.Name;
                    query.DiaChi_CaNhan = objNhanSu.DiaChi;
                    query.DienThoai_CaNhan = objNhanSu.SoDienThoai;
                    query.IsCNDT = objNhanSu.IsCNDT == true;
                }

                query.ListNgoaiNgu = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_NgoaiNgu>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_NgoaiNgu() };
                query.ListThoiGianCongTac = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThoiGianCongTac>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThoiGianCongTac { } };
                query.ListQuaTrinhDaoTao = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_QuaTrinhDaoTao>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_QuaTrinhDaoTao() };
                query.ListDeTai = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_DeTai>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_DeTai() { } };
                query.ListHuongDan = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_HuongDan>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_HuongDan() };
                query.ListSachQuocTe = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach() };
                query.ListSachTrongNuoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach() };
                query.ListTapChiQuocTe = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi() };
                query.ListTapChiTrongNuoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi() };
                query.ListHoiNghiQuocTe = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi() };
                query.ListHoiNghiTrongNuoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi() };
                query.ListGiaiThuong = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_GiaiThuong>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_GiaiThuong() };
                query.ListHiepHoiKhoaHoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_HiepHoiKhoaHoc>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_HiepHoiKhoaHoc() };
                query.ListTruongDaiHoc = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_TruongDaiHoc>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_TruongDaiHoc() };
                query.ListHocVi = new List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_HocVi>() { new DTO_CUS_HRM_STAFF_NhanSu_LLKH_HocVi() };
            }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.JSON_NgoaiNgu))
                {
                    query.ListNgoaiNgu = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_NgoaiNgu>>(query.JSON_NgoaiNgu);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_ThoiGianCongTac))
                {
                    query.ListThoiGianCongTac = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThoiGianCongTac>>(query.JSON_ThoiGianCongTac);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_QuaTrinhDaoTao))
                {
                    query.ListQuaTrinhDaoTao = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_QuaTrinhDaoTao>>(query.JSON_QuaTrinhDaoTao);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_DeTai))
                {
                    query.ListDeTai = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_DeTai>>(query.JSON_DeTai);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_HuongDan))
                {
                    query.ListHuongDan = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_HuongDan>>(query.JSON_HuongDan);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CongTrinhDaCongBo_SachQuocTe))
                {
                    query.ListSachQuocTe = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>>(query.JSON_CongTrinhDaCongBo_SachQuocTe);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CongTrinhDaCongBo_SachTrongNuoc))
                {
                    query.ListSachTrongNuoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_Sach>>(query.JSON_CongTrinhDaCongBo_SachTrongNuoc);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CongTrinhDaCongBo_TapChiQuocTe))
                {
                    query.ListTapChiQuocTe = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>>(query.JSON_CongTrinhDaCongBo_TapChiQuocTe);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CongTrinhDaCongBo_TapChiTrongNuoc))
                {
                    query.ListTapChiTrongNuoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_TapChi>>(query.JSON_CongTrinhDaCongBo_TapChiTrongNuoc);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CongTrinhDaCongBo_HoiNghiQuocTe))
                {
                    query.ListHoiNghiQuocTe = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>>(query.JSON_CongTrinhDaCongBo_HoiNghiQuocTe);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc))
                {
                    query.ListHoiNghiTrongNuoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_CongTrinhDaCongBo_HoiNghi>>(query.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_GiaiThuong))
                {
                    query.ListGiaiThuong = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_GiaiThuong>>(query.JSON_GiaiThuong);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_ThongTinKhac_HiepHoiKhoaHoc))
                {
                    query.ListHiepHoiKhoaHoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_HiepHoiKhoaHoc>>(query.JSON_ThongTinKhac_HiepHoiKhoaHoc);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_ThongTinKhac_TruongDaiHoc))
                {
                    query.ListTruongDaiHoc = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_ThongTinKhac_TruongDaiHoc>>(query.JSON_ThongTinKhac_TruongDaiHoc);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_HocVi))
                {
                    query.ListHocVi = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_LLKH_HocVi>>(query.JSON_HocVi);
                }
            }

            return query;
        }

        public static DTO_CUS_HRM_STAFF_NhanSu_LLKH save_CUS_HRM_STAFF_NhanSu_LLKH(AppEntities db, DTO_CUS_HRM_STAFF_NhanSu_LLKH item, string Username)
        {
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.Find(item.ID);
            if (dbitem == null)
            {
                dbitem = new tbl_CUS_HRM_STAFF_NhanSu_LLKH();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.Add(dbitem);
            }

            dbitem.IDNhanSu = item.IDNhanSu;
            dbitem.ImageURL = item.ImageURL;
            dbitem.HoTen = item.HoTen;
            dbitem.GioiTinh = item.GioiTinh;
            dbitem.NgaySinh = item.NgaySinh;
            dbitem.TruongVien = item.TruongVien;
            dbitem.PhongKhoa = item.PhongKhoa;
            dbitem.ChucVu = item.ChucVu;
            dbitem.CMND = item.CMND;
            dbitem.CMND_NgayCap = item.CMND_NgayCap;
            dbitem.CMND_NoiCap = item.CMND_NoiCap;
            dbitem.HocVi = item.HocVi;
            dbitem.HocHam = item.HocHam;
            dbitem.DiaChi_CoQuan = item.DiaChi_CoQuan;
            dbitem.DiaChi_CaNhan = item.DiaChi_CaNhan;
            dbitem.DienThoai_CoQuan = item.DienThoai_CoQuan;
            dbitem.DienThoai_CaNhan = item.DienThoai_CaNhan;
            dbitem.Email_CoQuan = item.Email_CoQuan;
            dbitem.Email_CaNhan = item.Email_CaNhan;
            dbitem.TaiKhoan_MST = item.TaiKhoan_MST;
            dbitem.TaiKhoan_STK = item.TaiKhoan_STK;
            dbitem.TaiKhoan_NganHang = item.TaiKhoan_NganHang;
            dbitem.LinhVucChuyenMon = item.LinhVucChuyenMon;
            dbitem.LinhVuc = item.LinhVuc;
            dbitem.ChuyenNganh = item.ChuyenNganh;
            dbitem.HuongNghienCuu = item.HuongNghienCuu;
            dbitem.HoatDongKhac = item.HoatDongKhac;
            dbitem.NgayKy_Ngay = item.NgayKy_Ngay;
            dbitem.NgayKy_Thang = item.NgayKy_Thang;
            dbitem.NgayKy_Nam = item.NgayKy_Nam;
            dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;
            dbitem.NamPhongHocHam = item.NamPhongHocHam;
            dbitem.HocViThacSy = item.HocViThacSy;
            dbitem.NamHocViThacSy = item.NamHocViThacSy;
            dbitem.HocViTienSy = item.HocViTienSy;
            dbitem.NamHocViTienSy = item.NamHocViTienSy;
            if (item.ListNgoaiNgu != null)
            {
                dbitem.JSON_NgoaiNgu = JsonConvert.SerializeObject(item.ListNgoaiNgu);
            }
            else
                dbitem.JSON_NgoaiNgu = string.Empty;

            if (item.ListThoiGianCongTac != null)
            {
                dbitem.JSON_ThoiGianCongTac = JsonConvert.SerializeObject(item.ListThoiGianCongTac);
            }
            else
                dbitem.JSON_ThoiGianCongTac = string.Empty;

            if (item.ListQuaTrinhDaoTao != null)
            {
                dbitem.JSON_QuaTrinhDaoTao = JsonConvert.SerializeObject(item.ListQuaTrinhDaoTao);
            }
            else
                dbitem.JSON_QuaTrinhDaoTao = string.Empty;

            if (item.ListDeTai != null)
            {
                dbitem.JSON_DeTai = JsonConvert.SerializeObject(item.ListDeTai);
            }
            else
                dbitem.JSON_DeTai = string.Empty;

            if (item.ListHuongDan != null)
            {
                dbitem.JSON_HuongDan = JsonConvert.SerializeObject(item.ListHuongDan);
            }
            else
                dbitem.JSON_HuongDan = string.Empty;

            if (item.ListSachQuocTe != null)
            {
                dbitem.JSON_CongTrinhDaCongBo_SachQuocTe = JsonConvert.SerializeObject(item.ListSachQuocTe);
            }
            else
                dbitem.JSON_CongTrinhDaCongBo_SachQuocTe = string.Empty;

            if (item.ListSachTrongNuoc != null)
            {
                dbitem.JSON_CongTrinhDaCongBo_SachTrongNuoc = JsonConvert.SerializeObject(item.ListSachTrongNuoc);
            }
            else
                dbitem.JSON_CongTrinhDaCongBo_SachTrongNuoc = string.Empty;

            if (item.ListTapChiQuocTe != null)
            {
                dbitem.JSON_CongTrinhDaCongBo_TapChiQuocTe = JsonConvert.SerializeObject(item.ListTapChiQuocTe);
            }
            else
                dbitem.JSON_CongTrinhDaCongBo_TapChiQuocTe = string.Empty;

            if (item.ListTapChiTrongNuoc != null)
            {
                dbitem.JSON_CongTrinhDaCongBo_TapChiTrongNuoc = JsonConvert.SerializeObject(item.ListTapChiTrongNuoc);
            }
            else
                dbitem.JSON_CongTrinhDaCongBo_TapChiTrongNuoc = string.Empty;

            if (item.ListHoiNghiQuocTe != null)
            {
                dbitem.JSON_CongTrinhDaCongBo_HoiNghiQuocTe = JsonConvert.SerializeObject(item.ListHoiNghiQuocTe);
            }
            else
                dbitem.JSON_CongTrinhDaCongBo_HoiNghiQuocTe = string.Empty;

            if (item.ListHoiNghiTrongNuoc != null)
            {
                dbitem.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc = JsonConvert.SerializeObject(item.ListHoiNghiTrongNuoc);
            }
            else
                dbitem.JSON_CongTrinhDaCongBo_HoiNghiTrongNuoc = string.Empty;

            if (item.ListGiaiThuong != null)
            {
                dbitem.JSON_GiaiThuong = JsonConvert.SerializeObject(item.ListGiaiThuong);
            }
            else
                dbitem.JSON_GiaiThuong = string.Empty;

            if (item.ListHiepHoiKhoaHoc != null)
            {
                dbitem.JSON_ThongTinKhac_HiepHoiKhoaHoc = JsonConvert.SerializeObject(item.ListHiepHoiKhoaHoc);
            }
            else
                dbitem.JSON_ThongTinKhac_HiepHoiKhoaHoc = string.Empty;

            if (item.ListTruongDaiHoc != null)
            {
                dbitem.JSON_ThongTinKhac_TruongDaiHoc = JsonConvert.SerializeObject(item.ListTruongDaiHoc);
            }
            else
                dbitem.JSON_ThongTinKhac_TruongDaiHoc = string.Empty;

            dbitem.FormConfig = item.FormConfig;
            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            try
            {
                db.SaveChanges();

                var syll = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.FirstOrDefault(c => c.IDNhanSu == dbitem.IDNhanSu);
                if (syll == null)
                {
                    var objSYLL = BS_CUS_HRM_STAFF_NhanSu_SYLL.get_CUS_HRM_STAFF_NhanSu_SYLLByNhanSu(db, dbitem.IDNhanSu);
                    if (objSYLL.ID == 0)
                    {
                        BS_CUS_HRM_STAFF_NhanSu_SYLL.save_CUS_HRM_STAFF_NhanSu_SYLL(db, objSYLL, Username);
                    }
                }
                else
                {
                    BS_HelperReference.STAFF_LLKH_Update(db, dbitem.IDNhanSu);
                }

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_LLKH", DateTime.Now, Username);
                item.ID = dbitem.ID;
                item.CreatedBy = dbitem.CreatedBy;
                item.CreatedDate = dbitem.CreatedDate;

                item.ModifiedBy = dbitem.ModifiedBy;
                item.ModifiedDate = dbitem.ModifiedDate;
                return item;
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("save_CUS_HRM_STAFF_NhanSu_LLKH", e);
                return null;
            }
        }
    }
}
