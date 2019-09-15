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

namespace API.Controllers.HRM
{

	[RoutePrefix("api/CUS/HRM/LIST/ChucDanh")]
    public class LIST_ChucDanhController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_CUS_HRM_LIST_ChucDanh> Get()
        {
			return BS_CUS_HRM_LIST_ChucDanh.get_CUS_HRM_LIST_ChucDanh(db, PartnerID, QueryStrings);
        }

        [Route("{id:int}", Name = "get_CUS_HRM_LIST_ChucDanh")]
        [ResponseType(typeof(DTO_CUS_HRM_LIST_ChucDanh))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_HRM_LIST_ChucDanh tbl_CUS_HRM_LIST_ChucDanh = BS_CUS_HRM_LIST_ChucDanh.get_CUS_HRM_LIST_ChucDanh(db, PartnerID, id);
            if (tbl_CUS_HRM_LIST_ChucDanh == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_HRM_LIST_ChucDanh);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_HRM_LIST_ChucDanh tbl_CUS_HRM_LIST_ChucDanh)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_HRM_LIST_ChucDanh.ID || PartnerID != tbl_CUS_HRM_LIST_ChucDanh.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_HRM_LIST_ChucDanh.put_CUS_HRM_LIST_ChucDanh(db, PartnerID, id, tbl_CUS_HRM_LIST_ChucDanh, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_HRM_LIST_ChucDanh))]
        public IHttpActionResult Post(DTO_CUS_HRM_LIST_ChucDanh tbl_CUS_HRM_LIST_ChucDanh)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_HRM_LIST_ChucDanh result = BS_CUS_HRM_LIST_ChucDanh.post_CUS_HRM_LIST_ChucDanh(db, PartnerID, tbl_CUS_HRM_LIST_ChucDanh, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_HRM_LIST_ChucDanh", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_LIST_ChucDanh))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_HRM_LIST_ChucDanh.check_CUS_HRM_LIST_ChucDanh_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_HRM_LIST_ChucDanh.delete_CUS_HRM_LIST_ChucDanh(db, id, Username); 

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
	"name": "LIST_ChucDanh",
	"description": "",
	"item": [
		{
			"name": "CUS/HRM/LIST/ChucDanh",
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
				"url": "{{apidomain}}CUS/HRM/LIST/ChucDanh",
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
			"name": "CUS/HRM/LIST/ChucDanh/1",
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
				"url": "{{apidomain}}CUS/HRM/LIST/ChucDanh/1",
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
			"name": "CUS/HRM/LIST/ChucDanh/1",
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
				"url": "{{apidomain}}CUS/HRM/LIST/ChucDanh/1",
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
			"name": "CUS/HRM/LIST/ChucDanh",
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
				"url": "{{apidomain}}CUS/HRM/LIST/ChucDanh",
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
			"name": "CUS/HRM/LIST/ChucDanh/25",
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
				"url": "{{apidomain}}CUS/HRM/LIST/ChucDanh/25",
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