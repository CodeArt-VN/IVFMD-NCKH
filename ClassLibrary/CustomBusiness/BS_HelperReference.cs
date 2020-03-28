using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_HelperReference
    {
        public static void PRO_DeTai_Update(AppEntities db, int IDDeTai)
        {
            var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == IDDeTai);
            if (detai != null)
            {
                var xxdd = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (xxdd != null)
                {
                    xxdd.PhanHai_TenNCYSH = detai.TenTiengViet;
                }

                var ntdt = db.tbl_PRO_BaoCaoNghiemThuDeTai.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (ntdt != null)
                {
                    ntdt.TenDeTai = detai.TenTiengViet;
                    ntdt.ChuNhiemDeTai = detai.tbl_CUS_HRM_STAFF_NhanSu1 != null ? detai.tbl_CUS_HRM_STAFF_NhanSu1.Name : "";
                }

                var dgdd = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (dgdd != null)
                {
                    dgdd.TenDeTai = detai.TenTiengViet;
                }

                var dxnt = db.tbl_PRO_DonXinNghiemThu.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (dxnt != null)
                {
                    dxnt.TenDeTai = detai.TenTiengViet;
                }

                var dxxd = db.tbl_PRO_DonXinXetDuyet.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (dxxd != null)
                {
                    dxxd.TenDeTai = detai.TenTiengViet;
                }

                var pxxdd = db.tbl_PRO_PhieuXemXetDaoDuc.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (pxxdd != null)
                {
                    pxxdd.TenNCSYH = detai.TenTiengViet;
                }

                var tmdt = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (tmdt != null)
                {
                    tmdt.A1_TenTiengViet = detai.TenTiengViet;
                    tmdt.A1_TenTiengAnh = detai.TenTiengAnh;
                }

                var bkns = db.tbl_PRO_BangKhaiNhanSu.FirstOrDefault(c => c.IDDeTai == IDDeTai);
                if (bkns != null)
                {
                    bkns.QuanLyDieuHanhChung_NguoiThucHien = detai.tbl_CUS_HRM_STAFF_NhanSu1.Name + "/" + detai.tbl_CUS_HRM_STAFF_NhanSu.Name;
                }

                db.SaveChanges();
            }
        }

        public static void PRO_SYLL_NCV_Update(AppEntities db, int IDDeTai, int IDNhanSu)
        {
            var syll = db.tbl_PRO_SYLL.FirstOrDefault(c => c.IDDetai == IDDeTai && c.IDNhanSu == IDNhanSu && c.IsDeleted == false);
            if (syll != null)
            {
                var xxdd = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (xxdd != null)
                {
                    xxdd.PhanHai_NCVChinh_HoTen = syll.HoTen;
                    xxdd.PhanHai_NCVChinh_Email = syll.Email;
                    xxdd.PhanHai_NCVChinh_DienThoai = syll.Mobile;
                    xxdd.PhanHai_NCVChinh_DiaChiLienHe = syll.DiaChi;
                    xxdd.PhanHai_NCVChinh_BenhVien = syll.CoQuanLamViec;
                }

                db.SaveChanges();
            }
        }

        public static void PRO_LLKH_NCV_Update(AppEntities db, int IDDeTai, int IDNhanSu)
        {
            var llkh = db.tbl_PRO_LLKH.FirstOrDefault(c => c.IDDetai == IDDeTai && c.IDNhanSu == IDNhanSu && c.IsDeleted == false);
            if (llkh != null)
            {
                var xxdd = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (xxdd != null)
                {
                    xxdd.PhanHai_NCVChinh_KhoaPhong = llkh.PhongKhoa;
                }

                db.SaveChanges();
            }
        }

        public static void PRO_LLKH_CN_Update(AppEntities db, int IDDeTai, int IDNhanSu)
        {
            var llkh = db.tbl_PRO_LLKH.FirstOrDefault(c => c.IDDetai == IDDeTai && c.IDNhanSu == IDNhanSu && c.IsDeleted == false);
            if (llkh != null)
            {
                var tmdt = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (tmdt != null)
                {
                    tmdt.A6_HoTen = (!string.IsNullOrEmpty(llkh.HocHam) ? llkh.HocHam + " " : "") + (!string.IsNullOrEmpty(llkh.HocViThacSy) ? llkh.HocViThacSy + " " : "") + (!string.IsNullOrEmpty(llkh.HocViTienSy) ? llkh.HocViTienSy + " " : "") + llkh.HoTen;
                    tmdt.A6_NgaySinh = llkh.NgaySinh;
                    tmdt.A6_GioiTinh = llkh.GioiTinh;
                    tmdt.A6_CMND = llkh.CMND;
                    tmdt.A6_NgayCap = llkh.CMND_NgayCap;
                    tmdt.A6_NoiCap = llkh.CMND_NoiCap;
                    tmdt.A6_MST = llkh.TaiKhoan_MST;
                    tmdt.A6_STK = llkh.TaiKhoan_STK;
                    tmdt.A6_NganHang = llkh.TaiKhoan_NganHang;
                    tmdt.A6_DiaChiCoQuan = llkh.DiaChi_CoQuan;
                    tmdt.A6_DienThoai = llkh.DienThoai_CaNhan;
                    tmdt.A6_Email = llkh.Email_CaNhan;

                    try
                    {
                        var chunhiem = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_ThuyetMinhDeTai_NhanLucNghienCuu>(tmdt.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai);
                        chunhiem.HoTen = tmdt.A6_HoTen;
                        chunhiem.DonVi = llkh.TruongVien;
                    }
                    catch { }

                }

                db.SaveChanges();
            }
        }

        public static void PRO_DonXinDanhGiaDaoDuc_Update(AppEntities db, int IDDeTai)
        {
            var dxdg = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
            if (dxdg != null)
            {
                var xxdd = db.tbl_PRO_PhieuXemXetDaoDuc.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (xxdd != null)
                {
                    xxdd.DonViChuTri = dxdg.TenDonViChuTri + "<br>Địa chỉ: " + dxdg.DiaChiDonVi + "<br>Điện thoại:" + dxdg.DienThoaiDonVi;
                }

                var tmdt = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (tmdt != null)
                {
                    tmdt.A4_ThoiGianThucHien = "Địa điểm: " + dxdg.DiaDiemNghienCuu + "<br>" + "Thời gian: " + dxdg.ThoiGianNghienCuu + " tháng. Từ" + dxdg.TuNgay + " đến tháng " + dxdg.DenNgay;
                    tmdt.A7_TenCoQuan = dxdg.TenDonViChuTri;
                    tmdt.A7_DiaChi = dxdg.DiaChiDonVi;
                    tmdt.A7_DienThoai = dxdg.DienThoaiDonVi;
                }

                db.SaveChanges();
            }
        }

        public static void PRO_ThuyetMinhDeTai_Update(AppEntities db, int IDDeTai)
        {
            var thuyetminh = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
            if (thuyetminh != null)
            {
                if (!string.IsNullOrEmpty(thuyetminh.B313_JSON_KeHoachThucHien))
                {
                    try
                    {
                        var bkns = db.tbl_PRO_BangKhaiNhanSu.FirstOrDefault(c => c.IDDeTai == IDDeTai);
                        if (bkns != null)
                        {
                            List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien>>(thuyetminh.B313_JSON_KeHoachThucHien);
                            foreach (var item in lst)
                            {
                                if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietDeCuong)
                                {
                                    bkns.YTuong_NguoiThucHien = item.NguoiThucHien;
                                    bkns.PhuongPhap_NguoiThucHien = item.NguoiThucHien;
                                }
                                if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.ThuThapSoLieu)
                                {
                                    bkns.QuyTrinhNhanMau_NguoiThucHien = item.NguoiThucHien;
                                    bkns.ThucHienNhanMau_NguoiThucHien = item.NguoiThucHien;
                                    bkns.NhapDuLieuVaoPM_NguoiThucHien = item.NguoiThucHien;
                                }
                                if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoTrongNuoc)
                                    bkns.VietBaiBaoCaoTiengViet_NguoiThucHien = item.NguoiThucHien;
                                if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoQuocTe)
                                    bkns.VietBaiBaoCaoTiengAnh_NguoiThucHien = item.NguoiThucHien;
                                if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.PhanTichSoLieuCuoiCung)
                                    bkns.PhanTichSoLieu_NguoiThucHien = item.NguoiThucHien;
                            }
                            db.SaveChanges();
                        }
                    }
                    catch { }
                }
            }
        }
    }
}
