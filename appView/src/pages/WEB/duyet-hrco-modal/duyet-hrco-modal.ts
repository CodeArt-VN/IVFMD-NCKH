import { Component } from '@angular/core';
import { ViewController, ModalController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_DeTaiCustomProvider, Sys_VarProvider } from '../../../providers/Services/CustomService';

import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-duyet-hrco-modal', priority: 'high', defaultHistory: ['page-duyet-hrco'] })
@Component({
    selector: 'duyet-hrco-modal',
    templateUrl: 'duyet-hrco-modal.html',
})
export class DuyetHrcoModalPage extends DetailPage {
    idDeTai: any;
    IDHinhThuc: any;
    hinhThucs = [];
    constructor(
        public currentProvider: PRO_DeTaiCustomProvider,
        public sysVarProvider: Sys_VarProvider,
        public modalCtrl: ModalController,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-duyet-hrco-modal');
        this.events.subscribe('app:Close-page-duyet-hrco-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }

        this.formGroup = formBuilder.group({
            IDHinhThuc: ['', Validators.compose([Validators.required])]
        });
        
        this.sysVarProvider.getByTypeOfVar(7)
        .then(values => {
            this.hinhThucs = values['data'];
            super.preLoadData();
        })
       
    }
    loadData() {
    }
    loadedData(){
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    updateSatus() {
      if (!this.formGroup.valid) {
        this.toastMessage('Vui lòng kiểm tra lại các thông tin được tô đỏ bên trên.');
      }
      else {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
          this.currentProvider.updateStatus(this.idDeTai, 'ApprovedHRCO', this.IDHinhThuc).then((savedItem: any) => {
            if (this.loading) this.loading.dismiss();
            this.dismiss();
            this.toastMessage('Đã duyệt!');
          }).catch(err => {
            console.log(err);
            if (this.loading) this.loading.dismiss();
            //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
          });
        })
      }
    }
}