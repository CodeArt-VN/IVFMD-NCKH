﻿using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorEngine;
using RazorEngine.Templating; // Dont forget to include this.
namespace BaseBusiness
{
    public static partial class BS_PRO_DeTai
    {
        public static DTO_PRO_DeTai get_PRO_DeTaiByID(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PRO_DeTai.Find(id);

            if (dbResult == null || dbResult.IDPartner != PartnerID)
                return null;
            else
            {
                var detai = toDTO(dbResult);
                if (detai != null)
                {
                    detai.Tags = db.tbl_PRO_Tags.Where(c => c.IDDeTai == id).Select(c => new DTO_PRO_DeTai_Tag
                    {
                        ID = c.IDTag,
                        TenTag = c.tbl_CAT_Tags.TenTag
                    }).ToList();
                }
                return detai;
            }


        }

        public static DTO_PRO_DeTai save_PRO_DeTai(AppEntities db, int PartnerID, int ID, int StaffID, DTO_PRO_DeTai item, string Username)
        {
            tbl_PRO_DeTai dbitem = db.tbl_PRO_DeTai.Find(ID);
            if (dbitem == null)
            {
                dbitem = new tbl_PRO_DeTai();
                dbitem.IDNCV = StaffID;
                dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_ChoGui;
                dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_ChoGui;
                dbitem.IDTrangThai_HRCO = -(int)SYSVarType.TrangThai_HRCO_ChoGui;
                dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_ChoGui;
                dbitem.IDPhanLoaiDeTai = -(int)SYSVarType.PhanLoaiDeTai_NghienCuu;
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                dbitem.IDLinhVuc = item.IDLinhVuc;
                db.tbl_PRO_DeTai.Add(dbitem);

                //Tạo mới 
                //SYLL CNDT
                //LLKH CNDT
                //SYLL NCV
                //LLKH NCV
                using (CopyHelper helperCopy = new CopyHelper())
                {
                    //SYLL_CN
                    if (item.IDChuNhiem > 0)
                    {
                        var objHRM_SYLL_CN = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.FirstOrDefault(c => c.IDNhanSu == item.IDChuNhiem.Value);
                        tbl_PRO_SYLL objSYLL_CN = new tbl_PRO_SYLL();
                        if (objHRM_SYLL_CN != null)
                        {
                            helperCopy.Copy(objHRM_SYLL_CN, objSYLL_CN);
                            objSYLL_CN.ID = 0;
                        }

                        objSYLL_CN.IDNhanSu = item.IDChuNhiem.Value;
                        objSYLL_CN.tbl_PRO_DeTai = dbitem;
                        objSYLL_CN.CreatedBy = Username;
                        objSYLL_CN.CreatedDate = DateTime.Now;
                        objSYLL_CN.IsDisabled = item.IsDisabled;
                        objSYLL_CN.IsDeleted = item.IsDeleted;
                        db.tbl_PRO_SYLL.Add(objSYLL_CN);

                        //LLKH_CN
                        var objHRM_LLKH_CN = db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.FirstOrDefault(c => c.IDNhanSu == item.IDChuNhiem.Value);
                        tbl_PRO_LLKH objLLKH_CN = new tbl_PRO_LLKH();
                        if (objHRM_LLKH_CN != null)
                        {
                            helperCopy.Copy(objHRM_LLKH_CN, objLLKH_CN);
                            objLLKH_CN.ID = 0;
                        }
                        objLLKH_CN.IDNhanSu = item.IDChuNhiem.Value;
                        objLLKH_CN.tbl_PRO_DeTai = dbitem;
                        objLLKH_CN.CreatedBy = Username;
                        objLLKH_CN.CreatedDate = DateTime.Now;
                        objLLKH_CN.IsDisabled = item.IsDisabled;
                        objLLKH_CN.IsDeleted = item.IsDeleted;
                        db.tbl_PRO_LLKH.Add(objLLKH_CN);
                    }
                    //SYLL_NCV
                    var objHRM_SYLL_NCV = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.FirstOrDefault(c => c.IDNhanSu == StaffID);
                    tbl_PRO_SYLL objSYLL_NCV = new tbl_PRO_SYLL();
                    if (objHRM_SYLL_NCV != null)
                    {
                        helperCopy.Copy(objHRM_SYLL_NCV, objSYLL_NCV);
                        objSYLL_NCV.ID = 0;
                    }
                    objSYLL_NCV.IDNhanSu = dbitem.IDNCV;
                    objSYLL_NCV.tbl_PRO_DeTai = dbitem;
                    objSYLL_NCV.CreatedBy = Username;
                    objSYLL_NCV.CreatedDate = DateTime.Now;
                    objSYLL_NCV.IsDisabled = item.IsDisabled;
                    objSYLL_NCV.IsDeleted = item.IsDeleted;
                    db.tbl_PRO_SYLL.Add(objSYLL_NCV);

                    //LLKH_NCV
                    var objHRM_LLKH_NCV = db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.FirstOrDefault(c => c.IDNhanSu == StaffID);
                    tbl_PRO_LLKH objLLKH_NCV = new tbl_PRO_LLKH();
                    if (objHRM_LLKH_NCV != null)
                    {
                        helperCopy.Copy(objHRM_LLKH_NCV, objLLKH_NCV);
                        objLLKH_NCV.ID = 0;
                    }
                    objLLKH_NCV.IDNhanSu = dbitem.IDNCV;
                    objLLKH_NCV.tbl_PRO_DeTai = dbitem;
                    objLLKH_NCV.CreatedBy = Username;
                    objLLKH_NCV.CreatedDate = DateTime.Now;
                    objLLKH_NCV.IsDisabled = item.IsDisabled;
                    objLLKH_NCV.IsDeleted = item.IsDeleted;
                    db.tbl_PRO_LLKH.Add(objLLKH_NCV);
                }
            }
            if (item != null)
            {
                dbitem.IDChuNhiem = item.IDChuNhiem;
                dbitem.IDHRCO = item.IDHRCO;
                dbitem.DeTai = item.DeTai;
                dbitem.GhiChu = item.GhiChu;
                dbitem.SoNCT = item.SoNCT;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;
                dbitem.MaSo = item.MaSo;
                dbitem.TenTiengViet = item.TenTiengViet;
                dbitem.TenTiengAnh = item.TenTiengAnh;
                dbitem.FileUpload = item.FileUpload;
                dbitem.MaSoHDDD = item.MaSoHDDD;
                dbitem.MaSoProtocalID = item.MaSoProtocalID;
                dbitem.IDHinhThucXetDuyet = item.IDHinhThucXetDuyet;
                dbitem.IDTinhTrangNghienCuu = item.IDTinhTrangNghienCuu;
                if (dbitem.IDLinhVuc == null)
                    dbitem.IDLinhVuc = item.IDLinhVuc;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                dbitem.IDPartner = PartnerID;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PRO_DeTai", DateTime.Now, Username);

                    BS_HelperReference.PRO_DeTai_Update(db, dbitem.ID);

                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                    item.IDPartner = dbitem.IDPartner;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_PRO_DeTai", e);
                    item = null;
                }
            }

