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
        $(this.item.HTML).appendTo("#frmPhieuXemXetDaoDuc");
        let id = this.item.ID;
        var that = this;
        this.nckhProvider.init();
        let ObjModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            self.ID = item.ID;
            self.IDDeTai = item.IDDeTai;
            self.MaSo = ko.observable(item.MaSo);
            self.NghienCuuDuocTaiTro = ko.observable(item.NghienCuuDuocTaiTro);
            self.XinPhepTapThe = ko.observable(item.XinPhepTapThe);
            self.KhongThuocNghienCuuNao = ko.observable(item.KhongThuocNghienCuuNao);
            self.NghienCuuHocVienSauDaiHoc = ko.observable(item.NghienCuuHocVienSauDaiHoc);
            self.DonXinTaiCapPhep = ko.observable(item.DonXinTaiCapPhep);
            self.NghienCuuCuaSinhVienDaiHoc = ko.observable(item.NghienCuuCuaSinhVienDaiHoc);
            self.SoGiayPhepCu = ko.observable(item.SoGiayPhepCu);
            self.TenNCSYH = ko.observable(item.TenNCSYH);
            self.DonViChuTri = ko.observable(item.DonViChuTri);
            self.NguoiGiaoDich_HoTen = ko.observable(item.NguoiGiaoDich_HoTen);
            self.NguoiGiaoDich_DienThoaiCQ = ko.observable(item.NguoiGiaoDich_DienThoaiCQ);
            self.NguoiGiaoDich_DienThoaiFx = ko.observable(item.NguoiGiaoDich_DienThoaiFx);
            self.NguoiGiaoDich_DienThoaiNR = ko.observable(item.NguoiGiaoDich_DienThoaiNR);
            self.NguoiGiaoDich_DienThoaiDD = ko.observable(item.NguoiGiaoDich_DienThoaiDD);
            self.NguoiGiaoDich_Email = ko.observable(item.NguoiGiaoDich_Email);
            self.QuyChe_TreEm = ko.observable(item.QuyChe_TreEm);
            self.QuyChe_NguoiQuanHeLeThuoc = ko.observable(item.QuyChe_NguoiQuanHeLeThuoc);
            self.QuyChe_PhongXa = ko.observable(item.QuyChe_PhongXa);
            self.QuyChe_PhacDoDieuTri = ko.observable(item.QuyChe_PhacDoDieuTri);
            self.QuyChe_GienNguoi = ko.observable(item.QuyChe_GienNguoi);
            self.QuyChe_NguoiTonThuongThanKinh = ko.observable(item.QuyChe_NguoiTonThuongThanKinh);
            self.QuyChe_CacTapTheNhomNguoi = ko.observable(item.QuyChe_CacTapTheNhomNguoi);
            self.QuyChe_NghienCuuDichTeHoc = ko.observable(item.QuyChe_NghienCuuDichTeHoc);
            self.QuyChe_NguoiCanChamSocYTe = ko.observable(item.QuyChe_NguoiCanChamSocYTe);
            self.QuyChe_NguoiDanToc = ko.observable(item.QuyChe_NguoiDanToc);
            self.QuyChe_ThuNghiemLamSang = ko.observable(item.QuyChe_ThuNghiemLamSang);
            self.QuyChe_SuDungMauMoNguoi = ko.observable(item.QuyChe_SuDungMauMoNguoi);
            self.QuyChe_CoTroGiupKiThuat = ko.observable(item.QuyChe_CoTroGiupKiThuat);
            self.ThongTinNguonTaiTro = ko.observable(item.ThongTinNguonTaiTro);
            self.ThongTinNCYSHSinhVien = ko.observable(item.ThongTinNCYSHSinhVien);
            self.QuyTrinh_MoTaDuAn = ko.observable(item.QuyTrinh_MoTaDuAn);
            self.QuyTrinh_QuyTrinhThucHien = ko.observable(item.QuyTrinh_QuyTrinhThucHien);
            self.QuyTrinh_MucDich = ko.observable(item.QuyTrinh_MucDich);
            self.QuyTrinh_VanDeLienQuan = ko.observable(item.QuyTrinh_VanDeLienQuan);
            self.QuyTrinh_DiaDiemNghienCuu = ko.observable(item.QuyTrinh_DiaDiemNghienCuu);
            self.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = ko.observable(item.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia);
            self.NguyCoTiemTang_NhomNghienCuu = ko.observable(item.NguyCoTiemTang_NhomNghienCuu);
            self.NguyCoTiemTang_NguoiThamGia = ko.observable(item.NguyCoTiemTang_NguoiThamGia);
            self.NguyCoTiemTang_CongDongCuaTruong = ko.observable(item.NguyCoTiemTang_CongDongCuaTruong);
            self.NguyCoTiemTang_CongDongLonHon = ko.observable(item.NguyCoTiemTang_CongDongLonHon);
            self.NguyCoTiemTang_SoSanhRuiRo = ko.observable(item.NguyCoTiemTang_SoSanhRuiRo);
            self.NguyCoTiemTang_QuyTrinhGiamRuiRo = ko.observable(item.NguyCoTiemTang_QuyTrinhGiamRuiRo);
            self.NguyCoTiemTang_CachXuLyRuiRo = ko.observable(item.NguyCoTiemTang_CachXuLyRuiRo);
            self.NguyCoTiemTang_SucKhoeVaTinhAnToan = ko.observable(item.NguyCoTiemTang_SucKhoeVaTinhAnToan);
            self.NguyCoTiemTang_CacVanDeAnToanSinhHoc = ko.observable(item.GhiChuGiayToKha);
            self.NguyCoTiemTang_ThaoTacGen = ko.observable(item.NguyCoTiemTang_ThaoTacGen);
            self.LoiIchTiemTang_NhungLoiIch = ko.observable(item.LoiIchTiemTang_NhungLoiIch);
            self.LoiIchTiemTang_AiDuocLoi = ko.observable(item.LoiIchTiemTang_AiDuocLoi);
            self.LoiIchTiemTang_DongGopKhoaHoc = ko.observable(item.LoiIchTiemTang_DongGopKhoaHoc);
            self.LoiIchTiemTang_SoSanh = ko.observable(item.LoiIchTiemTang_SoSanh);
            self.QuyChe_CoTroGiupKiThuat = ko.observable(item.QuyChe_CoTroGiupKiThuat);
            self.NguoiThamGiaNghienCuu_DuKien = ko.observable(item.NguoiThamGiaNghienCuu_DuKien);
            self.NguoiThamGiaNghienCuu_CachXacDinh = ko.observable(item.NguoiThamGiaNghienCuu_CachXacDinh);
            self.NguoiThamGiaNghienCuu_TreViThanhNien = ko.observable(item.NguoiThamGiaNghienCuu_TreViThanhNien);
            self.NguoiThamGiaNghienCuu_ThieuNangTriTue = ko.observable(item.NguoiThamGiaNghienCuu_ThieuNangTriTue);
            self.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc = ko.observable(item.NguoiThamGiaNghienCuu_CoQuanHeLeThuoc);
            self.NguoiThamGiaNghienCuu_MoiQuanHeSanCo = ko.observable(item.NguoiThamGiaNghienCuu_MoiQuanHeSanCo);
            self.NguoiThamGiaNghienCuu_RaoCanNgonNgu = ko.observable(item.NguoiThamGiaNghienCuu_RaoCanNgonNgu);
            self.NguoiThamGiaNghienCuu_SangTuyen = ko.observable(item.NguoiThamGiaNghienCuu_SangTuyen);
            self.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung = ko.observable(item.NguoiThamGiaNghienCuu_PhaiTuChoiPhacDoDangApDung);
            self.NguoiThamGiaNghienCuu_DanTocThieuSo = ko.observable(item.NguoiThamGiaNghienCuu_DanTocThieuSo);
            self.NguoiThamGiaNghienCuu_ThamGiaTapThe = ko.observable(item.NguoiThamGiaNghienCuu_ThamGiaTapThe);
            self.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich = ko.observable(item.NguoiThamGiaNghienCuu_ChiTraKhuyenKhich);
            self.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung = ko.observable(item.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoCuoiCung);
            self.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat = ko.observable(item.NguoiThamGiaNghienCuu_QuyTrinhBaoCaoTomTat);
            self.QuyTrinhXinChapThuanTinhNguyen = ko.observable(item.QuyTrinhXinChapThuanTinhNguyen);
            self.QuanLyDLVaBaoMat_ThuThapTrucTiep = ko.observable(item.QuanLyDLVaBaoMat_ThuThapTrucTiep);
            self.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan = ko.observable(item.QuanLyDLVaBaoMat_TiepCanThongTinCaNhan);
            self.QuanLyDLVaBaoMat_GhiLaiDL = ko.observable(item.QuanLyDLVaBaoMat_GhiLaiDL);
            self.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam = ko.observable(item.QuanLyDLVaBaoMat_ThonTinCaNhanNhayCam);
            self.QuanLyDLVaBaoMat_BaoMatThongTin = ko.observable(item.QuanLyDLVaBaoMat_BaoMatThongTin);
            self.QuanLyDLVaBaoMat_LuuTruDLTrongXNam = ko.observable(item.QuanLyDLVaBaoMat_LuuTruDLTrongXNam);
            self.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat = ko.observable(item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_CachKiemSoat);
            self.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan = ko.observable(item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_NguoiDuocPhepTienCan);
            self.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru = ko.observable(item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_DiaDiemLuuTru);
            self.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon = ko.observable(item.QuanLyDLVaBaoMat_DLBaoCaoKetQua_ChapThuanCuaBoMon);
            self.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat = ko.observable(item.QuanLyDLVaBaoMat_DLTrongNghienCuu_CachKiemSoat);
            self.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan = ko.observable(item.QuanLyDLVaBaoMat_DLTrongNghienCuu_NguoiDuocPhepTienCan);
            self.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru = ko.observable(item.QuanLyDLVaBaoMat_DLTrongNghienCuu_DiaDiemLuuTru);
            self.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon = ko.observable(item.QuanLyDLVaBaoMat_DLTrongNghienCuu_ChapThuanCuaBoMon);
            self.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru = ko.observable(item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_CoQuanLuuTru);
            self.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo = ko.observable(item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_SoLuongHoSo);
            self.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat = ko.observable(item.QuanLyDLVaBaoMat_BaoVeThongTinCaNhan_NguyenTacBaoMat);
            self.ThoiGianThucHien_ThuNghiem_NgayBatDau = ko.observable(item.ThoiGianThucHien_ThuNghiem_NgayBatDau);
            self.ThoiGianThucHien_ThuNghiem_NgayKetThuc = ko.observable(item.ThoiGianThucHien_ThuNghiem_NgayKetThuc);
            self.ThoiGianThucHien_ThuNghiem_ThangBatDau = ko.observable(item.ThoiGianThucHien_ThuNghiem_ThangBatDau);
            self.ThoiGianThucHien_ThuNghiem_ThangKetThuc = ko.observable(item.ThoiGianThucHien_ThuNghiem_ThangKetThuc);
            self.ThoiGianThucHien_ThuNghiem_NamBatDau = ko.observable(item.ThoiGianThucHien_ThuNghiem_NamBatDau);
            self.ThoiGianThucHien_ThuNghiem_NamKetThuc = ko.observable(item.ThoiGianThucHien_ThuNghiem_NamKetThuc);
            self.ThoiGianThucHien_ThuThapDL_NgayBatDau = ko.observable(item.ThoiGianThucHien_ThuThapDL_NgayBatDau);
            self.ThoiGianThucHien_ThuThapDL_NgayKetThuc = ko.observable(item.ThoiGianThucHien_ThuThapDL_NgayKetThuc);
            self.ThoiGianThucHien_ThuThapDL_ThangBatDau = ko.observable(item.ThoiGianThucHien_ThuThapDL_ThangBatDau);
            self.ThoiGianThucHien_ThuThapDL_ThangKetThuc = ko.observable(item.ThoiGianThucHien_ThuThapDL_ThangKetThuc);
            self.ThoiGianThucHien_ThuThapDL_NamBatDau = ko.observable(item.ThoiGianThucHien_ThuThapDL_NamBatDau);
            self.ThoiGianThucHien_ThuThapDL_NamKetThuc = ko.observable(item.ThoiGianThucHien_ThuThapDL_NamKetThuc);
            self.ThoiGianThucHien_TongThoiGian_NgayBatDau = ko.observable(item.ThoiGianThucHien_TongThoiGian_NgayBatDau);
            self.ThoiGianThucHien_TongThoiGian_NgayKetThuc = ko.observable(item.ThoiGianThucHien_TongThoiGian_NgayKetThuc);
            self.ThoiGianThucHien_TongThoiGian_ThangBatDau = ko.observable(item.ThoiGianThucHien_TongThoiGian_ThangBatDau);
            self.ThoiGianThucHien_TongThoiGian_ThangKetThuc = ko.observable(item.ThoiGianThucHien_TongThoiGian_ThangKetThuc);
            self.ThoiGianThucHien_TongThoiGian_NamBatDau = ko.observable(item.ThoiGianThucHien_TongThoiGian_NamBatDau);
            self.ThoiGianThucHien_TongThoiGian_NamKetThuc = ko.observable(item.ThoiGianThucHien_TongThoiGian_NamKetThuc);
            self.MauThuanLoiIch_NghienCuuTheoYeuCau = ko.observable(item.MauThuanLoiIch_NghienCuuTheoYeuCau);
            self.MauThuanLoiIch_PhuThuocTaiChinh = ko.observable(item.MauThuanLoiIch_PhuThuocTaiChinh);
            self.MauThuanLoiIch_LoiIchTaiChinh = ko.observable(item.MauThuanLoiIch_LoiIchTaiChinh);
            self.CanNhacDaoDucKhac = ko.observable(item.CanNhacDaoDucKhac);
            self.TongQuanTaiLieuKeHoachPhuongPhap = ko.observable(item.TongQuanTaiLieuKeHoachPhuongPhap);
            self.CanKet_TenNCYSH = ko.observable(item.CanKet_TenNCYSH);
            self.YKienNguoiHuongDan_TenNCYSH = ko.observable(item.YKienNguoiHuongDan_TenNCYSH);
            self.YKienNguoiHuongDan_NhanXet = ko.observable(item.YKienNguoiHuongDan_NhanXet);
            self.YKienNguoiHuongDan_BoMon = ko.observable(item.YKienNguoiHuongDan_BoMon);
            self.YKienNguoiHuongDan_NgayKy = ko.observable(item.YKienNguoiHuongDan_NgayKy);
            self.YKienNguoiHuongDan_ThangKy = ko.observable(item.YKienNguoiHuongDan_ThangKy);
            self.YKienNguoiHuongDan_NamKy = ko.observable(item.YKienNguoiHuongDan_NamKy);
            self.YKienNguoiHuongDan_HoTenVaChucDanh = ko.observable(item.YKienNguoiHuongDan_HoTenVaChucDanh);
            self.YKienTruongKhoa_XemXetBoiHDKH = ko.observable(item.YKienTruongKhoa_XemXetBoiHDKH);
            self.YKienTruongKhoa_XemXetBoiCapCaNhan = ko.observable(item.YKienTruongKhoa_XemXetBoiCapCaNhan);
            self.YKienTruongKhoa_XemXetBoiKhoaPhong = ko.observable(item.YKienTruongKhoa_XemXetBoiKhoaPhong);
            self.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap = ko.observable(item.YKienTruongKhoa_CanXemXetBoiChuyenGiaDocLap);
            self.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap = ko.observable(item.YKienTruongKhoa_KhongXemXetBoiChuyenGiaDocLap);
            self.YKienTruongKhoa_NhanXet = ko.observable(item.YKienTruongKhoa_NhanXet);
            self.YKienTruongKhoa_BoMon = ko.observable(item.YKienTruongKhoa_BoMon);
            self.YKienTruongKhoa_NgayKy = ko.observable(item.YKienTruongKhoa_NgayKy);
            self.YKienTruongKhoa_ThangKy = ko.observable(item.YKienTruongKhoa_ThangKy);
            self.YKienTruongKhoa_NamKy = ko.observable(item.YKienTruongKhoa_NamKy);
            self.YKienTruongKhoa_HoTenVaChucDanh = ko.observable(item.YKienTruongKhoa_HoTenVaChucDanh);

            self.ListNCV = ko.observableArray(ko.utils.arrayMap(item.ListNCV || [{}, {}, {}], function (nn) {
                return {
                    HoTen: ko.observable(nn.ThoiGian || ""),
                    ChucDanh: ko.observable(nn.TenHiepHoi || ""),
                    ChucVu: ko.observable(nn.ChucDanh || "")
                };
            }));

            self.ListCoQuan = ko.observableArray(ko.utils.arrayMap(item.ListCoQuan || [{}, {}, {}, {}, {}], function (nn) {
                return {
                    CoQuan: ko.observable(nn.ThoiGian || ""),
                    DuocCapPhep: ko.observable(nn.TenHiepHoi || false),
                    ChoCapPhep: ko.observable(nn.ChucDanh || false),
                    ChuaXinPhep: ko.observable(nn.ChucDanh || false),
                    GhiChuKhac: ko.observable(nn.ChucDanh || false)
                };
            }));

            self.CanKet_ListChuKy = ko.observableArray(ko.utils.arrayMap(item.CanKet_ListChuKy || [{}, {}, {}, {}, {}], function (nn) {
                return {
                    BoMon: ko.observable(nn.ThoiGian || ""),
                    NgayKy: ko.observable(nn.TenHiepHoi || ""),
                    ThangKy: ko.observable(nn.ChucDanh || ""),
                    NamKy: ko.observable(nn.ChucDanh || ""),
                    HoTenVaChucDanh: ko.observable(nn.ChucDanh || "")
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