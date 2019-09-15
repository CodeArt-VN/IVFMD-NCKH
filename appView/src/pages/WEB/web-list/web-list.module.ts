import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { WebListPage } from './web-list';
import { DirectivesModule } from '../../../directives/directives.module';

@NgModule({
  declarations: [
    WebListPage,
  ],
  imports: [
    IonicPageModule.forChild(WebListPage), DirectivesModule
  ],
  exports: [
    WebListPage
  ]
})
export class WebListPageModule {}
