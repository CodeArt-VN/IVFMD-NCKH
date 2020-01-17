import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BaoCaoTienDoNghienCuuModalPage } from './bao-cao-tien-do-nghien-cuu-modal';

@NgModule({
    declarations: [
        BaoCaoTienDoNghienCuuModalPage,
    ],
    imports: [
        IonicPageModule.forChild(BaoCaoTienDoNghienCuuModalPage)
    ],
    exports: [
        BaoCaoTienDoNghienCuuModalPage
    ]
})
export class BaoCaoTienDoNghienCuuModalPageModule { }
