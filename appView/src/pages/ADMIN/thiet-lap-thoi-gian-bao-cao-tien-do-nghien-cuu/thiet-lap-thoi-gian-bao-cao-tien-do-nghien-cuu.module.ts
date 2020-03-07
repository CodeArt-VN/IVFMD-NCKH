import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ThietLapThoiGianBaoCaoTDNCPage } from './thiet-lap-thoi-gian-bao-cao-tien-do-nghien-cuu';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';

@NgModule({
  declarations: [
        ThietLapThoiGianBaoCaoTDNCPage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      IonicPageModule.forChild(ThietLapThoiGianBaoCaoTDNCPage),
  ],
  exports: [
      ThietLapThoiGianBaoCaoTDNCPage
    ],
    schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class ThietLapThoiGianBaoCaoTDNCPageModule {}
