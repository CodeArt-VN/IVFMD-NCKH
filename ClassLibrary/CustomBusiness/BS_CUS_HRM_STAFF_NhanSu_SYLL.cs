﻿using ClassLibrary;
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
                IsCNDT = s.tbl_CUS_HRM_STAFF_NhanSu.IsCNDT == true
            }).FirstOrDefault();

            if (query == null)
            {
                //New
                query = new DTO_CUS_HRM_STAFF_NhanSu_SYLL
                {
                    IDNhanSu = nhanSuId
                };

                var nhansu = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(c => c.ID == nhanSuId);
                query.IsCNDT = nhansu != null && nhansu.IsCNDT == true;

                query.ListTrinhDoChuyenMon = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>();
                var objHocVi1 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                var objHocVi2 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                var objHocVi3 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();

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

                    objHocVi1.HocVi = objLL.HocViThacSy;
                    objHocVi1.NamNhanBang = objLL.NamHocViThacSy;

                    objHocVi2.HocVi = objLL.HocViTienSy;
                    objHocVi2.NamNhanBang = objLL.NamHocViTienSy;

                    objHocVi3.HocVi = objLL.HocHam;
                    objHocVi3.NamNhanBang = objLL.NamPhongHocHam;
                }

                query.ListTrinhDoChuyenMon.Add(objHocVi1);
                query.ListTrinhDoChuyenMon.Add(objHocVi2);
                query.ListTrinhDoChuyenMon.Add(objHocVi3);

                query.ListKinhNghiem = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_KinhNghiem>()
                {
                    new DTO_CUS_HRM_STAFF_NhanSu_SYLL_KinhNghiem
                    {
                        
                    }
                };
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
                dbitem.HoTen = item.HoTen;
                dbitem.GioiTinh = item.GioiTinh;
                dbitem.NgaySinh = item.NgaySinh;
                dbitem.DiaChi = item.DiaChi;
                dbitem.DienThoaiCQ = item.DienThoaiCQ;
                dbitem.Mobile = item.Mobile;
                dbitem.Email = item.Email;
                dbitem.ChucVu = item.ChucVu;
                dbitem.CoQuanLamViec = item.CoQuanLamViec;
                dbitem.DiaChiCoQuan = item.DiaChiCoQuan;
                dbitem.DienThoaiNhaRieng = item.DienThoaiNhaRieng;

                if (item.ListTrinhDoChuyenMon != null)
                {
                    dbitem.JSON_TrinhDoChuyenMon = JsonConvert.SerializeObject(item.ListTrinhDoChuyenMon);
                }
                else
                    dbitem.JSON_TrinhDoChuyenMon = string.Empty;

                db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.Add(dbitem);
            }
            else
            {
                var objHocVi1 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                var objHocVi2 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                var objHocVi3 = new DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon();
                var objLL = db.tbl_CUS_HRM_STAFF_NhanSu_LLKH.FirstOrDefault(c => c.IDNhanSu == item.IDNhanSu);
                if (objLL != null)
                {
                    objHocVi1.HocVi = objLL.HocViThacSy;
                    objHocVi1.NamNhanBang = objLL.NamHocViThacSy;

                    objHocVi2.HocVi = objLL.HocViTienSy;
                    objHocVi2.NamNhanBang = objLL.NamHocViTienSy;

                    objHocVi3.HocVi = objLL.HocHam;
                    objHocVi3.NamNhanBang = objLL.NamPhongHocHam;
                }
                var ListTrinhDoChuyenMon = new List<DTO_CUS_HRM_STAFF_NhanSu_SYLL_TrinhDoChuyenMon>();
                ListTrinhDoChuyenMon.Add(objHocVi1);
                ListTrinhDoChuyenMon.Add(objHocVi2);
                ListTrinhDoChuyenMon.Add(objHocVi3);

                if (item.ListTrinhDoChuyenMon != null && item.ListTrinhDoChuyenMon.Count == 3)
                {
                    int count = 1;
                    foreach (var itemTrinhDoChuyenMon in item.ListTrinhDoChuyenMon)
                    {
                        if (count == 1)
                        {
                            objHocVi1.HocHam = itemTrinhDoChuyenMon.HocHam;
                            objHocVi1.ChuyenNganhDaoTao = itemTrinhDoChuyenMon.ChuyenNganhDaoTao;
                        }

                        if (count == 2)
                        {
                            objHocVi2.HocHam = itemTrinhDoChuyenMon.HocHam;
                            objHocVi2.ChuyenNganhDaoTao = itemTrinhDoChuyenMon.ChuyenNganhDaoTao;
                        }

                        if (count == 3)
                        {
                            objHocVi3.HocHam = itemTrinhDoChuyenMon.HocHam;
                            objHocVi3.ChuyenNganhDaoTao = itemTrinhDoChuyenMon.ChuyenNganhDaoTao;
                        }

                        count++;
                    }
                }

                dbitem.JSON_TrinhDoChuyenMon = Newtonsoft.Json.JsonConvert.SerializeObject(ListTrinhDoChuyenMon);
            }

            dbitem.IDNhanSu = item.IDNhanSu;
            dbitem.ThuTruongCoQuan = item.ThuTruongCoQuan;
            dbitem.DienThoaiThuTruong = item.DienThoaiThuTruong;
            dbitem.DienThoaiNhaRieng = item.DienThoaiNhaRieng;
            dbitem.NgayKy_ChuKy = item.NgayKy_ChuKy;
            dbitem.NgayKy_Ngay = item.NgayKy_Ngay;
            dbitem.NgayKy_Thang = item.NgayKy_Thang;
            dbitem.NgayKy_Nam = item.NgayKy_Nam;
            if (item.ListKinhNghiem != null)
            {
                dbitem.JSON_KinhNghiem = JsonConvert.SerializeObject(item.ListKinhNghiem);
            }
            else
                dbitem.JSON_KinhNghiem = string.Empty;


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
