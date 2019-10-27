import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_DeTaiProvider } from '../../../providers/Services/Services';
import { DeTaiModalPage } from '../de-tai-modal/de-tai-modal';
import { SysnopsisPage } from '../sysnopsis/sysnopsis';
import { SysnopsisModalPage } from '../sysnopsis-modal/sysnopsis-modal';



@IonicPage({ name: 'page-de-tai', segment: 'de-tai', priority: 'high' }) 
@Component({ selector: 'page-de-tai', templateUrl: 'de-tai.html' })
export class DeTaiPage extends ListPage {
    

    FormGroups = [];

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
        public accountService: AccountServiceProvider,
    ) {
        super('page-de-tai', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
    }
    
    preLoadData(){
        
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(DeTaiModalPage, { 'id': item.ID });
        myModal.present();
    }

    openSysnopsis(item) {
        let myModal = this.modalCtrl.create(SysnopsisModalPage, { 'id': 0, 'idDeTai': item.ID }, { cssClass: 'preview-modal' });
        myModal.present();
    }

    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    
}
