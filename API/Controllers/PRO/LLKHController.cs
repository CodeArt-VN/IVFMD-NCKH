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
    [RoutePrefix("api/PRO/LLKH")]
    public class LLKHController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_LLKH> Get()
        {
            return BS_PRO_LLKH.get_PRO_LLKH(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_LLKH")]
        [ResponseType(typeof(DTO_PRO_LLKH))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_LLKH tbl_PRO_LLKH = BS_PRO_LLKH.get_PRO_LLKH(db, id);
            if (tbl_PRO_LLKH == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_LLKH);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_LLKH tbl_PRO_LLKH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_LLKH.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_LLKH.put_PRO_LLKH(db, id, tbl_PRO_LLKH, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_LLKH))]
        public IHttpActionResult Post(DTO_PRO_LLKH tbl_PRO_LLKH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_LLKH result = BS_PRO_LLKH.post_PRO_LLKH(db, tbl_PRO_LLKH, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_LLKH", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_LLKH))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_LLKH.check_PRO_LLKH_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_LLKH.delete_PRO_LLKH(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}