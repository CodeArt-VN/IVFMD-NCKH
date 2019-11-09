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
    [RoutePrefix("api/PRO/MauPhanTichDuLieu")]
    public class MauPhanTichDuLieuController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_MauPhanTichDuLieu> Get()
        {
            return BS_PRO_MauPhanTichDuLieu.get_PRO_MauPhanTichDuLieu(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_MauPhanTichDuLieu")]
        [ResponseType(typeof(DTO_PRO_MauPhanTichDuLieu))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_MauPhanTichDuLieu tbl_PRO_MauPhanTichDuLieu = BS_PRO_MauPhanTichDuLieu.get_PRO_MauPhanTichDuLieu(db, id);
            if (tbl_PRO_MauPhanTichDuLieu == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_MauPhanTichDuLieu);
        }

        [Route("get_PRO_MauPhanTichDuLieuByDeTai/{idDeTai:int}")]
        [ResponseType(typeof(DTO_PRO_MauPhanTichDuLieu))]
        public IHttpActionResult GetCustom(int idDeTai)
        {
            DTO_PRO_MauPhanTichDuLieu tbl_PRO_MauPhanTichDuLieu = BS_PRO_MauPhanTichDuLieu.get_PRO_MauPhanTichDuLieuByDeTai(db, idDeTai);
            if (tbl_PRO_MauPhanTichDuLieu == null)
            {
                string html = "";
                using(System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/MauPhanTichDuLieu.html")))
                {
                    html = r.ReadToEnd();
                }

                tbl_PRO_MauPhanTichDuLieu = new DTO_PRO_MauPhanTichDuLieu
                {
                    IDDeTai = idDeTai,
                    HTML = html,
                    KetQuaThai = new DTO_PRO_MauPhanTichDuLieu_KetQuaThai(),
                    DacDiemNen = new DTO_PRO_MauPhanTichDuLieu_DacDiemNen(),
                    KichThichBuongTrung = new DTO_PRO_MauPhanTichDuLieu_KichThichBuongTrung(),
                    LaBo = new DTO_PRO_MauPhanTichDuLieu_LaBo(),
                    ChuKyChuyenPhoi = new DTO_PRO_MauPhanTichDuLieu_ChuKyChuyenPhoi(),
                    BienSoKhac = new DTO_PRO_MauPhanTichDuLieu_BienSoKhac()
                };
            }

            return Ok(tbl_PRO_MauPhanTichDuLieu);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_MauPhanTichDuLieu tbl_PRO_MauPhanTichDuLieu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_MauPhanTichDuLieu.ID)
            {
                return BadRequest();
            }

            tbl_PRO_MauPhanTichDuLieu.JSON_BienSoKhac = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.BienSoKhac);
            tbl_PRO_MauPhanTichDuLieu.JSON_ChuKyChuyenPhoi = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.ChuKyChuyenPhoi);
            tbl_PRO_MauPhanTichDuLieu.JSON_DacDiemNen = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.DacDiemNen);
            tbl_PRO_MauPhanTichDuLieu.JSON_KetQuaThai = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.KetQuaThai);
            tbl_PRO_MauPhanTichDuLieu.JSON_KichThichBuongTrung = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.KichThichBuongTrung);
            tbl_PRO_MauPhanTichDuLieu.JSON_LaBo = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.LaBo);

            bool result = BS_PRO_MauPhanTichDuLieu.put_PRO_MauPhanTichDuLieu(db, id, tbl_PRO_MauPhanTichDuLieu, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_MauPhanTichDuLieu))]
        public IHttpActionResult Post(DTO_PRO_MauPhanTichDuLieu tbl_PRO_MauPhanTichDuLieu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            tbl_PRO_MauPhanTichDuLieu.JSON_BienSoKhac = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.BienSoKhac);
            tbl_PRO_MauPhanTichDuLieu.JSON_ChuKyChuyenPhoi = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.ChuKyChuyenPhoi);
            tbl_PRO_MauPhanTichDuLieu.JSON_DacDiemNen = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.DacDiemNen);
            tbl_PRO_MauPhanTichDuLieu.JSON_KetQuaThai = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.KetQuaThai);
            tbl_PRO_MauPhanTichDuLieu.JSON_KichThichBuongTrung = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.KichThichBuongTrung);
            tbl_PRO_MauPhanTichDuLieu.JSON_LaBo = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_MauPhanTichDuLieu.LaBo);

            DTO_PRO_MauPhanTichDuLieu result = BS_PRO_MauPhanTichDuLieu.post_PRO_MauPhanTichDuLieu(db, tbl_PRO_MauPhanTichDuLieu, Username);

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_MauPhanTichDuLieu", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_MauPhanTichDuLieu))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_MauPhanTichDuLieu.check_PRO_MauPhanTichDuLieu_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_MauPhanTichDuLieu.delete_PRO_MauPhanTichDuLieu(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}