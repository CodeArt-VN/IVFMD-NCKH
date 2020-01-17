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
    [RoutePrefix("api/HRM/STAFF_NhanSu_SYLL")]
    public class STAFF_NhanSu_SYLLController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CUS_HRM_STAFF_NhanSu_SYLL> Get()
        {
            return BS_CUS_HRM_STAFF_NhanSu_SYLL.get_CUS_HRM_STAFF_NhanSu_SYLL(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_HRM_STAFF_NhanSu_SYLL")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_SYLL))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_HRM_STAFF_NhanSu_SYLL tbl_CUS_HRM_STAFF_NhanSu_SYLL = BS_CUS_HRM_STAFF_NhanSu_SYLL.get_CUS_HRM_STAFF_NhanSu_SYLL(db, id);
            if (tbl_CUS_HRM_STAFF_NhanSu_SYLL == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_HRM_STAFF_NhanSu_SYLL);
        }

        [Route("get_CUS_HRM_STAFF_NhanSu_SYLL/{idNhanSu:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_SYLL))]
        public IHttpActionResult GetCustom(int idNhanSu)
        {
            DTO_CUS_HRM_STAFF_NhanSu_SYLL tbl_CUS_HRM_STAFF_NhanSu_SYLL = BS_CUS_HRM_STAFF_NhanSu_SYLL.get_CUS_HRM_STAFF_NhanSu_SYLLByNhanSu(db, idNhanSu);
            //if (tbl_CUS_HRM_STAFF_NhanSu_LLKH.ID == 0)
            //{
            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/NhanSuSYLL.html")))
            {
                html = r.ReadToEnd();
            }
            tbl_CUS_HRM_STAFF_NhanSu_SYLL.HTML = html;
            //}

            return Ok(tbl_CUS_HRM_STAFF_NhanSu_SYLL);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_HRM_STAFF_NhanSu_SYLL tbl_CUS_HRM_STAFF_NhanSu_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CUS_HRM_STAFF_NhanSu_SYLL.ID)
            {
                return BadRequest();
            }

            bool result = BS_CUS_HRM_STAFF_NhanSu_SYLL.put_CUS_HRM_STAFF_NhanSu_SYLL(db, id, tbl_CUS_HRM_STAFF_NhanSu_SYLL, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_SYLL))]
        public IHttpActionResult Post(DTO_CUS_HRM_STAFF_NhanSu_SYLL tbl_CUS_HRM_STAFF_NhanSu_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CUS_HRM_STAFF_NhanSu_SYLL result = BS_CUS_HRM_STAFF_NhanSu_SYLL.post_CUS_HRM_STAFF_NhanSu_SYLL(db, tbl_CUS_HRM_STAFF_NhanSu_SYLL, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CUS_HRM_STAFF_NhanSu_SYLL", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_SYLL))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_HRM_STAFF_NhanSu_SYLL.check_CUS_HRM_STAFF_NhanSu_SYLL_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_HRM_STAFF_NhanSu_SYLL.delete_CUS_HRM_STAFF_NhanSu_SYLL(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }

        [Route("save_CUS_HRM_STAFF_NhanSu_SYLL")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_SYLL))]
        public IHttpActionResult Save(DTO_CUS_HRM_STAFF_NhanSu_SYLL tbl_CUS_HRM_STAFF_NhanSu_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            tbl_CUS_HRM_STAFF_NhanSu_SYLL.IDNhanSu = user.StaffID;
            DTO_CUS_HRM_STAFF_NhanSu_SYLL result = BS_CUS_HRM_STAFF_NhanSu_SYLL.save_CUS_HRM_STAFF_NhanSu_SYLL(db, tbl_CUS_HRM_STAFF_NhanSu_SYLL, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}