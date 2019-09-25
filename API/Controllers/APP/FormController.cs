//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

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

namespace API.Controllers.APP
{

	[RoutePrefix("api/SYS/Form")]
    public class FormController : CustomApiController
    {
		[Route("")]
        public List<DTO_APP_FormGroup> Get()
        {
			return BS_SYS_Form.get_SYS_Form(db, PartnerID, AppRole);
        }

        [Route("{id:int}", Name = "get_SYS_Form")]
        [ResponseType(typeof(DTO_SYS_Form))]
        public IHttpActionResult Get(int id)
        {
            DTO_SYS_Form tbl_SYS_Form = BS_SYS_Form.get_SYS_Form(db, id);
            if (tbl_SYS_Form == null)
            {
                return NotFound();
            }

            return Ok(tbl_SYS_Form);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_SYS_Form tbl_SYS_Form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_SYS_Form.ID)
                return BadRequest();
            

            bool resul = BS_SYS_Form.put_SYS_Form(db, id, tbl_SYS_Form, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_SYS_Form))]
        public IHttpActionResult Post(DTO_SYS_Form tbl_SYS_Form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_SYS_Form result = BS_SYS_Form.post_SYS_Form(db, tbl_SYS_Form, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_SYS_Form", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_SYS_Form))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_SYS_Form.check_SYS_Form_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_SYS_Form.delete_SYS_Form(db, id, Username); 

			if(result){
				return StatusCode(HttpStatusCode.NoContent);
			}
				return Conflict();

        }

    }
}


//API info
/*


{
	"name": "Form",
	"description": "",
	"item": [
		{
			"name": "SYS/Form",
			"event": [
				{
					"listen": "test",
					"script": {
						"type": "text/javascript",
						"exec": [
							"tests[\"Status code is 200\"] = responseCode.code === 200;"
						]
					}
				}
			],
			"request": {
				"url": "{{apidomain}}SYS/Form",
				"method": "GET",
				"header": [
					{
						"key": "PartnerID",
						"value": "{{partnerid}}",
						"description": "Gửi theo ID của Partner"
					},
					{
						"key": "Authorization",
						"value": "{{token_type}} {{token}}",
						"description": "Gửi kèm token"
					}
				],
				"body": {
					"mode": "raw",
					"raw": ""
				},
				"description": ""
			},
			"response": []
		},
		{
			"name": "SYS/Form/1",
			"event": [
				{
					"listen": "test",
					"script": {
						"type": "text/javascript",
						"exec": [
							"tests[\"Status code is 200\"] = responseCode.code === 200;",
							"",
							"if(responseCode.code === 200){",
							"    postman.setEnvironmentVariable(\"citem\", responseBody);",
							"}"
						]
					}
				}
			],
			"request": {
				"url": "{{apidomain}}SYS/Form/1",
				"method": "GET",
				"header": [
					{
						"key": "PartnerID",
						"value": "{{partnerid}}",
						"description": "Gửi theo ID của Partner"
					},
					{
						"key": "Authorization",
						"value": "{{token_type}} {{token}}",
						"description": "Gửi kèm token"
					}
				],
				"body": {
					"mode": "raw",
					"raw": ""
				},
				"description": ""
			},
			"response": []
		},
		{
			"name": "SYS/Form/1",
			"event": [
				{
					"listen": "test",
					"script": {
						"type": "text/javascript",
						"exec": [
							"tests[\"Status code is 204\"] = responseCode.code === 204;"
						]
					}
				}
			],
			"request": {
				"url": "{{apidomain}}SYS/Form/1",
				"method": "PUT",
				"header": [
					{
						"key": "PartnerID",
						"value": "{{partnerid}}",
						"description": "Gửi theo ID của Partner"
					},
					{
						"key": "Authorization",
						"value": "{{token_type}} {{token}}",
						"description": "Gửi kèm token"
					},
					{
						"key": "Content-Type",
						"value": "application/json",
						"description": ""
					}
				],
				"body": {
					"mode": "raw",
					"raw": "{{citem}}"
				},
				"description": ""
			},
			"response": []
		},
		{
			"name": "SYS/Form",
			"event": [
				{
					"listen": "test",
					"script": {
						"type": "text/javascript",
						"exec": [
							"tests[\"Status code is 201 - Created\"] = responseCode.code === 201;"
						]
					}
				}
			],
			"request": {
				"url": "{{apidomain}}SYS/Form",
				"method": "POST",
				"header": [
					{
						"key": "PartnerID",
						"value": "{{partnerid}}",
						"description": "Gửi theo ID của Partner"
					},
					{
						"key": "Authorization",
						"value": "{{token_type}} {{token}}",
						"description": "Gửi kèm token"
					},
					{
						"key": "Content-Type",
						"value": "application/json",
						"description": ""
					}
				],
				"body": {
					"mode": "raw",
					"raw": "{{citem}}"
				},
				"description": ""
			},
			"response": []
		},
		{
			"name": "SYS/Form/25",
			"event": [
				{
					"listen": "test",
					"script": {
						"type": "text/javascript",
						"exec": [
							"tests[\"Status code is 204\"] = responseCode.code === 204;"
						]
					}
				}
			],
			"request": {
				"url": "{{apidomain}}SYS/Form/25",
				"method": "DELETE",
				"header": [
					{
						"key": "PartnerID",
						"value": "{{partnerid}}",
						"description": "Gửi theo ID của Partner"
					},
					{
						"key": "Authorization",
						"value": "{{token_type}} {{token}}",
						"description": "Gửi kèm token"
					},
					{
						"key": "Content-Type",
						"value": "application/json",
						"description": ""
					}
				],
				"body": {
					"mode": "raw",
					"raw": ""
				},
				"description": ""
			},
			"response": []
		}
	],
	"_postman_isSubFolder": true
}



*/