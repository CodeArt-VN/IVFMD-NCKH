import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DeTaiModalPage } from './de-tai-modal';

@NgModule({
  declarations: [
    DeTaiModalPage,
  ],
  imports: [
    IonicPageModule.forChild(DeTaiModalPage)
  ],
  exports: [
    DeTaiModalPage
  ]
})
export class DeTaiModalPageModule { }
