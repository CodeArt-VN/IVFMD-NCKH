import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { SYS_PermissionListProvider, SYS_RoleProvider } from '../../../providers/Services/Services';


@IonicPage({ name: 'page-permission', segment: 'permission', priority: 'high' })
@Component({ selector: 'page-permission', templateUrl: 'permission.html' })
export class PermissionPage extends ListPage {
    FormGroups = [];
    roles = [];
    selectedRoles: any[] = [];
    selectedAll = false;
    changedList = [];

    constructor(
        public currentProvider: SYS_PermissionListProvider,
        public roleProvider: SYS_RoleProvider,

        public modalCtrl: ModalController,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
    ) {
        super('page-permission', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);

    }

    preLoadData() {

        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 3);
        super.preLoadData();
    }

    loadData() {
        Promise.all([
            this.roleProvider.read(this.query),
        ])
            .then(values => {
                this.roles = values[0]['data'];
                if (this.roles.length > 0) {
                    this.query.IDRole = this.roles[0].ID;
                    this.selectedRoles = [this.roles[0]];
                    super.loadData();
                }
                else {
                    this.items = [...[]];
                }
            })
    }

    loadedData() {
        this.items.filter(d => d.RowType == 1).forEach(i => {
            let checkAllForm = true;
            this.items.filter(d => d.GroupID == i.GroupID && d.RowType == 2).forEach(j => {
                if (j.PermissionList[0].Visible == false) {
                    checkAllForm = false;
                }
            });
            if (checkAllForm)
                i.PermissionList[0].Visible = checkAllForm;
        })
        this.items.filter(d => d.RowType == 0).forEach(i => {
            let checkAllGroup = true;
            this.items.filter(d => d.AppID == i.AppID && d.RowType == 1).forEach(j => {
                if (j.PermissionList[0].Visible == false) {
                    checkAllGroup = false;
                }
            });
            if (checkAllGroup)
                i.PermissionList[0].Visible = checkAllGroup;
        })
        let checkAllApp = true;
        this.items.filter(d => d.RowType == 0).forEach(j => {
            if (j.PermissionList[0].Visible == false) {
                checkAllApp = false;
            }
        });
        this.selectedAll = checkAllApp;
        super.loadedData();
    }

    onRoleSelect(evt) {
        if (this.selectedRoles.length > 0 && this.query.IDRole != evt.selected[0].ID) {
            this.query.IDRole = this.selectedRoles[0].ID;
            super.loadData();
        }
    }

    changePermission(i, p) {
        this.changedList = [];
        if (i.RowType == 2) {
            p.Visible = !p.Visible;
            this.changedList.push(p);
        }
        else if (i.RowType == 1) {
            p.Visible = !p.Visible;
            this.items.filter(d => d.GroupID == i.GroupID).forEach(i => {
                if (i.PermissionList[0].Visible != p.Visible) {
                    i.PermissionList[0].Visible = p.Visible;
                    this.changedList.push(i.PermissionList[0]);
                }
            });

        }
        else if (i.RowType == 0) {
            p.Visible = !p.Visible;
            this.items.filter(d => d.AppID == i.AppID).forEach(i => {
                if (i.PermissionList[0].Visible != p.Visible) {
                    i.PermissionList[0].Visible = p.Visible;
                    if (i.RowType == 2) {
                        this.changedList.push(i.PermissionList[0]);
                    }
                }
            });

        }
        this.saveChange();
    }

    selectAllFn(item) {
        this.selectedAll = !this.selectedAll
        this.changedList = [];

        this.items.forEach(i => {
            if (i.PermissionList[0].Visible != this.selectedAll) {
                i.PermissionList[0].Visible = this.selectedAll;
                if (i.RowType == 2) {
                    this.changedList.push(i.PermissionList[0]);
                }

            }
        });
        this.saveChange();
    }

    saveChange() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            const promises = [];
            this.changedList.forEach(i => {
                promises.push(this.currentProvider.save(i));
            })
            Promise.all(promises)
                .then(res => {
                    super.loadData();
                    if (this.loading) this.loading.dismiss();
                    this.toastMessage('Đã lưu xong!');
                })
                .catch(err => {
                    if (this.loading) this.loading.dismiss();
                    this.toastMessage('Không lưu được, \nvui lòng thử lại.');
                });
        })
    }
}
