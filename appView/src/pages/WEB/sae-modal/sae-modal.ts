import { Component } from '@angular/core';
import { ModalController, ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_SAECustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';

@IonicPage({ name: 'page-sae-modal', priority: 'high', defaultHistory: ['page-sae-modal'] })
@Component({
    selector: 'sae-modal',
    templateUrl: 'sae-modal.html',
})
export class SAEModalPage extends DetailPage {
    id: any;
    idDeTai: any;
    idBenhNhan: any;
    model: any;
    isInput: any;
    constructor(
        public currentProvider: PRO_SAECustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-sae-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-sae-modal";
        this.events.unsubscribe('app:Close-page-sae-modal');
        this.events.subscribe('app:Close-page-sae-modal', () => {
            this.events.publish('app:close-page-sae-modal');
            this.dismiss();
        });
        this.events.publish('app:open-page-sae-modal'); 
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }

        this.idBenhNhan = navParams.get('idBenhNhan');
        if (this.idBenhNhan && commonService.isNumeric(this.idBenhNhan)) {
            this.idBenhNhan = parseInt(this.idBenhNhan, 10);
        }

        this.id = navParams.get('id');
        if (this.id && commonService.isNumeric(this.id)) {
            this.id = parseInt(this.id, 10);
        }
        else {
            this.id = -1;
        }
        this.isInput = navParams.get('isInput');
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idDeTai, this.idBenhNhan, this.id, this.isInput).then((ite) => {
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        try {
            ko.cleanNode($('#frmSAE')[0]);
            this.bindData();
        } catch (e) {
        }
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
        this.events.publish('app:close-page-sae-modal');
    }

    bindData() {
        $("#frmSAE").empty();
        $(this.item.HTML).appendTo("#frmSAE");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init(this.item.FormConfig);

        let ObjModel = function (item) {
            var self = this;

            that.nckhProvider.copyPropertiesValue(item, self);

            self.ListThuocThuLamSan = ko.observableArray(ko.utils.arrayMap(item.ListThuocThuLamSan || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    TenThuoc: ko.observable(nn.TenThuoc || ""),
                    DangBaoChe: ko.observable(nn.DangBaoChe || ""),
                    DuongDung: ko.observable(nn.DuongDung || ""),
                    LieuDung: ko.observable(nn.LieuDung || ""),
                    NgayBatDau: ko.observable(nn.NgayBatDau || ""),
                    NgayKetThuc: ko.observable(nn.NgayKetThuc || "")
                };
            }));
            
            self.ListCanThiepThuocThuLamSan = ko.observableArray(ko.utils.arrayMap(item.ListCanThiepThuocThuLamSan || [{}, {}, {}, {}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    NgungLieu_Co: ko.observable(nn.NgungLieu_Co || false),
                    NgungLieu_Khong: ko.observable(nn.NgungLieu_Khong || false),
                    CaiThien_Co: ko.observable(nn.CaiThien_Co || false),
                    CaiThien_Khong: ko.observable(nn.CaiThien_Khong || false),
                    CaiThien_KhongCoThongTin: ko.observable(nn.CaiThien_KhongCoThongTin || false),
                    XuatHienLai_Co: ko.observable(nn.XuatHienLai_Co || false),
                    XuatHienLai_Khong: ko.observable(nn.XuatHienLai_Khong || false),
                    XuatHienLai_KhongCoThongTin: ko.observable(nn.XuatHienLai_KhongCoThongTin || false),
                    XuatHienLai_KhongTaiSuDung: ko.observable(nn.XuatHienLai_KhongTaiSuDung || false)
                };
            }));

            self.ListThuocSuDungDongThoi = ko.observableArray(ko.utils.arrayMap(item.ListThuocSuDungDongThoi || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    TenThuoc: ko.observable(nn.TenThuoc || ""),
                    DangBaoChe: ko.observable(nn.DangBaoChe || ""),
                    DuongDung: ko.observable(nn.DuongDung || ""),
                    LieuDung: ko.observable(nn.LieuDung || ""),
                    NgayBatDau: ko.observable(nn.NgayBatDau || ""),
                    NgayKetThuc: ko.observable(nn.NgayKetThuc || "")
                };
            }));

            self.ListDanhGiaNCV = ko.observableArray(ko.utils.arrayMap(item.ListDanhGiaNCV || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    KetQua_Co: ko.observable(nn.KetQua_Co || false),
                    KetQua_Khong: ko.observable(nn.KetQua_Khong || false),
                    KetQua_ChuaKetLuan: ko.observable(nn.KetQua_ChuaKetLuan || false),
                    PhanUng_DuocDuKien: ko.observable(nn.PhanUng_DuocDuKien || false),
                    PhanUng_NgoaiDuKien: ko.observable(nn.PhanUng_NgoaiDuKien || false)
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
        item.FormConfig = this.nckhProvider.getConfigs();
        console.log(item);

        var errors = [];

        if (errors.length > 0)
            this.toastMessage(errors.join("\n") + "\nVui lòng kiểm tra lại.")
        else
            this.loadingMessage('Lưu dữ liệu...').then(() => {
                this.currentProvider.saveCustom(item).then((savedItem: any) => {
                    this.item.ID = this.id = this.model.ID = savedItem.ID;
                    if (this.loading) this.loading.dismiss();
                    this.events.publish('app:Update' + this.pageName);
                    console.log('publish => app:Update ' + this.pageName);
                    this.toastMessage('Đã lưu xong!');
                    this.viewCtrl.dismiss();
                    this.events.publish('app:close-page-sae-modal');
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
                pxHeader: $("#frmSAE .form-template-header").height(),
                pxFooter: $("#frmSAE .form-template-footer").height(),
                htmlContent: $("#frmSAE .form-template-body").html(),
                htmlFooter: $("#frmSAE .form-template-footer").html(),
                htmlHeader: $("#frmSAE .form-template-header").html()
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

    printPreview() {
        try {
            ko.cleanNode($('#frmSAEPrint')[0]);
        } catch (e) {
        }
        let item = this.model.getItem();
        item.FormConfig = this.nckhProvider.getConfigs();
        $("#frmSAEPrint").empty(); 
        $(this.item.HTMLPrint).appendTo("#frmSAEPrint");
        this.nckhProvider.init(item.FormConfig, true);
        ko.applyBindings(item, document.getElementById("frmSAEPrint"));
        this.nckhProvider.print($("#frmSAEPrint .form-template-body").html(), "SAE", 5000);
    };

}