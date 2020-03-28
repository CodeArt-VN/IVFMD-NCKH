import { Component, ViewChild } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { HRM_STAFF_NhanSuProvider, SYS_RoleProvider } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import { FileUploader } from 'ng2-file-upload';
// import 'jqueryui';
import { appSetting } from '../../../providers/CORE/api-list';
import { ACCOUNT_ApplicationUserProvider } from '../../../providers/Services/CustomService';
import { GlobalData } from '../../../providers/CORE/global-variable';
import { CompareValidator } from '../../../providers/CORE/validators';

@IonicPage({ name: 'page-staff-modal', priority: 'high', defaultHistory: ['page-staff'] })
@Component({
    selector: 'staff-modal',
    templateUrl: 'staff-modal.html',
})
export class StaffModalPage extends DetailPage {
    avatarURL = 'assets/imgs/avartar-empty.jpg';
    @ViewChild('importfile') importfile: any;

    uploader: FileUploader = new FileUploader({
        url: '',
        authTokenHeader: "Authorization",
        authToken: this.commonService.getToken(),
        queueLimit: 1,
        allowedFileType: ['image']
    });
    hasBaseDropZoneOver = false;

    activePage = 'page-1';
    baseServiceURL = appSetting.mainService.base;
    showLogout = false;

    oldPassword = '';
    newPassword = '';
    confirmPassword = '';
    passwordViewType = 'password';
    showRolesEdit = false;
    isViewProfile = false;
    userAccount: any = {};
    changePasswordForm: FormGroup;

    roles = [];

    constructor(
        public currentProvider: HRM_STAFF_NhanSuProvider,
        public urserProvider: ACCOUNT_ApplicationUserProvider,
        public roleProvider: SYS_RoleProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-staff-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);

