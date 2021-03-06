import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BaoCaoNangSuatKhoaHocPage } from './bao-cao-nang-suat-khoa-hoc';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
        BaoCaoNangSuatKhoaHocPage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      IonicPageModule.forChild(BaoCaoNangSuatKhoaHocPage)
  ],
  exports: [
      BaoCaoNangSuatKhoaHocPage
  ]
})
export class BaoCaoNangSuatKhoaHocPageModule {}
