import { Component, ViewChild } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators, FormControl } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_DeTaiProvider, HRM_STAFF_NhanSuProvider, CAT_TagsProvider } from '../../../providers/Services/Services';
import { Sys_VarProvider, PRO_NCVKhacCustomProvider, HRM_STAFF_NhanSuCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { NcvKhacModalPage } from '../ncv-khac-modal/ncv-khac-modal';
import { DateAdapter } from "@angular/material";
import { DatatableComponent } from '@swimlane/ngx-datatable';
import { DetailPage } from '../../detail-page';
import 'jqueryui';

interface obj {
    TenTag: string;
    ID: number;
}

@IonicPage({ name: 'page-de-tai-modal', priority: 'high', defaultHistory: ['page-de-tai'] })
@Component({
    selector: 'de-tai-modal',
    templateUrl: 'de-tai-modal.html',
})
export class DeTaiModalPage extends DetailPage {
    myDatePicker: any = {};
    tab = '1';
    staffs: any[] = [];
    typeOfTopics = [];
    lstBenhNhan: any[] = [];
    lstBNSelected: any[] = [];
    queryBN: any = {};
    lstTag: any[] = [];
    lstNCVKhac: any[] = [];
    lstNCVSelected: any[] = [];
    queryNCV: any = {};
    @ViewChild(DatatableComponent) table: DatatableComponent;
    constructor(
        public currentProvider: PRO_DeTaiProvider,
        public staffProvider: HRM_STAFF_NhanSuCustomProvider,
        public sysVarProvider: Sys_VarProvider,
        public ncvKhacProvider: PRO_NCVKhacCustomProvider,
        public tagProvider: CAT_TagsProvider,
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
            TenTiengViet: ['', Validators.compose([Validators.required])],
            TenTiengAnh: ['', Validators.compose([Validators.required])],
            SoNCT: [''],
            MaSoProtocalID: [''],
            MaSoHDDD: [''],
            GhiChu: [''],
            IDChuNhiem: ['', Validators.compose([Validators.required])],
            myDate: [Date],
            Tags: ['']
        });
    }

    comparer(o1: obj, o2: obj): boolean {
        // if possible compare by object's name, and not by reference.
        return o1 && o2 ? o1.TenTag === o2.TenTag : o2 === o2;
    }

    preLoadData() {
        Promise.all([
            this.staffProvider.getListChuNhiem(),
            this.sysVarProvider.getByTypeOfVar(1),
            this.ncvKhacProvider.getByDeTai(this.id),
            this.tagProvider.read(),
        ])
            .then(values => {
                this.staffs = values[0]['data'];
                this.typeOfTopics = values[1]['data'];
                this.lstNCVKhac = [...values[2]['data']];
                this.lstTag = [...values[3]['data']];
                super.preLoadData();
            })
    }

    loadedData() {
        if (this.item.ID == 0)
            this.item.Tags = [];
        
        jQuery("#datetimepicker1").datetimepicker();
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
            //debugger
            //this.table.recalculate();
        });
    }

    addNCV() {
        var that = this;
        let item = {
            ID: 0,
            
        };
        let modal = this.modalCtrl.create(NcvKhacModalPage, { 'id': item.ID, 'idDeTai': this.id });

        modal.onDidDismiss(data => {
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

}
