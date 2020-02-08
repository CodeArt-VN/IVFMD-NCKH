import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_DeTaiProvider, HRM_STAFF_NhanSuProvider } from '../../../providers/Services/Services';
import { Sys_VarProvider, PRO_BenhNhanCustomProvider, PRO_NCVKhacCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { NcvKhacModalPage } from '../ncv-khac-modal/ncv-khac-modal';
import { DeTaiBenhNhanModalPage } from '../de-tai-benh-nhan-modal/de-tai-benh-nhan-modal';
import { DateAdapter } from "@angular/material";

import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-de-tai-modal', priority: 'high', defaultHistory: ['page-de-tai'] })
@Component({
    selector: 'de-tai-modal',
    templateUrl: 'de-tai-modal.html',
})
export class DeTaiModalPage extends DetailPage {
    tab = '1';
    staffs = [];
    typeOfTopics = [];
    lstBenhNhan: any[] = [];
    lstBNSelected: any[] = [];
    queryBN: any = {};

    lstNCVKhac: any[] = [];
    lstNCVSelected: any[] = [];
    queryNCV: any = {};
    constructor(
        public currentProvider: PRO_DeTaiProvider,
        public staffProvider: HRM_STAFF_NhanSuProvider,
        public sysVarProvider: Sys_VarProvider,
        public benhNhanProvider: PRO_BenhNhanCustomProvider,
        public ncvKhacProvider: PRO_NCVKhacCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.dateAdapter.setLocale('vi');   
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-de-tai-modal');
        this.events.subscribe('app:Close-page-de-tai-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            MaSo: ['', Validators.compose([Validators.required])],
            DeTai: ['', Validators.compose([Validators.required])],
            TenTiengViet: ['', Validators.compose([Validators.required])],
            TenTiengAnh: ['', Validators.compose([Validators.required])],
            SoNCT: [''],
            GhiChu: [''],
            IDChuNhiem: ['', Validators.compose([Validators.required])],
            IDPhanLoaiDeTai: ['', Validators.compose([Validators.required])],
            myDate: [Date],
        });
    }

    preLoadData() {
        Promise.all([
            this.staffProvider.read(),
            this.sysVarProvider.getByTypeOfVar(1),
            this.benhNhanProvider.getByDeTai(this.id),
            this.ncvKhacProvider.getByDeTai(this.id)
        ])
            .then(values => {
                this.staffs = values[0]['data'];
                this.typeOfTopics = values[1]['data'];
                this.lstBenhNhan = [...values[2]['data']];
                this.lstNCVKhac = [...values[3]['data']];
                super.preLoadData();
            })
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    //#region NCV Khác
    refreshNCV() {
        this.lstNCVSelected = [];
        this.ncvKhacProvider.getByDeTai(this.id).then(value => {
            this.lstNCVKhac = [...value['data']];
        });
    }

    addNCV() {
        var that = this;
        let item = {
            ID: 0,
            
        };
        let modal = this.modalCtrl.create(NcvKhacModalPage, { 'id': item.ID, 'idDeTai': this.id });

        modal.onDidDismiss(data => {
            console.log('test');
            that.refreshNCV();
        });
        modal.present();
    }

    deleteNCV() {
        this.showActionMore = false;
        var count = this.lstNCVSelected.length;
        let title = 'Xóa ' + count + ' dòng';
        if (count == 1 && this.lstNCVSelected[0].Name) {
            title = 'Xóa [' + this.lstNCVSelected[0].Name + ']';
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
                        var seletedItems = [...this.lstNCVSelected];
                        var doneCount = 0;

                        for (var i = 0; i < seletedItems.length; i++) {
                            var ite = seletedItems[i];
                            this.ncvKhacProvider.delete(ite).then(data => {
                                doneCount++;
                                if (doneCount == count) {
                                    let toast = this.toastCtrl.create({
                                        message: 'Đã xóa ' + doneCount + ' dòng.',
                                        duration: GlobalData.UserData.Setting.ToastMessageDelay
                                    });
                                    toast.present();
                                    this.refreshNCV();
                                }

                            });
                        }
                    }
                }
            ]
        });
        confirm.present();
    }

    onSelectNCV({ selected }) {
        this.lstNCVSelected.splice(0, this.lstNCVSelected.length);
        this.lstNCVSelected.push(...selected);
    }
    openDetailNCV(item) {
        let myModal = this.modalCtrl.create(NcvKhacModalPage, { 'id': item.ID, 'idDeTai': this.id });
        myModal.present();
    }
    //#endregion NCV Khác

    //#region BenhNhan
    refreshBN() {
        this.lstBNSelected = [];
        this.benhNhanProvider.getByDeTai(this.id).then(value => {
            this.lstBenhNhan = [...value['data']];
        });
    }

    addBN(isNew) {
        let item = {
            ID: 0,
            
        };
        let modal = this.modalCtrl.create(DeTaiBenhNhanModalPage, { 'id': item.ID, 'idDeTai': this.id, 'isNew': isNew });
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
                            this.benhNhanProvider.delete(ite).then(data => {
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