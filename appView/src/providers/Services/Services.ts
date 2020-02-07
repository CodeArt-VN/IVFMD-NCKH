//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

import { Injectable } from '@angular/core';
import { APIList } from '../CORE/global-variable';
import { CommonServiceProvider } from '../CORE/common-service';
import { SearchConfig } from '../Services/SearchConfig';


@Injectable()
export class exService {

	apiPath: any;
	searchField = [];
	allowCache = true;
	serviceName = '';
	commonService: CommonServiceProvider;

	constructor(apiPath: any, searchField, commonService: CommonServiceProvider) {
		this.apiPath = apiPath;
		this.serviceName = searchField.name;
		this.searchField = searchField.value.filelds;
		this.allowCache = searchField.value.cache;
		this.commonService = commonService;
	}

	getAnItem(ID, UID: string = '') {
		if (this.allowCache) {
			return this.commonService.getAnItemLocal(ID, UID, this.apiPath.getList);
		}
		else {
			return this.commonService.getAnItemOnServer(ID, UID, this.apiPath.getItem);
		}

	}

	read(query = null) {
		if(this.allowCache){
			return this.commonService.connectLocal(this.apiPath.getList, query, this.searchField);
		}
		else{
			//connect server
			var that = this;
			return new Promise(function (resolve, reject) {
				let apiPath = that.apiPath.getList;
				that.commonService.connect(apiPath.method, apiPath.url(), query).toPromise()
					.then(data => {
						var result = { count: data.length, data: data };
						resolve(result);
					})
					.catch(err => {
						reject(err);
					});
			});
		}
	}

	save(item) {
		return this.commonService.save(item, this.apiPath);
	}

	delete(item) {
		return this.commonService.delete(item, this.apiPath);
	}
}


@Injectable()
export class DOC_FileProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.DOC_File, SearchConfig.getSearchFields('DOC_File'), commonService);
	}
}

@Injectable()
export class DOC_File_ActitityProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.DOC_File_Actitity, SearchConfig.getSearchFields('DOC_File_Actitity'), commonService);
	}
}

@Injectable()
export class DOC_File_PermissionProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.DOC_File_Permission, SearchConfig.getSearchFields('DOC_File_Permission'), commonService);
	}
}

@Injectable()
export class DOC_FileInFolderProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.DOC_FileInFolder, SearchConfig.getSearchFields('DOC_FileInFolder'), commonService);
	}
}

@Injectable()
export class DOC_FolderProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.DOC_Folder, SearchConfig.getSearchFields('DOC_Folder'), commonService);
	}
}

@Injectable()
export class DOC_Folder_ActivityProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.DOC_Folder_Activity, SearchConfig.getSearchFields('DOC_Folder_Activity'), commonService);
	}
}

@Injectable()
export class DOC_Folder_PermissionProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.DOC_Folder_Permission, SearchConfig.getSearchFields('DOC_Folder_Permission'), commonService);
	}
}

@Injectable()
export class HRM_LIST_BoPhanProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.HRM_LIST_BoPhan, SearchConfig.getSearchFields('HRM_LIST_BoPhan'), commonService);
	}
}

@Injectable()
export class HRM_LIST_ChucDanhProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.HRM_LIST_ChucDanh, SearchConfig.getSearchFields('HRM_LIST_ChucDanh'), commonService);
	}
}

@Injectable()
export class HRM_STAFF_NhanSuProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.HRM_STAFF_NhanSu, SearchConfig.getSearchFields('HRM_STAFF_NhanSu'), commonService);
	}
}

@Injectable()
export class SYS_CauHinhHeThongProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_CauHinhHeThong, SearchConfig.getSearchFields('SYS_CauHinhHeThong'), commonService);
	}
}

@Injectable()
export class SYS_PermissionListProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_PermissionList, SearchConfig.getSearchFields('SYS_PermissionList'), commonService);
	}
}

@Injectable()
export class SYS_PermissionListDetailDataProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_PermissionListDetailData, SearchConfig.getSearchFields('SYS_PermissionListDetailData'), commonService);
	}
}

