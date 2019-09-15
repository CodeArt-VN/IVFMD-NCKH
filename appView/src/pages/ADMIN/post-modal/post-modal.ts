import { Component, ViewChild } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { WEB_BaiVietProvider, WEB_DanhMucProvider } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import { FileUploader } from 'ng2-file-upload';
import Quill from 'quill/dist/quill.min';
import { appSetting } from '../../../providers/CORE/api-list';


@IonicPage({ name: 'page-post-modal', priority: 'high', defaultHistory: ['page-post'] })
@Component({
    selector: 'post-modal',
    templateUrl: 'post-modal.html',
})
export class PostModalPage extends DetailPage {
    imageServer = appSetting.mainService.base;
    UploadAPI = appSetting.apiDomain('CUS/FILE/UploadImage');
    @ViewChild('importfile') importfile: any;

    quill: any = null;


    uploader: FileUploader = new FileUploader({
        url: this.UploadAPI,
        authTokenHeader: "Authorization",
        authToken: this.commonService.getToken(),
        queueLimit: 1,
        allowedFileType: ['image']
    });
    uploader2: FileUploader = new FileUploader({
        url: this.UploadAPI,
        authTokenHeader: "Authorization",
        authToken: this.commonService.getToken(),
        queueLimit: 1,
        allowedFileType: ['image']
    });

    hasBaseDropZoneOver = false;
    danhMucList: any[] = null;

    constructor(
        public currentProvider: WEB_BaiVietProvider,
        public danhMucProvider: WEB_DanhMucProvider,

        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-post";
        this.events.unsubscribe('app:Close-page-post-modal');
        this.events.subscribe('app:Close-page-post-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            IDDanhMuc: [''],
            Name: ['', Validators.compose([Validators.required])],
            Remark: [''],
            Sort: [''],
            NoiDung: [''],
            Home: [''],
            Pin: [''],
            HomePos: [''],
            PinPos: [''],
            ThumbnailImage: [''],
        });

        this.uploader.onSuccessItem = (item, response, status: number, headers) => {
            if (status == 201 && response) {
                let data = JSON.parse(response);
                this.uploader.clearQueue();
                if (data.Image) {
                    this.item.ThumbnailImage = data.Image;
                }
            }
        }
        this.uploader2.onSuccessItem = (item, response, status: number, headers) => {
            if (status == 201 && response) {
                let data = JSON.parse(response);
                this.uploader2.clearQueue();
                if (data.Image) {
                    this.item.AlternateImage = data.Image;
                }
            }
        }
    }

    fileOverBase(e: any): void {
        this.hasBaseDropZoneOver = e;
    }
    onFileSelected() {
        setTimeout(() => {
            if (this.uploader.queue.length) {
                this.uploader.uploadAll();
            }
        }, 0);
    }
    onFileSelected2() {
        setTimeout(() => {
            if (this.uploader2.queue.length) {
                this.uploader2.uploadAll();
            }
        }, 0);
    }



    preLoadData() {
        Promise.all([
            this.danhMucProvider.read()
        ]).then(values => {
            this.danhMucList = values[0]['data'];
            super.preLoadData();
        });
    }

    loadedData() {
        if (!this.item.IDPartner) {
            this.item.IDPartner = this.navParams.data.IDPartner;
        }

        this.item.HasAlternateImage = this.item.AlternateImage ? true : false;

        setTimeout(() => {
            if (!this.quill) {
                this.quill = new Quill('#editor', {
                    modules: {
                        'toolbar': [
                            [{ 'size': [] }],
                            ['bold', 'italic', 'underline', 'strike', { 'script': 'super' }, { 'script': 'sub' }],

                            [{ 'background': [] }, { 'color': [] }],

                            [{ 'align': '' }, { 'align': 'center' }, { 'align': 'right' }, { 'align': 'justify' }],

                            [{ 'header': '1' }, { 'header': '2' }, 'blockquote'],
                            [{ 'list': 'ordered' }, { 'list': 'bullet' }, { 'indent': '-1' }, { 'indent': '+1' }],

                            ['link', 'image', 'video', 'formula'],
                            //https://github.com/quilljs/quill/issues/863#issuecomment-240579430
                            ['clean', 'showHtml']
                        ],
                        clipboard: {
                            matchVisual: false
                        },
                    },
                    
                    placeholder: 'Nhập nội dung bài viết...',
                    theme: 'snow'
                });

                let that = this;

                var txtArea = document.createElement('textarea');
                txtArea.style.cssText = "width: 100%;margin: 0px;background: rgb(29, 29, 29);box-sizing: border-box;color: rgb(204, 204, 204);font-size: 15px;outline: none;padding: 20px;line-height: 24px;font-family: Consolas, Menlo, Monaco, &quot;Courier New&quot;, monospace;position: absolute;top: 0;bottom: 0;border: none;display:none"

                var htmlEditor = this.quill.addContainer('ql-custom')
                htmlEditor.appendChild(txtArea)

                var myEditor = document.querySelector('#editor')
                this.quill.on('text-change', (delta, oldDelta, source) => {
                    var html = myEditor.children[0].innerHTML;
                    txtArea.value = html;
                })

                var customButton = document.querySelector('.ql-showHtml');
                customButton.addEventListener('click', function () {
                    if (txtArea.style.display === '') {
                        var html = txtArea.value;
                        //that.quill.pasteHTML(html);
                        that.quill.clipboard.dangerouslyPasteHTML(html);
                    }
                    txtArea.style.display = txtArea.style.display === 'none' ? '' : 'none';
                });

                this.quill.root.spellcheck = false;


                this.quill.on('editor-change', function (eventName, ...args) {
                    if (eventName === 'text-change') {
                        that.item.NoiDung = that.quill.container.firstChild.innerHTML;
                        that.formGroup.controls['NoiDung'].markAsDirty();
                    } else if (eventName === 'selection-change') {
                        // args[0] will be old range
                    }
                });
            }

            if (this.item && this.item.NoiDung) {
                //this.quill.pasteHTML(this.item.NoiDung);
                this.quill.clipboard.dangerouslyPasteHTML(this.item.NoiDung);
            }


        }, 0)
    }

    saveChange() {
        this.item.NoiDung = this.quill.container.firstChild.innerHTML;
        super.saveChange();
    }

    selectFile() {
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
        setTimeout(() => {
            if (this.uploader.queue.length) {
                this.uploader.uploadAll();
            }
        }, 0);
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}