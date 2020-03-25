import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { STAFF_NhanSu_SYLLProviderCustomProvider, PRO_SYLLCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-nhan-su-syll-modal', priority: 'high', defaultHistory: ['page-nhan-su-syll-modal'] })
@Component({
    selector: 'nhan-su-syll-modal',
    templateUrl: 'nhan-su-syll-modal.html',
})
export class NhanSuSYLLModalPage extends DetailPage {
    idNhanSu: any;
    idDeTai: any;
    isChuNhiem: false;
    model: any;
    constructor(
        public currentProvider: STAFF_NhanSu_SYLLProviderCustomProvider,
        public proSYLLProvider: PRO_SYLLCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-nhan-su-syll-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-nhan-su-syll-modal";
        this.events.unsubscribe('app:Close-page-nhan-su-syll-modal');
        this.events.subscribe('app:Close-page-nhan-su-syll-modal', () => {
            this.dismiss();
        });
        this.idNhanSu = navParams.get('idNhanSu');
        if (this.idNhanSu && commonService.isNumeric(this.idNhanSu)) {
            this.idNhanSu = parseInt(this.idNhanSu, 10);
        }

        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
        else {
            this.idDeTai = -1;
        }

        this.isChuNhiem = navParams.get('isChuNhiem');
        if (this.isChuNhiem) {
        }
        else {
            this.isChuNhiem = false;
        }
    }

    loadData() {
        if (this.idDeTai > 0) {
            this.proSYLLProvider.getItemCustom(this.idDeTai, this.idNhanSu, this.isChuNhiem).then((ite) => {
                this.item = ite;
                this.loadedData();
            }).catch((data) => {
                this.item.ID = 0;
                this.loadedData();
            });
        }
        else {
            this.currentProvider.getItemCustom(this.idNhanSu).then((ite) => {
                this.item = ite;
                this.loadedData();
            }).catch((data) => {
                this.item.ID = 0;
                this.loadedData();
            });
        }
    }

    loadedData() {
        ko.cleanNode($('#frmNhanSuSYLL')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmNhanSuSYLL").empty();
        $(this.item.HTML).appendTo("#frmNhanSuSYLL");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init(this.item.FormConfig);

        var ObjModel = function (item) {
            var self = this;
            self.ID = item.ID;
            self.IDNhanSu = item.IDNhanSu;
            self.IDDetai = item.IDDetai;

            
            self.HoTen = ko.observable(item.HoTen || "");
            self.GioiTinh = ko.observable(item.GioiTinh || "");
            self.NgaySinh = ko.observable(item.NgaySinh || "");
            self.DiaChi = ko.observable(item.DiaChi || "");
            self.DienThoaiCQ = ko.observable(item.DienThoaiCQ || "");
            self.Mobile = ko.observable(item.Mobile || "");
            self.Email = ko.observable(item.Email || "");
            self.ChucVu = ko.observable(item.ChucVu || "");
            self.CoQuanLamViec = ko.observable(item.CoQuanLamViec || "");
            self.ThuTruongCoQuan = ko.observable(item.ThuTruongCoQuan || "");
            self.DienThoaiThuTruong = ko.observable(item.DienThoaiThuTruong || "");
            self.DiaChiCoQuan = ko.observable(item.DiaChiCoQuan || "");
            self.NgayKy_Ngay = ko.observable(item.NgayKy_Ngay || "");
            self.NgayKy_Thang = ko.observable(item.NgayKy_Thang || "");
            self.NgayKy_Nam = ko.observable(item.NgayKy_Nam || "");
            self.NgayKy_ChuKy = ko.observable(item.NgayKy_ChuKy || "");
            self.DienThoaiNhaRieng = ko.observable(item.DienThoaiNhaRieng || "");
           
            self.ListTrinhDoChuyenMon = ko.observableArray(ko.utils.arrayMap(item.ListTrinhDoChuyenMon || [{}, {}, {}], function (nn) {
                return {
                    HocVi: ko.observable(nn.HocVi || ""),
                    NamNhanBang: ko.observable(nn.NamNhanBang || ""),
                    ChuyenNganhDaoTao: ko.observable(nn.ChuyenNganhDaoTao || "")
                };
            }));

            self.ListKinhNghiem = ko.observableArray(ko.utils.arrayMap(item.ListKinhNghiem || [{}, {}, {}], function (nn) {
                return {
                    TenDeTai: ko.observable(nn.TenDeTai || ""),
                    NhiemVuCaNhan: ko.observable(nn.NhiemVuCaNhan || ""),
                    CoQuanChuTri: ko.observable(nn.CoQuanChuTri || ""),
                    NamBatDauKetThuc: ko.observable(nn.NamBatDauKetThuc || "")
                };
            }));

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmNhanSuSYLL"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmNhanSuSYLL").html();
        item.FormConfig = this.nckhProvider.getConfigs();
        console.log(item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            if (this.idDeTai > 0) {
                this.proSYLLProvider.saveCustom(item).then((savedItem: any) => {
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
            }
            else {
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
            }
        })
    };

    print() {
        this.loadingMessage('Lấy dữ liệu in...').then(() => {
            var itemPrint = {
                id: this.id,
                type: 0,
                pxHeader: $("#frmNhanSuSYLL .form-template-header").height(),
                pxFooter: $("#frmNhanSuSYLL .form-template-footer").height(),
                htmlContent: $("#frmNhanSuSYLL .form-template-body").html(),
                htmlFooter: $("#frmNhanSuSYLL .form-template-footer").html(),
                htmlHeader: $("#frmNhanSuSYLL .form-template-header").html()
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