import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_BaoCaoTienDoNghienCuuCustomProvider } from '../../../providers/Services/CustomService';

@IonicPage({ name: 'page-tong-hop-bao-cao-tien-do-nghien-cuu', segment: 'tong-hop-bao-cao-tien-do-nghien-cuu', priority: 'high' }) 
@Component({ selector: 'page-tong-hop-bao-cao-tien-do-nghien-cuu', templateUrl: 'tong-hop-bao-cao-tien-do-nghien-cuu.html' })
export class TongHopBaoCaoTienDoNghienCuuPage extends ListPage {
    idDeTai: any;
    paramValue: any;
    model: any;
    FormGroups = [];
    lstData = [];
    constructor(
        public currentProvider: PRO_BaoCaoTienDoNghienCuuCustomProvider,

        public modalCtrl: ModalController,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider
    ) {
        super('page-tong-hop-bao-cao-tien-do-nghien-cuu', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }

    loadData() {
        this.gridConfig.page++;
        this.currentProvider.getListAll().then((result: any) => {
            this.lstData = [...result];
            this.lstData.forEach((i) => {
                i.NgayTaoText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
            })
            this.lastKeyword = this.keyword;
            this.gridConfig.totalRows = result.length;
            this.loadedData();
        }).catch((data) => {
            this.lstData = [];
            this.lastKeyword = this.keyword;
            this.gridConfig.totalRows = 0;
            this.loadedData();
        });
    }
    
    preLoadData(){
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        super.preLoadData();
    }
}
