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

namespace API.Controllers.CAT
{
    [RoutePrefix("api/CAT/ThietLapThoiGianBaoCaoNSKH")]
    public class ThietLapThoiGianBaoCaoNSKHController : CustomApiController
    {
        [Route("")]
        [ResponseType(typeof(DTO_SYS_Config))]
        public IHttpActionResult Get()
        {
            DTO_SYS_Config tbl_SYS_Config = BS_SYS_Config.get_SYS_Config_ThoiGianBaoCaoNSKH(db);
            if (tbl_SYS_Config == null)
            {
                return NotFound();
            }

            return Ok(tbl_SYS_Config);
        }

        [Route("")]
        [ResponseType(typeof(DTO_SYS_Config))]
        public IHttpActionResult Post(DTO_SYS_Config tbl_SYS_Config)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_SYS_Config result = BS_SYS_Config.post_SYS_Config_ThoiGianBaoCaoNSKH(db, tbl_SYS_Config, Username);

            return Ok(result);
        }
    }
}