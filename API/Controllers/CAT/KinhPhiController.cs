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

namespace API.Controllers.CAT
{
    [RoutePrefix("api/CAT/KinhPhi")]
    public class KinhPhiController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CAT_KinhPhi> Get()
        {
            return BS_CAT_KinhPhi.get_CAT_KinhPhi(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CAT_KinhPhi")]
        [ResponseType(typeof(DTO_CAT_KinhPhi))]
        public IHttpActionResult Get(int id)
        {
            DTO_CAT_KinhPhi tbl_CAT_KinhPhi = BS_CAT_KinhPhi.get_CAT_KinhPhi(db, id);
            if (tbl_CAT_KinhPhi == null)
            {
                return NotFound();
            }

            return Ok(tbl_CAT_KinhPhi);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CAT_KinhPhi tbl_CAT_KinhPhi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CAT_KinhPhi.ID)
            {
                return BadRequest();
            }

            bool result = BS_CAT_KinhPhi.put_CAT_KinhPhi(db, id, tbl_CAT_KinhPhi, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CAT_KinhPhi))]
        public IHttpActionResult Post(DTO_CAT_KinhPhi tbl_CAT_KinhPhi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CAT_KinhPhi result = BS_CAT_KinhPhi.post_CAT_KinhPhi(db, tbl_CAT_KinhPhi, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CAT_KinhPhi", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CAT_KinhPhi))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CAT_KinhPhi.check_CAT_KinhPhi_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CAT_KinhPhi.delete_CAT_KinhPhi(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}