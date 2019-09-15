import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { SYS_RoleProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-role-modal', priority: 'high', defaultHistory: ['page-role'] })
@Component({
    selector: 'role-modal',
    templateUrl: 'role-modal.html',
})
export class RoleModalPage extends DetailPage {
    constructor(
        public currentProvider: SYS_RoleProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-role";
        this.events.unsubscribe('app:Close-page-role-modal');
        this.events.subscribe('app:Close-page-role-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Code: ['', Validators.compose([Validators.required])],
            Name: ['', Validators.compose([Validators.required])],
            Remark: [''],
            Sort: [''],
        });
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