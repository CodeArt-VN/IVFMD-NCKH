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
using API.Models;
using Microsoft.AspNet.Identity;

namespace API.Controllers.PRO
{
    [RoutePrefix("api/PRO/DeTai")]
    public class DeTaiController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_DeTai> Get()
        {
            return BS_PRO_DeTai.get_PRO_DeTai(db, PartnerID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_DeTai")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_DeTai tbl_PRO_DeTai = BS_PRO_DeTai.get_PRO_DeTai(db, PartnerID, id);
            if (tbl_PRO_DeTai == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_DeTai);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_DeTai tbl_PRO_DeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_DeTai.ID)
            {
                return BadRequest();
            }
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            DTO_PRO_DeTai result = BS_PRO_DeTai.save_PRO_DeTai(db, PartnerID, id, user.StaffID, tbl_PRO_DeTai, Username);

            if (result != null)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult Post(DTO_PRO_DeTai tbl_PRO_DeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            DTO_PRO_DeTai result = BS_PRO_DeTai.save_PRO_DeTai(db, PartnerID, -1, user.StaffID, tbl_PRO_DeTai, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_DeTai", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_DeTai.check_PRO_DeTai_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_DeTai.delete_PRO_DeTai(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}