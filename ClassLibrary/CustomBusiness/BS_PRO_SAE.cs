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
    public static partial class BS_PRO_SAE
    {
        public static DTO_PRO_SAE get_PRO_SAECustom(AppEntities db, int idDeTai, int idBenhNhan, int? id = -1)
        {
            DTO_PRO_SAE query = null;
            if (id > 0)
            {
                query = db.tbl_PRO_SAE.Where(d => d.ID == id).Select(s => new DTO_PRO_SAE
                {
                    ID = s.ID,
                    IDDeTai = s.IDDeTai,
                    IDBenhNhan = s.IDBenhNhan,
                    MaSo = s.MaSo,
                    BaoCaoLanDau = s.BaoCaoLanDau,
                    BaoCaoBoSung = s.BaoCaoBoSung,
                    TuVong = s.TuVong,
                    DeDoaTinhMang = s.DeDoaTinhMang,
                    NhapVien = s.NhapVien,
                    TanTat = s.TanTat,
                    DiTatBamSinh = s.DiTatBamSinh,
                    YeuCanCanThiepYKhoa = s.YeuCanCanThiepYKhoa,
                    TenNghienCuu = s.TenNghienCuu,
                    ThietKeNghienCuu_NhanMo = s.ThietKeNghienCuu_NhanMo,
                    ThietKeNghienCuu_MuDon = s.ThietKeNghienCuu_MuDon,
                    ThietKeNghienCuu_MuDoi = s.ThietKeNghienCuu_MuDoi,
                    MoMu_Co = s.MoMu_Co,
                    MoMu_Khong = s.MoMu_Khong,
                    MoMu_KhongCoThongTin = s.MoMu_KhongCoThongTin,
                    NhaTaiTro = s.NhaTaiTro,
                    HoTenNCV = s.HoTenNCV,
                    DiemNghienCuu = s.DiemNghienCuu,
                    ThoiDiemNhanThongTin = s.ThoiDiemNhanThongTin,
                    ThoiDiemXuatHien = s.ThoiDiemXuatHien,
                    ThoiDiemKetThuc = s.ThoiDiemKetThuc,
                    DangTiepDien = s.DangTiepDien,
                    TenSAE = s.TenSAE,
                    TenNguoiThuThuoc = s.TenNguoiThuThuoc,
                    MaSoNguoiThuThuoc = s.MaSoNguoiThuThuoc,
                    MoTaDienBien = s.MoTaDienBien,
                    KetQua_HoiPhucKhongDiChung = s.KetQua_HoiPhucKhongDiChung,
                    KetQua_HoiPhucCoDiChung = s.KetQua_HoiPhucCoDiChung,
                    KetQua_DangHoiPhuc = s.KetQua_DangHoiPhuc,
                    KetQua_ChuaHoiPhuc = s.KetQua_ChuaHoiPhuc,
                    KetQua_TuVong = s.KetQua_TuVong,
                    KetQua_TuVong_Ngay = s.KetQua_TuVong_Ngay,
                    KetQua_KhongCoThongTin = s.KetQua_KhongCoThongTin,
                    NguoiThamGia_NgaySinh = s.NguoiThamGia_NgaySinh,
                    NguoiThamGia_Tuoi = s.NguoiThamGia_Tuoi,
                    NguoiThamGia_GioiTinh_Nam = s.NguoiThamGia_GioiTinh_Nam,
                    NguoiThamGia_GioiTinh_Nu = s.NguoiThamGia_GioiTinh_Nu,
                    NguoiThamGia_GioiTinh_Nu_DangMangThai = s.NguoiThamGia_GioiTinh_Nu_DangMangThai,
                    NguoiThamGia_GioiTinh_Nu_TuanMangThai = s.NguoiThamGia_GioiTinh_Nu_TuanMangThai,
                    NguoiThamGia_CanNang = s.NguoiThamGia_CanNang,
                    NguoiThamGia_TienSuYKhoa = s.NguoiThamGia_TienSuYKhoa,
                    JSON_ThuocThuLamSang = s.JSON_ThuocThuLamSang,
                    JSON_CanThiepThuocThuLamSang = s.JSON_CanThiepThuocThuLamSang,
                    JSON_ThuocSuDungDongThoi = s.JSON_ThuocSuDungDongThoi,
                    JSON_DanhGiaNCV = s.JSON_DanhGiaNCV,
                    LyDoDanhGia = s.LyDoDanhGia,
                    LyDoDanhGia_SoLuong = s.LyDoDanhGia_SoLuong,
                    LyDoDanhGia_SoLuongNghienCuuKhac = s.LyDoDanhGia_SoLuongNghienCuuKhac,
                    YKienHDDD_NguoiThamGia_TiepTucThamGia = s.YKienHDDD_NguoiThamGia_TiepTucThamGia,
                    YKienHDDD_NguoiThamGia_TamNgungThamGia = s.YKienHDDD_NguoiThamGia_TamNgungThamGia,
                    YKienHDDD_NguoiThamGia_RutKhoiNghienCuu = s.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu,
                    YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai = s.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai,
                    YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai = s.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai,
                    YKienHDDD_DeXuatNghienCuu_NgungTrienKhai = s.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai,
                    YKienHDDD_DeXuatKhac = s.YKienHDDD_DeXuatKhac,
                    NguoiBaoCao_ChuKy = s.NguoiBaoCao_ChuKy,
                    NguoiBaoCao_NgayKy = s.NguoiBaoCao_NgayKy,
                    NguoiBaoCao_HoTen = s.NguoiBaoCao_HoTen,
                    NguoiBaoCao_ChucVu = s.NguoiBaoCao_ChucVu,
                    NguoiBaoCao_DienThoai = s.NguoiBaoCao_DienThoai,
                    NguoiBaoCao_Email = s.NguoiBaoCao_Email,
                    HTML = s.HTML,
                    IsDisabled = s.IsDisabled,
                    IsDeleted = s.IsDeleted,
                    CreatedDate = s.CreatedDate,
                    CreatedBy = s.CreatedBy,
                    ModifiedDate = s.ModifiedDate,
                    ModifiedBy = s.ModifiedBy,
                }).FirstOrDefault();
            }
            else
            {
                query = db.tbl_PRO_SAE.Where(d => d.IDDeTai == idDeTai && d.IDBenhNhan == idBenhNhan && d.IsDeleted == false).Select(s => new DTO_PRO_SAE
                {
                    ID = s.ID,
                    IDDeTai = s.IDDeTai,
                    IDBenhNhan = s.IDBenhNhan,
                    MaSo = s.MaSo,
                    BaoCaoLanDau = s.BaoCaoLanDau,
                    BaoCaoBoSung = s.BaoCaoBoSung,
                    TuVong = s.TuVong,
                    DeDoaTinhMang = s.DeDoaTinhMang,
                    NhapVien = s.NhapVien,
                    TanTat = s.TanTat,
                    DiTatBamSinh = s.DiTatBamSinh,
                    YeuCanCanThiepYKhoa = s.YeuCanCanThiepYKhoa,
                    TenNghienCuu = s.TenNghienCuu,
                    ThietKeNghienCuu_NhanMo = s.ThietKeNghienCuu_NhanMo,
                    ThietKeNghienCuu_MuDon = s.ThietKeNghienCuu_MuDon,
                    ThietKeNghienCuu_MuDoi = s.ThietKeNghienCuu_MuDoi,
                    MoMu_Co = s.MoMu_Co,
                    MoMu_Khong = s.MoMu_Khong,
                    MoMu_KhongCoThongTin = s.MoMu_KhongCoThongTin,
                    NhaTaiTro = s.NhaTaiTro,
                    HoTenNCV = s.HoTenNCV,
                    DiemNghienCuu = s.DiemNghienCuu,
                    ThoiDiemNhanThongTin = s.ThoiDiemNhanThongTin,
                    ThoiDiemXuatHien = s.ThoiDiemXuatHien,
                    ThoiDiemKetThuc = s.ThoiDiemKetThuc,
                    DangTiepDien = s.DangTiepDien,
                    TenSAE = s.TenSAE,
                    TenNguoiThuThuoc = s.TenNguoiThuThuoc,
                    MaSoNguoiThuThuoc = s.MaSoNguoiThuThuoc,
                    MoTaDienBien = s.MoTaDienBien,
                    KetQua_HoiPhucKhongDiChung = s.KetQua_HoiPhucKhongDiChung,
                    KetQua_HoiPhucCoDiChung = s.KetQua_HoiPhucCoDiChung,
                    KetQua_DangHoiPhuc = s.KetQua_DangHoiPhuc,
                    KetQua_ChuaHoiPhuc = s.KetQua_ChuaHoiPhuc,
                    KetQua_TuVong = s.KetQua_TuVong,
                    KetQua_TuVong_Ngay = s.KetQua_TuVong_Ngay,
                    KetQua_KhongCoThongTin = s.KetQua_KhongCoThongTin,
                    NguoiThamGia_NgaySinh = s.NguoiThamGia_NgaySinh,
                    NguoiThamGia_Tuoi = s.NguoiThamGia_Tuoi,
                    NguoiThamGia_GioiTinh_Nam = s.NguoiThamGia_GioiTinh_Nam,
                    NguoiThamGia_GioiTinh_Nu = s.NguoiThamGia_GioiTinh_Nu,
                    NguoiThamGia_GioiTinh_Nu_DangMangThai = s.NguoiThamGia_GioiTinh_Nu_DangMangThai,
                    NguoiThamGia_GioiTinh_Nu_TuanMangThai = s.NguoiThamGia_GioiTinh_Nu_TuanMangThai,
                    NguoiThamGia_CanNang = s.NguoiThamGia_CanNang,
                    NguoiThamGia_TienSuYKhoa = s.NguoiThamGia_TienSuYKhoa,
                    JSON_ThuocThuLamSang = s.JSON_ThuocThuLamSang,
                    JSON_CanThiepThuocThuLamSang = s.JSON_CanThiepThuocThuLamSang,
                    JSON_ThuocSuDungDongThoi = s.JSON_ThuocSuDungDongThoi,
                    JSON_DanhGiaNCV = s.JSON_DanhGiaNCV,
                    LyDoDanhGia = s.LyDoDanhGia,
                    LyDoDanhGia_SoLuong = s.LyDoDanhGia_SoLuong,
                    LyDoDanhGia_SoLuongNghienCuuKhac = s.LyDoDanhGia_SoLuongNghienCuuKhac,
                    YKienHDDD_NguoiThamGia_TiepTucThamGia = s.YKienHDDD_NguoiThamGia_TiepTucThamGia,
                    YKienHDDD_NguoiThamGia_TamNgungThamGia = s.YKienHDDD_NguoiThamGia_TamNgungThamGia,
                    YKienHDDD_NguoiThamGia_RutKhoiNghienCuu = s.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu,
                    YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai = s.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai,
                    YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai = s.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai,
                    YKienHDDD_DeXuatNghienCuu_NgungTrienKhai = s.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai,
                    YKienHDDD_DeXuatKhac = s.YKienHDDD_DeXuatKhac,
                    NguoiBaoCao_ChuKy = s.NguoiBaoCao_ChuKy,
                    NguoiBaoCao_NgayKy = s.NguoiBaoCao_NgayKy,
                    NguoiBaoCao_HoTen = s.NguoiBaoCao_HoTen,
                    NguoiBaoCao_ChucVu = s.NguoiBaoCao_ChucVu,
                    NguoiBaoCao_DienThoai = s.NguoiBaoCao_DienThoai,
                    NguoiBaoCao_Email = s.NguoiBaoCao_Email,
                    HTML = s.HTML,
                    IsDisabled = s.IsDisabled,
                    IsDeleted = s.IsDeleted,
                    CreatedDate = s.CreatedDate,
                    CreatedBy = s.CreatedBy,
                    ModifiedDate = s.ModifiedDate,
                    ModifiedBy = s.ModifiedBy,
                }).FirstOrDefault();
            }
            if (query == null)
            {
                //New
                query = new DTO_PRO_SAE
                {
                    IDDeTai = idDeTai,
                    IDBenhNhan = idBenhNhan
                };

                query.ListCanThiepThuocThuLamSan = new List<DTO_PRO_SAE_CanThiepThuocThuLamSan>() { new DTO_PRO_SAE_CanThiepThuocThuLamSan() };
                query.ListDanhGiaNCV = new List<DTO_PRO_SAE_DanhGiaNCV>() { new DTO_PRO_SAE_DanhGiaNCV() };
                query.ListThuocSuDungDongThoi = new List<DTO_PRO_SAE_ThuocSuDungDongThoi>() { new DTO_PRO_SAE_ThuocSuDungDongThoi() };
                query.ListThuocThuLamSan = new List<DTO_PRO_SAE_ThuocThuLamSan>() { new DTO_PRO_SAE_ThuocThuLamSan() };
            }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.JSON_CanThiepThuocThuLamSang))
                {
                    query.ListCanThiepThuocThuLamSan = JsonConvert.DeserializeObject<List<DTO_PRO_SAE_CanThiepThuocThuLamSan>>(query.JSON_CanThiepThuocThuLamSang);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_DanhGiaNCV))
                {
                    query.ListDanhGiaNCV = JsonConvert.DeserializeObject<List<DTO_PRO_SAE_DanhGiaNCV>>(query.JSON_DanhGiaNCV);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_ThuocSuDungDongThoi))
                {
                    query.ListThuocSuDungDongThoi = JsonConvert.DeserializeObject<List<DTO_PRO_SAE_ThuocSuDungDongThoi>>(query.JSON_ThuocSuDungDongThoi);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_ThuocThuLamSang))
                {
                    query.ListThuocThuLamSan = JsonConvert.DeserializeObject<List<DTO_PRO_SAE_ThuocThuLamSan>>(query.JSON_ThuocThuLamSang);
                }
            }

            return query;
        }

        public static DTO_PRO_SAE save_PRO_SAE(AppEntities db, DTO_PRO_SAE item, string Username)
        {
            var dbitem = db.tbl_PRO_SAE.Find(item.ID);
            if (dbitem == null)
            {
                dbitem = new tbl_PRO_SAE();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                db.tbl_PRO_SAE.Add(dbitem);
            }

            dbitem.IDDeTai = item.IDDeTai;
            dbitem.IDBenhNhan = item.IDBenhNhan;
            dbitem.MaSo = item.MaSo;
            dbitem.BaoCaoLanDau = item.BaoCaoLanDau;
            dbitem.BaoCaoBoSung = item.BaoCaoBoSung;
            dbitem.TuVong = item.TuVong;
            dbitem.DeDoaTinhMang = item.DeDoaTinhMang;
            dbitem.NhapVien = item.NhapVien;
            dbitem.TanTat = item.TanTat;
            dbitem.DiTatBamSinh = item.DiTatBamSinh;
            dbitem.YeuCanCanThiepYKhoa = item.YeuCanCanThiepYKhoa;
            dbitem.TenNghienCuu = item.TenNghienCuu;
            dbitem.ThietKeNghienCuu_NhanMo = item.ThietKeNghienCuu_NhanMo;
            dbitem.ThietKeNghienCuu_MuDon = item.ThietKeNghienCuu_MuDon;
            dbitem.ThietKeNghienCuu_MuDoi = item.ThietKeNghienCuu_MuDoi;
            dbitem.MoMu_Co = item.MoMu_Co;
            dbitem.MoMu_Khong = item.MoMu_Khong;
            dbitem.MoMu_KhongCoThongTin = item.MoMu_KhongCoThongTin;
            dbitem.NhaTaiTro = item.NhaTaiTro;
            dbitem.HoTenNCV = item.HoTenNCV;
            dbitem.DiemNghienCuu = item.DiemNghienCuu;
            dbitem.ThoiDiemNhanThongTin = item.ThoiDiemNhanThongTin;
            dbitem.ThoiDiemXuatHien = item.ThoiDiemXuatHien;
            dbitem.ThoiDiemKetThuc = item.ThoiDiemKetThuc;
            dbitem.DangTiepDien = item.DangTiepDien;
            dbitem.TenSAE = item.TenSAE;
            dbitem.TenNguoiThuThuoc = item.TenNguoiThuThuoc;
            dbitem.MaSoNguoiThuThuoc = item.MaSoNguoiThuThuoc;
            dbitem.MoTaDienBien = item.MoTaDienBien;
            dbitem.KetQua_HoiPhucKhongDiChung = item.KetQua_HoiPhucKhongDiChung;
            dbitem.KetQua_HoiPhucCoDiChung = item.KetQua_HoiPhucCoDiChung;
            dbitem.KetQua_DangHoiPhuc = item.KetQua_DangHoiPhuc;
            dbitem.KetQua_ChuaHoiPhuc = item.KetQua_ChuaHoiPhuc;
            dbitem.KetQua_TuVong = item.KetQua_TuVong;
            dbitem.KetQua_TuVong_Ngay = item.KetQua_TuVong_Ngay;
            dbitem.KetQua_KhongCoThongTin = item.KetQua_KhongCoThongTin;
            dbitem.NguoiThamGia_NgaySinh = item.NguoiThamGia_NgaySinh;
            dbitem.NguoiThamGia_Tuoi = item.NguoiThamGia_Tuoi;
            dbitem.NguoiThamGia_GioiTinh_Nam = item.NguoiThamGia_GioiTinh_Nam;
            dbitem.NguoiThamGia_GioiTinh_Nu = item.NguoiThamGia_GioiTinh_Nu;
            dbitem.NguoiThamGia_GioiTinh_Nu_DangMangThai = item.NguoiThamGia_GioiTinh_Nu_DangMangThai;
            dbitem.NguoiThamGia_GioiTinh_Nu_TuanMangThai = item.NguoiThamGia_GioiTinh_Nu_TuanMangThai;
            dbitem.NguoiThamGia_CanNang = item.NguoiThamGia_CanNang;
            dbitem.NguoiThamGia_TienSuYKhoa = item.NguoiThamGia_TienSuYKhoa;
            dbitem.LyDoDanhGia = item.LyDoDanhGia;
            dbitem.LyDoDanhGia_SoLuong = item.LyDoDanhGia_SoLuong;
            dbitem.LyDoDanhGia_SoLuongNghienCuuKhac = item.LyDoDanhGia_SoLuongNghienCuuKhac;
            dbitem.YKienHDDD_NguoiThamGia_TiepTucThamGia = item.YKienHDDD_NguoiThamGia_TiepTucThamGia;
            dbitem.YKienHDDD_NguoiThamGia_TamNgungThamGia = item.YKienHDDD_NguoiThamGia_TamNgungThamGia;
            dbitem.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu = item.YKienHDDD_NguoiThamGia_RutKhoiNghienCuu;
            dbitem.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai = item.YKienHDDD_DeXuatNghienCuu_TiepTucTrienKhai;
            dbitem.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai = item.YKienHDDD_DeXuatNghienCuu_TamNgungTrienKhai;
            dbitem.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai = item.YKienHDDD_DeXuatNghienCuu_NgungTrienKhai;
            dbitem.YKienHDDD_DeXuatKhac = item.YKienHDDD_DeXuatKhac;
            dbitem.NguoiBaoCao_ChuKy = item.NguoiBaoCao_ChuKy;
            dbitem.NguoiBaoCao_NgayKy = item.NguoiBaoCao_NgayKy;
            dbitem.NguoiBaoCao_HoTen = item.NguoiBaoCao_HoTen;
            dbitem.NguoiBaoCao_ChucVu = item.NguoiBaoCao_ChucVu;
            dbitem.NguoiBaoCao_DienThoai = item.NguoiBaoCao_DienThoai;
            dbitem.NguoiBaoCao_Email = item.NguoiBaoCao_Email;

            if (item.ListThuocThuLamSan != null)
            {
                dbitem.JSON_ThuocThuLamSang = JsonConvert.SerializeObject(item.ListThuocThuLamSan);
            }
            else
                dbitem.JSON_ThuocThuLamSang = string.Empty;

            if (item.ListCanThiepThuocThuLamSan != null)
            {
                dbitem.JSON_CanThiepThuocThuLamSang = JsonConvert.SerializeObject(item.ListCanThiepThuocThuLamSan);
            }
            else
                dbitem.JSON_CanThiepThuocThuLamSang = string.Empty;

            if (item.ListThuocSuDungDongThoi != null)
            {
                dbitem.JSON_ThuocSuDungDongThoi = JsonConvert.SerializeObject(item.ListThuocSuDungDongThoi);
            }
            else
                dbitem.JSON_ThuocSuDungDongThoi = string.Empty;

            if (item.ListDanhGiaNCV != null)
            {
                dbitem.JSON_DanhGiaNCV = JsonConvert.SerializeObject(item.ListDanhGiaNCV);
            }
            else
                dbitem.JSON_DanhGiaNCV = string.Empty;

            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            try
            {
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_SAE", DateTime.Now, Username);
                item.ID = dbitem.ID;
                item.CreatedBy = dbitem.CreatedBy;
                item.CreatedDate = dbitem.CreatedDate;

                item.ModifiedBy = dbitem.ModifiedBy;
                item.ModifiedDate = dbitem.ModifiedDate;
                return item;
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("save_PRO_SAE", e);
                return null;
            }
        }

        public static IQueryable<DTO_PRO_SAE> get_PRO_SAEByDeTais(AppEntities db, int idDeTai)
        {
            var query = db.tbl_PRO_SAE.Where(d => d.IDDeTai == idDeTai && d.IsDeleted == false).Select(s => new DTO_PRO_SAE
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                IDBenhNhan = s.IDBenhNhan,
                MaSo = s.MaSo,
                HoTenBenhNhan = s.tbl_CUS_HRM_BenhNhan.HoTen
            });

            return query;
        }
    }
}
