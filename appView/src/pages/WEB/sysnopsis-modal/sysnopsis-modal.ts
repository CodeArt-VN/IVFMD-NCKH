import { Component } from '@angular/core';
import { ModalController, ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_SysnopsisCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-sysnopsis-modal', priority: 'high', defaultHistory: ['page-sysnopsis-modal'] })
@Component({
    selector: 'sysnopsis-modal',
    templateUrl: 'sysnopsis-modal.html',
})
export class SysnopsisModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    isInput: any;
    constructor(
        public currentProvider: PRO_SysnopsisCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-sysnopsis-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-sysnopsis-modal";
        this.events.unsubscribe('app:Close-page-sysnopsis-modal');
        this.events.subscribe('app:Close-page-sysnopsis-modal', () => {
            this.events.publish('app:close-page-sysnopsis-modal');
            this.dismiss();
        });
        this.events.publish('app:open-page-sysnopsis-modal');
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

    loadDataReset() {
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
            ko.cleanNode($('#frmSynopsis')[0]);
            this.bindData();
        } catch (e) {
        }
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
        this.events.publish('app:close-page-sysnopsis-modal');
    }

    bindData() {
        $("#frmSynopsis").empty();
        if (!this.item.IsDisabled)
            $(this.item.HTML).appendTo("#frmSynopsis");
        else {
            var dom = this.nckhProvider.disableContenteditable(this.item.HTML, [])
            $(dom).appendTo("#frmSynopsis");
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
        ko.applyBindings(this.model, document.getElementById("frmSynopsis"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmSynopsis").html();
        item.FormConfig = this.nckhProvider.getConfigs();
        console.log(item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.save(item).then((savedItem: any) => {
                this.item.ID = savedItem.ID;
                this.model.ID = savedItem.ID;
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                //this.goBack();
                this.toastMessage('Đã lưu xong!');
                this.viewCtrl.dismiss();
                this.events.publish('app:close-page-sysnopsis-modal');
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
                pxHeader: $("#frmSynopsis .form-template-header").height(),
                pxFooter: $("#frmSynopsis .form-template-footer").height(),
                htmlContent: $("#frmSynopsis .form-template-body").html(),
                htmlFooter: $("#frmSynopsis .form-template-footer").html(),
                htmlHeader: $("#frmSynopsis .form-template-header").html()
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
            ko.cleanNode($('#frmSynopsisPrint')[0]);
        } catch (e) {
        }
        let item = this.model.getItem();
        $(this.item.HTMLPrint).appendTo("#frmSynopsisPrint");
        this.nckhProvider.init(item.FormConfig);
        ko.applyBindings(item, document.getElementById("frmSynopsisPrint"));
        this.nckhProvider.print($("#frmSynopsisPrint .form-template-body").html(), "Synopsis");
    };
}