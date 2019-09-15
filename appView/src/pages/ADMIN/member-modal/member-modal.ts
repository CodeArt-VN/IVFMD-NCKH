import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ACCOUNT_ApplicationUserProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';

@IonicPage({ name: 'page-member-modal', priority: 'high', defaultHistory: ['page-member'] })
@Component({
    selector: 'member-modal',
    templateUrl: 'member-modal.html',
})
export class MemberModalPage extends DetailPage {
    constructor(
        public currentProvider: ACCOUNT_ApplicationUserProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-member";
        this.events.unsubscribe('app:Close-page-member-modal');
        this.events.subscribe('app:Close-page-member-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Code: ['', Validators.compose([Validators.required])],
            Email: ['', Validators.compose([Validators.required])],
            TenDayDu: ['', Validators.compose([Validators.required])],
            TenVietTat: [''],
            IDRole: [''],
        });
    }

    toTitleCase(str) {
        return str.replace(/\w\S*/g, function(txt){
            return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
        });
    }
    roles = [];
    preLoadData(){
        // this.roleProvider.read().then((result:any) =>{
        //     this.roles = result.data;
        // })
        super.preLoadData();
    }

    loadedData(){
        if(!this.item.IDPartner){
            this.item.IDPartner = this.navParams.data.IDPartner;
        }
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}