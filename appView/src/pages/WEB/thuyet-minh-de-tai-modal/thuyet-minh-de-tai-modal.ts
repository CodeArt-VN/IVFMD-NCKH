import { Component } from '@angular/core';
import { ModalController, ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_ThuyetMinhDeTaiCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-thuyet-minh-de-tai-modal', priority: 'high', defaultHistory: ['page-thuyet-minh-de-tai-modal'] })
@Component({
    selector: 'thuyet-minh-de-tai-modal',
    templateUrl: 'thuyet-minh-de-tai-modal.html',
})
export class ThuyetMinhDeTaiModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    isInput: any;
    constructor(
        public currentProvider: PRO_ThuyetMinhDeTaiCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-thuyet-minh-de-tai-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-thuyet-minh-de-tai-modal";
        this.events.unsubscribe('app:Close-page-thuyet-minh-de-tai-modal');
        this.events.subscribe('app:Close-page-thuyet-minh-de-tai-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
        this.isInput = navParams.get('isInput');
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idDeTai, this.isInput).then((ite) => {
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        try {
            ko.cleanNode($('#frmThuyetMinhDeTai')[0]);
            this.bindData();
        } catch (e) {
        }
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmThuyetMinhDeTai").empty();
        if (!this.item.IsDisabled)
            $(this.item.HTML).appendTo("#frmThuyetMinhDeTai");
        else {
            var dom = this.nckhProvider.disableContenteditable(this.item.HTML, [])
            $(dom).appendTo("#frmThuyetMinhDeTai");
        }
        
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init(this.item.FormConfig);

        let ObjModel = function (item) {
            var self = this;
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

            that.nckhProvider.copyPropertiesValue(item, self);

            self.ChuNhiemDeTai = ko.observable({
                HoTen: ko.observable(item.ChuNhiemDeTai.HoTen || ""),
                DonVi: ko.observable(item.ChuNhiemDeTai.DonVi || ""),
                SoThangLamViec: ko.observable(item.ChuNhiemDeTai.SoThangLamViec || ""),
            })


            self.ListCoQuanPhoiHop = ko.observableArray(ko.utils.arrayMap(item.ListCoQuanPhoiHop || [{}], function (nn) {
                return {
                    TenCoQuan: ko.observable(nn.TenCoQuan || ""),
                    HoTenThuTruong: ko.observable(nn.HoTenThuTruong || ""),
                    DienThoai: ko.observable(nn.DienThoai || ""),
                    DiaChi: ko.observable(nn.DiaChi || ""),
                };
            }));

            self.ListNhanLucNghienCuu = ko.observableArray(ko.utils.arrayMap(item.ListNhanLucNghienCuu || [{}, {}, {}, {}], function (nn) {
                return {
                    TT: ko.observable(nn.TT || ""),
                    HoTen: ko.observable(nn.HoTen || ""),
                    DonVi: ko.observable(nn.DonVi || ""),
                    SoThangLamViec: ko.observable(nn.SoThangLamViec || "")
                };
            }));

            self.ListGioiThieuChuyenGia = ko.observableArray(ko.utils.arrayMap(item.ListGioiThieuChuyenGia || [{}, {}, {}, {}, {}], function (nn) {
                return {
                    TT: ko.observable(nn.TT || ""),
                    HoTen: ko.observable(nn.HoTen || ""),
                    HuongNghienCuu: ko.observable(nn.HuongNghienCuu || ""),
                    CoQuan: ko.observable(nn.CoQuan || ""),
                    DienThoai: ko.observable(nn.DienThoai || "")
                };
            }));

            self.ListKeHoachThucHien = ko.observableArray(ko.utils.arrayMap(item.ListKeHoachThucHien, function (nn) {
                return {
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    ThoiGianThucHien: ko.observable(nn.ThoiGianThucHien || ""),
                    DuKienKetQua: ko.observable(nn.DuKienKetQua || ""),
                    NguoiThucHien: ko.observable(nn.NguoiThucHien || "")
                };
            }));

            self.ListKinhPhiCongLaoDong = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiCongLaoDong, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiNguyenVatLieu = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiNguyenVatLieu, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiThietBi = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiThietBi, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiKhac = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiKhac, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiTongHop = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiTongHop, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    PhanTram: ko.observable(nn.PhanTram || "")
                };
            }));

            self.ListBienSo = ko.observableArray(ko.utils.arrayMap(item.ListBienSo || [{ LoaiBienSo: 1 }, { LoaiBienSo: 2 }, { LoaiBienSo: 0 }], function (nn) {
                return {
                    Ten: ko.observable(nn.Ten || ""),
                    PhanLoai: ko.observable(nn.PhanLoai || ""),
                    GiaTri: ko.observable(nn.GiaTri || ""),
                    CachThuThap: ko.observable(nn.CachThuThap || ""),
                    LoaiBienSo: ko.observable(nn.LoaiBienSo)
                };
            }));

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmThuyetMinhDeTai"));
    };

    saveChange() {
        let item = this.model.getItem();
        var that = this;
        item.HTML = $("#frmThuyetMinhDeTai").html();
        item.FormConfig = this.nckhProvider.getConfigs();
        console.log(item);

        var errors = [];
        if (!this.nckhProvider.isPhoneNumber(item.A6_DienThoai))
            errors.push('Điện thoại chủ nhiệm không hợp lệ.');
        if (!this.nckhProvider.isPhoneNumber(item.A7_DienThoai))
            errors.push('Điện thoại cơ quan chủ trì không hợp lệ.');
        $.each(item.ListCoQuanPhoiHop, function (i, o) {
            if (!that.nckhProvider.isPhoneNumber(o.DienThoai))
                errors.push('Điện thoại cơ quan phối hợp thực hiện ' + o.TenCoQuan + ' không hợp lệ.');
        })
        //// Có cả email nên chưa validate
        //$.each(item.ListGioiThieuChuyenGia, function (i, o) {
        //    if (!that.nckhProvider.isPhoneNumber(o.DienThoai))
        //        errors.push('Điện thoại chuyên gia ' + o.HoTen + ' không hợp lệ.');
        //})

        if (errors.length > 0)
            this.toastMessage(errors.join("\n") + "\nVui lòng kiểm tra lại.")
        else
            this.loadingMessage('Lưu dữ liệu...').then(() => {
                this.currentProvider.save(item).then((savedItem: any) => {
                    this.item.ID = savedItem.ID;
                    this.model.ID = savedItem.ID;
                    if (this.loading) this.loading.dismiss();
                    this.events.publish('app:Update' + this.pageName);
                    console.log('publish => app:Update ' + this.pageName);
                    this.toastMessage('Đã lưu xong!');
                    this.viewCtrl.dismiss();
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
                pxHeader: $("#frmThuyetMinhDeTai .form-template-header").height(),
                pxFooter: $("#frmThuyetMinhDeTai .form-template-footer").height(),
                htmlContent: $("#frmThuyetMinhDeTai .form-template-body").html(),
                htmlFooter: $("#frmThuyetMinhDeTai .form-template-footer").html(),
                htmlHeader: $("#frmThuyetMinhDeTai .form-template-header").html()
            };
            this.deTaiCustomProvider.print(itemPrint).then((res: any) => {
                if (this.loading) this.loading.dismiss();
                if (res) this.download(res);
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Không in được, \nvui lòng thử lại.');
            });
        })
    };

    printPreview() {
        var param = { 'idDeTai': this.idDeTai, 'isInput': false };
        let myModal = this.modalCtrl.create(ThuyetMinhDeTaiModalPage, param, { cssClass: 'preview-modal' });
        this.viewCtrl.dismiss();
        myModal.present();
    };
}