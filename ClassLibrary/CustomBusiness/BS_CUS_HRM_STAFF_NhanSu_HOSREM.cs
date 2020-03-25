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
    public static partial class BS_CUS_HRM_STAFF_NhanSu_HOSREM
    {
        public static DTO_CUS_HRM_STAFF_NhanSu_HOSREM get_CUS_HRM_STAFF_NhanSu_HOSREMByNhanSu(AppEntities db, int nhanSuId)
        {
            var query = db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Where(d => d.IDNhanSu == nhanSuId && d.IsDeleted == false).Select(s => new DTO_CUS_HRM_STAFF_NhanSu_HOSREM
            {
                ID = s.ID,
                IDNhanSu = s.IDNhanSu,
                HoTen = s.HoTen,
                Email = s.Email,
                JSON_BaiDangTapChi = s.JSON_BaiDangTapChi,
                JSON_DonViCongTac = s.JSON_DonViCongTac,
                JSON_HoatDongKhac = s.JSON_HoatDongKhac,
                JSON_KinhNghiemLamViec = s.JSON_KinhNghiemLamViec,
                JSON_QuaTrinhDaoTao = s.JSON_QuaTrinhDaoTao,
                HTML = s.HTML,
                IsDeleted = s.IsDeleted,
                IsDisabled = s.IsDisabled,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            }).FirstOrDefault();

            if (query == null)
            {
                //New
                query = new DTO_CUS_HRM_STAFF_NhanSu_HOSREM
                {
                    IDNhanSu = nhanSuId
                };

                query.ListBaiDangTapChi = new List<string>();
                query.ListDonViCongTac = new List<string>();
                query.ListKinhNghiemLamViec = new List<string>();
                query.ListHoatDongKhac = new List<string>();
                query.ListQuaTrinhDaoTao = new List<string>();

                var nhansu = db.tbl_CUS_HRM_STAFF_NhanSu.FirstOrDefault(c => c.ID == nhanSuId);
                if (nhansu != null)
                {
                    query.HoTen = nhansu.Name;
                    query.Email = nhansu.Email;

                    var syll = db.tbl_CUS_HRM_STAFF_NhanSu_SYLL.FirstOrDefault(c => c.IDNhanSu == nhanSuId && c.IsDeleted == false);
                    if (syll != null)
                    {
                        query.ListDonViCongTac.Add(syll.ChucVu);
                        if (!string.IsNullOrEmpty(syll.JSON_TrinhDoChuyenMon))
                        {
                            List<DTO_PRO_SYLL_TrinhDoChuyenMon> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_PRO_SYLL_TrinhDoChuyenMon>>(syll.JSON_TrinhDoChuyenMon);
                            foreach (var item in lst)
                                query.ListQuaTrinhDaoTao.Add(item.NamNhanBang + "," + item.HocVi + " - " + item.ChuyenNganhDaoTao);
                        }
                        if (!string.IsNullOrEmpty(syll.JSON_KinhNghiem))
                        {
                            List<DTO_PRO_SYLL_KinhNghiem> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DTO_PRO_SYLL_KinhNghiem>>(syll.JSON_KinhNghiem);
                            foreach (var item in lst)
                                query.ListKinhNghiemLamViec.Add(item.NamBatDauKetThuc + "," + item.CoQuanChuTri);
                        }
                    }
                }
            }
            else
            {
                //Edit
                if (!string.IsNullOrWhiteSpace(query.JSON_QuaTrinhDaoTao))
                {
                    query.ListQuaTrinhDaoTao = JsonConvert.DeserializeObject<List<string>>(query.JSON_QuaTrinhDaoTao);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_BaiDangTapChi))
                {
                    query.ListBaiDangTapChi = JsonConvert.DeserializeObject<List<string>>(query.JSON_BaiDangTapChi);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_DonViCongTac))
                {
                    query.ListDonViCongTac = JsonConvert.DeserializeObject<List<string>>(query.JSON_DonViCongTac);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_HoatDongKhac))
                {
                    query.ListHoatDongKhac = JsonConvert.DeserializeObject<List<string>>(query.JSON_HoatDongKhac);
                }
                if (!string.IsNullOrWhiteSpace(query.JSON_KinhNghiemLamViec))
                {
                    query.ListKinhNghiemLamViec = JsonConvert.DeserializeObject<List<string>>(query.JSON_KinhNghiemLamViec);
                }
            }

            query.ParseConfigs(query.FormConfig);
            return query;
        }

        public static DTO_CUS_HRM_STAFF_NhanSu_HOSREM save_CUS_HRM_STAFF_NhanSu_HOSREM(AppEntities db, DTO_CUS_HRM_STAFF_NhanSu_HOSREM item, string Username)
        {
            var dbitem = db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Find(item.ID);
            if (dbitem == null)
            {
                dbitem = new tbl_CUS_HRM_STAFF_NhanSu_HOSREM();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                db.tbl_CUS_HRM_STAFF_NhanSu_HOSREM.Add(dbitem);
            }

            dbitem.IDNhanSu = item.IDNhanSu;
            dbitem.HoTen = item.HoTen;
            dbitem.Email = item.Email;
            dbitem.JSON_DonViCongTac = item.JSON_DonViCongTac;
            dbitem.JSON_HoatDongKhac = item.JSON_HoatDongKhac;
            dbitem.JSON_KinhNghiemLamViec = item.JSON_KinhNghiemLamViec;
            dbitem.JSON_BaiDangTapChi = item.JSON_BaiDangTapChi;
            dbitem.JSON_QuaTrinhDaoTao = item.JSON_QuaTrinhDaoTao;

            if (item.ListDonViCongTac != null)
            {
                dbitem.JSON_DonViCongTac = JsonConvert.SerializeObject(item.ListDonViCongTac);
            }
            else
                dbitem.JSON_DonViCongTac = string.Empty;

            if (item.ListHoatDongKhac != null)
            {
                dbitem.JSON_HoatDongKhac = JsonConvert.SerializeObject(item.ListHoatDongKhac);
            }
            else
                dbitem.JSON_HoatDongKhac = string.Empty;

            if (item.ListKinhNghiemLamViec != null)
            {
                dbitem.JSON_KinhNghiemLamViec = JsonConvert.SerializeObject(item.ListKinhNghiemLamViec);
            }
            else
                dbitem.JSON_KinhNghiemLamViec = string.Empty;

            if (item.ListQuaTrinhDaoTao != null)
            {
                dbitem.JSON_QuaTrinhDaoTao = JsonConvert.SerializeObject(item.ListQuaTrinhDaoTao);
            }
            else
                dbitem.JSON_QuaTrinhDaoTao = string.Empty;

            if (item.ListBaiDangTapChi != null)
            {
                dbitem.JSON_BaiDangTapChi = JsonConvert.SerializeObject(item.ListBaiDangTapChi);
            }
            else
                dbitem.JSON_BaiDangTapChi = string.Empty;

            dbitem.FormConfig = item.StringifyConfigs();
            dbitem.HTML = item.HTML;
            dbitem.IsDisabled = item.IsDisabled;
            dbitem.IsDeleted = item.IsDeleted;

            dbitem.ModifiedBy = Username;
            dbitem.ModifiedDate = DateTime.Now;

            try
            {
                db.SaveChanges();

                BS_CUS_Version.update_CUS_Version(db, null, "DTO_CUS_HRM_STAFF_NhanSu_HOSREM", DateTime.Now, Username);
                item.ID = dbitem.ID;
                item.CreatedBy = dbitem.CreatedBy;
                item.CreatedDate = dbitem.CreatedDate;

                item.ModifiedBy = dbitem.ModifiedBy;
                item.ModifiedDate = dbitem.ModifiedDate;
                return item;
            }
            catch (DbEntityValidationException e)
            {
                errorLog.logMessage("save_CUS_HRM_STAFF_NhanSu_HOSREM", e);
                return null;
            }
        }
    }
}
