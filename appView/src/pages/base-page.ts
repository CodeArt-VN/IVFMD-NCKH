﻿import { ViewChild } from '@angular/core';
import { NavController, NavParams, Events, Content, LoadingController, ToastController, AlertController, PopoverController } from 'ionic-angular';
import { GlobalData } from '../providers/CORE/global-variable'
import { AccountServiceProvider } from '../providers/CORE/account-service';
import { CommonServiceProvider } from '../providers/CORE/common-service';
import introJs from 'intro.js/intro.js';
import { PopoverPage } from './HETHONG/popover/popover';

export class BasePage {
    @ViewChild(Content) content: Content;
    userprofile = GlobalData.Profile;
    showActionMore = false;
    loadingIndicator: boolean = true;
    loading: any;
    pageToGoBack: string;

    constructor(
        public pageName: string,
        public pageChildName: string,
        public currentProvider: any,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
    ) {
        this.events.unsubscribe('app:Update' + this.pageName);
        this.events.subscribe('app:Update' + this.pageName, () => {
            this.refresh()
        });
    }
    //ctor => preLoadData => loadData => loadedData

    refresh() {
        this.preLoadData();
    }

    preLoadData() {
        this.loadData();
    }

    loadData() {
        this.loadedData();
    }

    loadedData() {
        this.loadingIndicator = false;
        // this.loading.dismiss();
    }

    goBack() {
        if (this.navCtrl.canGoBack()) {
            this.navCtrl.pop();
        }
        else {
            this.events.publish('app:openDefaultPage');
        }
    }

    openDefaultPage() {
        this.events.publish('app:openDefaultPage');
        return false;
    }
    openPage(page, item) {
        this.navCtrl.push(page, item);
        return false;
    }
    setPage(page, item) {
        this.navCtrl.setRoot(page, item);
        return false;
    }



    getName(ID, Lst: [any]) {
        if (!Lst) {
            return '...';
        }
        var it = Lst.filter(ite => ite.IsDeleted === false && ite.ID == ID);
        if (it.length) {
            return it[0].Name;
        }
        return '...';
    }

    getAttrib(ID, Lst, Attrib = 'Name', defaultValue = '...') {
        if (!Lst) {
            return defaultValue;
        }
        var it = Lst.filter(ite => ite.IsDeleted === false && ite.ID == ID);
        if (it.length) {
            return it[0][Attrib];
        }
        return defaultValue;
    }

    getItemInList(ID, Lst: [any]) {
        if (!Lst) {
            return {};
        }
        var it = Lst.filter(ite => ite.IsDeleted === false && ite.ID == ID);
        if (it.length) {
            return it[0];
        }
        return {};
    }

    loadingMessage(message) {
        this.loading = this.loadingCtrl.create({
            content: message
        });
        return this.loading.present();
    }

    toastMessage(message) {
        let toast = this.toastCtrl.create({
            message: message,
            duration: GlobalData.UserData.Setting.ToastMessageDelay
        });
        toast.present();
    }

    userGuide() {
        this.showActionMore = false;
        this.intro();
    }

    intro() {
        let intro = introJs.introJs();
        let options = GlobalData.IntroApp.getIntroByPage(this.pageName);
        if (options) {
            intro.setOptions(options.intro);
            intro.start();
        }
    }

    scrollToBottom() {
        setTimeout(() => {
            this.content.scrollToBottom(100);
        });
    }

    compare(e1: any, e2: any): boolean {
        return e1 === e2;
    }

    ionViewCanEnter(): Promise<void> {
        return new Promise<void>((resolve, reject) => {
            this.accountService.checkAuthor()
            .then(() => {
                this.checkPermission().then( ()=>{
                    resolve();
                }).catch(()=>{
                    reject();
                })
            })
            .catch(() => {
                setTimeout(() => this.events.publish('app:openDefaultPage'));
                reject();
            });
        });



    }

    ionViewDidLoad() {
        //console.log("ionViewDidLoad", this.pageName);
        this.preLoadData();
    }

    // ionViewWillEnter() {
    //     console.log("ionViewWillEnter", this.pageName);
    // }
    ionViewDidEnter() {
        //console.log("ionViewDidEnter", this.pageName);
        if (this.pageName.indexOf('modal') == -1 && this.pageName.indexOf('page-') > -1)
            this.events.publish('app:changeMenu', this.pageName);
    }
    // ionViewWillLeave() {
    //     console.log("ionViewWillLeave", this.pageName);
    // }
    ionViewDidLeave() {
        //console.log("ionViewDidLeave", this.pageName);
        this.events.publish('app:changeLayout');
    }
    // ionViewWillUnload() {
    //     console.log("ionViewWillUnload", this.pageName);
    // }
    // ionViewCanLeave() {
    //     console.log("ionViewCanLeave", this.pageName);
    // }



    checkPermission(){
        return new Promise<void>((resolve, reject) => {
            if(GlobalData &&  GlobalData.Profile && GlobalData.Profile.MenuItems){
                this.userprofile = GlobalData.Profile;
                let canPass = false;
                for (let i = 0; i < GlobalData.Profile.MenuItems.length; i++) {
                    const g = GlobalData.Profile.MenuItems[i];
                    for (let j = 0; j < g.Forms.length; j++) {
                        const f = g.Forms[j];
                        
                        if(f.Code == this.pageName || f.Code.indexOf(this.pageName)>-1 || this.pageName == null || this.pageName.indexOf('-modal')>-1){
                            canPass = true;
                            break;
                        }
                    }
                    if(canPass){
                        break;
                    }
                }
                if(canPass){
                    resolve();
                }
                else{
                    console.log('GateKeeper - access denied (no permission)', this.pageName);
                    setTimeout(() => this.events.publish('app:openDefaultPage'));
                    reject();
                }
            }
            else{
                console.log('GateKeeper - access denied (no data)', this.pageName);
                setTimeout(() => this.events.publish('app:openDefaultPage'));
                reject();
            }
        });
    }

