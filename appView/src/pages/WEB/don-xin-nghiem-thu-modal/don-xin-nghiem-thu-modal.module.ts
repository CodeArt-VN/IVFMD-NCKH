import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DonXinNghiemThuModalPage } from './don-xin-nghiem-thu-modal';

@NgModule({
    declarations: [
        DonXinNghiemThuModalPage,
    ],
    imports: [
        IonicPageModule.forChild(DonXinNghiemThuModalPage)
    ],
    exports: [
        DonXinNghiemThuModalPage
    ]
})
export class DonXinNghiemThuModalPageModule { }
