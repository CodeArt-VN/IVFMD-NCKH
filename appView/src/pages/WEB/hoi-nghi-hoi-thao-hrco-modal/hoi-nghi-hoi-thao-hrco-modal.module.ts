import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoHRCOModalPage } from './hoi-nghi-hoi-thao-hrco-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import {MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
        HoiNghiHoiThaoHRCOModalPage
  ],
  imports: [
    NgxDatatableModule,
    MatDatepickerModule,
    MatNativeDateModule,
      IonicPageModule.forChild(HoiNghiHoiThaoHRCOModalPage)
  ],
  exports: [
      HoiNghiHoiThaoHRCOModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HoiNghiHoiThaoHRCOModalPageModule { }
