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
using API.Models;

namespace API.Controllers.HRM
{

	[RoutePrefix("api/CUS/HRM/STAFF/NhanSu")]
    public class STAFF_NhanSuController : CustomApiController
    {
		[Route("")]
        public IQueryable<DTO_CUS_HRM_STAFF_NhanSu> Get()
        {
            var result = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, QueryStrings, false).ToList();
            if (result != null)
            {
                var context = new ApplicationDbContext();
                
                foreach (var item in result)
                {
                    if(! string.IsNullOrEmpty(item.Email))
                    {
                        var ac = context.Users.FirstOrDefault(d => d.Email == item.Email);
                        if (ac != null)
                        {
                            item.IsCreatedAccount = true;
                            item.IsLockedOut = ac.LockoutEnabled;
                            item.IsHostAccount = ac.Roles.Any(d => d.RoleId == "HOST");
                        }
                        
                    }
                    
                }
            }
            return result.AsQueryable();
        }

        [Route("NhanSuChuNhiem")]
        public IQueryable<DTO_CUS_HRM_STAFF_NhanSu> GetNhanSuChuNhiem()
        {
            var result = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, QueryStrings, true).ToList();
            return result.AsQueryable();
        }

        [Route("{id:int}", Name = "get_CUS_HRM_STAFF_NhanSu")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu))]
        public IHttpActionResult Get(int id)
        {
            DTO_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu = BS_CUS_HRM_STAFF_NhanSu.get_CUS_HRM_STAFF_NhanSu(db, PartnerID, id, true);
            if (tbl_CUS_HRM_STAFF_NhanSu == null)
            {
                return NotFound();
            }

            return Ok(tbl_CUS_HRM_STAFF_NhanSu);
        }

		[Route("{id:int}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DTO_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != tbl_CUS_HRM_STAFF_NhanSu.ID || PartnerID != tbl_CUS_HRM_STAFF_NhanSu.IDPartner)
                return BadRequest();
            

            bool resul = BS_CUS_HRM_STAFF_NhanSu.put_CUS_HRM_STAFF_NhanSu(db, PartnerID, id, tbl_CUS_HRM_STAFF_NhanSu, Username);

			if (resul)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();

        }

        [Route("")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu))]
        public IHttpActionResult Post(DTO_CUS_HRM_STAFF_NhanSu tbl_CUS_HRM_STAFF_NhanSu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DTO_CUS_HRM_STAFF_NhanSu result = BS_CUS_HRM_STAFF_NhanSu.post_CUS_HRM_STAFF_NhanSu(db, PartnerID, tbl_CUS_HRM_STAFF_NhanSu, Username);
			

			if (result!=null)
            {
                return CreatedAtRoute("get_CUS_HRM_STAFF_NhanSu", new { id = result.ID }, result);
            }
            return Conflict();

        }

        [Route("{id:int}")]
        [ResponseType(typeof(DTO_CUS_HRM_STAFF_NhanSu))]
        public IHttpActionResult Delete(int id)
        {
            bool check = BS_CUS_HRM_STAFF_NhanSu.check_CUS_HRM_STAFF_NhanSu_Exists(db, id); 
            if (!check)
            {
                return NotFound();
            }

            bool result = BS_CUS_HRM_STAFF_NhanSu.delete_CUS_HRM_STAFF_NhanSu(db, id, Username); 

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
	"name": "STAFF_NhanSu",
	"description": "",
	"item": [
		{
			"name": "CUS/HRM/STAFF/NhanSu",
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
				"url": "{{apidomain}}CUS/HRM/STAFF/NhanSu",
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
			"name": "CUS/HRM/STAFF/NhanSu/1",
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
				"url": "{{apidomain}}CUS/HRM/STAFF/NhanSu/1",
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
			"name": "CUS/HRM/STAFF/NhanSu/1",
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
				"url": "{{apidomain}}CUS/HRM/STAFF/NhanSu/1",
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
			"name": "CUS/HRM/STAFF/NhanSu",
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
				"url": "{{apidomain}}CUS/HRM/STAFF/NhanSu",
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
			"name": "CUS/HRM/STAFF/NhanSu/25",
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
				"url": "{{apidomain}}CUS/HRM/STAFF/NhanSu/25",
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