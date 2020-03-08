import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_HoiNghiHoiThaoProvider } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DateAdapter } from "@angular/material";
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao-hrco-modal', priority: 'high', defaultHistory: ['page-hoi-nghi-hoi-thao-hrco'] })
@Component({
    selector: 'hoi-nghi-hoi-thao-hrco-modal',
    templateUrl: 'hoi-nghi-hoi-thao-hrco-modal.html',
})
export class HoiNghiHoiThaoHRCOModalPage extends DetailPage {
    kinhphis = [];
    sites = [];
    nhoms = [];
    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.dateAdapter.setLocale('vi');   
        this.pageName = "page-hoi-nghi-hoi-thao-hrco";
        this.events.unsubscribe('app:Close-page-hoi-nghi-hoi-thao-hrco-modal');
        this.events.subscribe('app:Close-page-hoi-nghi-hoi-thao-hrco-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            DiaDiem: ['', Validators.compose([Validators.required])],
            TenHoiNghi: ['', Validators.compose([Validators.required])],
            ThoiGian: [Date],
            ThoiGianHetHan: [Date],
            IsDisabled: ''
        });
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}