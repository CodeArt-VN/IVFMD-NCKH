import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { HRM_STAFF_NhanSuProvider } from '../../../providers/Services/Services';
import { StaffModalPage } from '../staff-modal/staff-modal';



@IonicPage({ name: 'page-staff', segment: 'staff', priority: 'high' }) 
@Component({ selector: 'page-staff', templateUrl: 'staff.html' })
export class StaffPage extends ListPage {
    

    FormGroups = [];

    constructor(
        public currentProvider: HRM_STAFF_NhanSuProvider,

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
        super('page-staff', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
    }

    preLoadData(){
        
        this.FormGroups = this.userprofile.MenuItems.filter(d=>d.AppID==3);
        super.preLoadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(StaffModalPage, { 'id': item.ID, IDPartner: this.query.IDPartner });
        myModal.present();
    }
    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    copy(){
        super.copy();
    }
    
}
