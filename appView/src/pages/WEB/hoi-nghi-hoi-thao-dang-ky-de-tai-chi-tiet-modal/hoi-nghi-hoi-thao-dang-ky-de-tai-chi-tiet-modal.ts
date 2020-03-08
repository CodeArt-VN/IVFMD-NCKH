import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DateAdapter } from "@angular/material";
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal', priority: 'high', defaultHistory: ['page-hoi-nghi-hoi-thao'] })
@Component({
    selector: 'hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal',
    templateUrl: 'hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal.html',
})
export class HoiNghiHoiThaoDangKyDeTaiChiTietModalPage extends DetailPage {
    hinhThucDangKyList = [
        { 'ID': 49, 'Code': 'HinhThucDangKy_Oral', 'ValueOfVar': 'Oral' },
        { 'ID': 50, 'Code': 'HinhThucDangKy_Poster', 'ValueOfVar': 'Poster' },
    ];
    idDangKy: any;
    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.idDangKy = navParams.get('idDangKy');
        this.pageName = "page-hoi-nghi-hoi-thao";
        this.events.unsubscribe('app:Close-page-hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal');
        this.events.subscribe('app:Close-page-hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            TenDeTai: ['', Validators.compose([Validators.required])],
            IDHinhThucDangKy: ['', Validators.compose([Validators.required])],
        });
    }

    preLoadData() {
        if (this.id == 0) {
            this.item.IDDangKy = this.idDangKy;
            this.item.IDHinhThucDangKy = this.hinhThucDangKyList[0].ID;
        } else this.loadData();
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}