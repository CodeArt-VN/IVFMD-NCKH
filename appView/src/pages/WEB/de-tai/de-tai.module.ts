import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DeTaiPage } from './de-tai';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    DeTaiPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(DeTaiPage),
  ],
  exports: [
    DeTaiPage
  ]
})
export class DeTaiPageModule {}
