import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { STAFF_NhanSu_LLKHProviderCustomProvider, PRO_LLKHCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import 'jquery.tmpl';
declare var $: any;
import * as ko from 'knockout';
@IonicPage({ name: 'page-nhan-su-llkh-modal', priority: 'high', defaultHistory: ['page-nhan-su-llkh-modal'] })
@Component({
    selector: 'nhan-su-llkh-modal',
    templateUrl: 'nhan-su-llkh-modal.html',
})
export class NhanSuLLKHModalPage extends DetailPage {
    idNhanSu: any;
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: STAFF_NhanSu_LLKHProviderCustomProvider,
        public proLLKHProvider: PRO_LLKHCustomProvider,
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

        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
        else {
            this.idDeTai = -1;
        }
    }

    loadData() {
        if (this.idDeTai > 0) {
            this.proLLKHProvider.getItemCustom(this.idDeTai, this.idNhanSu).then((ite) => {
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
                $element.html(initialValue);
                $element.on('keyup', function () {
                    var observable = valueAccessor();
                    observable($element.html());
                });
            }
        };

        $(".ptable").on("click", ".clone", function (e) {
            var sconf = $(e.currentTarget).closest(".ptable").attr("conf");
            if (sconf != null) {
                try {
                    var conf = JSON.parse(sconf);
                    if (conf.add) {
                        var context = ko.contextFor(this);
                        context.$root.addItem(conf.name, conf.props);
                    }
                    return false;
                } catch (e) {
                    console.error(e);
                    return false;
                }
            }
        });
        $(".ptable").on("click", ".remove", function (e) {
            var target = window.getSelection().anchorNode;
            var sconf = $(e.currentTarget).closest(".ptable").attr("conf");
            // @ts-ignore
            if (sconf != null && (target.tagName == "TD" || target.parentElement.tagName == "TD")) {
                try {
                    var conf = JSON.parse(sconf);
                    if (conf.add) {
                        var tr = $(target).closest('tr');
                        var context = ko.contextFor(this);
                        context.$root.removeItem(conf.name, tr.attr('index'));
                    }
                    return false;
                } catch (e) {
                    console.error(e);
                    return false;
                }
            }
        });

        var popConrtrol = $('<div class="group_controls" style="position:absolute;top:-24px;right:0;border:1px solid red">' +
            '<div class="fieldgroup_controls">' +
            '<button style="line-height:20px" class="remove"><i class="fa fa-minus"></i> Xóa</button>' +
            '<button style="line-height:20px" class="clone"><i class="fa fa-plus"></i> Thêm</button>' +
            '</div>' +
            '</div>');
        $(".ptable").mouseenter(function (event) {
            try {
                var sconf = this.attributes["conf"].value;
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.add || conf.remove) {
                        var t = $(this).find(".group_controls");
                        if (t.length == 0) {
                            popConrtrol.appendTo($(this));
                        }
                    }
                }
            } catch (e) {
                console.error(e);
                return false;
            }
        }).mouseleave(function (event) {
            var t = $(this).find(".group_controls");
            t.detach();
        });

        var ObjModel = function (item) {
            var self = this;
            self.ID = item.ID;
            self.IDNhanSu = item.IDNhanSu;
            self.IDDetai = item.IDDetai;
            self.DienThoai_CaNhan = ko.observable(item.DienThoai_CaNhan || "");
            self.DienThoai_CoQuan = ko.observable(item.DienThoai_CoQuan || "");
            self.DiaChi_CoQuan = ko.observable(item.DiaChi_CoQuan || "");
            self.DiaChi_CaNhan = ko.observable(item.DiaChi_CaNhan || "");
            self.Email_CoQuan = ko.observable(item.Email_CoQuan || "");
            self.Email_CaNhan = ko.observable(item.Email_CaNhan || "");

            self.NamPhongHocHam = ko.observable(item.NamPhongHocHam || "");
            self.HocHam = ko.observable(item.HocHam || "");
            self.HocVi = ko.observable(item.HocVi || "");
            self.HocViThacSy = ko.observable(item.HocViThacSy || "");
            self.NamHocViThacSy = ko.observable(item.NamHocViThacSy || "");
            self.HocViTienSy = ko.observable(item.HocViTienSy || "");
            self.NamHocViTienSy = ko.observable(item.NamHocViTienSy || "");

            self.CMND = ko.observable(item.CMND || "");
            self.CMND_NoiCap = ko.observable(item.CMND_NoiCap || "");
            self.CMND_NgayCap = ko.observable(item.CMND_NgayCap || "");

            self.ChucVu = ko.observable(item.ChucVu || "");
            self.PhongKhoa = ko.observable(item.PhongKhoa || "");
            self.TruongVien = ko.observable(item.TruongVien || "");

            self.GioiTinh = ko.observable(item.GioiTinh || "");
            self.NgaySinh = ko.observable(item.NgaySinh || "");
            self.HoTen = ko.observable(item.HoTen || item.HoTen || "");
            self.LinhVuc = ko.observable(item.LinhVuc || "");
            self.ChuyenNganh = ko.observable(item.ChuyenNganh || "");
            self.HuongNghienCuu = ko.observable(item.HuongNghienCuu || "");

            self.NgoaiNgu = ko.observableArray([]);

            self.ListThoiGianCongTac = ko.observableArray(ko.utils.arrayMap(item.ListThoiGianCongTac || [{}, {}, {}], function (nn) {
                return {
                    ThoiGian: ko.observable(nn.ThoiGian || ""),
                    NoiCongTac: ko.observable(nn.NoiCongTac || ""),
                    ChucVu: ko.observable(nn.ChucVu || "")
                };
            }));

            self.ListQuaTrinhDaoTao = ko.observableArray(ko.utils.arrayMap(item.ListQuaTrinhDaoTao || [{
                Bac: "Đại học"
            },
            {
                Bac: "Thạc sỹ"
            },
            {
                Bac: "Tiến sỹ"
            }], function (nn) {
                return {
                    Bac: ko.observable(nn.Bac || ""),
                    ThoiGian: ko.observable(nn.ThoiGian || ""),
                    NoiDaoTao: ko.observable(nn.NoiDaoTao || ""),
                    ChuyenNganh: ko.observable(nn.ChuyenNganh || ""),
                    TenLuanAnTotNghiep: ko.observable(nn.TenLuanAnTotNghiep || "")
                };
            }));

            self.ListDeTai = ko.observableArray(ko.utils.arrayMap(item.ListDeTai || [{}, {}, {}], function (nn) {
                return {
                    TenDeTai: ko.observable(nn.TenDeTai || ""),
                    MaSoQuanLy: ko.observable(nn.MaSoQuanLy || ""),
                    ThoiGianThucHien: ko.observable(nn.ThoiGianThucHien || ""),
                    ChuNhiem: ko.observable(nn.ChuNhiem || ""),
                    NgayNghiemThu: ko.observable(nn.NgayNghiemThu || ""),
                    KetQua: ko.observable(nn.KetQua || "")
                };
            }));

            self.ListHuongDan = ko.observableArray(ko.utils.arrayMap(item.ListHuongDan || [{}, {}, {}], function (nn) {
                return {
                    TenSV: ko.observable(nn.TenSV || ""),
                    TenLuanAn: ko.observable(nn.TenLuanAn || ""),
                    NamTot: ko.observable(nn.NamTot || ""),
                    BacDaoTao: ko.observable(nn.BacDaoTao || ""),
                    SanPham: ko.observable(nn.SanPham || "")
                };
            }));

            self.ListSachQuocTe = ko.observableArray(ko.utils.arrayMap(item.ListSachQuocTe || [{}, {}, {}], function (nn) {
                return {
                    TenSach: ko.observable(nn.TenSach || ""),
                    SanPham: ko.observable(nn.SanPham || ""),
                    NhaXuatBan: ko.observable(nn.NhaXuatBan || ""),
                    NamXuatBan: ko.observable(nn.NamXuatBan || ""),
                    TacGia: ko.observable(nn.TacGia || ""),
                    ButDanh: ko.observable(nn.ButDanh || "")
                };
            }));

            self.ListSachTrongNuoc = ko.observableArray(ko.utils.arrayMap(item.ListSachTrongNuoc || [{}, {}, {}], function (nn) {
                return {
                    TenSach: ko.observable(nn.TenSach || ""),
                    SanPham: ko.observable(nn.SanPham || ""),
                    NhaXuatBan: ko.observable(nn.NhaXuatBan || ""),
                    NamXuatBan: ko.observable(nn.NamXuatBan || ""),
                    TacGia: ko.observable(nn.TacGia || ""),
                    ButDanh: ko.observable(nn.ButDanh || "")
                };
            }));

            self.ListTapChiQuocTe = ko.observableArray(ko.utils.arrayMap(item.ListTapChiQuocTe || [{}, {}, {}], function (nn) {
                return {
                    TenBaiViet: ko.observable(nn.TenBaiViet || ""),
                    SanPham: ko.observable(nn.SanPham || ""),
                    SoHieu: ko.observable(nn.SoHieu || ""),
                    DiemIF: ko.observable(nn.DiemIF || "")
                };
            }));

            self.ListTapChiTrongNuoc = ko.observableArray(ko.utils.arrayMap(item.ListTapChiTrongNuoc || [{}, {}, {}], function (nn) {
                return {
                    TenBaiViet: ko.observable(nn.TenBaiViet || ""),
                    SanPham: ko.observable(nn.SanPham || ""),
                    SoHieu: ko.observable(nn.SoHieu || ""),
                    DiemIF: ko.observable(nn.DiemIF || "")
                };
            }));

            self.ListHoiNghiQuocTe = ko.observableArray(ko.utils.arrayMap(item.ListHoiNghiQuocTe || [{}, {}, {}], function (nn) {
                return {
                    TenBaiViet: ko.observable(nn.TenBaiViet || ""),
                    SanPham: ko.observable(nn.SanPham || ""),
                    SoHieu: ko.observable(nn.SoHieu || ""),
                    DiemIF: ko.observable(nn.DiemIF || "")
                };
            }));

            self.ListHoiNghiTrongNuoc = ko.observableArray(ko.utils.arrayMap(item.ListHoiNghiTrongNuoc || [{}, {}], function (nn) {
                return {
                    TenBaiViet: ko.observable(nn.TenBaiViet || ""),
                    SanPham: ko.observable(nn.SanPham || ""),
                    SoHieu: ko.observable(nn.SoHieu || ""),
                    DiemIF: ko.observable(nn.DiemIF || "")
                };
            }));

            self.ListGiaiThuong = ko.observableArray(ko.utils.arrayMap(item.ListGiaiThuong || [{}, {}], function (nn) {
                return {
                    TenGiaiThuong: ko.observable(nn.TenGiaiThuong || ""),
                    NoiDungGiaiThuong: ko.observable(nn.NoiDungGiaiThuong || ""),
                    NamCap: ko.observable(nn.NamCap || ""),
                    NoiCap: ko.observable(nn.NoiCap || "")
                };
            }));

            self.ListHiepHoiKhoaHoc = ko.observableArray(ko.utils.arrayMap(item.ListHiepHoiKhoaHoc || [{}, {}, {}], function (nn) {
                return {
                    ThoiGian: ko.observable(nn.ThoiGian || ""),
                    TenHiepHoi: ko.observable(nn.TenHiepHoi || ""),
                    ChucDanh: ko.observable(nn.ChucDanh || "")
                };
            }));

            self.ListTruongDaiHoc = ko.observableArray(ko.utils.arrayMap(item.ListTruongDaiHoc || [{}, {}, {}], function (nn) {
                return {
                    ThoiGian: ko.observable(nn.ThoiGian || ""),
                    TenTruong: ko.observable(nn.TenTTNC || ""),
                    NoiDungThamGia: ko.observable(nn.NoiDungThamGia || "")
                };
            }));

            self.HoatDongKhac = ko.observable(item.HoatDongKhac || "");

            self.addItem = function (name, props) {
                if (self[name]) {
                    var obj = {};
                    $.each(props || [], function (i, o) {
                        obj[o] = ko.observable("");
                    })
                    self[name].push(ko.observable(obj));
                }
            };

            self.removeItem = function (name, index) {
                debugger
                if (self[name])
                    var idx = parseInt(index);
                self[name].splice(idx, 1);
            };

            self.savedJson = ko.observable("");
            self.save = function () {
                self.savedJson(JSON.stringify(ko.toJS(self || ""), null, 2));
            };

            self.getItem = function () {
                return ko.toJS(self);
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
            if (this.idDeTai > 0) {
                this.proLLKHProvider.saveCustom(item).then((savedItem: any) => {
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
}