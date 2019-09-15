import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { MemberModalPage } from './member-modal';

@NgModule({
  declarations: [
    MemberModalPage,
  ],
  imports: [
    IonicPageModule.forChild(MemberModalPage),
  ],
  exports: [
    MemberModalPage
  ]
})
export class MemberModalPageModule { }
