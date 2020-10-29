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
    [RoutePrefix("api/PRO/BaoCaoNangSuatKhoaHoc")]
    public class BaoCaoNangSuatKhoaHocController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> Get()
        {
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            return BS_PRO_BaoCaoNangSuatKhoaHoc.get_PRO_BaoCaoNangSuatKhoaHocCustom(db, user.StaffID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_BaoCaoNangSuatKhoaHoc")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNangSuatKhoaHoc))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_BaoCaoNangSuatKhoaHoc tbl_PRO_BaoCaoNangSuatKhoaHoc = BS_PRO_BaoCaoNangSuatKhoaHoc.get_PRO_BaoCaoNangSuatKhoaHocByID(db, id);
            if (tbl_PRO_BaoCaoNangSuatKhoaHoc == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_BaoCaoNangSuatKhoaHoc);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_BaoCaoNangSuatKhoaHoc tbl_PRO_BaoCaoNangSuatKhoaHoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_BaoCaoNangSuatKhoaHoc.ID)
            {
                return BadRequest();
            }
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            if (user.StaffID <= 0)
                return BadRequest("Chưa tạo nhân sự cho tài khoản");

            string res = BS_PRO_BaoCaoNangSuatKhoaHoc.put_PRO_BaoCaoNangSuatKhoaHocCustom(db, id, tbl_PRO_BaoCaoNangSuatKhoaHoc, Username);

            if (string.IsNullOrEmpty(res))
                return StatusCode(HttpStatusCode.NoContent);
            else
                return BadRequest(res);
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNangSuatKhoaHoc))]
        public IHttpActionResult Post(DTO_PRO_BaoCaoNangSuatKhoaHoc tbl_PRO_BaoCaoNangSuatKhoaHoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            if (user.StaffID <= 0)
                return BadRequest("Tài khoản chưa tạo nhân sự, không thể tạo mới");

            DTO_PRO_BaoCaoNangSuatKhoaHoc result = BS_PRO_BaoCaoNangSuatKhoaHoc.post_PRO_BaoCaoNangSuatKhoaHocCustom(db, user.StaffID, tbl_PRO_BaoCaoNangSuatKhoaHoc, Username);

            if (result != null && !string.IsNullOrEmpty(result.Error))
                return BadRequest(result.Error);

            if (result != null)
            {
                return CreatedAtRoute("get_PRO_BaoCaoNangSuatKhoaHoc", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("updateStatus_PRO_BaoCaoNangSuatKhoaHoc/{id:int}/{actionCode}")]
        [ResponseType(typeof(DTO_PRO_DeTai))]
        public IHttpActionResult UpdateStatus(int id, string actionCode)
        {
            var result = BS_PRO_BaoCaoNangSuatKhoaHoc.updateStatus_PRO_BaoCaoNangSuatKhoaHoc(db, id, actionCode, Username);
            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);
            DTO_PRO_BaoCaoNangSuatKhoaHoc tbl_PRO_BaoCaoNangSuatKhoaHoc = BS_PRO_BaoCaoNangSuatKhoaHoc.get_PRO_BaoCaoNangSuatKhoaHoc(db, id);
            if (tbl_PRO_BaoCaoNangSuatKhoaHoc == null)
            {
                return NotFound();
            }
            return Ok(tbl_PRO_BaoCaoNangSuatKhoaHoc);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNangSuatKhoaHoc))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_BaoCaoNangSuatKhoaHoc.check_PRO_BaoCaoNangSuatKhoaHoc_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_BaoCaoNangSuatKhoaHoc.delete_PRO_BaoCaoNangSuatKhoaHoc(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }


    }
}