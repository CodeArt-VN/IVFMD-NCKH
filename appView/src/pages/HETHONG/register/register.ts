import { Component } from '@angular/core';
import { IonicPage, Events, NavController, NavParams, LoadingController, ToastController } from 'ionic-angular';

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
		
	) {
		var that = this;
		
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
