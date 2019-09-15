import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { StaffPage } from './staff';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    StaffPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(StaffPage),
  ],
  exports: [
    StaffPage
  ]
})
export class StaffPageModule {}
