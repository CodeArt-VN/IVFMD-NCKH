import { Component } from '@angular/core';
import { ViewController, ModalController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_AECustomProvider, PRO_SAECustomProvider } from '../../../providers/Services/CustomService';
import { AEModalPage } from '../ae-modal/ae-modal';
import { SAEModalPage } from '../sae-modal/sae-modal';
import { ChonBenhNhanModalPage } from '../chon-benh-nhan-modal/chon-benh-nhan-modal';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import { GlobalData } from '../../../providers/CORE/global-variable'
import 'jqueryui';

@IonicPage({ name: 'page-list-select-modal', priority: 'high', defaultHistory: ['page-list-select'] })
@Component({
    selector: 'list-select-modal',
    templateUrl: 'list-select-modal.html',
})
export class ListSelectModalPage extends DetailPage {
    idDeTai: any;
    type: any;
    lstForm: any[] = [];
    lstFormSelected: any[] = [];
    queryForm: any = {};

    constructor(
        public currentProvider: PRO_AECustomProvider,
        public proSAECustomProvider: PRO_SAECustomProvider,
        public modalCtrl: ModalController,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-list-select-modal');
        this.events.subscribe('app:Close-page-list-select-modal', () => {
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
    }
    preLoadData() {
        if (this.type == 1) {
            this.lstFormSelected = [];
            this.currentProvider.getListByDeTai(this.idDeTai).then(value => {
                this.lstForm = [...value['data']];
                this.lstForm.forEach((i) => {
                    i.NgayTaoText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
                });
            });
        }
        else {
            this.lstFormSelected = [];
            this.proSAECustomProvider.getListByDeTai(this.idDeTai).then(value => {
                this.lstForm = [...value['data']];
                this.lstForm.forEach((i) => {
                    i.NgayTaoText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
                });
            });
        }
    }

    loadData() {
    }
    loadedData() {

    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    addForm() {
        var param = { 'idDeTai': this.idDeTai, 'idNhanSu': -1, 'type': this.type };
        let myModal = this.modalCtrl.create(ChonBenhNhanModalPage, param, { cssClass: 'select-modal' });
        this.dismiss();
        myModal.present();
    }
    openDetailForm(i) {
        this.dismiss();
        var page = null;
        var param = { 'idDeTai': this.idDeTai, 'idNhanSu': -1, 'idBenhNhan': i.IDBenhNhan, 'id': i.ID, isInput: true };
        switch (this.type) {
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

    refreshForm() {
        if (this.type == 1) {
            this.lstFormSelected = [];
            this.currentProvider.getListByDeTai(this.idDeTai).then(value => {
                this.lstForm = [...value['data']];
            });
        }
        else {
            this.lstFormSelected = [];
            this.proSAECustomProvider.getListByDeTai(this.idDeTai).then(value => {
                this.lstForm = [...value['data']];
            });
        }
    }

    deleteForm(i) {
        let confirm = this.alertCtrl.create({
            title: 'Xóa báo cáo',
            message: 'Bạn có chắc muốn xóa?',
            buttons: [
                {
                    text: 'Không xóa',
                    handler: () => {
                        console.log('Không xóa');
                    }
                },
                {
                    text: 'Đồng ý xóa',
                    handler: () => {
                        if (this.type == 1) {
                            this.currentProvider.delete(i).then(data => {
                                let toast = this.toastCtrl.create({
                                    message: 'Đã xóa thành công.',
                                    duration: GlobalData.UserData.Setting.ToastMessageDelay
                                });
                                toast.present();
                                this.refreshForm();
                            });
                        }
                        else {
                            this.proSAECustomProvider.delete(i).then(data => {
                                let toast = this.toastCtrl.create({
                                    message: 'Đã xóa thành công.',
                                    duration: GlobalData.UserData.Setting.ToastMessageDelay
                                });
                                toast.present();
                                this.refreshForm();
                            });
                        }
                    }
                }
            ]
        });
        confirm.present();
    }
}