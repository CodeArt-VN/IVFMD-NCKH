import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { HttpModule } from '@angular/http';
import { IonicStorageModule } from '@ionic/storage';
import { MyApp } from './app.component';
import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import { File } from '@ionic-native/file';
import { FileTransfer } from '@ionic-native/file-transfer';
import { Facebook } from '@ionic-native/facebook';
import { GoogleAnalytics } from '@ionic-native/google-analytics';


import { PipesModule } from '../pipes/pipes.module';
import { AccountServiceProvider } from '../providers/CORE/account-service';
import { CommonServiceProvider } from '../providers/CORE/common-service';
import { NCKHServiceProvider } from '../providers/CORE/nckh-service';

import {
    DOC_FileProvider, DOC_File_ActitityProvider, DOC_File_PermissionProvider, DOC_FileInFolderProvider, DOC_FolderProvider, DOC_Folder_ActivityProvider, DOC_Folder_PermissionProvider, HRM_LIST_BoPhanProvider, HRM_LIST_ChucDanhProvider, HRM_STAFF_NhanSuProvider, SYS_CauHinhHeThongProvider, SYS_PermissionListProvider, SYS_PermissionListDetailDataProvider, SYS_RoleProvider, VersionProvider, PAR_DonHangProvider, PAR_DonHang_ChiTietProvider, PAR_PartnerProvider, PAR_ThongTinSanPhamProvider, PROD_SanPhamProvider, PROD_SanPham_ChiTietProvider, SYS_AppsProvider, SYS_ConfigProvider, SYS_ControllerActionsProvider, SYS_FormProvider, SYS_FormDetailProvider, SYS_FormGroupProvider, WEB_BaiVietProvider, WEB_BaiViet_DanhMucProvider, WEB_BaiViet_TagProvider, WEB_DanhMucProvider, WEB_TagProvider, CAT_TagsProvider, CAT_NhomProvider, CAT_KinhPhiProvider, CAT_LinhVucProvider, CAT_BangGiaKinhPhiProvider, CAT_SiteProvider, PRO_DeTaiProvider, PRO_BenhNhanProvider, PRO_NCVKhacProvider, HRM_BenhNhanProvider, STAFF_NhanSu_LLKHProvider, PRO_LLKHProvider, STAFF_NhanSu_SYLLProvider, PRO_SYLLProvider,
    PRO_BangKiemXXDDProvider, PRO_AE, PRO_PhieuXemXetDaoDuc, PRO_SAE, PRO_BaoCaoNangSuatKhoaHocProvider, PRO_HoiNghiHoiThaoProvider, PRO_HoiNghiHoiThaoDangKyProvider, PRO_HoiNghiHoiThaoDangKyDeTaiProvider, PRO_ThuyetMinhDeTai, STAFF_NhanSu_HosremProvider
} from '../providers/Services/Services'; 

import {
    ACCOUNT_ApplicationUserProvider, ManualProvider, ReportProvider, Sys_VarProvider, PRO_SysnopsisCustomProvider, PRO_MauPhanTichDuLieuCustomProvider, PRO_DonXinXetDuyetCustomProvider, PRO_DonXinDanhGiaDaoDucCustomProvider, PRO_DonXinNghiemThuCustomProvider, PRO_BenhNhanCustomProvider, PRO_NCVKhacCustomProvider, STAFF_NhanSu_LLKHProviderCustomProvider, PRO_DeTaiCustomProvider, PRO_LLKHCustomProvider, STAFF_NhanSu_SYLLProviderCustomProvider, PRO_SYLLCustomProvider,
    PRO_BangKiemXXDDCustomProvider, PRO_BaoCaoTienDoNghienCuuCustomProvider, PRO_AECustomProvider, PRO_PhieuXemXetDaoDucCustomProvider, PRO_SAECustomProvider, PRO_BaoCaoNangSuatKhoaHocCustomProvider, PRO_HoiNghiHoiThaoCustomProvider, PRO_HoiNghiHoiThaoDangKyCustomProvider, PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider, PRO_ThuyetMinhDeTaiCustomProvider, STAFF_NhanSu_HosremCustomProvider, CAT_ThietLapThoiGianBaoCaoNSKHProvider, CAT_ThietLapThoiGianBaoCaoTDNCProvider, CAT_ThietLapTemplateProvider, PRO_BangKhaiNhanSuCustomProvider,
    PRO_BaoCaoNghiemThuDeTaiCustomProvider, HRM_STAFF_NhanSuCustomProvider, PRO_HoSoKhacCustomProvider
} from '../providers/Services/CustomService';
import { ViewerModalPage } from '../pages/DOC/viewer-modal/viewer-modal';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";

