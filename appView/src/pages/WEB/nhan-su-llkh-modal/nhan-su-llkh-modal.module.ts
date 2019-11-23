import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NhanSuLLKHModalPage } from './nhan-su-llkh-modal';

@NgModule({
    declarations: [
      NhanSuLLKHModalPage,
    ],
    imports: [
        IonicPageModule.forChild(NhanSuLLKHModalPage)
    ],
    exports: [
      NhanSuLLKHModalPage
    ]
})
export class NhanSuLLKHModalPageModule { }
