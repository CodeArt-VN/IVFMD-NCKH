import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { WEB_BaiVietProvider, WEB_DanhMucProvider } from '../../../providers/Services/Services';
import { PostModalPage } from '../post-modal/post-modal';
import { appSetting } from '../../../providers/CORE/api-list';



@IonicPage({ name: 'page-post', segment: 'post', priority: 'high' }) 
@Component({ selector: 'page-post', templateUrl: 'post.html' })
export class PostPage extends ListPage {
    imageServer = appSetting.mainService.base;
    DanhMuc:any[] = [];
    FormGroups = [];
    filterValue = 'Home';

    constructor(
        public currentProvider: WEB_BaiVietProvider,
        public danhMucProvider: WEB_DanhMucProvider,

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
        super('page-post', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        
    }
    
    preLoadData(){
        this.FormGroups = this.userprofile.MenuItems.filter(d=>d.AppID==3);
        
        this.query.Home = true;
        this.query.Pin = '';
        this.query.IDDanhMuc = '';

        this.danhMucProvider.read().then((result:any) =>{
            this.DanhMuc = result.data;
        });

        super.preLoadData();
    }

    loadedData(){
        if(this.filterValue == 'Home'){
            this.items = this.items.sort(function (a, b) {
                var keyA = a.HomePos == null ? 999 : a.HomePos,
                    keyB = b.HomePos == null ? 999 : b.HomePos;
                if (keyA < keyB) return -1;
                if (keyA > keyB) return 1;
                return 0;
            });
        }
        else if(this.filterValue == 'Pin'){
            this.items = this.items.sort(function (a, b) {
                var keyA = a.PinPos == null ? 999 : a.PinPos,
                    keyB = b.PinPos == null ? 999 : b.PinPos;
                if (keyA < keyB) return -1;
                if (keyA > keyB) return 1;
                return 0;
            });
        }
        
    }

    refresh(){
        this.changeFilter();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(PostModalPage, { 'id': item.ID, IDPartner: this.query.IDPartner }, {cssClass:'post-modal'});
        myModal.present(); 
    }
    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
    
    changeFilter(){
        if(this.filterValue == 'Home'){
            this.query.Home = true;
            this.query.Pin = '';
            this.query.IDDanhMuc = '';
        }
        else if(this.filterValue == 'Pin'){
            this.query.Home = '';
            this.query.Pin = true;
            this.query.IDDanhMuc = '';
        }
        else{
            this.query.Home = '';
            this.query.Pin = '';
            this.query.IDDanhMuc = this.filterValue;
        }
        this.loadData();
    }

    //sort theo filter home/pin
}
