import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_MauPhanTichDuLieuCustomProvider, PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-mau-phan-tich-du-lieu-modal', priority: 'high', defaultHistory: ['page-mau-phan-tich-du-lieu-modal'] })
@Component({
    selector: 'mau-phan-tich-du-lieu-modal',
    templateUrl: 'mau-phan-tich-du-lieu-modal.html',
})
export class MauPhanTichDuLieuModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_MauPhanTichDuLieuCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public deTaiCustomProvider: PRO_DeTaiCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-mau-phan-tich-du-lieu-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-mau-phan-tich-du-lieu-modal";
        this.events.unsubscribe('app:Close-page-mau-phan-tich-du-lieu-modal');
        this.events.subscribe('app:Close-page-mau-phan-tich-du-lieu-modal', () => {
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
        ko.cleanNode($('#frmMauPhanTichDuLieu')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmMauPhanTichDuLieu").empty();
        $(this.item.HTML).appendTo("#frmMauPhanTichDuLieu");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();

        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            self.DacDiemNen = ko.observable({
                TuoiVo: item.DacDiemNen.TuoiVo,
                BMI: item.DacDiemNen.BMI,
                AMHVo: item.DacDiemNen.AMHVo,
                AFC: item.DacDiemNen.AFC,
                ThoiGianVoSinh: item.DacDiemNen.ThoiGianVoSinh,
                SoChuKyChocHut: item.DacDiemNen.SoChuKyChocHut,
                LoaiVoSinh: item.DacDiemNen.LoaiVoSinh,
                ChiDinhTTTON: item.DacDiemNen.ChiDinhTTTON,
            });
            self.KichThichBuongTrung = ko.observable({
                E2NgayTrigger: item.KichThichBuongTrung.E2NgayTrigger,
                P4NgayTrigger: item.KichThichBuongTrung.P4NgayTrigger,
                ThoiGianKTBT: item.KichThichBuongTrung.ThoiGianKTBT,
                LieuDauFSH: item.KichThichBuongTrung.LieuDauFSH,
                TongLieuFSH: item.KichThichBuongTrung.TongLieuFSH,
                SoTrungChocHut: item.KichThichBuongTrung.SoTrungChocHut,
            });
            self.LaBo = ko.observable({
                SoTrungICSI: item.LaBo.SoTrungICSI,
                SoTrungThuTinh: item.LaBo.SoTrungThuTinh,
                TyLe2PN: item.LaBo.TyLe2PN,
                TyLeTaoPhoi: item.LaBo.TyLeTaoPhoi,
                SoPhoi: item.LaBo.SoPhoi,
                SoPhoiL1L2: item.LaBo.SoPhoiL1L2,
            });
            self.ChuKyChuyenPhoi = ko.observable({
                SoPhoiChuyenTB: item.ChuKyChuyenPhoi.SoPhoiChuyenTB,
                SoPhoiTotChuyenTB: item.ChuKyChuyenPhoi.SoPhoiTotChuyenTB,
                NMTC: item.ChuKyChuyenPhoi.NMTC
            });
            self.KetQuaThai = ko.observable({
                TyLeBeTaDuong: item.KetQuaThai.TyLeBeTaDuong,
                TyLeThaiLamSang: item.KetQuaThai.TyLeThaiLamSang,
                TyLeLamTo: item.KetQuaThai.TyLeLamTo,
                TyLeDaThai2Thai: item.KetQuaThai.TyLeDaThai2Thai,
                TyLeDaThai3Thai: item.KetQuaThai.TyLeDaThai3Thai,
                TyLeSayThaiDuoi12W: item.KetQuaThai.TyLeSayThaiDuoi12W,
                TyLeThaiDienTien12W: item.KetQuaThai.TyLeThaiDienTien12W,
                TyLeSayThai1224W: item.KetQuaThai.TyLeSayThai1224W,
                TyLeThaiDienTien24W: item.KetQuaThai.TyLeThaiDienTien24W,
                TyLeSayThaiTren24W: item.KetQuaThai.TyLeSayThaiTren24W,
                TyLeSinhSong: item.KetQuaThai.TyLeSinhSong,
                TyLeSinhDoi: item.KetQuaThai.TyLeSinhDoi,
                LoaiThaiSinh: item.KetQuaThai.LoaiThaiSinh,
                SinhThuong: item.KetQuaThai.SinhThuong,
                SinhMo: item.KetQuaThai.SinhMo,
                TuanThaiSinh: item.KetQuaThai.TuanThaiSinh,
                CanNangTre: item.KetQuaThai.CanNangTre,
                QuaKichBuongTrung: item.KetQuaThai.QuaKichBuongTrung,
                BienChungSanKhoa: item.KetQuaThai.BienChungSanKhoa,
                CaoHuyetApThaiKy: item.KetQuaThai.CaoHuyetApThaiKy,
                TieuDuongThaiKy: item.KetQuaThai.TieuDuongThaiKy,
            });
            self.BienSoKhac = ko.observable({
                Dong1: ko.observable(item.BienSoKhac.Dong1),
                Dong2: ko.observable(item.BienSoKhac.Dong2),
                Dong3: ko.observable(item.BienSoKhac.Dong3),
                Dong4: ko.observable(item.BienSoKhac.Dong4)
            });

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmMauPhanTichDuLieu"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmMauPhanTichDuLieu").html();
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
                pxHeader: $("#frmMauPhanTichDuLieu .form-template-header").height(),
                pxFooter: $("#frmMauPhanTichDuLieu .form-template-footer").height(),
                htmlContent: $("#frmMauPhanTichDuLieu .form-template-body").html(),
                htmlFooter: $("#frmMauPhanTichDuLieu .form-template-footer").html(),
                htmlHeader: $("#frmMauPhanTichDuLieu .form-template-header").html()
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