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
                
            }).FirstOrDefault();
       
            if (query == null)
            {
                //New
                query = new DTO_PRO_BangKiemLuaChonQuyTrinhXXDD
                {
                    IDDeTai = idDeTai
                };

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
                db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Add(dbitem);
            }

            dbitem.IDDeTai = item.IDDeTai;
            dbitem.MaSo = item.MaSo;
            dbitem.PhanMot_ConNguoi = item.PhanMot_ConNguoi;
            dbitem.PhanMot_DongVat = item.PhanMot_DongVat;
            dbitem.PhanHai_TenNCYSH = item.PhanHai_TenNCYSH;
            dbitem.PhanHai_NCVChinh_HoTen = item.PhanHai_NCVChinh_HoTen;
            dbitem.PhanHai_NCVChinh_KhoaPhong = item.PhanHai_NCVChinh_KhoaPhong;
            dbitem.PhanHai_NCVChinh_BenhVien = item.PhanHai_NCVChinh_BenhVien;
            dbitem.PhanHai_NCVChinh_DienThoai = item.PhanHai_NCVChinh_DienThoai;
            dbitem.PhanHai_NCVChinh_Email = item.PhanHai_NCVChinh_Email;
            dbitem.PhanHai_NCVChinh_DiaChiLienHe = item.PhanHai_NCVChinh_DiaChiLienHe;
            dbitem.PhanHai_NGS_HoTen = item.PhanHai_NGS_HoTen;
            dbitem.PhanHai_NGS_NoiLamViec = item.PhanHai_NGS_NoiLamViec;
            dbitem.PhanHai_NGS_DienThoai = item.PhanHai_NGS_DienThoai;
            dbitem.PhanHai_NGS_Email = item.PhanHai_NGS_Email;
            dbitem.PhanBon_C1_MoTaQuyTrinh = item.PhanBon_C1_MoTaQuyTrinh;
            dbitem.PhanBon_C1_NoiNhanMau = item.PhanBon_C1_NoiNhanMau;
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
            dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Co = item.PhanSau_NCYSH_GuiThongBao_KHTH_Co;
            dbitem.PhanSau_NCYSH_GuiThongBao_KHTH_Khong = item.PhanSau_NCYSH_GuiThongBao_KHTH_Khong;
            dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Co = item.PhanSau_NCYSH_GuiThongBao_TCKT_Co;
            dbitem.PhanSau_NCYSH_GuiThongBao_TCKT_Khong = item.PhanSau_NCYSH_GuiThongBao_TCKT_Khong;
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
