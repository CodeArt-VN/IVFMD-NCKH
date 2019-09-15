import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController, PopoverController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { HRM_STAFF_NhanSuProvider } from '../../../providers/Services/Services';
import { GlobalData } from '../../../providers/CORE/global-variable';
import { appSetting } from '../../../providers/CORE/api-list';

@IonicPage({ name: 'page-team', segment: 'team', priority: 'high' })
@Component({ selector: 'page-team', templateUrl: 'team.html' })
export class TeamPage extends ListPage {
    canManageFolder = false;
    canManageFile = false;
    canApproveDoc = false;
    canViewReport = false;
    canViewTeam = false;
    canViewSops = false;

    partnerInfo = null;

    constructor(
        public currentProvider: HRM_STAFF_NhanSuProvider,

        public popoverCtrl: PopoverController,
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
        super('page-team', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }

    preLoadData() {
    
        this.canManageFolder = this.isUserCanUse('page-folder-modal');
        this.canManageFile = this.isUserCanUse('page-file-modal');
        this.canApproveDoc = this.isUserCanUse('page-approve');
        this.canViewReport = this.isUserCanUse('page-report');
        this.canViewTeam = this.isUserCanUse('page-team');
        this.canViewSops = this.isUserCanUse('page-team');

        super.preLoadData();

    }

    loadedData(){
        this.items.forEach(i=>{
            i.Avatar = appSetting.mainService.base + 'Uploads/HRM/Staffs/Avatars/'+ i.Code +'.jpg';
        })
    }

    isUserCanUse(functionCode) {
        let menus = GlobalData.Profile.MenuItems;
        let sopGroup = menus.find(d => d.Code == 'SOPs');
        if (sopGroup) {
            return sopGroup.Forms.findIndex(d => d.Code == functionCode) > -1;
        }
        return false;
    }

    avatarLoadError(item) {
        item.Avatar = 'assets/imgs/avartar-empty.jpg';
    }
}