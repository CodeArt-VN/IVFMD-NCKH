import { Component } from '@angular/core';
import { IonicPage, Events, NavController, NavParams, LoadingController, ToastController } from 'ionic-angular';
import { Facebook } from '@ionic-native/facebook';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable';


@IonicPage({ name: 'page-register', segment: 'register', priority: 'high', })
@Component({ selector: 'page-register', templateUrl: 'register.html' })
export class RegisterPage {
	fullName: string;
	email: string;
	phone: string;
	password: string;
	retypePassword: string;
	FB_APP_ID: number = 125256361215152;
	loading: any;
	goingToGoOut = false;

	constructor(
		public events: Events,
		public loadingCtrl: LoadingController,
		public navCtrl: NavController,
		public navParams: NavParams,
		public toastCtrl: ToastController,
		private accountService: AccountServiceProvider,
		private fb: Facebook,
	) {
		var that = this;
		fb.browserInit(this.FB_APP_ID, "v2.8");
		setTimeout(function () {
			that.accountService.login('test@test.test', 'password').catch(err => { console.log(err); });
		}, 0);
	}


	register() {
		this.showLoading();

		this.accountService.register(this.email, this.password, this.retypePassword, this.phone, this.fullName)
			.then(data => {
				this.loading.dismiss();
				//this.goBack();
				this.navCtrl.setRoot('page-dashboard');
			})
			.catch(err => {
				this.loading.dismiss();
				console.log(err);
				let message = '';
				if (err._body.indexOf("already taken")) {
					message = 'Email ' + this.email + ' đã được đăng ký, \nvui lòng đăng nhập hoặc đăng ký bằng email khác.'
				}
				else {
					message = 'Đăng ký không thành công, \nvui lòng thử lại.';
				}

				let toast = this.toastCtrl.create({
					message: message,
					duration: GlobalData.UserData.Setting.ToastMessageDelay
				});
				toast.present();
			});
	}
	goBack() {

		if (this.navCtrl.canGoBack()) {
			this.goingToGoOut = true;
			this.navCtrl.pop();
		}
		else {
			this.navCtrl.setRoot('page-dashboard');
		}
	}
	doFbLogin() {
		if (GlobalData.IsCordova) {
			let permissions = new Array();
			permissions = ["public_profile", "email"];
			let that = this;

			that.fb.login(permissions).then(function (response) {
				let params = new Array();
				//Getting name and gender properties
				that.fb.api("/me?fields=email,gender", params).then(function (user) {
					//user.picture = "https://graph.facebook.com/" + response.authResponse.userID + "/picture?type=large";
					that.showLoading();
					that.accountService.facebookLogin(user.email, response.authResponse.userID)
						.then(data => {
							that.loading.dismiss();
							that.navCtrl.pop();
						})
						.catch(err => {
							that.loading.dismiss();
							console.log(err);
							let toast = that.toastCtrl.create({
								message: 'Đăng nhập không thành công, \nvui lòng thử lại.',
								duration: GlobalData.UserData.Setting.ToastMessageDelay
							});
							toast.present();
						});
				})
			}, function (error) {
				console.log(error);
			});
		}
		else {
			this.showLoading();
			this.accountService.facebookWebInfo().then(() => {
				this.loading.dismiss();
				this.goBack();
			}).catch(err => {
				this.loading.dismiss();
				console.log(err);
				let toast = this.toastCtrl.create({
					message: 'Đăng nhập không thành công, \nvui lòng thử lại.',
					duration: GlobalData.UserData.Setting.ToastMessageDelay
				});
				toast.present();
			});
		}
	}

	showLoading() {
		this.loading = this.loadingCtrl.create({
			content: 'Vui lòng chờ đăng nhập và đồng bộ dữ liệu...'
		});
		this.loading.present();
	}
	ionViewDidLoad() {
		this.events.publish('app:changeMenu', "page-register");
	}
	ionViewCanLeave(): Promise<void> {
		return new Promise<void>((resolve, reject) => {
			if (GlobalData.Profile.Id != '' || this.goingToGoOut) {
				resolve();
			}
			else {
				reject();
			}
		})
	}
}
