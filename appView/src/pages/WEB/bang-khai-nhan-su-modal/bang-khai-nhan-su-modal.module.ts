import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BangKhaiNhanSuModalPage } from './bang-khai-nhan-su-modal';

@NgModule({
  declarations: [
        BangKhaiNhanSuModalPage,
  ],
  imports: [
      IonicPageModule.forChild(BangKhaiNhanSuModalPage),
  ],
})
export class BangKhaiNhanSuModalPageModule {}
