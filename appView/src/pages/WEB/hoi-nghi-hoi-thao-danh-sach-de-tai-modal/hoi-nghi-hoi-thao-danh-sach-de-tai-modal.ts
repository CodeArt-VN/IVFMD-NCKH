import { Component } from '@angular/core';
import { ViewController, ModalController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_HoiNghiHoiThaoDangKyCustomProvider } from '../../../providers/Services/CustomService';
import { PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import { GlobalData } from '../../../providers/CORE/global-variable'
import 'jqueryui';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao-danh-sach-de-tai-modal', priority: 'high', defaultHistory: ['hoi-nghi-hoi-thao-danh-sach-de-tai-modal'] })
@Component({
    selector: 'hoi-nghi-hoi-thao-danh-sach-de-tai-modal',
    templateUrl: 'hoi-nghi-hoi-thao-danh-sach-de-tai-modal.html',
})
export class HoiNghiHoiThaoDanhSachDeTaiModalPage extends DetailPage {
    idHoiNghi: any;
    selected: any[] = [];
    lstRow: any[] = [];
    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoDangKyCustomProvider,
        public currentDeTaiProvider: PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider,
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
        this.currentProvider.getListDeTaiByHoiNghi(this.idHoiNghi).then((result: any) => {
            this.lstRow = [...result];
            this.lstRow.forEach((i) => {
                i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
            })
        });
    }

    onSelect({ selected }) {
        this.selected.splice(0, this.selected.length);
        this.selected.push(...selected);
    }

    action(actionCode) {
        let title = "Xác nhận duyệt";
        let message = 'Bạn chắc muốn duyệt đề tài đang được chọn?';
        if (actionCode == "UnApproved") {
            title = "Xác nhận hủy duyệt";
            message = 'Bạn chắc muốn hủy duyệt đề tài đang được chọn?';
        }
        let confirm = this.alertCtrl.create({
            title: title,
            message: message,
            buttons: [
                {
                    text: 'Không',
                    handler: () => {
                    }
                },
                {
                    text: 'Đồng ý',
                    handler: () => {
                        var seletedItems = [...this.selected];
                        for (var i = 0; i < seletedItems.length; i++) {
                            var ite = seletedItems[i];
                            this.loadingMessage('Lưu dữ liệu...').then(() => {
                                this.currentDeTaiProvider.updateStatus(ite.ID, actionCode).then((savedItem: any) => {
                                    if (this.loading) this.loading.dismiss();
                                    this.toastMessage('Đã cập nhật!');
                                    this.preLoadData();
                                }).catch(err => {
                                    console.log(err);
                                    if (this.loading) this.loading.dismiss();
                                    //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
                                });
                            })
                        }
                    }
                }
            ]
        });
        confirm.present();
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