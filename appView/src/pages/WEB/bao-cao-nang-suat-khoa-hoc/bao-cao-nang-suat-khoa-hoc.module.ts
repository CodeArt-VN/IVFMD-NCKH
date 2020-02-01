import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BaoCaoNangSuatKhoaHocPage } from './bao-cao-nang-suat-khoa-hoc';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
@NgModule({
  declarations: [
        BaoCaoNangSuatKhoaHocPage,
  ],
  imports: [
    NgxDatatableModule,
      IonicPageModule.forChild(BaoCaoNangSuatKhoaHocPage)
  ],
  exports: [
      BaoCaoNangSuatKhoaHocPage
  ]
})
export class BaoCaoNangSuatKhoaHocPageModule {}
