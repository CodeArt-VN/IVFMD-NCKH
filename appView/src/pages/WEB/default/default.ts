import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { CAT_KinhPhiProvider } from '../../../providers/Services/Services';

@IonicPage({ name: 'page-default', segment: 'default', priority: 'high' }) 
    @Component({ selector: 'page-default', templateUrl: 'default.html' })
export class DefaultPage extends ListPage {
    FormGroups = [];
    Modules = [];
    ListMenu = [];
    CurrentModule = "Home"; 
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
        super('page-default', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }
    
    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.FormGroups = [];
        this.Modules = this.getModules();
        this.ListMenu = this.getModules(true);
    }

    gotoPage(menu) {
        this.navCtrl.setRoot(menu.Code);
    }

    loadData() {

    }

    loadedData() {

    }
}
