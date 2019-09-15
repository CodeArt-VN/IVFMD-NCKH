import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PartnerPage } from './partner';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    PartnerPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(PartnerPage),
  ],
  exports: [
    PartnerPage
  ]
})
export class PartnerPageModule {}
