import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_BaoCaoNangSuatKhoaHocProvider } from '../../../providers/Services/Services';
import { BaoCaoNangSuatKhoaHocModalPage } from '../bao-cao-nang-suat-khoa-hoc-modal/bao-cao-nang-suat-khoa-hoc-modal';
@IonicPage({ name: 'page-bao-cao-nang-suat-khoa-hoc', segment: 'bao-cao-nang-suat-khoa-hoc', priority: 'high' }) 
@Component({ selector: 'page-bao-cao-nang-suat-khoa-hoc', templateUrl: 'bao-cao-nang-suat-khoa-hoc.html' })
export class BaoCaoNangSuatKhoaHocPage extends ListPage {
    FormGroups = [];
    constructor(
        public currentProvider: PRO_BaoCaoNangSuatKhoaHocProvider,

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
    }
    
    preLoadData(){
        
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(BaoCaoNangSuatKhoaHocModalPage, { 'id': item.ID });
        myModal.present();
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
