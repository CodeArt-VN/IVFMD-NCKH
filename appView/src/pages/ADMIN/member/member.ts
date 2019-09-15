import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { ACCOUNT_ApplicationUserProvider } from '../../../providers/Services/CustomService';
import { MemberModalPage } from '../member-modal/member-modal';



@IonicPage({ name: 'page-member', segment: 'member', priority: 'high' }) 
@Component({ selector: 'page-member', templateUrl: 'member.html' })
export class MemberPage extends ListPage {
    

    FormGroups = [];

    constructor(
        public currentProvider: ACCOUNT_ApplicationUserProvider,

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
        super('page-member', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
        
    }


    loadedData(){
        
        this.FormGroups = this.userprofile.MenuItems.filter(d=>d.AppID==3);
        this.items.forEach((i)=>{
            i.NgayTaoText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
            
            i.Roles.forEach(j=>{
                j.Name = j.RoleId=="HOST" ? "Host":"";
            })
        })
        super.loadedData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(MemberModalPage, { 'id': item.Email, IDPartner: this.query.IDPartner });
        myModal.present();
    }
    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    
}
