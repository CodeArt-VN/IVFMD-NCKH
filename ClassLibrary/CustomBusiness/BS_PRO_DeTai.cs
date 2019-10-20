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
            if(dbitem == null)
            {
                dbitem = new tbl_PRO_DeTai();
                dbitem.IDNCV = StaffID;
                dbitem.IDTrangThai_HDDD = -(int)SYSVarType.TrangThai_HDDD_ChoDuyet;
                dbitem.IDTrangThai_HDKH = -(int)SYSVarType.TrangThai_HDKH_ChoDuyet;
                dbitem.IDTrangThai_HRCO = -(int)SYSVarType.TrangThai_HRCO_ChoDuyet;
                dbitem.IDTrangThai_NghiemThu = -(int)SYSVarType.TrangThai_NghiemThu_ChoDuyet;
                
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
    }
}
