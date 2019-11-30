import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { CAT_BangGiaKinhPhiProvider } from '../../../providers/Services/Services';
import { BangGiaKinhPhiModalPage } from '../bang-gia-kinh-phi-modal/bang-gia-kinh-phi-modal';



@IonicPage({ name: 'page-bang-gia-kinh-phi', segment: 'bang-gia-kinh-phi', priority: 'high' }) 
@Component({ selector: 'page-bang-gia-kinh-phi', templateUrl: 'bang-gia-kinh-phi.html' })
export class BangGiaKinhPhiPage extends ListPage {
    

    FormGroups = [];

    constructor(
        public currentProvider: CAT_BangGiaKinhPhiProvider,

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
        super('page-bang-gia-kinh-phi', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
    }
    
    preLoadData(){
        
        this.FormGroups = this.userprofile.MenuItems.filter(d=>d.AppID==3);
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(BangGiaKinhPhiModalPage, { 'id': item.ID });
        myModal.present();
    }
    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    
}
