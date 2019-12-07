import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NhomModalPage } from './nhom-modal';

@NgModule({
  declarations: [
    NhomModalPage,
  ],
  imports: [
    IonicPageModule.forChild(NhomModalPage)
  ],
  exports: [
    NhomModalPage
  ]
})
export class NhomModalPageModule { }
