import { Injectable } from '@angular/core';
import { Headers, RequestOptions, Http, URLSearchParams } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/catch';

import { Events } from 'ionic-angular';
import { Storage } from '@ionic/storage';
import { CommonServiceProvider } from '../CORE/common-service';
import { APIList, GlobalData } from '../CORE/global-variable';
import { appSetting } from '../CORE/api-list';

//declare var cordova: any;
declare var FB: any;
declare var appVersion: any; //view on index.html file


@Injectable()
export class AccountServiceProvider {
	constructor(
		public http: Http,
		public commonService: CommonServiceProvider,
		public storage: Storage,
		public events: Events,

	) {
	}

	//
	checkVersion() {
		// let appVersion = '2018.08.20.3';
		return new Promise(resolve => {
			this.storage.get('appVersion').then((version) => {
				if (appVersion != version) {


					GlobalData.Token = {
						"access_token": "no token",
						"expires_in": 0,
						"token_type": "",
						"refresh_token": "no token"
					};

					this.storage.set('UserToken', GlobalData.Token).then(() => {
						GlobalData.Profile = null;
						this.storage.set('UserProfile', GlobalData.Profile).then(() => {
							this.storage.set('appVersion', appVersion).then(() => {
								resolve(appVersion);
							})
						});
					});
				}
				else {
					resolve(appVersion);
				}
			});
		});
	}

	loadSavedData(forceReload = false) {
		return new Promise(resolve => {
			this.checkVersion().then((v) => {
				GlobalData.Version = v;
				this.getToken().then(() => {
					this.getProfile(forceReload).then(() => {
						resolve(true);
					})
				})
			});
		});
	}

	checkAuthor() {
		return new Promise<void>((resolve, reject) => {
			this.loadSavedData().then(() => {
				if (GlobalData.Profile.Id != '' && GlobalData.Token.access_token != "-1") {
					resolve();
				}
				else {
					reject();
				}
			})
		})
	}


	//
	register(username, password, confirmpassword, PhoneNumber, FullName) {
		var that = this;
		return new Promise(function (resolve, reject) {
			let params = new URLSearchParams();
			let data = {
				Email: username,
				Password: password,
				ConfirmPassword: confirmpassword,
				FullName: FullName,
				PhoneNumber: PhoneNumber,
			};

			that.http.post(APIList.ACCOUNT.register.url, data)
				.map(res => res)
				.catch(err => {
					reject(err);
					return Promise.reject(err.message || err);
				})
				.subscribe(data => {
					that.login(username, password)
						.then(() => {
							resolve(true);
						})
						.catch(err => {
							reject(err);
						});
				});
		});
	}

	facebookRegister(username, userid) {
		let fbModel = { UserName: username, Provider: "FaceBook", ProviderId: userid };
		return this.commonService.connect(
			APIList.ACCOUNT.registerFB.method,
			APIList.ACCOUNT.registerFB.url, fbModel).toPromise();
	}

