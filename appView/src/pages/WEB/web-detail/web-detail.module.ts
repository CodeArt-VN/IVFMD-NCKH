import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { WebDetailPage } from './web-detail';
import { DirectivesModule } from '../../../directives/directives.module';
import { PipesModule } from '../../../pipes/pipes.module';

@NgModule({
  declarations: [
    WebDetailPage, 
  ],
  imports: [
    IonicPageModule.forChild(WebDetailPage), DirectivesModule, PipesModule
  ],
  exports: [
    WebDetailPage, 
  ]
})
export class WebDetailPageModule {}
