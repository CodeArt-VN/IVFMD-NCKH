import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { FileModalPage } from './file-modal';
import { FileUploadModule } from 'ng2-file-upload';

@NgModule({
  declarations: [
    FileModalPage, 
  ],
  imports: [
    IonicPageModule.forChild(FileModalPage),  FileUploadModule
  ],
  exports: [
    FileModalPage
  ]
})
export class FileModalPageModule { }
