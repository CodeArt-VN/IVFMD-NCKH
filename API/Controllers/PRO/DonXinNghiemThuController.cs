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
    [RoutePrefix("api/PRO/DonXinNghiemThu")]
    public class DonXinNghiemThuController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_DonXinNghiemThu> Get()
        {
            return BS_PRO_DonXinNghiemThu.get_PRO_DonXinNghiemThu(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_DonXinNghiemThu")]
        [ResponseType(typeof(DTO_PRO_DonXinNghiemThu))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_DonXinNghiemThu tbl_PRO_DonXinNghiemThu = BS_PRO_DonXinNghiemThu.get_PRO_DonXinNghiemThu(db, id);
            if (tbl_PRO_DonXinNghiemThu == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_DonXinNghiemThu);
        }

        [Route("get_PRO_DonXinNghiemThuByDeTai/{idDeTai:int}/{isInput?}")]
        [ResponseType(typeof(DTO_PRO_DonXinNghiemThu))]
        public IHttpActionResult GetCustom(int idDeTai, bool? isInput = false)
        {
            DTO_PRO_DonXinNghiemThu tbl_PRO_DonXinNghiemThu = BS_PRO_DonXinNghiemThu.get_PRO_DonXinNghiemThuByDeTai(db, idDeTai);

            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/DonXinNghiemThu.html")))
            {
                html = r.ReadToEnd();
            }

            if (isInput == true)
            {
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/DonXinNghiemThu_Input.html")))
                {
                    html = r.ReadToEnd();
                }
            }
            tbl_PRO_DonXinNghiemThu.HTML = html;

            return Ok(tbl_PRO_DonXinNghiemThu);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_DonXinNghiemThu tbl_PRO_DonXinNghiemThu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_DonXinNghiemThu.ID)
            {
                return BadRequest();
            }

            var result = BS_PRO_DonXinNghiemThu.save_PRO_DonXinNghiemThu(db, tbl_PRO_DonXinNghiemThu, Username);
            
            if (result != null)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_DonXinNghiemThu))]
        public IHttpActionResult Post(DTO_PRO_DonXinNghiemThu tbl_PRO_DonXinNghiemThu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_DonXinNghiemThu result = BS_PRO_DonXinNghiemThu.save_PRO_DonXinNghiemThu(db, tbl_PRO_DonXinNghiemThu, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_DonXinNghiemThu", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_DonXinNghiemThu))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_DonXinNghiemThu.check_PRO_DonXinNghiemThu_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_DonXinNghiemThu.delete_PRO_DonXinNghiemThu(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}