    getModules(isNotHome = false) {
        let modules = [];
        let isDefault = this.userprofile.MenuItems.filter(d => d.Code == 'Home').length ? true : false;
        if (isNotHome)
            isDefault = false;
        let isNCKH = this.userprofile.MenuItems.filter(d => d.Code == 'NCKH-View').length ? true : false;
        let isNSKH = this.userprofile.MenuItems.filter(d => d.Code == 'NSKH').length ? true : false;
        let isHNHT = this.userprofile.MenuItems.filter(d => d.Code == 'HNHT').length ? true : false;
        let isSOPs = this.userprofile.MenuItems.filter(d => d.Code == 'SOPs').length ? true : false;
        let isAdmin = this.userprofile.MenuItems.filter(d => d.Code == 'Admin-PAR').length ? true : false;
        if (isDefault) {
            modules.push({ Module: "Home", Name: 'Home', Code: this.userprofile.MenuItems.filter(d => d.Code == 'Home')[0].FormMenu[0].Code });
        }
        if (isNCKH) {
            modules.push({ Module: "NCKH-View", Name: 'Nghiên cứu khoa học', 
            Remark: 'Đăng ký đề tài nghiên cứu khoa học. Khai báo các thông tin hội đồng nội bộ, hội đồng đạo đức, Clinical Trial, thu nhận bệnh nhân... Báo cáo tiến độ nghiên cứu.',
            Code: this.userprofile.MenuItems.filter(d => d.Code == 'NCKH-View')[0].FormMenu[0].Code });
        }
        if (isNSKH) {
            if (this.userprofile.MenuItems.filter(d => d.Code == 'NSKH')[0].FormMenu.length > 0) {
                modules.push({
                    Module: "NSKH", Name: 'Năng suất khoa học',
                    Remark: 'Báo cáo đề tài, tạp chí hội nghị - hội thảo, sản phẩm khoa học, duyệt kinh phí...',
                    Code: this.userprofile.MenuItems.filter(d => d.Code == 'NSKH')[0].FormMenu[0].Code
                });
            }
        }
        if (isHNHT) {
            modules.push({ Module: "HNHT", Name: 'Hội nghị, hội thảo',
            Remark: 'Quản lý hội nghị hội thảo và các đề tài...', 
            Code: this.userprofile.MenuItems.filter(d => d.Code == 'HNHT')[0].FormMenu[0].Code });
        }
        if (isSOPs) {
            modules.push({ Module: "SOPs", Name: 'Thư viện điện tử', 
            Remark: 'Thư viện điện tử, nơi lưu trữ các tài liệu, đề tài khoa học đã báo cáo...',
            Code: this.userprofile.MenuItems.filter(d => d.Code == 'SOPs')[0].FormMenu[0].Code });
        }
        if (isAdmin) {
            modules.push({ Module: "Admin-PAR", Name: 'Quản trị hệ thống', Code: this.userprofile.MenuItems.filter(d => d.Code == 'Admin-PAR')[0].FormMenu[0].Code });
        } 
        return modules;
    }

    popover(ev: UIEvent, popoverCtrl) {
        let popover = popoverCtrl.create(PopoverPage, {
            popid: 'cp-user', 
            isAdminItems: this.userprofile.MenuItems.filter(d => d.AppName == 'Admin').length ? true : false,
            isDocItems: this.userprofile.MenuItems.filter(d => d.AppName == 'DOC').length ? true : false,
        });

        popover.present({
            ev: ev
        });
        popover.onDidDismiss(data => {
            if (data == 'openAdmin') {
                this.navCtrl.setRoot(this.userprofile.MenuItems.filter(d => d.AppName == 'Admin')[0].Forms[0].Code);
            }
            else if (data == 'openDoc') {
                this.navCtrl.setRoot(this.userprofile.MenuItems.filter(d => d.AppName == 'DOC')[0].Forms[0].Code);
            }
            else if (data == 'openProfile') {
                this.events.publish('user:openProfile');
            }
            else if (data == 'openLLKH') {
                this.events.publish('user:openLLKH');
            }
            else if (data == 'openSYLL') {
                this.events.publish('user:openSYLL');
            }
            else if (data == 'openHosrem') {
                this.events.publish('user:openHosrem');
            }
            else if (data == 'logout') {
                this.events.publish('user:logout');
            }
        });
    }

    downloadContent(name, data) {
        var pom = document.createElement('a');
        pom.setAttribute('href', 'data:text/plain;charset=utf-8,' + encodeURIComponent(data));
        pom.setAttribute('download', name);
        pom.style.display = 'none';
        document.body.appendChild(pom);
        pom.click();
        document.body.removeChild(pom);
    }

    downloadURLContent(url) {
        var pom = document.createElement('a');
        pom.setAttribute('target', '_blank');
        pom.setAttribute('href', url);
        //pom.setAttribute('target', '_blank');
        pom.style.display = 'none';
        document.body.appendChild(pom);
        pom.click();
        document.body.removeChild(pom);
    }

    downloadWithBaseName(path) {
        this.downloadURLContent(this.commonService.getDownloadUrl(path));
    }
}
