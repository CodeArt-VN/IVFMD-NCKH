import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { TongHopBaoCaoTienDoNghienCuuPage } from './tong-hop-bao-cao-tien-do-nghien-cuu';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
        TongHopBaoCaoTienDoNghienCuuPage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      IonicPageModule.forChild(TongHopBaoCaoTienDoNghienCuuPage)
  ],
  exports: [
      TongHopBaoCaoTienDoNghienCuuPage
    ],
    schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class TongHopBaoCaoTienDoNghienCuuPageModule {}
