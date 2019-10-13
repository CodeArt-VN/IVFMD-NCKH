import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_DeTaiProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-de-tai-modal', priority: 'high', defaultHistory: ['page-de-tai'] })
@Component({
    selector: 'de-tai-modal',
    templateUrl: 'de-tai-modal.html',
})
export class DeTaiModalPage extends DetailPage {
    constructor(
        public currentProvider: PRO_DeTaiProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-de-tai-modal');
        this.events.subscribe('app:Close-page-de-tai-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
          MaSo: ['', Validators.compose([Validators.required])],
          DeTai: ['', Validators.compose([Validators.required])],
          TenTiengViet: ['', Validators.compose([Validators.required])],
          TenTiengAnh: ['', Validators.compose([Validators.required])],
          SoNCT: [''],
          GhiChu: [''],
          Sort: ['']
        });
    }

    loadedData(){
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}