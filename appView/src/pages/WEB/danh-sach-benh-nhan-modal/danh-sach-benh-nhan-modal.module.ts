import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { DanhSachBenhNhanModalPage } from './danh-sach-benh-nhan-modal';

@NgModule({
  declarations: [
    DanhSachBenhNhanModalPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(DanhSachBenhNhanModalPage),
  ],
  exports: [
    DanhSachBenhNhanModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class DanhSachBenhNhanModalPageModule {}