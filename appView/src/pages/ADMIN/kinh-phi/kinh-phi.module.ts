import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { KinhPhiPage } from './kinh-phi';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    KinhPhiPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(KinhPhiPage),
  ],
  exports: [
    KinhPhiPage
  ]
})
export class KinhPhiPageModule {}
