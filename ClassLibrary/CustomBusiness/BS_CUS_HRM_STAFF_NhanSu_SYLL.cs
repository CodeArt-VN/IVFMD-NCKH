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
    public static partial class BS_CUS_HRM_STAFF_NhanSu_SYLL
    {
        public static DTO_CUS_HRM_STAFF_NhanSu_SYLL get_CUS_HRM_STAFF_NhanSu_SYLLByNhanSu(AppEntities db, int nhanSuId)
        {
            var query = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Where(d => d.IDNhanSu == nhanSuId && d.IsDeleted == false).Select(s => new DTO_CUS_HRM_STAFF_NhanSu_SYLL
            {
                ID = s.ID,
                IDNhanSu = s.IDNhanSu,
                HoTen = s.HoTen,
                GioiTinh = s.GioiTinh,
                NgaySinh = s.NgaySinh,
                DiaChi = s.DiaChi,
                DienThoaiCQ = s.DienThoaiCQ,
                Mobile = s.Mobile,
                Email = s.Email,
                ChucVu = s.ChucVu,
                CoQuanLamViec = s.CoQuanLamViec,
                ThuTruongCoQuan = s.ThuTruongCoQuan,
                DienThoaiThuTruong = s.DienThoaiThuTruong,
                DiaChiCoQuan = s.DiaChiCoQuan,
                JSON_TrinhDoChuyenMon = s.JSON_TrinhDoChuyenMon,
                JSON_KinhNghiem = s.JSON_KinhNghiem,
                HTML = s.HTML,
                FormConfig = s.FormConfig,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
                NgayKy_ChuKy = s.NgayKy_ChuKy,
                NgayKy_Nam = s.NgayKy_Nam,
                NgayKy_Ngay = s.NgayKy_Ngay,
                NgayKy_Thang = s.NgayKy_Thang,
                JSON_HocVi = s.JSON_HocVi,
                DienThoaiNhaRieng = s.DienThoaiNhaRieng,
            }).FirstOrDefault();

            if (query == null)
            {
                //New
                query = new DTO_CUS_HRM_STAFF_NhanSu_SYLL
                {
                    IDNhanSu = nhanSuId
                };
                query.ListTrinhDoChuyenMon = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>();

                var objLL = db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.FirstOrDefault(c => c.IDNhanSu == nhanSuId);
                if (objLL != null)
                {
                    query.HoTen = objLL.HoTen;
                    query.NgaySinh = objLL.NgaySinh;
                    query.Email = objLL.Email_CaNhan;
                    query.DiaChi = objLL.DiaChi_CaNhan;
                    query.Mobile = objLL.DienThoai_CaNhan;
                    query.GioiTinh = objLL.GioiTinh;
                    query.ChucVu = objLL.ChucVu;
                    query.DiaChiCoQuan = objLL.DiaChi_CoQuan;
                    query.CoQuanLamViec = "Bệnh viện Mỹ Đức";
                    query.DienThoaiCQ = objLL.DienThoai_CoQuan;

                    if (string.IsNullOrEmpty(objLL.HocViThacSy))
                    {
                        query.ListTrinhDoChuyenMon.Add(new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon
                        {
                            HocVi = objLL.HocViThacSy,
                            NamNhanBang = objLL.NamHocViThacSy
                        });
                    }
                    if (string.IsNullOrEmpty(objLL.HocViTienSy))
                    {
                        query.ListTrinhDoChuyenMon.Add(new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon
                        {
                            HocVi = objLL.HocViTienSy,
                            NamNhanBang = objLL.NamHocViTienSy
                        });
                    }
                    if (string.IsNullOrEmpty(objLL.HocHam))
                    {
                        query.ListTrinhDoChuyenMon.Add(new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon
                        {
                            HocVi = objLL.HocHam,
                            NamNhanBang = objLL.NamPhongHocHam
                        });
                    }
                }

                //if (string.IsNullOrEmpty(query.HoTen))
                //    query.HoTen = "(LLKH chưa có thông tin)";
                //if (string.IsNullOrEmpty(query.NgaySinh))
                //    query.NgaySinh = "(LLKH chưa có thông tin)";
                //if (string.IsNullOrEmpty(query.Email))
                //    query.Email = "(LLKH chưa có thông tin)";
                //if (string.IsNullOrEmpty(query.DiaChi))
                //    query.DiaChi = "(LLKH chưa có thông tin)";
                //if (string.IsNullOrEmpty(query.Mobile))
                //    query.Mobile = "(LLKH chưa có thông tin)";
                //if (string.IsNullOrEmpty(query.ChucVu))
                //    query.ChucVu = "(LLKH chưa có thông tin)";
                //if (string.IsNullOrEmpty(query.DiaChiCoQuan))
                //    query.DiaChiCoQuan = "(LLKH chưa có thông tin)";

                query.ListKinhNghiem = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_KinhNghiem>()
                {
                    new DTO_CUS_HRM_STAFF_NhanSu_SYLL_KinhNghiem
                    {
                        
                    }
                };
                
                if (query.ListTrinhDoChuyenMon.Count == 0)
                {
                    query.ListTrinhDoChuyenMon.Add(new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon
                    {
                        //HocVi = "(LLKH chưa có thông tin)",
                        //NamNhanBang = "(LLKH chưa có thông tin)",
                        HocVi = "",
                        NamNhanBang = ""
                    });
                }
            }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.JSON_KinhNghiem))
                {
                    query.ListKinhNghiem = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_KinhNghiem>>(query.JSON_KinhNghiem);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_TrinhDoChuyenMon))
                {
                    query.ListTrinhDoChuyenMon = JsonConvert.DeserializeObject<List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>>(query.JSON_TrinhDoChuyenMon);
                }
            }

            return query;
        }

        public static DTO_CUS_HRM_STAFF_NhanSu_SYLL save_CUS_HRM_STAFF_NhanSu_SYLL(AppEntities db, DTO_CUS_HRM_STAFF_NhanSu_SYLL item, string Username)
        {
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Find(item.ID);
            if (dbitem == null)
            {
                dbitem = new tbl_CUS_HRM_STAFF_NhanSu_SYLL();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Add(dbitem);
            }

            dbitem.IDNhanSu = item.IDNhanSu;
            dbitem.HoTen = item.HoTen;
            dbitem.GioiTinh = item.GioiTinh;
            dbitem.NgaySinh = item.NgaySinh;
            dbitem.DiaChi = item.DiaChi;
            dbitem.DienThoaiCQ = item.DienThoaiCQ;
            dbitem.Mobile = item.Mobile;
            dbitem.Email = item.Email;
            dbitem.ChucVu = item.ChucVu;
            dbitem.CoQuanLamViec = item.CoQuanLamViec;
            dbitem.ThuTruongCoQuan = item.ThuTruongCoQuan;
            dbitem.DienThoaiThuTruong = item.DienThoaiThuTruong;
            dbitem.DiaChiCoQuan = item.DiaChiCoQuan;
            dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;
            dbitem.NgayKy_Ngay = item.NgayKy_Ngay;
            dbitem.NgayKy_Thang = item.NgayKy_Thang;
            dbitem.NgayKy_Nam = item.NgayKy_Nam;
            dbitem.DienThoaiNhaRieng = item.DienThoaiNhaRieng;
            if (item.ListKinhNghiem != null)
            {
                dbitem.JSON_KinhNghiem = JsonConvert.SerializeObject(item.ListKinhNghiem);
            }
            else
                dbitem.JSON_KinhNghiem = string.Empty;

            if (item.ListTrinhDoChuyenMon != null)
            {
                dbitem.JSON_TrinhDoChuyenMon = JsonConvert.SerializeObject(item.ListTrinhDoChuyenMon);
            }
            else
                dbitem.JSON_TrinhDoChuyenMon = string.Empty;

            dbitem.FormConfig = item.FormConfig;
            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            try
            {
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_SYLL", DateTime.Now, Username);
                item.ID = dbitem.ID;
                item.CreatedBy = dbitem.CreatedBy;
                item.CreatedDate = dbitem.CreatedDate;

                item.ModifiedBy = dbitem.ModifiedBy;
                item.ModifiedDate = dbitem.ModifiedDate;
                return item;
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("save_CUS_HRM_STAFF_NhanSu_SYLL", e);
                return null;
            }
        }
    }
}
