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

namespace API.Controllers.WEB
{

	[RoutePrefix("api/WEB/DanhMuc")]
    public class DanhMucController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_WEB_DanhMuc> Get()
        {
			return BS_WEB_DanhMuc.get_WEB_DanhMuc(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_WEB_DanhMuc")]
        [ResponseType(typeof(DTO_WEB_DanhMuc))]
        public IHttpActionResult Get(int id)
        {
            DTO_WEB_DanhMuc tbl_WEB_DanhMuc = BS_WEB_DanhMuc.get_WEB_DanhMuc(db, id);
            if (tbl_WEB_DanhMuc == null)
            {
                return NotFound();
            }

            return Ok(tbl_WEB_DanhMuc);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_WEB_DanhMuc tbl_WEB_DanhMuc)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_WEB_DanhMuc.ID)
                return BadRequest();
            

            bool resul = BS_WEB_DanhMuc.put_WEB_DanhMuc(db, id, tbl_WEB_DanhMuc, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_WEB_DanhMuc))]
        public IHttpActionResult Post(DTO_WEB_DanhMuc tbl_WEB_DanhMuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_WEB_DanhMuc result = BS_WEB_DanhMuc.post_WEB_DanhMuc(db, tbl_WEB_DanhMuc, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_WEB_DanhMuc", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_WEB_DanhMuc))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_WEB_DanhMuc.check_WEB_DanhMuc_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_WEB_DanhMuc.delete_WEB_DanhMuc(db, id, Username); 

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