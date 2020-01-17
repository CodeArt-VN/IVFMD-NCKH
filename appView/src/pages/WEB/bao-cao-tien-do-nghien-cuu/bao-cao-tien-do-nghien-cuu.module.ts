import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BaoCaoTienDoNghienCuuPage } from './bao-cao-tien-do-nghien-cuu';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
@NgModule({
  declarations: [
    BaoCaoTienDoNghienCuuPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(BaoCaoTienDoNghienCuuPage)
  ],
  exports: [
    BaoCaoTienDoNghienCuuPage
  ]
})
export class BaoCaoTienDoNghienCuuPageModule {}
