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
    [AuthorizeAttribute]
    [RoutePrefix("api/PRO/HoSoKhac")]
    public class HoSoKhacController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_HoSoKhac> Get()
        {
            return BS_PRO_HoSoKhac.get_PRO_HoSoKhac(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_HoSoKhac")]
        [ResponseType(typeof(DTO_PRO_HoSoKhac))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_HoSoKhac tbl_PRO_HoSoKhac = BS_PRO_HoSoKhac.get_PRO_HoSoKhac(db, id);
            if (tbl_PRO_HoSoKhac == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_HoSoKhac);
        }

        [Route("get_PRO_HoSoKhacByDeTai/{idDeTai:int}")]
        public IQueryable<DTO_PRO_HoSoKhac> GetCustom(int idDeTai)
        {
            return BS_PRO_HoSoKhac.get_PRO_HoSoKhacByDeTai(db, QueryStrings, idDeTai);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_HoSoKhac tbl_PRO_HoSoKhac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_HoSoKhac.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_HoSoKhac.put_PRO_HoSoKhac(db, id, tbl_PRO_HoSoKhac, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_HoSoKhac))]
        public IHttpActionResult Post(DTO_PRO_HoSoKhac tbl_PRO_HoSoKhac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_HoSoKhac result = BS_PRO_HoSoKhac.post_PRO_HoSoKhac(db, tbl_PRO_HoSoKhac, Username);

            if (result != null)
            {
                return CreatedAtRoute("get_PRO_HoSoKhac", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_HoSoKhac))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_HoSoKhac.check_PRO_HoSoKhac_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_HoSoKhac.delete_PRO_HoSoKhac(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }
    }
}