import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { RoleModalPage } from './role-modal';

@NgModule({
  declarations: [
    RoleModalPage,
  ],
  imports: [
    IonicPageModule.forChild(RoleModalPage),
  ],
  exports: [
    RoleModalPage
  ]
})
export class RoleModalPageModule { }
