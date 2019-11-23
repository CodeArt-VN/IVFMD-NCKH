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
    [RoutePrefix("api/PRO/BaoCaoNangSuatKhoaHoc")]
    public class BaoCaoNangSuatKhoaHocController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> Get()
        {
            return BS_PRO_BaoCaoNangSuatKhoaHoc.get_PRO_BaoCaoNangSuatKhoaHocCustom(db, QueryStrings);
        }

        [Route("get_PRO_BaoCaoNangSuatKhoaHocByDeTai/{deTaiId:int}")]
        public IQueryable<DTO_PRO_BaoCaoNangSuatKhoaHoc> GetByDeTai(int deTaiId)
        {
            return BS_PRO_BaoCaoNangSuatKhoaHoc.get_PRO_BaoCaoNangSuatKhoaHocByDeTai(db, deTaiId, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_BaoCaoNangSuatKhoaHoc")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNangSuatKhoaHoc))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_BaoCaoNangSuatKhoaHoc tbl_PRO_BaoCaoNangSuatKhoaHoc = BS_PRO_BaoCaoNangSuatKhoaHoc.get_PRO_BaoCaoNangSuatKhoaHoc(db, id);
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

            bool result = BS_PRO_BaoCaoNangSuatKhoaHoc.put_PRO_BaoCaoNangSuatKhoaHoc(db, id, tbl_PRO_BaoCaoNangSuatKhoaHoc, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_BaoCaoNangSuatKhoaHoc))]
        public IHttpActionResult Post(DTO_PRO_BaoCaoNangSuatKhoaHoc tbl_PRO_BaoCaoNangSuatKhoaHoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_BaoCaoNangSuatKhoaHoc result = BS_PRO_BaoCaoNangSuatKhoaHoc.post_PRO_BaoCaoNangSuatKhoaHoc(db, tbl_PRO_BaoCaoNangSuatKhoaHoc, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_BaoCaoNangSuatKhoaHoc", new { id = result.ID }, result);
            }
            return Conflict();
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