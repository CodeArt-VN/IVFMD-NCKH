import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_DonXinNghiemThuCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
@IonicPage({ name: 'page-don-xin-nghiem-thu-modal', priority: 'high', defaultHistory: ['page-don-xin-nghiem-thu-modal'] })
@Component({
    selector: 'don-xin-nghiem-thu-modal',
    templateUrl: 'don-xin-nghiem-thu-modal.html',
})
export class DonXinNghiemThuModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_DonXinNghiemThuCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-don-xin-nghiem-thu-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-don-xin-nghiem-thu-modal";
        this.events.unsubscribe('app:Close-page-don-xin-nghiem-thu-modal');
        this.events.subscribe('app:Close-page-don-xin-nghiem-thu-modal', () => {
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
        ko.cleanNode($('#frmDonXinNghiemThu')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmDonXinNghiemThu").empty();
        $(this.item.HTML).appendTo("#frmDonXinNghiemThu");
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
            self.HoTenChuNhiem = ko.observable(item.HoTenChuNhiem);
            self.DonVi = ko.observable(item.DonVi);
            self.DiaChi = ko.observable(item.DiaChi);
            self.DienThoai = ko.observable(item.DienThoai);
            self.TenDeTai = ko.observable(item.TenDeTai);
            self.TenDonViChuTri = ko.observable(item.TenDonViChuTri);
            self.DiaChiDonVi = ko.observable(item.DiaChiDonVi);
            self.DienThoaiDonVi = ko.observable(item.DienThoaiDonVi);
            self.DiaDiemNghienCuu = ko.observable(item.DiaDiemNghienCuu);
            self.ThoiGianNghienCuu = ko.observable(item.ThoiGianNghienCuu);
            self.TuNgay = ko.observable(item.TuNgay);
            self.DenNgay = ko.observable(item.DenNgay);
            self.BaoCaoTomTat = ko.observable(item.BaoCaoTomTat);
            self.BaoCaoTongKet = ko.observable(item.BaoCaoTongKet);
            self.ThuyetMinhDeTai = ko.observable(item.ThuyetMinhDeTai);
            self.QuyetDinhChapThuanHDDD = ko.observable(item.QuyetDinhChapThuanHDDD);
            self.QuyetDinhGiaoNhiemVu = ko.observable(item.QuyetDinhGiaoNhiemVu);
            self.HopDongThucHienDeTai = ko.observable(item.HopDongThucHienDeTai);
            self.BangGiaiNganKinhPhi = ko.observable(item.BangGiaiNganKinhPhi);
            self.BaiDangBao = ko.observable(item.BaiDangBao);

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmDonXinNghiemThu"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmDonXinNghiemThu").html();
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
}