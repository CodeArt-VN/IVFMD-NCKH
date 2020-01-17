import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SaeModalPage } from './sae-modal';

@NgModule({
  declarations: [
    SaeModalPage,
  ],
  imports: [
      IonicPageModule.forChild(SaeModalPage)
  ],
  exports: [
    SaeModalPage
  ]
})
export class SaeModalPageModule {}
