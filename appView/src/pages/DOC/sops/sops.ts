import { Component, } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController, ModalController, PopoverController } from 'ionic-angular';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { ListPage } from '../../list-page';
import { DOC_FileProvider, DOC_File_ActitityProvider, DOC_FolderProvider } from '../../../providers/Services/Services';
import { GlobalData } from '../../../providers/CORE/global-variable';
import { FolderModalPage } from '../folder-modal/folder-modal';
import { FileModalPage } from '../file-modal/file-modal';
import { ViewerModalPage } from '../viewer-modal/viewer-modal';
import { PopoverPage } from '../../HETHONG/popover/popover';

import * as JsDiff from 'diff';
import PhotoSwipe from 'photoswipe';
import PhotoSwipeUI_Default from 'photoswipe/dist/photoswipe-ui-default';

import { appSetting } from '../../../providers/CORE/api-list';

@IonicPage({ name: 'page-sops', segment: 'sops', priority: 'high' })
@Component({ selector: 'page-sops', templateUrl: 'sops.html' })
export class SopsPage extends ListPage {
    folderList: any[] = [];
    folderTree: any[] = [];
    folderTreeState: any[] = [];
    isNeedToReloadTree = true;
    tabIndex = 0;

    folderid: null;
    folderPath: any[] = [];

    folderViewList: any[] = [];

    token = '';
    apiDomain = '';
    canManageFolder = false;
    canManageFile = false;
    canEditFile = false;
    canApproveDoc = false;
    canViewReport = false;
    canViewTeam = false;
    canViewSops = false;
    canDownload = false;
    canDeleteFolder = false;
    canDeleteFile = false;

    isFolderOther = false;

    FormGroups = [];
    Modules = [];
    CurrentModule = "SOPs"; 

