import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_PhieuXemXetDaoDucCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-phieu-xem-xet-dao-duc-modal', priority: 'high', defaultHistory: ['page-phieu-xem-xet-dao-duc-modal'] })
@Component({
    selector: 'phieu-xem-xet-dao-duc-modal',
    templateUrl: 'phieu-xem-xet-dao-duc-modal.html',
})
export class PhieuXemXetDaoDucModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_PhieuXemXetDaoDucCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public viewCtrl: ViewController,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-phieu-xem-xet-dao-duc-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-phieu-xem-xet-dao-duc-modal";
        this.events.unsubscribe('app:Close-page-phieu-xem-xet-dao-duc-modal');
        this.events.subscribe('app:Close-page-phieu-xem-xet-dao-duc-modal', () => {
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
        ko.cleanNode($('#frmPhieuXemXetDaoDuc')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmPhieuXemXetDaoDuc").empty();
        if (!this.item.IsDisabled)
            $(this.item.HTML).appendTo("#frmPhieuXemXetDaoDuc");
        else {
            var dom = this.nckhProvider.disableContenteditable(this.item.HTML, [])
            $(dom).appendTo("#frmPhieuXemXetDaoDuc");
        }
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init(this.item.FormConfig);

        let ObjModel = function (item) {
            var self = this;

            that.nckhProvider.copyPropertiesValue(item, self);

            self.ListNCV = ko.observableArray(ko.utils.arrayMap(item.ListNCV || [{}, {}, {}], function (nn) {
                return {
                    HoTen: ko.observable(nn.HoTen || ""),
                    ChucDanh: ko.observable(nn.ChucDanh || ""),
                    ChucVu: ko.observable(nn.ChucVu || "")
                };
            }));

            self.ListCoQuan = ko.observableArray(ko.utils.arrayMap(item.ListCoQuan || [{}, {}, {}, {}, {}], function (nn) {
                return {
                    CoQuan: ko.observable(nn.CoQuan || ""),
                    DuocCapPhep: ko.observable(nn.DuocCapPhep || false),
                    ChoCapPhep: ko.observable(nn.ChoCapPhep || false),
                    ChuaXinPhep: ko.observable(nn.ChuaXinPhep || false),
                    GhiChuKhac: ko.observable(nn.GhiChuKhac || false)
                };
            }));

            self.CanKet_ListChuKy = ko.observableArray(ko.utils.arrayMap(item.CanKet_ListChuKy || [{}, {}, {}, {}, {}], function (nn) {
                return {
                    BoMon: ko.observable(nn.BoMon || ""),
                    NgayKy: ko.observable(nn.NgayKy || ""),
                    ThangKy: ko.observable(nn.ThangKy || ""),
                    NamKy: ko.observable(nn.NamKy || ""),
                    HoTenVaChucDanh: ko.observable(nn.HoTenVaChucDanh || "")
                };
            }));

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmPhieuXemXetDaoDuc"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.IDDetai = this.idDeTai;
        item.HTML = $("#frmPhieuXemXetDaoDuc").html();
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

    print() {
        this.loadingMessage('Lấy dữ liệu in...').then(() => {
            var itemPrint = {
                id: this.id,
                type: 0,
                pxHeader: $("#frmPhieuXemXetDaoDuc .form-template-header").height(),
                pxFooter: $("#frmPhieuXemXetDaoDuc .form-template-footer").height(),
                htmlContent: $("#frmPhieuXemXetDaoDuc .form-template-body").html(),
                htmlFooter: $("#frmPhieuXemXetDaoDuc .form-template-footer").html(),
                htmlHeader: $("#frmPhieuXemXetDaoDuc .form-template-header").html()
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