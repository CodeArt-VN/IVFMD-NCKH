import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoModalPage } from './hoi-nghi-hoi-thao-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import {MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
        HoiNghiHoiThaoModalPage
  ],
  imports: [
    NgxDatatableModule,
    MatDatepickerModule,
    MatNativeDateModule,
      IonicPageModule.forChild(HoiNghiHoiThaoModalPage)
  ],
  exports: [
      HoiNghiHoiThaoModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HoiNghiHoiThaoModalPageModule { }
