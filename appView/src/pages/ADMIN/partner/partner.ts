import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PAR_PartnerProvider } from '../../../providers/Services/Services';
import { GlobalData } from '../../../providers/CORE/global-variable';
import { PartnerModalPage } from '../partner-modal/partner-modal';



@IonicPage({ name: 'page-partner', segment: 'partner', priority: 'high' })
@Component({ selector: 'page-partner', templateUrl: 'partner.html' })
export class PartnerPage extends ListPage {
    userprofile = null;

    FormGroups = [];
    Modules = [];
    CurrentModule = "Admin-PAR";
    constructor(
        public currentProvider: PAR_PartnerProvider,

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
        super('page-partner', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        

    
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

    loadedData(){
        GlobalData.Profile.Partners = [...this.items];
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(PartnerModalPage, { 'id': item.ID });
        myModal.present();
    }
    add() {
        let item = {
            ID: 0,
        };
        this.openDetail(item);
    }
    
}