@Injectable()
export class SYS_RoleProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_Role, SearchConfig.getSearchFields('SYS_Role'), commonService);
	}
}

@Injectable()
export class VersionProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.Version, SearchConfig.getSearchFields('Version'), commonService);
	}
}

@Injectable()
export class PAR_DonHangProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PAR_DonHang, SearchConfig.getSearchFields('PAR_DonHang'), commonService);
	}
}

@Injectable()
export class PAR_DonHang_ChiTietProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PAR_DonHang_ChiTiet, SearchConfig.getSearchFields('PAR_DonHang_ChiTiet'), commonService);
	}
}

@Injectable()
export class PAR_PartnerProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PAR_Partner, SearchConfig.getSearchFields('PAR_Partner'), commonService);
	}
}

@Injectable()
export class PAR_ThongTinSanPhamProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PAR_ThongTinSanPham, SearchConfig.getSearchFields('PAR_ThongTinSanPham'), commonService);
	}
}

@Injectable()
export class PROD_SanPhamProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PROD_SanPham, SearchConfig.getSearchFields('PROD_SanPham'), commonService);
	}
}

@Injectable()
export class PROD_SanPham_ChiTietProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PROD_SanPham_ChiTiet, SearchConfig.getSearchFields('PROD_SanPham_ChiTiet'), commonService);
	}
}

@Injectable()
export class SYS_AppsProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_Apps, SearchConfig.getSearchFields('SYS_Apps'), commonService);
	}
}

@Injectable()
export class SYS_ConfigProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_Config, SearchConfig.getSearchFields('SYS_Config'), commonService);
	}
}

@Injectable()
export class SYS_ControllerActionsProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_ControllerActions, SearchConfig.getSearchFields('SYS_ControllerActions'), commonService);
	}
}

@Injectable()
export class SYS_FormProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_Form, SearchConfig.getSearchFields('SYS_Form'), commonService);
	}
}

@Injectable()
export class SYS_FormDetailProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_FormDetail, SearchConfig.getSearchFields('SYS_FormDetail'), commonService);
	}
}

@Injectable()
export class SYS_FormGroupProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_FormGroup, SearchConfig.getSearchFields('SYS_FormGroup'), commonService);
	}
}

@Injectable()
export class WEB_BaiVietProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.WEB_BaiViet, SearchConfig.getSearchFields('WEB_BaiViet'), commonService);
	}
}

@Injectable()
export class WEB_BaiViet_DanhMucProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.WEB_BaiViet_DanhMuc, SearchConfig.getSearchFields('WEB_BaiViet_DanhMuc'), commonService);
	}
}

@Injectable()
export class WEB_BaiViet_TagProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.WEB_BaiViet_Tag, SearchConfig.getSearchFields('WEB_BaiViet_Tag'), commonService);
	}
}

@Injectable()
export class WEB_DanhMucProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.WEB_DanhMuc, SearchConfig.getSearchFields('WEB_DanhMuc'), commonService);
	}
}

@Injectable()
export class WEB_TagProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.WEB_Tag, SearchConfig.getSearchFields('WEB_Tag'), commonService);
	}
}

@Injectable()
export class CAT_TagsProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.CAT_Tags, SearchConfig.getSearchFields('CAT_Tags'), commonService);
	}
}

@Injectable()
export class CAT_NhomProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.CAT_Nhom, SearchConfig.getSearchFields('CAT_Nhom'), commonService);
	}
}

@Injectable()
export class CAT_KinhPhiProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.CAT_KinhPhi, SearchConfig.getSearchFields('CAT_KinhPhi'), commonService);
    }
}

@Injectable()
export class CAT_BangGiaKinhPhiProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.CAT_BangGiaKinhPhi, SearchConfig.getSearchFields('CAT_BangGiaKinhPhi'), commonService);
    }
}

@Injectable()
export class CAT_SiteProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.CAT_Site, SearchConfig.getSearchFields('CAT_Site'), commonService);
	}
}

