import { Component, ViewChild, ChangeDetectorRef } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { CAT_ThietLapTemplateProvider } from '../../../providers/Services/CustomService';
import { FileUploader, FileDropDirective, FileSelectDirective } from 'ng2-file-upload';
import { appSetting } from '../../../providers/CORE/api-list';

@IonicPage({ name: 'page-thiet-lap-template', segment: 'thiet-lap-template', priority: 'high' })
@Component({ selector: 'page-thiet-lap-template', templateUrl: 'thiet-lap-template.html' })
export class ThietLapTemplatePage extends ListPage {
    @ViewChild('importfile') importfile: any;
    FormGroups = [];
    Modules = [];
    CurrentModule = "Admin-PAR";
    UploadAPI = appSetting.apiDomain('CUS/File/FileUpload');
    hasBaseDropZoneOver = false;
    File = "";
    FileSize = 0;
    Extension = "";
    FileName = "";
    ID = 0;
    CurrentFile = "";
    item = {
        Template: {
            MauTrinhBayPPT: ''
        }
    };
    uploader: FileUploader = new FileUploader({
        url: this.UploadAPI,
        authTokenHeader: "Authorization",
        authToken: this.commonService.getToken(),
        queueLimit: 1,
        allowedFileType: ['doc', 'xls', 'ppt', 'pdf', 'image', 'video']
    });
    constructor(
        public currentProvider: CAT_ThietLapTemplateProvider,
        private cdr: ChangeDetectorRef,
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
        super('page-thiet-lap-template', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.uploader.onBeforeUploadItem = (item) => {
            this.UploadAPI = appSetting.apiDomain('CUS/File/FileUpload/' + 0 + '?IDPartner=' + 1);
            item.url = this.UploadAPI;
        }
        this.uploader.onSuccessItem = (item, response, status: number, headers) => {
            if (status == 201 && response) {
                let data = JSON.parse(response);
                this.uploader.clearQueue();
                if (this.CurrentFile == "MauTrinhBayPPT") {
                    this.item.Template.MauTrinhBayPPT = data.Path;
                    this.toastMessage('Upload thành công, vui lòng nhấn "Lưu" để cập nhật!');
                }
            }
        }
    }

    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 3);
        this.Modules = this.getModules();
        super.preLoadData();
    }

    loadData() {
        this.currentProvider.get().then((result: any) => {
            this.item = result;
        });
    }

    saveCustom() {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.saveCustom(this.item).then((result: any) => {
                this.item = result;
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                this.toastMessage('Đã cập nhật!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        });
    }

    downloadMauTrinhBayPPT() {
        if (this.item.Template.MauTrinhBayPPT)
            this.download(this.item.Template.MauTrinhBayPPT);
        else this.toastMessage('Chưa có file, không thể tải!');
    }

    uploadMauTrinhBayPPT() {
        this.CurrentFile = "MauTrinhBayPPT";
        this.showActionMore = false;
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
    }

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
}
