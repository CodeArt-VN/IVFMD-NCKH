import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ReportPage } from './report';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    ReportPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(ReportPage),
  ],
  exports: [
    ReportPage
  ]
})
export class ReportPageModule {}
