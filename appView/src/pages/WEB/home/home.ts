import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, PopoverController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';

import { WEB_BaiVietProvider, WEB_DanhMucProvider } from '../../../providers/Services/Services';
import { PopoverPage } from '../../HETHONG/popover/popover';
import { appSetting } from '../../../providers/CORE/api-list';

@IonicPage({ name: 'page-home', segment: 'home', priority: 'high' })
@Component({ selector: 'page-home', templateUrl: 'home.html' })
export class HomePage extends ListPage {
    avatarURL = 'assets/imgs/avartar-empty.jpg';
    imageServer = appSetting.mainService.base;
    menuList: any[] = [{ID:'loading'},{ID:'loading'},{ID:'loading'}];
    pinPost: any[] = [{ID:'loading'},{ID:'loading'},{ID:'loading'}];
    items: any[] = [{ID:'loading'},{ID:'loading'},{ID:'loading'}];
    
    Modules = [];
    ListMenu = [];

    constructor(
        public currentProvider: WEB_BaiVietProvider,
        public danhMucProvider: WEB_DanhMucProvider,

        public popoverCtrl: PopoverController,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
    ) {
        super('page-home', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
        events.subscribe('app:UpdateAvatar', (avatarURL) => {
            this.avatarURL = avatarURL;
        });
    }

    loadMenu() {
        this.menuList = [{"IDParent":null,"ID":2,"Code":"Tin tức","Name":"hệ thống","Remark":null,"Sort":1,"IsDisabled":false,"IsDeleted":false,"CreatedBy":"build in","ModifiedBy":"btthien@hyvonghospital.com","CreatedDate":"2018-07-20T09:22:07.7+07:00","ModifiedDate":"2018-09-20T17:32:34.4877703+07:00","ThumbnailImage":null,"Duyet":true,"NgonNgu":null,"Summary":null,"URL":"#/chuyen-muc/2/tin-tuc-he-thong","SEO1":null,"SEO2":null,"IsBuildIn":false},{"IDParent":null,"ID":4,"Code":"Giới thiệu","Name":"phòng QM","Remark":null,"Sort":2,"IsDisabled":false,"IsDeleted":false,"CreatedBy":"build in","ModifiedBy":"host@codeart.vn","CreatedDate":"2018-07-20T09:20:14.043+07:00","ModifiedDate":"2018-09-20T13:03:55.2898049+07:00","ThumbnailImage":null,"Duyet":true,"NgonNgu":null,"Summary":null,"URL":"#/bai-viet/6/gioi-thieu-phong-qm","SEO1":null,"SEO2":null,"IsBuildIn":false},{"IDParent":null,"ID":1,"Code":"SOPs","Name":null,"Remark":null,"Sort":2,"IsDisabled":false,"IsDeleted":false,"CreatedBy":"build in","ModifiedBy":"host@codeart.vn","CreatedDate":"2018-07-20T09:20:14.043+07:00","ModifiedDate":"2018-08-24T15:22:13.047863+07:00","ThumbnailImage":null,"Duyet":true,"NgonNgu":null,"Summary":null,"URL":"#/sops","SEO1":null,"SEO2":null,"IsBuildIn":true},{"IDParent":null,"ID":9,"Code":"Cải tiến","Name":"tích cực","Remark":null,"Sort":4,"IsDisabled":false,"IsDeleted":false,"CreatedBy":"host@codeart.vn","ModifiedBy":"host@codeart.vn","CreatedDate":"2018-09-01T17:57:36.3912282+07:00","ModifiedDate":"2018-09-20T13:04:31.4528733+07:00","ThumbnailImage":null,"Duyet":false,"NgonNgu":null,"Summary":null,"URL":"#/chuyen-muc/9/du-an-cai-tien","SEO1":null,"SEO2":null,"IsBuildIn":false},{"IDParent":null,"ID":3,"Code":"Báo cáo","Name":"Hệ Thống","Remark":"","Sort":5,"IsDisabled":false,"IsDeleted":false,"CreatedBy":"build in","ModifiedBy":"latuan@hyvonghospital.com","CreatedDate":"2018-07-20T09:20:14.043+07:00","ModifiedDate":"2019-04-08T13:04:16.9137415+07:00","ThumbnailImage":null,"Duyet":true,"NgonNgu":null,"Summary":null,"URL":"#/chuyen-muc/3/bao-cao-su-co","SEO1":null,"SEO2":null,"IsBuildIn":true},{"IDParent":null,"ID":11,"Code":"QC","Name":"HT IVFMD","Remark":null,"Sort":6,"IsDisabled":false,"IsDeleted":false,"CreatedBy":"btthien@hyvonghospital.com","ModifiedBy":"btthien@hyvonghospital.com","CreatedDate":"2018-11-01T09:18:51.6979296+07:00","ModifiedDate":"2018-11-01T09:33:34.2794104+07:00","ThumbnailImage":null,"Duyet":false,"NgonNgu":null,"Summary":null,"URL":"#/chuyen-muc/11/qc-null","SEO1":null,"SEO2":null,"IsBuildIn":false}];
        
    }

    preLoadData() {
        this.avatarURL = this.userprofile.Avatar;
        this.query.Home = true;
        this.loadMenu();
        
        this.Modules = this.getModules();
        this.ListMenu = this.getModules(true);

        super.preLoadData();
    }

 

    showSmallMenu(ev: UIEvent){
        let popover = this.popoverCtrl.create(PopoverPage, {
            popid: 'web-cate-menu', menuList: this.menuList
        });
        popover.present({ev: ev});
    }

    gotoPage(menu) {
        this.navCtrl.setRoot(menu.Code);
    }

    gotoPageRefer() {
        let origin = document.location.origin;
        let url = origin.substring(0, origin.lastIndexOf(":")) + ":9002/";
        window.open(url);
    }

    
}
