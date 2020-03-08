import { Component, ViewChild } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { PRO_HoiNghiHoiThaoDangKyCustomProvider } from '../../../providers/Services/CustomService';
import { PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DateAdapter } from "@angular/material";
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import { appSetting } from '../../../providers/CORE/api-list';
import { FileUploader, FileDropDirective, FileSelectDirective } from 'ng2-file-upload';
import { HoiNghiHoiThaoDangKyDeTaiChiTietModalPage } from '../hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal/hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal';

@IonicPage({ name: 'page-hoi-nghi-hoi-thao-dang-ky-de-tai-modal', priority: 'high', defaultHistory: ['page-hoi-nghi-hoi-thao'] })
@Component({
    selector: 'hoi-nghi-hoi-thao-dang-ky-de-tai-modal',
    templateUrl: 'hoi-nghi-hoi-thao-dang-ky-de-tai-modal.html',
})
export class HoiNghiHoiThaoDangKyDeTaiModalPage extends DetailPage {
    lstRow: any[] = [];
    selected: any[] = [];
    idDangKy: any;
    itemData: any;
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
        public currentProvider: PRO_HoiNghiHoiThaoDangKyCustomProvider,
        public currentDeTaiProvider: PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {

        super('page-hoi-nghi-hoi-thao', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-hoi-nghi-hoi-thao";
        this.events.unsubscribe('app:Close-hoi-nghi-hoi-thao-dang-ky-de-tai-modal');
        this.events.subscribe('app:Close-hoi-nghi-hoi-thao-dang-ky-de-tai-modal', () => {
            this.dismiss();
        });
        this.idDangKy = navParams.get('idDangKy');
        this.itemData = navParams.get('itemData');
        if (this.idDangKy && commonService.isNumeric(this.idDangKy)) {
            this.idDangKy = parseInt(this.idDangKy, 10);
        }

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

    preLoadData() {
        this.reloadData();
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
            this.currentDeTaiProvider.uploadAbstract({ ID: this.ID, BaiAbstract: path }).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Đã cập nhật!');
                this.reloadData(); 
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
            this.currentDeTaiProvider.uploadFullText({ ID: this.ID, BaiFulltext: path }).then((savedItem: any) => {
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Đã cập nhật!');
                this.reloadData();
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
            });
        })
    }

    add() {
        if (this.itemData != null) {
            if (this.itemData.CoTheDangKy) {
                let myModal = this.modalCtrl.create(HoiNghiHoiThaoDangKyDeTaiChiTietModalPage, { 'idDangKy': this.idDangKy, 'id': 0 });
                myModal.present();
            } else this.toastMessage('Đã hết hạn đăng ký đề tài!');
        }
    }

    onSelect({ selected }) {
        this.selected.splice(0, this.selected.length);
        this.selected.push(...selected);
    }

    delete() {
        let confirm = this.alertCtrl.create({
            title: "Xác nhận xóa",
            message: 'Bạn chắc muốn xóa dòng đang được chọn?',
            buttons: [
                {
                    text: 'Không xóa',
                    handler: () => {
                        console.log('Không xóa');
                    }
                },
                {
                    text: 'Đồng ý xóa',
                    handler: () => {
                        var seletedItems = [...this.selected];
                        var doneCount = 0;

                        for (var i = 0; i < seletedItems.length; i++) {
                            var ite = seletedItems[i];
                            this.currentDeTaiProvider.delete(ite).then(data => {
                                doneCount++;
                                if (doneCount == 1) {
                                    let toast = this.toastCtrl.create({
                                        message: 'Đã xóa ' + doneCount + ' dòng.',
                                        duration: GlobalData.UserData.Setting.ToastMessageDelay
                                    });
                                    toast.present();
                                    this.refresh();
                                }
                            });
                        }
                    }
                }
            ]
        });
        confirm.present();
    }

    action(actionCode) {
        let confirm = this.alertCtrl.create({
            title: "Xác nhận gửi duyệt",
            message: 'Bạn chắc muốn gửi duyệt đề tài đang được chọn?',
            buttons: [
                {
                    text: 'Không gửi',
                    handler: () => {
                    }
                },
                {
                    text: 'Đồng ý',
                    handler: () => {
                        var seletedItems = [...this.selected];
                        for (var i = 0; i < seletedItems.length; i++) {
                            var ite = seletedItems[i];
                            this.loadingMessage('Lưu dữ liệu...').then(() => {
                                this.currentDeTaiProvider.updateStatus(ite.ID, actionCode).then((savedItem: any) => {
                                    if (this.loading) this.loading.dismiss();
                                    this.toastMessage('Đã gửi duyệt!');
                                    this.reloadData();
                                }).catch(err => {
                                    console.log(err);
                                    if (this.loading) this.loading.dismiss();
                                    //this.toastMessage('Không cập nhật được, \nvui lòng thử lại.');
                                });
                            })
                        }
                    }
                }
            ]
        });
        confirm.present();
    }

    loadData() {
    }

    loadedData() {
        this.reloadData();
    }

    reloadData() {
        this.currentProvider.getListDeTaiByDangKy(this.idDangKy).then((result: any) => {
            this.lstRow = [...result];
            this.lstRow.forEach((i) => {
                i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');
                i.ModifiedDateText = this.commonService.dateFormat(i.ModifiedDate, 'dd/mm/yy hh:MM');
            })
        });
    }

    openDetailDeTai(item) {
        let myModal = this.modalCtrl.create(HoiNghiHoiThaoDangKyDeTaiChiTietModalPage, { 'idDangKy': this.idDangKy, 'id': item.ID });
        myModal.present();
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}