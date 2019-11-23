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
                    query.HoTen = nhansu.Ho + " " + nhansu.Ten;
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

            return query;
        }
    }
}
