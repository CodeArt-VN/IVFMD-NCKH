import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_DeTaiProvider } from '../../../providers/Services/Services';
import { DeTaiModalPage } from '../de-tai-modal/de-tai-modal';
import { DonXinNghiemThuModalPage } from '../don-xin-nghiem-thu-modal/don-xin-nghiem-thu-modal';

@IonicPage({ name: 'page-de-tai', segment: 'de-tai', priority: 'high' })
@Component({ selector: 'page-de-tai', templateUrl: 'de-tai.html' })
export class DeTaiPage extends ListPage {
    templateUrl = '';
    FormGroups = [];
    Modules = [];
    CurrentModule = "NCKH-View";
    constructor(
        public currentProvider: PRO_DeTaiProvider,
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
        super('page-de-tai', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);


    }

    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.query.SortBy = '[ID_desc]';
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        this.Modules = this.getModules();
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(DeTaiModalPage, { 'id': item.ID });
        myModal.present();
    }

    openDetailPage(item) {
        this.navCtrl.setRoot('page-de-tai-detail', { 'value': 'view-de-tai-' + item.ID });
        //this.navCtrl.push(DeTaiDetailPage, { 'id': item.ID });
        return false;
    }

    openSysnopsis(item) {
        let myModal = this.modalCtrl.create(DonXinNghiemThuModalPage, { 'idDeTai': item.ID }, { cssClass: 'preview-modal' });
        myModal.present();
    }

    loadedData() {
        this.items.forEach((i) => {
            i.NgayTaoText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
        })
    }

    add() {
        let item = {
            ID: 0,

        };
        this.openDetail(item);
    }
}
