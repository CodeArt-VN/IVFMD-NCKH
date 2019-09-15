import { Component } from '@angular/core';
import { IonicPage, Events, NavController, NavParams, LoadingController, ToastController } from 'ionic-angular';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RegisterPage } from '../register/register';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable';


@IonicPage({ name: 'page-forgot-password', segment: 'forgot-password', priority: 'high' })
@Component({ selector: 'page-forgot-password', templateUrl: 'forgot-password.html' })
export class ForgotPasswordPage {
    email: string;
    formGroup: FormGroup;
    submitAttempt: boolean = false;
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
        private accountService: AccountServiceProvider) {
        this.email = navParams.get('email');
        this.formGroup = formBuilder.group({
            UserName: ['', Validators.compose([Validators.required])],
        });
    }

    goBack() {
        this.goingToGoOut = true;
        this.navCtrl.setRoot('page-login');
    }
    
    openRegister() {
        this.goingToGoOut = true;
        this.navCtrl.push(RegisterPage, {});
    }

    forgotPassword() {
        this.submitAttempt = true;
        if (!this.formGroup.valid) {
            return;
        }

        this.showLoading();
        this.accountService.forgotPassword(this.email)
            .then(data => {
                if (this.loading) this.loading.dismiss();

                if (data.errorCode == "NotValid") {
                    let toast = this.toastCtrl.create({
                        message: 'Không tìm thấy email, vui lòng kiểm tra lại.',
                        showCloseButton: true,
                        closeButtonText: 'Ok'
                    });
                    toast.present();
                }
                else {
                    let toast = this.toastCtrl.create({
                        message: 'Hệ thống đã gửi email bảo mật để thay đổi mật khẩu. \nVui lòng kiểm tra email và làm theo hướng dẫn.',
                        showCloseButton: true,
                        closeButtonText: 'Ok'
                    });
                    toast.present();
                    this.goBack();
                }

            })
            .catch(err => {
                if (this.loading) this.loading.dismiss();
                let message = 'Không tìm thấy tài khoản ' + this.email;

                let toast = this.toastCtrl.create({
                    message: message,
                    duration: GlobalData.UserData.Setting.ToastMessageDelay
                });
                toast.present();
            });
    }

    showLoading() {
        this.loading = this.loadingCtrl.create({
            content: 'Vui lòng chờ gửi email...'
        });
        this.loading.present();
    }

    ionViewDidLoad() {
        this.events.publish('app:changeMenu', "page-forgot-password");
    }

    ionViewDidLeave() {
        this.goingToGoOut = false;
    }

    ionViewCanLeave(): Promise<void> {
        return new Promise<void>((resolve, reject) => {
            if (this.goingToGoOut) {
                resolve();
            }
            else {
                reject();
            }
        })
    }

}