	login(username, password) {
		var that = this;
		return new Promise(function (resolve, reject) {
			let headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });
			let options = new RequestOptions({ headers: headers });
			let params = new URLSearchParams();
			params.set('grant_type', 'password');
			params.set('username', username);
			params.set('password', password);

			that.http.post(APIList.ACCOUNT.token.url, params, options)
				.map(res => res.json())
				.catch(err => {
					reject(err);
					return Promise.reject(err.message || err);
				})
				.subscribe(data => {
					that.setToken(data);
					that.syncGetUserData()
						.then(() => {

							that.events.publish("user:update");
							resolve(true);
						});
				});
		});
	}

	facebookLogin(username, userid) {
		var that = this;
		return new Promise(function (resolve, reject) {
			let headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded', 'Authorization': 'Basic UG9ydGFsM1BTOmNsaWVudFBvcnRhbDNQUw==' });
			let options = new RequestOptions({ headers: headers });
			let params = new URLSearchParams();
			params.set('grant_type', 'password');
			params.set('username', username);
			params.set('password', 'facebook');
			params.set('scope', 'openid profile roles sampleApi offline_access');
			params.set('acr_values', 'Facebook');

			that.http.post(APIList.ACCOUNT.token.url, params, options)
				.map(res => res.json())
				.catch(err => {
					if (err.data.error == "invalid_grant") {
						//đăng ký
						that.facebookRegister(username, userid).then(() => {
							that.facebookLogin(username, userid).then(() => {
								resolve(true);
							});
						}).catch(errr => {
							console.log(errr);
							reject(errr);
							return Promise.reject(errr.message || errr);
						});
					}
					else {
						console.log(err);
						reject(err);
						return Promise.reject(err.message || err);
					}
				})
				.subscribe(data => {
					that.setToken(data);
					that.syncGetUserData()
						.then(data => {
							that.events.publish('user:update');
							resolve(true);
						});
				});
		});
	}

	logout() {
		var that = this;
		return new Promise(function (resolve, reject) {
			that.storage.clear();
			that.setToken(null);
			that.setProfile(null);
			that.events.publish("user:update");
			resolve(true);
		});
	}

	forgotPassword(email) {
		let data = { Email: email };
		return this.commonService.connect(
			APIList.ACCOUNT.forgotPassword.method,
			APIList.ACCOUNT.forgotPassword.url,
			data
		).toPromise();
	}


	//
	syncGetUserData() {
		let that = this;
		return new Promise(function (resolve, reject) {
			that.commonService.connect(
				APIList.ACCOUNT.getUserData.method,
				APIList.ACCOUNT.getUserData.url + '?GetMenu=true',
				null
			).toPromise()
				.then(data => {
					if (data) {
						data.Avatar = data.Avatar ? appSetting.mainService.base + data.Avatar : null;
						if (data.Partners.length > 0) {
							data.Partner = data.Partners[0];
						} else {
							data.Partner = {};
						}

						that.setProfile(data);
						resolve(true);
					}
				})
				.catch(err => {
					reject(err);
					return Promise.reject(err.message || err);
				});
		});
	}

	setToken(token) {
		if (token != null) {
			GlobalData.Token = token;
		}
		else {
			GlobalData.Token = {
				"access_token": "no token",
				"expires_in": 0,
				"token_type": "",
				"refresh_token": "no token"
			};
		}
		this.storage.set('UserToken', GlobalData.Token);
	}

	getToken() {
		return new Promise(resolve => {
			this.storage.get('UserToken').then((token) => {
				if (token != null) {
					let expires = new Date(token[".expires"]);
					let cDate = new Date();
					cDate.setDate(cDate.getDate() + 2);

					if (expires > cDate) {
						GlobalData.Token = token;
					}
					else {
						GlobalData.Token = {
							"access_token": "-1",
							"expires_in": 0,
							"token_type": "",
							"refresh_token": "no token"
						};
					}
				}
				else {
					GlobalData.Token = {
						"access_token": "-1",
						"expires_in": 0,
						"token_type": "",
						"refresh_token": "no token"
					};
				}
				resolve(GlobalData.Token);
			});
		});
	}

	setProfile(profile) {
		GlobalData.Profile = profile;
		this.storage.set('UserProfile', GlobalData.Profile);
	}

	getProfile(forceReload = false) {
		return new Promise(resolve => {
			if (forceReload) {
				this.syncGetUserData().then(() => {
					resolve(true);
				});
			}
			else {
				this.storage.get('UserProfile').then((profile) => {
					if (profile) {
						GlobalData.Profile = profile;
						resolve(true);
					} else {
						this.syncGetUserData().then(() => {
							resolve(true);
						});
					}
				});
			}

		});
	}

	facebookWebInfo() {
		let that = this;
		return new Promise(function (resolve, reject) {
			FB.getLoginStatus(function (response) {
				FB.api('/me', { fields: 'email, last_name, first_name, middle_name' }, function (responseInfo) {
					that.facebookLogin(responseInfo.email, responseInfo.id)
						.then(() => {
							resolve(true);
						})
						.catch(err => {
							reject(err);
							return Promise.reject(err.message || err);
						})
				});
			});
		});
	}


}

