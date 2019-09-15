import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { CateModalPage } from './cate-modal';

@NgModule({
  declarations: [
    CateModalPage,
  ],
  imports: [
    IonicPageModule.forChild(CateModalPage),
  ],
  exports: [
    CateModalPage
  ]
})
export class CateModalPageModule { }
