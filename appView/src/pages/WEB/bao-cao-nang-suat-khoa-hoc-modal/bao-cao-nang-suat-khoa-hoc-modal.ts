import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_BaoCaoNangSuatKhoaHocCustomProvider } from '../../../providers/Services/CustomService';
import { CAT_KinhPhiProvider } from '../../../providers/Services/Services';
import { CAT_NhomProvider } from '../../../providers/Services/Services';
import { CAT_SiteProvider } from '../../../providers/Services/Services';
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
    kinhphis = [];
    sites = [];
    nhoms = [];
    canApprove = false;
    constructor(
        public currentProvider: PRO_BaoCaoNangSuatKhoaHocCustomProvider,
        public kinhphiProvider: CAT_KinhPhiProvider,
        public nhomProvider: CAT_NhomProvider,
        public siteProvider: CAT_SiteProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.dateAdapter.setLocale('vi');   
        this.canApprove = navParams.get('canApprove');
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
            GhiChuKinhPhi: '',
        });
    }

    preLoadData() {
        Promise.all([
            this.kinhphiProvider.read(),
            this.siteProvider.read(),
            this.nhomProvider.read(),
        ])
            .then(values => {
                this.kinhphis = values[0]['data'];
                this.sites = values[1]['data'];
                this.nhoms = values[2]['data'];
                super.preLoadData();
            })
    }

    updateStatus(action) {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.updateStatus(this.item.ID, action).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        })
    }

    loadedData() {
        if (this.item.ID == 0)
            this.item.IsKinhPhiManual = false;
    }

    onChangeKinhPhi(e) {
        debugger
        this.item.GhiChuKinhPhi = this.getAttrib(this.item.IDKinhPhi, this.kinhphis, 'GhiChu', '');
        this.item.IsKinhPhiManual = this.getAttrib(this.item.IDKinhPhi, this.kinhphis, 'IsManual', '');
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}