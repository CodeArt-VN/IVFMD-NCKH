import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_BangKhaiNhanSuCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-bang-khai-nhan-su-modal', priority: 'high', defaultHistory: ['page-bang-khai-nhan-su-modal'] })
@Component({
    selector: 'bang-khai-nhan-su-modal',
    templateUrl: 'bang-khai-nhan-su-modal.html',
})
export class BangKhaiNhanSuModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_BangKhaiNhanSuCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-bang-khai-nhan-su-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-bang-khai-nhan-su-modal";
        this.events.unsubscribe('app:Close-page-bang-khai-nhan-su-modal');
        this.events.subscribe('app:Close-page-bang-khai-nhan-su-modal', () => {
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
        ko.cleanNode($('#frmBangKhaiNhanSu')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmBangKhaiNhanSu").empty();
        $(this.item.HTML).appendTo("#frmBangKhaiNhanSu");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init(this.item.FormConfig);
        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            self.filter = function (arr, prop, ko, val) {
                console.log(val)
                var data = arr().filter(function (v) {
                    if (ko) {
                        return v[prop]() == val;
                    } else {
                        return v[prop] == val;
                    }
                })
                var removable = data.length > 1 ? 1 : 0;
                var ab = data.map(function (o) {
                    o.removable = removable;
                    return o;
                })
                return ab;
            }
            
            self.YTuong_NguoiThucHien = ko.observable(item.YTuong_NguoiThucHien);
            self.YTuong_ChiPhi = ko.observable(item.YTuong_ChiPhi);
            self.PhuongPhap_NguoiThucHien = ko.observable(item.PhuongPhap_NguoiThucHien);
            self.PhuongPhap_ChiPhi = ko.observable(item.PhuongPhap_ChiPhi);
            self.QuyTrinhNhanMau_NguoiThucHien = ko.observable(item.QuyTrinhNhanMau_NguoiThucHien);
            self.QuyTrinhNhanMau_ChiPhi = ko.observable(item.QuyTrinhNhanMau_ChiPhi);
            self.ThucHienNhanMau_NguoiThucHien = ko.observable(item.ThucHienNhanMau_NguoiThucHien);
            self.ThucHienNhanMau_ChiPhi = ko.observable(item.ThucHienNhanMau_ChiPhi);
            self.NhapDuLieuVaoPM_NguoiThucHien = ko.observable(item.NhapDuLieuVaoPM_NguoiThucHien);
            self.NhapDuLieuVaoPM_ChiPhi = ko.observable(item.NhapDuLieuVaoPM_ChiPhi);
            self.VietBaiBaoCaoTiengViet_NguoiThucHien = ko.observable(item.VietBaiBaoCaoTiengViet_NguoiThucHien);
            self.VietBaiBaoCaoTiengViet_ChiPhi = ko.observable(item.VietBaiBaoCaoTiengViet_ChiPhi);
            self.VietBaiBaoCaoTiengAnh_NguoiThucHien = ko.observable(item.VietBaiBaoCaoTiengAnh_NguoiThucHien);
            self.VietBaiBaoCaoTiengAnh_ChiPhi = ko.observable(item.VietBaiBaoCaoTiengAnh_ChiPhi);
            self.ReviewTinhKhaThi_NguoiThucHien = ko.observable(item.ReviewTinhKhaThi_NguoiThucHien);
            self.ReviewTinhKhaThi_ChiPhi = ko.observable(item.ReviewTinhKhaThi_ChiPhi);
            self.XayDungPhanMem_NguoiThucHien = ko.observable(item.XayDungPhanMem_NguoiThucHien);
            self.XayDungPhanMem_ChiPhi = ko.observable(item.XayDungPhanMem_ChiPhi);
            self.XayDungKeHoachPhanTich_NguoiThucHien = ko.observable(item.XayDungKeHoachPhanTich_NguoiThucHien);
            self.XayDungKeHoachPhanTich_ChiPhi = ko.observable(item.XayDungKeHoachPhanTich_ChiPhi);
            self.LamSachSoLieu_NguoiThucHien = ko.observable(item.LamSachSoLieu_NguoiThucHien);
            self.LamSachSoLieu_ChiPhi = ko.observable(item.LamSachSoLieu_ChiPhi);
            self.PhanTichSoLieu_NguoiThucHien = ko.observable(item.PhanTichSoLieu_NguoiThucHien);
            self.PhanTichSoLieu_ChiPhi = ko.observable(item.PhanTichSoLieu_ChiPhi);
            self.XayDungKeHoachDieuPhoi_NguoiThucHien = ko.observable(item.XayDungKeHoachDieuPhoi_NguoiThucHien);
            self.XayDungKeHoachDieuPhoi_ChiPhi = ko.observable(item.XayDungKeHoachDieuPhoi_ChiPhi);
            self.ChuanBiHoSoGiayTo_NguoiThucHien = ko.observable(item.ChuanBiHoSoGiayTo_NguoiThucHien);
            self.ChuanBiHoSoGiayTo_ChiPhi = ko.observable(item.ChuanBiHoSoGiayTo_ChiPhi);
            self.DieuPhoiHoatDongNghienCuu_NguoiThucHien = ko.observable(item.DieuPhoiHoatDongNghienCuu_NguoiThucHien);
            self.DieuPhoiHoatDongNghienCuu_ChiPhi = ko.observable(item.DieuPhoiHoatDongNghienCuu_ChiPhi);
            self.QuanLyDieuHanhChung_NguoiThucHien = ko.observable(item.QuanLyDieuHanhChung_NguoiThucHien);
            self.QuanLyDieuHanhChung_ChiPhi = ko.observable(item.QuanLyDieuHanhChung_ChiPhi);

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmBangKhaiNhanSu"));
    };

    saveChange() {
        let item = this.model.getItem();
        let isError = false;
        try {
            if (item.YTuong_ChiPhi)
                if (isNaN(parseFloat(item.YTuong_ChiPhi))) isError = true;
            if (item.PhuongPhap_ChiPhi)
                if (isNaN(parseFloat(item.PhuongPhap_ChiPhi))) isError = true;
            if (item.QuyTrinhNhanMau_ChiPhi)
                if (isNaN(parseFloat(item.QuyTrinhNhanMau_ChiPhi))) isError = true;
            if (item.ThucHienNhanMau_ChiPhi)
                if (isNaN(parseFloat(item.ThucHienNhanMau_ChiPhi))) isError = true;
            if (item.NhapDuLieuVaoPM_ChiPhi)
                if (isNaN(parseFloat(item.NhapDuLieuVaoPM_ChiPhi))) isError = true;
            if (item.VietBaiBaoCaoTiengViet_ChiPhi)
                if (isNaN(parseFloat(item.VietBaiBaoCaoTiengViet_ChiPhi))) isError = true;
            if (item.VietBaiBaoCaoTiengAnh_ChiPhi)
                if (isNaN(parseFloat(item.VietBaiBaoCaoTiengAnh_ChiPhi))) isError = true;
            if (item.ReviewTinhKhaThi_ChiPhi)
                if (isNaN(parseFloat(item.ReviewTinhKhaThi_ChiPhi))) isError = true;
            if (item.XayDungPhanMem_ChiPhi)
                if (isNaN(parseFloat(item.XayDungPhanMem_ChiPhi))) isError = true;
            if (item.XayDungKeHoachPhanTich_ChiPhi)
                if (isNaN(parseFloat(item.XayDungKeHoachPhanTich_ChiPhi))) isError = true;
            if (item.LamSachSoLieu_ChiPhi)
                if (isNaN(parseFloat(item.LamSachSoLieu_ChiPhi))) isError = true;
            if (item.XayDungKeHoachDieuPhoi_ChiPhi)
                if (isNaN(parseFloat(item.XayDungKeHoachDieuPhoi_ChiPhi))) isError = true;
            if (item.ChuanBiHoSoGiayTo_ChiPhi)
                if (isNaN(parseFloat(item.ChuanBiHoSoGiayTo_ChiPhi))) isError = true;
            if (item.DieuPhoiHoatDongNghienCuu_ChiPhi)
                if (isNaN(parseFloat(item.DieuPhoiHoatDongNghienCuu_ChiPhi))) isError = true;
            if (item.QuanLyDieuHanhChung_ChiPhi)
                if (isNaN(parseFloat(item.QuanLyDieuHanhChung_ChiPhi))) isError = true;
        } catch (e) { isError = true; }
        if (isError) {
            this.toastMessage('Các cột Kinh phí vui lòng chỉ nhập số!');
            return;
        }

        item.HTML = $("#frmBangKhaiNhanSu").html();
        item.FormConfig = this.nckhProvider.getConfigs();
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

    refreshItem() {
        if (this.item.ID > 0) {
            let confirm = this.alertCtrl.create({
                title: "Xác nhận",
                message: 'Bạn có chắc muốn làm mới theo dữ liệu hiện tại??',
                buttons: [
                    {
                        text: 'Thoát',
                        handler: () => {
                        }
                    },
                    {
                        text: 'Đồng ý',
                        handler: () => {
                            this.loadingMessage('Lưu dữ liệu...').then(() => {
                                this.currentProvider.refreshItem({ IDDeTai: this.idDeTai }).then((savedItem: any) => {
                                    this.loadData();
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
                        }
                    }
                ]
            });
            confirm.present();
        } else this.toastMessage('Chỉ làm mới khi đã lưu dữ liệu!');
    };

    print() {
        this.loadingMessage('Lấy dữ liệu in...').then(() => {
            var itemPrint = {
                id: this.id,
                type: 0,
                pxHeader: $("#frmBangKhaiNhanSu .form-template-header").height(),
                pxFooter: $("#frmBangKhaiNhanSu .form-template-footer").height(),
                htmlContent: $("#frmBangKhaiNhanSu .form-template-body").html(),
                htmlFooter: $("#frmBangKhaiNhanSu .form-template-footer").html(),
                htmlHeader: $("#frmBangKhaiNhanSu .form-template-header").html()
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