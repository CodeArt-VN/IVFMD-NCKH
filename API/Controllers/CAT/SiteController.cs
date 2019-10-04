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
    [RoutePrefix("api/CAT/Site")]
    public class SiteController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CAT_Site> Get()
        {
            return BS_CAT_Site.get_CAT_Site(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CAT_Site")]
        [ResponseType(typeof(DTO_CAT_Site))]
        public IHttpActionResult Get(int id)
        {
            DTO_CAT_Site tbl_CAT_Site = BS_CAT_Site.get_CAT_Site(db, id);
            if (tbl_CAT_Site == null)
            {
                return NotFound();
            }

            return Ok(tbl_CAT_Site);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CAT_Site tbl_CAT_Site)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CAT_Site.ID)
            {
                return BadRequest();
            }

            bool result = BS_CAT_Site.put_CAT_Site(db, id, tbl_CAT_Site, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CAT_Site))]
        public IHttpActionResult Post(DTO_CAT_Site tbl_CAT_Site)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CAT_Site result = BS_CAT_Site.post_CAT_Site(db, tbl_CAT_Site, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CAT_Site", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CAT_Site))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CAT_Site.check_CAT_Site_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CAT_Site.delete_CAT_Site(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}