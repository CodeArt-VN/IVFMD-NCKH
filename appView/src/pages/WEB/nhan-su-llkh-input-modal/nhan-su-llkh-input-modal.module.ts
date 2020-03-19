import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NhanSuLLKHInputModalPage } from './nhan-su-llkh-input-modal';

@NgModule({
    declarations: [
        NhanSuLLKHInputModalPage,
    ],
    imports: [
        IonicPageModule.forChild(NhanSuLLKHInputModalPage)
    ],
    exports: [
        NhanSuLLKHInputModalPage
    ]
})
export class NhanSuLLKHInputModalPageModule { }
