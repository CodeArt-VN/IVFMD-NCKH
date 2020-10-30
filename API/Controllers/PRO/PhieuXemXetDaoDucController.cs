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
    [RoutePrefix("api/PRO/PhieuXemXetDaoDuc")]
    public class PhieuXemXetDaoDucController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_PhieuXemXetDaoDuc> Get()
        {
            return BS_PRO_PhieuXemXetDaoDuc.get_PRO_PhieuXemXetDaoDuc(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_PhieuXemXetDaoDuc")]
        [ResponseType(typeof(DTO_PRO_PhieuXemXetDaoDuc))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_PhieuXemXetDaoDuc tbl_PRO_PhieuXemXetDaoDuc = BS_PRO_PhieuXemXetDaoDuc.get_PRO_PhieuXemXetDaoDuc(db, id);
            if (tbl_PRO_PhieuXemXetDaoDuc == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_PhieuXemXetDaoDuc);
        }

        [Route("get_PRO_PhieuXemXetDaoDuc/{idDeTai:int}/{isInput?}")]
        [ResponseType(typeof(DTO_PRO_PhieuXemXetDaoDuc))]
        public IHttpActionResult GetCustom(int idDeTai, bool? isInput = false)
        {
            DTO_PRO_PhieuXemXetDaoDuc tbl_PRO_PhieuXemXetDaoDuc = BS_PRO_PhieuXemXetDaoDuc.get_PRO_PhieuXemXetDaoDucCustom(db, idDeTai);

            string html = "";
            string htmlPrint = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/PhieuXemXetDaoDuc.html")))
            {
                htmlPrint = r.ReadToEnd();
            }
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/PhieuXemXetDaoDuc_Input.html")))
            {
                html = r.ReadToEnd();
            }

            tbl_PRO_PhieuXemXetDaoDuc.HTML = html;
            tbl_PRO_PhieuXemXetDaoDuc.HTMLPrint = htmlPrint;

            return Ok(tbl_PRO_PhieuXemXetDaoDuc);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_PhieuXemXetDaoDuc tbl_PRO_PhieuXemXetDaoDuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_PhieuXemXetDaoDuc.ID)
            {
                return BadRequest();
            }
            tbl_PRO_PhieuXemXetDaoDuc.JSON_CacCoQuan = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_PhieuXemXetDaoDuc.ListCoQuan);
            tbl_PRO_PhieuXemXetDaoDuc.ListNCV.Insert(0, tbl_PRO_PhieuXemXetDaoDuc.NCVChinh);
            tbl_PRO_PhieuXemXetDaoDuc.JSON_CacNCV = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_PhieuXemXetDaoDuc.ListNCV);
            tbl_PRO_PhieuXemXetDaoDuc.JSON_ChuKy = Newtonsoft.Json.JsonConvert.SerializeObject(tbl_PRO_PhieuXemXetDaoDuc.CanKet_ListChuKy);
            bool result = BS_PRO_PhieuXemXetDaoDuc.put_PRO_PhieuXemXetDaoDuc(db, id, tbl_PRO_PhieuXemXetDaoDuc, Username);


            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_PhieuXemXetDaoDuc))]
        public IHttpActionResult Post(DTO_PRO_PhieuXemXetDaoDuc tbl_PRO_PhieuXemXetDaoDuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_PhieuXemXetDaoDuc result = BS_PRO_PhieuXemXetDaoDuc.post_PRO_PhieuXemXetDaoDuc(db, tbl_PRO_PhieuXemXetDaoDuc, Username);
            result.JSON_CacCoQuan = Newtonsoft.Json.JsonConvert.SerializeObject(result.ListCoQuan);
            result.ListNCV.Insert(0, result.NCVChinh);
            result.JSON_CacNCV = Newtonsoft.Json.JsonConvert.SerializeObject(result.ListNCV);
            result.JSON_ChuKy = Newtonsoft.Json.JsonConvert.SerializeObject(result.CanKet_ListChuKy);

            if (result != null)
            {
                return CreatedAtRoute("get_PRO_PhieuXemXetDaoDuc", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_PhieuXemXetDaoDuc))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_PhieuXemXetDaoDuc.check_PRO_PhieuXemXetDaoDuc_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_PhieuXemXetDaoDuc.delete_PRO_PhieuXemXetDaoDuc(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }
    }
}