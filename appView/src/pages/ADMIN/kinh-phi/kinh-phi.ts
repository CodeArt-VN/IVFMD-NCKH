import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { CAT_KinhPhiProvider } from '../../../providers/Services/Services';
import { KinhPhiModalPage } from '../kinh-phi-modal/kinh-phi-modal';



@IonicPage({ name: 'page-kinh-phi', segment: 'kinh-phi', priority: 'high' }) 
@Component({ selector: 'page-kinh-phi', templateUrl: 'kinh-phi.html' })
export class KinhPhiPage extends ListPage {
    

    FormGroups = [];
    Modules = [];
    CurrentModule = "Admin-PAR";
    constructor(
        public currentProvider: CAT_KinhPhiProvider,

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
        super('page-kinh-phi', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
    }
    
    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 3);
        this.Modules = this.getModules();
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(KinhPhiModalPage, { 'id': item.ID });
        myModal.present();
    }
    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    
}
