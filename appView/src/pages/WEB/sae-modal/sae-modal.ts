import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_SAECustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';

@IonicPage({ name: 'page-sae-modal', priority: 'high', defaultHistory: ['page-sae-modal'] })
@Component({
    selector: 'sae-modal',
    templateUrl: 'sae-modal.html',
})
export class SAEModalPage extends DetailPage {
    idDeTai: any;
    idBenhNhan: any;
    model: any;
    constructor(
        public currentProvider: PRO_SAECustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-sae-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-sae-modal";
        this.events.unsubscribe('app:Close-page-sae-modal');
        this.events.subscribe('app:Close-page-sae-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }

        this.idBenhNhan = navParams.get('idBenhNhan');
        if (this.idBenhNhan && commonService.isNumeric(this.idBenhNhan)) {
            this.idBenhNhan = parseInt(this.idBenhNhan, 10);
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idDeTai, this.idBenhNhan).then((ite) => {
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        ko.cleanNode($('#frmSAE')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmSAE").empty();
        $(this.item.HTML).appendTo("#frmSAE");
        let id = this.item.ID;
        var that = this;
        ko.bindingHandlers.editableHTML = {
            init: function (element, valueAccessor) {
                var $element = $(element);
                var initialValue = ko.utils.unwrapObservable(valueAccessor());
                if (id <= 0)
                    $element.html(initialValue);
                $element.on('keyup', function () {
                    var observable = valueAccessor();
                    observable($element.html());
                });
            }
        };

        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            self.ListThuocThuLamSan = ko.observableArray(ko.utils.arrayMap(item.ListThuocThuLamSan || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.ThoiGian || ""),
                    TenThuoc: ko.observable(nn.TenHiepHoi || ""),
                    DangBaoChe: ko.observable(nn.ChucDanh || ""),
                    DuongDung: ko.observable(nn.ChucDanh || ""),
                    LieuDung: ko.observable(nn.ChucDanh || ""),
                    NgayBatDau: ko.observable(nn.ChucDanh || ""),
                    NgayKetThuc: ko.observable(nn.ChucDanh || "")
                };
            }));
            
            self.ListCanThiepThuocThuLamSan = ko.observableArray(ko.utils.arrayMap(item.ListCanThiepThuocThuLamSan || [{}, {}, {}, {}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.ThoiGian || ""),
                    NgungLieu_Co: ko.observable(nn.TenHiepHoi || ""),
                    NgungLieu_Khong: ko.observable(nn.ChucDanh || ""),
                    CaiThien_Co: ko.observable(nn.ChucDanh || ""),
                    CaiThien_Khong: ko.observable(nn.ChucDanh || ""),
                    CaiThien_KhongCoThongTin: ko.observable(nn.ChucDanh || ""),
                    XuatHienLai_Co: ko.observable(nn.ChucDanh || ""),
                    XuatHienLai_Khong: ko.observable(nn.ChucDanh || ""),
                    XuatHienLai_KhongCoThongTin: ko.observable(nn.ChucDanh || ""),
                    XuatHienLai_KhongTaiSuDung: ko.observable(nn.ChucDanh || "")
                };
            }));

            self.ListThuocSuDungDongThoi = ko.observableArray(ko.utils.arrayMap(item.ListThuocSuDungDongThoi || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.ThoiGian || ""),
                    TenThuoc: ko.observable(nn.TenHiepHoi || ""),
                    DangBaoChe: ko.observable(nn.ChucDanh || ""),
                    DuongDung: ko.observable(nn.ChucDanh || ""),
                    LieuDung: ko.observable(nn.ChucDanh || ""),
                    NgayBatDau: ko.observable(nn.ChucDanh || ""),
                    NgayKetThuc: ko.observable(nn.ChucDanh || "")
                };
            }));

            self.ListDanhGiaNCV = ko.observableArray(ko.utils.arrayMap(item.ListDanhGiaNCV || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.ThoiGian || ""),
                    KetQua_Co: ko.observable(nn.TenHiepHoi || ""),
                    KetQua_Khong: ko.observable(nn.ChucDanh || ""),
                    KetQua_ChuaKetLuan: ko.observable(nn.ChucDanh || ""),
                    LieuDung: ko.observable(nn.ChucDanh || ""),
                    PhanUng_DuocDuKien: ko.observable(nn.ChucDanh || ""),
                    PhanUng_NgoaiDuKien: ko.observable(nn.ChucDanh || "")
                };
            }));
            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmSAE"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmSAE").html();
        console.log(item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.saveCustom(item).then((savedItem: any) => {
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
}