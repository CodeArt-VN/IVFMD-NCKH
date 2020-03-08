import { Injectable } from '@angular/core';
import { exService, PRO_NCVKhacProvider, PRO_BenhNhanProvider, PRO_DeTaiProvider, PRO_BaoCaoNangSuatKhoaHocProvider, PRO_HoiNghiHoiThaoProvider, PRO_HoiNghiHoiThaoDangKyProvider } from '../Services/Services';
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
    getItemCustom(idDeTai, isReset?) {
        let that = this.commonService;
        let apiPath = APIList.PRO_Sysnopsis.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai, isReset), null).toPromise()
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
export class PRO_MauPhanTichDuLieuCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_MauPhanTichDuLieu, SearchConfig.getSearchFields('PRO_MauPhanTichDuLieu'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_MauPhanTichDuLieu.getItemCustom;
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
export class PRO_DonXinXetDuyetCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_DonXinXetDuyet, SearchConfig.getSearchFields('PRO_DonXinXetDuyet'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_DonXinXetDuyet.getItemCustom;
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
export class PRO_DonXinDanhGiaDaoDucCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_DonXinDanhGiaDaoDuc, SearchConfig.getSearchFields('PRO_DonXinDanhGiaDaoDuc'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_DonXinDanhGiaDaoDuc.getItemCustom;
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
export class PRO_BaoCaoTienDoNghienCuuCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_BaoCaoTienDoNghienCuu, SearchConfig.getSearchFields('PRO_BaoCaoTienDoNghienCuu'), commonService);
    }
    getListCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_BaoCaoTienDoNghienCuu.getListCustom;
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
    getListAll() {
        let that = this.commonService;
        let apiPath = APIList.PRO_BaoCaoTienDoNghienCuu.getListAll;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    getTheoDeTai(query=null) {
        let that = this.commonService;
        let apiPath = APIList.PRO_BaoCaoTienDoNghienCuu.getTheoDeTai;
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
export class PRO_DonXinNghiemThuCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_DonXinNghiemThu, SearchConfig.getSearchFields('PRO_DonXinNghiemThu'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_DonXinNghiemThu.getItemCustom;
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

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.PRO_BenhNhan.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class STAFF_NhanSu_LLKHProviderCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.STAFF_NhanSu_LLKH, SearchConfig.getSearchFields('STAFF_NhanSu_LLKH'), commonService);
    }
    getItemCustom(idNhanSu) {
        let that = this.commonService;
        let apiPath = APIList.STAFF_NhanSu_LLKH.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idNhanSu), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.STAFF_NhanSu_LLKH.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class PRO_LLKHCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_LLKH, SearchConfig.getSearchFields('PRO_LLKH'), commonService);
    }
    getItemCustom(idDeTai, idNhanSu) {
        let that = this.commonService;
        let apiPath = APIList.PRO_LLKH.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai, idNhanSu), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.PRO_LLKH.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class STAFF_NhanSu_SYLLProviderCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.STAFF_NhanSu_SYLL, SearchConfig.getSearchFields('STAFF_NhanSu_SYLL'), commonService);
    }
    getItemCustom(idNhanSu) {
        let that = this.commonService;
        let apiPath = APIList.STAFF_NhanSu_SYLL.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idNhanSu), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.STAFF_NhanSu_SYLL.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class PRO_SYLLCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_LLKH, SearchConfig.getSearchFields('PRO_LLKH'), commonService);
    }
    getItemCustom(idDeTai, idNhanSu, isChuNhiem) {
        let that = this.commonService;
        let apiPath = APIList.PRO_SYLL.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai, idNhanSu, isChuNhiem), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.PRO_SYLL.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class PRO_DeTaiCustomProvider extends PRO_DeTaiProvider{
	constructor(public commonService: CommonServiceProvider) {
        super(commonService);
    }
	getItemCustom(deTaiId) {
		let that = this.commonService;
		let apiPath = APIList.PRO_DeTai.getItemCustom;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(deTaiId), null).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
	}
	updateStatus(deTaiId, actionCode) {
		let that = this.commonService;
		let apiPath = APIList.PRO_DeTai.updateStatus;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(deTaiId, actionCode), null).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
				});
		});
    }
    updateNCT(deTaiId, soNCT) {
        let that = this.commonService;
        let apiPath = APIList.PRO_DeTai.updateNCT;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(deTaiId, soNCT), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}
	print(item) {
		let that = this.commonService;
        let apiPath = APIList.PRO_DeTai.print;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class PRO_HoiNghiHoiThaoCustomProvider extends PRO_HoiNghiHoiThaoProvider {
    constructor(public commonService: CommonServiceProvider) {
        super(commonService);
    }
    updateStatus(id, actionCode) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThao.updateStatus;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(id, actionCode), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    uploadAbstract(item) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThao.uploadAbstract;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), item).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    uploadFullText(item) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThao.uploadFullText;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), item).toPromise()
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
export class PRO_HoiNghiHoiThaoDangKyCustomProvider extends PRO_HoiNghiHoiThaoDangKyProvider {
    constructor(public commonService: CommonServiceProvider) {
        super(commonService);
    }
    updateStatus(id, actionCode) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThaoDangKy.updateStatus;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(id, actionCode), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    uploadAbstract(item) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThaoDangKy.uploadAbstract;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), item).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    uploadFullText(item) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThaoDangKy.uploadFullText;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), item).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    getListByHoiNghi(idHoiNghi) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThaoDangKy.getListByHoiNghi;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idHoiNghi), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    getListDeTaiByHoiNghi(idHoiNghi) {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThaoDangKy.getListDeTaiByHoiNghi;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idHoiNghi), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }
    getListChuaDangKy() {
        let that = this.commonService;
        let apiPath = APIList.PRO_HoiNghiHoiThaoDangKy.getListChuaDangKy;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), null).toPromise()
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
export class PRO_BaoCaoNangSuatKhoaHocCustomProvider extends PRO_BaoCaoNangSuatKhoaHocProvider {
    constructor(public commonService: CommonServiceProvider) {
        super(commonService);
    }
    updateStatus(id, actionCode) {
        let that = this.commonService;
        let apiPath = APIList.PRO_BaoCaoNangSuatKhoaHoc.updateStatus;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(id, actionCode), null).toPromise()
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
export class PRO_BangKiemXXDDCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_XemXetDD, SearchConfig.getSearchFields('PRO_XemXetDD'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_XemXetDD.getItemCustom;
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

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.PRO_XemXetDD.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class PRO_PhieuXemXetDaoDucCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_PhieuXemXetDaoDuc, SearchConfig.getSearchFields('PRO_PhieuXemXetDaoDuc'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_PhieuXemXetDaoDuc.getItemCustom;
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
export class PRO_AECustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_AE, SearchConfig.getSearchFields('PRO_AE'), commonService);
    }
    getItemCustom(idDeTai, idBenhNhan, id) {
        let that = this.commonService;
        let apiPath = APIList.PRO_AE.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai, idBenhNhan, id), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}
	getListByDeTai(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_AE.getListByDeTai;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai), null).toPromise()
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
export class PRO_SAECustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_SAE, SearchConfig.getSearchFields('PRO_SAE'), commonService);
    }
    getItemCustom(idDeTai, idBenhNhan, id) {
        let that = this.commonService;
        let apiPath = APIList.PRO_SAE.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai, idBenhNhan, id), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.PRO_SAE.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}

	getListByDeTai(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_SAE.getListByDeTai;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idDeTai), null).toPromise()
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
export class PRO_ThuyetMinhDeTaiCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.PRO_ThuyetMinhDeTai, SearchConfig.getSearchFields('PRO_ThuyetMinhDeTai'), commonService);
    }
    getItemCustom(idDeTai) {
        let that = this.commonService;
        let apiPath = APIList.PRO_ThuyetMinhDeTai.getItemCustom;
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
export class STAFF_NhanSu_HosremCustomProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.STAFF_NhanSu_Hosrem, SearchConfig.getSearchFields('STAFF_NhanSu_Hosrem'), commonService);
    }
    getItemCustom(idNhanSu) {
        let that = this.commonService;
        let apiPath = APIList.STAFF_NhanSu_Hosrem.getItemCustom;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(idNhanSu), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
	}

	saveCustom(item) {
		let that = this.commonService;
        let apiPath = APIList.STAFF_NhanSu_Hosrem.saveCustom;
		return new Promise((resolve, reject) => {
			that.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
}

@Injectable()
export class CAT_ThietLapThoiGianBaoCaoNSKHProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.CAT_ThietLapThoiGianBaoCaoNSKH, SearchConfig.getSearchFields('CAT_ThietLapThoiGianBaoCaoNSKH'), commonService);
    }
    get() {
        let that = this.commonService;
        let apiPath = APIList.CAT_ThietLapThoiGianBaoCaoNSKH.get;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }

    saveCustom(item) {
        let that = this.commonService;
        let apiPath = APIList.CAT_ThietLapThoiGianBaoCaoNSKH.postItem;
        return new Promise((resolve, reject) => {
            that.connect(apiPath.method, apiPath.url(), item).toPromise()
                .then((data) => {
                    resolve(data);
                }).catch(err => {
                    reject(err);
                })
        });
    }
}

