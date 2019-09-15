import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController } from 'ionic-angular';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Facebook, FacebookLoginResponse } from '@ionic-native/facebook';
import { RegisterPage } from '../register/register';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable';



@IonicPage({ name: 'page-login', segment: 'login', priority: 'high' })
@Component({ selector: 'page-login', templateUrl: 'login.html', })
export class LoginPage {
	userprofile = GlobalData.Profile;
	formGroup: FormGroup;
	submitAttempt: boolean = false;
	email: string;
	password: string;
	FB_APP_ID: number = 125256361215152;
	loading: any;
	goingToGoOut = false;

	constructor(
		public events: Events,
		public loadingCtrl: LoadingController,
		public navCtrl: NavController,
		public navParams: NavParams,
		public toastCtrl: ToastController,
		public formBuilder: FormBuilder,
		private fb: Facebook,
		private accountService: AccountServiceProvider) {
		var that = this;

		//this.fb.browserInit(this.FB_APP_ID, "v2.8");

		this.formGroup = formBuilder.group({
			UserName: ['', Validators.compose([Validators.required])],
			Password: ['', Validators.compose([Validators.required])]
		});

		this.accountService.loadSavedData().then(() => {
			this.userprofile = GlobalData.Profile;
			if (this.userprofile.Id == '') {
				this.email = '';
				this.password = '';

				that.accountService.login('test@test.test', 'password').then(() => { }).catch((e) => { });

			}
			else {
				this.goBack();
			}
		})



	}

	goBack() {
		this.events.publish('app:openDefaultPage');
	}

	openRegister() {
		this.goingToGoOut = true;
		this.navCtrl.push(RegisterPage, {});

	}

	openForgotPassword() {
		this.goingToGoOut = true;
		this.navCtrl.push('page-forgot-password', { email: this.email });
	}

	login() {
		this.submitAttempt = true;
		if (!this.formGroup.valid) {
			return;
		}

		let loading = this.loadingCtrl.create({
			content: 'Vui lòng chờ đăng nhập và đồng bộ dữ liệu...'
		});
		loading.present();

		this.accountService.login(this.email, this.password)
			.then(data => {
				loading.dismiss();
				//this.goBack();
			})
			.catch(err => {
				loading.dismiss();
				let message = '';
				if (typeof (err._body.loaded) == 'number' && err._body.loaded == 0) {
					message = 'Không kết nối được server, vui lòng thử lại sau.'
				} else if (err._body.indexOf("locked out") > -1) {
					message = 'Tài khoản chưa kích hoạt hoặc đang bị khóa.'
				}
				else {
					message = 'Đăng nhập không thành công, \nvui lòng thử lại.';
				}
				let toast = this.toastCtrl.create({
					message: message,
					duration: GlobalData.UserData.Setting.ToastMessageDelay
				});
				toast.present();
			});
	}

	doFbLogin() {
		if (GlobalData.IsCordova) {
			let permissions = new Array();
			permissions = ["public_profile", "email"];
			let that = this;

			this.fb.login(permissions).then(function (response) {
				let params = new Array();
				//Getting name and gender properties
				this.fb.api("/me?fields=email,gender", params).then(function (user) {
					//user.picture = "https://graph.facebook.com/" + response.authResponse.userID + "/picture?type=large";
					that.showLoading();
					that.accountService.facebookLogin(user.email, response.authResponse.userID)
						.then(data => {
							that.loading.dismiss();
							this.goBack();
						})
						.catch(err => {
							that.loading.dismiss();
							let toast = that.toastCtrl.create({
								message: 'Đăng nhập không thành công, \nvui lòng thử lại.',
								duration: GlobalData.UserData.Setting.ToastMessageDelay
							});
							toast.present();
						});
				})
			}, function (error) {

			});
		}
		else {
			this.showLoading();
			this.accountService.facebookWebInfo().then(() => {
				this.loading.dismiss();
				this.goBack();
			}).catch(err => {
				this.loading.dismiss();
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
		this.events.publish('app:changeMenu', "page-login");
	}

	ionViewWillLeave() {

	}
	
	ionViewDidLeave() {
		this.goingToGoOut = false;
	}

	ionViewCanLeave(): Promise<void> {
		console.log('gateKeeper');
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
