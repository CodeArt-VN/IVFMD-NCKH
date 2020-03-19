import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_DonXinXetDuyetCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-don-xin-xet-duyet-modal', priority: 'high', defaultHistory: ['page-don-xin-xet-duyet-modal'] })
@Component({
    selector: 'don-xin-xet-duyet-modal',
    templateUrl: 'don-xin-xet-duyet-modal.html',
})
export class DonXinXetDuyetModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_DonXinXetDuyetCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-don-xin-xet-duyet-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-don-xin-xet-duyet-modal";
        this.events.unsubscribe('app:Close-page-don-xin-xet-duyet-modal');
        this.events.subscribe('app:Close-page-don-xin-xet-duyet-modal', () => {
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
        ko.cleanNode($('#frmDonXinXetDuyet')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmDonXinXetDuyet").empty();
        $(this.item.HTML).appendTo("#frmDonXinXetDuyet");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();

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
            self.ThuyetMinhDeCuong = ko.observable(item.ThuyetMinhDeCuong);
            self.LLKHChuNhiem = ko.observable(item.LLKHChuNhiem);
            self.LLKHNCV = ko.observable(item.LLKHNCV);
            self.GiayToKhac = ko.observable(item.GiayToKhac);
            self.GhiChuGiayToKha = ko.observable(item.GhiChuGiayToKha);
            self.NgayKy_Ngay = ko.observable(item.NgayKy_Ngay);
            self.NgayKy_Thang = ko.observable(item.NgayKy_Thang);
            self.NgayKy_Nam = ko.observable(item.NgayKy_Nam);
            self.NgayKy_ChuKy = ko.observable(item.NgayKy_ChuKy);
            
            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmDonXinXetDuyet"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmDonXinXetDuyet").html();
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
                htmlContent: $("#frmDonXinXetDuyet .form-template-body").html(),
                htmlFooter: $("#frmDonXinXetDuyet .form-template-footer").html(),
                htmlHeader: $("#frmDonXinXetDuyet .form-template-header").html()
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