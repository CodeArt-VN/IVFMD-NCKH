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
    public static partial class BS_PRO_AE
    {
        public static DTO_PRO_AE get_PRO_AEByDeTai(AppEntities db, int deTaiId, int idBenhNhan, int? id = -1)
        {
            DTO_PRO_AE query = null;
            if (id > 0)
            {
                query = db.tbl_PRO_AE.Where(d => d.ID == id).Select(s => new DTO_PRO_AE
                {
                    ID = s.ID,
                    IDDeTai = s.IDDeTai,
                    IDBenhNhan = s.IDBenhNhan,
                    MaSo = s.MaSo,
                    MaSoBenhNhan = s.tbl_CUS_HRM_BenhNhan.MaBenhNhan,
                    TenBienCo = s.TenBienCo,
                    NgayKhoiPhat_Ngay = s.NgayKhoiPhat_Ngay,
                    NgayKhoiPhat_Thang = s.NgayKhoiPhat_Thang,
                    NgayKhoiPhat_Nam = s.NgayKhoiPhat_Nam,
                    NgayKhoiPhat_Gio = s.NgayKhoiPhat_Gio,
                    NgayKhoiPhat_Phut = s.NgayKhoiPhat_Phut,
                    NgayKhoiPhat_DangTiepDien = s.NgayKhoiPhat_DangTiepDien,
                    PhanDoNang_Nghe = s.PhanDoNang_Nghe,
                    PhanDoNang_TrungBinh = s.PhanDoNang_TrungBinh,
                    PhanDoNang_Nang = s.PhanDoNang_Nang,
                    CanDieuTri_Khong = s.CanDieuTri_Khong,
                    CanDieuTri_Co = s.CanDieuTri_Co,
                    HDThuocNghienCuu_KhongApDung = s.HDThuocNghienCuu_KhongApDung,
                    HDThuocNghienCuu_NgungSuDung = s.HDThuocNghienCuu_NgungSuDung,
                    HDThuocDungKem_KhongApDung = s.HDThuocDungKem_KhongApDung,
                    HDThuocDungKem_NgungSuDung = s.HDThuocDungKem_NgungSuDung,
                    LyDoThuocNghienCuu_Khong = s.LyDoThuocNghienCuu_Khong,
                    LyDoThuocNghienCuu_Co = s.LyDoThuocNghienCuu_Co,
                    LyDoThuocDungKem_Khong = s.LyDoThuocDungKem_Khong,
                    LyDoThuocDungKem_Co = s.LyDoThuocDungKem_Co,
                    KetQua_HoiPhucKhongDiChung = s.KetQua_HoiPhucKhongDiChung,
                    KetQua_CoDiChung = s.KetQua_CoDiChung,
                    KetQua_DangHoiPhuc = s.KetQua_DangHoiPhuc,
                    KetQua_ChuaHoiPhuc = s.KetQua_ChuaHoiPhuc,
                    KetQua_KhongBiet = s.KetQua_KhongBiet,
                    KetQua_TuVong_Ngay = s.KetQua_TuVong_Ngay,
                    KetQua_TuVong_Thang = s.KetQua_TuVong_Thang,
                    KetQua_TuVong_Nam = s.KetQua_TuVong_Nam,
                    NghiemTrong_Khong = s.NghiemTrong_Khong,
                    NghiemTrong_Co = s.NghiemTrong_Co,
                    NghiemTrong_TuVong = s.NghiemTrong_TuVong,
                    NghiemTrong_DeDoaTinhMang = s.NghiemTrong_DeDoaTinhMang,
                    NghiemTrong_NhapVien = s.NghiemTrong_NhapVien,
                    NghiemTrong_TanTat = s.NghiemTrong_TanTat,
                    NghiemTrong_BatThuong = s.NghiemTrong_BatThuong,
                    NghiemTrong_BienCoKhac = s.NghiemTrong_BienCoKhac,
                    TienHanhSAE_Khong = s.TienHanhSAE_Khong,
                    TienHanhSAE_Co = s.TienHanhSAE_Co,
                    HoTenThucHien = s.HoTenThucHien,
                    NgayBaoCao_Ngay = s.NgayBaoCao_Ngay,
                    NgayBaoCao_Thang = s.NgayBaoCao_Thang,
                    NgayBaoCao_Nam = s.NgayBaoCao_Nam,
                    NT_NgayGioTangDoNang_Ngay = s.NT_NgayGioTangDoNang_Ngay,
                    NT_NgayGioTangDoNang_Thang = s.NT_NgayGioTangDoNang_Thang,
                    NT_NgayGioTangDoNang_Nam = s.NT_NgayGioTangDoNang_Nam,
                    NT_NgayGioTangDoNang_Gio = s.NT_NgayGioTangDoNang_Gio,
                    NT_NgayGioTangDoNang_Phut = s.NT_NgayGioTangDoNang_Phut,
                    NT_DoNangAE_Nhe = s.NT_DoNangAE_Nhe,
                    NT_DoNangAE_TrungBinh = s.NT_DoNangAE_TrungBinh,
                    NT_DoNangAE_Nang = s.NT_DoNangAE_Nang,
                    NT_YeuCauDieuTri_Khong = s.NT_YeuCauDieuTri_Khong,
                    NT_YeuCauDieuTri_Co = s.NT_YeuCauDieuTri_Co,
                    NT_HDThuocNghienCuu_KhongApDung = s.NT_HDThuocNghienCuu_KhongApDung,
                    NT_HDThuocNghienCuu_NgungSuDung = s.NT_HDThuocNghienCuu_NgungSuDung,
                    NT_HDThuocDungKem_KhongApDung = s.NT_HDThuocDungKem_KhongApDung,
                    NT_HDThuocDungKem_NgungSuDung = s.NT_HDThuocDungKem_NgungSuDung,
                    NT_LyDoThuocNghienCuu_Khong = s.NT_LyDoThuocNghienCuu_Khong,
                    NT_LyDoThuocNghienCuu_Co = s.NT_LyDoThuocNghienCuu_Co,
                    NT_LyDoThuocDungKem_Khong = s.NT_LyDoThuocDungKem_Khong,
                    NT_LyDoThuocDungKem_Co = s.NT_LyDoThuocDungKem_Co,
                    NT_NghiemTrong_Khong = s.NT_NghiemTrong_Khong,
                    NT_NghiemTrong_Co = s.NT_NghiemTrong_Co,
                    NT_NghiemTrong_TuVong = s.NT_NghiemTrong_TuVong,
                    NT_NghiemTrong_DeDoaTinhMang = s.NT_NghiemTrong_DeDoaTinhMang,
                    NT_NghiemTrong_NhapVien = s.NT_NghiemTrong_NhapVien,
                    NT_NghiemTrong_TanTat = s.NT_NghiemTrong_TanTat,
                    NT_NghiemTrong_BatThuong = s.NT_NghiemTrong_BatThuong,
                    NT_NghiemTrong_BienCoKhac = s.NT_NghiemTrong_BienCoKhac,
                    NT_HoTenThucHien = s.NT_HoTenThucHien,
                    NT_NgayBaoCao_Ngay = s.NT_NgayBaoCao_Ngay,
                    NT_NgayBaoCao_Thang = s.NT_NgayBaoCao_Thang,
                    NT_NgayBaoCao_Nam = s.NT_NgayBaoCao_Nam,
                    NT_GhiChu = s.NT_GhiChu,
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
                var objBN = db.tbl_CUS_HRM_BenhNhan.FirstOrDefault(c => c.ID == idBenhNhan);

                query = new DTO_PRO_AE
                {
                    IDDeTai = deTaiId,
                    IDBenhNhan = idBenhNhan,
                    MaSoBenhNhan = objBN != null ? objBN.MaBenhNhan : "________"
                };
            }

            return query;
        }

        public static IQueryable<DTO_PRO_AE> get_PRO_AEByDeTais(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_AE.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false).Select(s => new DTO_PRO_AE
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                IDBenhNhan = s.IDBenhNhan,
                MaSo = s.MaSo,
                MaSoBenhNhan = s.MaSoBenhNhan,
                HoTenBenhNhan = s.tbl_CUS_HRM_BenhNhan.HoTen
            });

            return query;
        }
    }
}
