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
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_Sysnopsis", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_Sysnopsis", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_MauPhanTichDuLieu.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_MauPhanTichDuLieu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_MauPhanTichDuLieu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_DonXinXetDuyet.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_DonXinXetDuyet", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_DonXinXetDuyet", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_DonXinNghiemThu.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_DonXinNghiemThu", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_DonXinNghiemThu", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_DonXinDanhGiaDaoDuc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_DonXinDanhGiaDaoDuc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_DonXinDanhGiaDaoDuc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_LLKH.Any(c => c.IDDetai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_LLKH", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_LLKH", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_PhieuXemXetDaoDuc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_PhieuXemXetDaoDuc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_PhieuXemXetDaoDuc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_SAE.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_SAE", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_SAE", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_SYLL.Any(c => c.IDDetai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_SYLL", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_SYLL", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_ThuyetMinhDeTai.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_ThuyetMinhDeTai", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_ThuyetMinhDeTai", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_BaoCaoNangSuatKhoaHoc.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_BaoCaoNangSuatKhoaHoc", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_BaoCaoNangSuatKhoaHoc", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_BangKiemLuaChonQuyTrinhXXDD", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_BangKiemLuaChonQuyTrinhXXDD", TrangThai = "Chưa tạo", TrangThaiCode = "New" });

                if (db.tbl_PRO_AE.Any(c => c.IDDeTai == ID && c.IsDeleted == false))
                    query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_AE", TrangThai = "Đã tạo", TrangThaiCode = "Update" });
                else query.ListFormStatus.Add(new DTO_PRO_DeTai_TrangThai { FormCode = "tbl_PRO_AE", TrangThai = "Chưa tạo", TrangThaiCode = "New" });
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
    }
}
