import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { AEModalPage } from './ae-modal';

@NgModule({
  declarations: [
    AEModalPage,
  ],
  imports: [
      IonicPageModule.forChild(AEModalPage)
  ],
  exports: [
    AEModalPage
  ]
})
export class AEModalPageModule {}
