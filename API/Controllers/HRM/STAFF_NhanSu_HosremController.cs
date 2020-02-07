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

namespace API.Controllers.HRM
{
    [RoutePrefix("api/HRM/STAFF_NhanSu_Hosrem")]
    public class STAFF_NhanSu_HosremController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CUS_HRM_STAFF_NhanSu_HOSREM> Get()
        {
            return BS_CUS_HRM_STAFF_NhanSu_HOSREM.get_CUS_HRM_STAFF_NhanSu_HOSREM(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_HRM_STAFF_NhanSu_HOSREM")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_HOSREM))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_HRM_STAFF_NhanSu_HOSREM tbl_CUS_HRM_STAFF_NhanSu_HOSREM = BS_CUS_HRM_STAFF_NhanSu_HOSREM.get_CUS_HRM_STAFF_NhanSu_HOSREM(db, id);
            if (tbl_CUS_HRM_STAFF_NhanSu_HOSREM == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_HRM_STAFF_NhanSu_HOSREM);
        }

        [Route("get_CUS_HRM_STAFF_NhanSu_HOSREM/{idNhanSu:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_HOSREM))]
        public IHttpActionResult GetCustom(int idNhanSu)
        {
            DTO_CUS_HRM_STAFF_NhanSu_HOSREM tbl_CUS_HRM_STAFF_NhanSu_HOSREM = BS_CUS_HRM_STAFF_NhanSu_HOSREM.get_CUS_HRM_STAFF_NhanSu_HOSREMByNhanSu(db, idNhanSu);
            //if (tbl_CUS_HRM_STAFF_NhanSu_LLKH.ID == 0)
            //{
            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/HOSREM.html")))
            {
                html = r.ReadToEnd();
            }
            tbl_CUS_HRM_STAFF_NhanSu_HOSREM.HTML = html;
            //}

            return Ok(tbl_CUS_HRM_STAFF_NhanSu_HOSREM);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_HRM_STAFF_NhanSu_HOSREM tbl_CUS_HRM_STAFF_NhanSu_HOSREM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CUS_HRM_STAFF_NhanSu_HOSREM.ID)
            {
                return BadRequest();
            }

            bool result = BS_CUS_HRM_STAFF_NhanSu_HOSREM.put_CUS_HRM_STAFF_NhanSu_HOSREM(db, id, tbl_CUS_HRM_STAFF_NhanSu_HOSREM, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_HOSREM))]
        public IHttpActionResult Post(DTO_CUS_HRM_STAFF_NhanSu_HOSREM tbl_CUS_HRM_STAFF_NhanSu_HOSREM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CUS_HRM_STAFF_NhanSu_HOSREM result = BS_CUS_HRM_STAFF_NhanSu_HOSREM.post_CUS_HRM_STAFF_NhanSu_HOSREM(db, tbl_CUS_HRM_STAFF_NhanSu_HOSREM, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CUS_HRM_STAFF_NhanSu_HOSREM", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_HOSREM))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_HRM_STAFF_NhanSu_HOSREM.check_CUS_HRM_STAFF_NhanSu_HOSREM_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_HRM_STAFF_NhanSu_HOSREM.delete_CUS_HRM_STAFF_NhanSu_HOSREM(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }

        [Route("save_CUS_HRM_STAFF_NhanSu_HOSREM")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_HOSREM))]
        public IHttpActionResult Save(DTO_CUS_HRM_STAFF_NhanSu_HOSREM tbl_CUS_HRM_STAFF_NhanSu_HOSREM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            tbl_CUS_HRM_STAFF_NhanSu_HOSREM.IDNhanSu = user.StaffID;
            DTO_CUS_HRM_STAFF_NhanSu_HOSREM result = BS_CUS_HRM_STAFF_NhanSu_HOSREM.save_CUS_HRM_STAFF_NhanSu_HOSREM(db, tbl_CUS_HRM_STAFF_NhanSu_HOSREM, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}