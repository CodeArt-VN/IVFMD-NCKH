import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { StaffModalPage } from './staff-modal';
import { FileUploadModule } from '../../../../node_modules/ng2-file-upload';

@NgModule({
  declarations: [
    StaffModalPage,
  ],
  imports: [
    IonicPageModule.forChild(StaffModalPage), FileUploadModule
  ],
  exports: [
    StaffModalPage
  ]
})
export class StaffModalPageModule { }
