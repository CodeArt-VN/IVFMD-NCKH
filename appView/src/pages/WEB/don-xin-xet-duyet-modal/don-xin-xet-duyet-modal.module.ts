import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DonXinXetDuyetModalPage } from './don-xin-xet-duyet-modal';

@NgModule({
    declarations: [
        DonXinXetDuyetModalPage,
    ],
    imports: [
        IonicPageModule.forChild(DonXinXetDuyetModalPage)
    ],
    exports: [
        DonXinXetDuyetModalPage
    ]
})
export class DonXinXetDuyetModalPageModule { }
