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
    [RoutePrefix("api/PRO/SYLL")]
    public class SYLLController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_SYLL> Get()
        {
            return BS_PRO_SYLL.get_PRO_SYLL(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_SYLL")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_SYLL tbl_PRO_SYLL = BS_PRO_SYLL.get_PRO_SYLL(db, id);
            if (tbl_PRO_SYLL == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_SYLL);
        }

        [Route("get_PRO_SYLL/{idDeTai:int}/{idNhanSu:int}/{isChuNhiem}/{isInput?}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_SYLL))]
        public IHttpActionResult GetCustom(int idDeTai, int idNhanSu, bool isChuNhiem, bool? isInput = false)
        {
            DTO_PRO_SYLL tbl_PRO_SYLL = BS_PRO_SYLL.get_PRO_SYLLCustom(db, idDeTai, idNhanSu);
            //if (tbl_PRO_LLKH.ID == 0)
            //{
            string html = "";
            string htmlPrint = "";
            if (isChuNhiem)
            {
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/NhanSuSYLL_ChuNhiemDeTai.html")))
                {
                    htmlPrint = r.ReadToEnd();
                }
            }
            else
            {
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/NhanSuSYLL.html")))
                {
                    htmlPrint = r.ReadToEnd();
                }
            }

            if (isChuNhiem)
            {
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/NhanSuSYLL_ChuNhiemDeTai_Input.html")))
                {
                    html = r.ReadToEnd();
                }
            }
            else
            {
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/NhanSuSYLL_Input.html")))
                {
                    html = r.ReadToEnd();
                }
            }

            tbl_PRO_SYLL.HTML = html;
            tbl_PRO_SYLL.HTMLPrint = htmlPrint;
            //}

            return Ok(tbl_PRO_SYLL);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_SYLL tbl_PRO_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_SYLL.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_SYLL.put_PRO_SYLL(db, id, tbl_PRO_SYLL, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Post(DTO_PRO_SYLL tbl_PRO_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_SYLL result = BS_PRO_SYLL.post_PRO_SYLL(db, tbl_PRO_SYLL, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_SYLL", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_SYLL.check_PRO_SYLL_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_SYLL.delete_PRO_SYLL(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        [Route("save_PRO_SYLL")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Save(DTO_PRO_SYLL tbl_PRO_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_SYLL result = BS_PRO_SYLL.save_PRO_SYLL(db, tbl_PRO_SYLL, Username);

            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [Route("update_PRO_SYLL")]
        [ResponseType(typeof(DTO_PRO_SYLL))]
        public IHttpActionResult Update(DTO_PRO_SYLL tbl_PRO_SYLL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_SYLL result = BS_PRO_SYLL.update_PRO_SYLL(db, tbl_PRO_SYLL, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}