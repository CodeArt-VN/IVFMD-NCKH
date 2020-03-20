import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_BaoCaoNghiemThuDeTaiCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-bao-cao-nghiem-thu-de-tai-modal', priority: 'high', defaultHistory: ['page-bao-cao-nghiem-thu-de-tai-modal'] })
@Component({
    selector: 'bao-cao-nghiem-thu-de-tai-modal-modal',
    templateUrl: 'bao-cao-nghiem-thu-de-tai-modal.html',
})
export class BaoCaoNghiemThuDeTaiModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_BaoCaoNghiemThuDeTaiCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-bao-cao-nghiem-thu-de-tai-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-bao-cao-nghiem-thu-de-tai-modal";
        this.events.unsubscribe('app:Close-page-bao-cao-nghiem-thu-de-tai-modal');
        this.events.subscribe('app:Close-page-bao-cao-nghiem-thu-de-tai-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idDeTai).then((ite) => {
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        ko.cleanNode($('#frmBaoCaoNghiemThuDeTai')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmBaoCaoNghiemThuDeTai").empty();
        $(this.item.HTML).appendTo("#frmBaoCaoNghiemThuDeTai");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();
        let ObjModel = function (item) {
            var self = this;
            that.nckhProvider.copyPropertiesValue(item, self);

            self.ThoiGian_Nam = ko.observable(item.ThoiGian_Nam || "");
            self.ThoiGian_Thang = ko.observable(item.ThoiGian_Thang || "");

            self.ListCanBo = ko.observableArray(ko.utils.arrayMap(item.ListCanBo || [{}, {}, {}, {}], function (cb) {
                return {
                    HocHamHoTen: ko.observable(cb.HocHamHoTen || ""),
                    ChiuTrachNhiem: ko.observable(cb.ChiuTrachNhiem || ""),
                    DienThoai: ko.observable(cb.DienThoai || ""),
                    Email: ko.observable(cb.Email || "")
                };
            }));

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmBaoCaoNghiemThuDeTai"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmBaoCaoNghiemThuDeTai").html();
        console.log(item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.save(item).then((savedItem: any) => {
                this.item.ID = savedItem.ID;
                this.model.ID = savedItem.ID;
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã lưu xong!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Không lưu được, \nvui lòng thử lại.');
            });
        })
    };

    print() {
        this.loadingMessage('Lấy dữ liệu in...').then(() => {
            var itemPrint = {
                id: this.id,
                type: 0,
                firstPageHeader: true,
                pxHeader: $("#frmBaoCaoNghiemThuDeTai .form-template-header").height(),
                pxFooter: $("#frmBaoCaoNghiemThuDeTai .form-template-footer").height(),
                htmlContent: $("#frmBaoCaoNghiemThuDeTai .form-template-body").html(),
                htmlFooter: $("#frmBaoCaoNghiemThuDeTai .form-template-footer").html(),
                htmlHeader: $("#frmBaoCaoNghiemThuDeTai .form-template-header").html()
            };
            this.deTaiCustomProvider.print(itemPrint).then((res: any) => {
                if (this.loading) this.loading.dismiss();
                if (res) this.download(res);
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Không in được, \nvui lòng thử lại.');
            });
        });
    };
}