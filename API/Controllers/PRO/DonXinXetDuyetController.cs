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
    [RoutePrefix("api/PRO/DonXinXetDuyet")]
    public class DonXinXetDuyetController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_DonXinXetDuyet> Get()
        {
            return BS_PRO_DonXinXetDuyet.get_PRO_DonXinXetDuyet(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_DonXinXetDuyet")]
        [ResponseType(typeof(DTO_PRO_DonXinXetDuyet))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_DonXinXetDuyet tbl_PRO_DonXinXetDuyet = BS_PRO_DonXinXetDuyet.get_PRO_DonXinXetDuyet(db, id);
            if (tbl_PRO_DonXinXetDuyet == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_DonXinXetDuyet);
        }

        [Route("get_PRO_DonXinXetDuyetByDeTai/{idDeTai:int}")]
        [ResponseType(typeof(DTO_PRO_DonXinXetDuyet))]
        public IHttpActionResult GetCustom(int idDeTai)
        {
            DTO_PRO_DonXinXetDuyet tbl_PRO_DonXinXetDuyet = BS_PRO_DonXinXetDuyet.get_PRO_DonXinXetDuyetByDeTai(db, idDeTai);

            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/DonXinXetDuyet.html")))
            {
                html = r.ReadToEnd();
            }
            tbl_PRO_DonXinXetDuyet.HTML = html;

            return Ok(tbl_PRO_DonXinXetDuyet);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_DonXinXetDuyet tbl_PRO_DonXinXetDuyet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_DonXinXetDuyet.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_DonXinXetDuyet.put_PRO_DonXinXetDuyet(db, id, tbl_PRO_DonXinXetDuyet, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_DonXinXetDuyet))]
        public IHttpActionResult Post(DTO_PRO_DonXinXetDuyet tbl_PRO_DonXinXetDuyet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_DonXinXetDuyet result = BS_PRO_DonXinXetDuyet.post_PRO_DonXinXetDuyet(db, tbl_PRO_DonXinXetDuyet, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_DonXinXetDuyet", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_DonXinXetDuyet))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_DonXinXetDuyet.check_PRO_DonXinXetDuyet_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_DonXinXetDuyet.delete_PRO_DonXinXetDuyet(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}