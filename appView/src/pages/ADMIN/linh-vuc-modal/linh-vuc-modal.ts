import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { CAT_LinhVucProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-linh-vuc-modal', priority: 'high', defaultHistory: ['page-linh-vuc'] })
@Component({
    selector: 'linh-vuc-modal',
    templateUrl: 'linh-vuc-modal.html',
})
export class LinhVucModalPage extends DetailPage {
    linhvucList: any = [];
    linhvucTree: any = [];
    constructor(
        public currentProvider: CAT_LinhVucProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-linh-vuc";
        this.events.unsubscribe('app:Close-page-linh-vuc-modal');
        this.events.subscribe('app:Close-page-linh-vuc-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Name: ['', Validators.compose([Validators.required])],
            Note: [''],
            Sort: [''],
            ParentID: [''],
        });
    }

    preLoadData() {
        Promise.all([
            this.currentProvider.read()
        ])
            .then(values => {
                this.linhvucList = values[0]['data'];
                this.linhvucTree = [];
                this.buildTree(null);

                super.preLoadData();
            })
    }

    buildTree(item) {
        let idp = item == null ? null : item.ID;
        let childrent = this.linhvucList.filter(d => d.ParentID == idp && d.ID != this.id);
        let level = (item && item.level >= 0) ? item.level + 1 : 1;

        let index = this.linhvucTree.findIndex(d => d.ID == idp)
        this.linhvucTree.splice(index + 1, 0, ...childrent);

        childrent.forEach(i => {
            i.levels = Array(level).fill('');
            i.level = level;
            this.buildTree(i);
        });
    }

    loadedData() {
        if (this.item.ID == 0) {
            this.item.ParentID = null;
            this.item.Sort = 0;
        } 
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}