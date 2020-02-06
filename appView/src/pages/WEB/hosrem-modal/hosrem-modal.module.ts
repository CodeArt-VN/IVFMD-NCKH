import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HosremModalPage } from './hosrem-modal';

@NgModule({
  declarations: [
    HosremModalPage,
  ],
  imports: [
    IonicPageModule.forChild(HosremModalPage),
  ],
})
export class HosremModalPageModule {}
