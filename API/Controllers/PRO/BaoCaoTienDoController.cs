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

namespace API.Controllers.PRO
{
    [RoutePrefix("api/PRO/BaoCaoTienDoNghienCuu")]
    public class BaoCaoTienDoNghienCuuController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_BaoCaoTienDoNghienCuu> Get()
        {
            return BS_PRO_BaoCaoTienDoNghienCuu.get_PRO_BaoCaoTienDoNghienCuuCustom(db, QueryStrings);
        }

        [Route("get_PRO_BaoCaoTienDoNghienCuuByDeTai/{deTaiId:int}")]
        public IQueryable<DTO_PRO_BaoCaoTienDoNghienCuu> GetByDeTai(int deTaiId)
        {
            return BS_PRO_BaoCaoTienDoNghienCuu.get_PRO_BaoCaoTienDoNghienCuuByDeTai(db, deTaiId, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_BaoCaoTienDoNghienCuu")]
        [ResponseType(typeof(DTO_PRO_BaoCaoTienDoNghienCuu))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_BaoCaoTienDoNghienCuu tbl_PRO_BaoCaoTienDoNghienCuu = BS_PRO_BaoCaoTienDoNghienCuu.get_PRO_BaoCaoTienDoNghienCuu(db, id);
            if (tbl_PRO_BaoCaoTienDoNghienCuu == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_BaoCaoTienDoNghienCuu);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_BaoCaoTienDoNghienCuu tbl_PRO_BaoCaoTienDoNghienCuu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_BaoCaoTienDoNghienCuu.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_BaoCaoTienDoNghienCuu.put_PRO_BaoCaoTienDoNghienCuu(db, id, tbl_PRO_BaoCaoTienDoNghienCuu, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_BaoCaoTienDoNghienCuu))]
        public IHttpActionResult Post(DTO_PRO_BaoCaoTienDoNghienCuu tbl_PRO_BaoCaoTienDoNghienCuu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BaoCaoTienDoNghienCuu result = BS_PRO_BaoCaoTienDoNghienCuu.post_PRO_BaoCaoTienDoNghienCuu(db, tbl_PRO_BaoCaoTienDoNghienCuu, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_BaoCaoTienDoNghienCuu", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_BaoCaoTienDoNghienCuu))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_BaoCaoTienDoNghienCuu.check_PRO_BaoCaoTienDoNghienCuu_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_BaoCaoTienDoNghienCuu.delete_PRO_BaoCaoTienDoNghienCuu(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        
    }
}