@Injectable()
export class CAT_ThietLapThoiGianBaoCaoTDNCProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.CAT_ThietLapThoiGianBaoCaoTDNC, SearchConfig.getSearchFields('CAT_ThietLapThoiGianBaoCaoTDNC'), commonService);
    }
    get() {
        let that = this.commonService;
        let apiPath = APIList.CAT_ThietLapThoiGianBaoCaoTDNC.get;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }

    saveCustom(item) {
        let that = this.commonService;
        let apiPath = APIList.CAT_ThietLapThoiGianBaoCaoTDNC.postItem;
        return new Promise((resolve, reject) => {
            that.connect(apiPath.method, apiPath.url(), item).toPromise()
                .then((data) => {
                    resolve(data);
                }).catch(err => {
                    reject(err);
                })
        });
    }
}

@Injectable()
export class CAT_ThietLapTemplateProvider extends exService {
    constructor(public commonService: CommonServiceProvider) {
        super(APIList.CAT_ThietLapTemplate, SearchConfig.getSearchFields('CAT_ThietLapTemplate'), commonService);
    }
    get() {
        let that = this.commonService;
        let apiPath = APIList.CAT_ThietLapTemplate.get;
        return new Promise(function (resolve, reject) {
            that.connect(apiPath.method, apiPath.url(), null).toPromise()
                .then(data => {
                    resolve(data);
                })
                .catch(err => {
                    reject(err);
                });
        });
    }

    saveCustom(item) {
        let that = this.commonService;
        let apiPath = APIList.CAT_ThietLapTemplate.postItem;
        return new Promise((resolve, reject) => {
            that.connect(apiPath.method, apiPath.url(), item).toPromise()
                .then((data) => {
                    resolve(data);
                }).catch(err => {
                    reject(err);
                })
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