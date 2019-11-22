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
    [RoutePrefix("api/CAT/BangGiaKinhPhi")]
    public class BangGiaKinhPhiController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CAT_BangGiaKinhPhi> Get()
        {
            return BS_CAT_BangGiaKinhPhi.get_CAT_BangGiaKinhPhiCustom(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CAT_BangGiaKinhPhi")]
        [ResponseType(typeof(DTO_CAT_BangGiaKinhPhi))]
        public IHttpActionResult Get(int id)
        {
            DTO_CAT_BangGiaKinhPhi tbl_CAT_BangGiaKinhPhi = BS_CAT_BangGiaKinhPhi.get_CAT_BangGiaKinhPhi(db, id);
            if (tbl_CAT_BangGiaKinhPhi == null)
            {
                return NotFound();
            }

            return Ok(tbl_CAT_BangGiaKinhPhi);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CAT_BangGiaKinhPhi tbl_CAT_BangGiaKinhPhi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CAT_BangGiaKinhPhi.ID)
            {
                return BadRequest();
            }

            bool result = BS_CAT_BangGiaKinhPhi.put_CAT_BangGiaKinhPhi(db, id, tbl_CAT_BangGiaKinhPhi, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CAT_BangGiaKinhPhi))]
        public IHttpActionResult Post(DTO_CAT_BangGiaKinhPhi tbl_CAT_BangGiaKinhPhi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CAT_BangGiaKinhPhi result = BS_CAT_BangGiaKinhPhi.post_CAT_BangGiaKinhPhi(db, tbl_CAT_BangGiaKinhPhi, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CAT_BangGiaKinhPhi", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CAT_BangGiaKinhPhi))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CAT_BangGiaKinhPhi.check_CAT_BangGiaKinhPhi_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CAT_BangGiaKinhPhi.delete_CAT_BangGiaKinhPhi(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}