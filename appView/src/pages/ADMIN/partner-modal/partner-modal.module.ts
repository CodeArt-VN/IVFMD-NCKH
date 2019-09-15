import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PartnerModalPage } from './partner-modal';

@NgModule({
  declarations: [
    PartnerModalPage,
  ],
  imports: [
    IonicPageModule.forChild(PartnerModalPage),
  ],
  exports: [
    PartnerModalPage
  ]
})
export class PartnerModalPageModule { }
