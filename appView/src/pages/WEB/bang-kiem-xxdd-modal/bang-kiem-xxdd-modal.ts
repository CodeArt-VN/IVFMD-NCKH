import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
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
    constructor(
        public currentProvider: PRO_BangKiemXXDDCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-bang-kiem-xxdd-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-bang-kiem-xxdd-modal";
        this.events.unsubscribe('app:Close-page-bang-kiem-xxdd-modal');
        this.events.subscribe('app:Close-page-bang-kiem-xxdd-modal', () => {
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
        ko.cleanNode($('#frmBangKiemXXDD')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmBangKiemXXDD").empty();
        $(this.item.HTML).appendTo("#frmBangKiemXXDD");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();
        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            self.MaSo = ko.observable(item.MaSo);
            self.PhanHai_TenNCYSH = ko.observable(item.PhanHai_TenNCYSH);
            self.PhanHai_NCVChinh_HoTen = ko.observable(item.PhanHai_NCVChinh_HoTen);
            self.PhanHai_NCVChinh_KhoaPhong = ko.observable(item.PhanHai_NCVChinh_KhoaPhong);
            self.PhanHai_NCVChinh_BenhVien = ko.observable(item.PhanHai_NCVChinh_BenhVien);
            self.PhanHai_NCVChinh_DienThoai = ko.observable(item.PhanHai_NCVChinh_DienThoai);
            self.PhanHai_NCVChinh_Email = ko.observable(item.PhanHai_NCVChinh_Email);
            self.PhanHai_NCVChinh_DiaChiLienHe = ko.observable(item.PhanHai_NCVChinh_DiaChiLienHe);
            self.PhanHai_NGS_HoTen = ko.observable(item.PhanHai_NGS_HoTen);
            self.PhanHai_NGS_NoiLamViec = ko.observable(item.PhanHai_NGS_NoiLamViec);
            self.PhanHai_NGS_DienThoai = ko.observable(item.PhanHai_NGS_DienThoai);
            self.PhanHai_NGS_Email = ko.observable(item.PhanHai_NGS_Email);
            self.PhanBon_C1_MoTaQuyTrinh = ko.observable(item.PhanBon_C1_MoTaQuyTrinh);
            self.PhanBon_C1_NoiNhanMau = ko.observable(item.PhanBon_C1_NoiNhanMau);
            self.PhanBon_C1_DanSoChonMau = ko.observable(item.PhanBon_C1_DanSoChonMau);
            self.PhanBon_C1_CoMauNghienCuu = ko.observable(item.PhanBon_C1_CoMauNghienCuu);
            self.PhanBon_C1_TieuChuanNhanVao = ko.observable(item.PhanBon_C1_TieuChuanNhanVao);
            self.PhanBon_C1_TieuChuanLoaiRa = ko.observable(item.PhanBon_C1_TieuChuanLoaiRa);
            self.PhanBon_C2_MoTaQuyTrinh = ko.observable(item.PhanBon_C2_MoTaQuyTrinh);
            self.PhanBon_C2_CachTienHanh = ko.observable(item.PhanBon_C2_CachTienHanh);
            self.PhanBon_C3_MoTaQuyTrinh = ko.observable(item.PhanBon_C3_MoTaQuyTrinh);

            self.ThoiGianTienHanh_Ngay = ko.observable(item.ThoiGianTienHanh_Ngay);
            self.ThoiGianTienHanh_Thang = ko.observable(item.ThoiGianTienHanh_Thang);
            self.ThoiGianTienHanh_Nam = ko.observable(item.ThoiGianTienHanh_Nam);
            self.ThoiGianTienHanhDenNgay_Ngay = ko.observable(item.ThoiGianTienHanhDenNgay_Ngay);
            self.ThoiGianTienHanhDenNgay_Thang = ko.observable(item.ThoiGianTienHanhDenNgay_Thang);
            self.ThoiGianTienHanhDenNgay_Nam = ko.observable(item.ThoiGianTienHanhDenNgay_Nam);

            self.ThoiGianThuThap_Ngay = ko.observable(item.ThoiGianThuThap_Ngay);
            self.ThoiGianThuThap_Thang = ko.observable(item.ThoiGianThuThap_Thang);
            self.ThoiGianThuThap_Nam = ko.observable(item.ThoiGianThuThap_Nam);
            self.ThoiGianThuThapDenNgay_Ngay = ko.observable(item.ThoiGianThuThapDenNgay_Ngay);
            self.ThoiGianThuThapDenNgay_Thang = ko.observable(item.ThoiGianThuThapDenNgay_Thang);
            self.ThoiGianThuThapDenNgay_Nam = ko.observable(item.ThoiGianThuThapDenNgay_Nam);

            self.ThoiGianNghienCuu_Ngay = ko.observable(item.ThoiGianNghienCuu_Ngay);
            self.ThoiGianNghienCuu_Thang = ko.observable(item.ThoiGianNghienCuu_Thang);
            self.ThoiGianNghienCuu_Nam = ko.observable(item.ThoiGianNghienCuu_Nam);
            self.ThoiGianNghienCuuDenNgay_Ngay = ko.observable(item.ThoiGianNghienCuuDenNgay_Ngay);
            self.ThoiGianNghienCuuDenNgay_Thang = ko.observable(item.ThoiGianNghienCuuDenNgay_Thang);
            self.ThoiGianNghienCuuDenNgay_Nam = ko.observable(item.ThoiGianNghienCuuDenNgay_Nam);


            self.PhanSau_NCYSH_HoTen = ko.observable(item.PhanSau_NCYSH_HoTen);
            self.PhanSau_NCYSH_NgayThangNam = ko.observable(item.PhanSau_NCYSH_NgayThangNam);
            self.PhanSau_NGS_HoTen = ko.observable(item.PhanSau_NGS_HoTen);
            self.PhanSau_NGS_NgayThangNam = ko.observable(item.PhanSau_NGS_NgayThangNam);
            self.PhanSau_TruongKhoa_HoTen = ko.observable(item.PhanSau_TruongKhoa_HoTen);
            self.PhanSau_TruongKhoa_ChucVu = ko.observable(item.PhanSau_TruongKhoa_ChucVu);
            self.PhanSau_TruongKhoa_NgayThangNam = ko.observable(item.PhanSau_TruongKhoa_NgayThangNam);
            self.YKienHDDD_NhanXet = ko.observable(item.YKienHDDD_NhanXet);
            self.YKienHDDD_So = ko.observable(item.YKienHDDD_So);
            self.NgayKy_Ngay = ko.observable(item.NgayKy_Ngay);
            self.NgayKy_Thang = ko.observable(item.NgayKy_Thang);
            self.NgayKy_Nam = ko.observable(item.NgayKy_Nam);
            self.MoTaNCYSH = ko.observable({
                ThongTin: ko.observable(item.MoTaNCYSH.ThongTin),
            });

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
        ko.applyBindings(this.model, document.getElementById("frmBangKiemXXDD"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmBangKiemXXDD").html();
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
}