import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_HoiNghiHoiThaoDangKyCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DateAdapter } from "@angular/material";
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao-modal', priority: 'high', defaultHistory: ['page-hoi-nghi-hoi-thao'] })
@Component({
    selector: 'hoi-nghi-hoi-thao-modal',
    templateUrl: 'hoi-nghi-hoi-thao-modal.html',
})
export class HoiNghiHoiThaoModalPage extends DetailPage {
    lstRow: any[] = [];
    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoDangKyCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-hoi-nghi-hoi-thao";
        this.events.unsubscribe('app:Close-page-hoi-nghi-hoi-thao-modal');
        this.events.subscribe('app:Close-page-hoi-nghi-hoi-thao-modal', () => {
            this.dismiss();
        });
    }

    preLoadData() {
        this.currentProvider.getListChuaDangKy().then((result: any) => {
            this.lstRow = [...result];
            this.lstRow.forEach((i) => {
                i.ThoiGianText = this.commonService.dateFormat(i.ThoiGian, 'dd/mm/yy hh:MM');
                i.ThoiGianHetHanText = this.commonService.dateFormat(i.ThoiGianHetHan, 'dd/mm/yy hh:MM');
                i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
            })
        });
    }

    resgister(item) {
        if (item.CoTheDangKy == true) {
            let confirm = this.alertCtrl.create({
                title: "Xác nhận đăng ký",
                message: 'Bạn chắc muốn đăng ký tham gia Hội nghị này?',
                buttons: [
                    {
                        text: 'Hủy',
                        handler: () => {

                        }
                    },
                    {
                        text: 'Đồng ý',
                        handler: () => {
                            let obj = { IDHoiNghiHoiThao: item.ID };
                            this.currentProvider.save(obj).then((savedItem: any) => {
                                if (this.loading) this.loading.dismiss();
                                this.events.publish('app:Update' + this.pageName);
                                console.log('publish => app:Update ' + this.pageName);
                                this.preLoadData();
                                this.toastMessage('Đăng ký thành công!');
                                this.savedChange();
                            }).catch(err => {
                                console.log(err);
                                if (this.loading) this.loading.dismiss();
                                this.savedChange();
                            });
                        }
                    }
                ]
            });
            confirm.present();
        }
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