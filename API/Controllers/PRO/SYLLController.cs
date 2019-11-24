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
    [RoutePrefix("api/PRO/SYLL")]
    public class SYLLController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_SYLL> Get()
        {
            return BS_PRO_SYLL.get_PRO_SYLL(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_SYLL")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_SYLL tbl_PRO_SYLL = BS_PRO_SYLL.get_PRO_SYLL(db, id);
            if (tbl_PRO_SYLL == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_SYLL);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_SYLL tbl_PRO_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_SYLL.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_SYLL.put_PRO_SYLL(db, id, tbl_PRO_SYLL, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Post(DTO_PRO_SYLL tbl_PRO_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_SYLL result = BS_PRO_SYLL.post_PRO_SYLL(db, tbl_PRO_SYLL, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_SYLL", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_SYLL.check_PRO_SYLL_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_SYLL.delete_PRO_SYLL(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}