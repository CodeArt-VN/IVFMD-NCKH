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
    [RoutePrefix("api/PRO/SAE")]
    public class SAEController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_SAE> Get()
        {
            return BS_PRO_SAE.get_PRO_SAE(db, QueryStrings);
        }

        [Route("get_PRO_SAE_ByDeTai/{idDeTai:int}")]
        public IQueryable<DTO_PRO_SAE> GetByDeTai(int idDeTai)
        {
            return BS_PRO_SAE.get_PRO_SAEByDeTais(db, idDeTai);
        }

        [Route("{id:int}", Name = "get_PRO_SAE")]
        [ResponseType(typeof(DTO_PRO_SAE))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_SAE tbl_PRO_SAE = BS_PRO_SAE.get_PRO_SAE(db, id);
            if (tbl_PRO_SAE == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_SAE);
        }

        [Route("get_PRO_SAE/{idDeTai:int}/{idBenhNhan:int}/{id:int}/{isInput?}")]
        [ResponseType(typeof(DTO_PRO_SAE))]
        public IHttpActionResult GetCustom(int idDeTai, int idBenhNhan, int? id = -1, bool? isInput = false)
        {
            DTO_PRO_SAE tbl_PRO_SAE = BS_PRO_SAE.get_PRO_SAECustom(db, idDeTai, idBenhNhan, id);

            string html = "";
            string htmlPrint = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/SAE.html")))
            {
                htmlPrint = r.ReadToEnd();
            }

            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/SAE_Input.html")))
            {
                html = r.ReadToEnd();
            }

            tbl_PRO_SAE.HTML = html;
            tbl_PRO_SAE.HTMLPrint = htmlPrint;

            return Ok(tbl_PRO_SAE);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_SAE tbl_PRO_SAE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_SAE.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_SAE.put_PRO_SAE(db, id, tbl_PRO_SAE, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_SAE))]
        public IHttpActionResult Post(DTO_PRO_SAE tbl_PRO_SAE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_SAE result = BS_PRO_SAE.post_PRO_SAE(db, tbl_PRO_SAE, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_SAE", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_SAE))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_SAE.check_PRO_SAE_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_SAE.delete_PRO_SAE(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        [Route("save_PRO_SAE")]
        [ResponseType(typeof(DTO_PRO_SAE))]
        public IHttpActionResult Save(DTO_PRO_SAE tbl_PRO_SAE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_SAE result = BS_PRO_SAE.save_PRO_SAE(db, tbl_PRO_SAE, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}