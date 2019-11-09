import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { MauPhanTichDuLieuModalPage } from './mau-phan-tich-du-lieu-modal';

@NgModule({
    declarations: [
        MauPhanTichDuLieuModalPage,
    ],
    imports: [
        IonicPageModule.forChild(MauPhanTichDuLieuModalPage)
    ],
    exports: [
        MauPhanTichDuLieuModalPage
    ]
})
export class MauPhanTichDuLieuModalPageModule { }
