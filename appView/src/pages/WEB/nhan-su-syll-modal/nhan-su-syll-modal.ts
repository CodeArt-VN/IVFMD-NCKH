import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { STAFF_NhanSu_SYLLProviderCustomProvider, PRO_SYLLCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
@IonicPage({ name: 'page-nhan-su-syll-modal', priority: 'high', defaultHistory: ['page-nhan-su-syll-modal'] })
@Component({
    selector: 'nhan-su-syll-modal',
    templateUrl: 'nhan-su-syll-modal.html',
})
export class NhanSuSYLLModalPage extends DetailPage {
    idNhanSu: any;
    idDeTai: any;
    model: any;
    constructor(
        public currentProvider: STAFF_NhanSu_SYLLProviderCustomProvider,
        public proSYLLProvider: PRO_SYLLCustomProvider,
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
    }

    loadData() {
        if (this.idDeTai > 0) {
            this.proSYLLProvider.getItemCustom(this.idDeTai, this.idNhanSu).then((ite) => {
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
            if (sconf != null && (target.parentElement.tagName == "TD")) {
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
           
            self.ListTrinhDoChuyenMon = ko.observableArray(ko.utils.arrayMap(item.ListTrinhDoChuyenMon || [{}, {}, {}], function (nn) {
                return {
                    HocVi: ko.observable(nn.HocVi || ""),
                    NamNhanBang: ko.observable(nn.NamNhanBang || ""),
                    ChuyenNganhDaoTao: ko.observable(nn.ChucVu || "")
                };
            }));

            self.ListKinhNghiem = ko.observableArray(ko.utils.arrayMap(item.ListKinhNghiem || [{}, {}, {}], function (nn) {
                return {
                    TenDeTai: ko.observable(nn.ThoiGian || ""),
                    NhiemVuCaNhan: ko.observable(nn.NoiCongTac || ""),
                    CoQuanChuTri: ko.observable(nn.ChucVu || ""),
                    NamBatDauKetThuc: ko.observable(nn.ChucVu || "")
                };
            }));

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
        ko.applyBindings(this.model, document.getElementById("frmNhanSuSYLL"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmNhanSuSYLL").html();
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
}