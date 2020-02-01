import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BaoCaoNangSuatKhoaHocModalPage } from './bao-cao-nang-suat-khoa-hoc-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import {MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
        BaoCaoNangSuatKhoaHocModalPage
  ],
  imports: [
    NgxDatatableModule,
    MatDatepickerModule,
    MatNativeDateModule,
      IonicPageModule.forChild(BaoCaoNangSuatKhoaHocModalPage)
  ],
  exports: [
      BaoCaoNangSuatKhoaHocModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class BaoCaoNangSuatKhoaHocModalPageModule { }
