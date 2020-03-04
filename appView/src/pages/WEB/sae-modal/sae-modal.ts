import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_SAECustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';

@IonicPage({ name: 'page-sae-modal', priority: 'high', defaultHistory: ['page-sae-modal'] })
@Component({
    selector: 'sae-modal',
    templateUrl: 'sae-modal.html',
})
export class SAEModalPage extends DetailPage {
    id: any;
    idDeTai: any;
    idBenhNhan: any;
    model: any;
    constructor(
        public currentProvider: PRO_SAECustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public viewCtrl: ViewController,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-sae-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-sae-modal";
        this.events.unsubscribe('app:Close-page-sae-modal');
        this.events.subscribe('app:Close-page-sae-modal', () => {
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
        ko.cleanNode($('#frmSAE')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmSAE").empty();
        $(this.item.HTML).appendTo("#frmSAE");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();

        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);

            self.MaSo = ko.observable(item.MaSo);
            self.TenNghienCuu = ko.observable(item.TenNghienCuu);
            self.NhaTaiTro = ko.observable(item.NhaTaiTro);
            self.HoTenNCV = ko.observable(item.HoTenNCV);
            self.DiemNghienCuu = ko.observable(item.DiemNghienCuu);
            self.ThoiDiemNhanThongTin = ko.observable(item.ThoiDiemNhanThongTin);
            self.ThoiDiemXuatHien = ko.observable(item.ThoiDiemXuatHien);
            self.ThoiDiemKetThuc = ko.observable(item.ThoiDiemKetThuc);
            self.TenSAE = ko.observable(item.TenSAE);
            self.TenNguoiThuThuoc = ko.observable(item.TenNguoiThuThuoc);
            self.MaSoNguoiThuThuoc = ko.observable(item.MaSoNguoiThuThuoc);
            self.MoTaDienBien = ko.observable(item.MoTaDienBien);
            self.KetQua_TuVong_Ngay = ko.observable(item.KetQua_TuVong_Ngay);
            self.NguoiThamGia_NgaySinh = ko.observable(item.NguoiThamGia_NgaySinh);
            self.NguoiThamGia_Tuoi = ko.observable(item.NguoiThamGia_Tuoi);
            self.NguoiThamGia_GioiTinh_Nu_TuanMangThai = ko.observable(item.NguoiThamGia_GioiTinh_Nu_TuanMangThai);
            self.NguoiThamGia_CanNang = ko.observable(item.NguoiThamGia_CanNang);
            self.NguoiThamGia_TienSuYKhoa = ko.observable(item.NguoiThamGia_TienSuYKhoa);
            self.LyDoDanhGia = ko.observable(item.LyDoDanhGia);
            self.LyDoDanhGia_SoLuong = ko.observable(item.LyDoDanhGia_SoLuong);
            self.LyDoDanhGia_SoLuongNghienCuuKhac = ko.observable(item.LyDoDanhGia_SoLuongNghienCuuKhac);
            self.YKienHDDD_DeXuatKhac = ko.observable(item.YKienHDDD_DeXuatKhac);
            self.NguoiBaoCao_ChuKy = ko.observable(item.NguoiBaoCao_ChuKy);
            self.NguoiBaoCao_NgayKy = ko.observable(item.NguoiBaoCao_NgayKy);
            self.NguoiBaoCao_HoTen = ko.observable(item.NguoiBaoCao_HoTen);
            self.NguoiBaoCao_ChucVu = ko.observable(item.NguoiBaoCao_ChucVu);
            self.NguoiBaoCao_DienThoai = ko.observable(item.NguoiBaoCao_DienThoai);
            self.NguoiBaoCao_Email = ko.observable(item.NguoiBaoCao_Email);
            
            self.ListThuocThuLamSan = ko.observableArray(ko.utils.arrayMap(item.ListThuocThuLamSan || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    TenThuoc: ko.observable(nn.TenThuoc || ""),
                    DangBaoChe: ko.observable(nn.DangBaoChe || ""),
                    DuongDung: ko.observable(nn.DuongDung || ""),
                    LieuDung: ko.observable(nn.LieuDung || ""),
                    NgayBatDau: ko.observable(nn.NgayBatDau || ""),
                    NgayKetThuc: ko.observable(nn.NgayKetThuc || "")
                };
            }));
            
            self.ListCanThiepThuocThuLamSan = ko.observableArray(ko.utils.arrayMap(item.ListCanThiepThuocThuLamSan || [{}, {}, {}, {}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    NgungLieu_Co: ko.observable(nn.NgungLieu_Co || false),
                    NgungLieu_Khong: ko.observable(nn.NgungLieu_Khong || false),
                    CaiThien_Co: ko.observable(nn.CaiThien_Co || false),
                    CaiThien_Khong: ko.observable(nn.CaiThien_Khong || false),
                    CaiThien_KhongCoThongTin: ko.observable(nn.CaiThien_KhongCoThongTin || false),
                    XuatHienLai_Co: ko.observable(nn.XuatHienLai_Co || false),
                    XuatHienLai_Khong: ko.observable(nn.XuatHienLai_Khong || false),
                    XuatHienLai_KhongCoThongTin: ko.observable(nn.XuatHienLai_KhongCoThongTin || false),
                    XuatHienLai_KhongTaiSuDung: ko.observable(nn.XuatHienLai_KhongTaiSuDung || false)
                };
            }));

            self.ListThuocSuDungDongThoi = ko.observableArray(ko.utils.arrayMap(item.ListThuocSuDungDongThoi || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    TenThuoc: ko.observable(nn.TenThuoc || ""),
                    DangBaoChe: ko.observable(nn.DangBaoChe || ""),
                    DuongDung: ko.observable(nn.DuongDung || ""),
                    LieuDung: ko.observable(nn.LieuDung || ""),
                    NgayBatDau: ko.observable(nn.NgayBatDau || ""),
                    NgayKetThuc: ko.observable(nn.NgayKetThuc || "")
                };
            }));

            self.ListDanhGiaNCV = ko.observableArray(ko.utils.arrayMap(item.ListDanhGiaNCV || [{}, {}, {}, {}, {}, {}, {}], function (nn) {
                return {
                    STT: ko.observable(nn.STT || ""),
                    KetQua_Co: ko.observable(nn.KetQua_Co || false),
                    KetQua_Khong: ko.observable(nn.KetQua_Khong || false),
                    KetQua_ChuaKetLuan: ko.observable(nn.KetQua_ChuaKetLuan || false),
                    PhanUng_DuocDuKien: ko.observable(nn.PhanUng_DuocDuKien || false),
                    PhanUng_NgoaiDuKien: ko.observable(nn.PhanUng_NgoaiDuKien || false)
                };
            }));

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmSAE"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmSAE").html();
        console.log(item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.saveCustom(item).then((savedItem: any) => {
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
                htmlContent: $("#frmSAE .form-template-body").html(),
                htmlFooter: $("#frmSAE .form-template-footer").html(),
                htmlHeader: $("#frmSAE .form-template-header").html()
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