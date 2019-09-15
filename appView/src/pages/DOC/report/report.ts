import { Component, ViewChild, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController, PopoverController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { DOC_FolderProvider } from '../../../providers/Services/Services';
import { GlobalData } from '../../../providers/CORE/global-variable';

import { ManualProvider } from '../../../providers/Services/CustomService';
import { Chart } from 'chart.js';

@IonicPage({ name: 'page-report', segment: 'report', priority: 'high' })
@Component({ selector: 'page-report', templateUrl: 'report.html' })
export class ReportPage extends ListPage {
    folderList: any[] = [];
    folderTree: any[] = [];
    folderTreeState: any[] = [];
    isNeedToReloadTree = true;
    tabIndex = 0;
    showInfo = false;

    folderid: null;

    canManageFolder = false;
    canManageFile = false;
    canApproveDoc = false;
    canViewReport = false;
    canViewTeam = false;
    canViewSops = false;


    doughnutChart: any;
    doughnutData:any[] = [];

    constructor(
        public folderProvider: DOC_FolderProvider,
        public currentProvider: ManualProvider,

        public popoverCtrl: PopoverController,
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
        super('page-report', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }

    preLoadData() {

        this.folderid = null;
        this.selected = [];
        this.showInfo = false;

        this.canManageFolder = this.isUserCanUse('page-folder-modal');
        this.canManageFile = this.isUserCanUse('page-file-modal');
        this.canApproveDoc = this.isUserCanUse('page-report');
        this.canViewReport = this.isUserCanUse('page-report');
        this.canViewTeam = this.isUserCanUse('page-team');
        this.canViewSops = this.isUserCanUse('page-report');

        super.preLoadData();


    }

    loadData() {
        //init left tree
        this.preBuildTree().then(() => {
            this.currentProvider.GetRTPFileInFolder(this.query).then((result: any) => {

                this.folderTree.forEach(i => {
                    let info = result.find(d => d.ID == i.ID);
                    if (info) {
                        i.TongSoFile = info.CountFile ? info.CountFile : '-';
                        i.SoFileDaDuyet = info.CountApproved ? info.CountApproved : '-';
                        i.SoFileChoDuyet = info.CountWaitApprove  ? info.CountWaitApprove : '-';
                        i.SoFileNhap = (info.CountFile - info.CountApproved - info.CountWaitApprove) ? (info.CountFile - info.CountApproved - info.CountWaitApprove) : '-';
                    }
                    else {
                        i.TongSoFile = '-';
                        i.SoFileDaDuyet = '-';
                        i.SoFileChoDuyet = '-';
                        i.SoFileNhap = '-';
                    }

                });
                this.loadedData();
            });
        });
    }

    loadedData() {
        this.items = [...this.folderTree];
        super.loadedData();

    }

    buildChart() {
        let doughnutCanvas = document.getElementById('doughnutCanvas');
        if (doughnutCanvas) {


            this.currentProvider.GetRPTFileByType(this.query).then((result: any) => {
                if (result.length) {
                    result.forEach((i) => {

                        if (i.Extension == 'pdf' || i.Extension == 'pdf') {
                            i.BackgroundColor = '#E15141';
                            i.FileTypeIcon = 'fa-file-pdf-o';
                        }
                        else if (i.Extension == 'doc' || i.Extension == 'docx') {
                            i.BackgroundColor = '#5688EE';
                            i.FileTypeIcon = 'fa-file-word-o';
                        }
                        else if (i.Extension == 'xlsx' || i.Extension == 'xls') {
                            i.BackgroundColor = '#4DA26A';
                            i.FileTypeIcon = 'fa-file-excel-o';
                        }
                        else if (i.Extension == 'ppt' || i.Extension == 'pptx') {
                            i.BackgroundColor = '#C45032';
                            i.FileTypeIcon = 'fa-file-powerpoint-o';
                        }
                        else if (i.Extension == 'jpg' || i.Extension == 'png' || i.Extension == 'jpeg') {
                            i.BackgroundColor = '#2C78CF';
                            i.FileTypeIcon = 'fa-image';
                        }
                        else if (i.Extension == 'mp4' || i.Extension == 'mkv' || i.Extension == 'flv' || i.Extension == 'avi' || i.Extension == 'mov' || i.Extension == 'wmv' || i.Extension == '3gp') {
                            i.BackgroundColor = '#AD2F4D';
                            i.FileTypeIcon = 'fa-file-video-o';
                        }

                        else {
                            i.BackgroundColor = '#007DC5';
                            i.FileTypeIcon = 'ios-document';
                        }



                        i.backgroundColorRgba = this.commonService.hexToRgba(i.BackgroundColor, 1);
                    });
                    this.doughnutData = result;


                    let that = this;
                    setTimeout(() => {
                        if (that.doughnutChart) {
                            that.doughnutChart.data = {
                                labels: result.map(p => p.Extension),
                                datasets: [{
                                    data: result.map(p => p.CountFile),
                                    backgroundColor: result.map(p => p.backgroundColorRgba),
                                    borderColor: result.map(p => p.BackgroundColor),
                                    borderWidth: 1
                                }]
                            };
                            that.doughnutChart.update();
                        }
                        else {

                            that.doughnutChart = new Chart(doughnutCanvas, {
                                type: 'doughnut',
                                data: {
                                    labels: result.map(p => p.Extension),
                                    datasets: [{
                                        data: result.map(p => p.CountFile),
                                        backgroundColor: result.map(p => p.backgroundColorRgba),
                                        borderColor: result.map(p => p.BackgroundColor),
                                        borderWidth: 1
                                    }]
                                },
                                options: {
                                    legend: {
                                        position: 'bottom'
                                    },
                                    responsive: true,
                                    maintainAspectRatio: false,
                                }

                            });
                        }
                    }, 0);
                }
                else {
                    this.doughnutChart = null;
                }
            });

        }
    }


    //event
    changePartner() {
        let partner = this.userprofile.Partners.find(d => d.ID == this.query.IDPartner)
        if (partner) {
            this.userprofile.Partner = partner;
        }
        GlobalData.Filter.IDPartner = this.query.IDPartner;
        this.preLoadData();
    }

    //table
    onSelect({ selected }) {

    }

    //tool

    showHideInfo() {
        this.showInfo = !this.showInfo;

        setTimeout(() => {
            window.dispatchEvent(new Event('resize'));
            if (this.showInfo) {
                this.buildChart();
            }
            else {
                this.doughnutChart = null;
            }
        }, 0);
    }

    avatarLoadError(item) {
        item.Avatar = 'assets/imgs/avartar-empty.jpg';
    }

    //method
    preBuildTree() {

        return new Promise(resolve => {
            Promise.all([
                this.folderProvider.read()
            ])
                .then(values => {
                    this.isNeedToReloadTree = false;
                    this.folderList = values[0]['data'];
                    this.folderTree = [{ ID: null, Name: 'Root' }];

                    this.buildTree(null);
                    resolve(true);
                });
        });
    }

    buildTree(item) {
        let idp = item == null ? null : item.ID;
        let childrent = this.folderList.filter(d => d.IDParent == idp);
        let level = (item && item.level >= 0) ? item.level + 1 : 1;

        if (item)
            item.count = childrent.length;

        let index = this.folderTree.findIndex(d => d.ID == idp)
        this.folderTree.splice(index + 1, 0, ...childrent);

        childrent.forEach(i => {
            i.levels = Array(level).fill('');
            i.level = level;
            i.show = item == null ? true : false;
            i.showdetail = false;
            this.buildTree(i);
        });
    }

    isUserCanUse(functionCode) {
        let menus = GlobalData.Profile.MenuItems;
        let sopGroup = menus.find(d => d.Code == 'SOPs');
        if (sopGroup) {
            return sopGroup.Forms.findIndex(d => d.Code == functionCode) > -1;
        }
        return false;
    }

}