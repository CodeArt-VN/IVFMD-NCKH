import { NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AccountServiceProvider } from '../providers/CORE/account-service';
import { CommonServiceProvider } from '../providers/CORE/common-service';
import { appSetting } from '../providers/CORE/api-list';
import { BasePage } from './base-page';

export class DetailPage extends BasePage {
    id: any;
    _uid: string;
    item: any;
    formGroup: FormGroup;
    submitAttempt: boolean = false;

    constructor(
        public pageName: string,
        public pageChildName: string,
        public currentProvider: any,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,

        public formBuilder: FormBuilder
    ) {
        super(pageName, pageChildName, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);

        this.id = navParams.get('id');
        if (this.id && commonService.isNumeric(this.id)) {
            this.id = parseInt(this.id, 10);
        }
        this._uid = navParams.get('_uid');
        this.item = navParams.get('item');
        if(!this.item){
            this.item = {}
        }
        this.formGroup = formBuilder.group({});
    }

    loadData() {
        if(this.id){
            this.currentProvider.getAnItem(this.id, this._uid).then((ite) => {
                this.commonService.copyPropertiesValue(ite, this.item);
                super.loadData();
            }).catch((data) => {
                this.item.ID = 0;
                super.loadData();
            });
        }
        else{
            this.item.ID = 0;
            super.loadData();
        }
    }

    loadedData() {
        this.formGroup.markAsPristine();
        super.loadedData();
    }

    saveChange() {
        this.showActionMore = false;
        this.submitAttempt = true;
        if (!this.formGroup.valid) {
            this.toastMessage('Vui lòng kiểm tra lại các thông tin được tô đỏ bên trên.');
        }
        else {
            this.loadingMessage('Lưu dữ liệu...').then(() => {
                this.currentProvider.save(this.item).then((savedItem: any) => {
                    this.id = savedItem.ID;
                    if (this.loading) this.loading.dismiss();
                    this.events.publish('app:Update' + this.pageName);
                    console.log('publish => app:Update ' + this.pageName);
                    this.loadData();
                    //this.goBack();
                    this.toastMessage('Đã lưu xong!');
                    this.savedChange();
                }).catch(err => {
                    console.log(err);
                    if (this.loading) this.loading.dismiss();
                    //this.toastMessage('Không lưu được, \nvui lòng thử lại.');
                    this.savedChange();
                });
            })
        }
    }

    savedChange(){
        this.formGroup.markAsPristine();
    }

    canDelete() {
        return true;
    }

    delete() {
        if (this.canDelete) {
            this.showActionMore = false;
            let confirm = this.alertCtrl.create({
                title: 'Xóa ' + (this.item.Code? ' '+this.item.Code : ''),
                message: 'Bạn chắc muốn xóa' + (this.item.Name? ' '+this.item.Name : '') + '?',
                buttons: [
                    {
                        text: 'Không',
                        role: 'cancel',
                        handler: () => {
                            console.log('Không xóa');
                        }
                    },
                    {
                        text: 'Đồng ý xóa',
                        cssClass: 'danger-btn',
                        handler: () => {
                            this.currentProvider.delete(this.item).then(() => {
                                this.toastMessage('Đã xóa xong!');
                                this.events.publish('app:Update' + this.pageName);
                                if(this.pageName.indexOf('-modal')){
                                    this.events.publish('app:Close-' + this.pageName);
                                }
                                else{
                                    this.goBack();
                                }
                                this.deleted();
                            }).catch(err => {
                                console.log(err);
                            })
                        }
                    }
                ]
            });
            confirm.present();
        }
    }

    deleted(){

    }

    refresh() {
        this.preLoadData();
    }

    cancel() {
        this.refresh();
    }

    setColor(color) {
        this.item.BackgroundColor = color;
        this.formGroup.markAsDirty();
    }

    download(url) {
        this.downloadURLContent(appSetting.mainService.base + url);
    }
}