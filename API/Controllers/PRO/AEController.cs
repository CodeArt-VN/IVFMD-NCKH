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
    [RoutePrefix("api/PRO/AE")]
    public class AEController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_AE> Get()
        {
            return BS_PRO_AE.get_PRO_AE(db, QueryStrings);
        }

        [Route("get_PRO_AE_ByDeTai/{idDeTai:int}")]
        public IQueryable<DTO_PRO_AE> GetByDeTai(int idDeTai)
        {
            return BS_PRO_AE.get_PRO_AEByDeTais(db, idDeTai);
        }

        [Route("{id:int}", Name = "get_PRO_AE")]
        [ResponseType(typeof(DTO_PRO_AE))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_AE tbl_PRO_AE = BS_PRO_AE.get_PRO_AE(db, id);
            if (tbl_PRO_AE == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_AE);
        }

        [Route("get_PRO_AE/{idDeTai:int}/{idBenhNhan:int}/{id:int}")]
        [ResponseType(typeof(DTO_PRO_AE))]
        public IHttpActionResult GetCustom(int idDeTai, int idBenhNhan, int? id = -1)
        {
            DTO_PRO_AE tbl_PRO_AE = BS_PRO_AE.get_PRO_AEByDeTai(db, idDeTai, idBenhNhan, id);
            //if (tbl_PRO_LLKH.ID == 0)
            //{
            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/AE.html")))
            {
                html = r.ReadToEnd();
            }
            tbl_PRO_AE.HTML = html;
            //}

            return Ok(tbl_PRO_AE);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_AE tbl_PRO_AE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_AE.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_AE.put_PRO_AE(db, id, tbl_PRO_AE, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_AE))]
        public IHttpActionResult Post(DTO_PRO_AE tbl_PRO_AE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_AE result = BS_PRO_AE.post_PRO_AE(db, tbl_PRO_AE, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_AE", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_AE))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_AE.check_PRO_AE_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_AE.delete_PRO_AE(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }
    }
}