import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { CAT_TagsProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-tags-modal', priority: 'high', defaultHistory: ['page-tags'] })
@Component({
    selector: 'tags-modal',
    templateUrl: 'tags-modal.html',
})
export class TagsModalPage extends DetailPage {
    constructor(
        public currentProvider: CAT_TagsProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-tags";
        this.events.unsubscribe('app:Close-page-tags-modal');
        this.events.subscribe('app:Close-page-tags-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            TenTag: ['', Validators.compose([Validators.required])],
            GhiChu: ['']
        });
    }

    loadedData(){
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}