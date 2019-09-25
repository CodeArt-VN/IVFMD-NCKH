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

	[RoutePrefix("api/WEB/BaiViet")]
    public class BaiVietController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_WEB_BaiViet> Get()
        {
			return BS_WEB_BaiViet.get_WEB_BaiViet(db, PartnerID, QueryStrings, true);
        }

        [Route("home-page")]
        public IQueryable<DTO_WEB_BaiViet> GetHomePage()
        {
            return BS_WEB_BaiViet.get_WEB_BaiViet(db, QueryStrings);
        }
        [Route("list-page/{id:int}")]
        public IQueryable<DTO_WEB_BaiViet> GetListPage()
        {
            return BS_WEB_BaiViet.get_WEB_BaiViet(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_WEB_BaiViet")]
        [ResponseType(typeof(DTO_WEB_BaiViet))]
        public IHttpActionResult Get(int id)
        {
            DTO_WEB_BaiViet tbl_WEB_BaiViet = BS_WEB_BaiViet.get_WEB_BaiViet(db, id);
            if (tbl_WEB_BaiViet == null)
            {
                return NotFound();
            }

            return Ok(tbl_WEB_BaiViet);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_WEB_BaiViet tbl_WEB_BaiViet)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_WEB_BaiViet.ID)
                return BadRequest();
            //#/bai-viet/12/gioi-thieu-phong-qm

            tbl_WEB_BaiViet.URL = "#/bai-viet/" + tbl_WEB_BaiViet.ID.ToString() + "/" +
            iData.Common.StringUtil.RemoveVietSignSpecialCharAndSpaceChar(tbl_WEB_BaiViet.Name);

            bool resul = BS_WEB_BaiViet.put_WEB_BaiViet(db, id, tbl_WEB_BaiViet, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_WEB_BaiViet))]
        public IHttpActionResult Post(DTO_WEB_BaiViet tbl_WEB_BaiViet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_WEB_BaiViet result = BS_WEB_BaiViet.post_WEB_BaiViet(db, tbl_WEB_BaiViet, Username);
            Put(result.ID, result);


            if (result!=null)
            {
                return CreatedAtRoute("get_WEB_BaiViet", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_WEB_BaiViet))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_WEB_BaiViet.check_WEB_BaiViet_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_WEB_BaiViet.delete_WEB_BaiViet(db, id, Username); 

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