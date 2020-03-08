import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoDanhSachDeTaiModalPage } from './hoi-nghi-hoi-thao-danh-sach-de-tai-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
@NgModule({
  declarations: [
        HoiNghiHoiThaoDanhSachDeTaiModalPage,
  ],
  imports: [
      NgxDatatableModule,
      IonicPageModule.forChild(HoiNghiHoiThaoDanhSachDeTaiModalPage)
  ],
  exports: [
      HoiNghiHoiThaoDanhSachDeTaiModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HoiNghiHoiThaoDanhSachDeTaiModalPageModule {}
