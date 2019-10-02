import { ViewChild } from '@angular/core';
import { NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { GlobalData, APIList } from '../providers/CORE/global-variable'
import { AccountServiceProvider } from '../providers/CORE/account-service';
import { CommonServiceProvider } from '../providers/CORE/common-service';
import { appSetting } from '../providers/CORE/api-list';
import { BasePage } from './base-page';

export class ListPage extends BasePage {
    @ViewChild('importfile') importfile: any;
    items: any[] = [];
    selected: any[] = [];
    keyword = '';
    lastKeyword = '';

    gridConfig = {
        isInfiniteScrool: false,
        reorderable: true,
        page: 0,
        pageSize: 0,
        totalRows: 0,
        showCheck: false,
    }

    query: any = {};

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
        public accountService: AccountServiceProvider
    ) {
        super(pageName, pageChildName, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
    }

    preLoadData(){
        // if (GlobalData.Filter.IDPartner) {
        //     this.query.IDPartner = GlobalData.Filter.IDPartner;
        // } else {
            
        //     GlobalData.Filter.IDPartner = this.query.IDPartner = this.userprofile.Partners[0].ID;
        // }

        // let partner = this.userprofile.Partners.find(d => d.ID == this.query.IDPartner)
        // if (partner) {
        //     this.userprofile.Partner = partner;
        // }

        super.preLoadData();
    }

    loadData() {
        this.gridConfig.page++;
        this.currentProvider.read(this.query).then((result: any) => {
            this.items = [...result.data]; 
            this.lastKeyword = this.keyword;
            this.gridConfig.totalRows = result.count;
            super.loadData();
        });
    }

    selectAll() {
        let checked = false;
        if (this.items.length) {
            checked = this.items[0]._isChecked;
            this.items.forEach(ite => {
                ite._isChecked = !checked;
            });
        }
    }

    countCheckedItems() {
        return this.selected.length;
    }

    openDetailPage(item) {
        this.navCtrl.push(this.pageChildName, {
            id: item.ID,
            _uid: item._uid
        });
        return false;

    }

    search(ev) {
        var val = ev.target.value;
        if (val == undefined) {
            val = '';
        }
        if (val.length > 2 || val == '') {
            this.keyword = val;
            this.query.Keywork = this.keyword;
            this.gridConfig.page = 0;
            this.loadData();
        }

    }

    changePartner() {
        let partner = this.userprofile.Partners.find(d => d.ID == this.query.IDPartner)
        if (partner) {
            this.userprofile.Partner = partner;
        }
        GlobalData.Filter.IDPartner = this.query.IDPartner;
        this.refresh();
    }

    refresh() {
        this.gridConfig.page = 0;
        this.showActionMore = false;
        this.selected = [];
        this.loadData();
    }

    add() {
        this.showActionMore = false;
        this.navCtrl.push(this.pageChildName, { id: 0, _uid: '' });
        this.scrollToBottom();
    }

    copy() {
        this.showActionMore = false;
        var seletedItems = [...this.selected]
        for (var i = 0; i < seletedItems.length; i++) {
            var ite = seletedItems[i];
            var item = {};
            this.commonService.copyPropertiesValue(ite, item);
            item['ID'] = 0;
            item['Code'] += '-copy';
            item['Name'] += ' copy';
            item['Email'] += '.copy';
            this.currentProvider.save(item).then(data => {
                this.items.push(data);
                this.items = [...this.items];
                this.scrollToBottom();
            });
        }
    }

    delete() {
        this.showActionMore = false;
        var count = this.countCheckedItems();
        let title = 'Xóa ' + count + ' dòng';
        if (count == 1 && this.selected[0].Name) {
            title = 'Xóa [' + this.selected[0].Name + ']';
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
                        var seletedItems = [...this.selected];
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

    import() {
        this.showActionMore = false;
        this.importfile.nativeElement.value = "";
        this.importfile.nativeElement.click();
    }

    onImportFileChange(event) {
        if (event.target.files.length == 0)
            return;
        this.loadingMessage("Vui lòng chờ import dữ liệu");
        let apiPath = this.getAPIPathByPageName(this.pageName);
        this.commonService.upload(apiPath, event.target.files[0]).then((response) => {
            this.refresh();
            if (this.loading) this.loading.dismiss();
        })
            .catch(err => {
                if (err.statusText == "Conflict") {
                    // var contentDispositionHeader = err.headers.get('Content-Disposition');
                    // var result = contentDispositionHeader.split(';')[1].trim().split('=')[1];
                    // this.downloadContent(result.replace(/"/g, ''),err._body);
                    this.downloadURLContent(appSetting.mainService.base + err._body);
                }
                //console.log(err);
                if (this.loading) this.loading.dismiss();
            })
    }

    export() {
        this.showActionMore = false;
        let apiPath = this.getAPIPathByPageName(this.pageName);
        this.commonService.download(apiPath, this.query).then((response: any) => {
            // var contentDispositionHeader = response.headers.get('Content-Disposition');
            // var name = contentDispositionHeader.split(';')[1].trim().split('=')[1];
            this.downloadURLContent(appSetting.mainService.base + response._body);
        }).catch(err => {

        })
    }

    download(url){
         this.downloadURLContent( appSetting.mainService.base + url);
    }

    private getAPIPathByPageName(pageName) {
        let apiPath = null;
        if (this.pageName == 'page-staff') {
            apiPath = APIList.FILE_Import.NhanSu;
        }
        else if (this.pageName == 'page-doanh-thu-tong') {
            apiPath = APIList.ReportAPI.downloadDoanhThuTong;
        }
        else if (this.pageName == 'page-doanh-thu-khach-hang') {
            apiPath = APIList.ReportAPI.downloadDoanhThuTheoKhachTongHop;
        }
        else if (this.pageName == 'page-gio-hoat-dong') {
            apiPath = APIList.ReportAPI.downloadTongHopGioHoatDong;
        }
        else if (this.pageName == 'page-bang-ke-thu-chi') {
            apiPath = APIList.ReportAPI.downloadBangKeThuChi;
        }
        else if (this.pageName == 'page-chi-phi-nhan-vien') {
            apiPath = APIList.ReportAPI.downloadBangKeChiPhiTheoNhanVien;
        }
        else if (this.pageName == 'page-chi-phi-theo-loai') {
            apiPath = APIList.ReportAPI.downloadBaoCaoChiPhiTheoLoai;
        }
        else if (this.pageName == 'page-tong-hop-ngay-cong') {
            apiPath = APIList.ReportAPI.downloadBaoCaoNgayCong;
        }

        else if (this.pageName == 'page-khach-hang') {
            apiPath = APIList.FILE_Import.KhachHang;
        }
        else if (this.pageName == 'page-phuong-tien') {
            apiPath = APIList.FILE_Import.PhuongTien;
        }
        else if (this.pageName == 'page-nhan-su') {
            apiPath = APIList.FILE_Import.NhanSu;
        }
        else if (this.pageName == 'page-tinh-thanh') {
            apiPath = APIList.FILE_Import.TinhThanh;
        }
        else if (this.pageName == 'page-quan-huyen') {
            apiPath = APIList.FILE_Import.QuanHuyen;
        }
        else if (this.pageName == 'page-bang-gia') {
            apiPath = APIList.FILE_Import.BangGiaChung;
        }
        else if (this.pageName == 'page-hop-dong-chi-tiet') {
            apiPath = APIList.FILE_Import.BangGiaTheoKhach;
        }




        return apiPath;
    }

    private downloadContent(name, data) {
        var pom = document.createElement('a');
        pom.setAttribute('href', 'data:text/plain;charset=utf-8,' + encodeURIComponent(data));
        pom.setAttribute('download', name);
        pom.style.display = 'none';
        document.body.appendChild(pom);
        pom.click();
        document.body.removeChild(pom);
    }

    private downloadURLContent(url) {
        var pom = document.createElement('a');
        pom.setAttribute('target', '_blank');
        pom.setAttribute('href', url);
        //pom.setAttribute('target', '_blank');
        pom.style.display = 'none';
        document.body.appendChild(pom);
        pom.click();
        document.body.removeChild(pom);
    }

    onPage(event) {

    }

    onSelect({ selected }) {
        this.selected.splice(0, this.selected.length);
        this.selected.push(...selected);
        if (this.selected.length) {
            this.gridConfig.showCheck = true;
        }
        else {
            this.gridConfig.showCheck = false;
        }
    }

    onActivate(event) {
        //console.log('Activate Event', event);
    }

}
