import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_BenhNhanProvider, HRM_BenhNhanProvider } from '../../../providers/Services/Services';
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
    benhNhans = [];
    constructor(
        public currentProvider: PRO_BenhNhanProvider,
        public hrmBenhNhanProvider: HRM_BenhNhanProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-tags";
        this.events.unsubscribe('app:Close-page-de-tai-benh-nhan-modal');
        this.events.subscribe('app:Close-page-de-tai-benh-nhan-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
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
}