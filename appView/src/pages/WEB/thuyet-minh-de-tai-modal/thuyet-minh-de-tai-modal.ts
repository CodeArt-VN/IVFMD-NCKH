import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_ThuyetMinhDeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { NCKHServiceProvider } from '../../../providers/CORE/nckh-service';
@IonicPage({ name: 'page-thuyet-minh-de-tai-modal', priority: 'high', defaultHistory: ['page-thuyet-minh-de-tai-modal'] })
@Component({
    selector: 'thuyet-minh-de-tai-modal',
    templateUrl: 'thuyet-minh-de-tai-modal.html',
})
export class ThuyetMinhDeTaiModalPage extends DetailPage {
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: PRO_ThuyetMinhDeTaiCustomProvider,
        public nckhProvider: NCKHServiceProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-thuyet-minh-de-tai-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-thuyet-minh-de-tai-modal";
        this.events.unsubscribe('app:Close-page-thuyet-minh-de-tai-modal');
        this.events.subscribe('app:Close-page-thuyet-minh-de-tai-modal', () => {
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
        ko.cleanNode($('#frmThuyetMinhDeTai')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmThuyetMinhDeTai").empty();
        $(this.item.HTML).appendTo("#frmThuyetMinhDeTai");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();
        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            self.filter = function (arr, prop, ko, val) {
                console.log(val)
                var data = arr().filter(function (v) {
                    if (ko) {
                        return v[prop]() == val;
                    } else {
                        return v[prop] == val;
                    }
                })
                var removable = data.length > 1 ? 1 : 0;
                var ab = data.map(function (o) {
                    o.removable = removable;
                    return o;
                })
                return ab;
            }
            
            self.A1_TenTiengViet = ko.observable(item.A1_TenTiengViet);
            self.A1_TenTiengAnh = ko.observable(item.A1_TenTiengAnh);
            self.A2_KhacMoTa = ko.observable(item.A2_KhacMoTa);
            self.A4_ThoiGianThucHien = ko.observable(item.A4_ThoiGianThucHien);
            self.A5_TongKinhPhi = ko.observable(item.A5_TongKinhPhi);
            self.A6_HoTen = ko.observable(item.A6_HoTen);
            self.A6_NgaySinh = ko.observable(item.A6_NgaySinh);
            self.A6_GioiTinh = ko.observable(item.A6_GioiTinh);
            self.A6_CMND = ko.observable(item.A6_CMND);
            self.A6_NgayCap = ko.observable(item.A6_NgayCap);
            self.A6_NoiCap = ko.observable(item.A6_NoiCap);
            self.A6_MST = ko.observable(item.A6_MST);
            self.A6_STK = ko.observable(item.A6_STK);
            self.A6_NganHang = ko.observable(item.A6_NganHang);
            self.A6_DiaChiCoQuan = ko.observable(item.A6_DiaChiCoQuan);
            self.A6_DienThoai = ko.observable(item.A6_DienThoai);
            self.A6_Email = ko.observable(item.A6_Email);
            self.A6_TomTatHoatDong = ko.observable(item.A6_TomTatHoatDong);
            self.A7_TenCoQuan = ko.observable(item.A7_TenCoQuan);
            self.A7_HoTenThuTruong = ko.observable(item.A7_HoTenThuTruong);
            self.A7_DienThoai = ko.observable(item.A7_DienThoai);
            self.A7_DiaChi = ko.observable(item.A7_DiaChi);
            self.A8_CoQuanPhoiHopThucHien = ko.observable(item.A8_CoQuanPhoiHopThucHien);
            self.B1_GioiThieu = ko.observable(item.B1_GioiThieu);
            self.B2_TaiLieuThamKhao = ko.observable(item.B2_TaiLieuThamKhao);
            self.B311_MucTieuNghienCuu = ko.observable(item.B311_MucTieuNghienCuu);
            self.B312_ChiTieuDanhGia = ko.observable(item.B312_ChiTieuDanhGia);
            self.B313_DiaChi = ko.observable(item.B313_DiaChi);
            self.B321_ThietKeNghienCuu = ko.observable(item.B321_ThietKeNghienCuu);
            self.B322_DanSoNghienCuu = ko.observable(item.B322_DanSoNghienCuu);
            self.B3221_TieuChuanNhanLoai = ko.observable(item.B3221_TieuChuanNhanLoai);
            self.B3222_CoMau = ko.observable(item.B3222_CoMau);
            self.B323_PhuongPhapTienHanh = ko.observable(item.B323_PhuongPhapTienHanh);
            self.B324_PhuongPhapDanhGia = ko.observable(item.B324_PhuongPhapDanhGia);
            self.B3241_YeuToDanhGiaKetQua = ko.observable(item.B3241_YeuToDanhGiaKetQua);
            self.B3242_CacBienChungDieuTri = ko.observable(item.B3242_CacBienChungDieuTri);
            self.B3243_CacBienChungVeSanKhoa = ko.observable(item.B3243_CacBienChungVeSanKhoa);
            self.B325_PhuongPhapPhanTich = ko.observable(item.B325_PhuongPhapPhanTich);
            self.B327_BangKetQuaDuKien = ko.observable(item.B327_BangKetQuaDuKien);
            self.B328_VanDeYDuc = ko.observable(item.B328_VanDeYDuc);
            self.B329_TinhKhaThi = ko.observable(item.B329_TinhKhaThi);
            self.B33_PhuongAnPhoiHop = ko.observable(item.B33_PhuongAnPhoiHop);
            self.B33_PhuongAnPhoiHopPTN = ko.observable(item.B33_PhuongAnPhoiHopPTN);
            self.B33_PhuongAnPhoiHopDonVi = ko.observable(item.B33_PhuongAnPhoiHopDonVi);
            self.B33_PhuongAnPhoiHopCGCN = ko.observable(item.B33_PhuongAnPhoiHopCGCN);
            self.B4_KetQuaNghienCuu = ko.observable(item.B4_KetQuaNghienCuu);
            self.B41_AnPhamKhoaHoc = ko.observable(item.B41_AnPhamKhoaHoc);
            self.B42_DangKySoHuuTriTue = ko.observable(item.B42_DangKySoHuuTriTue);
            self.B43_KetQuaDaoTao = ko.observable(item.B43_KetQuaDaoTao);
            self.B5_KhaNangUngDung = ko.observable(item.B5_KhaNangUngDung);
            self.B51_KhaNangUngDungLinhVucDaoTao = ko.observable(item.B51_KhaNangUngDungLinhVucDaoTao);
            self.B52_TongHopKinhPhi = ko.observable(item.B52_TongHopKinhPhi);
            self.B52_CoQuanChuTri_NgayKy_Ngay = ko.observable(item.B52_CoQuanChuTri_NgayKy_Ngay);
            self.B52_CoQuanChuTri_NgayKy_Thang = ko.observable(item.B52_CoQuanChuTri_NgayKy_Thang);
            self.B52_CoQuanChuTri_NgayKy_Nam = ko.observable(item.B52_CoQuanChuTri_NgayKy_Nam);
            self.B52_CoQuanChuTri_NgayKy_ChuKy = ko.observable(item.B52_CoQuanChuTri_NgayKy_ChuKy);
            self.B52_CNDT_NgayKy_Ngay = ko.observable(item.B52_CNDT_NgayKy_Ngay);
            self.B52_CNDT_NgayKy_Thang = ko.observable(item.B52_CNDT_NgayKy_Thang);
            self.B52_CNDT_NgayKy_Nam = ko.observable(item.B52_CNDT_NgayKy_Nam);
            self.B52_CNDT_NgayKy_ChuKy = ko.observable(item.B52_CNDT_NgayKy_ChuKy);

            self.ChuNhiemDeTai = ko.observable({
                HoTen: ko.observable(item.ChuNhiemDeTai.HoTen || ""),
                DonVi: ko.observable(item.ChuNhiemDeTai.DonVi || ""),
                SoThangLamViec: ko.observable(item.ChuNhiemDeTai.SoThangLamViec || ""),
            })

            self.ListNhanLucNghienCuu = ko.observableArray(ko.utils.arrayMap(item.ListNhanLucNghienCuu || [{}, {}, {}, {}], function (nn) {
                return {
                    TT: ko.observable(nn.TT || ""),
                    HoTen: ko.observable(nn.HoTen || ""),
                    DonVi: ko.observable(nn.DonVi || ""),
                    SoThangLamViec: ko.observable(nn.SoThangLamViec || "")
                };
            }));

            self.ListGioiThieuChuyenGia = ko.observableArray(ko.utils.arrayMap(item.ListGioiThieuChuyenGia || [{}, {}, {}, {}, {}], function (nn) {
                return {
                    TT: ko.observable(nn.TT || ""),
                    HoTen: ko.observable(nn.HoTen || ""),
                    HuongNghienCuu: ko.observable(nn.HuongNghienCuu || ""),
                    CoQuan: ko.observable(nn.CoQuan || ""),
                    DienThoai: ko.observable(nn.DienThoai || "")
                };
            }));

            self.ListKeHoachThucHien = ko.observableArray(ko.utils.arrayMap(item.ListKeHoachThucHien, function (nn) {
                return {
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    ThoiGianThucHien: ko.observable(nn.ThoiGianThucHien || ""),
                    DuKienKetQua: ko.observable(nn.DuKienKetQua || ""),
                    NguoiThucHien: ko.observable(nn.NguoiThucHien || "")
                };
            }));

            self.ListKinhPhiCongLaoDong = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiCongLaoDong, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi || ""),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiNguyenVatLieu = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiNguyenVatLieu, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi || ""),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiThietBi = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiThietBi, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi || ""),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiKhac = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiKhac, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi || ""),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    GhiChu: ko.observable(nn.GhiChu || "")
                };
            }));
            self.ListKinhPhiTongHop = ko.observableArray(ko.utils.arrayMap(item.ListKinhPhiTongHop, function (nn) {
                return {
                    LoaiKinhPhi: ko.observable(nn.LoaiKinhPhi || ""),
                    NoiDung: ko.observable(nn.NoiDung || ""),
                    KinhPhi: ko.observable(nn.KinhPhi || ""),
                    KhoanChi: ko.observable(nn.KhoanChi || ""),
                    PhanTram: ko.observable(nn.PhanTram || "")
                };
            }));

            self.ListBienSo = ko.observableArray(ko.utils.arrayMap(item.ListBienSo || [{ LoaiBienSo: 1 }, { LoaiBienSo: 2 }, { LoaiBienSo: 0 }], function (nn) {
                return {
                    Ten: ko.observable(nn.Ten || ""),
                    PhanLoai: ko.observable(nn.PhanLoai || ""),
                    GiaTri: ko.observable(nn.GiaTri || ""),
                    CachThuThap: ko.observable(nn.CachThuThap || ""),
                    LoaiBienSo: ko.observable(nn.LoaiBienSo)
                };
            }));

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmThuyetMinhDeTai"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmThuyetMinhDeTai").html();
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
}