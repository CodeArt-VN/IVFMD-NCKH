import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { CAT_ThietLapThoiGianBaoCaoNSKHProvider } from '../../../providers/Services/CustomService';
import { DateAdapter } from "@angular/material";

@IonicPage({ name: 'page-thiet-lap-thoi-gian-bao-cao-nskh', segment: 'thiet-lap-thoi-gian-bao-cao-nskh', priority: 'high' }) 
@Component({ selector: 'page-thiet-lap-thoi-gian-bao-cao-nskh', templateUrl: 'thiet-lap-thoi-gian-bao-cao-nskh.html' })
export class ThietLapThoiGianBaoCaoNSKHPage extends ListPage {
    FormGroups = [];
    item = {
        ThoiGianBaoCaoNSKH: {
            NgayBatDau: null,
            NgayKetThuc: null,
        }
    };
    constructor(
        public currentProvider: CAT_ThietLapThoiGianBaoCaoNSKHProvider,

        public modalCtrl: ModalController,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {
        super('page-thiet-lap-thoi-gian-bao-cao-nskh', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.dateAdapter.setLocale('vi');  
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 3);
        super.preLoadData();
    }

    loadData() {
        this.currentProvider.get().then((result: any) => {
            this.item = result;
        });
    }

    saveCustom() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.saveCustom(this.item).then((result: any) => {
                this.item = result;
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        });
    }
}
