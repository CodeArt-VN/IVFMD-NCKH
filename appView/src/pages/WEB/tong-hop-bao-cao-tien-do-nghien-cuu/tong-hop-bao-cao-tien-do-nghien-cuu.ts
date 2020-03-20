import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { PRO_BaoCaoTienDoNghienCuuCustomProvider } from '../../../providers/Services/CustomService';
import { TongHopBaoCaoTienDoNghienCuuModalPage } from '../tong-hop-bao-cao-tien-do-nghien-cuu-modal/tong-hop-bao-cao-tien-do-nghien-cuu-modal';
import * as moment from 'moment';
import TinyDatePicker from 'tiny-date-picker';
import { DateAdapter } from "@angular/material";
import { TienDoNghienCuuModalPage } from '../tien-do-nghien-cuu-modal/tien-do-nghien-cuu-modal';
@IonicPage({ name: 'page-tong-hop-bao-cao-tien-do-nghien-cuu', segment: 'tong-hop-bao-cao-tien-do-nghien-cuu', priority: 'high' }) 
@Component({ selector: 'page-tong-hop-bao-cao-tien-do-nghien-cuu', templateUrl: 'tong-hop-bao-cao-tien-do-nghien-cuu.html' })
export class TongHopBaoCaoTienDoNghienCuuPage extends ListPage {
    idDeTai: any;
    paramValue: any;
    model: any;
    FormGroups = [];
    Modules = [];
    CurrentModule = "NCKH-View";
    lstData = [];
    statusList = [
        { 'ID': 41, 'Code': 'TinhTrangNghienCuu_DangNhanMau', 'ValueOfVar': 'Đang nhận mẫu', 'Selected': false },
        { 'ID': 42, 'Code': 'TinhTrangNghienCuu_PhanTichSoLieu', 'ValueOfVar': 'Phân tích số liệu', 'Selected': false },
        { 'ID': 43, 'Code': 'TinhTrangNghienCuu_VietBaiDangBao', 'ValueOfVar': 'Viết bài đăng báo', 'Selected': false },
        { 'ID': 44, 'Code': 'TinhTrangNghienCuu_GuiBaiTapChi', 'ValueOfVar': 'Gửi bài tạp chí', 'Selected': false },
        { 'ID': 45, 'Code': 'TinhTrangNghienCuu_NghiemThu', 'ValueOfVar': 'Nghiệm thu', 'Selected': false },
    ];
    showDatePicks = false;
    showStatus = false;
    timeQuery: any = {
        DateFrom: null,
        DateTo: null,
    };
    lang = {
        months: ['Tháng 1', 'Tháng 2', 'Tháng 3', 'Tháng 4', 'Tháng 5', 'Tháng 6', 'Tháng 7', 'Tháng 8', 'Tháng 9', 'Tháng 10', 'Tháng 11', 'Tháng 12'],
        days: ['CN', 'T2', 'T3', 'T4', 'T5', 'T6', 'T7'],
        today: 'Hôm nay',
        clear: 'Xóa',
        close: 'Đóng',
    };
    constructor(
        public currentProvider: PRO_BaoCaoTienDoNghienCuuCustomProvider,

        public modalCtrl: ModalController,
        public navCtrl: NavController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
        private dateAdapter: DateAdapter<Date>
    ) {
        super('page-tong-hop-bao-cao-tien-do-nghien-cuu', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.query.ListStatusID = "";
        this.query.DateFrom = "";
        this.query.DateTo = "";
    }

    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.statusList.forEach((i) => {
            i.Selected = true;
            if (i.ID == 45) i.Selected = false;
        });

        this.query.ListStatusID = this.statusList.filter(c => c.Selected == true).map(d => d.ID).join();
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        this.Modules = this.getModules();
        super.preLoadData();
    }

    loadData() {
        this.gridConfig.page++;
        this.currentProvider.getTheoDeTai(this.query).then((result: any) => {
            this.lstData = [...result];
            this.lstData.forEach((i) => {
                i.LastReportDateText = this.commonService.dateFormat(i.LastReportDate, 'dd/mm/yy hh:MM');// tempDate.getDate() + '/' + (tempDate.getMonth() + 1.0) +'/' + tempDate.getFullYear();
            })
            this.lastKeyword = this.keyword;
            this.gridConfig.totalRows = result.length;
            this.loadedData();
        }).catch((data) => {
            this.lstData = [];
            this.lastKeyword = this.keyword;
            this.gridConfig.totalRows = 0;
            this.loadedData();
        });
    }

    getRandomIntInclusive(min, max) {
        min = Math.ceil(min);
        max = Math.floor(max);
        return Math.floor(Math.random() * (max - min + 1)) + min; //The maximum is inclusive and the minimum is inclusive 
    }

    filterByTime() {
        this.showDatePicks = false;
        this.query.DateFrom = this.timeQuery.DateFrom;
        this.query.DateTo = this.timeQuery.DateTo;
        this.loadData();
    }

    clearFilterByTime() {
        this.showDatePicks = false;
        this.query.DateFrom = '';
        this.query.DateTo = '';
        this.timeQuery.DateFrom = null;
        this.timeQuery.DateTo = null;
        this.loadData();
    }

    filterByStatus() {
        this.showStatus = false;
        this.query.ListStatusID = this.statusList.filter(c => c.Selected == true).map(d => d.ID).join();
        this.loadData();
    }

    clearFilterByStatus() {
        this.showStatus = false;
        this.query.ListStatusID = '';
        this.statusList.forEach((i) => {
            i.Selected = false;
        });
        this.loadData();
    }

    openDetail(item) {
        let myModal = this.modalCtrl.create(TienDoNghienCuuModalPage, { 'idDeTai': item.IDDeTai, 'isView': true });
        myModal.present(); 
    }
}
