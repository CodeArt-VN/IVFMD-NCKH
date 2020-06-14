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
    [RoutePrefix("api/PRO/BangKiemLuaChonQuyTrinhXXDD")]
    public class BangKiemLuaChonQuyTrinhXXDDController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_BangKiemLuaChonQuyTrinhXXDD> Get()
        {
            return BS_PRO_BangKiemLuaChonQuyTrinhXXDD.get_PRO_BangKiemLuaChonQuyTrinhXXDD(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_BangKiemLuaChonQuyTrinhXXDD")]
        [ResponseType(typeof(DTO_PRO_BangKiemLuaChonQuyTrinhXXDD))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_BangKiemLuaChonQuyTrinhXXDD tbl_PRO_BangKiemLuaChonQuyTrinhXXDD = BS_PRO_BangKiemLuaChonQuyTrinhXXDD.get_PRO_BangKiemLuaChonQuyTrinhXXDD(db, id);
            if (tbl_PRO_BangKiemLuaChonQuyTrinhXXDD == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_BangKiemLuaChonQuyTrinhXXDD);
        }

        [Route("get_PRO_BangKiemLuaChonQuyTrinhXXDD/{idDeTai:int}/{isInput?}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu_SYLL))]
        public IHttpActionResult GetCustom(int idDeTai, bool? isInput = false)
        {
            DTO_PRO_BangKiemLuaChonQuyTrinhXXDD tbl_PRO_BangKiemLuaChonQuyTrinhXXDD = BS_PRO_BangKiemLuaChonQuyTrinhXXDD.get_PRO_BangKiemLuaChonQuyTrinhXXDDCustom(db, idDeTai);
            //if (tbl_PRO_LLKH.ID == 0)
            //{
            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/BangKiemLuaChonQuyTrinhXXDD.html")))
            {
                html = r.ReadToEnd();
            }

            if (isInput == true)
            {
                using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/BangKiemLuaChonQuyTrinhXXDD_Input.html")))
                {
                    html = r.ReadToEnd();
                }
            }
            tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.HTML = html;
            //}

            return Ok(tbl_PRO_BangKiemLuaChonQuyTrinhXXDD);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_BangKiemLuaChonQuyTrinhXXDD tbl_PRO_BangKiemLuaChonQuyTrinhXXDD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_BangKiemLuaChonQuyTrinhXXDD.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_BangKiemLuaChonQuyTrinhXXDD.put_PRO_BangKiemLuaChonQuyTrinhXXDD(db, id, tbl_PRO_BangKiemLuaChonQuyTrinhXXDD, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_BangKiemLuaChonQuyTrinhXXDD))]
        public IHttpActionResult Post(DTO_PRO_BangKiemLuaChonQuyTrinhXXDD tbl_PRO_BangKiemLuaChonQuyTrinhXXDD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BangKiemLuaChonQuyTrinhXXDD result = BS_PRO_BangKiemLuaChonQuyTrinhXXDD.post_PRO_BangKiemLuaChonQuyTrinhXXDD(db, tbl_PRO_BangKiemLuaChonQuyTrinhXXDD, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_PRO_BangKiemLuaChonQuyTrinhXXDD", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_BangKiemLuaChonQuyTrinhXXDD))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_BangKiemLuaChonQuyTrinhXXDD.check_PRO_BangKiemLuaChonQuyTrinhXXDD_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_BangKiemLuaChonQuyTrinhXXDD.delete_PRO_BangKiemLuaChonQuyTrinhXXDD(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }

        [Route("save_PRO_BangKiemLuaChonQuyTrinhXXDD")]
        [ResponseType(typeof(DTO_PRO_BangKiemLuaChonQuyTrinhXXDD))]
        public IHttpActionResult Save(DTO_PRO_BangKiemLuaChonQuyTrinhXXDD tbl_PRO_BangKiemLuaChonQuyTrinhXXDD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BangKiemLuaChonQuyTrinhXXDD result = BS_PRO_BangKiemLuaChonQuyTrinhXXDD.save_PRO_BangKiemLuaChonQuyTrinhXXDD(db, tbl_PRO_BangKiemLuaChonQuyTrinhXXDD, Username);


            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}