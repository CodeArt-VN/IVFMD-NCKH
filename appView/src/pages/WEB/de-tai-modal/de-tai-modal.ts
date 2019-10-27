import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_DeTaiProvider, HRM_STAFF_NhanSuProvider} from '../../../providers/Services/Services';
import { Sys_VarProvider, PRO_BenhNhanCustomProvider, PRO_NCVKhacCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-de-tai-modal', priority: 'high', defaultHistory: ['page-de-tai'] })
@Component({
    selector: 'de-tai-modal',
    templateUrl: 'de-tai-modal.html',
})
export class DeTaiModalPage extends DetailPage {
    tab = '1';
    staffs = [];
    typeOfTopics = [];
    lstBenhNhan: any[] = [];
    lstNCVKhac: any[] = [];
    constructor(
        public currentProvider: PRO_DeTaiProvider,
        public staffProvider: HRM_STAFF_NhanSuProvider,
        public sysVarProvider: Sys_VarProvider,
        public benhNhanProvider: PRO_BenhNhanCustomProvider,
        public ncvKhacProvider: PRO_NCVKhacCustomProvider,
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
          IDChuNhiem: ['', Validators.compose([Validators.required])],
          IDPhanLoaiDeTai: ['', Validators.compose([Validators.required])]
        });
    }

    preLoadData() {
        Promise.all([
            this.staffProvider.read(),
            this.sysVarProvider.getByTypeOfVar(1),
            this.benhNhanProvider.getByDeTai(this.id),
            this.ncvKhacProvider.getByDeTai(this.id)
        ])
            .then(values => {
                this.staffs = values[0]['data'];
                this.typeOfTopics = values[1]['data'];
                this.lstBenhNhan = [...values[2]['data']];
                this.lstNCVKhac = [...values[3]['data']];
                super.preLoadData();
            })
    }

    loadedData(){
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}