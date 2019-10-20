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

namespace API.Controllers.SYS
{
    [RoutePrefix("api/SYS/Var")]
    public class VarController : CustomApiController
    {
        [Route("")]
        public IQueryable<DTO_SYS_Var> Get()
        {
            return BS_SYS_Var.get_SYS_Var(db, QueryStrings);
        }

        [Route("{id:int}", Name = "get_SYS_Var")]
        [ResponseType(typeof(DTO_SYS_Var))]
        public IHttpActionResult Get(int id)
        {
            DTO_SYS_Var tbl_SYS_Var = BS_SYS_Var.get_SYS_Var(db, id);
            if (tbl_SYS_Var == null)
            {
                return NotFound();
            }

            return Ok(tbl_SYS_Var);
        }

        [Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_SYS_Var tbl_SYS_Var)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_SYS_Var.ID)
            {
                return BadRequest();
            }

            bool result = BS_SYS_Var.put_SYS_Var(db, id, tbl_SYS_Var, Username);
            
            if (result)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        [Route("")]
        [ResponseType(typeof(DTO_SYS_Var))]
        public IHttpActionResult Post(DTO_SYS_Var tbl_SYS_Var)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DTO_SYS_Var result = BS_SYS_Var.post_SYS_Var(db, tbl_SYS_Var, Username);
			

			if (result != null)
            {
                return CreatedAtRoute("get_SYS_Var", new { id = result.ID }, result);
            }
            return Conflict();
        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_SYS_Var))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_SYS_Var.check_SYS_Var_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_SYS_Var.delete_SYS_Var(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
            return Conflict();
        }
        
        [Route("get_SYS_VarByTypeOfVar/{typeOfVar:int}")]
        public IQueryable<DTO_SYS_Var> GetByTypeOfVar(int typeOfVar)
        {
            return BS_SYS_Var.get_SYS_VarByType(db, typeOfVar);
        }
    }
}