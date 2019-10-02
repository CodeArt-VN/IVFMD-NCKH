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
    [RoutePrefix("api/CAT/Tags")]
    public class TagsController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CAT_Tags> Get()
        {
            return BS_CAT_Tags.get_CAT_Tags(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CAT_Tags")]
        [ResponseType(typeof(DTO_CAT_Tags))]
        public IHttpActionResult Get(int id)
        {
            DTO_CAT_Tags tbl_CAT_Tags = BS_CAT_Tags.get_CAT_Tags(db, id);
            if (tbl_CAT_Tags == null)
            {
                return NotFound();
            }

            return Ok(tbl_CAT_Tags);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CAT_Tags tbl_CAT_Tags)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CAT_Tags.ID)
            {
                return BadRequest();
            }

            bool result = BS_CAT_Tags.put_CAT_Tags(db, id, tbl_CAT_Tags, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CAT_Tags))]
        public IHttpActionResult Post(DTO_CAT_Tags tbl_CAT_Tags)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CAT_Tags result = BS_CAT_Tags.post_CAT_Tags(db, tbl_CAT_Tags, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CAT_Tags", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CAT_Tags))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CAT_Tags.check_CAT_Tags_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CAT_Tags.delete_CAT_Tags(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
				return Conflict();
        }
    }
}