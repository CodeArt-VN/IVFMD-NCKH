import { Component, ViewChild, ChangeDetectorRef } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { DOC_FileProvider, DOC_FolderProvider } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import { FileUploader } from 'ng2-file-upload';
import { appSetting } from '../../../providers/CORE/api-list';


@IonicPage({ name: 'page-file-modal', priority: 'high', defaultHistory: ['page-folder'] })
@Component({
    selector: 'file-modal',
    templateUrl: 'file-modal.html',
})
export class FileModalPage extends DetailPage {
    UploadAPI = appSetting.apiDomain('CUS/DOC/File/FileUpload');
    @ViewChild('importfile') importfile: any;
    folderList: any = [];
    folderTree: any = [];
    hasBaseDropZoneOver = false;
    canApproveDoc = false;

    uploader: FileUploader = new FileUploader({
        url: this.UploadAPI,
        authTokenHeader: "Authorization",
        authToken: this.commonService.getToken(),
        queueLimit: 1,
        //allowedMimeType: ['application/pdf', 'image/*'],
        allowedFileType: ['doc', 'xls', 'ppt', 'pdf', 'image', 'video'] //application image video audio pdf compress doc xls ppt
    });
 


    constructor(
        public currentProvider: DOC_FileProvider,
        public folderProvider: DOC_FolderProvider,
        public viewCtrl: ViewController,
        private cdr: ChangeDetectorRef,

        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super('page-file-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.events.unsubscribe('app:Close-page-file-modal');
        this.events.subscribe('app:Close-page-file-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            File: ['', Validators.compose([Validators.required])],
            IDFolder: [''],
            Code: [''],
            Name: ['', Validators.compose([Validators.required])],
            Remark: [''],
            Sort: [''],
            FileVersion: [''],
        });

        this.uploader.onBeforeUploadItem = (item) => {
            this.UploadAPI = appSetting.apiDomain('CUS/DOC/File/FileUpload/' + this.item.ID + '?IDPartner=' + this.navParams.data.IDPartner);
            item.url = this.UploadAPI;
        }
        this.uploader.onSuccessItem = (item, response, status: number, headers) => {
            if (status == 201 && response) {
                let data = JSON.parse(response);
                this.uploader.clearQueue();
                if (data.ID && (this.item.ID = data.ID || this.item.ID == 0)) {
                    this.id = data.ID;
                    this.item.ID = data.ID;
                    this.item.Path = data.Path;
                    this.item.Code = data.Code;
                    this.item.Extension = data.Extension;
                    this.item.FileSize = data.FileSize;
                    this.cdr.detectChanges();

                    this.saveChange();
                }

            }
        }
    } 

    preLoadData() {
        Promise.all([
            this.folderProvider.read()
        ])
            .then(values => {
                this.folderList = values[0]['data'];
                this.folderTree = [];
                this.buildTree(null);
                super.preLoadData();
            })
    }

    loadedData() {
        if (this.navParams.data.canApproveDoc) {
            this.canApproveDoc = this.navParams.data.canApproveDoc;
        }

        if (!this.item.IDPartner) {
            this.item.IDPartner = this.navParams.data.IDPartner;
        }
        if (this.item.Code) {
            this.item.File = "Đã lưu file.";
        }
        this.item.oldIDFolder = this.item.IDFolder;
    }


    // event

    fileOverBase(e: any): void {
        this.hasBaseDropZoneOver = e;
    }
    onFileSelected() {
        this.item.File = this.uploader.queue[0].file.name;
        this.item.FileSize = this.uploader.queue[0].file.size;
        this.item.Extension = this.uploader.queue[0].file.name.split('.').pop();
        if (!this.item.Name)
            this.item.Name = this.uploader.queue[0].file.name;

        this.formGroup.controls['File'].markAsDirty();
        this.cdr.detectChanges();
    }

    selectFile() {
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
    }

    dismiss() {
        this.viewCtrl.dismiss();
    }

    buildTree(item) {
        let idp = item == null ? null : item.ID;
        let childrent = this.folderList.filter(d => d.IDParent == idp ); //&& d.IDLinhVuc == null
        let level = (item && item.level >= 0) ? item.level + 1 : 1;

        let index = this.folderTree.findIndex(d => d.ID == idp)
        this.folderTree.splice(index + 1, 0, ...childrent);

        childrent.forEach(i => {
            i.levels = Array(level).fill('');
            i.level = level;
            this.buildTree(i);
        });
    }

    upLoadThenSave() {
        if (this.uploader.queue.length) {
            this.uploader.uploadAll();
        }
        else {
            this.saveChange();
        }
    }

    savedChange() {
        this.events.publish('app:page-sops-ReloadFileInfo', this.item);
        super.savedChange();
    }
}