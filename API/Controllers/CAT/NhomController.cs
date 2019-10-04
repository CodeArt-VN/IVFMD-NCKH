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
    [RoutePrefix("api/CAT/Nhom")]
    public class NhomController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CAT_Nhom> Get()
        {
            return BS_CAT_Nhom.get_CAT_Nhom(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CAT_Nhom")]
        [ResponseType(typeof(DTO_CAT_Nhom))]
        public IHttpActionResult Get(int id)
        {
            DTO_CAT_Nhom tbl_CAT_Nhom = BS_CAT_Nhom.get_CAT_Nhom(db, id);
            if (tbl_CAT_Nhom == null)
            {
                return NotFound();
            }

            return Ok(tbl_CAT_Nhom);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CAT_Nhom tbl_CAT_Nhom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CAT_Nhom.ID)
            {
                return BadRequest();
            }

            bool result = BS_CAT_Nhom.put_CAT_Nhom(db, id, tbl_CAT_Nhom, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CAT_Nhom))]
        public IHttpActionResult Post(DTO_CAT_Nhom tbl_CAT_Nhom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CAT_Nhom result = BS_CAT_Nhom.post_CAT_Nhom(db, tbl_CAT_Nhom, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CAT_Nhom", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CAT_Nhom))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CAT_Nhom.check_CAT_Nhom_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CAT_Nhom.delete_CAT_Nhom(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}