@Injectable()
export class PRO_DeTaiProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_DeTai, SearchConfig.getSearchFields('PRO_DeTai'), commonService);
	}
}

@Injectable()
export class PRO_NCVKhacProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_NCVKhac, SearchConfig.getSearchFields('PRO_NCVKhac'), commonService);
	}
}

@Injectable()
export class PRO_BenhNhanProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_BenhNhan, SearchConfig.getSearchFields('PRO_BenhNhan'), commonService);
	}
}

@Injectable()
export class HRM_BenhNhanProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.HRM_BenhNhan, SearchConfig.getSearchFields('HRM_BenhNhan'), commonService);
	}
}

@Injectable()
export class STAFF_NhanSu_LLKHProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.STAFF_NhanSu_LLKH, SearchConfig.getSearchFields('STAFF_NhanSu_LLKH'), commonService);
	}
}

@Injectable()
export class PRO_LLKHProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_LLKH, SearchConfig.getSearchFields('PRO_LLKH'), commonService);
	}
}

@Injectable()
export class STAFF_NhanSu_SYLLProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.STAFF_NhanSu_SYLL, SearchConfig.getSearchFields('STAFF_NhanSu_SYLL'), commonService);
	}
}

@Injectable()
export class PRO_SYLLProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_SYLL, SearchConfig.getSearchFields('PRO_SYLL'), commonService);
	}
}

@Injectable()
export class PRO_BangKiemXXDDProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_BangKiemXXDD, SearchConfig.getSearchFields('PRO_BangKiemXXDD'), commonService);
	}
}
@Injectable()
export class PRO_PhieuXemXetDaoDuc extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_PhieuXemXetDaoDuc, SearchConfig.getSearchFields('PRO_PhieuXemXetDaoDuc'), commonService);
	}
}
@Injectable()
export class PRO_AE extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_AE, SearchConfig.getSearchFields('PRO_AE'), commonService);
	}
}
@Injectable()
export class PRO_SAE extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_SAE, SearchConfig.getSearchFields('PRO_SAE'), commonService);
	}
}
@Injectable()
export class PRO_BaoCaoNangSuatKhoaHocProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_BaoCaoNangSuatKhoaHoc, SearchConfig.getSearchFields('PRO_BaoCaoNangSuatKhoaHoc'), commonService);
    }
}

@Injectable()
export class PRO_HoiNghiHoiThaoProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_HoiNghiHoiThao, SearchConfig.getSearchFields('PRO_HoiNghiHoiThao'), commonService);
    }
}

@Injectable()
export class PRO_ThuyetMinhDeTai extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.PRO_ThuyetMinhDeTai, SearchConfig.getSearchFields('PRO_ThuyetMinhDeTai'), commonService);
	}
}

@Injectable()
export class STAFF_NhanSu_HosremProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.STAFF_NhanSu_Hosrem, SearchConfig.getSearchFields('STAFF_NhanSu_Hosrem'), commonService);
	}
}
//import { DOC_FileProvider, DOC_File_ActitityProvider, DOC_File_PermissionProvider, DOC_FileInFolderProvider, DOC_FolderProvider, DOC_Folder_ActivityProvider, DOC_Folder_PermissionProvider, HRM_LIST_BoPhanProvider, HRM_LIST_ChucDanhProvider, HRM_STAFF_NhanSuProvider, SYS_CauHinhHeThongProvider, SYS_PermissionListProvider, SYS_PermissionListDetailDataProvider, SYS_RoleProvider, VersionProvider, PAR_DonHangProvider, PAR_DonHang_ChiTietProvider, PAR_PartnerProvider, PAR_ThongTinSanPhamProvider, PROD_SanPhamProvider, PROD_SanPham_ChiTietProvider, SYS_AppsProvider, SYS_ConfigProvider, SYS_ControllerActionsProvider, SYS_FormProvider, SYS_FormDetailProvider, SYS_FormGroupProvider, WEB_BaiVietProvider, WEB_BaiViet_DanhMucProvider, WEB_BaiViet_TagProvider, WEB_DanhMucProvider, WEB_TagProvider, } from '../providers/Services/Services';




