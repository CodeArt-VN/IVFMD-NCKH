import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { STAFF_NhanSu_LLKHProviderCustomProvider, PRO_LLKHCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';

@IonicPage({ name: 'page-nhan-su-llkh-input-modal', priority: 'high', defaultHistory: ['page-nhan-su-llkh-input-modal'] })
@Component({
    selector: 'nhan-su-llkh-input-modal',
    templateUrl: 'nhan-su-llkh-input-modal.html',
})
export class NhanSuLLKHInputModalPage extends DetailPage {
    idNhanSu: any;
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: STAFF_NhanSu_LLKHProviderCustomProvider,
        public proLLKHProvider: PRO_LLKHCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,

        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-nhan-su-llkh-input-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-nhan-su-llkh-input-modal";
        this.events.unsubscribe('app:Close-nhan-su-llkh-input-modal');
        this.events.subscribe('app:Close-nhan-su-llkh-input-modal', () => {
            this.dismiss();
        });
        this.idNhanSu = navParams.get('idNhanSu');
        if (this.idNhanSu && commonService.isNumeric(this.idNhanSu)) {
            this.idNhanSu = parseInt(this.idNhanSu, 10);
        }

        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
        else {
            this.idDeTai = -1;
        }
    }

    loadData() {
        if (this.idDeTai > 0) {
            this.proLLKHProvider.getItemCustom(this.idDeTai, this.idNhanSu).then((ite) => {
                this.item = ite;
                this.loadedData();
            }).catch((data) => {
                this.item.ID = 0;
                this.loadedData();
            });
        }
        else {
            this.currentProvider.getItemCustom(this.idNhanSu).then((ite) => {
                this.item = ite;
                this.loadedData();
            }).catch((data) => {
                this.item.ID = 0;
                this.loadedData();
            });
        }
    }

    loadedData() {
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        let id = this.item.ID;
    };

    tableAdd(Prop) {
        debugger
        switch (Prop) {
            case "ListNgoaiNgu":
                this.item.ListNgoaiNgu.push({ NgoaiNgu: '', NgheTot: '', NgheKha: '', NgheTB: '', NoiTot: '', NoiKha: '', NoiTB: '', VietTot: '', VietKha: '', VietTB: '', DocTot: '', DocKha: '', DocTB:'' });
                break;
        }
    }

    tableDelete(Prop) {
        switch (Prop) {
            case "ListNgoaiNgu":
                var anchorNode = window.getSelection().anchorNode;
                if (anchorNode) {
                    debugger
                }
                break;
        }
    }

    saveChange() {
        console.log(this.item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            if (this.idDeTai > 0) {
                this.proLLKHProvider.saveCustom(this.item).then((savedItem: any) => {
                    this.item.ID = savedItem.ID;
                    if (this.loading) this.loading.dismiss();
                    this.events.publish('app:Update' + this.pageName);
                    console.log('publish => app:Update ' + this.pageName);
                    this.toastMessage('Đã lưu xong!');
                }).catch(err => {
                    console.log(err);
                    if (this.loading) this.loading.dismiss();
                    this.toastMessage('Không lưu được, \nvui lòng thử lại.');
                });
            }
            else {
                this.currentProvider.saveCustom(this.item).then((savedItem: any) => {
                    this.item.ID = savedItem.ID;
                    if (this.loading) this.loading.dismiss();
                    this.events.publish('app:Update' + this.pageName);
                    console.log('publish => app:Update ' + this.pageName);
                    this.toastMessage('Đã lưu xong!');
                }).catch(err => {
                    console.log(err);
                    if (this.loading) this.loading.dismiss();
                    this.toastMessage('Không lưu được, \nvui lòng thử lại.');
                });
            }
        })
    };

    print() {
        
    };
}