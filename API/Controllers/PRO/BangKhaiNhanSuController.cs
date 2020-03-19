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
    [RoutePrefix("api/PRO/BangKhaiNhanSu")]
    public class BangKhaiNhanSuController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_BangKhaiNhanSu> Get()
        {
            return BS_PRO_BangKhaiNhanSu.get_PRO_BangKhaiNhanSu(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_BangKhaiNhanSu")]
        [ResponseType(typeof(DTO_PRO_BangKhaiNhanSu))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_BangKhaiNhanSu tbl_PRO_BangKhaiNhanSu = BS_PRO_BangKhaiNhanSu.get_PRO_BangKhaiNhanSu(db, id);
            if (tbl_PRO_BangKhaiNhanSu == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_BangKhaiNhanSu);
        }

        [Route("get_PRO_BangKhaiNhanSu/{idDeTai:int}")]
        [ResponseType(typeof(DTO_PRO_BangKhaiNhanSu))]
        public IHttpActionResult GetCustom(int idDeTai)
        {
            DTO_PRO_BangKhaiNhanSu tbl_PRO_BangKhaiNhanSu = BS_PRO_BangKhaiNhanSu.get_PRO_BangKhaiNhanSuByDeTai(db, idDeTai);
            //if (tbl_PRO_LLKH.ID == 0)
            //{
            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/BangKhaiNhanSu.html")))
            {
                html = r.ReadToEnd();
            }
            tbl_PRO_BangKhaiNhanSu.HTML = html;

            return Ok(tbl_PRO_BangKhaiNhanSu);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_BangKhaiNhanSu tbl_PRO_BangKhaiNhanSu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_BangKhaiNhanSu.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_BangKhaiNhanSu.put_PRO_BangKhaiNhanSu(db, id, tbl_PRO_BangKhaiNhanSu, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_BangKhaiNhanSu))]
        public IHttpActionResult Post(DTO_PRO_BangKhaiNhanSu tbl_PRO_BangKhaiNhanSu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BangKhaiNhanSu result = BS_PRO_BangKhaiNhanSu.post_PRO_BangKhaiNhanSu(db, tbl_PRO_BangKhaiNhanSu, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_BangKhaiNhanSu", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("refresh_PRO_BangKhaiNhanSu")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Refresh(DTO_PRO_BangKhaiNhanSu tbl_PRO_BangKhaiNhanSu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BS_PRO_BangKhaiNhanSu.refresh_PRO_BangKhaiNhanSuByDeTai(db, tbl_PRO_BangKhaiNhanSu.IDDeTai, Username);
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_BangKhaiNhanSu))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_BangKhaiNhanSu.check_PRO_BangKhaiNhanSu_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_BangKhaiNhanSu.delete_PRO_BangKhaiNhanSu(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }
    }
}