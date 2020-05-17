import { Component, ViewChild } from '@angular/core';
import { ViewController, ModalController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_HoSoKhacCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import { GlobalData } from '../../../providers/CORE/global-variable'
import 'jqueryui';
import { appSetting } from '../../../providers/CORE/api-list';
import { FileUploader, FileDropDirective, FileSelectDirective } from 'ng2-file-upload';

@IonicPage({ name: 'page-ho-so-khac-modal', priority: 'high', defaultHistory: ['ho-so-khac-modal'] })
@Component({
    selector: 'ho-so-khac-modal',
    templateUrl: 'ho-so-khac-modal.html',
})
export class HoSoKhacModalPage extends DetailPage {
    idDeTai: any;
    IDFile: any;
    selected: any[] = [];
    lstRow: any[] = [];
    @ViewChild('importfile') importfile: any;
    UploadAPI = appSetting.apiDomain('CUS/File/FileUpload');
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
        public currentProvider: PRO_HoSoKhacCustomProvider,
        public modalCtrl: ModalController,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
        this.pageName = "page-ho-so-khac-modal";

        this.uploader.onBeforeUploadItem = (item) => {
            this.UploadAPI = appSetting.apiDomain('CUS/File/FileUpload/' + 0 + '?IDPartner=' + 1);
            item.url = this.UploadAPI;
        }
        this.uploader.onSuccessItem = (item, response, status: number, headers) => {
            if (status == 201 && response) {
                let data = JSON.parse(response);
                this.uploader.clearQueue();
                if (this.CurrentFile == "FileUpload") {
                    this.uploadFileUpload(data.ID);
                }
            }
        }
    }
    preLoadData() {
        this.reloadData();
    }

    reloadData() {
        this.currentProvider.getListCustom(this.idDeTai).then((result: any) => {
            this.lstRow = [...result];
            this.lstRow.forEach((i) => {
                i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
            })
        });
    }

    uploadFile() {
        this.IDFile = 0;
        this.CurrentFile = "FileUpload";
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

    uploadFileUpload(IDFile) {
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.save({ ID: 0, IDDeTai: this.idDeTai, IDFile: IDFile}).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Đã cập nhật!');
                this.reloadData();
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
            });
        })
    }

    onSelect({ selected }) {
        this.selected.splice(0, this.selected.length);
        this.selected.push(...selected);
    }

    donwloadFile(item) {
        if (item.Path)
            this.download(item.Path);
        else this.toastMessage('Chưa up file, không thể down!');
    }

    deleteFile(item) { 
        let confirm = this.alertCtrl.create({
            title: "Xác nhận",
            message: 'Bạn có chắc muốn xóa file này??',
            buttons: [
                {
                    text: 'Thoát',
                    handler: () => {
                    }
                },
                {
                    text: 'Đồng ý',
                    handler: () => {
                        this.loadingMessage('Lưu dữ liệu...').then(() => {
                            this.currentProvider.delete(item).then((savedItem: any) => {
                                if (this.loading) this.loading.dismiss();
                                this.reloadData();
                                this.toastMessage('Đã cập nhật!');
                            }).catch(err => {
                                console.log(err);
                                if (this.loading) this.loading.dismiss();
                            });
                        })
                    }
                }
            ]
        });
        confirm.present();
    }

    loadData() {
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}