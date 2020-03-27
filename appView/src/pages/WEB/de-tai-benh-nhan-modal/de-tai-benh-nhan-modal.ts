import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_BenhNhanProvider, HRM_BenhNhanProvider } from '../../../providers/Services/Services';
import { PRO_BenhNhanCustomProvider } from '../../../providers/Services/CustomService';

import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-de-tai-benh-nhan-modal', priority: 'high', defaultHistory: ['page-de-tai-benh-nhan'] })
@Component({
    selector: 'de-tai-benh-nhan-modal',
    templateUrl: 'de-tai-benh-nhan-modal.html',
})
export class DeTaiBenhNhanModalPage extends DetailPage {
    idDeTai: any;
    isNew: any;
    benhNhans = [];
    constructor(
        public currentProvider: PRO_BenhNhanProvider,
        public hrmBenhNhanProvider: HRM_BenhNhanProvider,
        public proBenhNhanCustomProvider: PRO_BenhNhanCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-de-tai-benh-nhan-modal');
        this.events.subscribe('app:Close-page-de-tai-benh-nhan-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }

        this.isNew = navParams.get('isNew');
        if (this.isNew && commonService.isNumeric(this.isNew)) {
            this.isNew = parseInt(this.isNew, 10);
        }

        if (this.isNew == 0)
        {
            this.formGroup = formBuilder.group({
                IDBenhNhan: ['', Validators.compose([Validators.required])]
            });
            
            Promise.all([
                this.hrmBenhNhanProvider.read()
            ])
            .then(values => {
                this.benhNhans = values[0]['data'];
                super.preLoadData();
            })
        }
        else {
            this.formGroup = formBuilder.group({
                MaBenhNhan: ['', Validators.compose([Validators.required])],
                TenBenhNhan: ['', Validators.compose([Validators.required])],
                GioiTinh: ['', Validators.compose([Validators.required])]
            });
            super.preLoadData();
        }

    }
    loadData() {
      if(this.id){
          this.currentProvider.getAnItem(this.id, this._uid).then((ite) => {
              this.commonService.copyPropertiesValue(ite, this.item);
          }).catch((data) => {
              this.item.ID = 0;
              this.item.IDDeTai = this.idDeTai;
          });
      }
      else{
          this.item.ID = 0;
          this.item.IDDeTai = this.idDeTai;
      }
    }
    loadedData(){
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    createBN() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.proBenhNhanCustomProvider.saveCustom(this.item).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã lưu xong!');
                this.dismiss();
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Không lưu được, \nvui lòng thử lại.');
            });
        })
    };
}