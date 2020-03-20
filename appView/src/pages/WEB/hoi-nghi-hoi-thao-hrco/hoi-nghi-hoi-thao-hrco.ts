import { Component, ViewChild, ChangeDetectorRef } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_HoiNghiHoiThaoCustomProvider } from '../../../providers/Services/CustomService';
import { HoiNghiHoiThaoHRCOModalPage } from '../hoi-nghi-hoi-thao-hrco-modal/hoi-nghi-hoi-thao-hrco-modal';
import { HoiNghiHoiThaoDanhSachDangKyModalPage } from '../hoi-nghi-hoi-thao-danh-sach-dang-ky-modal/hoi-nghi-hoi-thao-danh-sach-dang-ky-modal';
import { HoiNghiHoiThaoDanhSachDeTaiModalPage } from '../hoi-nghi-hoi-thao-danh-sach-de-tai-modal/hoi-nghi-hoi-thao-danh-sach-de-tai-modal';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao-hrco', segment: 'hoi-nghi-hoi-thao-hrco', priority: 'high' }) 
@Component({ selector: 'page-hoi-nghi-hoi-thao-hrco', templateUrl: 'hoi-nghi-hoi-thao-hrco.html' })
export class HoiNghiHoiThaoHRCOPage extends ListPage {
    FormGroups = [];
    Modules = [];
    CurrentModule = "NCKH-View";
    canApprove = true;
    showDatePicks = false;
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
        public currentProvider: PRO_HoiNghiHoiThaoCustomProvider,
        private cdr: ChangeDetectorRef,
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
        super('page-hoi-nghi-hoi-thao-hrco', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.query.DateFrom = "";
        this.query.DateTo = "";
    }
    
    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        this.Modules = this.getModules();
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(HoiNghiHoiThaoHRCOModalPage, { 'id': item.ID });
        myModal.present();
    }

    loadedData() {
        this.items.forEach((i) => {
            i.ThoiGianText = this.commonService.dateFormat(i.ThoiGian, 'dd/mm/yy hh:MM');
            i.ThoiGianHetHanText = this.commonService.dateFormat(i.ThoiGianHetHan, 'dd/mm/yy hh:MM');
            i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
        })
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

    openNguoiDangKy(item) {
        let myModal = this.modalCtrl.create(HoiNghiHoiThaoDanhSachDangKyModalPage, { 'idHoiNghi': item.ID });
        myModal.present(); 
    }

    openDeTai(item) {
        let myModal = this.modalCtrl.create(HoiNghiHoiThaoDanhSachDeTaiModalPage, { 'idHoiNghi': item.ID });
        myModal.present(); 
    }

    exportOnly(item) {
        let query = {
            IDHoiNghiHoiThao: item.ID 
        };
        this.exportCustomQuery(query);
    }

    exportAll() {
        let query = {
            DateFrom: this.query.DateFrom,
            DateTo: this.query.DateTo,
        };
        this.exportCustomQuery(query);
    }

    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
}
