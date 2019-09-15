import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';

import { ACCOUNT_ApplicationUserProvider } from '../../../providers/Services/CustomService';

@IonicPage({ name: 'page-user-profile', segment: 'user-profile/:id', priority: 'high', defaultHistory: ['page-member'] })
@Component({ selector: 'page-user-profile', templateUrl: 'user-profile.html' })

export class UserProfilePage extends DetailPage {
    activePage = 'page-1';
    showLogout = false;

    oldPassword = '';
    newPassword = '';
    confirmPassword = '';
    passwordViewType = 'password';
    showRolesEdit = false;


    constructor(
        public currentProvider: ACCOUNT_ApplicationUserProvider,

        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public formBuilder: FormBuilder,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
    ) {
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.formGroup = formBuilder.group({

            DOB: [''],
            Email: [''],
            FullName: ['', Validators.compose([Validators.required])],
            PhoneNumber: [''],
            CreatedDate: [''],
            Gender: [''],
            Roles: ['']
        });
    }


    loadedData() {
        this.showRolesEdit = GlobalData.Profile.Roles.findIndex(d => d.RoleId == 'ThuKy') > -1;
        this.showLogout = this.item.UserName == GlobalData.Profile.UserName;
        let createdDate = new Date(this.item.CreatedDate);
        this.item.CreatedDateText = createdDate.getDate() + '/' + (createdDate.getMonth() + 1) + '/' + createdDate.getFullYear();
        super.loadedData();
    }

    changeGender(gender) {
        this.item.Gender = gender;
        this.formGroup.controls['Gender'].markAsDirty();
    }

    changePassword() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.changePassword(this.oldPassword, this.newPassword, this.confirmPassword)
                .then((savedItem: any) => {
                    if (this.loading) this.loading.dismiss();
                    this.loadData();
                    this.toastMessage('Đã đổi mật khẩu!');
                }).catch(err => {
                    let message = '';
                    if (err._body.indexOf('confirmation password do not match') > -1) {
                        message = 'Mật khẩu nhập lại không khớp.'
                    }

                    else if (err._body.indexOf('least 6 characters') > -1) {
                        message = 'Vui lòng nhập mật khẩu nhiều hơn 6 ký tự.'
                    }
                    else if (err._body.indexOf('Incorrect password') > -1) {
                        message = 'Mật khẩu cũ không đúng. \nVui lòng thử lại.'
                    }
                    else {
                        message = 'Không lưu được, \nvui lòng thử lại.'
                    }

                    if (this.loading) this.loading.dismiss();
                    this.toastMessage(message);
                });
        })
    }

    resetPassword() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.resetPassword(this.item.ID, this.newPassword, this.confirmPassword)
                .then((savedItem: any) => {
                    if (this.loading) this.loading.dismiss();
                    this.loadData();
                    this.toastMessage('Đã đổi mật khẩu!');
                }).catch(err => {
                    let message = '';
                    if (err._body.indexOf('confirmation password do not match') > -1) {
                        message = 'Mật khẩu nhập lại không khớp.'
                    }
                    else if (err._body.indexOf('least 6 characters') > -1) {
                        message = 'Vui lòng nhập mật khẩu nhiều hơn 6 ký tự.'
                    }
                    else {
                        message = 'Không lưu được, \nvui lòng thử lại.'
                    }

                    if (this.loading) this.loading.dismiss();
                    this.toastMessage(message);
                });
        })
    }

    checkRole(role) {
        return (this.item.Roles.filter(d => d.RoleId == role)).length > 0;
    }
    
    changeRole(role) {
        var index = this.item.Roles.findIndex(d => d.RoleId == role);
        if (index === -1) {
            this.item.Roles.push({ RoleId: role, Name: null });
        } else {
            this.item.Roles.splice(index, 1);
        }
        this.formGroup.controls['Roles'].markAsDirty();
    }

    logout() {
        let loading = this.loadingCtrl.create({
            content: 'Vui lòng chờ đồng bộ dữ liệu của bạn và đăng xuất...'
        });
        loading.present();

        this.accountService.logout()
            .then(_ => {
                loading.dismiss();
                this.goBack();
            })
            .catch(err => {
                loading.dismiss();
                console.log(err);

                let toast = this.toastCtrl.create({
                    message: 'Không đồng bộ được, vui lòng thử lại sau.',
                    duration: GlobalData.UserData.Setting.ToastMessageDelay
                });
                toast.present();
            });
    }
}
