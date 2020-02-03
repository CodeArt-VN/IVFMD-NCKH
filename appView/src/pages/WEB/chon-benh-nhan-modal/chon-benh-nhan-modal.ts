import { Component } from '@angular/core';
import { ViewController, ModalController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_BenhNhanProvider, HRM_BenhNhanProvider } from '../../../providers/Services/Services';
import { PRO_BenhNhanCustomProvider } from '../../../providers/Services/CustomService';
import { AEModalPage } from '../ae-modal/ae-modal';
import { SAEModalPage } from '../sae-modal/sae-modal';

import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-chon-benh-nhan-modal', priority: 'high', defaultHistory: ['page-chon-benh-nhan'] })
@Component({
    selector: 'chon-benh-nhan-modal',
    templateUrl: 'chon-benh-nhan-modal.html',
})
export class ChonBenhNhanModalPage extends DetailPage {
    idDeTai: any;
    type: any;
    idBenhNhan: any;
    isNew: any;
    benhNhans = [];
    constructor(
        public currentProvider: PRO_BenhNhanProvider,
        public proBenhNhanCustomProvider: PRO_BenhNhanCustomProvider,
        public modalCtrl: ModalController,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-tags";
        this.events.unsubscribe('app:Close-page-chon-benh-nhan-modal');
        this.events.subscribe('app:Close-page-chon-benh-nhan-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }

        this.type = navParams.get('type');
        if (this.type && commonService.isNumeric(this.type)) {
            this.type = parseInt(this.type, 10);
        }

        this.formGroup = formBuilder.group({
            IDBenhNhan: ['', Validators.compose([Validators.required])]
        });
        
        Promise.all([
            this.proBenhNhanCustomProvider.getByDeTai(this.idDeTai)
        ])
        .then(values => {
            this.benhNhans = values[0]['data'];
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

    selectBN() {
      if (!this.formGroup.valid) {
        this.toastMessage('Vui lòng kiểm tra lại các thông tin được tô đỏ bên trên.');
      }
      else {
        this.dismiss();
        var page = null; 
        var param = { 'idDeTai': this.idDeTai, 'idNhanSu': -1, 'idBenhNhan': this.idBenhNhan };
        switch(this.type){
            case 1:
              page = AEModalPage;
              break;
            case 2:
              page = SAEModalPage;
              break;
        }
          let myModal = this.modalCtrl.create(page, param, { cssClass: 'preview-modal' });
          myModal.present();
      }
    }
}