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

namespace API.Controllers.DOC
{

	[RoutePrefix("api/CUS/DOC/File/Actitity")]
    public class File_ActitityController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_CUS_DOC_File_Actitity> Get()
        {
            var result = BS_CUS_DOC_File_Actitity.get_CUS_DOC_File_Actitity(db, PartnerID, QueryStrings).ToList();
            if (result != null)
            {
                var context = new Models.ApplicationDbContext();
                var users = context.Users.ToList();

                foreach (var item in result)
                {
                    var u = users.FirstOrDefault(d => d.Email == item.CreatedBy);
                    if (u != null)
                    {
                        item.ModifiedByName = u.FullName;
                        item.Avatar = u.Avatar;
                    }
                }
            }

            return result.AsQueryable();
        }

        [Route("{id}", Name = "get_CUS_DOC_File_Actitity")]
        [ResponseType(typeof(DTO_CUS_DOC_File_Actitity))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_DOC_File_Actitity tbl_CUS_DOC_File_Actitity = BS_CUS_DOC_File_Actitity.get_CUS_DOC_File_Actitity(db, PartnerID, id);
            if (tbl_CUS_DOC_File_Actitity == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_DOC_File_Actitity);
        }

		[Route("{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_DOC_File_Actitity tbl_CUS_DOC_File_Actitity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_DOC_File_Actitity.ID || PartnerID != tbl_CUS_DOC_File_Actitity.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_DOC_File_Actitity.put_CUS_DOC_File_Actitity(db, PartnerID, id, tbl_CUS_DOC_File_Actitity, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_DOC_File_Actitity))]
        public IHttpActionResult Post(DTO_CUS_DOC_File_Actitity tbl_CUS_DOC_File_Actitity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_DOC_File_Actitity result = BS_CUS_DOC_File_Actitity.post_CUS_DOC_File_Actitity(db, PartnerID, tbl_CUS_DOC_File_Actitity, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_DOC_File_Actitity", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id}")]
        [ResponseType(typeof(DTO_CUS_DOC_File_Actitity))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_DOC_File_Actitity.check_CUS_DOC_File_Actitity_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_DOC_File_Actitity.delete_CUS_DOC_File_Actitity(db, id, Username); 

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
	"name": "File_Actitity",
	"description": "",
	"item": [
		{
			"name": "CUS/DOC/File/Actitity",
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
				"url": "{{apidomain}}CUS/DOC/File/Actitity",
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
			"name": "CUS/DOC/File/Actitity/1",
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
				"url": "{{apidomain}}CUS/DOC/File/Actitity/1",
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
			"name": "CUS/DOC/File/Actitity/1",
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
				"url": "{{apidomain}}CUS/DOC/File/Actitity/1",
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
			"name": "CUS/DOC/File/Actitity",
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
				"url": "{{apidomain}}CUS/DOC/File/Actitity",
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
			"name": "CUS/DOC/File/Actitity/25",
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
				"url": "{{apidomain}}CUS/DOC/File/Actitity/25",
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