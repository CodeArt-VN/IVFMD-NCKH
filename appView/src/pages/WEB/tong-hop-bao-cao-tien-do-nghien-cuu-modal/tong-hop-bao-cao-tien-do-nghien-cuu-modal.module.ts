import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { TongHopBaoCaoTienDoNghienCuuModalPage } from './tong-hop-bao-cao-tien-do-nghien-cuu-modal';

@NgModule({
    declarations: [
        TongHopBaoCaoTienDoNghienCuuModalPage,
    ],
    imports: [
        IonicPageModule.forChild(TongHopBaoCaoTienDoNghienCuuModalPage)
    ],
    exports: [
        TongHopBaoCaoTienDoNghienCuuModalPage
    ]
})
export class TongHopBaoCaoTienDoNghienCuuModalPageModule { }
