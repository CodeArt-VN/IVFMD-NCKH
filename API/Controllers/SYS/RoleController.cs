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

namespace API.Controllers.SYS
{

	[RoutePrefix("api/CUS/SYS/Role")]
    public class RoleController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_CUS_SYS_Role> Get()
        {
			return BS_CUS_SYS_Role.get_CUS_SYS_Role(db, PartnerID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_SYS_Role")]
        [ResponseType(typeof(DTO_CUS_SYS_Role))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_SYS_Role tbl_CUS_SYS_Role = BS_CUS_SYS_Role.get_CUS_SYS_Role(db, PartnerID, id);
            if (tbl_CUS_SYS_Role == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_SYS_Role);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_SYS_Role tbl_CUS_SYS_Role)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_SYS_Role.ID || PartnerID != tbl_CUS_SYS_Role.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_SYS_Role.put_CUS_SYS_Role(db, PartnerID, id, tbl_CUS_SYS_Role, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_SYS_Role))]
        public IHttpActionResult Post(DTO_CUS_SYS_Role tbl_CUS_SYS_Role)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_SYS_Role result = BS_CUS_SYS_Role.post_CUS_SYS_Role(db, PartnerID, tbl_CUS_SYS_Role, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_SYS_Role", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_SYS_Role))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_SYS_Role.check_CUS_SYS_Role_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_SYS_Role.delete_CUS_SYS_Role(db, id, Username); 

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