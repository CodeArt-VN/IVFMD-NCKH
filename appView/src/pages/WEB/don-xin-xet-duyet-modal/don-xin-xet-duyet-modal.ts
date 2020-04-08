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
        try {
            ko.cleanNode($('#frmDonXinXetDuyet')[0]);
            this.bindData();
        } catch (e) {
        }
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
        this.nckhProvider.init(this.item.FormConfig);

        let ObjModel = function (item) {
            var self = this;

            that.nckhProvider.copyPropertiesValue(item, self);

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
                pxHeader: $("#frmDonXinXetDuyet .form-template-header").height(),
                pxFooter: $("#frmDonXinXetDuyet .form-template-footer").height(),
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