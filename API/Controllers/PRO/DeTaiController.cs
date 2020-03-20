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
using System.Configuration;

namespace API.Controllers.PRO
{
    [RoutePrefix("api/PRO/DeTai")]
    public class DeTaiController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_DeTai> Get()
        {
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            return BS_PRO_DeTai.get_PRO_DeTaiCustom(db, PartnerID, user.StaffID, QueryStrings);
        }

        [Route("get_PRO_DeTaiByRefer")]
        public IQueryable<DTO_PRO_DeTai> GetByRefer()
        {
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            return BS_PRO_DeTai.get_PRO_DeTaiByRefer(db, PartnerID, user.StaffID, QueryStrings);
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

        [Route("get_PRO_DeTaiCustom/{id:int}")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult GetCustom(int id)
        {
            DTO_PRO_DeTai tbl_PRO_DeTai = BS_PRO_DeTai.get_PRO_DeTaiCustom(db, id);
            if (tbl_PRO_DeTai == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_DeTai);
        }

        [Route("updateStatus_PRO_DeTai/{id:int}/{actionCode}/{typeId:int}")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult UpdateStatus(int id, string actionCode, int typeId)
        {
            var result = BS_PRO_DeTai.updateStatus_PRO_DeTai(db, id, actionCode, typeId, Username);
            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);
            DTO_PRO_DeTai tbl_PRO_DeTai = BS_PRO_DeTai.get_PRO_DeTaiCustom(db, id);
            if (tbl_PRO_DeTai == null)
            {
                return NotFound();
            }
            return Ok(tbl_PRO_DeTai);
        }

        [Route("updateNCT_PRO_DeTai/{id:int}/{soNCT}")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult UpdateNCT(int id, string soNCT)
        {
            var result = BS_PRO_DeTai.updateNCT_PRO_DeTai(db, id, soNCT, Username);
            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);
            DTO_PRO_DeTai tbl_PRO_DeTai = BS_PRO_DeTai.get_PRO_DeTaiCustom(db, id);
            if (tbl_PRO_DeTai == null)
            {
                return NotFound();
            }
            return Ok(tbl_PRO_DeTai);
        }

        [Route("updateMaSo_PRO_DeTai")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult UpdateMaSo(DTO_PRO_DeTai tbl_PRO_DeTai)
        {
            var result = BS_PRO_DeTai.updateMaSo_PRO_DeTai(db, tbl_PRO_DeTai, Username);
            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);
            DTO_PRO_DeTai item = BS_PRO_DeTai.get_PRO_DeTaiCustom(db, tbl_PRO_DeTai.ID);
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
            if (user.StaffID <= 0)
                return BadRequest("Chưa tạo nhân sự cho tài khoản");

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

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        [Route("print")]
        [ResponseType(typeof(DTO_PRO_DeTai_PrinterData))]
        public IHttpActionResult Print(DTO_PRO_DeTai_PrinterData item)
        {
            var exportPath = ConfigurationManager.AppSettings["PdfExportPath"] ?? @"/PDFFiles/";
            var path = System.IO.Path.Combine(exportPath, DateTime.Now.Ticks.ToString() + ".pdf");
            var pp = NckhHtmlToPdfConverter.HtmlToPdf(System.Web.Hosting.HostingEnvironment.MapPath(path), item.htmlContent, item.htmlHeader, item.htmlFooter, item.pxHeader, item.pxFooter, item.firstPageHeader);
            return Ok(path);
        }

        [Route("uploadFile")]
        public IHttpActionResult UploadFile(DTO_PRO_DeTai item)
        {
            BS_PRO_DeTai.uploadFile(db, item.ID, item.FileUpload, Username);
            return Ok();
        }

        [Route("uploadFileChapThuan")]
        public IHttpActionResult UploadFileChapThuan(DTO_PRO_DeTai item)
        {
            BS_PRO_DeTai.uploadFileChapThuan(db, item.ID, item.FileChapThuan, Username);
            return Ok();
        }
    }
}