        this.isViewProfile = this.navParams.get('profile');
        this.events.unsubscribe('app:Close-page-staff-modal');
        this.events.subscribe('app:Close-page-staff-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Code: ['', Validators.compose([Validators.required])],
            Email: ['', Validators.compose([Validators.required, , Validators.email])],
            Name: ['', Validators.compose([Validators.required])],
            SoDienThoai: [''],
            DiaChi: [''],
            IDRole: [''],
            IsCNDT: false,
            IsHRCO: false
        });

        this.changePasswordForm = formBuilder.group({
            oldPassword: [''],
            newPassword: ['', Validators.compose([Validators.required, Validators.minLength(6)])],
            confirmPassword: ['', Validators.compose([Validators.required, CompareValidator.confirmPassword])]
        });
        this.changePasswordForm.controls['confirmPassword'].setParent(this.changePasswordForm);



        this.uploader.onBeforeUploadItem = (item) => {
            let UploadAPI = appSetting.apiDomain('CUS/FILE/UploadAvatar/' + this.item.Code);
            item.url = UploadAPI;
        }

        this.uploader.onSuccessItem = (item, response, status: number, headers) => {
            
            this.uploader.clearQueue();
            console.log(response);
            this.avatarURL = this.baseServiceURL + 'Uploads/HRM/Staffs/Avatars/'+ this.item.Code +'.jpg?t=' + new Date().getTime();
                
            if (this.userprofile.Email == this.item.Email) {
                //reload avatar in user cp
                GlobalData.Profile.Avatar = this.avatarURL;
                this.accountService.setProfile(GlobalData.Profile);
                this.events.publish('app:UpdateAvatar', this.avatarURL);
                console.log('app:UpdateAvatar');
            }
        }
    }



    preLoadData() {
        Promise.all([
            this.roleProvider.read()
        ])
            .then(values => {
                this.roles = values[0]['data'];
                super.preLoadData();
            })
    }

    loadedData() {
        if (!this.item.IDPartner) {
            this.item.IDPartner = this.navParams.data.IDPartner;
        }

        if (this.id) {
            this.urserProvider.getAnItem(this.item.Email, '').then((ite) => {
                this.commonService.copyPropertiesValue(ite, this.userAccount);

            }).catch((data) => {
                this.userAccount.ID = 0;
            });
            this.avatarURL = this.baseServiceURL + 'Uploads/HRM/Staffs/Avatars/'+ this.item.Code +'.jpg?t=' + new Date().getTime();
            
        }
        else {
            this.userAccount.ID = 0;
        }

        this.showRolesEdit = GlobalData.Profile.Roles.SYSRoles.indexOf('HOST') > -1;
        if (this.item.Email && GlobalData.Profile.UserName)
            this.showLogout = this.item.Email.toLowerCase() == GlobalData.Profile.UserName.toLowerCase();
        super.loadedData();
    }

    saveChange() {
        if (!this.formGroup.valid) {
            this.toastMessage('Vui lòng kiểm tra lại các thông tin được tô đỏ bên trên.');
            return;
        }
        if (this.userAccount.ID) {
            this.userAccount.Email = this.item.Email;
            this.userAccount.FullName = this.item.Name;
            this.userAccount.Avatar = 'Uploads/HRM/Staffs/Avatars/' + this.item.Code + '.jpg';
            this.userAccount.PhoneNumber = this.item.SoDienThoai;
            this.userAccount.Address = this.item.DiaChi;
            this.userAccount.StaffID = this.item.ID;
            this.userAccount.PartnerID = this.item.IDPartner;
            this.userAccount.IsHRCO = this.item.IsHRCO;
            this.userAccount.IsCNDT = this.item.IsCNDT;
            this.urserProvider.save(this.userAccount).then(() => {
                super.saveChange();
            })
        }
        else {
            super.saveChange();
        }
    }

    savedChange() {
        this.events.publish('app:Update' + 'page-staff');
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    changePassword() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.urserProvider.changePassword(this.oldPassword, this.newPassword, this.confirmPassword)
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
        if (!this.changePasswordForm.valid) {
            this.toastMessage('Vui lòng kiểm tra lại các thông tin được tô đỏ bên trên.');
            return;
        }

        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.urserProvider.resetPassword(this.userAccount.ID, this.newPassword, this.confirmPassword)
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
        if (this.userAccount) {
            return (this.userAccount.Roles.filter(d => d.RoleId == role)).length > 0;
        }
        else {
            return false;
        }


    }

    changeRole(role) {
        var index = this.userAccount.Roles.findIndex(d => d.RoleId == role);
        if (index === -1) {
            this.userAccount.Roles.push({ RoleId: role, Name: null });
        } else {
            this.userAccount.Roles.splice(index, 1);
        }
        this.urserProvider.save(this.userAccount).then(() => {
            this.toastMessage('Đã thay đổi quyền quản trị');
            this.events.publish('app:Update' + 'page-staff');
        })
    }

    changeLock() {
        this.userAccount.LockoutEnabled = !this.userAccount.LockoutEnabled;
        let message = 'Tài khoản hoạt động bình thường';

        if (this.userAccount.LockoutEnabled) {
            message = 'Tài khoản đã bị khóa, không cho phép đăng nhập';
        }
        this.urserProvider.save(this.userAccount).then(() => {
            this.toastMessage(message);
            this.events.publish('app:Update' + 'page-staff');
        })
    }

    createAccount() {
        this.showActionMore = false;
        this.submitAttempt = true;
        if (!this.changePasswordForm.valid) {
            this.toastMessage('Vui lòng kiểm tra lại các thông tin được tô đỏ bên trên.');
        }
        else {
            this.loadingMessage('Lưu dữ liệu...').then(() => {
                this.userAccount = {};
                this.userAccount.Email = this.item.Email;
                this.userAccount.FullName = this.item.Name;
                this.userAccount.Avatar = 'Uploads/HRM/Staffs/Avatars/' + this.item.Code + '.jpg';
                this.userAccount.PhoneNumber = this.item.SoDienThoai;
                this.userAccount.Address = this.item.DiaChi;
                this.userAccount.StaffID = this.item.ID;
                this.userAccount.PartnerID = this.item.IDPartner;
                this.userAccount.UserName = this.newPassword;
                this.userAccount.IsHRCO = this.item.IsHRCO;
                this.userAccount.IsCNDT = this.item.IsCNDT;
                this.urserProvider.save(this.userAccount)
                    .then(() => {
                        this.toastMessage('Đã tạo tài khoản cho nhân sự ' + this.item.Name);
                        if (this.loading) this.loading.dismiss();
                        this.loadedData();
                        this.events.publish('app:Update' + 'page-staff');

                    })
                    .catch(err => {
                        if (this.loading) this.loading.dismiss();
                        this.toastMessage('Không lưu được, \nvui lòng thử lại.');
                    });
            })
        }

    }

    logout() {
        this.events.publish('user:logout');
        this.dismiss();
    }

    fileOverBase(e: any): void {
        this.hasBaseDropZoneOver = e;
    }

    onFileSelected() {
        setTimeout(() => {
            if (this.uploader.queue.length) {
                this.uploader.uploadAll();
            }
        }, 0);
    }

    selectFile() {
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
        setTimeout(() => {
            if (this.uploader.queue.length) {
                this.uploader.uploadAll();
            }
        }, 0);
    }

}