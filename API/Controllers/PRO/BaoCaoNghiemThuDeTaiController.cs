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
    [RoutePrefix("api/PRO/BaoCaoNghiemThuDeTai")]
    public class BaoCaoNghiemThuDeTaiController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_BaoCaoNghiemThuDeTai> Get()
        {
            return BS_PRO_BaoCaoNghiemThuDeTai.get_PRO_BaoCaoNghiemThuDeTai(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_BaoCaoNghiemThuDeTai")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNghiemThuDeTai))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_BaoCaoNghiemThuDeTai tbl_PRO_BaoCaoNghiemThuDeTai = BS_PRO_BaoCaoNghiemThuDeTai.get_PRO_BaoCaoNghiemThuDeTai(db, id);
            if (tbl_PRO_BaoCaoNghiemThuDeTai == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_BaoCaoNghiemThuDeTai);
        }

        [Route("get_PRO_BaoCaoNghiemThuDeTai/{idDeTai:int}/{isInput?}")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNghiemThuDeTai))]
        public IHttpActionResult GetCustom(int idDeTai, bool? isInput = false)
        {
            DTO_PRO_BaoCaoNghiemThuDeTai tbl_PRO_BaoCaoNghiemThuDeTai = BS_PRO_BaoCaoNghiemThuDeTai.get_PRO_BaoCaoNghiemThuDeTaiCustom(db, idDeTai);

            string html = "";
            string htmlPrint = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/BaoCaoNghiemThuDeTai.html")))
            {
                htmlPrint = r.ReadToEnd();
            }
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/BaoCaoNghiemThuDeTai_Input.html")))
            {
                html = r.ReadToEnd();
            }

            tbl_PRO_BaoCaoNghiemThuDeTai.HTML = html;
            tbl_PRO_BaoCaoNghiemThuDeTai.HTMLPrint = htmlPrint;

            return Ok(tbl_PRO_BaoCaoNghiemThuDeTai);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_BaoCaoNghiemThuDeTai tbl_PRO_BaoCaoNghiemThuDeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_BaoCaoNghiemThuDeTai.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_BaoCaoNghiemThuDeTai.put_PRO_BaoCaoNghiemThuDeTai(db, id, tbl_PRO_BaoCaoNghiemThuDeTai, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNghiemThuDeTai))]
        public IHttpActionResult Post(DTO_PRO_BaoCaoNghiemThuDeTai tbl_PRO_BaoCaoNghiemThuDeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BaoCaoNghiemThuDeTai result = BS_PRO_BaoCaoNghiemThuDeTai.post_PRO_BaoCaoNghiemThuDeTai(db, tbl_PRO_BaoCaoNghiemThuDeTai, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_BaoCaoNghiemThuDeTai", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNghiemThuDeTai))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_BaoCaoNghiemThuDeTai.check_PRO_BaoCaoNghiemThuDeTai_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_BaoCaoNghiemThuDeTai.delete_PRO_BaoCaoNghiemThuDeTai(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        [Route("save_PRO_BaoCaoNghiemThuDeTai")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNghiemThuDeTai))]
        public IHttpActionResult Save(DTO_PRO_BaoCaoNghiemThuDeTai tbl_PRO_BaoCaoNghiemThuDeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BaoCaoNghiemThuDeTai result = BS_PRO_BaoCaoNghiemThuDeTai.save_PRO_BaoCaoNghiemThuDeTai(db, tbl_PRO_BaoCaoNghiemThuDeTai, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [Route("uploadFullText_PRO_BaoCaoNghiemThuDeTai")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNghiemThuDeTai))]
        public IHttpActionResult UploadFullText(DTO_PRO_BaoCaoNghiemThuDeTai item)
        {
            BS_PRO_BaoCaoNghiemThuDeTai.uploadFullText_PRO_BaoCaoNghiemThuDeTai(db, item.ID, item.BaiFulltext, Username);
            var res = BS_PRO_BaoCaoNghiemThuDeTai.get_PRO_BaoCaoNghiemThuDeTaiCustom(db, item.ID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [Route("uploadFileBaoCaoTongHop_PRO_BaoCaoNghiemThuDeTai")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNghiemThuDeTai))]
        public IHttpActionResult UploadFileBaoCaoTongHop(DTO_PRO_BaoCaoNghiemThuDeTai item)
        {
            BS_PRO_BaoCaoNghiemThuDeTai.uploadFileBaoCaoTongHop_PRO_BaoCaoNghiemThuDeTai(db, item.ID, item.FileBaoCaoTongHop, Username);
            var res = BS_PRO_BaoCaoNghiemThuDeTai.get_PRO_BaoCaoNghiemThuDeTaiCustom(db, item.ID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }
    }
}