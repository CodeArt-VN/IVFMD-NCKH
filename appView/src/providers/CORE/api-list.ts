//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

export var appSetting = {
	mainService: {
        //base: document.location.origin + "/",
        //base: "http://nckh.appcenter.vn/",
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

    File: {
        Download: {
            method: "GET",
            url: function (path) { return appSetting.apiDomain("CUS/File/Download/") + "?path=" + path }
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
        getListChuNhiem: {
            method: "GET",
            url: function () { return appSetting.apiDomain("CUS/HRM/STAFF/NhanSu/NhanSuChuNhiem") }
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

    CAT_KinhPhi: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("CAT/KinhPhi") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("CAT/KinhPhi/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("CAT/KinhPhi/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("CAT/KinhPhi") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("CAT/KinhPhi/") + id }
        }

    },

    CAT_BangGiaKinhPhi: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("CAT/BangGiaKinhPhi") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("CAT/BangGiaKinhPhi/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("CAT/BangGiaKinhPhi/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("CAT/BangGiaKinhPhi") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("CAT/BangGiaKinhPhi/") + id }
        }

    },

    CAT_ThietLapThoiGianBaoCaoNSKH: {
        get: {
            method: "GET",
            url: function () { return appSetting.apiDomain("CAT/ThietLapThoiGianBaoCaoNSKH") }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("CAT/ThietLapThoiGianBaoCaoNSKH") }
        },
    },

    CAT_ThietLapThoiGianBaoCaoTDNC: {
        get: {
            method: "GET",
            url: function () { return appSetting.apiDomain("CAT/ThietLapThoiGianBaoCaoTDNC") }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("CAT/ThietLapThoiGianBaoCaoTDNC") }
        },
    },

    CAT_ThietLapTemplate: {
        get: {
            method: "GET",
            url: function () { return appSetting.apiDomain("CAT/ThietLapTemplate") }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("CAT/ThietLapTemplate") }
        },
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
    
    PRO_DeTai:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PRO/DeTai")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PRO/DeTai/") + id} 
        },
        getItemCustom:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PRO/DeTai/get_PRO_DeTaiCustom/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PRO/DeTai/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/DeTai")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PRO/DeTai/") + id} 
        },
        updateStatus:{
            method: "POST",
            url: function(id, actionCode, typeId){return appSetting.apiDomain("PRO/DeTai/updateStatus_PRO_DeTai/") + id + "/" + actionCode + "/" + typeId} 
        },
        updateNCT: {
            method: "POST",
            url: function (id, soNCT) { return appSetting.apiDomain("PRO/DeTai/updateNCT_PRO_DeTai/") + id + "/" + soNCT }
        },
        updateMaSo: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/DeTai/updateMaSo_PRO_DeTai/") }
        },
        print: {
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/DeTai/print")}
        },
        uploadFile: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/DeTai/uploadFile/")}
        },
        uploadFileChapThuan: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/DeTai/uploadFileChapThuan/") }
        },
    },

    PRO_BaoCaoNangSuatKhoaHoc: {
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoNangSuatKhoaHoc/") + id }
        },
        getList: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoNangSuatKhoaHoc/")}
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoNangSuatKhoaHoc/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoNangSuatKhoaHoc") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoNangSuatKhoaHoc/") + id }
        },
        updateStatus: {
            method: "POST",
            url: function (id, actionCode) { return appSetting.apiDomain("PRO/BaoCaoNangSuatKhoaHoc/updateStatus_PRO_BaoCaoNangSuatKhoaHoc/") + id + "/" + actionCode }
        },
    },

    PRO_HoiNghiHoiThao: {
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThao/") + id }
        },
        getList: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThao/") }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThao/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/HoiNghiHoiThao") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThao/") + id }
        },
        updateStatus: {
            method: "POST",
            url: function (id, actionCode) { return appSetting.apiDomain("PRO/HoiNghiHoiThao/updateStatus_PRO_HoiNghiHoiThao/") + id + "/" + actionCode }
        },
        uploadAbstract: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/HoiNghiHoiThao/uploadAbstract_PRO_HoiNghiHoiThao/")}
        },
        uploadFullText: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/HoiNghiHoiThao/uploadFullText_PRO_HoiNghiHoiThao/")}
        },
    },

    PRO_HoiNghiHoiThaoDangKy: {
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/") + id }
        },
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/") }
        },
        getListByHoiNghi: {
            method: "GET",
            url: function (idHoiNghi) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/get_PRO_HoiNghiHoiThaoDangKyTheoHoiNghi/") + idHoiNghi }
        },
        getListChuaDangKy: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/get_PRO_HoiNghiHoiThaoChuaDangKy/") }
        },
        getListDeTaiByHoiNghi: {
            method: "GET",
            url: function (idHoiNghi) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/get_PRO_HoiNghiHoiThaoDangKyDeTaiTheoHoiNghi/") + idHoiNghi }
        },
        getListDeTaiByDangKy: {
            method: "GET",
            url: function (idDangKy) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/get_PRO_HoiNghiHoiThaoDangKyDeTaiTheoDangKy/") + idDangKy }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/") + id }
        },
        uploadAbstract: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/uploadAbstract_PRO_HoiNghiHoiThaoDangKy/") }
        },
        uploadFullText: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKy/uploadFullText_PRO_HoiNghiHoiThaoDangKy/") }
        },
    },

    PRO_HoiNghiHoiThaoDangKyDeTai: {
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai/") + id }
        },
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai/") }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai/") + id }
        },
        uploadAbstract: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai/uploadAbstract_PRO_HoiNghiHoiThaoDangKyDeTai/") }
        },
        uploadFullText: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai/uploadFullText_PRO_HoiNghiHoiThaoDangKyDeTai/") }
        },
        updateStatus: {
            method: "POST",
            url: function (id, actionCode) { return appSetting.apiDomain("PRO/HoiNghiHoiThaoDangKyDeTai/updateStatus_PRO_HoiNghiHoiThaoDangKyDeTai/") + id + "/" + actionCode }
        },
    },
    
    SYS_Var:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("SYS/Var")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("SYS/Var/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("SYS/Var/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("SYS/Var")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("SYS/Var/") + id} 
        },
		getListByTypeOfVar:{
            method: "GET",
            url: function(typeOfVar){return appSetting.apiDomain("SYS/Var/get_SYS_VarByTypeOfVar/") + typeOfVar}  
        }
    },

    PRO_Sysnopsis: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/Sysnopsis") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/Sysnopsis/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/Sysnopsis/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/Sysnopsis") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/Sysnopsis/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai, isReset?) { return appSetting.apiDomain("PRO/Sysnopsis/get_PRO_SysnopsisByDeTai/") + idDeTai + "/" + isReset }
        }
    },

    PRO_MauPhanTichDuLieu: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/MauPhanTichDuLieu") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/MauPhanTichDuLieu/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/MauPhanTichDuLieu/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/MauPhanTichDuLieu") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/MauPhanTichDuLieu/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/MauPhanTichDuLieu/get_PRO_MauPhanTichDuLieuByDeTai/") + idDeTai }
        }
    },

    PRO_DonXinXetDuyet: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/DonXinXetDuyet") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinXetDuyet/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinXetDuyet/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/DonXinXetDuyet") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinXetDuyet/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/DonXinXetDuyet/get_PRO_DonXinXetDuyetByDeTai/") + idDeTai }
        }
    },

    PRO_DonXinDanhGiaDaoDuc: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/DonXinDanhGiaDaoDuc") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinDanhGiaDaoDuc/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinDanhGiaDaoDuc/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/DonXinDanhGiaDaoDuc") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinDanhGiaDaoDuc/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/DonXinDanhGiaDaoDuc/get_PRO_DonXinDanhGiaDaoDucByDeTai/") + idDeTai }
        }
    },

    PRO_DonXinNghiemThu: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/DonXinNghiemThu") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinNghiemThu/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinNghiemThu/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/DonXinNghiemThu") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/DonXinNghiemThu/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/DonXinNghiemThu/get_PRO_DonXinNghiemThuByDeTai/") + idDeTai }
        }
    },

    PRO_BaoCaoTienDoNghienCuu: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu/") + id }
        },
        getListCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu/get_PRO_BaoCaoTienDoNghienCuuByDeTai/") + idDeTai }
        },
        getListAll: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu/get_PRO_BaoCaoTienDoNghienCuuAll") }
        },
        getTheoDeTai: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoTienDoNghienCuu/get_PRO_BaoCaoTienDoNghienCuuTheoDeTai") }
        }
    },

    PRO_NCVKhac:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PRO/NCVKhac")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PRO/NCVKhac/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PRO/NCVKhac/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/NCVKhac")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PRO/NCVKhac/") + id} 
        },
		getListByDeTai:{
            method: "GET",
            url: function(deTaiId){return appSetting.apiDomain("PRO/NCVKhac/get_PRO_NCVKhacByDeTai/") + deTaiId}  
        }
    },

    PRO_BenhNhan:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PRO/BenhNhan")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PRO/BenhNhan/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PRO/BenhNhan/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/BenhNhan")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PRO/BenhNhan/") + id} 
        },
		getListByDeTai:{
            method: "GET",
            url: function(deTaiId){return appSetting.apiDomain("PRO/BenhNhan/get_PRO_BenhNhanByDeTai/") + deTaiId}  
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/BenhNhan/save_PRO_BenhNhan")}
        },
    },

    HRM_BenhNhan:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("HRM/HRMBenhNhan")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("HRM/HRMBenhNhan/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("HRM/HRMBenhNhan/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("HRM/HRMBenhNhan")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("HRM/HRMBenhNhan/") + id} 
        }
		
    },

    STAFF_NhanSu_LLKH:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("HRM/STAFF_NhanSu_LLKH")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("HRM/STAFF_NhanSu_LLKH/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("HRM/STAFF_NhanSu_LLKH/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("HRM/STAFF_NhanSu_LLKH")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("HRM/STAFF_NhanSu_LLKH/") + id} 
        },
        getItemCustom: {
            method: "GET",
            url: function (idNhanSu) { return appSetting.apiDomain("HRM/STAFF_NhanSu_LLKH/get_CUS_HRM_STAFF_NhanSu_LLKH/") + idNhanSu }
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("HRM/STAFF_NhanSu_LLKH/save_CUS_HRM_STAFF_NhanSu_LLKH")}
        },
    },
    PRO_LLKH:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PRO/LLKH")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PRO/LLKH/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PRO/LLKH/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/LLKH")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PRO/LLKH/") + id} 
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai, idNhanSu) { return appSetting.apiDomain("PRO/LLKH/get_PRO_LLKH/") + idDeTai + "/" + idNhanSu }
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/LLKH/save_PRO_LLKH")}
        },
        update:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/LLKH/update_PRO_LLKH")}
        },
    },
    STAFF_NhanSu_SYLL:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("HRM/STAFF_NhanSu_SYLL")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("HRM/STAFF_NhanSu_SYLL/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("HRM/STAFF_NhanSu_SYLL/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("HRM/STAFF_NhanSu_SYLL")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("HRM/STAFF_NhanSu_SYLL/") + id} 
        },
        getItemCustom: {
            method: "GET",
            url: function (idNhanSu) { return appSetting.apiDomain("HRM/STAFF_NhanSu_SYLL/get_CUS_HRM_STAFF_NhanSu_SYLL/") + idNhanSu }
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("HRM/STAFF_NhanSu_SYLL/save_CUS_HRM_STAFF_NhanSu_SYLL")}
        },
    },
    PRO_SYLL:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PRO/SYLL")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PRO/SYLL/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PRO/SYLL/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/SYLL")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PRO/SYLL/") + id} 
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai, idNhanSu, isChuNhiem) { return appSetting.apiDomain("PRO/SYLL/get_PRO_SYLL/") + idDeTai + "/" + idNhanSu + "/" + isChuNhiem }
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/SYLL/save_PRO_SYLL")}
        },
        update:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/SYLL/update_PRO_SYLL")}
        },
    },
    PRO_XemXetDD:{
        getList:{
            method: "GET",
            url: function(){return appSetting.apiDomain("PRO/BangKiemLuaChonQuyTrinhXXDD")}  
        },
        getItem:{
            method: "GET",
            url: function(id){return appSetting.apiDomain("PRO/BangKiemLuaChonQuyTrinhXXDD/") + id} 
        },
        putItem:{
            method: "PUT",
            url: function(id){return appSetting.apiDomain("PRO/BangKiemLuaChonQuyTrinhXXDD/") + id} 
        },
        postItem:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/BangKiemLuaChonQuyTrinhXXDD")}
        },
        delItem:{
            method: "DELETE",
            url: function(id){return appSetting.apiDomain("PRO/BangKiemLuaChonQuyTrinhXXDD/") + id} 
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai, idNhanSu) { return appSetting.apiDomain("PRO/BangKiemLuaChonQuyTrinhXXDD/get_PRO_BangKiemLuaChonQuyTrinhXXDD/") + idDeTai }
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/BangKiemLuaChonQuyTrinhXXDD/save_PRO_BangKiemLuaChonQuyTrinhXXDD")}
        },
    },
    PRO_PhieuXemXetDaoDuc: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/PhieuXemXetDaoDuc") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/PhieuXemXetDaoDuc/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/PhieuXemXetDaoDuc/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/PhieuXemXetDaoDuc") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/PhieuXemXetDaoDuc/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/PhieuXemXetDaoDuc/get_PRO_PhieuXemXetDaoDuc/") + idDeTai }
        }
    },
    PRO_AE: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/AE") }
        },
        getListByDeTai: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/AE/get_PRO_AE_ByDeTai/") + idDeTai }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/AE/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/AE/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/AE") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/AE/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai, idBenhNhan, id) { return appSetting.apiDomain("PRO/AE/get_PRO_AE/") + idDeTai + "/" + idBenhNhan + "/" + id }
        }
    },
    PRO_SAE: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/SAE") }
        },
        getListByDeTai: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/SAE/get_PRO_SAE_ByDeTai/") + idDeTai }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/SAE/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/SAE/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/SAE") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/SAE/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai, idBenhNhan, id) { return appSetting.apiDomain("PRO/SAE/get_PRO_SAE/") + idDeTai + "/" + idBenhNhan + "/" + id}
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("PRO/SAE/save_PRO_SAE")}
        },
    },
    PRO_BaoCaoNghiemThuDeTai: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai/get_PRO_BaoCaoNghiemThuDeTai/") + idDeTai  }
        },
        saveCustom: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai/save_PRO_BaoCaoNghiemThuDeTai") }
        },
        uploadFullText: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai/uploadFullText_PRO_BaoCaoNghiemThuDeTai/") }
        },
        uploadFileBaoCaoTongHop: {
            method: "POST",
            url: function (id, path) { return appSetting.apiDomain("PRO/BaoCaoNghiemThuDeTai/uploadFileBaoCaoTongHop_PRO_BaoCaoNghiemThuDeTai/") }
        },
    },
    PRO_ThuyetMinhDeTai: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/ThuyetMinhDeTai") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/ThuyetMinhDeTai/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/ThuyetMinhDeTai/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/ThuyetMinhDeTai") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/ThuyetMinhDeTai/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/ThuyetMinhDeTai/get_PRO_ThuyetMinhDeTaiByDeTai/") + idDeTai }
        }
    },
    PRO_BangKhaiNhanSu: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("PRO/BangKhaiNhanSu") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("PRO/BangKhaiNhanSu/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("PRO/BangKhaiNhanSu/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/BangKhaiNhanSu") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("PRO/BangKhaiNhanSu/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idDeTai) { return appSetting.apiDomain("PRO/BangKhaiNhanSu/get_PRO_BangKhaiNhanSu/") + idDeTai }
        },
        refreshItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("PRO/BangKhaiNhanSu/refresh_PRO_BangKhaiNhanSu/") }
        },
    },
    STAFF_NhanSu_Hosrem: {
        getList: {
            method: "GET",
            url: function () { return appSetting.apiDomain("HRM/STAFF_NhanSu_Hosrem") }
        },
        getItem: {
            method: "GET",
            url: function (id) { return appSetting.apiDomain("HRM/STAFF_NhanSu_Hosrem/") + id }
        },
        putItem: {
            method: "PUT",
            url: function (id) { return appSetting.apiDomain("HRM/STAFF_NhanSu_Hosrem/") + id }
        },
        postItem: {
            method: "POST",
            url: function () { return appSetting.apiDomain("HRM/STAFF_NhanSu_Hosrem") }
        },
        delItem: {
            method: "DELETE",
            url: function (id) { return appSetting.apiDomain("HRM/STAFF_NhanSu_Hosrem/") + id }
        },
        getItemCustom: {
            method: "GET",
            url: function (idNhanSu) { return appSetting.apiDomain("HRM/STAFF_NhanSu_Hosrem/get_CUS_HRM_STAFF_NhanSu_HOSREM/") + idNhanSu }
        },
        saveCustom:{
            method: "POST",
            url: function(){return appSetting.apiDomain("HRM/STAFF_NhanSu_Hosrem/save_CUS_HRM_STAFF_NhanSu_HOSREM")}
        },
    }
};


