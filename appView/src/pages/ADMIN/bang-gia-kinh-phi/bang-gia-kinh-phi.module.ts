import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BangGiaKinhPhiPage } from './BangGiaKinhPhi';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    BangGiaKinhPhiPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(BangGiaKinhPhiPage),
  ],
  exports: [
    BangGiaKinhPhiPage
  ]
})
export class BangGiaKinhPhiPageModule {}
