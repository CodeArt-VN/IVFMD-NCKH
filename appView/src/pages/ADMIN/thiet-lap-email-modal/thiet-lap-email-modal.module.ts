import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ThietLapEmailModalPage } from './thiet-lap-email-modal';

@NgModule({
  declarations: [
    ThietLapEmailModalPage,
  ],
  imports: [
    IonicPageModule.forChild(ThietLapEmailModalPage)
  ],
  exports: [
    ThietLapEmailModalPage
  ]
})
export class ThietLapEmailModalPageModule { }
