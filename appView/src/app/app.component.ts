import { Component, ViewChild } from '@angular/core';
import { Nav, Platform, MenuController, Events, ModalController, PopoverController } from 'ionic-angular';
import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import { GoogleAnalytics } from '@ionic-native/google-analytics';


import { GlobalData } from '../providers/CORE/global-variable';
import { AccountServiceProvider } from '../providers/CORE/account-service';
import { StaffModalPage } from '../pages/ADMIN/staff-modal/staff-modal';
import { NhanSuLLKHModalPage } from '../pages/WEB/nhan-su-llkh-modal/nhan-su-llkh-modal';
import { NhanSuSYLLModalPage } from '../pages/WEB/nhan-su-syll-modal/nhan-su-syll-modal';
import { HosremModalPage } from '../pages/WEB/hosrem-modal/hosrem-modal';

import { PopoverPage } from '../pages/HETHONG/popover/popover';


@Component({
    templateUrl: 'app.html'
})
export class MyApp {
    @ViewChild(Nav) nav: Nav;
    //@ViewChild('menuScroll') menuScroll: any;
    avatarURL = 'assets/imgs/avartar-empty.jpg';
    userprofile = GlobalData.Profile;
    rootPage: any = null;
    activePage = '';
    userMenuItems: any;
    userAdminItems: any;
    showAdminMenu: false;
    firstpage = true;

    constructor(
        public menu: MenuController,
        public platform: Platform,
        public statusBar: StatusBar,
        public splashScreen: SplashScreen,
        public ga: GoogleAnalytics,
        public modalCtrl: ModalController,
        public popoverCtrl: PopoverController,

        public events: Events,
        public accountService: AccountServiceProvider

    ) {
        
        events.subscribe('app:UpdateAvatar', (avatarURL) => {
            if(avatarURL){
                this.avatarURL = avatarURL;
            }
            else{
                avatarURL = 'assets/imgs/avartar-empty.jpg';
            }
        });

        events.subscribe('app:openPage', (page) => {
            this.openPage({ Code: page });
        });
        events.subscribe('app:changeMenu', (page, pageID) => {
            this.changeMenu(page, pageID);
        });
        events.subscribe('user:update', () => {
            this.loadUserData();
        });
        events.subscribe('user:logout', () => {
            this.logout();
        });
        events.subscribe('user:openProfile', () => {
            this.openProfile();
        });
        events.subscribe('app:openDefaultPage', () => {
            this.openDefaultPage();
        });
        events.subscribe('app:changeLayout', () => {
            let pageComponent = this.activePage;
            let layout = 'doc-layout';
            if (
                pageComponent == 'page-home'
                || pageComponent == 'page-web-list'
                || pageComponent == 'page-web-detail'
                || pageComponent == 'page-contact'
                || pageComponent == 'page-support'

            ) {
                layout = 'web-layout';
            }
            else if (
                pageComponent == 'page-login'
                || pageComponent == 'page-forgot-password'

            ) {
                layout = '_free';
            }

            let body = document.getElementsByTagName('body')[0];
            body.classList.remove("web-layout");
            body.classList.remove("doc-layout");
            body.classList.add(layout);
        });


        this.initializeApp();
        this.loadUserData();
        //loadUserData => Profile => userMenu
    }


    //Events

    ngOnInit() {
        //console.log("app - ngOnInit");
    }

    ngAfterViewInit() {
        
        //console.log("ngAfterViewInit");
        this.nav.viewDidEnter.subscribe((data) => {
            // if (this.platform.is('cordova')) {
            //     // GoogleAnalytics.startTrackerWithId(this.config.analytics_trackingId).then(() => {
            //     //     GoogleAnalytics.trackView(data.instance.constructor.name)
            //     // })
            // }
        });
    }

    openPage(page, param = null) {
        this.menu.close();
        if (page) {
            this.nav.setRoot(page.Code, param);
            this.changeMenu(page.Code);

            // if (page.Icon == 'stats') {
            //     this.menuScroll.scrollTo(0, 500, 200);
            // } else if (page.Icon == 'logo-buffer' || page.Icon == 'bulb' || page.Icon == 'options') {
            //     this.menuScroll.scrollToBottom(200);
            // }
        }


    }

    openProfile() {
        if (this.userprofile.Id) {
            if (this.userprofile.StaffID) {
                let myModal = this.modalCtrl.create(StaffModalPage, { 'id': this.userprofile.StaffID, 'profile': true });
                myModal.present();
            }
            this.menu.close();



        }
        else if (this.activePage != 'page-login') {
            this.menu.close();
            this.openPage({ Code: 'page-login' });
        }
    }

    openLLKH() {
        if (this.userprofile.Id) {
            if (this.userprofile.StaffID) {
                let myModal = this.modalCtrl.create(NhanSuLLKHModalPage, { 'idNhanSu': this.userprofile.StaffID }, { cssClass: 'preview-modal' });
                myModal.present();
            }
            this.menu.close();



        }
        else if (this.activePage != 'page-login') {
            this.menu.close();
            this.openPage({ Code: 'page-login' });
        }
    }

