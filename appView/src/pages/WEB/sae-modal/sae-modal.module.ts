import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SAEModalPage } from './sae-modal';

@NgModule({
  declarations: [
    SAEModalPage,
  ],
  imports: [
      IonicPageModule.forChild(SAEModalPage)
  ],
  exports: [
    SAEModalPage
  ]
})
export class SAEModalPageModule {}
