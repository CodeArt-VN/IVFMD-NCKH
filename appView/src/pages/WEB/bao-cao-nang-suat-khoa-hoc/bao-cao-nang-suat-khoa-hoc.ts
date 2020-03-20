import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_BaoCaoNangSuatKhoaHocCustomProvider } from '../../../providers/Services/CustomService';
import { BaoCaoNangSuatKhoaHocModalPage } from '../bao-cao-nang-suat-khoa-hoc-modal/bao-cao-nang-suat-khoa-hoc-modal';
import { DateAdapter } from "@angular/material";
@IonicPage({ name: 'page-bao-cao-nang-suat-khoa-hoc', segment: 'bao-cao-nang-suat-khoa-hoc', priority: 'high' }) 
@Component({ selector: 'page-bao-cao-nang-suat-khoa-hoc', templateUrl: 'bao-cao-nang-suat-khoa-hoc.html' })
export class BaoCaoNangSuatKhoaHocPage extends ListPage {
    FormGroups = [];
    Modules = [];
    CurrentModule = "NCKH-View";
    canApprove = false;
    statusList = [
        { 'ID': 1, 'Code': 'ChuaDuyet', 'ValueOfVar': 'Chưa duyệt', 'Selected': false },
        { 'ID': 2, 'Code': 'DaDuyet', 'ValueOfVar': 'Đã duyệt', 'Selected': false },
    ];
    showDatePicks = false;
    showStatus = false;
    timeQuery: any = {
        DateFrom: null,
        DateTo: null,
    };
    lang = {
        months: ['Tháng 1', 'Tháng 2', 'Tháng 3', 'Tháng 4', 'Tháng 5', 'Tháng 6', 'Tháng 7', 'Tháng 8', 'Tháng 9', 'Tháng 10', 'Tháng 11', 'Tháng 12'],
        days: ['CN', 'T2', 'T3', 'T4', 'T5', 'T6', 'T7'],
        today: 'Hôm nay',
        clear: 'Xóa',
        close: 'Đóng',
    };
    constructor(
        public currentProvider: PRO_BaoCaoNangSuatKhoaHocCustomProvider,

        public modalCtrl: ModalController,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider
    ) {
        super('page-bao-cao-nang-suat-khoa-hoc', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.query.ListStatusID = "";
        this.query.DateFrom = "";
        this.query.DateTo = "";
    }

    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.canApprove = this.isUserCanUse('page-bao-cao-nang-suat-khoa-hoc-hrco');
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        this.Modules = this.getModules();
        super.preLoadData();
    }

    filterByTime() {
        this.showDatePicks = false;
        this.query.DateFrom = this.timeQuery.DateFrom;
        this.query.DateTo = this.timeQuery.DateTo;
        this.loadData();
    }

    clearFilterByTime() {
        this.showDatePicks = false;
        this.query.DateFrom = '';
        this.query.DateTo = '';
        this.timeQuery.DateFrom = null;
        this.timeQuery.DateTo = null;
        this.loadData();
    }

    filterByStatus() {
        this.showStatus = false;
        this.query.ListStatusID = this.statusList.filter(c => c.Selected == true).map(d => d.ID).join();
        this.loadData();
    }

    clearFilterByStatus() {
        this.showStatus = false;
        this.query.ListStatusID = '';
        this.statusList.forEach((i) => {
            i.Selected = false;
        });
        this.loadData();
    }

    isUserCanUse(functionCode) {
        let menus = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        return menus[0].Forms.findIndex(d => d.Code == functionCode) > -1;
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(BaoCaoNangSuatKhoaHocModalPage, { 'id': item.ID, 'canApprove': this.canApprove });
        myModal.present();
    }

    approve(item) {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.updateStatus(item.ID, "Approved").then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        })
    }

    unApprove(item) {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.updateStatus(item.ID, "UnApproved").then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        })
    }

    loadedData() {
        this.items.forEach((i) => {
            i.NgayBaoCaoText = this.commonService.dateFormat(i.NgayBaoCao, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
        })
    }

    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
}
