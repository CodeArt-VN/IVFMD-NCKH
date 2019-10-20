import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_DeTaiProvider, HRM_STAFF_NhanSuProvider} from '../../../providers/Services/Services';
import { Sys_VarProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-de-tai-modal', priority: 'high', defaultHistory: ['page-de-tai'] })
@Component({
    selector: 'de-tai-modal',
    templateUrl: 'de-tai-modal.html',
})
export class DeTaiModalPage extends DetailPage {
    staffs = [];
    typeOfTopics = [];
    constructor(
        public currentProvider: PRO_DeTaiProvider,
        public staffProvider: HRM_STAFF_NhanSuProvider,
        public sysVarProvider: Sys_VarProvider,
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
            this.sysVarProvider.getByTypeOfVar(1)
        ])
            .then(values => {
                this.staffs = values[0]['data'];
                this.typeOfTopics = values[1]['data'];
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