import { Component } from '@angular/core';
import { ModalController, ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
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
    isInput: any;
    constructor(
        public currentProvider: PRO_AECustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-ae-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-ae-modal";
        this.events.unsubscribe('app:Close-page-ae-modal');
        this.events.subscribe('app:Close-page-ae-modal', () => {
            this.events.publish('app:close-page-ae-modal');
            this.dismiss();
        });
        this.events.publish('app:open-page-ae-modal');
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
            ko.cleanNode($('#frmAE')[0]);
            this.bindData();
        } catch (e) {
        }
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
        this.events.publish('app:close-page-ae-modal');
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

        var errors = [];
        if (!this.nckhProvider.checkDateTime(item.NgayKhoiPhat_Ngay, item.NgayKhoiPhat_Thang, item.NgayKhoiPhat_Nam,
            item.NgayKhoiPhat_Gio, item.NgayKhoiPhat_Phut, null))
            errors.push('Ngày khởi phát không hợp lệ.');
        if (!this.nckhProvider.checkDateTime(item.NgayKetThuc_Ngay, item.NgayKetThuc_Thang, item.NgayKetThuc_Nam,
            item.NgayKetThuc_Gio, item.NgayKetThuc_Phut, null))
            errors.push('Ngày kết thúc không hợp lệ.');
        if (!this.nckhProvider.checkDate(item.KetQua_TuVong_Ngay, item.KetQua_TuVong_Thang, item.KetQua_TuVong_Nam))
            errors.push('Ngày tử vong không hợp lệ.');
        if (!this.nckhProvider.checkDate(item.NgayBaoCao_Ngay, item.NgayBaoCao_Thang, item.NgayBaoCao_Nam))
            errors.push('Ngày báo cáo không hợp lệ.');
        if (!this.nckhProvider.checkDateTime(item.NT_NgayGioTangDoNang_Ngay, item.NT_NgayGioTangDoNang_Thang, item.NT_NgayGioTangDoNang_Nam,
            item.NT_NgayGioTangDoNang_Gio, item.NT_NgayGioTangDoNang_Phut, null))
            errors.push('Ngày/Giờ tăng độ nặng, trở nên nghiêm trọng không hợp lệ.');
        if (!this.nckhProvider.checkDate(item.NT_NgayBaoCao_Ngay, item.NT_NgayBaoCao_Thang, item.NT_NgayBaoCao_Nam))
            errors.push('Ngày báo cáo (nghiêm trọng) không hợp lệ.');
        if (errors.length > 0)
            this.toastMessage(errors.join("\n") + "\nVui lòng kiểm tra lại.")
        else
            this.loadingMessage('Lưu dữ liệu...').then(() => {
                this.currentProvider.save(item).then((savedItem: any) => {
                    this.item.ID = this.id = this.model.ID = savedItem.ID;
                    if (this.loading) this.loading.dismiss();
                    this.events.publish('app:Update' + this.pageName);
                    console.log('publish => app:Update ' + this.pageName);
                    this.toastMessage('Đã lưu xong!');
                    this.viewCtrl.dismiss();
                    this.events.publish('app:close-page-ae-modal');
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

    printPreview() {
        var param = { 'idDeTai': this.idDeTai, 'idBenhNhan': this.idBenhNhan, 'id': this.id, 'isInput': false };
        let myModal = this.modalCtrl.create(AEModalPage, param, { cssClass: 'preview-modal' });
        this.viewCtrl.dismiss();
        myModal.present();
    };
}