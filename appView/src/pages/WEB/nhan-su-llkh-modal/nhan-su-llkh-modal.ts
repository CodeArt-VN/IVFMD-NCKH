import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { STAFF_NhanSu_LLKHProviderCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
@IonicPage({ name: 'page-nhan-su-llkh-modal', priority: 'high', defaultHistory: ['page-nhan-su-llkh-modal'] })
@Component({
    selector: 'nhan-su-llkh-modal',
    templateUrl: 'nhan-su-llkh-modal.html',
})
export class NhanSuLLKHModalPage extends DetailPage {
    idNhanSu: any;
    model: any;
    constructor(
        public currentProvider: STAFF_NhanSu_LLKHProviderCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-nhan-su-llkh-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-nhan-su-llkh-modal";
        this.events.unsubscribe('app:Close-page-nhan-su-llkh-modal');
        this.events.subscribe('app:Close-page-nhan-su-llkh-modal', () => {
            this.dismiss();
        });
        this.idNhanSu = navParams.get('idNhanSu');
        if (this.idNhanSu && commonService.isNumeric(this.idNhanSu)) {
            this.idNhanSu = parseInt(this.idNhanSu, 10);
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.idNhanSu).then((ite) => {
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        ko.cleanNode($('#frmNhanSuLLKH')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmNhanSuLLKH").empty();
        $(this.item.HTML).appendTo("#frmNhanSuLLKH");
        let id = this.item.ID;
        var that = this;
        ko.bindingHandlers.editableHTML = {
            init: function (element, valueAccessor) {
                var $element = $(element);
                var initialValue = ko.utils.unwrapObservable(valueAccessor());
                if (id <= 0)
                    $element.html(initialValue);
                $element.on('keyup', function () {
                    var observable = valueAccessor();
                    observable($element.html());
                });
            }
        };

        let ObjModel = function (item) {
          var self = this;
          self.ThongTinChung = ko.observable({
            DienThoai_CaNhan: ko.observable(""),
            DienThoai_CoQuan: ko.observable(""),
            DiaChi_CoQuan: ko.observable(""),
            DiaChi_CaNhan: ko.observable(""),
            Email_CoQuan: ko.observable(""),
            Email_CaNhan: ko.observable(""),

              NamPhongHocHam: ko.observable(""),//x
              HocHam: ko.observable(""),//x
              HocViThacSy: ko.observable(""),//x
              NamHocViThacSy: ko.observable(""),//x
              HocViTienSy: ko.observable(""),//x
              NamHocViTienSy: ko.observable(""),//x

              CMND: ko.observable(""),
              CMND_NoiCap: ko.observable(""),
              CMND_NgayCap: ko.observable(""),

              ChucVu: ko.observable(""),
              PhongKhoa: ko.observable(""),
              TruongVien: ko.observable(""),

              GioiTinh: ko.observable(""),
              NgaySinh: ko.observable(""),
              HoTen: ko.observable(""),
              LinhVuc: ko.observable(""),
              ChuyenNganh: ko.observable(""),
              HuongNghienCuu: ko.observable("</br></br>")
          })

          self.ListNgoaiNgu = ko.observableArray([]);

          self.ListThoiGianCongTac = ko.observableArray(ko.utils.arrayMap(item.ListThoiGianCongTac || [{}, {}, {}], function (nn) {
              return {
                  ThoiGian: ko.observable(nn.ThoiGian),
                  NoiCongTac: ko.observable(nn.NoiCongTac),
                  ChucVu: ko.observable(nn.ChucVu)
              };
          }));

          self.ListQuaTrinhDaoTao = ko.observableArray(ko.utils.arrayMap(item.QuaTrinhDaoTao || [{
              BacDaoTao: "Đại học"
          },
          {
              BacDaoTao: "Thạc sỹ"
          },
          {
              BacDaoTao: "Tiến sỹ"
          }], function (nn) {
              return {
                  BacDaoTao: ko.observable(nn.BacDaoTao),
                  ThoiGian: ko.observable(nn.ThoiGian),
                  NoiDaoTao: ko.observable(nn.NoiDaoTao),
                  ChuyenNganh: ko.observable(nn.ChuyenNganh),
                  TenLuanAnTotNghiep: ko.observable(nn.TenLuanAn)
              };
          }));

          self.DeTaiNghienCuu = ko.observableArray(ko.utils.arrayMap(item.DeTaiNghienCuu || [{}, {}, {}], function (nn) {
              return {
                TT: ko.observable(nn.TT),
                  TenDeTai: ko.observable(nn.TenDeTai),
                  MaSoQuanLy: ko.observable(nn.MaSoCapQuanLy),
                  ThoiGianThucHien: ko.observable(nn.ThoiGianThucHien),
                  ChuNhiem: ko.observable(nn.ChuNhiemThamGia),
                  NgayNghiemThu: ko.observable(nn.NgayNghiemThu),
                  KetQua: ko.observable(nn.KetQua)
              };
          }));

          self.ListHuongDan = ko.observableArray(ko.utils.arrayMap(item.ListHuongDan || [{}, {}, {}], function (nn) {
              return {
                  TT: ko.observable(nn.TT),
                  TenSV: ko.observable(nn.TenSV),
                  TenLuanAn: ko.observable(nn.TenLuanAn),
                  NamTot: ko.observable(nn.NamTotNghiep),
                  BacDaoTao: ko.observable(nn.BacDaoTao),
                  SanPham: ko.observable(nn.SanPhamDeTai)
              };
          }));

          self.ListSachQuocTe = ko.observableArray(ko.utils.arrayMap(item.SachXuatBanQuocTe || [{}, {}, {}], function (nn) {
              return {
                    TT: ko.observable(nn.TT),
                  TenSach: ko.observable(nn.TenSach),
                  SanPham: ko.observable(nn.SanPhamDeTai),
                  NhaXuatBan: ko.observable(nn.NXB),
                  NamXuatBan: ko.observable(nn.NamXuatBan),
                  TacGia: ko.observable(nn.DongTacGia),
                  ButDanh: ko.observable(nn.ButDanh)
              };
          }));

          self.ListSachTrongNuoc = ko.observableArray(ko.utils.arrayMap(item.SachXuatBanTrongNuoc || [{}, {}, {}], function (nn) {
              return {
                TT: ko.observable(nn.TT),
                  TenSach: ko.observable(nn.TenSach),
                  SanPham: ko.observable(nn.SanPhamDeTai),
                  NhaXuatBan: ko.observable(nn.NXB),
                  NamXuatBan: ko.observable(nn.NamXuatBan),
                  TacGia: ko.observable(nn.DongTacGia),
                  ButDanh: ko.observable(nn.ButDanh)
              };
          }));

          self.ListTapChiQuocTe = ko.observableArray(ko.utils.arrayMap(item.TapChiQuocTe || [{}, {}, {}], function (nn) {
              return {
                TT: ko.observable(nn.TT),
                TenBaiViet: ko.observable(nn.TenDeTai),
                SanPham: ko.observable(nn.SanPhamDeTai),
                SoHieu: ko.observable(nn.ISSN),
                DiemIF: ko.observable(nn.IF)
              };
          }));

          self.TapChiTrongNuoc = ko.observableArray(ko.utils.arrayMap(item.TapChiTrongNuoc || [{}, {}, {}], function (nn) {
              return {
                  TenBaiViet: ko.observable(nn.TenDeTai),
                  SanPhamDeTai: ko.observable(nn.SanPhamDeTai),
                  ISSN: ko.observable(nn.ISSN),
                  GhiChu: ko.observable(nn.GhiChu)
              };
          }));

          self.HoiNghiQuocTe = ko.observableArray(ko.utils.arrayMap(item.HoiNghiQuocTe || [{}, {}, {}], function (nn) {
              return {
                  TenDeTai: ko.observable(nn.TenDeTai),
                  SanPhamDeTai: ko.observable(nn.SanPhamDeTai),
                  ISSN: ko.observable(nn.ISSN),
                  GhiChu: ko.observable(nn.GhiChu)
              };
          }));

          self.HoiNghiTrongNuoc = ko.observableArray(ko.utils.arrayMap(item.HoiNghiTrongNuoc || [{}, {}], function (nn) {
              return {
                  TenDeTai: ko.observable(nn.TenDeTai),
                  SanPhamDeTai: ko.observable(nn.SanPhamDeTai),
                  ISSN: ko.observable(nn.ISSN),
                  GhiChu: ko.observable(nn.GhiChu)
              };
          }));

          self.GiaiThuongKHCN = ko.observableArray(ko.utils.arrayMap(item.GiaiThuongKHCN || [{}, {}], function (nn) {
              return {
                  Ten: ko.observable(nn.Ten),
                  NoiDung: ko.observable(nn.NoiDung),
                  NamCap: ko.observable(nn.NamCap),
                  NoiCap: ko.observable(nn.NoiCap)
              };
          }));

          self.ThamGiaHHKH = ko.observableArray(ko.utils.arrayMap(item.ThamGiaHHKH || [{}, {}, {}], function (nn) {
              return {
                  ThoiGian: ko.observable(nn.ThoiGian),
                  TenHiepHoi: ko.observable(nn.TenHiepHoi),
                  ChucDanh: ko.observable(nn.ChucDanh)
              };
          }));

          self.ThamGiaTTNC = ko.observableArray(ko.utils.arrayMap(item.ThamGiaTTNC || [{}, {}, {}], function (nn) {
              return {
                  ThoiGian: ko.observable(nn.ThoiGian),
                  TenTTNC: ko.observable(nn.TenTTNC),
                  NoiDungThamGia: ko.observable(nn.NoiDungThamGia)
              };
          }));

          self.HoatDongKhac = ko.observable(item.HoatDongKhac);

          self.addItem = function (name) {
              if (self[name]) {
                  var obj = {};
                  switch (name) {
                      case "ThoiGianCongTac":
                          obj = {
                              ThoiGian: ko.observable(""),
                              NoiCongTac: ko.observable(""),
                              ChucVu: ko.observable("")
                          };
                          break;
                      case "DeTaiNghienCuu":
                          obj = {
                              TenDeTai: ko.observable(""),
                              MaSoCapQuanLy: ko.observable(""),
                              ThoiGianThucHien: ko.observable(""),
                              ChuNhiemThamGia: ko.observable(""),
                              NgayNghiemThu: ko.observable(""),
                              KetQua: ko.observable("")
                          };
                          break;
                      case "DeTaiHuongDanSinhVien":
                          obj = {
                              TenSV: ko.observable(""),
                              TenLuanAn: ko.observable(""),
                              NamTotNghiep: ko.observable(""),
                              BacDaoTao: ko.observable(""),
                              SanPhamDeTai: ko.observable("")
                          };
                          break;
                      default:
                          return false;
                  }
                  self[name].push(obj);
              }
          };

          self.removeItem = function (name, index) {
              if (self[name])
                  var idx = parseInt(index);
              self[name].splice(idx, 1);
          };

          self.savedJson = ko.observable("");
          self.save = function () {
              self.savedJson(JSON.stringify(ko.toJS(self), null, 2));
          };
        }
        this.model = new ObjModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmNhanSuLLKH"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmNhanSuLLKH").html();
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