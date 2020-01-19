import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_BaoCaoTienDoNghienCuuCustomProvider } from '../../../providers/Services/CustomService';
import { BaoCaoTienDoNghienCuuModalPage } from '../bao-cao-tien-do-nghien-cuu-modal/bao-cao-tien-do-nghien-cuu-modal';

@IonicPage({ name: 'page-bao-cao-tien-do-nghien-cuu', segment: 'bao-cao-tien-do-nghien-cuu/:value', priority: 'high' }) 
@Component({ selector: 'page-bao-cao-tien-do-nghien-cuu', templateUrl: 'bao-cao-tien-do-nghien-cuu.html' })
export class BaoCaoTienDoNghienCuuPage extends ListPage {
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
        super('page-bao-cao-tien-do-nghien-cuu', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.idDeTai = navParams.get('id');
        this.paramValue = navParams.get('value');
        try {
            var arr = this.paramValue.split('-');
            this.idDeTai = arr[arr.length - 1];
        }
        catch (e) {
            this.idDeTai = 0;
        }

        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
    }

    loadData() {
        this.gridConfig.page++;
        this.currentProvider.getListCustom(this.idDeTai).then((result: any) => {
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

    openDetail(item) {
        let myModal = this.modalCtrl.create(BaoCaoTienDoNghienCuuModalPage, {
            'id': item.ID, 'idDeTai': this.idDeTai });
        myModal.present();
    }

    add() {
        let item = {
            ID: 0,
        };
        this.openDetail(item);
    }
}
