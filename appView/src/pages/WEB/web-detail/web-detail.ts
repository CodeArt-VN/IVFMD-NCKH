import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, PopoverController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';

import { WEB_BaiVietProvider, WEB_DanhMucProvider } from '../../../providers/Services/Services';
import { GlobalData } from '../../../providers/CORE/global-variable';
import { PopoverPage } from '../../HETHONG/popover/popover';
import { appSetting } from '../../../providers/CORE/api-list';

@IonicPage({ name: 'page-web-detail', segment: 'bai-viet/:**', priority: 'high' })
@Component({ selector: 'page-web-detail', templateUrl: 'web-detail.html' })
export class WebDetailPage extends ListPage {
    avatarURL = 'assets/imgs/avartar-empty.jpg';
    imageServer = appSetting.mainService.base;
    hasShadow = false;
    menuList: any[] = [];
    pinPost: any[] = [];

    url = '';
    id = 0;
    item: any = {};

    cate: any = null;

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
        super('page-web-detail', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
        events.subscribe('app:UpdateAvatar', (avatarURL) => {
            this.avatarURL = avatarURL;
        });
    }


    loadMenu() {
        let pinQuery = { Pin: true }
        let menuQuery = { IsDisabled: false }
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
        if (!GlobalData.WebData.menu.length) {
            this.loadMenu();
        }
        else {
            this.menuList = GlobalData.WebData.menu;
            this.pinPost = GlobalData.WebData.pinPost;
        }

        this.url = window.location.hash;
        let matches = this.url.match(/^.*\/(\d+)/);
        if (this.url && matches && matches.length) {
            this.id = parseInt(matches[1]);
        }
        else {
            //not found
        }
        super.preLoadData();
    }

    loadData() {
        if (this.id) {
            this.currentProvider.getAnItem(this.id, '').then((ite) => {
                this.commonService.copyPropertiesValue(ite, this.item);
                this.cate = this.menuList.find(d => d.ID == this.item.IDDanhMuc);

            }).catch((data) => {
                //not found
            });
        }
        else {
            //not found
        }
    }

    // fix ionic lost url
    ionViewDidEnter() {
        super.ionViewDidEnter();
        setTimeout(() => {
            window.location.hash = this.url;
        }, 0);
    }

    showSmallMenu(ev: UIEvent){
        let popover = this.popoverCtrl.create(PopoverPage, {
            popid: 'web-cate-menu', menuList: this.menuList
        });
        popover.present({ev: ev});
    }

}
