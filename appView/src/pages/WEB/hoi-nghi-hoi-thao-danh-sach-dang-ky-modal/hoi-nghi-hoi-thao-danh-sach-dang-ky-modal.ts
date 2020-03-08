import { Component } from '@angular/core';
import { ViewController, ModalController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_HoiNghiHoiThaoDangKyCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import { GlobalData } from '../../../providers/CORE/global-variable'
import 'jqueryui';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao-danh-sach-dang-ky-modal', priority: 'high', defaultHistory: ['hoi-nghi-hoi-thao-danh-sach-dang-ky-modal'] })
@Component({
    selector: 'hoi-nghi-hoi-thao-danh-sach-dang-ky-modal',
    templateUrl: 'hoi-nghi-hoi-thao-danh-sach-dang-ky-modal.html',
})
export class HoiNghiHoiThaoDanhSachDangKyModalPage extends DetailPage {
    idHoiNghi: any;
    lstRow: any[] = [];
    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoDangKyCustomProvider,
        public modalCtrl: ModalController,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.idHoiNghi = navParams.get('idHoiNghi'); 
        this.pageName = "page-hoi-nghi-hoi-thao-hrco";
        if (this.idHoiNghi && commonService.isNumeric(this.idHoiNghi)) {
            this.idHoiNghi = parseInt(this.idHoiNghi, 10);
        }
    }
    preLoadData() {
        this.currentProvider.getListByHoiNghi(this.idHoiNghi).then((result: any) => {
            this.lstRow = [...result];
            this.lstRow.forEach((i) => {
                i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
            })
        });
    }

    loadData() {
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}