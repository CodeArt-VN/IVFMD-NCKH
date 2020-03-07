import { APIListBase, appSetting } from '../CORE/api-list';
import { introAppData } from '../CORE/intro'


export var APIList:any = APIListBase;
APIList.FILE_Import={
  	NhanSu:{
		method: "GET",
		url: function(){return appSetting.apiDomain("CUS/FILE/NhanSu")}  
	},
};

APIList.FILE_Export = {
    BaoCaoTienDoNghienCuu: {
        method: "GET",
        url: function () { return appSetting.apiDomain("CUS/FILE/BaoCaoTienDoNghienCuu") }
    },
};



APIList.ACCOUNT_ApplicationUser={
	getList:{
		method: "GET",
		url: function(){return appSetting.apiDomain("Account/ApplicationUsers")}  
	},
	getItem:{
		method: "GET",
		url: function(id){return appSetting.apiDomain("Account/ApplicationUsers/") + id} 
	},
	putItem:{
		method: "PUT",
		url: function(id){return appSetting.apiDomain("Account/ApplicationUsers/") + id} 
	},
	postItem:{
		method: "POST",
		url: function(){return appSetting.apiDomain("Account/ApplicationUsers")}
	},
	delItem:{
		method: "DELETE",
		url: function(id){return appSetting.apiDomain("Account/ApplicationUsers/") + id} 
	},

	postChangePassword:{
		method: "POST",
		url: function(){return appSetting.apiDomain("Account/ChangePassword")}
	},
	postSetPassword:{
		method: "POST",
		url: function(){return appSetting.apiDomain("Account/SetPassword")}
	},

	

	
};
APIList.ManualAPI={
	getAvailbleDoctorTime:{
		method: "GET",
		url: function(){return appSetting.apiDomain("BOOK/Bookings/AvailbleDoctorTime")}  
	},
	getDonHangPhanTai:{
		method: "GET",
		url: function(){return appSetting.apiDomain("CUS/CRM/CONTRACT/DonHang/PhanTai")}  
	},

	getRPT_FileInFolder:{
		method: "GET",
		url: function(){return appSetting.apiDomain("CUS/DOC/File/RPT_FileInFolder")}  
	},

	getRPTFileByType:{
		method: "GET",
		url: function(){return appSetting.apiDomain("CUS/DOC/File/RPT_FileByType")}  
	},

};
APIList.ReportAPI={
	getDoanhThuTong:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/DoanhThuTong")}  
	},
	getDoanhThuTheoKhachTongHop:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/DoanhThuTheoKhachTongHop")}  
	},
	getDoanhThuTheoKhachKhoiLuongChiTiet:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/DoanhThuTheoKhachKhoiLuongChiTiet")}  
	},
	getTongHopGioHoatDong:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/TongHopGioHoatDong")}  
	},
	getBangKeThuChi:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/BangKeThuChi")}  
	},
	getBangKeChiPhiTheoNhanVien:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/BangKeChiPhiTheoNhanVien")}  
	},
	getBaoCaoChiPhiTheoLoai:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/BaoCaoChiPhiTheoLoai")}  
	},
	getBaoCaoNgayCong:{
		method: "GET",
		url: function(){return appSetting.apiDomain("RPT/BaoCaoNgayCong")}  
	},

	//Download files
	downloadDoanhThuTong:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/DoanhThuTong")}  
	},
	downloadDoanhThuTheoKhachTongHop:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/DoanhThuTheoKhachTongHop")}  
	},
	downloadDoanhThuTheoKhachKhoiLuongChiTiet:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/DoanhThuTheoKhachKhoiLuongChiTiet")}  
	},
	downloadTongHopGioHoatDong:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/TongHopGioHoatDong")}  
	},
	downloadBangKeThuChi:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/BangKeThuChi")}  
	},
	downloadBangKeChiPhiTheoNhanVien:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/BangKeChiPhiTheoNhanVien")}  
	},
	downloadBaoCaoChiPhiTheoLoai:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/BaoCaoChiPhiTheoLoai")}  
	},
	downloadBaoCaoNgayCong:{
		method: "GET",
		url: function(){return appSetting.apiDomain("FILE/RPT/BaoCaoNgayCong")}  
	},

};






export var GlobalData: any = {
    Filter: {
        FromDate: (new Date()).setDate(1),
        ToDate: new Date(),
        IDPartner: null,
    },
    IntroApp: introAppData,
    IsCordova: true,
    Token: {
        access_token: "",
        expires_in: 0,
        token_type: "",
        refresh_token: ""
    },
    Profile: {
        Id: '',
        UserName: "",
        Avatar: "",
        FirstName: "",
        LastName: "",
        Wallet: "",
        PhoneNumber: "",
        IsAgency: false,
        VipUser: false,
        Roles: [{ RoleId: 'GUEST' }],
        PatientID: 0,
        PartnerID: 0,
        StaffID: 0
    },
    WebData: {
        menu: [],
        pinPost: []
    },
    UserData: {
        MenuItem: [],
        Setting: {
            tablePageSize: 30,
            ToastMessageDelay: 5000,
        },
    },
    Params: {},
    Version: ''
};