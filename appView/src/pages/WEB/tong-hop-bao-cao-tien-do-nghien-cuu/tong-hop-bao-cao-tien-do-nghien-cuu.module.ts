import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { TongHopBaoCaoTienDoNghienCuuPage } from './tong-hop-bao-cao-tien-do-nghien-cuu';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
@NgModule({
  declarations: [
        TongHopBaoCaoTienDoNghienCuuPage,
  ],
  imports: [
    NgxDatatableModule,
      IonicPageModule.forChild(TongHopBaoCaoTienDoNghienCuuPage)
  ],
  exports: [
      TongHopBaoCaoTienDoNghienCuuPage
  ]
})
export class TongHopBaoCaoTienDoNghienCuuPageModule {}