    openSYLL() {
        if (this.userprofile.Id) {
            if (this.userprofile.StaffID) {
                let myModal = this.modalCtrl.create(NhanSuSYLLModalPage, { 'idNhanSu': this.userprofile.StaffID }, { cssClass: 'preview-modal' });
                myModal.present();
            }
            this.menu.close();



        }
        else if (this.activePage != 'page-login') {
            this.menu.close();
            this.openPage({ Code: 'page-login' });
        }
    }

    openHosrem() {
        if (this.userprofile.Id) {
            if (this.userprofile.StaffID) {
                let myModal = this.modalCtrl.create(HosremModalPage, { 'idNhanSu': this.userprofile.StaffID }, { cssClass: 'preview-modal' });
                myModal.present();
            }
            this.menu.close();



        }
        else if (this.activePage != 'page-login') {
            this.menu.close();
            this.openPage({ Code: 'page-login' });
        }
    }

    logout() {
        this.accountService.logout()
            .then(_ => {
                this.menu.close();
                this.countLoop = 0;
                //account service check user changed and publish event...
            })
            .catch(err => {

            });
    }

    popover(ev: UIEvent) {
        let popover = this.popoverCtrl.create(PopoverPage, {
            popid: 'cp-user', 
            isAdminItems: this.userAdminItems.length ? true : false,
            isDocItems: this.userprofile.MenuItems.filter(d => d.AppName == 'DOC').length ? true : false,
        });

        popover.present({
            ev: ev
        });
        popover.onDidDismiss(data => {
            if (data == 'openAdmin') {
                this.nav.setRoot(this.userAdminItems[0].Forms[0].Code);
            }
            else if (data == 'openDoc') {
                this.nav.setRoot(this.userprofile.MenuItems.filter(d => d.AppName == 'DOC')[0].Forms[0].Code);
            }
            else if (data == 'openProfile') {
                this.openProfile();
            }
            else if (data == 'openLLKH') {
                this.openLLKH();
            }
            else if (data == 'openSYLL') {
                this.openSYLL();
            }
            else if (data == 'openHosrem') {
                this.openHosrem();
            }
            else if (data == 'logout') {
                this.logout();
            }
        });
    }

    //private function
    initializeApp() {
        this.platform.ready().then(() => {
            this.statusBar.styleDefault();
            this.splashScreen.hide();
            // this.ga.startTrackerWithId('UA-118642509-2')
            //     .then(() => {
            //         this.ga.debugMode();
            //         this.ga.setAllowIDFACollection(true);
            //         this.ga.trackView('platform.ready');
            //     })
            //     .catch(e => console.log('Error starting GoogleAnalytics', e));
        });
    }


    countLoop=0;
    loadUserData() {
        this.countLoop++;
        //console.log('loadUserData',this.countLoop);
        if(this.countLoop > 5){
            return;
        }
        return new Promise(resolve => {
            this.accountService.loadSavedData(true).then(() => {
                //console.log(GlobalData.Profile);
                this.userprofile = GlobalData.Profile;
                if(this.userprofile.Avatar){
                    this.avatarURL = this.userprofile.Avatar;
                }
                this.userMenuItems = this.userprofile.MenuItems;
                this.userAdminItems = this.userprofile.MenuItems.filter(d => d.AppName == 'Admin');
                
                if (this.userprofile.Partner) {
                    let link: any = document.querySelector("link[rel*='icon']") || document.createElement('link');
                    link.type = 'image/x-icon';
                    link.rel = 'shortcut icon';
                    link.href = this.userprofile.Partner.LogoURL;
                    document.getElementsByTagName('head')[0].appendChild(link);
                }

                //TODO: sau khi đăng nhập, check nếu không được quyền dùng page hiện tại thì di chuyển đến trang mặc định
                let canPass = false;
                for (let i = 0; i < GlobalData.Profile.MenuItems.length; i++) {
                    const g = GlobalData.Profile.MenuItems[i];
                    for (let j = 0; j < g.Forms.length; j++) {
                        const f = g.Forms[j];

                        if (f.Code == this.activePage || f.Code.indexOf(this.activePage) > -1) {
                            canPass = true;
                            break;
                        }
                    }
                    if (canPass) {
                        break;
                    }
                }
                if (!canPass) {
                    console.log('loadUserData GateKeeper - access denied', this.activePage);
                    this.firstpage=true;
                    setTimeout(() => this.events.publish('app:openDefaultPage'));
                }
                else {
                    //console.log('loadUserData GateKeeper - pass', this.activePage);
                }

                resolve(true);

            })
        });

    }

    openDefaultPage() {
        //console.log('openDefaultPage', this.userMenuItems, this.userMenuItems[0].Forms[0]);
        debugger
        if (this.userMenuItems) {
            this.openPage(this.userMenuItems[0].Forms[0]);
        } else {
            this.loadUserData().then(() => {
                this.openPage(this.userMenuItems[0].Forms[0]);
            })
        }
    }

    changeMenu(pageComponent, pageID = null) {
        if (!pageID) {
            pageID = pageComponent
        }
        this.activePage = pageComponent;
        //this.ga.trackView(pageID);

        if (pageComponent.indexOf('-modal') > -1 || pageComponent.indexOf('chi-tiet') > -1) {
            return;
        }
        if (this.firstpage) {
            this.events.publish('app:changeLayout');
            this.firstpage = false;
        }

    }
}
