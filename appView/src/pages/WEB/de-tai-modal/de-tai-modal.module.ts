import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
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
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class DeTaiModalPageModule { }
