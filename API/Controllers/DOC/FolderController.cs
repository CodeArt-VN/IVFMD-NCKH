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

	[RoutePrefix("api/CUS/DOC/Folder")]
    public class FolderController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_CUS_DOC_Folder> Get()
        {
			return BS_CUS_DOC_Folder.get_CUS_DOC_Folder(db, PartnerID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_DOC_Folder")]
        [ResponseType(typeof(DTO_CUS_DOC_Folder))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_DOC_Folder tbl_CUS_DOC_Folder = BS_CUS_DOC_Folder.get_CUS_DOC_Folder(db, PartnerID, id);
            if (tbl_CUS_DOC_Folder == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_DOC_Folder);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_DOC_Folder tbl_CUS_DOC_Folder)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_DOC_Folder.ID || PartnerID != tbl_CUS_DOC_Folder.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_DOC_Folder.put_CUS_DOC_Folder(db, PartnerID, id, tbl_CUS_DOC_Folder, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_DOC_Folder))]
        public IHttpActionResult Post(DTO_CUS_DOC_Folder tbl_CUS_DOC_Folder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_DOC_Folder result = BS_CUS_DOC_Folder.post_CUS_DOC_Folder(db, PartnerID, tbl_CUS_DOC_Folder, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_DOC_Folder", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_DOC_Folder))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_DOC_Folder.check_CUS_DOC_Folder_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            string result = BS_CUS_DOC_Folder.delete_CUS_DOC_FolderCustom(db, id, Username); 

			if(string.IsNullOrEmpty(result)){
				return StatusCode(HttpStatusCode.NoContent);
            }
            else
            {
                return BadRequest(result);
            }

        }

    }
}


//API info
/*






*/