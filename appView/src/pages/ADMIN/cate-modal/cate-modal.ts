import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { WEB_DanhMucProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-cate-modal', priority: 'high', defaultHistory: ['page-cate'] })
@Component({
    selector: 'cate-modal',
    templateUrl: 'cate-modal.html',
})
export class CateModalPage extends DetailPage {
    constructor(
        public currentProvider: WEB_DanhMucProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-cate";
        this.events.unsubscribe('app:Close-page-cate-modal');
        this.events.subscribe('app:Close-page-cate-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Code: ['', Validators.compose([Validators.required])],
            Name: [''],
            URL: [''],
            Remark: [''],
            Sort: [''],
        });
    }

    loadedData(){
        if(!this.item.IDPartner){
            this.item.IDPartner = this.navParams.data.IDPartner;
        }
    }

    createURL(){
        this.item.URL = "#/chuyen-muc/"+this.item.ID +"/"+ this.commonService.URLFormat( this.item.Code + " " + this.item.Name );
        this.formGroup.controls['URL'].markAsDirty();
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}