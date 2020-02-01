import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_BaoCaoNangSuatKhoaHocProvider } from '../../../providers/Services/Services';
import { PRO_BenhNhanCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DateAdapter } from "@angular/material";
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-bao-cao-nang-suat-khoa-hoc-modal', priority: 'high', defaultHistory: ['page-bao-cao-nang-suat-khoa-hoc'] })
@Component({
    selector: 'bao-cao-nang-suat-khoa-hoc-modal',
    templateUrl: 'bao-cao-nang-suat-khoa-hoc-modal.html',
})
export class BaoCaoNangSuatKhoaHocModalPage extends DetailPage {
    constructor(
        public currentProvider: PRO_BaoCaoNangSuatKhoaHocProvider,
        public benhNhanProvider: PRO_BenhNhanCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.dateAdapter.setLocale('vi');   
        this.pageName = "page-bao-cao-nang-suat-khoa-hoc";
        this.events.unsubscribe('app:Close-page-bao-cao-nang-suat-khoa-hoc-modal');
        this.events.subscribe('app:Close-page-bao-cao-nang-suat-khoa-hoc-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            TenDeTai: ['', Validators.compose([Validators.required])],
            TapChiHoiNghi: ['', Validators.compose([Validators.required])],
            KinhPhi: 0,
            IDKinhPhi: ['', Validators.compose([Validators.required])],
            IDSite: ['', Validators.compose([Validators.required])],
            IDNhom: ['', Validators.compose([Validators.required])],
            NgayBaoCao: [Date],
        });
    }

    preLoadData() {
        //Promise.all([
        //    this.staffProvider.read(),
        //    this.sysVarProvider.getByTypeOfVar(1),
        //    this.benhNhanProvider.getByDeTai(this.id),
        //    this.ncvKhacProvider.getByDeTai(this.id)
        //])
        //    .then(values => {
        //        this.staffs = values[0]['data'];
        //        this.typeOfTopics = values[1]['data'];
        //        this.lstBenhNhan = [...values[2]['data']];
        //        this.lstNCVKhac = [...values[3]['data']];
        //        super.preLoadData();
        //    })
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}