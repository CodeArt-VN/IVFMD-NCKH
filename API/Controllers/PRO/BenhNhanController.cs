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
    [RoutePrefix("api/PRO/BenhNhan")]
    public class BenhNhanController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_BenhNhan> Get()
        {
            return BS_PRO_BenhNhan.get_PRO_BenhNhan(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_BenhNhan")]
        [ResponseType(typeof(DTO_PRO_BenhNhan))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_BenhNhan tbl_PRO_BenhNhan = BS_PRO_BenhNhan.get_PRO_BenhNhanCustom(db, id);
            if (tbl_PRO_BenhNhan == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_BenhNhan);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_BenhNhan tbl_PRO_BenhNhan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_BenhNhan.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_BenhNhan.put_PRO_BenhNhanCustom(db, id, tbl_PRO_BenhNhan, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_BenhNhan))]
        public IHttpActionResult Post(DTO_PRO_BenhNhan tbl_PRO_BenhNhan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BenhNhan result = BS_PRO_BenhNhan.post_PRO_BenhNhan(db, tbl_PRO_BenhNhan, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_BenhNhan", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_BenhNhan))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_BenhNhan.check_PRO_BenhNhan_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_BenhNhan.delete_PRO_BenhNhan(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }

        [Route("get_PRO_BenhNhanByDeTai/{deTaiId:int}")]
        public IQueryable<DTO_PRO_BenhNhan> GetByDeTai(int deTaiId)
        {
            return BS_PRO_BenhNhan.get_PRO_BenhNhanByDeTai(db, deTaiId);
        }

        [Route("save_PRO_BenhNhan")]
        [ResponseType(typeof(DTO_PRO_BenhNhan))]
        public IHttpActionResult Save(DTO_PRO_BenhNhan tbl_PRO_BenhNhan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BenhNhan result = BS_PRO_BenhNhan.save_PRO_BenhNhan(db, tbl_PRO_BenhNhan, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}