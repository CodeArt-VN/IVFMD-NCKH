import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { CAT_ThietLapThoiGianBaoCaoTDNCProvider } from '../../../providers/Services/CustomService';

@IonicPage({ name: 'page-thiet-lap-thoi-gian-bao-cao-tien-do-nghien-cuu', segment: 'thiet-lap-thoi-gian-bao-cao-tien-do-nghien-cuu', priority: 'high' }) 
@Component({ selector: 'page-thiet-lap-thoi-gian-bao-cao-tien-do-nghien-cuu', templateUrl: 'thiet-lap-thoi-gian-bao-cao-tien-do-nghien-cuu.html' })
export class ThietLapThoiGianBaoCaoTDNCPage extends ListPage {
    FormGroups = [];
    Modules = [];
    CurrentModule = "Admin-PAR";
    item = {
        ThoiGianBaoCaoTDNC:
        {
            GiaiDoan1_NgayBatDau: 0,
            GiaiDoan1_NgayKetThuc: 0,
            GiaiDoan2_NgayBatDau: 0,
            GiaiDoan2_NgayKetThuc: 0
        }
    };
    constructor(
        public currentProvider: CAT_ThietLapThoiGianBaoCaoTDNCProvider,

        public modalCtrl: ModalController,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
    ) {
        super('page-thiet-lap-thoi-gian-bao-cao-tien-do-nghien-cuu', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }

    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 3);
        this.Modules = this.getModules();
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
