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

namespace API.Controllers.DOC
{

	[RoutePrefix("api/CUS/DOC/Folder/Permission")]
    public class Folder_PermissionController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_CUS_DOC_Folder_Permission> Get()
        {
			return BS_CUS_DOC_Folder_Permission.get_CUS_DOC_Folder_Permission(db, PartnerID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_DOC_Folder_Permission")]
        [ResponseType(typeof(DTO_CUS_DOC_Folder_Permission))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_DOC_Folder_Permission tbl_CUS_DOC_Folder_Permission = BS_CUS_DOC_Folder_Permission.get_CUS_DOC_Folder_Permission(db, PartnerID, id);
            if (tbl_CUS_DOC_Folder_Permission == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_DOC_Folder_Permission);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_DOC_Folder_Permission tbl_CUS_DOC_Folder_Permission)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_DOC_Folder_Permission.ID || PartnerID != tbl_CUS_DOC_Folder_Permission.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_DOC_Folder_Permission.put_CUS_DOC_Folder_Permission(db, PartnerID, id, tbl_CUS_DOC_Folder_Permission, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_DOC_Folder_Permission))]
        public IHttpActionResult Post(DTO_CUS_DOC_Folder_Permission tbl_CUS_DOC_Folder_Permission)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_DOC_Folder_Permission result = BS_CUS_DOC_Folder_Permission.post_CUS_DOC_Folder_Permission(db, PartnerID, tbl_CUS_DOC_Folder_Permission, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_DOC_Folder_Permission", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_DOC_Folder_Permission))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_DOC_Folder_Permission.check_CUS_DOC_Folder_Permission_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_DOC_Folder_Permission.delete_CUS_DOC_Folder_Permission(db, id, Username); 

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