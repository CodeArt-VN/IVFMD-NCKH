import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ThietLapThoiGianBaoCaoNSKHPage } from './thiet-lap-thoi-gian-bao-cao-nskh';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';

@NgModule({
  declarations: [
        ThietLapThoiGianBaoCaoNSKHPage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      IonicPageModule.forChild(ThietLapThoiGianBaoCaoNSKHPage),
  ],
  exports: [
      ThietLapThoiGianBaoCaoNSKHPage
    ],
    schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class ThietLapThoiGianBaoCaoNSKHPageModule {}
