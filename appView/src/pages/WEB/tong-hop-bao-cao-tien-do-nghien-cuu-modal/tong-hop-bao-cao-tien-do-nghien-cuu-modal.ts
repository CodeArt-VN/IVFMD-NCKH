import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_BaoCaoTienDoNghienCuuCustomProvider, } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-tong-hop-bao-cao-tien-do-nghien-cuu-modal', priority: 'high', defaultHistory: ['page-tong-hop-bao-cao-tien-do-nghien-cuu'] })
@Component({
    selector: 'tong-hop-bao-cao-tien-do-nghien-cuu-modal',
    templateUrl: 'tong-hop-bao-cao-tien-do-nghien-cuu-modal.html',
})
export class TongHopBaoCaoTienDoNghienCuuModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_BaoCaoTienDoNghienCuuCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-tong-hop-bao-cao-tien-do-nghien-cuu";
        this.events.unsubscribe('app:Close-page-tong-hop-bao-cao-tien-do-nghien-cuu-modal');
        this.events.subscribe('app:Close-page-tong-hop-bao-cao-tien-do-nghien-cuu-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            SoCaThuThapHopLe: ['', Validators.compose([Validators.required])],
            TienDoThuNhanMau: ['', Validators.compose([Validators.required])],
            KhoKhan: [''],
            TenDeTai: [''],
            ChuNhiemDeTai: [''],
            NCVChinh: [''],
            SoNCT: [''],
            ThoiGianTienHanh: [''],
            CoMau: [''],
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
    }

    loadData() {
        if (this.id) {
            debugger
            this.currentProvider.getAnItem(this.id, this._uid).then((ite) => {
                this.commonService.copyPropertiesValue(ite, this.item);
            }).catch((data) => {
                this.item.ID = 0;
                this.item.IDDeTai = this.idDeTai;
            });
        }
        else {
            this.item.ID = 0;
            this.item.IDDeTai = this.idDeTai;
        }
    }

    loadedData() {
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}