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


/**
 * Generated class for the DeTaiDetailPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */
@IonicPage({ name: 'page-de-tai-detail', segment: 'de-tai-detail/:id', priority: 'high' })
@Component({
  selector: 'page-de-tai-detail',
  templateUrl: 'de-tai-detail.html',
})
export class DeTaiDetailPage extends BasePage {
  id: any;
  @ViewChild(Slides) slides: Slides;
  //@ViewChild('pages') slides: Slides;
  slideListByType = [];
  listForm1 = [];
  listForm2 = [];
  pageIndex: number = 0;
  pageTitle = '';
  slideOpts: any;
  item: any = {};
  statusHRCO = 'Gửi HRCO';
  statusHDDD = 'Gửi HDDD';
  statusHDKH = 'Gửi HDKH';
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
    if (this.id && commonService.isNumeric(this.id)) {
      this.id = parseInt(this.id, 10);
    }
    this.pageIndex = 0;
  }

  mockupData() {
    if (this.item.IDTrangThai_HRCO == 18){
      this.statusHRCO = 'Đang chờ duyệt HRCO';
  }
    if (this.item.IDTrangThai_HDDD == 7){
        this.statusHDDD = 'Đang chờ duyệt HDDD';
    }
    if (this.item.IDTrangThai_HDKH == 13){
      this.statusHDKH = 'Đang chờ duyệt HDKH';
    }
    this.slideListByType = [
      { type: 0, index: 0, title: 'Hội đồng nội bộ', shortTitle: 'Hội đồng nội bộ' },
      { type: 0, index: 1, title: 'Hội đồng Đạo đức, Hội đồng Khoa học', shortTitle: 'Hội đồng DD,KH' },
      { type: 0, index: 2, title: 'Đăng ký Clinical Trial', shortTitle: 'Đăng ký Clinical Trial' },
      { type: 0, index: 3, title: 'Thu nhận bệnh nhân', shortTitle: 'Thu nhận bệnh nhân' },
      { type: 0, index: 4, title: 'Nghiệm thu', shortTitle: 'Nghiệm thu' }
    ];
    this.listForm1 = this.item.ListFormStatus.filter((c) => { return c.Type == 0});
    this.listForm2 = this.item.ListFormStatus.filter((c) => { return c.Type == 1});
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
      setTimeout(() => {
          this.updateSlides();
      }, 300);
      super.preLoadData();
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

    /// 0: Sysnopsis/1:Phan tich/2:HDDD/3:HDKH/4:LLKH-CN/5:SYLL-CN/6:LLKH-NCV/7:SYLL-NCV
    openDetailModal(type){
        var page = null; 
        var param = { 'idDeTai': this.id, 'idNhanSu': -1 };
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
              param = { 'idDeTai': this.id, 'idNhanSu': this.item.IDChuNhiem };
              break;
            case 5:
              page = SysnopsisModalPage;
              break;
            case 6:
              page = NhanSuLLKHModalPage;
              param = { 'idDeTai': this.id, 'idNhanSu': this.item.IDNCV };
              break;
            case 7:
              page = SysnopsisModalPage;
              break;    
        }

        let myModal = this.modalCtrl.create(page, param, { cssClass: 'preview-modal' });
        myModal.present();
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
                this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
      })
  };
  }