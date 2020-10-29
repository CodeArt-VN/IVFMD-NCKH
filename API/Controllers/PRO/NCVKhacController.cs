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
    [RoutePrefix("api/PRO/NCVKhac")]
    public class NCVKhacController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_NCVKhac> Get()
        {
            return BS_PRO_NCVKhac.get_PRO_NCVKhac(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_NCVKhac")]
        [ResponseType(typeof(DTO_PRO_NCVKhac))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_NCVKhac tbl_PRO_NCVKhac = BS_PRO_NCVKhac.get_PRO_NCVKhac(db, id);
            if (tbl_PRO_NCVKhac == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_NCVKhac);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_NCVKhac tbl_PRO_NCVKhac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_NCVKhac.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_NCVKhac.put_PRO_NCVKhac(db, id, tbl_PRO_NCVKhac, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_NCVKhac))]
        public IHttpActionResult Post(DTO_PRO_NCVKhac tbl_PRO_NCVKhac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_NCVKhac result = BS_PRO_NCVKhac.post_PRO_NCVKhac(db, tbl_PRO_NCVKhac, Username);

            if (result != null)
            {
                return CreatedAtRoute("get_PRO_NCVKhac", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_NCVKhac))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_NCVKhac.check_PRO_NCVKhac_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_NCVKhac.delete_PRO_NCVKhac(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        [Route("get_PRO_NCVKhacByDeTai/{deTaiId:int}")]
        public IQueryable<DTO_PRO_NCVKhac> GetByDeTai(int deTaiId)
        {
            return BS_PRO_NCVKhac.get_PRO_NCVKhacByDeTai(db, deTaiId);
        }
    }
}