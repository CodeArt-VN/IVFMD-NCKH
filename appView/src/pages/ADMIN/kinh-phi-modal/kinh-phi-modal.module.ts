import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { KinhPhiModalPage } from './nhom-modal';

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
