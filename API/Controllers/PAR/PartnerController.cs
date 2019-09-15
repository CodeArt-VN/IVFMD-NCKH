//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

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

namespace API.Controllers.PAR
{

	[RoutePrefix("api/PAR/Partner")]
    public class PartnerController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_PAR_Partner> Get()
        {
			return BS_PAR_Partner.get_PAR_Partner(db, PartnerID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PAR_Partner")]
        [ResponseType(typeof(DTO_PAR_Partner))]
        public IHttpActionResult Get(int id)
        {
            DTO_PAR_Partner tbl_PAR_Partner = BS_PAR_Partner.get_PAR_Partner(db, PartnerID, id);
            if (tbl_PAR_Partner == null)
            {
                return NotFound();
            }

            return Ok(tbl_PAR_Partner);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PAR_Partner tbl_PAR_Partner)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_PAR_Partner.ID)
                return BadRequest();
            

            bool resul = BS_PAR_Partner.put_PAR_Partner(db, PartnerID, id, tbl_PAR_Partner, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_PAR_Partner))]
        public IHttpActionResult Post(DTO_PAR_Partner tbl_PAR_Partner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_PAR_Partner result = BS_PAR_Partner.post_PAR_Partner(db, PartnerID, tbl_PAR_Partner, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_PAR_Partner", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PAR_Partner))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PAR_Partner.check_PAR_Partner_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PAR_Partner.delete_PAR_Partner(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
				return Conflict();

        }

    }
}


//API info
/*






*/