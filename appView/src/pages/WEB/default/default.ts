import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, PopoverController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';

import { WEB_BaiVietProvider, WEB_DanhMucProvider } from '../../../providers/Services/Services';
import { PopoverPage } from '../../HETHONG/popover/popover';
import { appSetting } from '../../../providers/CORE/api-list';
@IonicPage({ name: 'page-default', segment: 'default', priority: 'high' }) 
    @Component({ selector: 'page-default', templateUrl: 'default.html' })
export class DefaultPage extends ListPage {
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
        super('page-default', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
        events.subscribe('app:UpdateAvatar', (avatarURL) => {
            this.avatarURL = avatarURL;
        });
    }

    preLoadData() {
        this.avatarURL = this.userprofile.Avatar;
        this.query.Home = true;
        
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
