import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NhomPage } from './nhom';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    NhomPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(NhomPage),
  ],
  exports: [
    NhomPage
  ]
})
export class NhomPageModule {}
