import { Component } from '@angular/core';
import { ModalController, ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_BangKiemXXDDCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';

@IonicPage({ name: 'page-bang-kiem-xxdd-modal', priority: 'high', defaultHistory: ['page-bang-kiem-xxdd-modal'] })
@Component({
    selector: 'bang-kiem-xxdd-modal',
    templateUrl: 'bang-kiem-xxdd-modal.html',
})
export class BangKiemXXDDModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    isInput: any;
    constructor(
        public currentProvider: PRO_BangKiemXXDDCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-bang-kiem-xxdd-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-bang-kiem-xxdd-modal";
        this.events.unsubscribe('app:Close-page-bang-kiem-xxdd-modal');
        this.events.subscribe('app:Close-page-bang-kiem-xxdd-modal', () => {
            this.events.publish('app:close-page-bang-kiem-xxdd-modal');
            this.dismiss();
        });
        this.events.publish('app:open-page-bang-kiem-xxdd-modal');
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
            ko.cleanNode($('#frmBangKiemXXDD')[0]);
            this.bindData();
        } catch (e) {
        }
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
        this.events.publish('app:close-page-bang-kiem-xxdd-modal');
    }

    bindData() {
        $("#frmBangKiemXXDD").empty();
        if (!this.item.IsDisabled)
            $(this.item.HTML).appendTo("#frmBangKiemXXDD");
        else {
            var dom = this.nckhProvider.disableContenteditable(this.item.HTML, [])
            $(dom).appendTo("#frmBangKiemXXDD");
        }
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init(this.item.FormConfig);

        let ObjModel = function (item) {
            var self = this;
            that.nckhProvider.copyPropertiesValue(item, self);

            self.NCVKhac = ko.observableArray(ko.utils.arrayMap(item.NCVKhac || [{}], function (nn) {
                return {
                    ThongTin: ko.observable(nn.ThongTin || "")
                };
            }));

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        console.log(this.model.getItem());
        try {
            ko.applyBindings(this.model, document.getElementById("frmBangKiemXXDD"));
        } catch (e) {
            console.error(e);
        }
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmBangKiemXXDD").html();
        item.FormConfig = this.nckhProvider.getConfigs();
        console.log(item);

        var errors = [];
        if (!this.nckhProvider.isPhoneNumber(item.PhanHai_NGS_DienThoai))
            errors.push('Điện thoại người giám sát/hướng dẫn không hợp lệ.');
        if (!this.nckhProvider.checkDate(item.ThoiGianTienHanh_Ngay, item.ThoiGianTienHanh_Thang, item.ThoiGianTienHanh_Nam))
            errors.push('Thời gian bắt đầu tiến hành thử nghiệm của nghiên cứu không hợp lệ.');
        if (!this.nckhProvider.checkDate(item.ThoiGianTienHanhDenNgay_Ngay, item.ThoiGianTienHanhDenNgay_Thang, item.ThoiGianTienHanhDenNgay_Nam))
            errors.push('Thời gian kết thúc tiến hành thử nghiệm của nghiên cứu không hợp lệ.');
        if (!this.nckhProvider.checkDate(1, item.ThoiGianThuThap_Thang, item.ThoiGianThuThap_Nam, true))
            errors.push('Thời gian bắt đầu thu thập số liệu của nghiên cứu không hợp lệ.');
        if (!this.nckhProvider.checkDate(1, item.ThoiGianThuThapDenNgay_Thang, item.ThoiGianThuThapDenNgay_Nam, true))
            errors.push('Thời gian kết thúc thu thập số liệu của nghiên cứu không hợp lệ.');
        if (!this.nckhProvider.checkDate(1, item.ThoiGianNghienCuu_Thang, item.ThoiGianNghienCuu_Nam, true))
            errors.push('Bắt đầu toàn bộ quỹ thời gian nghiên cứu không hợp lệ.');
        if (!this.nckhProvider.checkDate(1, item.ThoiGianNghienCuuDenNgay_Thang, item.ThoiGianNghienCuuDenNgay_Nam, true))
            errors.push('Kết thúc toàn bộ quỹ thời gian nghiên cứu không hợp lệ.');
        if (!this.nckhProvider.checkDate(item.NgayKy_Ngay, item.NgayKy_Thang, item.NgayKy_Nam))
            errors.push('Ngày ký của chủ tịch hội đồng đạo đức không hợp lệ.');

        if (errors.length > 0)
            this.toastMessage(errors.join("\n") + "\nVui lòng kiểm tra lại.")
        else
            this.loadingMessage('Lưu dữ liệu...').then(() => {
                this.currentProvider.saveCustom(item).then((savedItem: any) => {
                    this.item.ID = savedItem.ID;
                    this.model.ID = savedItem.ID;
                    if (this.loading) this.loading.dismiss();
                    this.events.publish('app:Update' + this.pageName);
                    console.log('publish => app:Update ' + this.pageName);
                    this.toastMessage('Đã lưu xong!');
                    this.viewCtrl.dismiss();
                    this.events.publish('app:close-page-bang-kiem-xxdd-modal');
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
                pxHeader: $("#frmBangKiemXXDD .form-template-header").height(),
                pxFooter: $("#frmBangKiemXXDD .form-template-footer").height(),
                htmlContent: $("#frmBangKiemXXDD .form-template-body").html(),
                htmlFooter: $("#frmBangKiemXXDD .form-template-footer").html(),
                htmlHeader: $("#frmBangKiemXXDD .form-template-header").html()
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
        var param = { 'idDeTai': this.idDeTai, 'idNhanSu': -1, 'type': -1, 'isChuNhiem': false, 'isInput': false };
        let myModal = this.modalCtrl.create(BangKiemXXDDModalPage, param, { cssClass: 'preview-modal' });
        this.viewCtrl.dismiss();
        myModal.present();
    };
}