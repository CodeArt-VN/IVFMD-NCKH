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
    public static partial class BS_PRO_DeTai
    {
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

                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                db.tbl_PRO_DeTai.Add(dbitem);
            }
            if (item != null)
            {
                dbitem.IDChuNhiem = item.IDChuNhiem;
                dbitem.IDHRCO = item.IDHRCO;
                dbitem.IDPhanLoaiDeTai = item.IDPhanLoaiDeTai;
                dbitem.DeTai = item.DeTai;
                dbitem.GhiChu = item.GhiChu;
                dbitem.SoNCT = item.SoNCT;
                dbitem.IsDisabled = item.IsDisabled;
                dbitem.IsDeleted = item.IsDeleted;
                dbitem.MaSo = item.MaSo;
                dbitem.TenTiengViet = item.TenTiengViet;
                dbitem.TenTiengAnh = item.TenTiengAnh;

                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;

                dbitem.IDPartner = PartnerID;

                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, dbitem.IDPartner, "DTO_PRO_DeTai", DateTime.Now, Username);



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
            return item;
        }

        public static DTO_PRO_DeTai get_PRO_DeTaiCustom(AppEntities db, int ID)
        {
            var query = db.tbl_PRO_DeTai.Where(d => d.ID == ID && d.IsDeleted == false).Select(s => new DTO_PRO_DeTai
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
            }).FirstOrDefault();

            if (query != null)
            {
                query.ListFormStatus = new List<DTO_PRO_DeTai_TrangThai>();

                if (db.tbl_PRO_Sysnopsis.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = 0, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_Sysnopsis", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = 0, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_Sysnopsis", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_MauPhanTichDuLieu.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 1, Type = 0, Name = "Đăng kí phân tích", Description = "Đăng kí phân tích", FormCode = "tbl_PRO_MauPhanTichDuLieu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 1, Type = 0, Name = "Đăng kí phân tích", Description = "Đăng kí phân tích", FormCode = "tbl_PRO_MauPhanTichDuLieu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
                
                if (db.tbl_PRO_DonXinDanhGiaDaoDuc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 2, Type = 1, Name = "Xét duyệt HDDD", Description = "Đơn xin đánh giá đạo đức hướng nghiên cứu", FormCode = "tbl_PRO_DonXinDanhGiaDaoDuc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 2, Type = 1, Name = "Xét duyệt HDDD", Description = "Đơn xin đánh giá đạo đức hướng nghiên cứu", FormCode = "tbl_PRO_DonXinDanhGiaDaoDuc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
                
                if (db.tbl_PRO_DonXinXetDuyet.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 3, Type = 1, Name = "Xét duyệt HDKH", Description = "Đơn xin xét duyệt đề tài nghiên cứu khoa học", FormCode = "tbl_PRO_DonXinXetDuyet", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 3, Type = 1, Name = "Xét duyệt HDKH", Description = "Đơn xin xét duyệt đề tài nghiên cứu khoa học", FormCode = "tbl_PRO_DonXinXetDuyet", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_LLKH.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDChuNhiem && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 4, Type = 1, Name = "Lý lịch khoa học CNĐT", Description = "Lý lịch khoa học", FormCode = "tbl_PRO_LLKH", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 4, Type = 1, Name = "Lý lịch khoa học CNĐT", Description = "Lý lịch khoa học", FormCode = "tbl_PRO_LLKH", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_SYLL.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDChuNhiem && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 5, Type = 1, Name = "Sơ yếu lý lịch CNĐT", Description = "Sơ yếu lý lịch NCV chính", FormCode = "tbl_PRO_SYLL", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 5, Type = 1, Name = "Sơ yếu lý lịch CNĐT", Description = "Sơ yếu lý lịch NCV chính", FormCode = "tbl_PRO_SYLL", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_LLKH.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDNCV && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 6, Type = 1, Name = "Lý lịch khoa học NCV Chính", Description = "Lý lịch khoa học", FormCode = "tbl_PRO_LLKH", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 6, Type = 1, Name = "Lý lịch khoa học NCV Chính", Description = "Lý lịch khoa học", FormCode = "tbl_PRO_LLKH", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_SYLL.Any(c => c.IDDetai == ID && c.IDNhanSu == query.IDNCV && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 7, Type = 1, Name = "Sơ yếu lý lịch NCV chính", Description = "Sơ yếu lý lịch NCV chính", FormCode = "tbl_PRO_SYLL", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 7, Type = 1, Name = "Sơ yếu lý lịch NCV chính", Description = "Sơ yếu lý lịch NCV chính", FormCode = "tbl_PRO_SYLL", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
                
                if (db.tbl_PRO_ThuyetMinhDeTai.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 8, Type = 1, Name = "Thuyết minh đề tài", Description = "Thuyết minh đề tài", FormCode = "tbl_PRO_ThuyetMinhDeTai", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 8, Type = 1, Name = "Thuyết minh đề tài", Description = "Thuyết minh đề tài", FormCode = "tbl_PRO_ThuyetMinhDeTai", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
                
                if (db.tbl_PRO_DonXinNghiemThu.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 9, Type = 4, Name = "Nghiệm thu", Description = "Đơn xin nghiệm thu", FormCode = "tbl_PRO_DonXinNghiemThu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 9, Type = 4, Name = "Nghiệm thu", Description = "Đơn xin nghiệm thu", FormCode = "tbl_PRO_DonXinNghiemThu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_PhieuXemXetDaoDuc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_PhieuXemXetDaoDuc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_PhieuXemXetDaoDuc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_SAE.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_SAE", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_SAE", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_BaoCaoNangSuatKhoaHoc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_BaoCaoNangSuatKhoaHoc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_BangKiemLuaChonQuyTrinhXXDD", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_BangKiemLuaChonQuyTrinhXXDD", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_AE.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_AE", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { Index = 0, Type = -1, Name = "Sysnopsis", Description = "Sysnopsis", FormCode = "tbl_PRO_AE", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
            }
            return query;
        }

        public static string updateStatus_PRO_DeTai(AppEntities db, int ID, string ActionCode, string Username)
        {
            tbl_PRO_DeTai dbitem = db.tbl_PRO_DeTai.Find(ID);

            if (dbitem != null)
            {
                #region HRCO
                #region Gửi Duyệt
                if (ActionCode == "SendHRCO")
                {
                    if (db.tbl_CAT_HRCOConfig.Count(c => c.IsDeleted == false) == 0)
                        return "Chưa thiết lập nhân sự ban HRCO";

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
                    }
                    else return "Đã gửi trước đó, vui lòng chờ duyệt";
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
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoGui) { return "Đề tài chưa được gửi, không thể hủy gửi"; }
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_DaDuyet) { return "Đề tài đã được duyệt, không thể hủy gửi"; }
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
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoGui) { return "Đề tài chưa được gửi, không thể duyệt"; }
                    else return "Đề tài đã được duyệt trước đó";
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
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HRCO;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HRCO == -(int)SYSVarType.TrangThai_HRCO_ChoGui) { return "Đề tài chưa được gửi, không thể hủy duyệt"; }
                    else return "Đề tài đã được hủy duyệt trước đó";
                }
                #endregion
                #endregion

                #region HDDD
                #region Gửi Duyệt
                if (ActionCode == "SendHDDD")
                {
                    if (db.tbl_CAT_HRCOConfig.Count(c => c.IsDeleted == false) == 0)
                        return "Chưa thiết lập nhân sự ban HRCO";

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
                    }
                    else return "Đã gửi trước đó, vui lòng chờ duyệt";
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDDD;
                        dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDDD;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoGui) { return "Đề tài chưa được gửi, không thể hủy gửi"; }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_DaDuyet) { return "Đề tài đã được duyệt, không thể hủy gửi"; }
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDDD;
                        dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_DaDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDDD;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoGui) { return "Đề tài chưa được gửi, không thể duyệt"; }
                    else return "Đề tài đã được duyệt trước đó";
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDDD;
                        dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDDD;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDDD == -(int)SYSVarType.TrangThai_HDDD_ChoGui) { return "Đề tài chưa được gửi, không thể hủy duyệt"; }
                    else return "Đề tài đã được hủy duyệt trước đó";
                }
                #endregion
                #endregion

                #region HDKH
                #region Gửi Duyệt
                if (ActionCode == "SendHDKH")
                {
                    if (db.tbl_CAT_HRCOConfig.Count(c => c.IsDeleted == false) == 0)
                        return "Chưa thiết lập nhân sự ban HRCO";

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
                    }
                    else return "Đã gửi trước đó, vui lòng chờ duyệt";
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDKH;
                        dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDKH;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoGui) { return "Đề tài chưa được gửi, không thể hủy gửi"; }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_DaDuyet) { return "Đề tài đã được duyệt, không thể hủy gửi"; }
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDKH;
                        dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_DaDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDKH;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoGui) { return "Đề tài chưa được gửi, không thể duyệt"; }
                    else return "Đề tài đã được duyệt trước đó";
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_HDKH;
                        dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_HDKH;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_HDKH == -(int)SYSVarType.TrangThai_HDKH_ChoGui) { return "Đề tài chưa được gửi, không thể hủy duyệt"; }
                    else return "Đề tài đã được hủy duyệt trước đó";
                }
                #endregion
                #endregion

                #region NghiemThu
                #region Gửi Duyệt
                if (ActionCode == "SendNghiemThu")
                {
                    if (db.tbl_CAT_HRCOConfig.Count(c => c.IsDeleted == false) == 0)
                        return "Chưa thiết lập nhân sự ban HRCO";

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
                    }
                    else return "Đã gửi trước đó, vui lòng chờ duyệt";
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_NghiemThu;
                        dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_NghiemThu;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoGui) { return "Đề tài chưa được gửi, không thể hủy gửi"; }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_DaDuyet) { return "Đề tài đã được duyệt, không thể hủy gửi"; }
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_NghiemThu;
                        dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_DaDuyet;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_NghiemThu;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoGui) { return "Đề tài chưa được gửi, không thể duyệt"; }
                    else return "Đề tài đã được duyệt trước đó";
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
                        dbLog.IDPhanLoaiTrangThai = 1;
                        dbLog.IDTrangThaiCu = dbitem.IDTrangThai_NghiemThu;
                        dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_ChoGui;
                        dbLog.IDTrangThaiMoi = dbitem.IDTrangThai_NghiemThu;
                        db.tbl_PRO_TrangThai_Log.Add(dbLog);
                        db.SaveChanges();
                    }
                    else if (dbitem.IDTrangThai_NghiemThu == -(int)SYSVarType.TrangThai_NghiemThu_ChoGui) { return "Đề tài chưa được gửi, không thể hủy duyệt"; }
                    else return "Đề tài đã được hủy duyệt trước đó";
                }
                #endregion
                #endregion
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

    }
}