@NgModule({
    declarations: [
        MyApp, ViewerModalPage
    ],
    imports: [
        BrowserModule,
        HttpModule,
        IonicStorageModule.forRoot(),
        IonicModule.forRoot(MyApp, {
            mode: 'ios',
            preloadModules: true,
            backButtonText: 'Trở lại',
            modalEnter: 'modal-slide-in',
            modalLeave: 'modal-slide-out',
            tabsPlacement: 'bottom',
            pageTransition: 'ios-transition',
            locationStrategy: 'local',//'local'; Set to 'path' to remove hashbangs when using Deeplinking.
        }),
        PipesModule,
        BrowserAnimationsModule
    ],
  
    bootstrap: [IonicApp],
    entryComponents: [
        MyApp, ViewerModalPage
    ],
    providers: [
        StatusBar, SplashScreen, File, FileTransfer, Facebook, GoogleAnalytics,
        { provide: ErrorHandler, useClass: IonicErrorHandler },
        AccountServiceProvider,
        CommonServiceProvider,
        NCKHServiceProvider,
        
        ACCOUNT_ApplicationUserProvider,
        PRO_BaoCaoTienDoNghienCuuCustomProvider, 
        ManualProvider, ReportProvider, Sys_VarProvider, PRO_SysnopsisCustomProvider, PRO_MauPhanTichDuLieuCustomProvider, PRO_DonXinXetDuyetCustomProvider, PRO_DonXinDanhGiaDaoDucCustomProvider, PRO_DonXinNghiemThuCustomProvider, PRO_BenhNhanCustomProvider, PRO_NCVKhacCustomProvider, STAFF_NhanSu_LLKHProviderCustomProvider, PRO_DeTaiCustomProvider,
        PRO_NCVKhacCustomProvider, PRO_LLKHCustomProvider, PRO_SYLLCustomProvider, STAFF_NhanSu_SYLLProviderCustomProvider, PRO_BangKiemXXDDCustomProvider, , PRO_AECustomProvider, PRO_PhieuXemXetDaoDucCustomProvider, PRO_SAECustomProvider, PRO_ThuyetMinhDeTaiCustomProvider, STAFF_NhanSu_HosremCustomProvider,
        DOC_FileProvider, DOC_File_ActitityProvider, DOC_File_PermissionProvider, DOC_FileInFolderProvider, DOC_FolderProvider, DOC_Folder_ActivityProvider, DOC_Folder_PermissionProvider, HRM_LIST_BoPhanProvider, HRM_LIST_ChucDanhProvider, HRM_STAFF_NhanSuProvider, SYS_CauHinhHeThongProvider, SYS_PermissionListProvider, SYS_PermissionListDetailDataProvider, SYS_RoleProvider, VersionProvider, PAR_DonHangProvider, PAR_DonHang_ChiTietProvider, PAR_PartnerProvider, PAR_ThongTinSanPhamProvider, PROD_SanPhamProvider, PROD_SanPham_ChiTietProvider, SYS_AppsProvider, SYS_ConfigProvider, SYS_ControllerActionsProvider, SYS_FormProvider, SYS_FormDetailProvider, SYS_FormGroupProvider, WEB_BaiVietProvider, WEB_BaiViet_DanhMucProvider, WEB_BaiViet_TagProvider, WEB_DanhMucProvider, WEB_TagProvider, CAT_TagsProvider, CAT_NhomProvider, CAT_KinhPhiProvider, CAT_LinhVucProvider, CAT_BangGiaKinhPhiProvider, CAT_ThietLapThoiGianBaoCaoNSKHProvider, CAT_ThietLapThoiGianBaoCaoTDNCProvider, CAT_ThietLapTemplateProvider, CAT_SiteProvider, PRO_DeTaiProvider, PRO_BenhNhanProvider, PRO_NCVKhacProvider,
        HRM_BenhNhanProvider, STAFF_NhanSu_LLKHProvider, PRO_LLKHProvider, STAFF_NhanSu_SYLLProvider, PRO_SYLLProvider, PRO_BangKiemXXDDProvider, PRO_AE, PRO_PhieuXemXetDaoDuc, PRO_SAE, PRO_BaoCaoNangSuatKhoaHocProvider, PRO_BaoCaoNangSuatKhoaHocCustomProvider, PRO_HoiNghiHoiThaoProvider, PRO_HoiNghiHoiThaoCustomProvider, PRO_HoiNghiHoiThaoDangKyProvider, PRO_HoiNghiHoiThaoDangKyDeTaiProvider, PRO_HoiNghiHoiThaoDangKyCustomProvider, PRO_HoiNghiHoiThaoDangKyDeTaiCustomProvider, PRO_ThuyetMinhDeTai, STAFF_NhanSu_HosremProvider,
        PRO_BaoCaoNghiemThuDeTaiCustomProvider, PRO_BangKhaiNhanSuCustomProvider, HRM_STAFF_NhanSuCustomProvider, PRO_HoSoKhacCustomProvider
    ]
})
export class AppModule { }
