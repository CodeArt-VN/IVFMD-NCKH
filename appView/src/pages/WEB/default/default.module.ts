import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DefaultPage } from './default';
import { DirectivesModule } from '../../../directives/directives.module';

@NgModule({
  declarations: [
        DefaultPage,
  ],
  imports: [
      IonicPageModule.forChild(DefaultPage), DirectivesModule
  ],
  exports: [
      DefaultPage
  ]
})
export class DefaultPageModule {}
