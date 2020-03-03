import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { STAFF_NhanSu_HosremCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';

@IonicPage({ name: 'page-hosrem-modal', priority: 'high', defaultHistory: ['page-hosrem-modal'] })
@Component({
    selector: 'hosrem-modal',
    templateUrl: 'hosrem-modal.html',
})
export class HosremModalPage extends DetailPage {
    idNhanSu: any;
    model: any;
    constructor(
        public currentProvider: STAFF_NhanSu_HosremCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-hosrem-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-hosrem-modal";
        this.events.unsubscribe('app:Close-page-hosrem-modal');
        this.events.subscribe('app:Close-page-hosrem-modal', () => {
            this.dismiss();
        });

        this.idNhanSu = navParams.get('idNhanSu');
        if (this.idNhanSu && commonService.isNumeric(this.idNhanSu)) {
            this.idNhanSu = parseInt(this.idNhanSu, 10);
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idNhanSu).then((ite) => {
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        ko.cleanNode($('#frmHosrem')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmHosrem").empty();
        $(this.item.HTML).appendTo("#frmHosrem");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();

        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            that.nckhProvider.copyPropertiesValue(item, self);
            self.ListDonViCongTac = that.nckhProvider.observableSimpleArray(item.ListDonViCongTac, ["- ", "- "]);
            self.ListQuaTrinhDaoTao = that.nckhProvider.observableSimpleArray(item.ListQuaTrinhDaoTao, ["- ", "- "]);
            self.ListHoatDongKhac = that.nckhProvider.observableSimpleArray(item.ListHoatDongKhac, ["- ", "- "]);
            self.ListBaiDangTapChi = that.nckhProvider.observableSimpleArray(item.ListBaiDangTapChi, ["- ", "- "]);
            self.ListKinhNghiemLamViec = that.nckhProvider.observableSimpleArray(item.ListKinhNghiemLamViec, ["- ", "- "]);
            self.getItem = function () {
                var obj = ko.toJS(self);
                obj.ListDonViCongTac = that.nckhProvider.stringifySimpleArray(obj.ListDonViCongTac);
                obj.ListQuaTrinhDaoTao = that.nckhProvider.stringifySimpleArray(obj.ListQuaTrinhDaoTao);
                obj.ListHoatDongKhac = that.nckhProvider.stringifySimpleArray(obj.ListHoatDongKhac);
                obj.ListBaiDangTapChi = that.nckhProvider.stringifySimpleArray(obj.ListBaiDangTapChi);
                obj.ListKinhNghiemLamViec = that.nckhProvider.stringifySimpleArray(obj.ListKinhNghiemLamViec);
                return obj;
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmHosrem"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmHosrem").html();
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

    print() {
        this.loadingMessage('Lấy dữ liệu in...').then(() => {
            var itemPrint = {
                id: this.id,
                type: 0,
                htmlContent: $("#frmHosrem .form-template-body").html(),
                htmlFooter: $("#frmHosrem .form-template-footer").html(),
                htmlHeader: $("#frmHosrem .form-template-header").html()
            };
            this.deTaiCustomProvider.print(itemPrint).then((res: any) => {
                if (this.loading) this.loading.dismiss();
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Không in được, \nvui lòng thử lại.');
            });
        });
    };
}