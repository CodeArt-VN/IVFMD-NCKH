import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { DOC_FileProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import { appSetting } from '../../../providers/CORE/api-list';

//@IonicPage({ name: 'page-viewer-modal', priority: 'high', defaultHistory: ['page-folder'] })
@Component({
    selector: 'viewer-modal',
    templateUrl: 'viewer-modal.html',
})
export class ViewerModalPage extends DetailPage {
    showIframe = false;
    constructor(
        public currentProvider: DOC_FileProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-viewer-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.events.unsubscribe('app:Close-page-viewer-modal');
        this.events.subscribe('app:Close-page-viewer-modal', () => {
            this.dismiss();
        });
    }

    loadedData(){
        if(this.item.Path){
            this.item.url = appSetting.mainService.base + "pdf/web/viewer.html?file=" + appSetting.mainService.base + this.item.Code;
            this.showIframe = true; 
        }
        
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }


}