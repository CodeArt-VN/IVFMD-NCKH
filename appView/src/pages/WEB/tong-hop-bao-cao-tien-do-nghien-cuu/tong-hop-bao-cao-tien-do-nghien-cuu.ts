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

@IonicPage({ name: 'page-tong-hop-bao-cao-tien-do-nghien-cuu', segment: 'tong-hop-bao-cao-tien-do-nghien-cuu', priority: 'high' }) 
@Component({ selector: 'page-tong-hop-bao-cao-tien-do-nghien-cuu', templateUrl: 'tong-hop-bao-cao-tien-do-nghien-cuu.html' })
export class TongHopBaoCaoTienDoNghienCuuPage extends ListPage {
    idDeTai: any;
    paramValue: any;
    model: any;
    FormGroups = [];
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
        this.query.StatusID = "-1";
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

    preLoadData() {
        //let a = TinyDatePicker('.c-date-picker1', {
        //    mode: 'dp-below',
        //    min: '1/1/2018',
        //    max: '31/12/2030',
        //    lang: this.lang,
        //    format(date) {
        //        //return date.toLocaleDateString();
        //        let m = moment(date, "DD/MM/YYYY");
        //        return m.format('DD/MM/YYYY');

        //    },
        //    parse(str) {
        //        let date = moment(str, "DD/MM/YYYY");

        //        if (date.isValid()) {
        //            return date.toDate();
        //        }
        //        else {
        //            return new Date();
        //        }

        //    },
        //})
        //    .on('select', (_, dp) => {
        //        let text = this.commonService.dateFormat(dp.state.selectedDate, 'yyyy-mm-dd');
        //        this.timeQuery.DateFrom = text;
        //    });

        //let b = TinyDatePicker('.c-date-picker2', {
        //    mode: 'dp-below',
        //    min: '1/1/2018',
        //    max: '31/12/2030',
        //    lang: this.lang,
        //    format(date) {
        //        //return date.toLocaleDateString();
        //        let m = moment(date, "DD/MM/YYYY");
        //        return m.format('DD/MM/YYYY');
        //    },
        //    parse(str) {
        //        let date = moment(str, "DD/MM/YYYY");

        //        if (date.isValid()) {
        //            return date.toDate();
        //        }
        //        else {
        //            return new Date();
        //        }
        //    },
        //})
        //    .on('select', (_, dp) => {
        //        let text = this.commonService.dateFormat(dp.state.selectedDate, 'yyyy-mm-dd');
        //        this.timeQuery.DateTo = text + ' 23:59:59';
        //    });


        //Promise.all([
        //    this.serviceRoleProvider.read(),
        //    this.branchesProvider.read(),
        //    this.bookingSourcesProvider.read(),
        //    this.bookingStatusProvider.read(),
        //    this.staffProvider.read({ Type: 4 }),// 1: BS hội chẩn; 2: BS mổ; 3: BS dự trù; 4 BS cộng tác
        //    this.staffProvider.read({ ChoPhepDatHen: true, SortBy: 'FirstName' }),
        //]).then(values => {
        //    this.serviceRoleList = values[0]['data'];
        //    this.branchList = values[1]['data'];
        //    this.sourceList = values[2]['data'];
        //    this.statusList = values[3]['data'];
        //    this.partnerList = values[4]['data'];
        //    this.staffList = values[5]['data'];
        //    super.preLoadData();
        //});

        this.statusList.forEach((i) => {
            i.Selected = true;
            if (i.ID == 45) i.Selected = false;
        });

        this.query.ListStatusID = this.statusList.filter(c => c.Selected == true).map(d => d.ID).join();
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 5);
        super.preLoadData();
    }

    filterByTime() {
        this.showDatePicks = false;
        this.query.DateFrom = this.timeQuery.DateFrom;
        this.query.DateTo = this.timeQuery.DateTo;
        debugger
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
        //let myModal = this.modalCtrl.create(TongHopBaoCaoTienDoNghienCuuModalPage, {
        //    'id': item.ID, 'idDeTai': item.IDDeTai
        //});
        //myModal.present();
    }
}
