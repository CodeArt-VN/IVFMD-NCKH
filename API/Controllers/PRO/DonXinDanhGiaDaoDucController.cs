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
    [RoutePrefix("api/PRO/DonXinDanhGiaDaoDuc")]
    public class DonXinDanhGiaDaoDucController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_DonXinDanhGiaDaoDuc> Get()
        {
            return BS_PRO_DonXinDanhGiaDaoDuc.get_PRO_DonXinDanhGiaDaoDuc(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_DonXinDanhGiaDaoDuc")]
        [ResponseType(typeof(DTO_PRO_DonXinDanhGiaDaoDuc))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_DonXinDanhGiaDaoDuc tbl_PRO_DonXinDanhGiaDaoDuc = BS_PRO_DonXinDanhGiaDaoDuc.get_PRO_DonXinDanhGiaDaoDuc(db, id);
            if (tbl_PRO_DonXinDanhGiaDaoDuc == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_DonXinDanhGiaDaoDuc);
        }

        [Route("get_PRO_DonXinDanhGiaDaoDucByDeTai/{idDeTai:int}")]
        [ResponseType(typeof(DTO_PRO_DonXinDanhGiaDaoDuc))]
        public IHttpActionResult GetCustom(int idDeTai)
        {
            DTO_PRO_DonXinDanhGiaDaoDuc tbl_PRO_DonXinDanhGiaDaoDuc = BS_PRO_DonXinDanhGiaDaoDuc.get_PRO_DonXinDanhGiaDaoDucByDeTai(db, idDeTai);

            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/DonXinDanhGiaDaoDuc.html")))
            {
                html = r.ReadToEnd();
            }
            tbl_PRO_DonXinDanhGiaDaoDuc.HTML = html;

            return Ok(tbl_PRO_DonXinDanhGiaDaoDuc);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_DonXinDanhGiaDaoDuc tbl_PRO_DonXinDanhGiaDaoDuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_DonXinDanhGiaDaoDuc.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_DonXinDanhGiaDaoDuc.put_PRO_DonXinDanhGiaDaoDuc(db, id, tbl_PRO_DonXinDanhGiaDaoDuc, Username);
            
            if (result)
            {
                BS_HelperReference.PRO_DonXinDanhGiaDaoDuc_Update(db, tbl_PRO_DonXinDanhGiaDaoDuc.IDDeTai);
                return StatusCode(HttpStatusCode.NoContent);
            }
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_DonXinDanhGiaDaoDuc))]
        public IHttpActionResult Post(DTO_PRO_DonXinDanhGiaDaoDuc tbl_PRO_DonXinDanhGiaDaoDuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_DonXinDanhGiaDaoDuc result = BS_PRO_DonXinDanhGiaDaoDuc.post_PRO_DonXinDanhGiaDaoDuc(db, tbl_PRO_DonXinDanhGiaDaoDuc, Username);
			

			if (result != null)
            {
                BS_HelperReference.PRO_DonXinDanhGiaDaoDuc_Update(db, tbl_PRO_DonXinDanhGiaDaoDuc.IDDeTai);
                return CreatedAtRoute("get_PRO_DonXinDanhGiaDaoDuc", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_DonXinDanhGiaDaoDuc))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_DonXinDanhGiaDaoDuc.check_PRO_DonXinDanhGiaDaoDuc_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_DonXinDanhGiaDaoDuc.delete_PRO_DonXinDanhGiaDaoDuc(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}