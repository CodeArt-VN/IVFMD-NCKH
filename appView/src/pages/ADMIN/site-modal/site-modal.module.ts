import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SiteModalPage } from './site-modal';

@NgModule({
  declarations: [
    SiteModalPage,
  ],
  imports: [
    IonicPageModule.forChild(SiteModalPage)
  ],
  exports: [
    SiteModalPage
  ]
})
export class SiteModalPageModule { }
