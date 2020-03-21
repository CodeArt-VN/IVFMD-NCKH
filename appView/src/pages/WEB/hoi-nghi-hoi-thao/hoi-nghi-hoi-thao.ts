import { Component, ViewChild, ChangeDetectorRef } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_HoiNghiHoiThaoDangKyCustomProvider } from '../../../providers/Services/CustomService';
import { HoiNghiHoiThaoModalPage } from '../hoi-nghi-hoi-thao-modal/hoi-nghi-hoi-thao-modal';
import { HoiNghiHoiThaoDangKyDeTaiModalPage } from '../hoi-nghi-hoi-thao-dang-ky-de-tai-modal/hoi-nghi-hoi-thao-dang-ky-de-tai-modal';
@IonicPage({ name: 'page-hoi-nghi-hoi-thao', segment: 'hoi-nghi-hoi-thao', priority: 'high' }) 
@Component({ selector: 'page-hoi-nghi-hoi-thao', templateUrl: 'hoi-nghi-hoi-thao.html' })
export class HoiNghiHoiThaoPage extends ListPage {
    FormGroups = [];
    canApprove = false;
    Modules = [];
    CurrentModule = "HNHT";
    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoDangKyCustomProvider,
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
        super('page-hoi-nghi-hoi-thao', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }
    
    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 7);
        this.Modules = this.getModules();
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(HoiNghiHoiThaoModalPage, { 'id': item.ID });
        myModal.present();
    }

    loadedData() {
        this.items.forEach((i) => {
            i.ThoiGianText = this.commonService.dateFormat(i.ThoiGian, 'dd/mm/yy hh:MM');
            i.ThoiGianHetHanText = this.commonService.dateFormat(i.ThoiGianHetHan, 'dd/mm/yy hh:MM');
            i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
        })
    }

    resgister(item) {
        let myModal = this.modalCtrl.create(HoiNghiHoiThaoDangKyDeTaiModalPage, { 'idDangKy': item.ID, 'itemData': item });
        myModal.present();
    }

    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
}
