import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_HoiNghiHoiThaoCustomProvider } from '../../../providers/Services/CustomService';
import { HoiNghiHoiThaoModalPage } from '../hoi-nghi-hoi-thao-modal/hoi-nghi-hoi-thao-modal';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao', segment: 'hoi-nghi-hoi-thao', priority: 'high' }) 
@Component({ selector: 'page-hoi-nghi-hoi-thao', templateUrl: 'hoi-nghi-hoi-thao.html' })
export class HoiNghiHoiThaoPage extends ListPage {
    FormGroups = [];
    canApprove = false;
    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoCustomProvider,
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
        super('page-hoi-nghi-hoi-thao', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }
    
    preLoadData(){
        this.canApprove = this.isUserCanUse('page-hoi-nghi-hoi-thao-hrco');
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        super.preLoadData();
    }

    isUserCanUse(functionCode) {
        let menus = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        return menus[0].Forms.findIndex(d => d.Code == functionCode) > -1;
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(HoiNghiHoiThaoModalPage, { 'id': item.ID });
        myModal.present();
    }

    action(item, actionCode) {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.updateStatus(item.ID, actionCode).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        })
    }

    loadedData() {
        this.items.forEach((i) => {
            i.ThoiGianText = this.commonService.dateFormat(i.ThoiGian, 'dd/mm/yy hh:MM');
            i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
        })
    }

    uploadCVHosrem(item) {

    }

    downloadBaiAbstract(item) {

    }

    uploadBaiAbstract(item) {
        this.showActionMore = false;
        debugger
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
    }

    downloadBaiFulltext(item) {

    }

    uploadBaiFulltext(item) {

    }


    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
}
