import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { DOC_FolderProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-folder-modal', priority: 'high', defaultHistory: ['page-folder'] })
@Component({
    selector: 'folder-modal',
    templateUrl: 'folder-modal.html',
})
export class FolderModalPage extends DetailPage {
    folderList: any = [];
    folderTree: any = [];
    constructor(
        public currentProvider: DOC_FolderProvider,
        public folderProvider: DOC_FolderProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super('page-folder-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.events.unsubscribe('app:Close-page-folder-modal');
        this.events.subscribe('app:Close-page-folder-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({

            IDParent: [''],
            Code: [''],
            Name: ['', Validators.compose([Validators.required])],
            Remark: [''],
            Sort: [''],
        });
    }

    preLoadData() {
        Promise.all([
            this.folderProvider.read()
        ])
        .then(values => {
            this.folderList = values[0]['data'];
            this.folderTree = [];
            this.buildTree(null);

            super.preLoadData();
        })
    }

    loadedData() {
        if (!this.item.IDPartner) {
            this.item.IDPartner = this.navParams.data.IDPartner;
        }

        this.item.oldIDParent = this.item.IDParent;
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    buildTree(item) {
        let idp = item == null ? null : item.ID;
        let childrent = this.folderList.filter(d => d.IDParent == idp && d.ID != this.id && d.IDLinhVuc == null);
        let level = (item && item.level >= 0) ? item.level + 1 : 1;

        let index = this.folderTree.findIndex(d => d.ID == idp)
        this.folderTree.splice(index + 1, 0, ...childrent);

        childrent.forEach(i => {
            i.levels = Array(level).fill('');
            i.level = level;
            this.buildTree(i);
        });
    }

    savedChange() {
        this.events.publish('app:page-sops-ReBuildFolderTree', this.item);
        super.savedChange();
    }
}