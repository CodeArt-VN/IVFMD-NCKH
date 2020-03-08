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
    [RoutePrefix("api/PRO/HoiNghiHoiThaoDangKy")]
    public class HoiNghiHoiThaoDangKyController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_HoiNghiHoiThao_DangKy> Get()
        {
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            return BS_PRO_HoiNghiHoiThao_DangKy.get_PRO_HoiNghiHoiThao_DangKyTheoNCV(db, QueryStrings, user.StaffID);
        }

        [Route("get_PRO_HoiNghiHoiThaoDangKyTheoHoiNghi/{idHoiNghi:int}")]
        public IQueryable<DTO_PRO_HoiNghiHoiThao_DangKy> GetByHoiNghi(int idHoiNghi)
        {
            return BS_PRO_HoiNghiHoiThao_DangKy.get_PRO_HoiNghiHoiThao_DangKyTheoHoiNghi(db, QueryStrings, idHoiNghi);
        }

        [Route("get_PRO_HoiNghiHoiThaoChuaDangKy")]
        public IQueryable<DTO_PRO_HoiNghiHoiThao> GetChuaDangKy()
        {
            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            return BS_PRO_HoiNghiHoiThao_DangKy.get_PRO_HoiNghiHoiThao_ChuaDangKy(db, QueryStrings, user.StaffID);
        }

        [Route("get_PRO_HoiNghiHoiThaoDangKyDeTaiTheoHoiNghi/{idHoiNghi:int}")]
        public IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> GetDeTaiByHoiNghi(int idHoiNghi)
        {
            return BS_PRO_HoiNghiHoiThao_DangKyDeTai.get_PRO_HoiNghiHoiThao_DangKyDeTaiTheoHoiNghi(db, QueryStrings, idHoiNghi);
        }

        [Route("get_PRO_HoiNghiHoiThaoDangKyDeTaiTheoDangKy/{idDangKy:int}")]
        public IQueryable<DTO_PRO_HoiNghiHoiThao_DangKyDeTai> GetDeTaiByDangKy(int idDangKy)
        {
            return BS_PRO_HoiNghiHoiThao_DangKyDeTai.get_PRO_HoiNghiHoiThao_DangKyDeTaiTheoDangKy(db, QueryStrings, idDangKy);
        }

        [Route("{id:int}", Name = "get_PRO_HoiNghiHoiThaoDangKy")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKy))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_HoiNghiHoiThao_DangKy tbl_PRO_HoiNghiHoiThaoDangKy = BS_PRO_HoiNghiHoiThao_DangKy.get_PRO_HoiNghiHoiThao_DangKy(db, id);
            if (tbl_PRO_HoiNghiHoiThaoDangKy == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_HoiNghiHoiThaoDangKy);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_HoiNghiHoiThao_DangKy tbl_PRO_HoiNghiHoiThaoDangKy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_HoiNghiHoiThaoDangKy.ID)
            {
                return BadRequest();
            }

            bool res = BS_PRO_HoiNghiHoiThao_DangKy.put_PRO_HoiNghiHoiThao_DangKy(db, id, tbl_PRO_HoiNghiHoiThaoDangKy, Username);

            if (res)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKy))]
        public IHttpActionResult Post(DTO_PRO_HoiNghiHoiThao_DangKy tbl_PRO_HoiNghiHoiThaoDangKy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = UserManager.FindById(User.Identity.GetUserId());
            if (user.StaffID <= 0)
                return BadRequest("Chưa thiết lập nhân sự, không thể đăng ký");

            tbl_PRO_HoiNghiHoiThaoDangKy.IDNhanVien = user.StaffID;
            DTO_PRO_HoiNghiHoiThao_DangKy result = BS_PRO_HoiNghiHoiThao_DangKy.post_PRO_HoiNghiHoiThao_DangKyCustom(db, tbl_PRO_HoiNghiHoiThaoDangKy, Username);

            if (result != null)
            {
                if (!string.IsNullOrEmpty(result.Error))
                    return BadRequest(result.Error);

                return CreatedAtRoute("get_PRO_HoiNghiHoiThaoDangKy", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_HoiNghiHoiThao_DangKy))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_HoiNghiHoiThao_DangKy.check_PRO_HoiNghiHoiThao_DangKy_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_HoiNghiHoiThao_DangKy.delete_PRO_HoiNghiHoiThao_DangKy(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }

        
    }
}