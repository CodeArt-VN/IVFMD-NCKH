import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DeTaiDetailPage } from './de-tai-detail';
import { FileUploadModule } from 'ng2-file-upload';
@NgModule({
  declarations: [
    DeTaiDetailPage
  ],
  imports: [
    IonicPageModule.forChild(DeTaiDetailPage),
    FileUploadModule
  ],
  exports: [
    DeTaiDetailPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class DeTaiDetailPageModule {}
