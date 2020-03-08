import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoDanhSachDangKyModalPage } from './hoi-nghi-hoi-thao-danh-sach-dang-ky-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
@NgModule({
  declarations: [
        HoiNghiHoiThaoDanhSachDangKyModalPage,
  ],
  imports: [
      NgxDatatableModule,
      IonicPageModule.forChild(HoiNghiHoiThaoDanhSachDangKyModalPage)
  ],
  exports: [
      HoiNghiHoiThaoDanhSachDangKyModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HoiNghiHoiThaoDanhSachDangKyModalPageModule {}
