import { Component, ViewChild } from '@angular/core';
import { NavController, ModalController, NavParams, Events, LoadingController, ToastController, AlertController, IonicPage, Slides } from 'ionic-angular';
import { BasePage } from '../../base-page';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { PRO_DeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { DeTaiPage } from '../de-tai/de-tai';
import { SysnopsisModalPage } from '../sysnopsis-modal/sysnopsis-modal';
import { MauPhanTichDuLieuModalPage } from '../mau-phan-tich-du-lieu-modal/mau-phan-tich-du-lieu-modal';
import { DonXinDanhGiaDaoDucModalPage } from '../don-xin-danh-gia-dao-duc-modal/don-xin-danh-gia-dao-duc-modal';
import { DonXinXetDuyetModalPage } from '../don-xin-xet-duyet-modal/don-xin-xet-duyet-modal';
import { DonXinNghiemThuModalPage } from '../don-xin-nghiem-thu-modal/don-xin-nghiem-thu-modal';
import { NhanSuLLKHModalPage } from '../nhan-su-llkh-modal/nhan-su-llkh-modal';
import { NhanSuSYLLModalPage } from '../nhan-su-syll-modal/nhan-su-syll-modal';

import { BaoCaoTienDoNghienCuuPage } from '../bao-cao-tien-do-nghien-cuu/bao-cao-tien-do-nghien-cuu';
import { PhieuXemXetDaoDucModalPage } from '../phieu-xem-xet-dao-duc-modal/phieu-xem-xet-dao-duc-modal';
import { AEModalPage } from '../ae-modal/ae-modal';
import { SAEModalPage } from '../sae-modal/sae-modal';
import { BangKiemXXDDModalPage } from '../bang-kiem-xxdd-modal/bang-kiem-xxdd-modal';
import { ChonBenhNhanModalPage } from '../chon-benh-nhan-modal/chon-benh-nhan-modal';
import { ListSelectModalPage } from '../list-select-modal/list-select-modal';

import { ThuyetMinhDeTaiModalPage } from '../thuyet-minh-de-tai-modal/thuyet-minh-de-tai-modal';

/**
 * Generated class for the DeTaiDetailPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */
@IonicPage({ name: 'page-de-tai-detail', segment: 'de-tai-detail/:value', priority: 'high' })
@Component({
  selector: 'page-de-tai-detail',
  templateUrl: 'de-tai-detail.html',
})
export class DeTaiDetailPage extends BasePage {
  id: any;
  paramValue: any;
  @ViewChild(Slides) slides: Slides;
  //@ViewChild('pages') slides: Slides;
  slideListByType = [];
  listForm1 = [];
  listForm2 = [];
  listForm4 = [];
  listForm5 = [];

  pageIndex: number = 0;
  pageTitle = '';
  slideOpts: any;
  item: any = {};
  statusHRCO = 'Gửi HRCO';
  statusHDDD = 'Gửi HĐĐĐ';
  statusHDKH = 'Gửi HĐKH';
  canApprove = false;
  constructor(
    public currentProvider: PRO_DeTaiCustomProvider,
    public modalCtrl: ModalController,
    public navCtrl: NavController,
    public navParams: NavParams,
    public events: Events,
    public toastCtrl: ToastController,
    public loadingCtrl: LoadingController,
    public alertCtrl: AlertController,
    public commonService: CommonServiceProvider,
    public accountService: AccountServiceProvider,
  ) {
    super('page-de-tai-detail', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    this.id = navParams.get('id');
    this.paramValue = navParams.get('value');
    try {
      var arr = this.paramValue.split('-');
      this.id = arr[arr.length-1];
    } 
    catch (e) {
      this.id = 0;
    }

    if (this.id && commonService.isNumeric(this.id)) {
            this.id = parseInt(this.id, 10);
        }
        this.pageIndex = 0;
    }

    mockupData() {
        if (this.item.IDTrangThai_HRCO == 19) {
            this.statusHRCO = 'Đang chờ HRCO duyệt ';
        }
        else if (this.item.IDTrangThai_HRCO == 20) {
            this.statusHRCO = 'HRCO đã duyệt ';
        }
        if (this.item.IDTrangThai_HDDD == 7) {
            this.statusHDDD = 'Đang chờ HĐĐĐ duyệt ';
        }
        else if (this.item.IDTrangThai_HRCO == 8) {
            this.statusHRCO = 'HĐĐĐ đã duyệt';
        }

        if (this.item.IDTrangThai_HDKH == 13) {
            this.statusHDKH = 'Đang chờ HĐKH duyệt ';
        }
        else if (this.item.IDTrangThai_HRCO == 14) {
            this.statusHRCO = 'HĐKH đã duyệt';
        }

        this.slideListByType = [
            { type: 0, index: 0, title: 'Hội đồng nội bộ', shortTitle: 'Hội đồng nội bộ' },
            { type: 0, index: 1, title: 'Hội đồng Đạo đức, Hội đồng Khoa học', shortTitle: 'Hội đồng ĐĐ, KH' },
            { type: 0, index: 2, title: 'Đăng ký Clinical Trial', shortTitle: 'Đăng ký Clinical Trial' },
            { type: 0, index: 3, title: 'Thu nhận bệnh nhân', shortTitle: 'Thu nhận bệnh nhân' },
            { type: 0, index: 4, title: 'Nghiệm thu', shortTitle: 'Nghiệm thu' }
        ];
        this.listForm1 = this.item.ListFormStatus.filter((c) => { return c.Type == 0 });
        this.listForm2 = this.item.ListFormStatus.filter((c) => { return c.Type == 1 });
        this.listForm4 = this.item.ListFormStatus.filter((c) => { return c.Type == 3 });
        this.listForm5 = this.item.ListFormStatus.filter((c) => { return c.Type == 4 });

        this.slideOpts = {
            pager: false,

            autoHeight: true,
            calculateHeight: true,
            slidesPerView: 1,
            slidesPerColumn: 1,
            // allowSlidePrev:false,
            //allowSlideNext: false,
            // noSwipingClass: 'no-swipe',
            // noSwiping: true,
            allowTouchMove: false,
            // pagination: {
            //   el: '.swiper-pagination',
            //   clickable: true,
            //   paginationClickable: true,
            //   renderBullet: function (index, className) {
            //     return '<span class="' + className + '">' + (index + 1) + '</span>';
            //   },
            // },

        };
    }
    preLoadData() {
        this.canApprove = this.isUserCanUse('page-de-tai-hrco');
      setTimeout(() => {
          this.updateSlides();
      }, 300);
      super.preLoadData();
    }

    isUserCanUse(functionCode) {
        let menus = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        return menus[0].Forms.findIndex(d => d.Code == functionCode) > -1;
    }

    loadData() {
      this.loadedData();
      if (this.id) {
        this.currentProvider.getItemCustom(this.id).then((ite: any) => {
          this.item = ite;
          
          this.mockupData();
          setTimeout(() => {
            this.goToStep(0, null);
          }, 300);
          this.loadedData();
        }).catch((err) => {
          this.loadedData();
        });
      }
    }

    bindItemViewData(item) {
        item.ListFormStatus.forEach(e => {
          switch(e.FormCode) {
            case "tbl_PRO_Sysnopsis":

              break;
            default:
              break;
          }
          if(e.FormCode == "tbl_PRO_Sysnopsis"){

          }
        });
    }

    loadedData() {
      super.loadedData();
      setTimeout(() => {
        this.updateSlides();
      }, 0);
    }

    // Main
    goBack() {
        this.navCtrl.push(DeTaiPage);
    }

    bookFinished() {
      this.pageIndex = 0;
      this.events.publish('app:ShowMenu', true);
      //this.navCtrl.navigateBack('/home/booking-list');


    }

    // Steps check and update functions
    goToStep(index, value) {
      if (this.pageIndex == 5) { return; }

      //Không update data khi di chuyển qua lại. 
      if (value) {
        this.updateBookingData(this.pageIndex, value);
      }

      //Kiểm tra trước khi cho qua bước tiếp theo
      if (index == 2) {
      } else if (index == 3) {
      } else if (index == 4) {
      } else if (index == 5) {
        return;
      }

      //Chuẩn bị dữ liệu cho slide chuẩn bị enter
      if (index == 3) {//Nếu là slide chọn ngày giờ

      }
      else if (index == 4) {
      }



      //Di chuyển đến trang mới
      this.pageIndex = index;
      let currentSlide = this.slideListByType.filter(i => i.index == index);
      if (currentSlide.length) {
        this.pageTitle = currentSlide[0].title;
      }

      if (index > 0) {
        this.events.publish('app:ShowMenu', false);
      }
      else {
        this.events.publish('app:ShowMenu', true);
      }
      //this.slides.lockSwipes(false).then(()=>{
      this.slides.slideTo(index);
      //});


    }

    updateBookingData(step, value) {
      switch (step) {
        case 1:
          break;

        case 2:
          break;

        case 3:
          break;

        case 4:

          break;

        default:

          break;
      }
    }

    // Page functions
    slideChanged() {
      setTimeout(() => {
        this.updateSlides();
      }, 0);


      //this.slides.lockSwipes(true);
      // this.slides.getActiveIndex().then(index=>{
      //   this.pageIndex = index;

      //   this.slides.lockSwipes(true);

      //   if(index > 0){
      //     this.events.publish('app:ShowMenu', false);
      //   }
      //   else{
      //     this.events.publish('app:ShowMenu', true);
      //   }
      // });
    }

    updateSlides() {
      this.slides.update();
    }

    ionViewDidEnter() {
      super.ionViewDidEnter();
      window.onresize = (e) => {
        setTimeout(() => {
          this.updateSlides();
        }, 0);
      };
    }

    refreshData(){
      this.currentProvider.getItemCustom(this.id).then((ite: any) => {
        this.item = ite;
        this.listForm1 = this.item.ListFormStatus.filter((c) => { return c.Type == 0 });
        this.listForm2 = this.item.ListFormStatus.filter((c) => { return c.Type == 1 });
        this.listForm4 = this.item.ListFormStatus.filter((c) => { return c.Type == 3 });
        this.listForm5 = this.item.ListFormStatus.filter((c) => { return c.Type == 4 });
      });
    }

    /// 0: Sysnopsis/1:Phan tich/2:HDDD/3:HDKH/4:LLKH-CN/5:SYLL-CN/6:LLKH-NCV/7:SYLL-NCV
    openDetailModal(type){
        var page = null; 
        var param = { 'idDeTai': this.id, 'idNhanSu': -1, 'type': -1, 'isChuNhiem': false };
        switch(type){
            case 0:
              page = SysnopsisModalPage;
              break;
            case 1:
              page = MauPhanTichDuLieuModalPage;
              break;
            case 2:
              page = DonXinDanhGiaDaoDucModalPage;
              break;
            case 3: 
              page = DonXinXetDuyetModalPage;
              break;
            case 4:
              page = NhanSuLLKHModalPage;
              param = { 'idDeTai': this.id, 'idNhanSu': this.item.IDChuNhiem, 'type': -1, 'isChuNhiem': false };
              break;
            case 5:
              page = NhanSuSYLLModalPage;
              param = { 'idDeTai': this.id, 'idNhanSu': this.item.IDChuNhiem, 'type': -1, 'isChuNhiem': true };
              break;
            case 6:
              page = NhanSuLLKHModalPage;
              param = { 'idDeTai': this.id, 'idNhanSu': this.item.IDNCV, 'type': -1, 'isChuNhiem': false };
              break;
            case 7:
              page = NhanSuSYLLModalPage;
              param = { 'idDeTai': this.id, 'idNhanSu': this.item.IDNCV, 'type': -1, 'isChuNhiem': false };
                break;
            case 8:
                page = ThuyetMinhDeTaiModalPage;
                break;
            case 9:
              page = DonXinNghiemThuModalPage;
                break;
            case 10:
              page = PhieuXemXetDaoDucModalPage;
                break;
            case 11:
              page = BaoCaoTienDoNghienCuuPage;
              break;
            case 12:
              param = { 'idDeTai': this.id, 'idNhanSu': -1, 'type': 1, 'isChuNhiem': false };
              page = ListSelectModalPage;
              break;
            case 13:
              param = { 'idDeTai': this.id, 'idNhanSu': -1, 'type': 2, 'isChuNhiem': false };
              page = ListSelectModalPage;
              break;
            case 14:
              page = BangKiemXXDDModalPage;
              break;
        }
        if (type == 12 || type == 13) {
          let myModal = this.modalCtrl.create(page, param);
          myModal.onDidDismiss(data => {
            this.refreshData();
          });
          myModal.present();
        } 
        else if (type != 11) {
            let myModal = this.modalCtrl.create(page, param, { cssClass: 'preview-modal' });
            myModal.onDidDismiss(data => {
              this.refreshData();
            });
            myModal.present();
        } else {
            this.navCtrl.setRoot('page-bao-cao-tien-do-nghien-cuu', { 'value': 'view-bao-cao-tien-do-' + this.id });
            return false;
        }
    }

    updateSatus(actionCode) {
      this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.updateStatus(this.id, actionCode).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
      })
    };

    updateNCT() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.updateNCT(this.id, this.item.SoNCT).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                //this.events.publish('app:Update' + this.pageName);
                //console.log('publish => app:Update ' + this.pageName);
                this.refreshData();
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        })
    };
  }