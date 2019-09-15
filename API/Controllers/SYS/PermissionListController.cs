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

	[RoutePrefix("api/CUS/SYS/PermissionList")]
    public class PermissionListController : CustomApiController
    {
		[Route("")]
        public List<DTO_CUS_SYS_Form_Role_PermissionList_Full> Get()
        {
			return BS_CUS_SYS_PermissionList.get_CUS_SYS_PermissionList(db, PartnerID, QueryStrings, true);
        }

        [Route("{id:int}", Name = "get_CUS_SYS_PermissionList")]
        [ResponseType(typeof(DTO_CUS_SYS_PermissionList))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_SYS_PermissionList tbl_CUS_SYS_PermissionList = BS_CUS_SYS_PermissionList.get_CUS_SYS_PermissionList(db, PartnerID, id);
            if (tbl_CUS_SYS_PermissionList == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_SYS_PermissionList);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_SYS_PermissionList tbl_CUS_SYS_PermissionList)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_SYS_PermissionList.ID || PartnerID != tbl_CUS_SYS_PermissionList.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_SYS_PermissionList.put_CUS_SYS_PermissionList(db, PartnerID, id, tbl_CUS_SYS_PermissionList, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_SYS_PermissionList))]
        public IHttpActionResult Post(DTO_CUS_SYS_PermissionList tbl_CUS_SYS_PermissionList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_SYS_PermissionList result = BS_CUS_SYS_PermissionList.post_CUS_SYS_PermissionList(db, PartnerID, tbl_CUS_SYS_PermissionList, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_SYS_PermissionList", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_SYS_PermissionList))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_SYS_PermissionList.check_CUS_SYS_PermissionList_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_SYS_PermissionList.delete_CUS_SYS_PermissionList(db, id, Username); 

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