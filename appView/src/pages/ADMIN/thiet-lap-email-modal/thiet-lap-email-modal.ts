import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { CAT_ThietLapEmailProvider, } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-thiet-lap-email-modal', priority: 'high', defaultHistory: ['page-thiet-lap-email'] })
@Component({
    selector: 'thiet-lap-email-modal',
    templateUrl: 'thiet-lap-email-modal.html',
})
export class ThietLapEmailModalPage extends DetailPage {
    code: any;
    constructor(
        public currentProvider: CAT_ThietLapEmailProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.code = navParams.get('code');
        this.pageName = "page-thiet-lap-email";
        this.events.unsubscribe('app:Close-page-thiet-lap-email-modal');
        this.events.subscribe('app:Close-page-thiet-lap-email-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Subject: ['', Validators.compose([Validators.required])],
            Body: ['', Validators.compose([Validators.required])],
            EmailList: ''
        });
    }

    loadData() {
        if (this.code) {
            this.currentProvider.get(this.code).then((ite) => {
                this.commonService.copyPropertiesValue(ite, this.item);
            }).catch((data) => {
                this.item.ID = 0;
            });
        }
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    saveChange() {
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