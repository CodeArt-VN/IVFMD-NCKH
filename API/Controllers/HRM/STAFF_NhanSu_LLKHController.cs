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
    [RoutePrefix("api/HRM/STAFF_NhanSu_LLKH")]
    public class STAFF_NhanSu_LLKHController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CUS_HRM_STAFF_NhanSu_LLKH> Get()
        {
            return BS_CUS_HRM_STAFF_NhanSu_LLKH.get_CUS_HRM_STAFF_NhanSu_LLKH(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_HRM_STAFF_NhanSu_LLKH")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_LLKH))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_HRM_STAFF_NhanSu_LLKH tbl_CUS_HRM_STAFF_NhanSu_LLKH = BS_CUS_HRM_STAFF_NhanSu_LLKH.get_CUS_HRM_STAFF_NhanSu_LLKH(db, id);
            if (tbl_CUS_HRM_STAFF_NhanSu_LLKH == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_HRM_STAFF_NhanSu_LLKH);
        }

        [Route("get_CUS_HRM_STAFF_NhanSu_LLKH/{idNhanSu:int}/{isInput?}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_LLKH))]
        public IHttpActionResult GetCustom(int idNhanSu, bool? isInput = false)
        {
            DTO_CUS_HRM_STAFF_NhanSu_LLKH tbl_CUS_HRM_STAFF_NhanSu_LLKH = BS_CUS_HRM_STAFF_NhanSu_LLKH.get_CUS_HRM_STAFF_NhanSu_LLKHByNhanSu(db, idNhanSu);

            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/NhanSuLLKH.html")))
            {
                html = r.ReadToEnd();
            }

            if (isInput == true)
            {
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/NhanSuLLKH_Input.html")))
                {
                    html = r.ReadToEnd();
                }
            }
            tbl_CUS_HRM_STAFF_NhanSu_LLKH.HTML = html;

            return Ok(tbl_CUS_HRM_STAFF_NhanSu_LLKH);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_HRM_STAFF_NhanSu_LLKH tbl_CUS_HRM_STAFF_NhanSu_LLKH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CUS_HRM_STAFF_NhanSu_LLKH.ID)
            {
                return BadRequest();
            }

            bool result = BS_CUS_HRM_STAFF_NhanSu_LLKH.put_CUS_HRM_STAFF_NhanSu_LLKH(db, id, tbl_CUS_HRM_STAFF_NhanSu_LLKH, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_LLKH))]
        public IHttpActionResult Post(DTO_CUS_HRM_STAFF_NhanSu_LLKH tbl_CUS_HRM_STAFF_NhanSu_LLKH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            tbl_CUS_HRM_STAFF_NhanSu_LLKH.IDNhanSu = user.StaffID;
            DTO_CUS_HRM_STAFF_NhanSu_LLKH result = BS_CUS_HRM_STAFF_NhanSu_LLKH.post_CUS_HRM_STAFF_NhanSu_LLKH(db, tbl_CUS_HRM_STAFF_NhanSu_LLKH, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CUS_HRM_STAFF_NhanSu_LLKH", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_LLKH))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_HRM_STAFF_NhanSu_LLKH.check_CUS_HRM_STAFF_NhanSu_LLKH_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_HRM_STAFF_NhanSu_LLKH.delete_CUS_HRM_STAFF_NhanSu_LLKH(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }

        [Route("save_CUS_HRM_STAFF_NhanSu_LLKH")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_LLKH))]
        public IHttpActionResult Save(DTO_CUS_HRM_STAFF_NhanSu_LLKH tbl_CUS_HRM_STAFF_NhanSu_LLKH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CUS_HRM_STAFF_NhanSu_LLKH result = BS_CUS_HRM_STAFF_NhanSu_LLKH.save_CUS_HRM_STAFF_NhanSu_LLKH(db, tbl_CUS_HRM_STAFF_NhanSu_LLKH, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}