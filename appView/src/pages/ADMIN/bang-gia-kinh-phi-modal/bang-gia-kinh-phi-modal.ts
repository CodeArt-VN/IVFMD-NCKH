import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { CAT_NhomProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-bang-gia-kinh-phi-modal', priority: 'high', defaultHistory: ['page-bang-gia-kinh-phi-modal'] })
@Component({
    selector: 'bang-gia-kinh-phi-modal',
    templateUrl: 'bang-gia-kinh-phi-modal.html',
})
export class BangGiaKinhPhiModalPage extends DetailPage {
    constructor(
        public currentProvider: CAT_NhomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "bang-gia-kinh-phi-modal";
        this.events.unsubscribe('app:Close-page-bang-gia-kinh-phi-modal');
        this.events.subscribe('app:Close-page-bang-gia-kinh-phi-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Code: ['', Validators.compose([Validators.required])],
            Name: ['', Validators.compose([Validators.required])],
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