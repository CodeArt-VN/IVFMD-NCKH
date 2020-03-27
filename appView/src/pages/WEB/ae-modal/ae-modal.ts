import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_AECustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';

@IonicPage({ name: 'page-ae-modal', priority: 'high', defaultHistory: ['page-ae-modal'] })
@Component({
    selector: 'ae-modal',
    templateUrl: 'ae-modal.html',
})
export class AEModalPage extends DetailPage {
    id: any;
    idDeTai: any;
    idBenhNhan: any;
    model: any;
    constructor(
        public currentProvider: PRO_AECustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-ae-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-ae-modal";
        this.events.unsubscribe('app:Close-page-ae-modal');
        this.events.subscribe('app:Close-page-ae-modal', () => {
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

        this.id = navParams.get('id');
        if (this.id && commonService.isNumeric(this.id)) {
            this.id = parseInt(this.id, 10);
        }
        else {
            this.id = -1;
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idDeTai, this.idBenhNhan, this.id).then((ite) => {
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        ko.cleanNode($('#frmAE')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmAE").empty();
        $(this.item.HTML).appendTo("#frmAE");
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
        ko.applyBindings(this.model, document.getElementById("frmAE"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmAE").html();
        item.FormConfig = this.nckhProvider.getConfigs();
        console.log(item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.save(item).then((savedItem: any) => {
                this.item.ID = this.id = this.model.ID = savedItem.ID;
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
                pxHeader: $("#frmAE .form-template-header").height(),
                pxFooter: $("#frmAE .form-template-footer").height(),
                htmlContent: $("#frmAE .form-template-body").html(),
                htmlFooter: $("#frmAE .form-template-footer").html(),
                htmlHeader: $("#frmAE .form-template-header").html()
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