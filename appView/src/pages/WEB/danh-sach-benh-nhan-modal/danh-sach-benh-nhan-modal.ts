import { Component, ViewChild } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_BenhNhanCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DeTaiBenhNhanModalPage } from '../de-tai-benh-nhan-modal/de-tai-benh-nhan-modal';
import { DatatableComponent } from '@swimlane/ngx-datatable';

import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-danh-sach-benh-nhan-modal', priority: 'high', defaultHistory: ['page-danh-sach-benh-nhan'] })
@Component({
    selector: 'danh-sach-benh-nhan-modal',
    templateUrl: 'danh-sach-benh-nhan-modal.html',
})
export class DanhSachBenhNhanModalPage extends DetailPage {
    tab = '1';
    staffs = [];
    typeOfTopics = [];
    lstBenhNhan: any[] = [];
    lstBNSelected: any[] = [];
    queryBN: any = {};

    lstNCVKhac: any[] = [];
    lstNCVSelected: any[] = [];
    queryNCV: any = {};
    @ViewChild(DatatableComponent) table: DatatableComponent;

    constructor(
        public currentProvider: PRO_BenhNhanCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);   
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-danh-sach-benh-nhan-modal');
        this.events.subscribe('app:Close-page-danh-sach-benh-nhan-modal', () => {
            this.dismiss();
        });
    }

    preLoadData() {
            this.currentProvider.getByDeTai(this.id)
            .then(value => {
                this.lstBenhNhan = [...value['data']];
                super.preLoadData();
            })
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    //#region BenhNhan
    refreshBN() {
        this.lstBNSelected = [];
        this.currentProvider.getByDeTai(this.id).then(value => {
            this.lstBenhNhan = [...value['data']];
        });
    }

    addBN(isNew) {
        let item = {
            ID: 0,
            
        };
        let modal = this.modalCtrl.create(DeTaiBenhNhanModalPage, { 'id': item.ID, 'idDeTai': this.id, 'isNew': isNew });
        modal.onDidDismiss(data => {
            this.refreshBN();
        });
        modal.present();
    }

    deleteBN() {
        this.showActionMore = false;
        var count = this.lstBNSelected.length;
        let title = 'Xóa ' + count + ' dòng';
        if (count == 1 && this.lstBNSelected[0].Name) {
            title = 'Xóa [' + this.lstBNSelected[0].Name + ']';
        }
        else if (count == 1) {
            title = 'Xóa bỏ';
        }

        let confirm = this.alertCtrl.create({
            title: title,
            message: 'Bạn chắc muốn xóa ' + (count == 1 ? '' : count + ' ') + 'dòng đang được chọn?',
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
                        debugger
                        var seletedItems = [...this.lstBNSelected];
                        var doneCount = 0;

                        for (var i = 0; i < seletedItems.length; i++) {
                            var ite = seletedItems[i];
                            this.currentProvider.delete(ite).then(data => {
                                doneCount++;
                                if (doneCount == count) {
                                    let toast = this.toastCtrl.create({
                                        message: 'Đã xóa ' + doneCount + ' dòng.',
                                        duration: GlobalData.UserData.Setting.ToastMessageDelay
                                    });
                                    toast.present();
                                    this.refreshBN();
                                }

                            });
                        }
                    }
                }
            ]
        });
        confirm.present();
    }

    onSelectBN({ selected }) {
        this.lstBNSelected.splice(0, this.lstBNSelected.length);
        this.lstBNSelected.push(...selected);
    }
    openDetailBN(item) {
        let myModal = this.modalCtrl.create(DeTaiBenhNhanModalPage, { 'id': item.ID, 'idDeTai': this.id });
        myModal.present();
    }
    //#endregion BenhNhan
}