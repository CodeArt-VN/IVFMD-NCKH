import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DonXinDanhGiaDaoDucModalPage } from './don-xin-danh-gia-dao-duc-modal';

@NgModule({
    declarations: [
        DonXinDanhGiaDaoDucModalPage,
    ],
    imports: [
        IonicPageModule.forChild(DonXinDanhGiaDaoDucModalPage)
    ],
    exports: [
        DonXinDanhGiaDaoDucModalPage
    ]
})
export class DonXinDanhGiaDaoDucModalPageModule { }
