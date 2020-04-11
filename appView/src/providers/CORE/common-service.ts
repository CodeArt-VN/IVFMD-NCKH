import { Injectable } from '@angular/core';
import { Headers, RequestOptions, Http } from '@angular/http';
import { ToastController } from 'ionic-angular';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/toPromise';
import { Storage } from '@ionic/storage';
import { GlobalData } from '../CORE/global-variable'
import { APIListBase } from './api-list';

@Injectable()
export class CommonServiceProvider {
    constructor(private http: Http, public storage: Storage, public toastCtrl: ToastController,) {
	}

	connect(pmethod, URL, data) {
		let headers = new Headers({
			'Authorization': this.getToken(),
			'Content-Type': 'application/json',
			'Data-type': 'json',
			'withCredentials': true
		});
		let options = new RequestOptions({ headers: headers, withCredentials: true });

		if (GlobalData.Profile
			&& GlobalData.Profile.Roles
			&& GlobalData.Profile.Roles.SYSRoles
			&& GlobalData.Profile.Roles.SYSRoles.indexOf('HOST') > -1
			&& GlobalData.Filter.IDPartner) {
			URL =  URL + (URL.indexOf('?')>-1? '&' : '?')+ 'IDPartner=' + GlobalData.Filter.IDPartner;
        }

        if (pmethod == "GET") {
            options.search = data;
            //return this.http.get(URL, options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch(this.handleError);
            return this.http.get(URL, options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch((error: any) => {
                if (error.status == 0) {
                    return Promise.reject('Can not connect to API server!');
                } else {
                    var msg = JSON.parse(error._body);
                    if (msg && msg.Message) {
                        let toast = this.toastCtrl.create({
                            message: msg.Message,
                            duration: 3000
                        });
                        toast.present();
                        return Promise.reject(msg.Message);
                    }
                    return Promise.reject(error.message || error);
                }
            });
        }
        else if (pmethod == "POST") {
            //return this.http.post(URL, JSON.stringify(data), options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch(this.handleError);
            return this.http.post(URL, JSON.stringify(data), options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch((error: any) => {
                if (error.status == 0) {
                    return Promise.reject('Can not connect to API server!');
                } else {
                    var msg = JSON.parse(error._body);
                    if (msg && msg.Message) {
                        let toast = this.toastCtrl.create({
                            message: msg.Message,
                            duration: 3000
                        });
                        toast.present();
                        return Promise.reject(msg.Message);
                    }
                    return Promise.reject(error.message || error);
                }
            });
        }
        else if (pmethod == "PUT") {
            //return this.http.put(URL, data, options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch(this.handleError);
            return this.http.put(URL, JSON.stringify(data), options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch((error: any) => {
                if (error.status == 0) {
                    return Promise.reject('Can not connect to API server!');
                } else {
                    var msg = JSON.parse(error._body);
                    if (msg && msg.Message) {
                        let toast = this.toastCtrl.create({
                            message: msg.Message,
                            duration: 3000
                        });
                        toast.present();
                        return Promise.reject(msg.Message);
                    }
                    return Promise.reject(error.message || error);
                }
            });
        }
        else if (pmethod == "DELETE") {
            //return this.http.delete(URL, options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch(this.handleError);
            return this.http.delete(URL, options).map((res: any) => { return res._body == "" ? res : res.json(); }).catch((error: any) => {
                if (error.status == 0) {
                    return Promise.reject('Can not connect to API server!');
                } else {
                    var msg = JSON.parse(error._body);
                    if (msg && msg.Message) {
                        let toast = this.toastCtrl.create({
                            message: msg.Message,
                            duration: 3000
                        });
                        toast.present();
                        return Promise.reject(msg.Message);
                    }
                    return Promise.reject(error.message || error);
                }
            });
		}
		else if (pmethod == "UPLOAD") {
			headers = new Headers({
				'Authorization': this.getToken(),
				'withCredentials': true
			});
			options = new RequestOptions({ headers: headers, withCredentials: true });

			return this.http.post(URL, data, options).map(res => res).catch(this.handleError);
		}
		else if (pmethod == "DOWNLOAD") {
			options.search = data;
			return this.http.get(URL, options).map(res => res).catch(this.handleError);
		}
	}

	connectLocal(apiPath, query, fields) {
		//apiPath.method, apiPath.url()

		let that = this;
		let keyword = (query && query.Keywork) ? query.Keywork : null;

		let page = 1;
		let pageSize = 999999;

		if (query && query.Page && query.PageSize) {
			page = query.Page;
			pageSize = query.PageSize;
		}

		return new Promise(function (resolve, reject) {
			that.storage.get(apiPath.url())
				.then(items => {

					if (items == null) {
						that.connect(apiPath.method, apiPath.url(), null).subscribe(data => {
							that.cacheLocal(apiPath.url(), data);
							that.searchInItems(keyword, fields, page, pageSize, data).then(result => {
								resolve(result);
							})
						})
					}
					else {
						that.searchInItems(keyword, fields, page, pageSize, items).then(result => {
							resolve(result);
						})
					}
				})
				.catch(err => {
					reject(err);
				});
		});


	}

	cacheLocal(URL, Data) {
		return this.storage.set(URL, Data);
    }

    setLocal(key, data) {
        return this.storage.set(key, data);
    }

    getLocal(key) {
        return this.storage.get(key);
    }

	private handleError(error: any): Promise<any> {
		//console.log('An error occurred', error); // for demo purposes only
        //return Promise.reject(error.message || error);
        debugger
        var that = this;
		if (error.status == 0) {
			return Promise.reject('Can not connect to API server!');
        } else {
            var msg = JSON.parse(error._body);
            if (msg && msg.Message) {
                let toast = that.toastCtrl.create({
                    message: msg.Message,
                    duration: 3
                });
                toast.present();
                return Promise.reject(msg.Message);
            }
			return Promise.reject(error.message || error);
		}
	}

	getToken() {
		return 'Bearer ' + GlobalData.Token.access_token;
	}

	getAnItemLocal(ID: number, UID: string = '', apiPath) {
		let that = this;
		return new Promise((resolve, reject) => {
			let query = {
				Keywork: ID == 0 ? UID : ID
			};

			that.connectLocal(apiPath, query, ['ID', '_uid'])
				.then((results: any) => {
					if (results.count === 1) {
						resolve(results.data[0]);
					}
					else {
						reject(results);
					}
				})
				.catch(err => {
					reject(err);
				})
		});
	}

	getAnItemOnServer(ID: number, UID: string = '', apiPath) {
		let that = this;
		return new Promise(function (resolve, reject) {
			that.connect(apiPath.method, apiPath.url(ID), null).toPromise()
				.then(data => {
					resolve(data);
				})
				.catch(err => {
					reject(err);
					//return Promise.reject(err.message || err);
				});
		});
	}

	searchInItems(keyword, fields = [], page, pageSize, items) {
		return new Promise(resolve => {
			var result = { count: 0, data: [] };
			var data = [];
			if (keyword && fields.length) {
				data = items.filter(ite => {
					if (typeof (ite.IsDeleted) != 'undefined' && ite.IsDeleted != false) {
						return false;
					}
					else {
						let checkResult = false;
						for (var i = 0; i < fields.length; i++) {
							var element = fields[i];
							if (ite[element] == undefined) {
								checkResult == false;
							}
							else if (typeof (keyword.toLowerCase) == 'undefined') {
								checkResult = ite[element] == keyword
							}
							else {
								checkResult = (ite[element].toLowerCase().indexOf(keyword.toLowerCase()) > -1);
							}


							if (checkResult) {
								break;
							}
						}
						return checkResult;
					}
				});
			} else {
				data = items.filter((ite) => {
					if (typeof (ite.IsDeleted) == 'undefined') {
						return true;
					}
					else {
						return ite.IsDeleted === false
					}
				});
			}

			result.count = data.length;
			if (page && pageSize) {
				let from = (page - 1) * pageSize;
				let to = from + pageSize;
				result.data = data.slice(from, to);
			}
			else {
				result.data = data;
			}

			resolve(result);
		});
	}

	save(item, apiPath) {
		if (item.ID) {
			return this.update(item, apiPath.putItem);
		}
		else {
			return this.add(item, apiPath.postItem);
		}
	}
	add(item, apiPath) {
		item._state = 'add';
		item._uid = this.generateUID();
		return new Promise((resolve, reject) => {
			this.connect(apiPath.method, apiPath.url(), item).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
	update(item, apiPath) {
		item._state = 'update';
		return new Promise((resolve, reject) => {
			this.connect(apiPath.method, apiPath.url(item.ID), item).toPromise()
				.then(() => {
					resolve(item);
				}).catch(err => {
					reject(err);
				})
		});
	}
	delete(item, apiPath) {
		item._state = 'delete';
		item.IsDeleted = true;
		return new Promise((resolve, reject) => {
			this.connect(apiPath.delItem.method, apiPath.delItem.url(item.ID), null).toPromise()
				.then(() => {
					resolve(true);
				}).catch(err => {
					reject(err);
				})
		});
	}
	upload(apiPath: any, fileToUpload: File) {
		const formData: FormData = new FormData();
		formData.append('fileKey', fileToUpload, fileToUpload.name);
		return new Promise((resolve, reject) => {
			this.connect('UPLOAD', apiPath.url(), formData).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
	}
	download(apiPath: any, query) {
		return new Promise((resolve, reject) => {
			this.connect('DOWNLOAD', apiPath.url(), query).toPromise()
				.then((data) => {
					resolve(data);
				}).catch(err => {
					reject(err);
				})
		});
    }
    getDownloadUrl(path) {
        return APIListBase.File.Download.url(path);
    }
	copyPropertiesValue(fromItem, toItem) {
		for (let x in fromItem) {
			if (x != '_isChecked') {
				toItem[x] = fromItem[x];
			}
		}
	}
	cloneObject(source) {
		return JSON.parse(JSON.stringify(source));
	}
	getObject(path, obj) {
		return path.split('.')
			.reduce(function (prev, curr) {
				return prev ? prev[curr] : undefined
			},
				obj || self)
	}
	generateUID() {
		var d = new Date().getTime();
		var uuid = d + '-xxxxxxxxxxx'.replace(/[xy]/g, function (c) {
			var r = (d + Math.random() * 16) % 16 | 0;
			d = Math.floor(d / 16);
			return (c == 'x' ? r : (r & 0x3 | 0x8)).toString(16);
		});
		return uuid;
	}
	isNumeric(value: any): boolean {
		return !isNaN(value - parseFloat(value));
	}
	paddingNumber(number, count) {
		let numberString = '' + number;
		while (numberString.length < count) {
			numberString = '0' + numberString;
		}
		return numberString;
	}
	dateFormat(date, term) {
		if (!date) {
			return '';
		}

		let value = new Date(date);
		let result = '';
		let yy = value.getFullYear();
		let mm = value.getMonth() + 1;
		let dd = value.getDate();

		let hh = value.getHours();
		let MM = value.getMinutes();
		let ss = value.getSeconds();

		if (term == 'dd/mm/yy') {
			result = this.paddingNumber(dd, 2) + '/' + this.paddingNumber(mm, 2) + '/' + this.paddingNumber(yy - 2000, 2);
		}
		else if (term == 'dd/mm/yyyy') {
			result = this.paddingNumber(dd, 2) + '/' + this.paddingNumber(mm, 2) + '/' + this.paddingNumber(yy, 4);
		}
		else if (term == 'yy/mm/dd') {
			result = this.paddingNumber(yy - 2000, 2) + '/' + this.paddingNumber(mm, 2) + '/' + this.paddingNumber(dd, 2);
		}
		else if (term == 'yyyy/mm/dd') {
			result = this.paddingNumber(yy, 4) + '/' + this.paddingNumber(mm, 2) + '/' + this.paddingNumber(dd, 2);
		}
		else if (term == 'yyyy-mm-dd') {
			result = this.paddingNumber(yy, 4) + '-' + this.paddingNumber(mm, 2) + '-' + this.paddingNumber(dd, 2);
		}
		else if (term == 'd/m/yy') {
			result = this.paddingNumber(dd, 1) + '/' + this.paddingNumber(mm, 1) + '/' + this.paddingNumber(yy - 2000, 2);
		}
		else if (term == 'd/m/yyyy') {
			result = this.paddingNumber(dd, 1) + '/' + this.paddingNumber(mm, 1) + '/' + this.paddingNumber(yy, 4);
		}
		else if (term == 'dd/mm') {
			result = this.paddingNumber(dd, 2) + '/' + this.paddingNumber(mm, 2);
		}
		else if (term == 'dd/mm/yy hh:MM') {
			result = this.paddingNumber(dd, 2) + '/' + this.paddingNumber(mm, 2) + '/' + this.paddingNumber(yy, 2) + ' ' + this.paddingNumber(hh, 2) + ':' + this.paddingNumber(MM, 2);
		}
		else if (term == 'hh:MM dd/mm') {
			result = this.paddingNumber(hh, 2) + ':' + this.paddingNumber(MM, 2) + ' ' + this.paddingNumber(dd, 2) + '/' + this.paddingNumber(mm, 2);
		}
		else if (term == 'hh:MM dd/mm/yyyy') {
			result = this.paddingNumber(hh, 2) + ':' + this.paddingNumber(MM, 2) + ' ' + this.paddingNumber(dd, 2) + '/' + this.paddingNumber(mm, 2) + '/' + this.paddingNumber(yy, 4);
		}
		else if (term == 'hh:MM') {
			result = this.paddingNumber(hh, 2) + ':' + this.paddingNumber(MM, 2);
		}
		else if (term == 'hh:MM:ss') {
			result = this.paddingNumber(hh, 2) + ':' + this.paddingNumber(MM, 2) + ':' + this.paddingNumber(ss, 2);
		}

		return result;
	}
	dateFormatFriendly(date) {
		let now: any = new Date();
		let value:any = new Date(date);
		var seconds = Math.floor((now - value) / 1000);
		var interval = Math.floor(seconds / 31536000);
		if (interval > 1) {
			return interval + " năm trước";
		}
		interval = Math.floor(seconds / 2592000);
		if (interval > 1) {
			return interval + " tháng trước";
		}
		interval = Math.floor(seconds / 86400);
		if (interval > 1) {
			return interval + " ngày trước";
		}
		interval = Math.floor(seconds / 3600);
		if (interval > 1) {
			return interval + " giờ trước";
		}
		interval = Math.floor(seconds / 60);
		if (interval > 1) {
			return interval + " phút trước";
		}
		return Math.floor(seconds) + " giây trước";
	}
	currencyFormat(currency, contryCode = 'vi-VN', currencyCode = 'vnd') {
		return parseFloat(currency).toLocaleString(contryCode, { style: 'currency', currency: currencyCode });
	}
	hexToRgba(hex, alpha) {
		var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(hex);
		return result ? 'rgba(' + parseInt(result[1], 16) + ',' + parseInt(result[2], 16) + ',' + parseInt(result[3], 16) + ',' + alpha + ')' : null;
	}
	fileSizeFormat(bytes, si = true) {
		var thresh = si ? 1000 : 1024;
		if (Math.abs(bytes) < thresh) {
			if (bytes) {
				return bytes + ' B';
			}
			else {
				return '--'
			}

		}
		var units = si
			? ['kB', 'MB', 'GB', 'TB', 'PB', 'EB', 'ZB', 'YB']
			: ['KiB', 'MiB', 'GiB', 'TiB', 'PiB', 'EiB', 'ZiB', 'YiB'];
		var u = -1;
		do {
			bytes /= thresh;
			++u;
		} while (Math.abs(bytes) >= thresh && u < units.length - 1);
		return bytes.toFixed(1) + ' ' + units[u];
	}
	URLFormat(str) {
		if(!str){
			return '';
		}
		str = str.trim();
		str = str.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g, "a");
		str = str.replace(/è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ/g, "e");
		str = str.replace(/ì|í|ị|ỉ|ĩ/g, "i");
		str = str.replace(/ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ/g, "o");
		str = str.replace(/ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ/g, "u");
		str = str.replace(/ỳ|ý|ỵ|ỷ|ỹ/g, "y");
		str = str.replace(/đ/g, "d");
		str = str.replace(/À|Á|Ạ|Ả|Ã|Â|Ầ|Ấ|Ậ|Ẩ|Ẫ|Ă|Ằ|Ắ|Ặ|Ẳ|Ẵ/g, "A");
		str = str.replace(/È|É|Ẹ|Ẻ|Ẽ|Ê|Ề|Ế|Ệ|Ể|Ễ/g, "E");
		str = str.replace(/Ì|Í|Ị|Ỉ|Ĩ/g, "I");
		str = str.replace(/Ò|Ó|Ọ|Ỏ|Õ|Ô|Ồ|Ố|Ộ|Ổ|Ỗ|Ơ|Ờ|Ớ|Ợ|Ở|Ỡ/g, "O");
		str = str.replace(/Ù|Ú|Ụ|Ủ|Ũ|Ư|Ừ|Ứ|Ự|Ử|Ữ/g, "U");
		str = str.replace(/Ỳ|Ý|Ỵ|Ỷ|Ỹ/g, "Y");
		str = str.replace(/Đ/g, "D");
		str = str.replace(/!|@|%|\^|\*|\(|\)|\+|\=|\<|\>|\?|\/|,|\.|\:|\;|\'|\"|\&|\#|\[|\]|~|\$|_|`| |{|}|\||\\/g,"-");
		str = str.replace(/ + /g,"-");
		str = str.replace(/--/g,"-");
		
		return str.toLowerCase();
	}
}
//https://angular.io/docs/ts/latest/api/http/index/Http-class.html