            #region Tags
            foreach (var itemTag in db.tbl_PRO_Tags.Where(c => c.IDDeTai == dbitem.ID))
            {
                db.tbl_PRO_Tags.Remove(itemTag);
            }
            if (item.Tags != null && item.Tags.Count > 0 && dbitem.ID > 0)
            {
                foreach (var itemTag in item.Tags)
                {
                    tbl_PRO_Tags tag = new tbl_PRO_Tags
                    {
                        CreatedBy = Username,
                        CreatedDate = DateTime.Now,
                        IDDeTai = dbitem.ID,
                        IDTag = itemTag.ID,
                    };
                    db.tbl_PRO_Tags.Add(tag);
                }
                db.SaveChanges();
            }
            #endregion

            return item;
        }

        public static DTO_PRO_DeTai get_PRO_DeTaiCustom(AppEntities db, int ID, int StaffID)
        {
            var queryData = db.tbl_PRO_DeTai.Where(c => c.IsDeleted == false && c.ID == ID);
            var staff = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(c => c.ID == StaffID);
            if (staff != null)
            {
                if (staff.tbl_CUS_SYS_Role == null || staff.tbl_CUS_SYS_Role.Code != "ADMIN")
                    queryData = queryData.Where(c => c.IDNCV == staff.ID || c.IDChuNhiem == staff.ID || (c.tbl_PRO_NCVKhac.Count > 0 && c.tbl_PRO_NCVKhac.Any(d => d.IDNCV == staff.ID)));
            }
            var query = queryData.Select(s => new DTO_PRO_DeTai
            {
                ID = s.ID,
                IDPartner = s.IDPartner,
                IDNCV = s.IDNCV,
                IDChuNhiem = s.IDChuNhiem,
                IDHRCO = s.IDHRCO,
                IDPhanLoaiDeTai = s.IDPhanLoaiDeTai,
                IDTrangThai_HDDD = s.IDTrangThai_HDDD,
                IDTrangThai_HDKH = s.IDTrangThai_HDKH,
                IDTrangThai_HRCO = s.IDTrangThai_HRCO,
                IDTrangThai_NghiemThu = s.IDTrangThai_NghiemThu,
                TrangThai_HDDD = s.tbl_SYS_Var1.ValueOfVar,
                TrangThai_HDKH = s.tbl_SYS_Var2.ValueOfVar,
                TrangThai_HRCO = s.tbl_SYS_Var3.ValueOfVar,
                TrangThai_NghiemThu = s.tbl_SYS_Var4.ValueOfVar,
                DeTai = s.DeTai,
                GhiChu = s.GhiChu,
                SoNCT = s.SoNCT,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                MaSo = s.MaSo,
                TenTiengViet = s.TenTiengViet,
                TenTiengAnh = s.TenTiengAnh,
                FileUpload = s.FileUpload,
                MaSoHDDD = s.MaSoHDDD,
                MaSoProtocalID = s.MaSoProtocalID,
                IDHinhThucXetDuyet = s.IDHinhThucXetDuyet,
                IDTinhTrangNghienCuu = s.IDTinhTrangNghienCuu,
                BaiFullTextNghiemThu = "",
                FileChapThuan = s.FileChapThuan,
                IsDisabledHDDD = s.IsDisabledHDDD ?? false,
                IsDisabledHRCO = s.IsDisabledHRCO ?? false,
                IDLinhVuc = s.IDLinhVuc,
                LinhVuc = s.IDLinhVuc > 0 ? s.tbl_CAT_LinhVuc.Name : ""
            }).FirstOrDefault();

            if (query != null)
            {
                query.Tags = db.tbl_PRO_Tags.Where(c => c.IDDeTai == query.ID).Select(c => new DTO_PRO_DeTai_Tag
                {
                    ID = c.IDTag,
                    TenTag = c.tbl_CAT_Tags.TenTag
                }).ToList();

                query.ListFormStatus = new List<DTO_PRO_DeTai_TrangThai>();

                if (db.tbl_PRO_Sysnopsis.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = 0, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_Sysnopsis", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = 0, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_Sysnopsis", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_MauPhanTichDuLieu.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 1, Type = 0, Name = "Đăng kí phân tích", Description = "Đăng kí phân tích", FormCode = "tbl_PRO_MauPhanTichDuLieu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 1, Type = 0, Name = "Đăng kí phân tích", Description = "Đăng kí phân tích", FormCode = "tbl_PRO_MauPhanTichDuLieu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_DonXinDanhGiaDaoDuc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 2, Type = 1, Name = "Xét duyệt HĐĐĐ", Description = "Đơn xin đánh giá đạo đức trong nghiên cứu", FormCode = "tbl_PRO_DonXinDanhGiaDaoDuc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 2, Type = 1, Name = "Xét duyệt HĐĐĐ", Description = "Đơn xin đánh giá đạo đức trong nghiên cứu", FormCode = "tbl_PRO_DonXinDanhGiaDaoDuc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                //if (db.tbl_PRO_LLKH.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDChuNhiem && c.IsDeleted == false))
                //    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 4, Type = 1, Name = "Lý lịch khoa học CNĐT", Description = "Lý lịch khoa học CNĐT", FormCode = "tbl_PRO_LLKH", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                //else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 4, Type = 1, Name = "Lý lịch khoa học CNĐT", Description = "Lý lịch khoa học CNĐT", FormCode = "tbl_PRO_LLKH", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                //if (db.tbl_PRO_SYLL.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDChuNhiem && c.IsDeleted == false))
                //    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 5, Type = 1, Name = "Sơ yếu lý lịch CNĐT", Description = "Sơ yếu lý lịch CNĐT", FormCode = "tbl_PRO_SYLL", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                //else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 5, Type = 1, Name = "Sơ yếu lý lịch CNĐT", Description = "Sơ yếu lý lịch CNĐT", FormCode = "tbl_PRO_SYLL", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                //if (db.tbl_PRO_LLKH.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDNCV && c.IsDeleted == false))
                //    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 6, Type = 1, Name = "Lý lịch khoa học NCV chính", Description = "Lý lịch khoa học NCV chính", FormCode = "tbl_PRO_LLKH", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                //else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 6, Type = 1, Name = "Lý lịch khoa học NCV chính", Description = "Lý lịch khoa học NCV chính", FormCode = "tbl_PRO_LLKH", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                //if (db.tbl_PRO_SYLL.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDNCV && c.IsDeleted == false))
                //    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 7, Type = 1, Name = "Sơ yếu lý lịch NCV chính", Description = "Sơ yếu lý lịch NCV chính", FormCode = "tbl_PRO_SYLL", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                //else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 7, Type = 1, Name = "Sơ yếu lý lịch NCV chính", Description = "Sơ yếu lý lịch NCV chính", FormCode = "tbl_PRO_SYLL", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                //if (db.tbl_PRO_ThuyetMinhDeTai.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                //    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 8, Type = 1, Name = "Thuyết minh đề tài", Description = "Thuyết minh đề tài", FormCode = "tbl_PRO_ThuyetMinhDeTai", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                //else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 8, Type = 1, Name = "Thuyết minh đề tài", Description = "Thuyết minh đề tài", FormCode = "tbl_PRO_ThuyetMinhDeTai", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_DonXinNghiemThu.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 9, Type = 4, Name = "Nghiệm thu", Description = "Đơn xin nghiệm thu", FormCode = "tbl_PRO_DonXinNghiemThu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 9, Type = 4, Name = "Nghiệm thu", Description = "Đơn xin nghiệm thu", FormCode = "tbl_PRO_DonXinNghiemThu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (query.IDHinhThucXetDuyet == -(int)SYSVarType.HinhThucXetDuyet_DayDu)
                {
                    if (db.tbl_PRO_PhieuXemXetDaoDuc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                        query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 10, Type = 1, Name = "Phiếu thông tin xem xét đạo đức", Description = "Phiếu thông tin xem xét đạo đức theo quy trình đầy đủ", FormCode = "tbl_PRO_PhieuXemXetDaoDuc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                    else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 10, Type = 1, Name = "Phiếu thông tin xem xét đạo đức", Description = "Phiếu thông tin xem xét đạo đức theo quy trình đầy đủ", FormCode = "tbl_PRO_PhieuXemXetDaoDuc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
                }

                if (db.tbl_PRO_AE.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 12, Type = 3, Name = "Báo cáo AE", Description = "Báo cáo AE", FormCode = "tbl_PRO_AE", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 12, Type = 3, Name = "Báo cáo AE", Description = "Báo cáo AE", FormCode = "tbl_PRO_AE", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_SAE.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 13, Type = 3, Name = "Báo cáo SAE", Description = "Báo cáo SAE", FormCode = "tbl_PRO_SAE", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 13, Type = 3, Name = "Báo cáo SAE", Description = "Báo cáo SAE", FormCode = "tbl_PRO_SAE", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_BaoCaoTienDoNghienCuu.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 11, Type = 3, Name = "Tiến độ nghiên cứu", Description = "Báo cáo tiến độ nghiên cứu", FormCode = "tbl_PRO_BaoCaoTienDoNghienCuu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 11, Type = 3, Name = "Tiến độ nghiên cứu", Description = "Báo cáo tiến độ nghiên cứu", FormCode = "tbl_PRO_BaoCaoTienDoNghienCuu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (query.IDHinhThucXetDuyet == -(int)SYSVarType.HinhThucXetDuyet_RutGon)
                {
                    if (db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                        query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 14, Type = 1, Name = "Bảng kiểm lựa chọn quy trình XXĐĐ rút gọn", Description = "Bảng kiểm lựa chọn quy trình xem xét đạo đức rút gọn", FormCode = "tbl_PRO_BangKiemLuaChonQuyTrinhXXDD", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                    else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 14, Type = 1, Name = "Bảng kiểm lựa chọn quy trình XXĐĐ rút gọn", Description = "Bảng kiểm lựa chọn quy trình xem xét đạo đức rút gọn", FormCode = "tbl_PRO_BangKiemLuaChonQuyTrinhXXDD", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
                }
                //if (db.tbl_PRO_BaoCaoNghiemThuDeTai.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                //    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 15, Type = 4, Name = "Báo cáo tổng hợp", Description = "Báo cáo tổng hợp", FormCode = "tbl_PRO_BaoCaoNghiemThuDeTai", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                //else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 15, Type = 4, Name = "Báo cáo tổng hợp", Description = "Báo cáo tổng hợp", FormCode = "tbl_PRO_BaoCaoNghiemThuDeTai", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                var nghiemthu = db.tbl_PRO_BaoCaoNghiemThuDeTai.FirstOrDefault(c => c.IDDeTai == ID && c.IsDeleted == false);
                if (nghiemthu != null)
                {
                    //query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 16, Type = 4, Name = "Upload bài fulltext", Description = "Upload bài fulltext", FormCode = "tbl_PRO_BaoCaoNghiemThuDeTai", TrangThai = "Đã up", TrangThaiCode = "File" });
                    query.BaiFullTextNghiemThu = nghiemthu.BaiFulltext;
                    query.FileBaoCaoTongHop = nghiemthu.FileBaoCaoTongHop;
                }

                var thuyetminh = db.tbl_PRO_ThuyetMinhDeTai.FirstOrDefault(c => c.IDDeTai == ID && c.IsDeleted == false);
                if (thuyetminh != null)
                {
                    query.FileThuyetMinh = thuyetminh.FileThuyetMinh;
                }

                //else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 16, Type = 4, Name = "Upload bài fulltext", Description = "Upload bài fulltext", FormCode = "tbl_PRO_BaoCaoNghiemThuDeTai", TrangThai = "Chưa up", TrangThaiCode = "File" });

                if (db.tbl_PRO_BangKhaiNhanSu.Any(c => c.IDDeTai == ID))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 17, Type = 4, Name = "Bảng khai chi tiết nhân sự", Description = "Bảng khai chi tiết nhân sự tham gia nghiên cứu", FormCode = "tbl_PRO_BangKhaiNhanSu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 17, Type = 4, Name = "Bảng khai chi tiết nhân sự", Description = "Bảng khai chi tiết nhân sự tham gia nghiên cứu", FormCode = "tbl_PRO_BangKhaiNhanSu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

            }
            return query;
        }

        public static DTO_StatusResult updateStatus_PRO_DeTai(AppEntities db, int ID, string ActionCode, int typeId, string Username)
        {
            DTO_StatusResult result = new DTO_StatusResult();
            result.ListEmail = new List<DTO_Email>();

            tbl_PRO_DeTai dbitem = db.tbl_PRO_DeTai.Find(ID);

            if (dbitem != null)
            {
                #region HRCO
                #region Gửi Duyệt
                if (ActionCode == "SendHRCO")
                {
                    if (db.tbl_CUS_HRM_STAFF_NhanSu.Count(c => c.IsDeleted == false && c.IDRole > 0 && c.tbl_CUS_SYS_Role.Code == "ADMIN") == 0)
                    {
                        result.Error = "Chưa thiết lập nhân sự ban HRCO";
                        return result;
                    }

                    if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoGui)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HRCO;
                        dbitem.IDTrangThai_HRCO = -(int)SYSVarType.TrangThai_HRCO_ChoDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HRCO;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();

                        foreach (var item in db.tbl_PRO_HRCO.Where(c => c.IDDeTai == ID))
                            db.tbl_PRO_HRCO.Remove(item);

                        var lstNhanSuID = db.tbl_CAT_HRCOConfig.Where(c => c.IsDeleted == false).Select(c => c.IDNhanSu).Distinct().ToList();
                        foreach (var item in lstNhanSuID)
                        {
                            tbl_PRO_HRCO obj = new tbl_PRO_HRCO
                            {
                                CreatedBy = Username,
                                CreatedDate = DateTime.Now,
                                IDDeTai = ID,
                                IDNhanSu = item,
                            };
                            db.tbl_PRO_HRCO.Add(obj);
                        }
                        db.SaveChanges();

                        #region Gửi email cho NCV
                        var emailTemplate = BS_SYS_Config.get_SYS_ConfigEmail_Template(db, SYSConfigCode.EmailGuiHDNB_NCV.ToString());
                        if (emailTemplate != null && !string.IsNullOrEmpty(emailTemplate.Subject) && !string.IsNullOrEmpty(emailTemplate.Body))
                        {
                            string template = emailTemplate.Body;
                            string subject = emailTemplate.Subject;
                            var ncvChinh = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDNCV);
                            var chuNhiem = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDChuNhiem);

                            var htmlSubject = Engine.Razor.RunCompile(subject, SYSConfigCode.EmailGuiHDNB_NCV.ToString(), null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            var htmlBody = Engine.Razor.RunCompile(template, SYSConfigCode.EmailGuiHDNB_NCV.ToString() + "_body", null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            result.ListEmail.Add(new DTO_Email { Body = htmlBody, Subject = htmlSubject, Destination = ncvChinh.Email });
                        }
                        #endregion

                        #region Gửi email cho HRCO
                        emailTemplate = BS_SYS_Config.get_SYS_ConfigEmail_Template(db, SYSConfigCode.EmailGuiHDNB_HRCO.ToString());
                        if (emailTemplate != null && !string.IsNullOrEmpty(emailTemplate.Subject) && !string.IsNullOrEmpty(emailTemplate.Body) && !string.IsNullOrEmpty(emailTemplate.EmailList))
                        {
                            string template = emailTemplate.Body;
                            string subject = emailTemplate.Subject;
                            var ncvChinh = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDNCV);
                            var chuNhiem = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDChuNhiem);

                            var htmlSubject = Engine.Razor.RunCompile(subject, SYSConfigCode.EmailGuiHDNB_HRCO.ToString(), null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            var htmlBody = Engine.Razor.RunCompile(template, SYSConfigCode.EmailGuiHDNB_HRCO.ToString() + "_body", null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            var lstEmail = emailTemplate.EmailList.Split(';');
                            foreach (var item in lstEmail)
                            {
                                if (!string.IsNullOrEmpty(item))
                                    result.ListEmail.Add(new DTO_Email { Body = htmlBody, Subject = htmlSubject, Destination = item.Trim() });
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        result.Error = "Đã gửi trước đó, vui lòng chờ duyệt";
                        return result;
                    }
                }
                #endregion

                #region Hủy Gửi 
                if (ActionCode == "UnSendHRCO")
                {
                    if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HRCO;
                        dbitem.IDTrangThai_HRCO = -(int)SYSVarType.TrangThai_HRCO_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HRCO;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy gửi";
                        return result;
                    }
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_DaDuyet)
                    {
                        result.Error = "Đề tài đã được duyệt, không thể hủy gửi";
                        return result;
                    }
                }
                #endregion

                #region Duyệt
                if (ActionCode == "ApprovedHRCO")
                {
                    if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HRCO;
                        dbitem.IDTrangThai_HRCO = -(int)SYSVarType.TrangThai_HRCO_DaDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HRCO;
                        if (typeId > 0)
                            dbitem.IDHinhThucXetDuyet = typeId;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);

                        dbitem.IsDisabledHRCO = true;

                        db.SaveChanges();

                        #region Gửi email cho NCV
                        var emailTemplate = BS_SYS_Config.get_SYS_ConfigEmail_Template(db, SYSConfigCode.EmailHDNBDuyet_NCV.ToString());
                        if (emailTemplate != null && !string.IsNullOrEmpty(emailTemplate.Subject) && !string.IsNullOrEmpty(emailTemplate.Body))
                        {
                            string template = emailTemplate.Body;
                            string subject = emailTemplate.Subject;
                            var ncvChinh = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDNCV);
                            var chuNhiem = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDChuNhiem);

                            var htmlSubject = Engine.Razor.RunCompile(subject, SYSConfigCode.EmailHDNBDuyet_NCV.ToString(), null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            var htmlBody = Engine.Razor.RunCompile(template, SYSConfigCode.EmailHDNBDuyet_NCV.ToString() + "_body", null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            result.ListEmail.Add(new DTO_Email { Body = htmlBody, Subject = htmlSubject, Destination = ncvChinh.Email });
                        }
                        #endregion
                    }
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được duyệt trước đó";
                        return result;
                    }
                }
                #endregion

                #region Hủy Duyệt
                if (ActionCode == "UnApprovedHRCO")
                {
                    if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_DaDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HRCO;
                        dbitem.IDTrangThai_HRCO = -(int)SYSVarType.TrangThai_HRCO_ChoGui;
                        dbitem.IDHinhThucXetDuyet = null;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HRCO;

                        dbitem.IsDisabledHRCO = false;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được hủy duyệt trước đó";
                        return result;
                    }
                }
                #endregion
                #endregion

