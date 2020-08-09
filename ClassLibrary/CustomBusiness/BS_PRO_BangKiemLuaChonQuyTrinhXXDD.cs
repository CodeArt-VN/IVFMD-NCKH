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
    public static partial class BS_PRO_BangKiemLuaChonQuyTrinhXXDD
    {
        public static DTO_PRO_BangKiemLuaChonQuyTrinhXXDD get_PRO_BangKiemLuaChonQuyTrinhXXDDCustom(AppEntities db, int idDeTai)
        {
            var query = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Where(d => d.IDDeTai == idDeTai && d.IsDeleted == false).Select(s => new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                MaSo = s.MaSo,
                PhanMot_ConNguoi = s.PhanMot_ConNguoi,
                PhanMot_DongVat = s.PhanMot_DongVat,
                PhanHai_TenNCYSH = s.PhanHai_TenNCYSH,
                PhanHai_NCVChinh_HoTen = s.PhanHai_NCVChinh_HoTen,
                PhanHai_NCVChinh_KhoaPhong = s.PhanHai_NCVChinh_KhoaPhong,
                PhanHai_NCVChinh_BenhVien = s.PhanHai_NCVChinh_BenhVien,
                PhanHai_NCVChinh_DienThoai = s.PhanHai_NCVChinh_DienThoai,
                PhanHai_NCVChinh_Email = s.PhanHai_NCVChinh_Email,
                PhanHai_NCVChinh_DiaChiLienHe = s.PhanHai_NCVChinh_DiaChiLienHe,
                PhanHai_NGS_HoTen = s.PhanHai_NGS_HoTen,
                PhanHai_NGS_NoiLamViec = s.PhanHai_NGS_NoiLamViec,
                PhanHai_NGS_DienThoai = s.PhanHai_NGS_DienThoai,
                PhanHai_NGS_Email = s.PhanHai_NGS_Email,
                PhanBa_A_JSON = s.PhanBa_A_JSON,
                PhanBa_B_JSON = s.PhanBa_B_JSON,
                PhanBon_C1_MoTaQuyTrinh = s.PhanBon_C1_MoTaQuyTrinh,
                PhanBon_C1_NoiNhanMau = s.PhanBon_C1_NoiNhanMau,
                PhanBon_C1_DanSoChonMau = s.PhanBon_C1_DanSoChonMau,
                PhanBon_C1_CoMauNghienCuu = s.PhanBon_C1_CoMauNghienCuu,
                PhanBon_C1_TieuChuanNhanVao = s.PhanBon_C1_TieuChuanNhanVao,
                PhanBon_C1_TieuChuanLoaiRa = s.PhanBon_C1_TieuChuanLoaiRa,
                PhanBon_C2_MoTaQuyTrinh = s.PhanBon_C2_MoTaQuyTrinh,
                PhanBon_C2_CachTienHanh = s.PhanBon_C2_CachTienHanh,
                PhanBon_C3_MoTaQuyTrinh = s.PhanBon_C3_MoTaQuyTrinh,
                PhanNam_JSON = s.PhanNam_JSON,
                ThoiGianTienHanh_Ngay = s.ThoiGianTienHanh_Ngay,
                ThoiGianTienHanh_Thang = s.ThoiGianTienHanh_Thang,
                ThoiGianTienHanh_Nam = s.ThoiGianTienHanh_Nam,
                ThoiGianThuThap_Ngay = s.ThoiGianThuThap_Ngay,
                ThoiGianThuThap_Thang = s.ThoiGianThuThap_Thang,
                ThoiGianThuThap_Nam = s.ThoiGianThuThap_Nam,
                ThoiGianNghienCuu_Ngay = s.ThoiGianNghienCuu_Ngay,
                ThoiGianNghienCuu_Thang = s.ThoiGianNghienCuu_Thang,
                ThoiGianNghienCuu_Nam = s.ThoiGianNghienCuu_Nam,
                JSON_NCVKhac = s.JSON_NCVKhac,
                DaGuiThuDienTu = s.DaGuiThuDienTu,
                JSON_MoTaNCYSH = s.JSON_MoTaNCYSH,
                PhanSau_NCYSH_KhongThuocPhamVi = s.PhanSau_NCYSH_KhongThuocPhamVi,
                PhanSau_NCYSH_DuDieuKienXemXet = s.PhanSau_NCYSH_DuDieuKienXemXet,
                PhanSau_NCYSH_HoTen = s.PhanSau_NCYSH_HoTen,
                PhanSau_NCYSH_NgayThangNam = s.PhanSau_NCYSH_NgayThangNam,
                PhanSau_NCYSH_GuiThongBao_KHTH = s.PhanSau_NCYSH_GuiThongBao_KHTH,
                PhanSau_NCYSH_GuiThongBao_TCKT = s.PhanSau_NCYSH_GuiThongBao_TCKT,
                PhanSau_NGS_KhongThuocPhamVi = s.PhanSau_NGS_KhongThuocPhamVi,
                PhanSau_NGS_DuDieuKienXemXet = s.PhanSau_NGS_DuDieuKienXemXet,
                PhanSau_NGS_HoTen = s.PhanSau_NGS_HoTen,
                PhanSau_NGS_NgayThangNam = s.PhanSau_NGS_NgayThangNam,
                PhanSau_TruongKhoa_KhongThuocPhamVi = s.PhanSau_TruongKhoa_KhongThuocPhamVi,
                PhanSau_TruongKhoa_DuDieuKienXemXet = s.PhanSau_TruongKhoa_DuDieuKienXemXet,
                PhanSau_TruongKhoa_HoTen = s.PhanSau_TruongKhoa_HoTen,
                PhanSau_TruongKhoa_ChucVu = s.PhanSau_TruongKhoa_ChucVu,
                PhanSau_TruongKhoa_NgayThangNam = s.PhanSau_TruongKhoa_NgayThangNam,
                YKienHDDD_KhongThuocPhamVi = s.YKienHDDD_KhongThuocPhamVi,
                YKienHDDD_DuocXemXetDaoDuc = s.YKienHDDD_DuocXemXetDaoDuc,
                YKienHDDD_DuocXemXetDaoDucRutGon = s.YKienHDDD_DuocXemXetDaoDucRutGon,
                YKienHDDD_CanDuocHoiDongXemXet = s.YKienHDDD_CanDuocHoiDongXemXet,
                YKienHDDD_NhanXet = s.YKienHDDD_NhanXet,
                HTML = s.HTML,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                YKienHDDD_So = s.YKienHDDD_So,
                NgayKy_Ngay = s.NgayKy_Ngay,
                NgayKy_Thang = s.NgayKy_Thang,
                NgayKy_Nam = s.NgayKy_Nam,
                PhanSau_NCYSH_KhongThuocPhamVi_Co = s.PhanSau_NCYSH_KhongThuocPhamVi_Co,
                PhanSau_NCYSH_KhongThuocPhamVi_Khong = s.PhanSau_NCYSH_KhongThuocPhamVi_Khong,
                PhanSau_NCYSH_GuiThongBao_KHTH_Co = s.PhanSau_NCYSH_GuiThongBao_KHTH_Co,
                PhanSau_NCYSH_GuiThongBao_KHTH_Khong = s.PhanSau_NCYSH_GuiThongBao_KHTH_Khong,
                PhanSau_NCYSH_GuiThongBao_TCKT_Co = s.PhanSau_NCYSH_GuiThongBao_TCKT_Co,
                PhanSau_NCYSH_GuiThongBao_TCKT_Khong = s.PhanSau_NCYSH_GuiThongBao_TCKT_Khong,
                PhanSau_NGS_KhongThuocPhamVi_Co = s.PhanSau_NGS_KhongThuocPhamVi_Co,
                PhanSau_NGS_KhongThuocPhamVi_Khong = s.PhanSau_NGS_KhongThuocPhamVi_Khong,
                PhanSau_TruongKhoa_KhongThuocPhamVi_Co = s.PhanSau_TruongKhoa_KhongThuocPhamVi_Co,
                PhanSau_TruongKhoa_KhongThuocPhamVi_Khong = s.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong,
                ThoiGianTienHanhDenNgay_Ngay = s.ThoiGianTienHanhDenNgay_Ngay,
                ThoiGianTienHanhDenNgay_Thang = s.ThoiGianTienHanhDenNgay_Thang,
                ThoiGianTienHanhDenNgay_Nam = s.ThoiGianTienHanhDenNgay_Nam,
                ThoiGianThuThapDenNgay_Ngay = s.ThoiGianThuThapDenNgay_Ngay,
                ThoiGianThuThapDenNgay_Thang = s.ThoiGianThuThapDenNgay_Thang,
                ThoiGianThuThapDenNgay_Nam = s.ThoiGianThuThapDenNgay_Nam,
                ThoiGianNghienCuuDenNgay_Ngay = s.ThoiGianNghienCuuDenNgay_Ngay,
                ThoiGianNghienCuuDenNgay_Thang = s.ThoiGianNghienCuuDenNgay_Thang,
                ThoiGianNghienCuuDenNgay_Nam = s.ThoiGianNghienCuuDenNgay_Nam,
                FormConfig = s.FormConfig,
                IsDisabled = s.tbl_PRO_DeTai.IsDisabledHDDD ?? false,
                ChuKy = s.ChuKy
            }).FirstOrDefault();

            if (query == null)
            {
                //New
                query = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD
                {
                    IDDeTai = idDeTai
                };

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == idDeTai);
                if (detai != null)
                {
                    query.IsDisabled = detai.IsDisabledHDDD ?? false;
                    query.PhanHai_TenNCYSH = detai.TenTiengViet;
                    var syll = db.tbl_PRO_SYLL.FirstOrDefault(c => c.IDDetai == idDeTai && c.IDNhanSu == detai.IDNCV && c.IsDeleted == false);
                    if (syll != null)
                    {
                        query.PhanHai_NCVChinh_HoTen = syll.HoTen;
                        query.PhanHai_NCVChinh_Email = syll.Email;
                        query.PhanHai_NCVChinh_DienThoai = syll.Mobile;
                        query.PhanHai_NCVChinh_DiaChiLienHe = syll.DiaChi;
                        query.PhanHai_NCVChinh_BenhVien = syll.CoQuanLamViec;
                    }

                    var llkh = db.tbl_PRO_LLKH.FirstOrDefault(c => c.IDDetai == idDeTai && c.IDNhanSu == detai.IDNCV && c.IsDeleted == false);
                    if (llkh != null)
                    {
                        query.PhanHai_NCVChinh_KhoaPhong = llkh.PhongKhoa;
                    }

                    var hddd = db.tbl_PRO_DonXinDanhGiaDaoDuc.FirstOrDefault(c => c.IDDeTai == idDeTai && c.IsDeleted == false);
                    if (hddd != null)
                    {
                        query.PhanBon_C1_NoiNhanMau = "<br>Địa điểm: " + hddd.DiaDiemNghienCuu + "<br>" + "Thời gian: " + hddd.ThoiGianNghienCuu + " tháng. Từ " + hddd.TuNgay + " đến tháng " + hddd.DenNgay;
                    }

                    var thuyetminh = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == idDeTai && c.IsDeleted == false);
                    if (thuyetminh != null)
                    {
                        query.PhanBon_C1_TieuChuanNhanVao = "<br>" + thuyetminh.B3221_TieuChuanNhan;
                        query.PhanBon_C1_TieuChuanLoaiRa = "<br>" + thuyetminh.B3221_TieuChuanLoai;
                        query.PhanBon_C1_TieuChuanNhanVao = query.PhanBon_C1_TieuChuanNhanVao.Replace("<div>", "<br>").Replace("</div>", "");
                        query.PhanBon_C1_TieuChuanLoaiRa = query.PhanBon_C1_TieuChuanLoaiRa.Replace("<div>", "<br>").Replace("</div>", "");
                        //query.PhanBon_C2_CachTienHanh = thuyetminh.B323_PhuongPhapTienHanh;
                    }
                }

                query.NCVKhac = new List<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac>() { new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac() };
                query.PhanBa_A = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaA();
                query.PhanBa_B = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaB();
                query.PhanNam = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanNam();
                query.MoTaNCYSH = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_MoTaNCYSH();
            }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.PhanBa_A_JSON))
                {
                    query.PhanBa_A = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaA>(query.PhanBa_A_JSON);
                }
                if (!string.IsNullOrWhiteSpace(query.PhanBa_B_JSON))
                {
                    query.PhanBa_B = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanBaB>(query.PhanBa_B_JSON);
                }
                if (!string.IsNullOrWhiteSpace(query.PhanNam_JSON))
                {
                    query.PhanNam = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_PhanNam>(query.PhanNam_JSON);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_MoTaNCYSH))
                {
                    query.MoTaNCYSH = JsonConvert.DeserializeObject<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_MoTaNCYSH>(query.JSON_MoTaNCYSH);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_NCVKhac))
                {
                    query.NCVKhac = JsonConvert.DeserializeObject<List<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD_NCVKhac>>(query.JSON_NCVKhac);
                }
            }

            return query;
        }

        public static DTO_PRO_BangKiemLuaChonQuyTrinhXXDD save_PRO_BangKiemLuaChonQuyTrinhXXDD(AppEntities db, DTO_PRO_BangKiemLuaChonQuyTrinhXXDD item, string Username)
        {
            var dbitem = db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Find(item.ID);
            if (dbitem == null)
            {
                dbitem = new tbl_PRO_BangKiemLuaChonQuyTrinhXXDD();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                dbitem.PhanHai_TenNCYSH = item.PhanHai_TenNCYSH;
                dbitem.PhanHai_NCVChinh_HoTen = item.PhanHai_NCVChinh_HoTen;
                dbitem.PhanHai_NCVChinh_BenhVien = item.PhanHai_NCVChinh_BenhVien;
                dbitem.PhanHai_NCVChinh_DienThoai = item.PhanHai_NCVChinh_DienThoai;
                dbitem.PhanHai_NCVChinh_Email = item.PhanHai_NCVChinh_Email;
                dbitem.PhanHai_NCVChinh_DiaChiLienHe = item.PhanHai_NCVChinh_DiaChiLienHe;
                dbitem.PhanHai_NCVChinh_KhoaPhong = item.PhanHai_NCVChinh_KhoaPhong;
                dbitem.PhanBon_C1_NoiNhanMau = item.PhanBon_C1_NoiNhanMau;

                db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Add(dbitem);
            }

            dbitem.IDDeTai = item.IDDeTai;
            dbitem.MaSo = item.MaSo;
            dbitem.PhanMot_ConNguoi = item.PhanMot_ConNguoi;
            dbitem.PhanMot_DongVat = item.PhanMot_DongVat;
            dbitem.PhanHai_NGS_HoTen = item.PhanHai_NGS_HoTen;
            dbitem.PhanHai_NGS_NoiLamViec = item.PhanHai_NGS_NoiLamViec;
            dbitem.PhanHai_NGS_DienThoai = item.PhanHai_NGS_DienThoai;
            dbitem.PhanHai_NGS_Email = item.PhanHai_NGS_Email;
            dbitem.PhanBon_C1_MoTaQuyTrinh = item.PhanBon_C1_MoTaQuyTrinh;
            dbitem.PhanBon_C1_DanSoChonMau = item.PhanBon_C1_DanSoChonMau;
            dbitem.PhanBon_C1_CoMauNghienCuu = item.PhanBon_C1_CoMauNghienCuu;
            dbitem.PhanBon_C1_TieuChuanNhanVao = item.PhanBon_C1_TieuChuanNhanVao;
            dbitem.PhanBon_C1_TieuChuanLoaiRa = item.PhanBon_C1_TieuChuanLoaiRa;
            dbitem.PhanBon_C2_MoTaQuyTrinh = item.PhanBon_C2_MoTaQuyTrinh;
            dbitem.PhanBon_C2_CachTienHanh = item.PhanBon_C2_CachTienHanh;
            dbitem.PhanBon_C3_MoTaQuyTrinh = item.PhanBon_C3_MoTaQuyTrinh;
            dbitem.ThoiGianTienHanh_Ngay = item.ThoiGianTienHanh_Ngay;
            dbitem.ThoiGianTienHanh_Thang = item.ThoiGianTienHanh_Thang;
            dbitem.ThoiGianTienHanh_Nam = item.ThoiGianTienHanh_Nam;
            dbitem.ThoiGianThuThap_Ngay = item.ThoiGianThuThap_Ngay;
            dbitem.ThoiGianThuThap_Thang = item.ThoiGianThuThap_Thang;
            dbitem.ThoiGianThuThap_Nam = item.ThoiGianThuThap_Nam;
            dbitem.ThoiGianNghienCuu_Ngay = item.ThoiGianNghienCuu_Ngay;
            dbitem.ThoiGianNghienCuu_Thang = item.ThoiGianNghienCuu_Thang;
            dbitem.ThoiGianNghienCuu_Nam = item.ThoiGianNghienCuu_Nam;
            dbitem.DaGuiThuDienTu = item.DaGuiThuDienTu;
            dbitem.PhanSau_NCYSH_KhongThuocPhamVi = item.PhanSau_NCYSH_KhongThuocPhamVi;
            dbitem.PhanSau_NCYSH_DuDieuKienXemXet = item.PhanSau_NCYSH_DuDieuKienXemXet;
            dbitem.PhanSau_NCYSH_HoTen = item.PhanSau_NCYSH_HoTen;
            dbitem.PhanSau_NCYSH_NgayThangNam = item.PhanSau_NCYSH_NgayThangNam;
            dbitem.PhanSau_NCYSH_GuiThongBao_KHTH = item.PhanSau_NCYSH_GuiThongBao_KHTH;
            dbitem.PhanSau_NCYSH_GuiThongBao_TCKT = item.PhanSau_NCYSH_GuiThongBao_TCKT;
            dbitem.PhanSau_NGS_KhongThuocPhamVi = item.PhanSau_NGS_KhongThuocPhamVi;
            dbitem.PhanSau_NGS_DuDieuKienXemXet = item.PhanSau_NGS_DuDieuKienXemXet;
            dbitem.PhanSau_NGS_HoTen = item.PhanSau_NGS_HoTen;
            dbitem.PhanSau_NGS_NgayThangNam = item.PhanSau_NGS_NgayThangNam;
            dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi = item.PhanSau_TruongKhoa_KhongThuocPhamVi;
            dbitem.PhanSau_TruongKhoa_DuDieuKienXemXet = item.PhanSau_TruongKhoa_DuDieuKienXemXet;
            dbitem.PhanSau_TruongKhoa_HoTen = item.PhanSau_TruongKhoa_HoTen;
            dbitem.PhanSau_TruongKhoa_ChucVu = item.PhanSau_TruongKhoa_ChucVu;
            dbitem.PhanSau_TruongKhoa_NgayThangNam = item.PhanSau_TruongKhoa_NgayThangNam;
            dbitem.YKienHDDD_KhongThuocPhamVi = item.YKienHDDD_KhongThuocPhamVi;
            dbitem.YKienHDDD_DuocXemXetDaoDuc = item.YKienHDDD_DuocXemXetDaoDuc;
            dbitem.YKienHDDD_DuocXemXetDaoDucRutGon = item.YKienHDDD_DuocXemXetDaoDucRutGon;
            dbitem.YKienHDDD_CanDuocHoiDongXemXet = item.YKienHDDD_CanDuocHoiDongXemXet;
            dbitem.YKienHDDD_NhanXet = item.YKienHDDD_NhanXet;
            dbitem.YKienHDDD_So = item.YKienHDDD_So;
            dbitem.NgayKy_Ngay = item.NgayKy_Ngay;
            dbitem.NgayKy_Thang = item.NgayKy_Thang;
            dbitem.NgayKy_Nam = item.NgayKy_Nam;
            dbitem.PhanSau_NCYSH_KhongThuocPhamVi_Co = item.PhanSau_NCYSH_KhongThuocPhamVi_Co;
            dbitem.PhanSau_NCYSH_KhongThuocPhamVi_Khong = item.PhanSau_NCYSH_KhongThuocPhamVi_Khong;
            dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Co = item.PhanSau_NCYSH_GuiThongBao_KHTH_Co;
            dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Khong = item.PhanSau_NCYSH_GuiThongBao_KHTH_Khong;
            dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Co = item.PhanSau_NCYSH_GuiThongBao_TCKT_Co;
            dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Khong = item.PhanSau_NCYSH_GuiThongBao_TCKT_Khong;
            dbitem.PhanSau_NGS_KhongThuocPhamVi_Co = item.PhanSau_NGS_KhongThuocPhamVi_Co;
            dbitem.PhanSau_NGS_KhongThuocPhamVi_Khong = item.PhanSau_NGS_KhongThuocPhamVi_Khong;
            dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi_Co = item.PhanSau_TruongKhoa_KhongThuocPhamVi_Co;
            dbitem.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong = item.PhanSau_TruongKhoa_KhongThuocPhamVi_Khong;
            dbitem.ThoiGianTienHanhDenNgay_Ngay = item.ThoiGianTienHanhDenNgay_Ngay;
            dbitem.ThoiGianTienHanhDenNgay_Thang = item.ThoiGianTienHanhDenNgay_Thang;
            dbitem.ThoiGianTienHanhDenNgay_Nam = item.ThoiGianTienHanhDenNgay_Nam;
            dbitem.ThoiGianThuThapDenNgay_Ngay = item.ThoiGianThuThapDenNgay_Ngay;
            dbitem.ThoiGianThuThapDenNgay_Thang = item.ThoiGianThuThapDenNgay_Thang;
            dbitem.ThoiGianThuThapDenNgay_Nam = item.ThoiGianThuThapDenNgay_Nam;
            dbitem.ThoiGianNghienCuuDenNgay_Ngay = item.ThoiGianNghienCuuDenNgay_Ngay;
            dbitem.ThoiGianNghienCuuDenNgay_Thang = item.ThoiGianNghienCuuDenNgay_Thang;
            dbitem.ThoiGianNghienCuuDenNgay_Nam = item.ThoiGianNghienCuuDenNgay_Nam;
            dbitem.ChuKy = item.ChuKy;
            if (item.PhanBa_A != null)
            {
                dbitem.PhanBa_A_JSON = JsonConvert.SerializeObject(item.PhanBa_A);
            }
            else
                dbitem.PhanBa_A_JSON = string.Empty;

            if (item.PhanBa_B != null)
            {
                dbitem.PhanBa_B_JSON = JsonConvert.SerializeObject(item.PhanBa_B);
            }
            else
                dbitem.PhanBa_B_JSON = string.Empty;

            if (item.PhanNam != null)
            {
                dbitem.PhanNam_JSON = JsonConvert.SerializeObject(item.PhanNam);
            }
            else
                dbitem.PhanNam_JSON = string.Empty;

            if (item.MoTaNCYSH != null)
            {
                dbitem.JSON_MoTaNCYSH = JsonConvert.SerializeObject(item.MoTaNCYSH);
            }
            else
                dbitem.JSON_MoTaNCYSH = string.Empty;

            if (item.NCVKhac != null)
            {
                dbitem.JSON_NCVKhac = JsonConvert.SerializeObject(item.NCVKhac);
            }
            else
                dbitem.JSON_NCVKhac = string.Empty;

            dbitem.FormConfig = item.FormConfig;
            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            try
            {
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKiemLuaChonQuyTrinhXXDD", DateTime.Now, Username);
                item.ID = dbitem.ID;
                item.CreatedBy = dbitem.CreatedBy;
                item.CreatedDate = dbitem.CreatedDate;

                item.ModifiedBy = dbitem.ModifiedBy;
                item.ModifiedDate = dbitem.ModifiedDate;
                return item;
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("save_PRO_BangKiemLuaChonQuyTrinhXXDD", e);
                return null;
            }
        }
    }
}
