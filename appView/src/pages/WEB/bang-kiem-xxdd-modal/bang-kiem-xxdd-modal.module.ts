import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BangKiemXxddModalPage } from './bang-kiem-xxdd-modal';

@NgModule({
  declarations: [
    BangKiemXxddModalPage,
  ],
  imports: [
    IonicPageModule.forChild(BangKiemXxddModalPage),
  ],
  exports: [
    BangKiemXxddModalPage
  ]
})
export class BangKiemXxddModalPageModule {}