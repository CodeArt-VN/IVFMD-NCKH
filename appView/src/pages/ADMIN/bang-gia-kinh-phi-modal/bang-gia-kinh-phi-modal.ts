import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { CAT_BangGiaKinhPhiProvider, CAT_KinhPhiProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import { DateAdapter } from "@angular/material";

@IonicPage({ name: 'page-bang-gia-kinh-phi-modal', priority: 'high', defaultHistory: ['page-bang-gia-kinh-phi-modal'] })
@Component({
    selector: 'bang-gia-kinh-phi-modal',
    templateUrl: 'bang-gia-kinh-phi-modal.html',
})
export class BangGiaKinhPhiModalPage extends DetailPage {
    kinhPhis = [];

    constructor(
        public currentProvider: CAT_BangGiaKinhPhiProvider,
        public viewCtrl: ViewController,
        public kinhPhiProvider: CAT_KinhPhiProvider,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider, private dateAdapter: DateAdapter<Date>
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "bang-gia-kinh-phi-modal";
        this.dateAdapter.setLocale('vi');   
        this.events.unsubscribe('app:Close-page-bang-gia-kinh-phi-modal');
        this.events.subscribe('app:Close-page-bang-gia-kinh-phi-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            NgayHieuLuc: ['', Validators.compose([Validators.required])],
            Gia: ['', Validators.compose([Validators.required])],
            IDKinhPhi: [''],
        });
    }

    preLoadData() {
        Promise.all([
            this.kinhPhiProvider.read()
        ])
            .then(values => {
                this.kinhPhis = values[0]['data'];
                super.preLoadData();
            })
    }

    savedChange() {
        this.events.publish('app:Update' + 'page-bang-gia-kinh-phi');
    }

    loadedData(){
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}