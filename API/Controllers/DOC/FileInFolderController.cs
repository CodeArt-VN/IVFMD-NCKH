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

	[RoutePrefix("api/CUS/DOC/FileInFolder")]
    public class FileInFolderController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_CUS_DOC_FileInFolder> Get()
        {
			return BS_CUS_DOC_FileInFolder.get_CUS_DOC_FileInFolder(db, PartnerID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_DOC_FileInFolder")]
        [ResponseType(typeof(DTO_CUS_DOC_FileInFolder))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_DOC_FileInFolder tbl_CUS_DOC_FileInFolder = BS_CUS_DOC_FileInFolder.get_CUS_DOC_FileInFolder(db, PartnerID, id);
            if (tbl_CUS_DOC_FileInFolder == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_DOC_FileInFolder);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_DOC_FileInFolder tbl_CUS_DOC_FileInFolder)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_DOC_FileInFolder.ID || PartnerID != tbl_CUS_DOC_FileInFolder.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_DOC_FileInFolder.put_CUS_DOC_FileInFolder(db, PartnerID, id, tbl_CUS_DOC_FileInFolder, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_DOC_FileInFolder))]
        public IHttpActionResult Post(DTO_CUS_DOC_FileInFolder tbl_CUS_DOC_FileInFolder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_DOC_FileInFolder result = BS_CUS_DOC_FileInFolder.post_CUS_DOC_FileInFolder(db, PartnerID, tbl_CUS_DOC_FileInFolder, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_DOC_FileInFolder", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_DOC_FileInFolder))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_DOC_FileInFolder.check_CUS_DOC_FileInFolder_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_DOC_FileInFolder.delete_CUS_DOC_FileInFolder(db, id, Username); 

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