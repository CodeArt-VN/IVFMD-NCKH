import { Component, ViewChild, ChangeDetectorRef } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_HoiNghiHoiThaoCustomProvider } from '../../../providers/Services/CustomService';
import { HoiNghiHoiThaoModalPage } from '../hoi-nghi-hoi-thao-modal/hoi-nghi-hoi-thao-modal';
import { appSetting } from '../../../providers/CORE/api-list';
import { FileUploader, FileDropDirective, FileSelectDirective } from 'ng2-file-upload';
@IonicPage({ name: 'page-hoi-nghi-hoi-thao', segment: 'hoi-nghi-hoi-thao', priority: 'high' }) 
@Component({ selector: 'page-hoi-nghi-hoi-thao', templateUrl: 'hoi-nghi-hoi-thao.html' })
export class HoiNghiHoiThaoPage extends ListPage {
    @ViewChild('importfile') importfile: any;
    FormGroups = [];
    canApprove = false;
    UploadAPI = appSetting.apiDomain('CUS/DOC/File/FileUpload');
    hasBaseDropZoneOver = false;
    File = "";
    FileSize = 0;
    Extension = "";
    FileName = "";
    ID = 0;
    CurrentFile = "";
    uploader: FileUploader = new FileUploader({
        url: this.UploadAPI,
        authTokenHeader: "Authorization",
        authToken: this.commonService.getToken(),
        queueLimit: 1,
        allowedFileType: ['doc', 'xls', 'ppt', 'pdf', 'image', 'video']
    });

    constructor(
        public currentProvider: PRO_HoiNghiHoiThaoCustomProvider,
        private cdr: ChangeDetectorRef,
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
        this.uploader.onBeforeUploadItem = (item) => {
            this.UploadAPI = appSetting.apiDomain('CUS/DOC/File/FileUpload/' + 0 + '?IDPartner=' + 1);
            item.url = this.UploadAPI;
        }
        this.uploader.onSuccessItem = (item, response, status: number, headers) => {
            if (status == 201 && response) {
                let data = JSON.parse(response);
                this.uploader.clearQueue();
                if (this.CurrentFile == "Abstract") {
                    this.uploadBaiAbstract(data.Path);
                }
                if (this.CurrentFile == "FullText") {
                    this.uploadBaiFullText(data.Path);
                }
            }
        }
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

    downloadCVHosrem(item) {

    }

    // event

    fileOverBase(e: any): void {
        this.hasBaseDropZoneOver = e;
    }
    onFileSelected() {
        this.File = this.uploader.queue[0].file.name;
        this.FileSize = this.uploader.queue[0].file.size;
        this.Extension = this.uploader.queue[0].file.name.split('.').pop();
        this.FileName = this.uploader.queue[0].file.name;
        //this.cdr.detectChanges();
        this.uploader.uploadAll();
    }

    downloadBaiAbstract(item) {
        if (item.BaiAbstract)
            this.download(item.BaiAbstract);
    }

    uploadBaiAbstractClick(item) {
        this.ID = item.ID;
        this.CurrentFile = "Abstract";
        this.showActionMore = false;
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
    }

    uploadBaiAbstract(path) {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.uploadAbstract({ ID: this.ID, BaiAbstract: path }).then((savedItem: any) => {
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

    donwloadBaiFullText(item) {
        if (item.BaiFulltext)
            this.download(item.BaiFulltext);
    }

    uploadBaiFullTextClick(item) {
        this.ID = item.ID;
        this.CurrentFile = "FullText";
        this.showActionMore = false;
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
    }

    uploadBaiFullText(path) {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.uploadFullText({ ID: this.ID, BaiFulltext: path }).then((savedItem: any) => {
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


    add() {
        let item = {
            ID: 0,
            
        };
        this.openDetail(item);
    }
}
