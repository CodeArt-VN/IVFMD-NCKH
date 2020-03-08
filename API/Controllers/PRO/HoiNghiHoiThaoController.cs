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
    [RoutePrefix("api/PRO/HoiNghiHoiThao")]
    public class HoiNghiHoiThaoController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_HoiNghiHoiThao> Get()
        {
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            return BS_PRO_HoiNghiHoiThao.get_PRO_HoiNghiHoiThaoCustom(db, user.StaffID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_HoiNghiHoiThao")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_HoiNghiHoiThao tbl_PRO_HoiNghiHoiThao = BS_PRO_HoiNghiHoiThao.get_PRO_HoiNghiHoiThao(db, id);
            if (tbl_PRO_HoiNghiHoiThao == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_HoiNghiHoiThao);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_HoiNghiHoiThao tbl_PRO_HoiNghiHoiThao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_HoiNghiHoiThao.ID)
            {
                return BadRequest();
            }

            bool res = BS_PRO_HoiNghiHoiThao.put_PRO_HoiNghiHoiThaoCustom(db, id, tbl_PRO_HoiNghiHoiThao, Username);

            if (res)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("uploadAbstract_PRO_HoiNghiHoiThao")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao))]
        public IHttpActionResult UploadAbstract(DTO_PRO_HoiNghiHoiThao item)
        {
            BS_PRO_HoiNghiHoiThao.uploadAbstract_PRO_HoiNghiHoiThao(db, item.ID, item.BaiAbstract, Username);
            var res = BS_PRO_HoiNghiHoiThao.get_PRO_HoiNghiHoiThao(db, item.ID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [Route("uploadFullText_PRO_HoiNghiHoiThao")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao))]
        public IHttpActionResult UploadFullText(DTO_PRO_HoiNghiHoiThao item)
        {
            BS_PRO_HoiNghiHoiThao.uploadFullText_PRO_HoiNghiHoiThao(db, item.ID, item.BaiFulltext, Username);
            var res = BS_PRO_HoiNghiHoiThao.get_PRO_HoiNghiHoiThao(db, item.ID);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao))]
        public IHttpActionResult Post(DTO_PRO_HoiNghiHoiThao tbl_PRO_HoiNghiHoiThao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            tbl_PRO_HoiNghiHoiThao.IDTrangThai = -(int)SYSVarType.TrangThai_HNHT_ChoGui;
            DTO_PRO_HoiNghiHoiThao result = BS_PRO_HoiNghiHoiThao.post_PRO_HoiNghiHoiThaoCustom(db, tbl_PRO_HoiNghiHoiThao, Username);

            if (result != null)
            {
                return CreatedAtRoute("get_PRO_HoiNghiHoiThao", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("updateStatus_PRO_HoiNghiHoiThao/{id:int}/{actionCode}")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult UpdateStatus(int id, string actionCode)
        {
            var result = BS_PRO_HoiNghiHoiThao.updateStatus_PRO_HoiNghiHoiThao(db, id, actionCode, Username);
            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);
            DTO_PRO_HoiNghiHoiThao tbl_PRO_HoiNghiHoiThao = BS_PRO_HoiNghiHoiThao.get_PRO_HoiNghiHoiThao(db, id);
            if (tbl_PRO_HoiNghiHoiThao == null)
            {
                return NotFound();
            }
            return Ok(tbl_PRO_HoiNghiHoiThao);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_HoiNghiHoiThao.check_PRO_HoiNghiHoiThao_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_HoiNghiHoiThao.delete_PRO_HoiNghiHoiThao(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        
    }
}