                #region HDDD
                #region Gửi Duyệt
                if (ActionCode == "SendHDDD")
                {
                    if (db.tbl_CUS_HRM_STAFF_NhanSu.Count(c => c.IsDeleted == false && c.IDRole > 0 && c.tbl_CUS_SYS_Role.Code == "ADMIN") == 0)
                    {
                        result.Error = "Chưa thiết lập nhân sự ban HRCO";
                        return result;
                    }

                    if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoGui)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 2;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HRCO;
                        dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_ChoDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDDD;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();

                        #region Gửi email cho NCV
                        var ncvChinh = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDNCV);
                        var chuNhiem = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDChuNhiem);
                        var ThoiGianXetDuyet = "1 tháng tính từ ngày hoàn chỉnh hồ sơ hoàn chỉnh";
                        if (dbitem.IDHinhThucXetDuyet == -(int)SYSVarType.HinhThucXetDuyet_DayDu)
                            ThoiGianXetDuyet = "sẽ thông báo thời gian trình cụ thể ngay khi có thông tin chính thức";

                        var emailTemplate = BS_SYS_Config.get_SYS_ConfigEmail_Template(db, SYSConfigCode.EmailGuiHDDD_NCV.ToString());
                        if (emailTemplate != null && !string.IsNullOrEmpty(emailTemplate.Subject) && !string.IsNullOrEmpty(emailTemplate.Body))
                        {
                            string template = emailTemplate.Body;
                            string subject = emailTemplate.Subject;
                            
                            var htmlSubject = Engine.Razor.RunCompile(subject, SYSConfigCode.EmailGuiHDDD_NCV.ToString(), null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                                ThoiGianXetDuyet = ThoiGianXetDuyet,
                            });

                            var htmlBody = Engine.Razor.RunCompile(template, SYSConfigCode.EmailGuiHDDD_NCV.ToString() + "_body", null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                                ThoiGianXetDuyet = ThoiGianXetDuyet,
                            });

                            result.ListEmail.Add(new DTO_Email { Body = htmlBody, Subject = htmlSubject, Destination = ncvChinh.Email });
                        }
                        #endregion

                        #region Gửi email cho HRCO
                        emailTemplate = BS_SYS_Config.get_SYS_ConfigEmail_Template(db, SYSConfigCode.EmailGuiHDDD_HRCO.ToString());
                        if (emailTemplate != null && !string.IsNullOrEmpty(emailTemplate.Subject) && !string.IsNullOrEmpty(emailTemplate.Body) && !string.IsNullOrEmpty(emailTemplate.EmailList))
                        {
                            string template = emailTemplate.Body;
                            string subject = emailTemplate.Subject;

                            var htmlSubject = Engine.Razor.RunCompile(subject, SYSConfigCode.EmailGuiHDDD_HRCO.ToString(), null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                                ThoiGianXetDuyet = ThoiGianXetDuyet,
                            });

                            var htmlBody = Engine.Razor.RunCompile(template, SYSConfigCode.EmailGuiHDDD_HRCO.ToString() + "_body", null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                                ThoiGianXetDuyet = ThoiGianXetDuyet,
                            });

                            var lstEmail = emailTemplate.EmailList.Split(';');
                            foreach (var item in lstEmail)
                            {
                                if (!string.IsNullOrEmpty(item))
                                    result.ListEmail.Add(new DTO_Email { Body = htmlBody, Subject = htmlSubject, Destination = item.Trim() });
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        result.Error = "Đã gửi trước đó, vui lòng chờ duyệt";
                        return result;
                    }
                }
                #endregion

                #region Hủy Gửi 
                if (ActionCode == "UnSendHDDD")
                {
                    if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 2;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDDD;
                        dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDDD;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy gửi";
                        return result;
                    }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_DaDuyet)
                    {
                        result.Error = "Đề tài đã được duyệt, không thể hủy gửi";
                        return result;
                    }
                }
                #endregion

                #region Duyệt
                if (ActionCode == "ApprovedHDDD")
                {
                    if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 2;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDDD;
                        dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_DaDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDDD;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        dbitem.IsDisabledHDDD = true;
                        db.SaveChanges();

                        #region Gửi email cho NCV
                        var emailTemplate = BS_SYS_Config.get_SYS_ConfigEmail_Template(db, SYSConfigCode.EmailHDDDDuyet_NCV.ToString());
                        if (emailTemplate != null && !string.IsNullOrEmpty(emailTemplate.Subject) && !string.IsNullOrEmpty(emailTemplate.Body))
                        {
                            string template = emailTemplate.Body;
                            string subject = emailTemplate.Subject;
                            var ncvChinh = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDNCV);
                            var chuNhiem = db.tbl_CUS_HRM_STAFF_NhanSu.Find(dbitem.IDChuNhiem);

                            var htmlSubject = Engine.Razor.RunCompile(subject, SYSConfigCode.EmailHDDDDuyet_NCV.ToString(), null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            var htmlBody = Engine.Razor.RunCompile(template, SYSConfigCode.EmailHDDDDuyet_NCV.ToString() + "_body", null, new
                            {
                                Email = ncvChinh.Email,
                                TenDeTai = dbitem.TenTiengViet,
                                NCVChinh = ncvChinh.Name,
                                ChuNhiemDeTai = chuNhiem.Name,
                            });

                            result.ListEmail.Add(new DTO_Email { Body = htmlBody, Subject = htmlSubject, Destination = ncvChinh.Email });
                        }
                        #endregion
                    }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được duyệt trước đó";
                        return result;
                    }
                }
                #endregion

                #region Hủy Duyệt
                if (ActionCode == "UnApprovedHDDD")
                {
                    if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_DaDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 2;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDDD;
                        dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDDD;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        dbitem.IsDisabledHDDD = false;
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được hủy duyệt trước đó";
                        return result;
                    }
                }
                #endregion
                #endregion

                #region HDKH
                #region Gửi Duyệt
                if (ActionCode == "SendHDKH")
                {
                    if (db.tbl_CUS_HRM_STAFF_NhanSu.Count(c => c.IsDeleted == false && c.IDRole > 0 && c.tbl_CUS_SYS_Role.Code == "ADMIN") == 0)
                    {
                        result.Error = "Chưa thiết lập nhân sự ban HRCO";
                        return result;
                    }

                    if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoGui)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 3;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDKH;
                        dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_ChoDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDKH;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else
                    {
                        result.Error = "Đã gửi trước đó, vui lòng chờ duyệt";
                        return result;
                    }
                }
                #endregion

                #region Hủy Gửi 
                if (ActionCode == "UnSendHDKH")
                {
                    if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 3;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDKH;
                        dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDKH;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy gửi";
                        return result;
                    }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_DaDuyet)
                    {
                        result.Error = "Đề tài đã được duyệt, không thể hủy gửi";
                        return result;
                    }
                }
                #endregion

                #region Duyệt
                if (ActionCode == "ApprovedHDKH")
                {
                    if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 3;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDKH;
                        dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_DaDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDKH;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được duyệt trước đó";
                        return result;
                    }
                }
                #endregion

                #region Hủy Duyệt
                if (ActionCode == "UnApprovedHDKH")
                {
                    if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_DaDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 3;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDKH;
                        dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDKH;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được hủy duyệt trước đó";
                        return result;
                    }
                }
                #endregion
                #endregion

                #region NghiemThu
                #region Gửi Duyệt
                if (ActionCode == "SendNghiemThu")
                {
                    if (db.tbl_CUS_HRM_STAFF_NhanSu.Count(c => c.IsDeleted == false && c.IDRole > 0 && c.tbl_CUS_SYS_Role.Code == "ADMIN") == 0)
                    {
                        result.Error = "Chưa thiết lập nhân sự ban HRCO";
                        return result;
                    }

                    if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoGui)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 4;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_NghiemThu;
                        dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_ChoDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_NghiemThu;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else
                    {
                        result.Error = "Đã gửi trước đó, vui lòng chờ duyệt";
                        return result;
                    }
                }
                #endregion

                #region Hủy Gửi 
                if (ActionCode == "UnSendNghiemThu")
                {
                    if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 4;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_NghiemThu;
                        dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_NghiemThu;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy gửi";
                        return result;
                    }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_DaDuyet)
                    {
                        result.Error = "Đề tài đã được duyệt, không thể hủy gửi";
                        return result;
                    }
                }
                #endregion

                #region Duyệt
                if (ActionCode == "ApprovedNghiemThu")
                {
                    if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 4;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_NghiemThu;
                        dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_DaDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_NghiemThu;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được duyệt trước đó";
                        return result;
                    }
                }
                #endregion

                #region Hủy Duyệt
                if (ActionCode == "UnApprovedNghiemThu")
                {
                    if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_DaDuyet)
                    {
                        tbl_PRO_TrangThai_Log dbLog = new tbl_PRO_TrangThai_Log();
                        dbLog.CreatedBy = Username;
                        dbLog.CreatedDate = DateTime.Now;
                        dbLog.IDDeTai = dbitem.ID;
                        dbLog.IDPhanLoaiTrangThai = 4;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_NghiemThu;
                        dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_NghiemThu;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoGui)
                    {
                        result.Error = "Đề tài chưa được gửi, không thể hủy duyệt";
                        return result;
                    }
                    else
                    {
                        result.Error = "Đề tài đã được hủy duyệt trước đó";
                        return result;
                    }
                }
                #endregion
                #endregion

                #region Khóa dữ liệu HRCO
                #region Khóa
                if (ActionCode == "DisableHRCO")
                {
                    if (dbitem.IsDisabledHRCO != true)
                    {
                        dbitem.IsDisabledHRCO = true;
                        db.SaveChanges();
                    }
                    else
                    {
                        result.Error = "Đã khóa trước đó";
                        return result;
                    }
                }
                #endregion

                #region Mở khóa
                if (ActionCode == "EnableHRCO")
                {
                    if (dbitem.IsDisabledHRCO == true)
                    {
                        dbitem.IsDisabledHRCO = false;
                        db.SaveChanges();
                    }
                    else
                    {
                        result.Error = "Đã mở khóa trước đó";
                        return result;
                    }
                }
                #endregion
                #endregion

                #region Khóa dữ liệu HDDD
                #region Khóa
                if (ActionCode == "DisableHDDD")
                {
                    if (dbitem.IsDisabledHDDD != true)
                    {
                        dbitem.IsDisabledHDDD = true;
                        db.SaveChanges();
                    }
                    else
                    {
                        result.Error = "Đã khóa trước đó";
                        return result;
                    }
                }
                #endregion

                #region Mở khóa
                if (ActionCode == "EnableHDDD")
                {
                    if (dbitem.IsDisabledHDDD == true)
                    {
                        dbitem.IsDisabledHDDD = false;
                        db.SaveChanges();
                    }
                    else
                    {
                        result.Error = "Đã mở khóa trước đó";
                        return result;
                    }
                }
                #endregion
                #endregion
            }

            return result;
        }

        public static string updateNCT_PRO_DeTai(AppEntities db, int ID, string NCT, string Username)
        {
            tbl_PRO_DeTai dbitem = db.tbl_PRO_DeTai.Find(ID);

            if (dbitem != null)
            {
                if (!string.IsNullOrEmpty(dbitem.SoNCT))
                    return "Số NCT chỉ được nhập 1 lần duy nhất!";
                dbitem.SoNCT = NCT;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
                db.SaveChanges();
            }

            return string.Empty;
        }

        public static string updateMaSo_PRO_DeTai(AppEntities db, DTO_PRO_DeTai item, string Username)
        {
            tbl_PRO_DeTai dbitem = db.tbl_PRO_DeTai.Find(item.ID);

            if (dbitem != null)
            {
                dbitem.MaSoHDDD = item.MaSoHDDD;
                dbitem.MaSoProtocalID = item.MaSoProtocalID;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
                db.SaveChanges();
            }

            return string.Empty;
        }

        public static IQueryable<DTO_PRO_DeTai> get_PRO_DeTaiByRefer(AppEntities db, int PartnerID, int StaffID, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_DeTai.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);
            query = query.Where(c => c.tbl_PRO_HRCO.Any(d => d.IDNhanSu == StaffID));

            //Query keyword



            //Query ID (int)
            if (QueryStrings.Any(d => d.Key == "ID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ID));
            }

            //Query IDPartner (int)
            if (QueryStrings.Any(d => d.Key == "IDPartner"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPartner").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPartner));
            }

            //Query IDNCV (int)
            if (QueryStrings.Any(d => d.Key == "IDNCV"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNCV").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNCV));
            }

            //Query IDChuNhiem (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDChuNhiem"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDChuNhiem").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDChuNhiem));
            }

            //Query IDHRCO (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDHRCO"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHRCO").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHRCO));
            }

            //Query IDPhanLoaiDeTai (int)
            if (QueryStrings.Any(d => d.Key == "IDPhanLoaiDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPhanLoaiDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPhanLoaiDeTai));
            }

            //Query IDTrangThai_HDDD (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_HDDD"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HDDD").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HDDD));
            }

            //Query IDTrangThai_HDKH (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_HDKH"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HDKH").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HDKH));
            }

            //Query IDTrangThai_HRCO (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_HRCO"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HRCO").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HRCO));
            }

            //Query IDTrangThai_NghiemThu (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_NghiemThu"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_NghiemThu").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_NghiemThu));
            }

            //Query DeTai (string)
            if (QueryStrings.Any(d => d.Key == "DeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DeTai").Value;
                query = query.Where(d => d.DeTai == keyword);
            }

            //Query GhiChu (string)
            if (QueryStrings.Any(d => d.Key == "GhiChu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value;
                query = query.Where(d => d.GhiChu == keyword);
            }

            //Query SoNCT (string)
            if (QueryStrings.Any(d => d.Key == "SoNCT") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoNCT").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoNCT").Value;
                query = query.Where(d => d.SoNCT == keyword);
            }

            //Query IsDisabled (bool)
            if (QueryStrings.Any(d => d.Key == "IsDisabled"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDisabled").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDisabled);
            }

            //Query IsDeleted (bool)
            if (QueryStrings.Any(d => d.Key == "IsDeleted"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDeleted").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDeleted);
            }

            //Query CreatedDate (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

            //Query CreatedBy (string)
            if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d => d.CreatedBy == keyword);
            }

            //Query ModifiedDate (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

            //Query ModifiedBy (string)
            if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d => d.ModifiedBy == keyword);
            }

            //Query MaSo (string)
            if (QueryStrings.Any(d => d.Key == "MaSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value;
                query = query.Where(d => d.MaSo == keyword);
            }

            //Query TenTiengViet (string)
            if (QueryStrings.Any(d => d.Key == "TenTiengViet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenTiengViet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenTiengViet").Value;
                query = query.Where(d => d.TenTiengViet == keyword);
            }

            //Query TenTiengAnh (string)
            if (QueryStrings.Any(d => d.Key == "TenTiengAnh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenTiengAnh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenTiengAnh").Value;
                query = query.Where(d => d.TenTiengAnh == keyword);
            }


            return toDTO(query);

        }

        public static IQueryable<DTO_PRO_DeTai> get_PRO_DeTaiCustom(AppEntities db, int PartnerID, int StaffID, Dictionary<string, string> QueryStrings)
        {
            var query = db.tbl_PRO_DeTai.Where(d => d.IsDeleted == false && d.IDPartner == PartnerID);

            var staff = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(c => c.ID == StaffID);
            if (staff != null)
            {
                if (staff.tbl_CUS_SYS_Role == null || staff.tbl_CUS_SYS_Role.Code != "ADMIN")
                    query = query.Where(c => c.IDNCV == staff.ID || c.IDChuNhiem == staff.ID || (c.tbl_PRO_NCVKhac.Count > 0 && c.tbl_PRO_NCVKhac.Any(d => d.IDNCV == staff.ID)));
            }
            else query = query.Where(c => false);

            //Query keyword



            //Query ID (int)
            if (QueryStrings.Any(d => d.Key == "ID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ID));
            }

            //Query IDPartner (int)
            if (QueryStrings.Any(d => d.Key == "IDPartner"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPartner").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPartner));
            }

            //Query IDNCV (int)
            if (QueryStrings.Any(d => d.Key == "IDNCV"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDNCV").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDNCV));
            }

            //Query IDChuNhiem (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDChuNhiem"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDChuNhiem").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDChuNhiem));
            }

            //Query IDHRCO (Nullable<int>)
            if (QueryStrings.Any(d => d.Key == "IDHRCO"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDHRCO").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int?> IDs = new List<int?>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                    else if (item == "null")
                        IDs.Add(null);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDHRCO));
            }

            //Query IDPhanLoaiDeTai (int)
            if (QueryStrings.Any(d => d.Key == "IDPhanLoaiDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDPhanLoaiDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDPhanLoaiDeTai));
            }

            //Query IDTrangThai_HDDD (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_HDDD"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HDDD").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HDDD));
            }

            //Query IDTrangThai_HDKH (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_HDKH"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HDKH").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HDKH));
            }

            //Query IDTrangThai_HRCO (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_HRCO"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_HRCO").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_HRCO));
            }

            //Query IDTrangThai_NghiemThu (int)
            if (QueryStrings.Any(d => d.Key == "IDTrangThai_NghiemThu"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDTrangThai_NghiemThu").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDTrangThai_NghiemThu));
            }

            //Query DeTai (string)
            if (QueryStrings.Any(d => d.Key == "DeTai") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DeTai").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DeTai").Value;
                query = query.Where(d => d.DeTai == keyword);
            }

            //Query GhiChu (string)
            if (QueryStrings.Any(d => d.Key == "GhiChu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "GhiChu").Value;
                query = query.Where(d => d.GhiChu == keyword);
            }

            //Query SoNCT (string)
            if (QueryStrings.Any(d => d.Key == "SoNCT") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SoNCT").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SoNCT").Value;
                query = query.Where(d => d.SoNCT == keyword);
            }

            //Query IsDisabled (bool)
            if (QueryStrings.Any(d => d.Key == "IsDisabled"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDisabled").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDisabled);
            }

            //Query IsDeleted (bool)
            if (QueryStrings.Any(d => d.Key == "IsDeleted"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDeleted").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDeleted);
            }

            //Query CreatedDate (System.DateTime)
            if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

            //Query CreatedBy (string)
            if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d => d.CreatedBy == keyword);
            }

            //Query ModifiedDate (Nullable<System.DateTime>)
            if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

            //Query ModifiedBy (string)
            if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d => d.ModifiedBy == keyword);
            }

            //Query MaSo (string)
            if (QueryStrings.Any(d => d.Key == "MaSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value;
                query = query.Where(d => d.MaSo == keyword);
            }

            //Query TenTiengViet (string)
            if (QueryStrings.Any(d => d.Key == "TenTiengViet") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenTiengViet").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenTiengViet").Value;
                query = query.Where(d => d.TenTiengViet == keyword);
            }

            //Query TenTiengAnh (string)
            if (QueryStrings.Any(d => d.Key == "TenTiengAnh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenTiengAnh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenTiengAnh").Value;
                query = query.Where(d => d.TenTiengAnh == keyword);
            }


            return toDTOCustom(query);

        }

        public static IQueryable<DTO_PRO_DeTai> toDTOCustom(IQueryable<tbl_PRO_DeTai> query)
        {
            return query
            .Select(s => new DTO_PRO_DeTai()
            {
                ID = s.ID,
                IDPartner = s.IDPartner,
                IDNCV = s.IDNCV,
                IDChuNhiem = s.IDChuNhiem,
                IDHRCO = s.IDHRCO,
                IDPhanLoaiDeTai = s.IDPhanLoaiDeTai,
                IDTrangThai_HDDD = s.IDTrangThai_HDDD,
                IDTrangThai_HDKH = s.IDTrangThai_HDKH,
                IDTrangThai_HRCO = s.IDTrangThai_HRCO,
                IDTrangThai_NghiemThu = s.IDTrangThai_NghiemThu,
                TrangThai_HDDD = s.tbl_SYS_Var1.ValueOfVar,
                TrangThai_HDKH = s.tbl_SYS_Var2.ValueOfVar,
                TrangThai_HRCO = s.tbl_SYS_Var3.ValueOfVar,
                TrangThai_NghiemThu = s.tbl_SYS_Var4.ValueOfVar,
                DeTai = s.DeTai,
                GhiChu = s.GhiChu,
                SoNCT = s.SoNCT,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                MaSo = s.MaSo,
                TenTiengViet = s.TenTiengViet,
                TenTiengAnh = s.TenTiengAnh,
                NCVChinh = s.tbl_CUS_HRM_STAFF_NhanSu.Name,
                ChuNhiemDeTai = s.IDChuNhiem > 0 ? s.tbl_CUS_HRM_STAFF_NhanSu1.Name : "",
                MaSoHDDD = s.MaSoHDDD,
                MaSoProtocalID = s.MaSoProtocalID,
                IDHinhThucXetDuyet = s.IDHinhThucXetDuyet,
                IDTinhTrangNghienCuu = s.IDTinhTrangNghienCuu,
                IDLinhVuc = s.IDLinhVuc,
                LinhVuc = s.IDLinhVuc > 0 ? s.tbl_CAT_LinhVuc.Name : ""
            });

        }

        public static bool uploadFile(AppEntities db, int ID, string path, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_DeTai.Find(ID);
            if (dbitem != null)
            {
                dbitem.FileUpload = path;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DeTai", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("uploadFile", e);
                    result = false;
                }
            }
            return result;
        }

        public static bool uploadFileChapThuan(AppEntities db, int ID, string path, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_DeTai.Find(ID);
            if (dbitem != null)
            {
                dbitem.FileChapThuan = path;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_DeTai", DateTime.Now, Username);

                    result = true;
                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("uploadFileChapThuan", e);
                    result = false;
                }
            }
            return result;
        }

    }
}
