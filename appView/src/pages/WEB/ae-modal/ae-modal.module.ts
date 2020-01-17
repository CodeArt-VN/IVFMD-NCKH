import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { AeModalPage } from './ae-modal';

@NgModule({
  declarations: [
    AeModalPage,
  ],
  imports: [
      IonicPageModule.forChild(AeModalPage)
  ],
  exports: [
    AeModalPage
  ]
})
export class AeModalPageModule {}
