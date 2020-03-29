import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DefaultPage } from './default';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
        DefaultPage,
  ],
  imports: [
    NgxDatatableModule,
      IonicPageModule.forChild(DefaultPage),
  ],
  exports: [
      DefaultPage
  ]
})
export class DefaultPageModule {}
