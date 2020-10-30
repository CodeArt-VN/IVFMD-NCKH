import { Component } from '@angular/core';
import { ModalController, ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_DonXinDanhGiaDaoDucCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-don-xin-danh-gia-dao-duc-modal', priority: 'high', defaultHistory: ['page-don-xin-danh-gia-dao-duc-modal'] })
@Component({
    selector: 'don-xin-danh-gia-dao-duc-modal',
    templateUrl: 'don-xin-danh-gia-dao-duc-modal.html',
})
export class DonXinDanhGiaDaoDucModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    isInput: any;
    constructor(
        public currentProvider: PRO_DonXinDanhGiaDaoDucCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-don-xin-danh-gia-dao-duc-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-don-xin-danh-gia-dao-duc-modal";
        this.events.unsubscribe('app:Close-page-don-xin-danh-gia-dao-duc-modal');
        this.events.subscribe('app:Close-page-don-xin-danh-gia-dao-duc-modal', () => {
            this.events.publish('app:close-page-don-xin-danh-gia-dao-duc-modal');
            this.dismiss();
        });
        this.events.publish('app:open-page-don-xin-danh-gia-dao-duc-modal');
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
            ko.cleanNode($('#frmDonXinDanhGiaDaoDuc')[0]);
            this.bindData();
        } catch (e) {
        }
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
        this.events.publish('app:close-page-don-xin-danh-gia-dao-duc-modal');
    }

    bindData() {
        $("#frmDonXinDanhGiaDaoDuc").empty();
        if (!this.item.IsDisabled)
            $(this.item.HTML).appendTo("#frmDonXinDanhGiaDaoDuc");
        else {
            var dom = this.nckhProvider.disableContenteditable(this.item.HTML, [])
            $(dom).appendTo("#frmDonXinDanhGiaDaoDuc");
        }
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init(this.item.FormConfig);

        let ObjModel = function (item) {
            var self = this;

            that.nckhProvider.copyPropertiesValue(item, self);

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmDonXinDanhGiaDaoDuc"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmDonXinDanhGiaDaoDuc").html();
        item.FormConfig = this.nckhProvider.getConfigs();
        console.log(item);

        var errors = [];
        if (!this.nckhProvider.isPhoneNumber(item.DienThoai))
            errors.push('Điện thoại chủ nhiệm đề tài không hợp lệ.');
        if (!this.nckhProvider.isPhoneNumber(item.DienThoaiDonVi))
            errors.push('Điện thoại đơn vị chủ trì đề tài không hợp lệ.');
        if (!this.nckhProvider.checkDate(item.NgayKy_Ngay, item.NgayKy_Thang, item.NgayKy_Nam))
            errors.push('Ngày ký không hợp lệ.');

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
                    this.events.publish('app:close-page-don-xin-danh-gia-dao-duc-modal');
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
                pxHeader: $("#frmDonXinDanhGiaDaoDuc .form-template-header").height(),
                pxFooter: $("#frmDonXinDanhGiaDaoDuc .form-template-footer").height(),
                htmlContent: $("#frmDonXinDanhGiaDaoDuc .form-template-body").html(),
                htmlFooter: $("#frmDonXinDanhGiaDaoDuc .form-template-footer").html(),
                htmlHeader: $("#frmDonXinDanhGiaDaoDuc .form-template-header").html()
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
            ko.cleanNode($('#frmDonXinDanhGiaDaoDucPrint')[0]);
        } catch (e) {
        }
        let item = this.model.getItem();
        item.FormConfig = this.nckhProvider.getConfigs();
        $("#frmDonXinDanhGiaDaoDucPrint").empty(); 
        $(this.item.HTMLPrint).appendTo("#frmDonXinDanhGiaDaoDucPrint");
        this.nckhProvider.init(item.FormConfig, true);
        ko.applyBindings(item, document.getElementById("frmDonXinDanhGiaDaoDucPrint"));
        this.nckhProvider.print($("#frmDonXinDanhGiaDaoDucPrint .form-template-body").html(), "Đơn xin đánh giá đạo đức", 1000, 0.6);
    };
}