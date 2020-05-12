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
    [RoutePrefix("api/CAT/LinhVuc")]
    public class LinhVucController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CAT_LinhVuc> Get()
        {
            return BS_CAT_LinhVuc.get_CAT_LinhVucCustom(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CAT_LinhVuc")]
        [ResponseType(typeof(DTO_CAT_LinhVuc))]
        public IHttpActionResult Get(int id)
        {
            DTO_CAT_LinhVuc tbl_CAT_LinhVuc = BS_CAT_LinhVuc.get_CAT_LinhVuc(db, id);
            if (tbl_CAT_LinhVuc == null)
            {
                return NotFound();
            }

            return Ok(tbl_CAT_LinhVuc);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CAT_LinhVuc tbl_CAT_LinhVuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CAT_LinhVuc.ID)
            {
                return BadRequest();
            }

            bool result = BS_CAT_LinhVuc.put_CAT_LinhVucCustom(db, id, tbl_CAT_LinhVuc, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CAT_LinhVuc))]
        public IHttpActionResult Post(DTO_CAT_LinhVuc tbl_CAT_LinhVuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CAT_LinhVuc result = BS_CAT_LinhVuc.post_CAT_LinhVucCustom(db, tbl_CAT_LinhVuc, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CAT_LinhVuc", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CAT_LinhVuc))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CAT_LinhVuc.check_CAT_LinhVuc_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CAT_LinhVuc.delete_CAT_LinhVuc(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}