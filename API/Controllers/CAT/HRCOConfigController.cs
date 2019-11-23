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

namespace API.Controllers.CAT
{
    [RoutePrefix("api/CAT/HRCOConfig")]
    public class HRCOConfigController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_CAT_HRCOConfig> Get()
        {
            return BS_CAT_HRCOConfig.get_CAT_HRCOConfigCustom(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CAT_HRCOConfig")]
        [ResponseType(typeof(DTO_CAT_HRCOConfig))]
        public IHttpActionResult Get(int id)
        {
            DTO_CAT_HRCOConfig tbl_CAT_HRCOConfig = BS_CAT_HRCOConfig.get_CAT_HRCOConfig(db, id);
            if (tbl_CAT_HRCOConfig == null)
            {
                return NotFound();
            }

            return Ok(tbl_CAT_HRCOConfig);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CAT_HRCOConfig tbl_CAT_HRCOConfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_CAT_HRCOConfig.ID)
            {
                return BadRequest();
            }

            bool result = BS_CAT_HRCOConfig.put_CAT_HRCOConfig(db, id, tbl_CAT_HRCOConfig, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_CAT_HRCOConfig))]
        public IHttpActionResult Post(DTO_CAT_HRCOConfig tbl_CAT_HRCOConfig)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_CAT_HRCOConfig result = BS_CAT_HRCOConfig.post_CAT_HRCOConfig(db, tbl_CAT_HRCOConfig, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_CAT_HRCOConfig", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CAT_HRCOConfig))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CAT_HRCOConfig.check_CAT_HRCOConfig_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CAT_HRCOConfig.delete_CAT_HRCOConfig(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
    }
}