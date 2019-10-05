//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

export var appSetting = {
	mainService: {
        //base: "http://ivfmd.demo.codeart.vn/",
        base: "http://localhost:54009/",
		api: "api/",
	},
	apiDomain:function(api){
		return this.mainService.base + this.mainService.api + api;
	}
}

export var APIListBase = {
	ACCOUNT: {
		register: {
			method: "POST",
			url: appSetting.mainService.base + appSetting.mainService.api + "Account/Register"
		},
		registerFB: {
			method: "POST",
			url: appSetting.mainService.base + appSetting.mainService.api + "Account/RegisterExternal"
		},
		token: {
			method: "POST",
			url: appSetting.mainService.base + "token"
		},
		forgotPassword: {
			method: "POST",
			url: appSetting.mainService.base + appSetting.mainService.api + "Account/ForgotPassword"
		},
		getUserData: {
			method: "GET",
			url: appSetting.apiDomain("Account/UserInfo")
		},
		postUserData: {
			method: "POST",
			url: appSetting.mainService.base + appSetting.mainService.api + ""
		},
	},



	DOC_File:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/DOC/File")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/DOC/File")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/") + id} 
        }
		
	},

	DOC_File_Actitity:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/DOC/File/Actitity")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/Actitity/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/Actitity/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/DOC/File/Actitity")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/Actitity/") + id} 
        }
		
	},

	DOC_File_Permission:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/DOC/File/Permission")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/Permission/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/Permission/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/DOC/File/Permission")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/DOC/File/Permission/") + id} 
        }
		
	},

	DOC_FileInFolder:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/DOC/FileInFolder")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/DOC/FileInFolder/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/DOC/FileInFolder/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/DOC/FileInFolder")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/DOC/FileInFolder/") + id} 
        }
		
	},

	DOC_Folder:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/DOC/Folder")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/DOC/Folder")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/") + id} 
        }
		
	},

	DOC_Folder_Activity:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/DOC/Folder/Activity")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/Activity/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/Activity/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/DOC/Folder/Activity")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/Activity/") + id} 
        }
		
	},

	DOC_Folder_Permission:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/DOC/Folder/Permission")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/Permission/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/Permission/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/DOC/Folder/Permission")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/DOC/Folder/Permission/") + id} 
        }
		
	},

	HRM_LIST_BoPhan:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/HRM/LIST/BoPhan")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/HRM/LIST/BoPhan/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/HRM/LIST/BoPhan/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/HRM/LIST/BoPhan")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/HRM/LIST/BoPhan/") + id} 
        }
		
	},

	HRM_LIST_ChucDanh:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/HRM/LIST/ChucDanh")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/HRM/LIST/ChucDanh/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/HRM/LIST/ChucDanh/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/HRM/LIST/ChucDanh")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/HRM/LIST/ChucDanh/") + id} 
        }
		
	},

	HRM_STAFF_NhanSu:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/HRM/STAFF/NhanSu")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/HRM/STAFF/NhanSu/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/HRM/STAFF/NhanSu/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/HRM/STAFF/NhanSu")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/HRM/STAFF/NhanSu/") + id} 
        }
		
	},

	SYS_CauHinhHeThong:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/SYS/CauHinhHeThong")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/SYS/CauHinhHeThong/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/SYS/CauHinhHeThong/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/SYS/CauHinhHeThong")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/SYS/CauHinhHeThong/") + id} 
        }
		
	},

	SYS_PermissionList:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/SYS/PermissionList")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/SYS/PermissionList/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/SYS/PermissionList/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/SYS/PermissionList")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/SYS/PermissionList/") + id} 
        }
		
	},

	SYS_PermissionListDetailData:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/SYS/PermissionListDetailData")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/SYS/PermissionListDetailData/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/SYS/PermissionListDetailData/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/SYS/PermissionListDetailData")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/SYS/PermissionListDetailData/") + id} 
        }
		
	},

	SYS_Role:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/SYS/Role")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/SYS/Role/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/SYS/Role/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/SYS/Role")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/SYS/Role/") + id} 
        }
		
	},

	Version:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CUS/Version")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CUS/Version/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CUS/Version/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CUS/Version")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CUS/Version/") + id} 
        }
		
	},

	PAR_DonHang:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PAR/DonHang")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PAR/DonHang/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PAR/DonHang/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PAR/DonHang")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PAR/DonHang/") + id} 
        }
		
	},

	PAR_DonHang_ChiTiet:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PAR/DonHang/ChiTiet")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PAR/DonHang/ChiTiet/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PAR/DonHang/ChiTiet/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PAR/DonHang/ChiTiet")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PAR/DonHang/ChiTiet/") + id} 
        }
		
	},

	PAR_Partner:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PAR/Partner")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PAR/Partner/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PAR/Partner/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PAR/Partner")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PAR/Partner/") + id} 
        }
		
	},

	PAR_ThongTinSanPham:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PAR/ThongTinSanPham")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PAR/ThongTinSanPham/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PAR/ThongTinSanPham/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PAR/ThongTinSanPham")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PAR/ThongTinSanPham/") + id} 
        }
		
	},

	PROD_SanPham:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PROD/SanPham")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PROD/SanPham/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PROD/SanPham/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PROD/SanPham")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PROD/SanPham/") + id} 
        }
		
	},

	PROD_SanPham_ChiTiet:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PROD/SanPham/ChiTiet")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PROD/SanPham/ChiTiet/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PROD/SanPham/ChiTiet/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PROD/SanPham/ChiTiet")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PROD/SanPham/ChiTiet/") + id} 
        }
		
	},

	SYS_Apps:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("SYS/Apps")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("SYS/Apps/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("SYS/Apps/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("SYS/Apps")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("SYS/Apps/") + id} 
        }
		
	},

	SYS_Config:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("SYS/Config")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("SYS/Config/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("SYS/Config/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("SYS/Config")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("SYS/Config/") + id} 
        }
		
	},

	SYS_ControllerActions:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("SYS/ControllerActions")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("SYS/ControllerActions/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("SYS/ControllerActions/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("SYS/ControllerActions")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("SYS/ControllerActions/") + id} 
        }
		
	},

	SYS_Form:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("SYS/Form")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("SYS/Form/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("SYS/Form/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("SYS/Form")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("SYS/Form/") + id} 
        }
		
	},

	SYS_FormDetail:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("SYS/FormDetail")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("SYS/FormDetail/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("SYS/FormDetail/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("SYS/FormDetail")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("SYS/FormDetail/") + id} 
        }
		
	},

	SYS_FormGroup:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("SYS/FormGroup")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("SYS/FormGroup/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("SYS/FormGroup/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("SYS/FormGroup")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("SYS/FormGroup/") + id} 
        }
		
	},

	WEB_BaiViet:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("WEB/BaiViet")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("WEB/BaiViet")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/") + id} 
        }
		
	},

	WEB_BaiViet_DanhMuc:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("WEB/BaiViet/DanhMuc")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/DanhMuc/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/DanhMuc/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("WEB/BaiViet/DanhMuc")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/DanhMuc/") + id} 
        }
		
	},

	WEB_BaiViet_Tag:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("WEB/BaiViet/Tag")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/Tag/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/Tag/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("WEB/BaiViet/Tag")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("WEB/BaiViet/Tag/") + id} 
        }
		
	},

	WEB_DanhMuc:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("WEB/DanhMuc")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("WEB/DanhMuc/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("WEB/DanhMuc/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("WEB/DanhMuc")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("WEB/DanhMuc/") + id} 
        }
		
	},

	WEB_Tag:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("WEB/Tag")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("WEB/Tag/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("WEB/Tag/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("WEB/Tag")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("WEB/Tag/") + id} 
        }
		
	},

    CAT_Tags:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CAT/Tags")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CAT/Tags/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CAT/Tags/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CAT/Tags")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CAT/Tags/") + id} 
        }
		
    },
    
    CAT_Nhom:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CAT/Nhom")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CAT/Nhom/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CAT/Nhom/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CAT/Nhom")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CAT/Nhom/") + id} 
        }
		
    },
    
    CAT_Site:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("CAT/Site")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("CAT/Site/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("CAT/Site/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("CAT/Site")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("CAT/Site/") + id} 
        }
		
	},
};


