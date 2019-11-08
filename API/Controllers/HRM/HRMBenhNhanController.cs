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

namespace API.Controllers.HRM
{
    [RoutePrefix("api/HRM/HRMBenhNhan")]
    public class HRMBenhNhanController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CUS_HRM_BenhNhan> Get()
        {
            return BS_CUS_HRM_BenhNhan.get_CUS_HRM_BenhNhan(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_HRM_BenhNhan")]
        [ResponseType(typeof(DTO_CUS_HRM_BenhNhan))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_HRM_BenhNhan tbl_CUS_HRM_BenhNhan = BS_CUS_HRM_BenhNhan.get_CUS_HRM_BenhNhan(db, id);
            if (tbl_CUS_HRM_BenhNhan == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_HRM_BenhNhan);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_HRM_BenhNhan tbl_CUS_HRM_BenhNhan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CUS_HRM_BenhNhan.ID)
            {
                return BadRequest();
            }

            bool result = BS_CUS_HRM_BenhNhan.put_CUS_HRM_BenhNhan(db, id, tbl_CUS_HRM_BenhNhan, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_HRM_BenhNhan))]
        public IHttpActionResult Post(DTO_CUS_HRM_BenhNhan tbl_CUS_HRM_BenhNhan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CUS_HRM_BenhNhan result = BS_CUS_HRM_BenhNhan.post_CUS_HRM_BenhNhan(db, tbl_CUS_HRM_BenhNhan, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CUS_HRM_BenhNhan", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_BenhNhan))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_HRM_BenhNhan.check_CUS_HRM_BenhNhan_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_HRM_BenhNhan.delete_CUS_HRM_BenhNhan(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}