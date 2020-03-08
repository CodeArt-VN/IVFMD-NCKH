import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoDangKyDeTaiChiTietModalPage } from './hoi-nghi-hoi-thao-dang-ky-de-tai-chi-tiet-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import {MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
        HoiNghiHoiThaoDangKyDeTaiChiTietModalPage
  ],
  imports: [
    NgxDatatableModule,
    MatDatepickerModule,
    MatNativeDateModule,
      IonicPageModule.forChild(HoiNghiHoiThaoDangKyDeTaiChiTietModalPage)
  ],
  exports: [
      HoiNghiHoiThaoDangKyDeTaiChiTietModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HoiNghiHoiThaoDangKyDeTaiChiTietModalPageModule { }
