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
    [RoutePrefix("api/PRO/HoiNghiHoiThaoDangKyDeTai")]
    public class HoiNghiHoiThaoDangKyDeTaiController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> Get()
        {
            return BS_PRO_HoiNghiHoiThao_DangKyDeTai.get_PRO_HoiNghiHoiThao_DangKyDeTai(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_HoiNghiHoiThao_DangKyDeTai")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKyDeTai))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_HoiNghiHoiThao_DangKyDeTai tbl_PRO_HoiNghiHoiThao_DangKyDeTai = BS_PRO_HoiNghiHoiThao_DangKyDeTai.get_PRO_HoiNghiHoiThao_DangKyDeTai(db, id);
            if (tbl_PRO_HoiNghiHoiThao_DangKyDeTai == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_HoiNghiHoiThao_DangKyDeTai);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_HoiNghiHoiThao_DangKyDeTai tbl_PRO_HoiNghiHoiThao_DangKyDeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_HoiNghiHoiThao_DangKyDeTai.ID)
            {
                return BadRequest();
            }

            string result = BS_PRO_HoiNghiHoiThao_DangKyDeTai.put_PRO_HoiNghiHoiThao_DangKyDeTaiCustom(db, id, tbl_PRO_HoiNghiHoiThao_DangKyDeTai, Username);

            if (string.IsNullOrEmpty(result))
                return StatusCode(HttpStatusCode.NoContent);
            else
                return BadRequest(result);
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKyDeTai))]
        public IHttpActionResult Post(DTO_PRO_HoiNghiHoiThao_DangKyDeTai tbl_PRO_HoiNghiHoiThao_DangKyDeTai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_HoiNghiHoiThao_DangKyDeTai result = BS_PRO_HoiNghiHoiThao_DangKyDeTai.post_PRO_HoiNghiHoiThao_DangKyDeTaiCustom(db, tbl_PRO_HoiNghiHoiThao_DangKyDeTai, Username);


            if (result != null)
            {
                if (!string.IsNullOrEmpty(result.Error))
                    return BadRequest(result.Error);
                return CreatedAtRoute("get_PRO_HoiNghiHoiThao_DangKyDeTai", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKyDeTai))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_HoiNghiHoiThao_DangKyDeTai.check_PRO_HoiNghiHoiThao_DangKyDeTai_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_HoiNghiHoiThao_DangKyDeTai.delete_PRO_HoiNghiHoiThao_DangKyDeTai(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }


        [Route("uploadAbstract_PRO_HoiNghiHoiThaoDangKyDeTai")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKyDeTai))]
        public IHttpActionResult UploadAbstract(DTO_PRO_HoiNghiHoiThao_DangKyDeTai item)
        {
            BS_PRO_HoiNghiHoiThao_DangKyDeTai.uploadAbstract_PRO_HoiNghiHoiThaoDangKyDeTai(db, item.ID, item.BaiAbstract, Username);
            var res = BS_PRO_HoiNghiHoiThao_DangKyDeTai.get_PRO_HoiNghiHoiThao_DangKyDeTai(db, item.ID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [Route("uploadFullText_PRO_HoiNghiHoiThaoDangKyDeTai")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKy))]
        public IHttpActionResult UploadFullText(DTO_PRO_HoiNghiHoiThao_DangKyDeTai item)
        {
            BS_PRO_HoiNghiHoiThao_DangKyDeTai.uploadFullText_PRO_HoiNghiHoiThaoDangKyDeTai(db, item.ID, item.BaiFulltext, Username);
            var res = BS_PRO_HoiNghiHoiThao_DangKyDeTai.get_PRO_HoiNghiHoiThao_DangKyDeTai(db, item.ID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [Route("updateStatus_PRO_HoiNghiHoiThaoDangKyDeTai/{id:int}/{actionCode}")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult UpdateStatus(int id, string actionCode)
        {
            var result = BS_PRO_HoiNghiHoiThao_DangKyDeTai.updateStatus_PRO_HoiNghiHoiThaoDangKyDeTai(db, id, actionCode, Username);
            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);
            DTO_PRO_HoiNghiHoiThao_DangKyDeTai tbl_PRO_HoiNghiHoiThao = BS_PRO_HoiNghiHoiThao_DangKyDeTai.get_PRO_HoiNghiHoiThao_DangKyDeTai(db, id);
            if (tbl_PRO_HoiNghiHoiThao == null)
            {
                return NotFound();
            }
            return Ok(tbl_PRO_HoiNghiHoiThao);
        }
    }
}