import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NhanSuSYLLModalPage } from './nhan-su-syll-modal';

@NgModule({
  declarations: [
    NhanSuSYLLModalPage,
  ],
  imports: [
      IonicPageModule.forChild(NhanSuSYLLModalPage)
  ],
  exports: [
    NhanSuSYLLModalPage
  ]
})
export class NhanSuSYLLModalPageModule {}