    constructor(
        public folderProvider: DOC_FolderProvider,
        public file_ActitityProvider: DOC_File_ActitityProvider,
        public currentProvider: DOC_FileProvider,

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
        super('page-sops', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.events.subscribe('app:page-sops-ReBuildFolderTree', (folder) => {

            this.isNeedToReloadTree = true;
            this.loadFolderTree(null).then(() => {
                if (folder && folder.ID == this.folderid) {
                    this.folderPath = [];
                    this.lookupFolderPath(folder.ID);
                }
            });
            if (folder && (folder.IDParent == this.folderid || folder.oldIDParent == this.folderid)) {
                this.refresh();
            }
        });
        this.events.subscribe('app:page-sops-ReloadFileInfo', (file) => {
            if (file && (file.IDFolder == this.folderid || file.oldIDFolder == this.folderid)) {
                this.refresh();
            }
        });


    }

    changeModule() {
        if (this.CurrentModule) {
            this.navCtrl.setRoot(this.Modules.filter(d => d.Module == this.CurrentModule)[0].Code);
        }
    }

    preLoadData() {
        this.FormGroups = this.userprofile.MenuItems.filter(d => d.AppID == 3);
        this.Modules = this.getModules();
        this.folderPath = [];
        this.folderid = null;
        this.selected = [];
        this.showInfo = false;

        this.query.IsApproved = true;
        this.query.IDParent = null;
        this.query.IDFolder = null;
        this.query.IncludeOwner = true;

        this.token = GlobalData.Token.access_token;
        this.apiDomain = appSetting.mainService.base;
        this.checkRight();
        super.preLoadData();
        //init left tree
        this.loadFolderTree(null);

    }

    checkRight() {
        this.canManageFolder = this.isUserCanUse('page-folder-modal');
        this.canManageFile = this.isUserCanUse('page-file-modal');
        this.canEditFile = this.isUserCanUse('func-document-editor');
        this.canApproveDoc = this.isUserCanUse('page-approve');
        this.canViewReport = this.isUserCanUse('page-report');
        this.canViewTeam = this.isUserCanUse('page-team');
        this.canViewSops = this.isUserCanUse('page-sops');
        this.canDownload = this.isUserCanUse('func-download');
        this.canDeleteFolder = this.isUserCanUse('func-folder-delete');
        this.canDeleteFile = this.isUserCanUse('func-file-delete');
    }

    loadData() {

        Promise.all([
            this.folderProvider.read(this.query),
        ])
            .then(values => {
                this.folderViewList = values[0]['data'];
                super.loadData();
            })
    }

    loadedData() {
        let folders = [];
        this.folderViewList.forEach(i => {
            folders.push({ ID: i.ID, Code: i.Code, Name: i.Name, Remark: i.Remark, Extension: 'folder', FileSize: '', Path: '', CreatedBy: i.CreatedBy, CreatedDate: i.CreatedDate, ModifiedBy: i.ModifiedBy, ModifiedDate: i.ModifiedDate, IDLinhVuc: i.IDLinhVuc, IDDeTai: i.IDDeTai });
        });

        folders = folders.concat(this.items);

        folders.forEach(i => {
            this.getFileViewInfo(i);
        });

        this.items = [...folders];

        if (this.selected.length && this.showInfo) {
            let seletedite = this.items.find(d => d.ID == this.selected[0].ID && d.Extension == this.selected[0].Extension);
            if (seletedite) {
                this.selected = [seletedite];
                this.loadActivity(this.selected[0]);
            }
        }
        //check cmd to open shared links
        else if (this.navParams.data.cmd) {

            if (this.navParams.data.cmd == 'open-folder') {
                let i = this.folderTree.find(d => d.ID == this.navParams.data.id);
                if (i) {
                    this.showFolder(i);
                    this.navParams.data.cmd = null;
                }
            }
            else if (this.navParams.data.cmd == 'open-file') {
                this.currentProvider.getAnItem(this.navParams.data.id).then((i: any) => {

                    this.getFileViewInfo(i);
                    this.items = [];
                    this.items.push(i);
                    let f = this.folderTree.find(d => d.ID == i.IDFolder);
                    this.showFolder(f);

                    this.previewItem(i);
                    this.navParams.data.cmd = null;
                });

            }

        }



        super.loadedData();
    }

    getFileViewInfo(i) {
        if (i.Extension == 'folder' || i.Extension == '') {
            i.FileTypeIcon = 'ios-folder';
        }
        else if (i.Extension == 'pdf' || i.Extension == 'pdf') {
            i.FileTypeIcon = 'fa-file-pdf-o';
        }
        else if (i.Extension == 'doc' || i.Extension == 'docx') {
            i.FileTypeIcon = 'fa-file-word-o';
        }
        else if (i.Extension == 'xlsx' || i.Extension == 'xls') {
            i.FileTypeIcon = 'fa-file-excel-o';
        }
        else if (i.Extension == 'ppt' || i.Extension == 'pptx') {
            i.FileTypeIcon = 'fa-file-powerpoint-o';
        }
        else if (i.Extension == 'jpg' || i.Extension == 'png' || i.Extension == 'jpeg') {
            i.FileTypeIcon = 'fa-image';
        }
        else if (i.Extension == 'mp4' || i.Extension == 'mkv' || i.Extension == 'flv' || i.Extension == 'avi' || i.Extension == 'mov' || i.Extension == 'wmv' || i.Extension == '3gp') {
            i.FileTypeIcon = 'fa-file-video-o';
        }

        else {
            i.FileTypeIcon = 'ios-document';
        }

        i.FileSizeText = this.commonService.fileSizeFormat(i.FileSize);
        i.ModifiedDateText = this.commonService.dateFormat(i.ModifiedDate, 'hh:MM dd/mm/yyyy');
        i.CreatedDateText = this.commonService.dateFormat(i.CreatedDate, 'hh:MM dd/mm/yyyy');

    }


    //event
    changePartner() {
        let partner = this.userprofile.Partners.find(d => d.ID == this.query.IDPartner)
        if (partner) {
            this.userprofile.Partner = partner;
        }
        GlobalData.Filter.IDPartner = this.query.IDPartner;
        this.isNeedToReloadTree = true;
        this.preLoadData();
    }

    //table
    onSelect({ selected }) {
        if (this.showInfo && this.selected[0].Extension != 'folder') {
            this.loadActivity(this.selected[0]);
            setTimeout(() => {
                window.dispatchEvent(new Event('resize'));
            }, 0);
        }
    }

    previewItem(i) {
        if (i.FileTypeIcon == 'ios-folder') {
            this.showFolder(i);
        }
        else if (i.FileTypeIcon == 'fa-image') {
            this.photoSwipe(i);
        }
        else {
            this.previewPDFItem(i);
        }
    }

    previewPDFItem(item) {

        console.log(item);
        let myModal = this.modalCtrl.create(ViewerModalPage, { item: item, 'id': item.ID, IDPartner: this.query.IDPartner }, { cssClass: 'preview-modal' });
        myModal.present();

    }


    //tool
    showInfo = false;
    showHideInfo() {
        this.showInfo = !this.showInfo;
        setTimeout(() => {
            window.dispatchEvent(new Event('resize'));
        }, 0);
        if (this.selected[0].Extension != 'folder') {
            this.loadActivity(this.selected[0]);
        }
    }

    editItem(item) {
        if (item.Extension == 'folder') {
            if (item.IDLinhVuc > 0) {
                this.toastMessage('Không thể sửa folder này!')
                return;
            }
            let myModal = this.modalCtrl.create(FolderModalPage, { item: item, 'id': item.ID, IDPartner: this.query.IDPartner });
            myModal.present();
        }
        else {
            if (item.IDDeTai > 0) {
                this.toastMessage('Không thể sửa file này!')
                return;
            }
            let myModal = this.modalCtrl.create(FileModalPage, { item: item, 'id': item.ID, IDPartner: this.query.IDPartner, canApproveDoc: this.canApproveDoc });
            myModal.present();
        }
    }

    addItem(ev: UIEvent) {
        let popover = this.popoverCtrl.create(PopoverPage, {
            popid: 'sops-add'
        });

        popover.present({
            ev: ev
        });
        popover.onDidDismiss(data => {
            if (data == 'addFile') {
                let item = {
                    ID: 0,
                    IDFolder: this.folderid,
                };
                this.editItem(item);
            }
            else if (data == 'addFolder') {
                let item = {
                    ID: 0,
                    IDParent: this.folderid,
                    Extension: 'folder'
                };
                this.editItem(item);
            }
        });
    }

    deleteItem(item) {
        if (item.IDLinhVuc > 0) {
            this.toastMessage('Không thể xóa folder này!')
            return;
        }
        if (item.IDDeTai > 0) {
            this.toastMessage('Không thể xóa file này!')
            return;
        }

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
                        const promises = [];
                        seletedItems.forEach(ite => {
                            if (ite.Extension == 'folder') {
                                promises.push(this.folderProvider.delete(ite));
                            }
                            else {
                                promises.push(this.currentProvider.delete(ite));
                            }
                        })
                        Promise.all(promises)
                            .then(res => {
                                let toast = this.toastCtrl.create({
                                    message: 'Đã xóa ' + seletedItems.length + ' dòng.',
                                    duration: GlobalData.UserData.Setting.ToastMessageDelay
                                });
                                toast.present();
                                this.refresh();
                                this.events.publish('app:page-sops-ReBuildFolderTree');
                            })
                            .catch(err => {
                                console.log(err);
                                if (this.loading) this.loading.dismiss();
                                this.toastMessage('Không lưu được, \nvui lòng thử lại.');
                            });
                    }
                }
            ]
        });
        confirm.present();


    }

    showTab(index) {
        this.tabIndex = index;
    }

    getShareLink(ev) {
        let link = window.location.origin + "/#/";

        if (this.selected[0].Extension == 'folder') {
            link += 'share-folder-' + this.selected[0].ID;
        }
        else {
            link += 'share-file-' + this.selected[0].ID;
        }

        let popover = this.popoverCtrl.create(PopoverPage, {
            popid: 'sops-link',
            link: link
        });
        popover.present({
            ev: ev
        });
        popover.onDidDismiss(data => {
            if (data == 'copied') {
                this.toastMessage('Đã copy.')
            }
        });
    }


    

    loadFolderTree(folder, toogle = false) {
        return new Promise(resolve => {
            this.preBuildTree().then(() => {
                if (folder && folder.showdetail && toogle) {
                    //hide
                    folder.showdetail = false;
                    this.showHideAllNestedFolder(folder.ID, false, folder.showdetail);

                }
                else if (folder && !folder.showdetail && toogle) {
                    //show loaded
                    folder.showdetail = true;
                    this.showHideAllNestedFolder(folder.ID, true, folder.showdetail);
                }
                resolve(true);
            });
        });
    }

    showFolder(folder) {
        this.folderPath = [];
        if (folder == null) {
            this.query.IDParent = null;
            this.query.IDFolder = null;
            this.checkRight();
        }
        else {
            this.query.IDParent = folder.ID;
            this.query.IDFolder = folder.ID;
            if (folder.IDLinhVuc > 0) {
                this.canManageFolder = false;
                this.canManageFile = false;
                this.canEditFile = false;
                this.canDeleteFolder = false;
                this.canDeleteFile = false;
                this.isFolderOther = false;
            } else this.isFolderOther = true;

            let active = this.folderTree.find(d => d.ID == folder.ID);
            this.loadFolderTree(active);
            this.lookupFolderPath(folder.ID);
        }
        this.folderid = this.query.IDParent;
        this.selected = [];
        this.showInfo = false;
        this.loadData();
    }



    //load activities
    loadActivity(item) {
        if (!item.LoadedActivities) {
            let queryFileActivities = { IDFile: item.ID }
            this.file_ActitityProvider.read(queryFileActivities).then((result: any) => {
                //item.LoadedActivities = true;
                item.activities = result.data;
                item.activities.forEach(i => {
                    i.Avatar = appSetting.mainService.base + i.Avatar;
                    i.ModifiedDateText = this.commonService.dateFormat(i.ModifiedDate, 'hh:MM dd/mm/yyyy');
                    let changes = JSON.parse(i.Remark.replace(/\r?\n|\r/g, "-"));
                    let str = "";

                    for (var pro in changes) {
                        let d = changes[pro];

                        if (pro == 'Code') {
                            //str += "<div class='title'>Tên file:</div>"
                            continue;
                        }
                        else if (pro == 'Name') {
                            str += "<div class='title'>Tiêu đề văn bản:</div>"
                        }
                        else if (pro == 'Remark') {
                            str += "<div class='title'>Mô tả:</div>"
                        }
                        else if (pro == 'Path') {
                            str += "<div class='title'>Cập nhật file:</div>"
                            if (d.old) {
                                let fileName = d.old.replace(/^.*[\\\/]/, '');
                                if (fileName.length > 39) {
                                    let span = document.createElement('div');
                                    span.className = 'removed';
                                    span.appendChild(document.createTextNode(fileName.substring(39)));
                                    str += span.outerHTML;
                                }
                            }
                            if (d.new) {
                                let fileName = d.new.replace(/^.*[\\\/]/, '');
                                if (fileName.length > 39) {
                                    let span = document.createElement('div');
                                    span.className = 'added';
                                    span.appendChild(document.createTextNode(fileName.substring(39)));
                                    str += span.outerHTML;
                                }
                            }
                            continue;
                        }
                        else if (pro == 'FileSize') {
                            str += "<div class='title'>File size:</div>";
                            if (d.old) {
                                let span = document.createElement('span');
                                span.className = 'removed';
                                span.appendChild(document.createTextNode(this.commonService.fileSizeFormat(d.old)));
                                str += span.outerHTML;
                            }
                            if (d.new) {
                                let span = document.createElement('span');
                                span.className = 'added';
                                span.appendChild(document.createTextNode(this.commonService.fileSizeFormat(d.new)));
                                str += span.outerHTML;
                            }
                            continue;
                        }
                        if (pro == 'Extension') {
                            continue;
                        }
                        
                        else if (pro == 'IsApproved') {
                            str += "<div class='title'></div>"
                            let span = document.createElement('span');
                            if (d.new == 'True') {
                                span.className = 'text-ios-success';
                                span.appendChild(document.createTextNode('Đã duyệt'));
                            }
                            else {
                                span.className = 'text-ios-danger';
                                span.appendChild(document.createTextNode('Chưa được duyệt do thay đổi'));
                            }

                            str += span.outerHTML;
                            continue;
                        }
                        else if (pro == 'ApprovedBy') {
                            let text = d.new == 'Chờ duyệt' ? 'Gửi duyệt' : d.new == 'Không được duyệt' ? 'Đã từ chối duyệt' : '';
                            if (text != '') {
                                str += "<div class='title'></div>"

                                let color = d.new == 'Chờ duyệt' ? 'success' : d.new == 'Không được duyệt' ? 'danger' : 'warning';

                                let span = document.createElement('span');
                                span.className = 'text-ios-' + color;
                                span.appendChild(document.createTextNode(text));
                                str += span.outerHTML;
                            }


                            continue;
                        }

                        var diff = JsDiff.diffWords(d.old, d.new);
                        diff.forEach(function (part) {
                            let color = part.added ? 'added' : part.removed ? 'removed' : '';
                            let span = document.createElement('span');
                            span.className = color;
                            span.innerHTML = part.value;
                            //span.appendChild(document.createTextNode(part.value));
                            str += span.outerHTML;
                        });
                    }
                    i.Changes = str;
                });
            })
        }
    }

    avatarLoadError(item) {
        item.Avatar = 'assets/imgs/avartar-empty.jpg';
    }

    //method
    preBuildTree() {
        this.folderTreeState = this.folderTree;
        return new Promise(resolve => {
            if (this.isNeedToReloadTree) {
                Promise.all([
                    this.folderProvider.read()
                ])
                    .then(values => {
                        this.isNeedToReloadTree = false;
                        this.folderList = values[0]['data'];
                        this.folderTree = [];
                        this.buildTree(null);

                        //load saved state
                        let currentParent = null;
                        this.folderTree.forEach(i => {

                            currentParent = this.folderTree.find(d => d.ID == i.IDParent);

                            let f = this.folderTreeState.find(d => d.ID == i.ID);
                            if (f) {
                                i.show = !currentParent ? true : ((currentParent.showdetail && f.show) ? true : false);
                                i.showdetail = f.showdetail ? true : false;

                            }
                            else {
                                i.show = !currentParent ? true : currentParent.showdetail;
                                i.showdetail = false;
                            }
                        });
                        resolve(true);
                    });
            }
            else {
                resolve(true);
            }
        });
    }

    lookupFolderPath(IDParent) {
        let f = this.folderTree.find(d => d.ID == IDParent);
        if (f) {
            this.folderPath.unshift(f);
            if (f.IDParent) {
                this.lookupFolderPath(f.IDParent);
            }
        }

    }

    showHideAllNestedFolder(ID, isShow, showDetail) {
        this.folderTree.filter(d => d.IDParent == ID).forEach(i => {
            if (!isShow || showDetail) {
                i.show = isShow;
            }
            this.showHideAllNestedFolder(i.ID, isShow, i.showdetail);
        });
    }

    buildTree(item) {
        let idp = item == null ? null : item.ID;
        let childrent = this.folderList.filter(d => d.IDParent == idp);
        let level = (item && item.level >= 0) ? item.level + 1 : 0;

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

    photoSwipe(item) {

        let pswpElement = document.querySelectorAll('.pswp')[0];
        let imgItems = this.items.filter(d => d.FileTypeIcon == 'fa-image');

        imgItems.forEach(i => {
            i.src = appSetting.mainService.base + i.Code;
            i.w = 0,
                i.h = 0
        });

        let index = imgItems.findIndex(d => d.ID == item.ID)

        var options = {
            bgOpacity: 0.7,
            arrowKeys: true,
            shareEl: false,
            index: index,
            history: false,
            focus: false,
            closeOnScroll: false,
            showAnimationDuration: 0,
            hideAnimationDuration: 0

        };

        var gallery = new PhotoSwipe(pswpElement, PhotoSwipeUI_Default, imgItems, options);
        gallery.listen('gettingData', function (index, item) {
            if (item.w < 1 || item.h < 1) { // unknown size
                let img: any = new Image();
                img.onload = function () { // will get size after load
                    item.w = this.width; // set image width
                    item.h = this.height; // set image height
                    gallery.invalidateCurrItems(); // reinit Items
                    gallery.updateSize(true); // reinit Items
                }
                img.src = item.src; // let's download image
            }
        });
        gallery.init();
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