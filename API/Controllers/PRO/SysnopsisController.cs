﻿using System;
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
    [RoutePrefix("api/PRO/Sysnopsis")]
    public class SysnopsisController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_PRO_Sysnopsis> Get()
        {
            return BS_PRO_Sysnopsis.get_PRO_Sysnopsis(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_PRO_Sysnopsis")]
        [ResponseType(typeof(DTO_PRO_Sysnopsis))]
        public IHttpActionResult Get(int id)
        {
            DTO_PRO_Sysnopsis tbl_PRO_Sysnopsis = BS_PRO_Sysnopsis.get_PRO_Sysnopsis(db, id);
            if (tbl_PRO_Sysnopsis == null)
            {
                return NotFound();
            }

            return Ok(tbl_PRO_Sysnopsis);
        }

        [Route("get_PRO_SysnopsisByDeTai/{idDeTai:int}/{isInput?}")]
        [ResponseType(typeof(DTO_PRO_Sysnopsis))]
        public IHttpActionResult GetCustom(int idDeTai, bool? isInput = false)
        {
            DTO_PRO_Sysnopsis tbl_PRO_Sysnopsis = BS_PRO_Sysnopsis.get_PRO_SysnopsisByDeTai(db, idDeTai);
            string html = "";
            string htmlPrint = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/Sysnopsis.html")))
            {
                htmlPrint = r.ReadToEnd();
            }
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/Content/FormTemplate/Sysnopsis_Input.html")))
            {
                html = r.ReadToEnd();
            }


            tbl_PRO_Sysnopsis.HTML = html;
            tbl_PRO_Sysnopsis.HTMLPrint = htmlPrint;


            return Ok(tbl_PRO_Sysnopsis);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_PRO_Sysnopsis tbl_PRO_Sysnopsis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_PRO_Sysnopsis.ID)
            {
                return BadRequest();
            }

            bool result = BS_PRO_Sysnopsis.put_PRO_Sysnopsis(db, id, tbl_PRO_Sysnopsis, Username);

            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_PRO_Sysnopsis))]
        public IHttpActionResult Post(DTO_PRO_Sysnopsis tbl_PRO_Sysnopsis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_PRO_Sysnopsis result = BS_PRO_Sysnopsis.post_PRO_Sysnopsis(db, tbl_PRO_Sysnopsis, Username);


            if (result != null)
            {
                return CreatedAtRoute("get_PRO_Sysnopsis", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_PRO_Sysnopsis))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_PRO_Sysnopsis.check_PRO_Sysnopsis_Exists(db, id);
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_PRO_Sysnopsis.delete_PRO_Sysnopsis(db, id, Username);

            if (result)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Conflict();
        }
    }
}