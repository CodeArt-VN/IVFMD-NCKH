import { Component, ChangeDetectorRef } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PAR_PartnerProvider, } from '../../../providers/Services/Services';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import Quill from 'quill/dist/quill.min';

@IonicPage({ name: 'page-partner-modal', priority: 'high', defaultHistory: ['page-partner'] })
@Component({
    selector: 'partner-modal',
    templateUrl: 'partner-modal.html',
})
export class PartnerModalPage extends DetailPage {
    quill: any = null;
    constructor(
        public currentProvider: PAR_PartnerProvider,
        private cdr: ChangeDetectorRef,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-partner";
        this.events.unsubscribe('app:Close-page-partner-modal');
        this.events.subscribe('app:Close-page-partner-modal', () => {
            this.dismiss();
        });
        this.formGroup = formBuilder.group({
            Code: ['', Validators.compose([Validators.required])],
            Name: ['', Validators.compose([Validators.required])],
            Remark: [''],
            LogoURL: ['', Validators.compose([Validators.required])],
        });
    }
    loadedData() {
        if (!this.item.IDPartner) {
            this.item.IDPartner = this.navParams.data.IDPartner;
        }

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
                        that.item.Remark = that.quill.container.firstChild.innerHTML;
                        that.formGroup.controls['Remark'].markAsDirty();
                    } else if (eventName === 'selection-change') {
                        // args[0] will be old range
                    }
                });
            }

            if (this.item && this.item.Remark) {
                //this.quill.pasteHTML(this.item.Remark);
                this.quill.clipboard.dangerouslyPasteHTML(this.item.Remark);
            }


        }, 0)
    }
    saveChange() {
        this.item.Remark = this.quill.container.firstChild.innerHTML;
        super.saveChange();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }
}