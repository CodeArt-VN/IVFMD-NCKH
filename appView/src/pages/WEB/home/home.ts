import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, PopoverController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';

import { WEB_BaiVietProvider, WEB_DanhMucProvider } from '../../../providers/Services/Services';
import { GlobalData } from '../../../providers/CORE/global-variable';
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
        let pinQuery = { Pin: true }
        let menuQuery = {IsDisabled : false}
        Promise.all([
            this.danhMucProvider.read(menuQuery),
            this.currentProvider.read(pinQuery),
        ]).then(values => {
            GlobalData.WebData.menu = this.menuList = values[0]['data'];
            GlobalData.WebData.pinPost = this.pinPost = values[1]['data'].sort(function (a, b) {
                var keyA = a.PinPos == null ? 999 : a.PinPos,
                    keyB = b.PinPos == null ? 999 : b.PinPos;
                if (keyA < keyB) return -1;
                if (keyA > keyB) return 1;
                return 0;
            });
        })
    }

    preLoadData() {
        this.avatarURL = this.userprofile.Avatar;
        this.query.Home = true;
        if (!GlobalData.WebData.menu.length) {
            this.loadMenu();
        }
        else {
            this.menuList = GlobalData.WebData.menu;
            this.pinPost = GlobalData.WebData.pinPost;
        }
        super.preLoadData();
    }

    loadedData() {
        this.items = this.items.sort(function (a, b) {
            var keyA = a.HomePos == null ? 999 : a.HomePos,
                keyB = b.HomePos == null ? 999 : b.HomePos;
            if (keyA < keyB) return -1;
            if (keyA > keyB) return 1;
            return 0;
        });
        this.items.forEach(i => {
            i.ModifiedDateText = this.commonService.dateFormatFriendly(i.ModifiedDate);
        });
    }

    showSmallMenu(ev: UIEvent){
        let popover = this.popoverCtrl.create(PopoverPage, {
            popid: 'web-cate-menu', menuList: this.menuList
        });
        popover.present({ev: ev});
    }

    
}
