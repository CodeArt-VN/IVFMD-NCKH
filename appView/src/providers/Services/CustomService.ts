import { Injectable } from '@angular/core';
import { exService, PRO_NCVKhacProvider, PRO_BenhNhanProvider } from '../Services/Services';
import { CommonServiceProvider } from '../CORE/common-service';
import { APIList } from '../CORE/global-variable';
import { SearchConfig } from './SearchConfig';

@Injectable()
export class ACCOUNT_ApplicationUserProvider extends exService {
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.ACCOUNT_ApplicationUser, SearchConfig.getSearchFields('ACCOUNT_ApplicationUser'), commonService);
	}

	changePassword(oldPassword, newPassword, confirmPassword) {
		let that = this;
		let apiPath = APIList.ACCOUNT_ApplicationUser.postChangePassword;
		let data = {
			OldPassword: oldPassword,
			NewPassword: newPassword,
			ConfirmPassword: confirmPassword
		}
		return new Promise((resolve, reject) => {
			that.commonService.connect(apiPath.method, apiPath.url(), data).toPromise()
				.then(() => {
					resolve(true);
				}).catch(err => {
					reject(err);
				})
		});
	}
	resetPassword(userId, newPassword, confirmPassword) {
		let that = this;
		let apiPath = APIList.ACCOUNT_ApplicationUser.postSetPassword;
		let data = {
			UserId: userId,
			NewPassword: newPassword,
			ConfirmPassword: confirmPassword
		}
		return new Promise((resolve, reject) => {
			that.commonService.connect(apiPath.method, apiPath.url(), data).toPromise()
				.then(() => {
					resolve(true);
				}).catch(err => {
					reject(err);
				})
		});
	}

}

@Injectable()
export class ManualProvider {
	constructor(private commonService: CommonServiceProvider) { }

	getAvailbleDoctorTime(query) {
		let that = this.commonService;
		let apiPath = APIList.ManualAPI.getAvailbleDoctorTime;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});

	}
	getDonHangPhanTai(query) {
		let that = this.commonService;
		let apiPath = APIList.ManualAPI.getDonHangPhanTai;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});

	}

	GetRTPFileInFolder(query) {
		let that = this.commonService;
		let apiPath = APIList.ManualAPI.getRPT_FileInFolder;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}
	GetRPTFileByType(query) {
		let that = this.commonService;
		let apiPath = APIList.ManualAPI.getRPTFileByType;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

}

@Injectable()
export class ReportProvider {
	constructor(private commonService: CommonServiceProvider) { }

	getDoanhThuTong(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getDoanhThuTong;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

	getDoanhThuTheoKhachTongHop(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getDoanhThuTheoKhachTongHop;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

	getDoanhThuTheoKhachKhoiLuongChiTiet(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getDoanhThuTheoKhachKhoiLuongChiTiet;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

	getTongHopGioHoatDong(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getTongHopGioHoatDong;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

	getBangKeThuChi(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getBangKeThuChi;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

	getBangKeChiPhiTheoNhanVien(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getBangKeChiPhiTheoNhanVien;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

	getBaoCaoChiPhiTheoLoai(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getBaoCaoChiPhiTheoLoai;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}

	getBaoCaoNgayCong(query) {
		let that = this.commonService;
		let apiPath = APIList.ReportAPI.getBaoCaoNgayCong;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(), query).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}


}

@Injectable()
export class Sys_VarProvider extends exService{
	constructor(public commonService: CommonServiceProvider) {
		super(APIList.SYS_Var, SearchConfig.getSearchFields('SYS_Var'), commonService);
	}
	getByTypeOfVar(typeOfVar) {
		let that = this.commonService;
		let apiPath = APIList.SYS_Var.getListByTypeOfVar;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(typeOfVar), null).toPromise()
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

@Injectable()
export class PRO_SysnopsisCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_Sysnopsis, SearchConfig.getSearchFields('PRO_Sysnopsis'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_Sysnopsis.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
}

@Injectable()
export class PRO_NCVKhacCustomProvider extends PRO_NCVKhacProvider{
	constructor(public commonService: CommonServiceProvider) {
        super(commonService);
    }
	getByDeTai(deTaiId) {
		let that = this.commonService;
		let apiPath = APIList.PRO_NCVKhac.getListByDeTai;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(deTaiId), null).toPromise()
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

@Injectable()
export class PRO_BenhNhanCustomProvider extends PRO_BenhNhanProvider{
	constructor(public commonService: CommonServiceProvider) {
        super(commonService);
    }
	getByDeTai(deTaiId) {
		let that = this.commonService;
		let apiPath = APIList.PRO_BenhNhan.getListByDeTai;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(deTaiId), null).toPromise()
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
// @Injectable()
// export class HRM_LIST_ChucDanh_EX extends HRM_LIST_ChucDanhProvider {
//     constructor(public commonService: CommonServiceProvider) {
//         super(commonService);
//     }
//     getChucDanhTheoBoPhan(IDBoPhan) {
//         return new Promise(resolve => {
// 			this.read().then(()=>{
// 				var result = { count: 0, data: [] };
// 				var data = [];
// 				data = this.items.filter(ite => ite.IsDeleted === false && ite.IDBoPhan==IDBoPhan);

// 				result.count = data.length;
// 				result.data = data;
// 				resolve(result);
// 			});
// 		});
//     }
// }