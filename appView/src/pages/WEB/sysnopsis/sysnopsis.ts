import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_SysnopsisCustomProvider } from '../../../providers/Services/CustomService';
import { BasePage } from '../../base-page';

@IonicPage({ name: 'page-sysnopsis', segment: 'sysnopsis/:id/:idDetai', priority: 'high' }) 
@Component({ selector: 'page-sysnopsis', templateUrl: 'sysnopsis.html' })
export class SysnopsisPage extends BasePage {
    id: any;
    idDetai: any;
    _uid: string;
    item: any;
    submitAttempt: boolean = false;
    FormGroups = [];

    constructor(
        public currentProvider: PRO_SysnopsisCustomProvider,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
    ) {
        super('page-sysnopsis', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);

        debugger
        this.id = navParams.get('id');
        if (this.id && commonService.isNumeric(this.id)) {
            this.id = parseInt(this.id, 10);
        }
        this.idDetai = navParams.get('idDetai');
        if (this.idDetai && commonService.isNumeric(this.idDetai)) {
            this.idDetai = parseInt(this.idDetai, 10);
        }
        if (this.idDetai == undefined || this.id == undefined) {
            commonService.getLocal('page-sysnopsis').then(item => {
                if (commonService.isNumeric(item.id)) {
                    this.id = parseInt(item.id, 10);
                }
                if (commonService.isNumeric(item.idDetai)) {
                    this.idDetai = parseInt(item.idDetai, 10);
                }
            });
        }
        if (!this.item) {
            this.item = {}
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idDetai).then((ite) => {
            this.commonService.copyPropertiesValue(ite, this.item);
        }).catch((data) => {
            this.item.ID = 0;
        });
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        super.preLoadData();
    }

    loadedData() {

    }
}
