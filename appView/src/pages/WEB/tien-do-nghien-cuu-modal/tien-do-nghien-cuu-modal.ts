import { Component, ViewChild } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { GlobalData } from '../../../providers/CORE/global-variable'
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DatatableComponent } from '@swimlane/ngx-datatable';
import { PRO_BaoCaoTienDoNghienCuuCustomProvider } from '../../../providers/Services/CustomService';
import { BaoCaoTienDoNghienCuuModalPage } from '../bao-cao-tien-do-nghien-cuu-modal/bao-cao-tien-do-nghien-cuu-modal';

import { DetailPage } from '../../detail-page';
import 'jqueryui';

@IonicPage({ name: 'page-tien-do-nghien-cuu-modal', priority: 'high', defaultHistory: ['page-tien-do-nghien-cuu'] })
@Component({
    selector: 'tien-do-nghien-cuu-modal',
    templateUrl: 'tien-do-nghien-cuu-modal.html',
})
export class TienDoNghienCuuModalPage extends DetailPage {
    idDeTai: any;
    paramValue: any;
    lstData: any[] = [];
    lstSelected: any[] = [];
    query: any = {};
    @ViewChild(DatatableComponent) table: DatatableComponent;

    constructor(
        public currentProvider: PRO_BaoCaoTienDoNghienCuuCustomProvider,
        public viewCtrl: ViewController,
        public modalCtrl: ModalController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {

        super(null, null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);   
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-tien-do-nghien-cuu-modal');
        this.events.subscribe('app:Close-page-tien-do-nghien-cuu-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
    }

    preLoadData() {
      this.currentProvider.getListCustom(this.idDeTai).then((result: any) => {
        this.lstData = [...result];
        this.lstData.forEach((i) => {
            i.NgayTaoText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
        });
        super.preLoadData();
      }).catch((data) => {
          this.lstData = [];
          super.preLoadData();
      });
    }

    loadedData() {
    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    refresh() {
        this.lstData = [];
        this.currentProvider.getListCustom(this.idDeTai).then((result: any) => {
          this.lstData = [...result];
          this.lstData.forEach((i) => {
              i.NgayTaoText = this.commonService.dateFormat(i.CreatedDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
          });
          super.preLoadData();
        }).catch((data) => {
            this.lstData = [];
            super.preLoadData();
        });
    }

    add() {
      let item1 = {
        ID: 0,
      };
      this.openDetail(item1);
        let item = {
            ID: 0
      };
    }

    delete() {
        this.showActionMore = false;
        var count = this.lstSelected.length;
        let title = 'Xóa ' + count + ' dòng';
        if (count == 1 && this.lstSelected[0].Name) {
            title = 'Xóa [' + this.lstSelected[0].Name + ']';
        }
        else if (count == 1) {
            title = 'Xóa bỏ';
        }

        let confirm = this.alertCtrl.create({
            title: title,
            message: 'Bạn chắc muốn xóa ' + (count == 1 ? '' : count + ' ') + 'dòng đang được chọn?',
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
                        debugger
                        var seletedItems = [...this.lstSelected];
                        var doneCount = 0;

                        for (var i = 0; i < seletedItems.length; i++) {
                            var ite = seletedItems[i];
                            this.currentProvider.delete(ite).then(data => {
                                doneCount++;
                                if (doneCount == count) {
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

    onSelect({ selected }) {
        this.lstSelected.splice(0, this.lstSelected.length);
        this.lstSelected.push(...selected);
    }
    openDetail(item) {
        let myModal = this.modalCtrl.create(BaoCaoTienDoNghienCuuModalPage, {
          'id': item.ID, 'idDeTai': this.idDeTai });
          
        myModal.onDidDismiss(data => {
          this.refresh();
        });
        myModal.present();
    }
}