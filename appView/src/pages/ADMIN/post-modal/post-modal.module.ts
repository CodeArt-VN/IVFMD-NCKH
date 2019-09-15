import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PostModalPage } from './post-modal';
import { FileUploadModule } from '../../../../node_modules/ng2-file-upload';

@NgModule({
  declarations: [
    PostModalPage,
  ],
  imports: [
    IonicPageModule.forChild(PostModalPage), FileUploadModule
  ],
  exports: [
    PostModalPage
  ]
})
export class PostModalPageModule { }
