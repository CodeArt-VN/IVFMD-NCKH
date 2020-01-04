import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { KinhPhiModalPage } from './kinh-phi-modal';

@NgModule({
  declarations: [
    KinhPhiModalPage,
  ],
  imports: [
    IonicPageModule.forChild(KinhPhiModalPage)
  ],
  exports: [
    KinhPhiModalPage
  ]
})
export class KinhPhiModalPageModule { }
