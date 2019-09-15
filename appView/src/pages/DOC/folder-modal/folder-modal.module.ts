import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { FolderModalPage } from './folder-modal';

@NgModule({
  declarations: [
    FolderModalPage,
  ],
  imports: [
    IonicPageModule.forChild(FolderModalPage),
  ],
  exports: [
    FolderModalPage
  ]
})
export class FolderModalPageModule { }
