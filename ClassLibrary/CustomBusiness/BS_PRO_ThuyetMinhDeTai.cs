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
    public static partial class BS_PRO_ThuyetMinhDeTai
    {
        public static DTO_PRO_ThuyetMinhDeTai get_PRO_ThuyetMinhDeTaiByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_ThuyetMinhDeTai.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false).Select(s => new DTO_PRO_ThuyetMinhDeTai
            {
				ID = s.ID,
				IDDeTai = s.IDDeTai,
				A1_TenTiengViet = s.A1_TenTiengViet,
				A1_TenTiengAnh = s.A1_TenTiengAnh,
				A2_QuanLy = s.A2_QuanLy,
				A2_SinhHocVaCongNghe = s.A2_SinhHocVaCongNghe,
				A2_KhoaHocSucKhoe = s.A2_KhoaHocSucKhoe,
				A2_Khac = s.A2_Khac,
				A2_KhacMoTa = s.A2_KhacMoTa,
				A3_NghienCuuCoBan = s.A3_NghienCuuCoBan,
				A3_NghienCuuUngDung = s.A3_NghienCuuUngDung,
				A3_NghienCuuTrienKhai = s.A3_NghienCuuTrienKhai,
				A4_ThoiGianThucHien = s.A4_ThoiGianThucHien,
				A5_TongKinhPhi = s.A5_TongKinhPhi,
				A6_HoTen = s.A6_HoTen,
				A6_NgaySinh = s.A6_NgaySinh,
				A6_GioiTinh = s.A6_GioiTinh,
				A6_CMND = s.A6_CMND,
				A6_NgayCap = s.A6_NgayCap,
				A6_NoiCap = s.A6_NoiCap,
				A6_MST = s.A6_MST,
				A6_STK = s.A6_STK,
				A6_NganHang = s.A6_NganHang,
				A6_DiaChiCoQuan = s.A6_DiaChiCoQuan,
				A6_DienThoai = s.A6_DienThoai,
				A6_Email = s.A6_Email,
				A6_TomTatHoatDong = s.A6_TomTatHoatDong,
				A7_TenCoQuan = s.A7_TenCoQuan,
				A7_HoTenThuTruong = s.A7_HoTenThuTruong,
				A7_DienThoai = s.A7_DienThoai,
				A7_DiaChi = s.A7_DiaChi,
				A8_CoQuanPhoiHopThucHien = s.A8_CoQuanPhoiHopThucHien,
				A9_JSON_NhanLucNghienCuu = s.A9_JSON_NhanLucNghienCuu,
				B1_GioiThieu = s.B1_GioiThieu,
				B2_TaiLieuThamKhao = s.B2_TaiLieuThamKhao,
				B2_JSON_GioiThieuChuyenGia = s.B2_JSON_GioiThieuChuyenGia,
				B311_MucTieuNghienCuu = s.B311_MucTieuNghienCuu,
				B312_ChiTieuDanhGia = s.B312_ChiTieuDanhGia,
				B313_DiaChi = s.B313_DiaChi,
				B313_JSON_KeHoachThucHien = s.B313_JSON_KeHoachThucHien,
				B321_ThietKeNghienCuu = s.B321_ThietKeNghienCuu,
				B322_DanSoNghienCuu = s.B322_DanSoNghienCuu,
				B3221_TieuChuanNhanLoai = s.B3221_TieuChuanNhanLoai,
				B3222_CoMau = s.B3222_CoMau,
				B323_PhuongPhapTienHanh = s.B323_PhuongPhapTienHanh,
				B324_PhuongPhapDanhGia = s.B324_PhuongPhapDanhGia,
				B3241_YeuToDanhGiaKetQua = s.B3241_YeuToDanhGiaKetQua,
				B3242_CacBienChungDieuTri = s.B3242_CacBienChungDieuTri,
				B3243_CacBienChungVeSanKhoa = s.B3243_CacBienChungVeSanKhoa,
				B325_PhuongPhapPhanTich = s.B325_PhuongPhapPhanTich,
				B326_JSON_CacBienSoCanThuThap = s.B326_JSON_CacBienSoCanThuThap,
				B327_BangKetQuaDuKien = s.B327_BangKetQuaDuKien,
				B328_VanDeYDuc = s.B328_VanDeYDuc,
				B329_TinhKhaThi = s.B329_TinhKhaThi,
				B33_PhuongAnPhoiHop = s.B33_PhuongAnPhoiHop,
				B33_PhuongAnPhoiHopPTN = s.B33_PhuongAnPhoiHopPTN,
				B33_PhuongAnPhoiHopDonVi = s.B33_PhuongAnPhoiHopDonVi,
				B33_PhuongAnPhoiHopCGCN = s.B33_PhuongAnPhoiHopCGCN,
				B4_KetQuaNghienCuu = s.B4_KetQuaNghienCuu,
				B41_AnPhamKhoaHoc = s.B41_AnPhamKhoaHoc,
				B42_DangKySoHuuTriTue = s.B42_DangKySoHuuTriTue,
				B43_KetQuaDaoTao = s.B43_KetQuaDaoTao,
				B5_KhaNangUngDung = s.B5_KhaNangUngDung,
				B51_KhaNangUngDungLinhVucDaoTao = s.B51_KhaNangUngDungLinhVucDaoTao,
				B52_TongHopKinhPhi = s.B52_TongHopKinhPhi,
				B52_JSON_TongHopKinhPhi = s.B52_JSON_TongHopKinhPhi,
				PhuLuc_JSON_KhoanCongLaoDong = s.PhuLuc_JSON_KhoanCongLaoDong,
				PhuLuc_JSON_NguyenVatLieu = s.PhuLuc_JSON_NguyenVatLieu,
				HTML = s.HTML,
				IsDisabled = s.IsDisabled,
				IsDeleted = s.IsDeleted,
				CreatedDate = s.CreatedDate,
				CreatedBy = s.CreatedBy,
				ModifiedDate = s.ModifiedDate,
				ModifiedBy = s.ModifiedBy,
				PhuLuc_JSON_ThietBi = s.PhuLuc_JSON_ThietBi,
				PhuLuc_JSON_ChiKhac = s.PhuLuc_JSON_ChiKhac,
				A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai = s.A9_JSON_NhanLucNghienCuu_ChuNhiemDeTai,
				B52_CoQuanChuTri_NgayKy_Ngay = s.B52_CoQuanChuTri_NgayKy_Ngay,
				B52_CoQuanChuTri_NgayKy_Thang = s.B52_CoQuanChuTri_NgayKy_Thang,
				B52_CoQuanChuTri_NgayKy_Nam = s.B52_CoQuanChuTri_NgayKy_Nam,
				B52_CoQuanChuTri_NgayKy_ChuKy = s.B52_CoQuanChuTri_NgayKy_ChuKy,
				B52_CNDT_NgayKy_Ngay = s.B52_CNDT_NgayKy_Ngay,
				B52_CNDT_NgayKy_Thang = s.B52_CNDT_NgayKy_Thang,
				B52_CNDT_NgayKy_Nam = s.B52_CNDT_NgayKy_Nam,
				B52_CNDT_NgayKy_ChuKy = s.B52_CNDT_NgayKy_ChuKy,
			}).FirstOrDefault();

            if (query == null)
            {
                query = new DTO_PRO_ThuyetMinhDeTai
                {
                    IDDeTai = deTaiId
                };

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == deTaiId);
                if (detai != null)
                {
                    query.A1_TenTiengViet = detai.TenTiengViet;
                    query.A1_TenTiengAnh = detai.TenTiengAnh;

                    var chunhiem = db.tbl_PRO_LLKH.FirstOrDefault(c => c.IDDetai == deTaiId && c.IDNhanSu == detai.IDChuNhiem && c.IsDeleted == false);
                    if (chunhiem != null)
                    {
                        query.A6_HoTen = (!string.IsNullOrEmpty(chunhiem.HocHam) ? chunhiem.HocHam + " " : "") + (!string.IsNullOrEmpty(chunhiem.HocViThacSy) ? chunhiem.HocViThacSy + " " : "") + (!string.IsNullOrEmpty(chunhiem.HocViTienSy) ? chunhiem.HocViTienSy + " " : "") + chunhiem.HoTen;
                        query.A6_NgaySinh = chunhiem.NgaySinh;
                        query.A6_GioiTinh = chunhiem.GioiTinh;
                        query.A6_CMND = chunhiem.CMND;
                        query.A6_NgayCap = chunhiem.CMND_NgayCap;
                        query.A6_NoiCap = chunhiem.CMND_NoiCap;
                        query.A6_MST = chunhiem.TaiKhoan_MST;
                        query.A6_STK = chunhiem.TaiKhoan_STK;
                        query.A6_NganHang = chunhiem.TaiKhoan_NganHang;
                        query.A6_DiaChiCoQuan = chunhiem.DiaChi_CoQuan;
                        query.A6_DienThoai = chunhiem.DienThoai_CaNhan;
                        query.A6_Email = chunhiem.Email_CaNhan;
                    }
                }
            }

            return query;
        }
    }
}
