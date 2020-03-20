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
    public static partial class BS_PRO_BangKhaiNhanSu
    {
        public static DTO_PRO_BangKhaiNhanSu get_PRO_BangKhaiNhanSuByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_BangKhaiNhanSu.Where(d => d.IDDeTai == deTaiId).Select(s => new DTO_PRO_BangKhaiNhanSu
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                YTuong_NguoiThucHien = s.YTuong_NguoiThucHien,
                YTuong_ChiPhi = s.YTuong_ChiPhi,
                PhuongPhap_NguoiThucHien = s.PhuongPhap_NguoiThucHien,
                PhuongPhap_ChiPhi = s.PhuongPhap_ChiPhi,
                QuyTrinhNhanMau_NguoiThucHien = s.QuyTrinhNhanMau_NguoiThucHien,
                QuyTrinhNhanMau_ChiPhi = s.QuyTrinhNhanMau_ChiPhi,
                ThucHienNhanMau_NguoiThucHien = s.ThucHienNhanMau_NguoiThucHien,
                ThucHienNhanMau_ChiPhi = s.ThucHienNhanMau_ChiPhi,
                NhapDuLieuVaoPM_NguoiThucHien = s.NhapDuLieuVaoPM_NguoiThucHien,
                NhapDuLieuVaoPM_ChiPhi = s.NhapDuLieuVaoPM_ChiPhi,
                VietBaiBaoCaoTiengViet_NguoiThucHien = s.VietBaiBaoCaoTiengViet_NguoiThucHien,
                VietBaiBaoCaoTiengViet_ChiPhi = s.VietBaiBaoCaoTiengViet_ChiPhi,
                VietBaiBaoCaoTiengAnh_NguoiThucHien = s.VietBaiBaoCaoTiengAnh_NguoiThucHien,
                VietBaiBaoCaoTiengAnh_ChiPhi = s.VietBaiBaoCaoTiengAnh_ChiPhi,
                ReviewTinhKhaThi_NguoiThucHien = s.ReviewTinhKhaThi_NguoiThucHien,
                ReviewTinhKhaThi_ChiPhi = s.ReviewTinhKhaThi_ChiPhi,
                XayDungPhanMem_NguoiThucHien = s.XayDungPhanMem_NguoiThucHien,
                XayDungPhanMem_ChiPhi = s.XayDungPhanMem_ChiPhi,
                XayDungKeHoachPhanTich_NguoiThucHien = s.XayDungKeHoachPhanTich_NguoiThucHien,
                XayDungKeHoachPhanTich_ChiPhi = s.XayDungKeHoachPhanTich_ChiPhi,
                LamSachSoLieu_NguoiThucHien = s.LamSachSoLieu_NguoiThucHien,
                LamSachSoLieu_ChiPhi = s.LamSachSoLieu_ChiPhi,
                PhanTichSoLieu_NguoiThucHien = s.PhanTichSoLieu_NguoiThucHien,
                PhanTichSoLieu_ChiPhi = s.PhanTichSoLieu_ChiPhi,
                XayDungKeHoachDieuPhoi_NguoiThucHien = s.XayDungKeHoachDieuPhoi_NguoiThucHien,
                XayDungKeHoachDieuPhoi_ChiPhi = s.XayDungKeHoachDieuPhoi_ChiPhi,
                ChuanBiHoSoGiayTo_NguoiThucHien = s.ChuanBiHoSoGiayTo_NguoiThucHien,
                ChuanBiHoSoGiayTo_ChiPhi = s.ChuanBiHoSoGiayTo_ChiPhi,
                DieuPhoiHoatDongNghienCuu_NguoiThucHien = s.DieuPhoiHoatDongNghienCuu_NguoiThucHien,
                DieuPhoiHoatDongNghienCuu_ChiPhi = s.DieuPhoiHoatDongNghienCuu_ChiPhi,
                QuanLyDieuHanhChung_NguoiThucHien = s.QuanLyDieuHanhChung_NguoiThucHien,
                QuanLyDieuHanhChung_ChiPhi = s.QuanLyDieuHanhChung_ChiPhi,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            }).FirstOrDefault();

            if(query == null)
            {
                query = new DTO_PRO_BangKhaiNhanSu
                {
                    ID = 0,
                    IDDeTai = deTaiId
                };

                var thuyetminh = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == deTaiId && c.IsDeleted == false);
                if (thuyetminh != null && !string.IsNullOrEmpty(thuyetminh.B313_JSON_KeHoachThucHien))
                {
                    try
                    {
                        List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien>>(thuyetminh.B313_JSON_KeHoachThucHien);
                        foreach (var item in lst)
                        {
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietDeCuong)
                            {
                                query.YTuong_NguoiThucHien = item.NguoiThucHien;
                                query.PhuongPhap_NguoiThucHien = item.NguoiThucHien;
                            }
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.ThuThapSoLieu)
                            {
                                query.QuyTrinhNhanMau_NguoiThucHien = item.NguoiThucHien;
                                query.ThucHienNhanMau_NguoiThucHien = item.NguoiThucHien;
                                query.NhapDuLieuVaoPM_NguoiThucHien = item.NguoiThucHien;
                            }
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoTrongNuoc)
                                query.VietBaiBaoCaoTiengViet_NguoiThucHien = item.NguoiThucHien;
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoQuocTe)
                                query.VietBaiBaoCaoTiengAnh_NguoiThucHien = item.NguoiThucHien;
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.PhanTichSoLieuCuoiCung)
                                query.PhanTichSoLieu_NguoiThucHien = item.NguoiThucHien;
                        }
                    }
                    catch { }
                }

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == deTaiId);
                if (detai != null)
                    query.QuanLyDieuHanhChung_NguoiThucHien = detai.tbl_CUS_HRM_STAFF_NhanSu1.Name + "/" + detai.tbl_CUS_HRM_STAFF_NhanSu.Name;
            }

            return query;
        }

        public static void refresh_PRO_BangKhaiNhanSuByDeTai(AppEntities db, int deTaiId, string Username)
        {
            var dbitem = db.tbl_PRO_BangKhaiNhanSu.Where(d => d.IDDeTai == deTaiId).FirstOrDefault();
            if (dbitem != null)
            {
                var thuyetminh = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == deTaiId && c.IsDeleted == false);
                if (thuyetminh != null && !string.IsNullOrEmpty(thuyetminh.B313_JSON_KeHoachThucHien))
                {
                    try
                    {
                        List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien>>(thuyetminh.B313_JSON_KeHoachThucHien);
                        foreach (var item in lst)
                        {
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietDeCuong)
                            {
                                dbitem.YTuong_NguoiThucHien = item.NguoiThucHien;
                                dbitem.PhuongPhap_NguoiThucHien = item.NguoiThucHien;
                            }
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.ThuThapSoLieu)
                            {
                                dbitem.QuyTrinhNhanMau_NguoiThucHien = item.NguoiThucHien;
                                dbitem.ThucHienNhanMau_NguoiThucHien = item.NguoiThucHien;
                                dbitem.NhapDuLieuVaoPM_NguoiThucHien = item.NguoiThucHien;
                            }
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoTrongNuoc)
                                dbitem.VietBaiBaoCaoTiengViet_NguoiThucHien = item.NguoiThucHien;
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoQuocTe)
                                dbitem.VietBaiBaoCaoTiengAnh_NguoiThucHien = item.NguoiThucHien;
                            if (item.NoiDung == DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.PhanTichSoLieuCuoiCung)
                                dbitem.PhanTichSoLieu_NguoiThucHien = item.NguoiThucHien;
                        }
                    }
                    catch { }
                }

                var detai = db.tbl_PRO_DeTai.FirstOrDefault(c => c.ID == deTaiId);
                if (detai != null)
                    dbitem.QuanLyDieuHanhChung_NguoiThucHien = detai.tbl_CUS_HRM_STAFF_NhanSu1.Name + "/" + detai.tbl_CUS_HRM_STAFF_NhanSu.Name;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKhaiNhanSu", DateTime.Now, Username);
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("refresh_PRO_BangKhaiNhanSuByDeTai", e);
                }
            }
        }

    }
}
