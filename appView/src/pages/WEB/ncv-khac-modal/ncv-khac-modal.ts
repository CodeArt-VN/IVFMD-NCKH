import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_NCVKhacProvider, HRM_STAFF_NhanSuProvider } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-ncv-khac-modal', priority: 'high', defaultHistory: ['page-ncv-khac'] })
@Component({
    selector: 'ncv-khac-modal',
    templateUrl: 'ncv-khac-modal.html',
})
export class NcvKhacModalPage extends DetailPage {
    idDeTai: any;
    staffs = [];
    constructor(
        public currentProvider: PRO_NCVKhacProvider,
        public staffProvider: HRM_STAFF_NhanSuProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-ncv-khac-modal');
        this.events.subscribe('app:Close-page-ncv-khac-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
        this.formGroup = formBuilder.group({
            ChucDanh: [''],
            ChucVu: [''],
            IDNCV: ['', Validators.compose([Validators.required])]
        });

        Promise.all([
          this.staffProvider.read()
      ])
          .then(values => {
              this.staffs = values[0]['data'];
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