import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { LinhVucModalPage } from './linh-vuc-modal';

@NgModule({
  declarations: [
    LinhVucModalPage,
  ],
  imports: [
    IonicPageModule.forChild(LinhVucModalPage)
  ],
  exports: [
    LinhVucModalPage
  ]
})
export class LinhVucModalPageModule { }
