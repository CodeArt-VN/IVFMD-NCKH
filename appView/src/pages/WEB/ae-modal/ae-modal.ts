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
        
        this.nckhProvider.init();

        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);

            self.MaSo = ko.observable(item.MaSo);
            self.MaSoBenhNhan = ko.observable(item.MaSoBenhNhan);
            self.TenBienCo = ko.observable(item.TenBienCo);
            self.NgayKhoiPhat_Ngay = ko.observable(item.NgayKhoiPhat_Ngay);
            self.NgayKhoiPhat_Thang = ko.observable(item.NgayKhoiPhat_Thang);
            self.NgayKhoiPhat_Nam = ko.observable(item.NgayKhoiPhat_Nam);
            self.NgayKhoiPhat_Gio = ko.observable(item.NgayKhoiPhat_Gio);
            self.NgayKhoiPhat_Phut = ko.observable(item.NgayKhoiPhat_Phut);
            self.NgayKhoiPhat_DangTiepDien = ko.observable(item.NgayKhoiPhat_DangTiepDien);
            self.PhanDoNang_Nghe = ko.observable(item.PhanDoNang_Nghe);
            self.PhanDoNang_TrungBinh = ko.observable(item.PhanDoNang_TrungBinh);
            self.PhanDoNang_Nang = ko.observable(item.PhanDoNang_Nang);
            self.CanDieuTri_Khong = ko.observable(item.CanDieuTri_Khong);
            self.CanDieuTri_Co = ko.observable(item.CanDieuTri_Co);
            self.HDThuocNghienCuu_KhongApDung = ko.observable(item.HDThuocNghienCuu_KhongApDung);
            self.HDThuocNghienCuu_NgungSuDung = ko.observable(item.HDThuocNghienCuu_NgungSuDung);
            self.HDThuocDungKem_KhongApDung = ko.observable(item.HDThuocDungKem_KhongApDung);
            self.HDThuocDungKem_NgungSuDung = ko.observable(item.HDThuocDungKem_NgungSuDung);
            self.LyDoThuocNghienCuu_Khong = ko.observable(item.LyDoThuocNghienCuu_Khong);
            self.LyDoThuocNghienCuu_Co = ko.observable(item.LyDoThuocNghienCuu_Co);
            self.LyDoThuocDungKem_Khong = ko.observable(item.LyDoThuocDungKem_Khong);
            self.LyDoThuocDungKem_Co = ko.observable(item.LyDoThuocDungKem_Co);
            self.KetQua_HoiPhucKhongDiChung = ko.observable(item.KetQua_HoiPhucKhongDiChung);
            self.KetQua_CoDiChung = ko.observable(item.KetQua_CoDiChung);
            self.KetQua_DangHoiPhuc = ko.observable(item.KetQua_DangHoiPhuc);
            self.KetQua_ChuaHoiPhuc = ko.observable(item.KetQua_ChuaHoiPhuc);
            self.KetQua_KhongBiet = ko.observable(item.KetQua_KhongBiet);
            self.KetQua_TuVong_Ngay = ko.observable(item.KetQua_TuVong_Ngay);
            self.KetQua_TuVong_Thang = ko.observable(item.KetQua_TuVong_Thang);
            self.KetQua_TuVong_Nam = ko.observable(item.KetQua_TuVong_Nam);
            self.NghiemTrong_Khong = ko.observable(item.NghiemTrong_Khong);
            self.NghiemTrong_Co = ko.observable(item.NghiemTrong_Co);
            self.NghiemTrong_TuVong = ko.observable(item.NghiemTrong_TuVong);
            self.NghiemTrong_DeDoaTinhMang = ko.observable(item.NghiemTrong_DeDoaTinhMang);
            self.NghiemTrong_NhapVien = ko.observable(item.NghiemTrong_NhapVien);
            self.NghiemTrong_TanTat = ko.observable(item.NghiemTrong_TanTat);
            self.NghiemTrong_BatThuong = ko.observable(item.NghiemTrong_BatThuong);
            self.NghiemTrong_BienCoKhac = ko.observable(item.NghiemTrong_BienCoKhac);
            self.TienHanhSAE_Khong = ko.observable(item.TienHanhSAE_Khong);
            self.TienHanhSAE_Co = ko.observable(item.TienHanhSAE_Co);
            self.HoTenThucHien = ko.observable(item.HoTenThucHien);
            self.NgayBaoCao_Ngay = ko.observable(item.NgayBaoCao_Ngay);
            self.NgayBaoCao_Thang = ko.observable(item.NgayBaoCao_Thang);
            self.NgayBaoCao_Nam = ko.observable(item.NgayBaoCao_Nam);
            self.NT_NgayGioTangDoNang_Ngay = ko.observable(item.NT_NgayGioTangDoNang_Ngay);
            self.NT_NgayGioTangDoNang_Thang = ko.observable(item.NT_NgayGioTangDoNang_Thang);
            self.NT_NgayGioTangDoNang_Nam = ko.observable(item.NT_NgayGioTangDoNang_Nam);
            self.NT_NgayGioTangDoNang_Gio = ko.observable(item.NT_NgayGioTangDoNang_Gio);
            self.NT_NgayGioTangDoNang_Phut = ko.observable(item.NT_NgayGioTangDoNang_Phut);
            self.NT_DoNangAE_Nhe = ko.observable(item.NT_DoNangAE_Nhe);
            self.NT_DoNangAE_TrungBinh = ko.observable(item.NT_DoNangAE_TrungBinh);
            self.NT_DoNangAE_Nang = ko.observable(item.NT_DoNangAE_Nang);
            self.NT_YeuCauDieuTri_Khong = ko.observable(item.NT_YeuCauDieuTri_Khong);
            self.NT_YeuCauDieuTri_Co = ko.observable(item.NT_YeuCauDieuTri_Co);
            self.NT_HDThuocNghienCuu_KhongApDung = ko.observable(item.NT_HDThuocNghienCuu_KhongApDung);
            self.NT_HDThuocNghienCuu_NgungSuDung = ko.observable(item.NT_HDThuocNghienCuu_NgungSuDung);
            self.NT_HDThuocDungKem_KhongApDung = ko.observable(item.NT_HDThuocDungKem_KhongApDung);
            self.NT_HDThuocDungKem_NgungSuDung = ko.observable(item.NT_HDThuocDungKem_NgungSuDung);
            self.NT_LyDoThuocNghienCuu_Khong = ko.observable(item.NT_LyDoThuocNghienCuu_Khong);
            self.NT_LyDoThuocNghienCuu_Co = ko.observable(item.NT_LyDoThuocNghienCuu_Co);
            self.NT_LyDoThuocDungKem_Khong = ko.observable(item.NT_LyDoThuocDungKem_Khong);
            self.NT_LyDoThuocDungKem_Co = ko.observable(item.NT_LyDoThuocDungKem_Co);
            self.NT_NghiemTrong_Khong = ko.observable(item.NT_NghiemTrong_Khong);
            self.NT_NghiemTrong_Co = ko.observable(item.NT_NghiemTrong_Co);
            self.NT_NghiemTrong_TuVong = ko.observable(item.NT_NghiemTrong_TuVong);
            self.NT_NghiemTrong_DeDoaTinhMang = ko.observable(item.NT_NghiemTrong_DeDoaTinhMang);
            self.NT_NghiemTrong_NhapVien = ko.observable(item.NT_NghiemTrong_NhapVien);
            self.NT_NghiemTrong_TanTat = ko.observable(item.NT_NghiemTrong_TanTat);
            self.NT_NghiemTrong_BatThuong = ko.observable(item.NT_NghiemTrong_BatThuong);
            self.NT_NghiemTrong_BienCoKhac = ko.observable(item.NT_NghiemTrong_BienCoKhac);
            self.NT_HoTenThucHien = ko.observable(item.NT_HoTenThucHien);
            self.NT_NgayBaoCao_Ngay = ko.observable(item.NT_NgayBaoCao_Ngay);
            self.NT_NgayBaoCao_Thang = ko.observable(item.NT_NgayBaoCao_Thang);
            self.NT_NgayBaoCao_Nam = ko.observable(item.NT_NgayBaoCao_Nam);
            self.NT_GhiChu = ko.observable(item.NT_GhiChu);
            self.NgayKetThuc_Ngay = ko.observable(item.NgayKetThuc_Ngay);
            self.NgayKetThuc_Thang = ko.observable(item.NgayKetThuc_Thang);
            self.NgayKetThuc_Nam = ko.observable(item.NgayKetThuc_Nam);
            self.NgayKetThuc_Gio = ko.observable(item.NgayKetThuc_Gio);
            self.NgayKetThuc_Phut = ko.observable(item.NgayKetThuc_Phut);
            self.KetQua_TuVong = ko.observable(item.KetQua_TuVong);
            self.TienHanhSAE1_Co = ko.observable(item.TienHanhSAE1_Co);
            self.TienHanhSAE1_Khong = ko.observable(item.TienHanhSAE1_Khong);

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