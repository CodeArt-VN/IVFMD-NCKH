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

                    var chunhiem = db.tbl_PRO_LLKH.FirstOrDefault(c => c.IDDetai == IDDeTai && c.IDNhanSu == detai.IDChuNhiem);
                    if (chunhiem != null)
                    {
                        dgdd.HoTenChuNhiem = chunhiem.HoTen;
                        dgdd.DiaChi = chunhiem.DiaChi_CaNhan;
                        dgdd.DienThoai = chunhiem.DienThoai_CaNhan;
                    }
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

                try
                {
                    var syll = db.tbl_PRO_SYLL.FirstOrDefault(c => c.IDDetai == IDDeTai && c.IDNhanSu == IDNhanSu && c.IsDeleted == false);
                    if (syll != null)
                    {
                        List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon> ListTrinhDoChuyenMon = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>();
                        var objHocVi1 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                        var objHocVi2 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                        var objHocVi3 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();

                        objHocVi1.HocVi = llkh.HocViThacSy;
                        objHocVi1.NamNhanBang = llkh.NamHocViThacSy;

                        objHocVi2.HocVi = llkh.HocViTienSy;
                        objHocVi2.NamNhanBang = llkh.NamHocViTienSy;

                        objHocVi3.HocVi = llkh.HocHam;
                        objHocVi3.NamNhanBang = llkh.NamPhongHocHam;

                        var myData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>>(syll.JSON_TrinhDoChuyenMon);
                        if (myData != null)
                        {
                            if (myData.Count > 0)
                            {
                                var hocvi = myData.ToArray()[0];
                                if (hocvi != null)
                                    objHocVi1.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }

                            if (myData.Count > 1)
                            {
                                var hocvi = myData.ToArray()[1];
                                if (hocvi != null)
                                    objHocVi2.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }

                            if (myData.Count > 2)
                            {
                                var hocvi = myData.ToArray()[2];
                                if (hocvi != null)
                                    objHocVi3.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }
                        }

                        ListTrinhDoChuyenMon.Add(objHocVi1);
                        ListTrinhDoChuyenMon.Add(objHocVi2);
                        ListTrinhDoChuyenMon.Add(objHocVi3);

                        syll.JSON_TrinhDoChuyenMon = Newtonsoft.Json.JsonConvert.SerializeObject(ListTrinhDoChuyenMon);
                    }
                }
                catch { }
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
                    tmdt.A6_HoTen = (!string.IsNullOrEmpty(llkh.HocHam) ? llkh.HocHam + ", " : "") + (!string.IsNullOrEmpty(llkh.HocViThacSy) ? llkh.HocViThacSy + ", " : "") + (!string.IsNullOrEmpty(llkh.HocViTienSy) ? llkh.HocViTienSy + ", " : "") + llkh.HoTen;
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

                var dgdd = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (dgdd != null)
                {
                    if (llkh != null)
                    {
                        dgdd.HoTenChuNhiem = llkh.HoTen;
                        dgdd.DiaChi = llkh.DiaChi_CaNhan;
                        dgdd.DienThoai = llkh.DienThoai_CaNhan;
                    }
                }

                try
                {
                    var syll = db.tbl_PRO_SYLL.FirstOrDefault(c => c.IDDetai == IDDeTai && c.IDNhanSu == IDNhanSu && c.IsDeleted == false);
                    if (syll != null)
                    {
                        List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon> ListTrinhDoChuyenMon = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>();
                        var objHocVi1 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                        var objHocVi2 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                        var objHocVi3 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();

                        objHocVi1.HocVi = llkh.HocViThacSy;
                        objHocVi1.NamNhanBang = llkh.NamHocViThacSy;

                        objHocVi2.HocVi = llkh.HocViTienSy;
                        objHocVi2.NamNhanBang = llkh.NamHocViTienSy;

                        objHocVi3.HocVi = llkh.HocHam;
                        objHocVi3.NamNhanBang = llkh.NamPhongHocHam;

                        var myData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>>(syll.JSON_TrinhDoChuyenMon);
                        if (myData != null)
                        {
                            if (myData.Count > 0)
                            {
                                var hocvi = myData.ToArray()[0];
                                if (hocvi != null)
                                    objHocVi1.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }

                            if (myData.Count > 1)
                            {
                                var hocvi = myData.ToArray()[1];
                                if (hocvi != null)
                                    objHocVi2.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }

                            if (myData.Count > 2)
                            {
                                var hocvi = myData.ToArray()[2];
                                if (hocvi != null)
                                    objHocVi3.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }
                        }

                        ListTrinhDoChuyenMon.Add(objHocVi1);
                        ListTrinhDoChuyenMon.Add(objHocVi2);
                        ListTrinhDoChuyenMon.Add(objHocVi3);

                        syll.JSON_TrinhDoChuyenMon = Newtonsoft.Json.JsonConvert.SerializeObject(ListTrinhDoChuyenMon);
                    }
                }
                catch { }

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

                var bangkiem = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (bangkiem != null)
                {
                    bangkiem.PhanBon_C1_NoiNhanMau = "<br>Địa điểm: " + dxdg.DiaDiemNghienCuu + "<br>" + "Thời gian: " + dxdg.ThoiGianNghienCuu + " tháng. Từ " + dxdg.TuNgay + " đến tháng " + dxdg.DenNgay;
                }

                var tmdt = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (tmdt != null)
                {
                    tmdt.A4_ThoiGianThucHien = "Địa điểm: " + (!string.IsNullOrEmpty(dxdg.DiaDiemNghienCuu) ? dxdg.DiaDiemNghienCuu.Replace("<br>", "<div>") : "") + "<div>" + "Thời gian: " + dxdg.ThoiGianNghienCuu + " tháng. Từ " + dxdg.TuNgay + " đến tháng " + dxdg.DenNgay + "</div>";
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
                            
                        }
                    }
                    catch { }
                }

                var bangkiem = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.FirstOrDefault(c => c.IDDeTai == IDDeTai && c.IsDeleted == false);
                if (bangkiem != null)
                {
                    bangkiem.PhanBon_C1_TieuChuanNhanVao = "<br>" + thuyetminh.B3221_TieuChuanNhan;
                    bangkiem.PhanBon_C1_TieuChuanLoaiRa = "<br>" + thuyetminh.B3221_TieuChuanLoai;
                    bangkiem.PhanBon_C1_TieuChuanNhanVao = bangkiem.PhanBon_C1_TieuChuanNhanVao.Replace("<div>", "<br>").Replace("</div>", "");
                    bangkiem.PhanBon_C1_TieuChuanLoaiRa = bangkiem.PhanBon_C1_TieuChuanLoaiRa.Replace("<div>", "<br>").Replace("</div>", "");
                    bangkiem.PhanBon_C2_CachTienHanh = thuyetminh.B323_PhuongPhapTienHanh;
                }

                db.SaveChanges();
            }
        }

        public static void STAFF_LLKH_Update(AppEntities db, int IDNhanSu)
        {
            var objLL = db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.FirstOrDefault(c => c.IDNhanSu == IDNhanSu && c.IsDeleted == false);
            if (objLL != null)
            {
                var query = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.FirstOrDefault(c => c.IDNhanSu == IDNhanSu && c.IsDeleted == false);
                if (query != null)
                {
                    query.HoTen = objLL.HoTen;
                    query.NgaySinh = objLL.NgaySinh;
                    query.Email = objLL.Email_CaNhan;
                    query.DiaChi = objLL.DiaChi_CaNhan;
                    query.Mobile = objLL.DienThoai_CaNhan;
                    query.GioiTinh = objLL.GioiTinh;
                    query.ChucVu = objLL.ChucVu;
                    query.DiaChiCoQuan = objLL.DiaChi_CoQuan;
                    query.CoQuanLamViec = "Bệnh viện Mỹ Đức";
                    query.DienThoaiCQ = objLL.DienThoai_CoQuan;

                    try
                    {
                        List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon> ListTrinhDoChuyenMon = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>();
                        var objHocVi1 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                        var objHocVi2 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                        var objHocVi3 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();

                        objHocVi1.HocVi = objLL.HocViThacSy;
                        objHocVi1.NamNhanBang = objLL.NamHocViThacSy;

                        objHocVi2.HocVi = objLL.HocViTienSy;
                        objHocVi2.NamNhanBang = objLL.NamHocViTienSy;

                        objHocVi3.HocVi = objLL.HocHam;
                        objHocVi3.NamNhanBang = objLL.NamPhongHocHam;

                        var myData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>>(query.JSON_TrinhDoChuyenMon);
                        if (myData != null)
                        {
                            if (myData.Count > 0)
                            {
                                var hocvi = myData.ToArray()[0];
                                if (hocvi != null)
                                    objHocVi1.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }

                            if (myData.Count > 1)
                            {
                                var hocvi = myData.ToArray()[1];
                                if (hocvi != null)
                                    objHocVi2.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }

                            if (myData.Count > 2)
                            {
                                var hocvi = myData.ToArray()[2];
                                if (hocvi != null)
                                    objHocVi3.ChuyenNganhDaoTao = hocvi.ChuyenNganhDaoTao;
                            }
                        }

                        ListTrinhDoChuyenMon.Add(objHocVi1);
                        ListTrinhDoChuyenMon.Add(objHocVi2);
                        ListTrinhDoChuyenMon.Add(objHocVi3);

                        query.JSON_TrinhDoChuyenMon = Newtonsoft.Json.JsonConvert.SerializeObject(ListTrinhDoChuyenMon);
                    }
                    catch { }
                }

                db.SaveChanges();
            }
        }
    }
}
