using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ClassLibrary;
using DTOModel;
using BaseBusiness;

namespace API.Controllers.PRO
{
    [AuthorizeAttribute]
    [RoutePrefix("api/PRO/ThuyetMinhDeTai")]
    public class ThuyetMinhDeTaiController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_ThuyetMinhDeTai> Get()
        {
            return BS_PRO_ThuyetMinhDeTai.get_PRO_ThuyetMinhDeTai(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_ThuyetMinhDeTai")]
        [ResponseType(typeof(DTO_PRO_ThuyetMinhDeTai))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_ThuyetMinhDeTai tbl_PRO_ThuyetMinhDeTai = BS_PRO_ThuyetMinhDeTai.get_PRO_ThuyetMinhDeTai(db, id);
            if (tbl_PRO_ThuyetMinhDeTai == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_ThuyetMinhDeTai);
        }

        [Route("get_PRO_ThuyetMinhDeTaiByDeTai/{idDeTai:int}")]
        [ResponseType(typeof(DTO_PRO_ThuyetMinhDeTai))]
        public IHttpActionResult GetCustom(int idDeTai)
        {
            //DTO_PRO_ThuyetMinhDeTai tbl_PRO_ThuyetMinhDeTai = BS_PRO_ThuyetMinhDeTai.get_PRO_ThuyetMinhDeTaiByDeTai(db, idDeTai);
            DTO_PRO_ThuyetMinhDeTai tbl_PRO_ThuyetMinhDeTai = null;
            if (tbl_PRO_ThuyetMinhDeTai == null)
            {
                string html = "";
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/ThuyetMinhDeTai.html")))
                {
                    html = r.ReadToEnd();
                }

                tbl_PRO_ThuyetMinhDeTai = new DTO_PRO_ThuyetMinhDeTai
                {
                    IDDeTai = idDeTai,
                    HTML = html,
                    ListNhanLucNghienCuu = new List<DTO_PRO_ThuyetMinhDeTai_NhanLucNghienCuu>(),
                    ListGioiThieuChuyenGia = new List<DTO_PRO_ThuyetMinhDeTai_GioiThieuChuyenGia>(),
                    ListBienSo = new List<DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap>()
                    {
                        new DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap()
                        {
                            LoaiBienSo =  (int)DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap.BienSo.BSNen
                        },
                        new DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap()
                        {
                            LoaiBienSo =  (int)DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap.BienSo.BSDocLap
                        },
                        new DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap()
                        {
                            LoaiBienSo =  (int)DTO_PRO_ThuyetMinhDeTai_CacBienSoCanThuThap.BienSo.BSPhuThuoc
                        },
                    },
                    ListKeHoachThucHien = new List<DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien>()
                    {
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietDeCuong),
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.ThongQuaHDKH),
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.ThuThapSoLieu),
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.PhanTichSoLieuGiuaKy),
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.PhanTichSoLieuCuoiCung),
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoTrongNuoc),
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.NghiemThuDeTai),
                        new DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien(DTO_PRO_ThuyetMinhDeTai_KeHoachThucHien.VietBaiDangBaoQuocTe)
                    },
                    ListKinhPhiTongHop = new List<DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi>()
                    {
                        new DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi(DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi.NoiDungKinhPhi.Khoan1TraCongLaoDong),
                        new DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi(DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi.NoiDungKinhPhi.Khoan2NguyenLieu),
                        new DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi(DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi.NoiDungKinhPhi.Khoan3ThietBi),
                        new DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi(DTO_PRO_ThuyetMinhDeTai_TongHopKinhPhi.NoiDungKinhPhi.Khoan4Khac),
                    },
                    ListKinhPhiCongLaoDong = new List<DTO_PRO_ThuyetMinhDeTai_KinhPhi>()
                    {
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan1VietDeCuong),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan2ThuThapDL),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan3XLVaPTSoLieu),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan4DieuPhoiNghienCuu),
                    },
                    ListKinhPhiNguyenVatLieu = new List<DTO_PRO_ThuyetMinhDeTai_KinhPhi>()
                    {
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan1NguyenVatLieu),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan2DungCuPhuTungReTien),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan3NangLuong),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan4SachTaiLieu),
                    },
                    ListKinhPhiThietBi = new List<DTO_PRO_ThuyetMinhDeTai_KinhPhi>()
                    {
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan1MuaThietBi),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan2ThueThietBi),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan3VanChuyenLapDat),
                    },
                    ListKinhPhiKhac = new List<DTO_PRO_ThuyetMinhDeTai_KinhPhi>()
                    {
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan1HopTacTrongNuoc),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan2HDDD),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan3HDKH),
                        new DTO_PRO_ThuyetMinhDeTai_KinhPhi(DTO_PRO_ThuyetMinhDeTai_KinhPhi.NoiDungKinhPhi.Khoan4DuPhong),
                    }
                };
            }

            return Ok(tbl_PRO_ThuyetMinhDeTai);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_ThuyetMinhDeTai tbl_PRO_ThuyetMinhDeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_ThuyetMinhDeTai.ID)
            {
                return BadRequest();
            }

            tbl_PRO_ThuyetMinhDeTai.A9_JSON_NhanLucNghienCuu = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListNhanLucNghienCuu);
            tbl_PRO_ThuyetMinhDeTai.B2_JSON_GioiThieuChuyenGia = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListGioiThieuChuyenGia);
            tbl_PRO_ThuyetMinhDeTai.B326_JSON_CacBienSoCanThuThap = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListBienSo);
            tbl_PRO_ThuyetMinhDeTai.B313_JSON_KeHoachThucHien = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListKeHoachThucHien);
            tbl_PRO_ThuyetMinhDeTai.B52_JSON_TongHopKinhPhi = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListKinhPhiTongHop);
            tbl_PRO_ThuyetMinhDeTai.PhuLuc_JSON_NguyenVatLieu = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListKinhPhiNguyenVatLieu);

            bool result = BS_PRO_ThuyetMinhDeTai.put_PRO_ThuyetMinhDeTai(db, id, tbl_PRO_ThuyetMinhDeTai, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_ThuyetMinhDeTai))]
        public IHttpActionResult Post(DTO_PRO_ThuyetMinhDeTai tbl_PRO_ThuyetMinhDeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            tbl_PRO_ThuyetMinhDeTai.A9_JSON_NhanLucNghienCuu = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListNhanLucNghienCuu);
            tbl_PRO_ThuyetMinhDeTai.B2_JSON_GioiThieuChuyenGia = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListGioiThieuChuyenGia);
            tbl_PRO_ThuyetMinhDeTai.B326_JSON_CacBienSoCanThuThap = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListBienSo);
            tbl_PRO_ThuyetMinhDeTai.B313_JSON_KeHoachThucHien = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_ThuyetMinhDeTai.ListKeHoachThucHien);

            DTO_PRO_ThuyetMinhDeTai result = BS_PRO_ThuyetMinhDeTai.post_PRO_ThuyetMinhDeTai(db, tbl_PRO_ThuyetMinhDeTai, Username);

            if (result != null)
            {
                return CreatedAtRoute("get_PRO_ThuyetMinhDeTai", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_ThuyetMinhDeTai))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_ThuyetMinhDeTai.check_PRO_ThuyetMinhDeTai_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_ThuyetMinhDeTai.delete_PRO_ThuyetMinhDeTai(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }
    }
}