import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { SYS_RoleProvider } from '../../../providers/Services/Services';
import { RoleModalPage } from '../role-modal/role-modal';



@IonicPage({ name: 'page-role', segment: 'role', priority: 'high' }) 
@Component({ selector: 'page-role', templateUrl: 'role.html' })
export class RolePage extends ListPage {
    

    FormGroups = [];

    constructor(
        public currentProvider: SYS_RoleProvider,

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
        super('page-role', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
    }
    
    preLoadData(){
        
        this.FormGroups = this.userprofile.MenuItems.filter(d=>d.AppID==3);
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(RoleModalPage, { 'id': item.ID, IDPartner: this.query.IDPartner });
        myModal.present();
    }
    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    
}
