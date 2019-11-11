import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DeTaiDetailPage } from './de-tai-detail';

@NgModule({
  declarations: [
    DeTaiDetailPage,
  ],
  imports: [
    IonicPageModule.forChild(DeTaiDetailPage),
  ],
  exports: [
    DeTaiDetailPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class DeTaiDetailPageModule {}
