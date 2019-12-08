import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DeTaiModalPage } from './de-tai-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import {MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
    DeTaiModalPage
  ],
  imports: [
    NgxDatatableModule,
    MatDatepickerModule,
    MatNativeDateModule,
    IonicPageModule.forChild(DeTaiModalPage)
  ],
  exports: [
    DeTaiModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class DeTaiModalPageModule { }
