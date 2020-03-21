import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { WEB_DanhMucProvider } from '../../../providers/Services/Services';
import { CateModalPage } from '../cate-modal/cate-modal';



@IonicPage({ name: 'page-cate', segment: 'cate', priority: 'high' }) 
@Component({ selector: 'page-cate', templateUrl: 'cate.html' })
export class CatePage extends ListPage {
    

    FormGroups = [];
    Modules = [];
    CurrentModule = "Admin-PAR";
    constructor(
        public currentProvider: WEB_DanhMucProvider,

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
        super('page-cate', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
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
        let myModal = this.modalCtrl.create(CateModalPage, { 'id': item.ID, IDPartner: this.query.IDPartner });
        myModal.present();
    }
    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    
}
