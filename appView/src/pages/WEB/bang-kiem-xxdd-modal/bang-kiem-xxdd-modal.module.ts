import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BangKiemXXDDModalPage } from './bang-kiem-xxdd-modal';

@NgModule({
  declarations: [
    BangKiemXXDDModalPage,
  ],
  imports: [
    IonicPageModule.forChild(BangKiemXXDDModalPage),
  ],
  exports: [
    BangKiemXXDDModalPage
  ]
})
export class BangKiemXXDDModalPageModule {}