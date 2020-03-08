import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoDangKyDeTaiModalPage } from './hoi-nghi-hoi-thao-dang-ky-de-tai-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
import { FileUploadModule } from 'ng2-file-upload';
@NgModule({
  declarations: [
        HoiNghiHoiThaoDangKyDeTaiModalPage
  ],
  imports: [
    NgxDatatableModule,
    MatDatepickerModule,
      MatNativeDateModule,
      FileUploadModule,
      IonicPageModule.forChild(HoiNghiHoiThaoDangKyDeTaiModalPage)
  ],
  exports: [
      HoiNghiHoiThaoDangKyDeTaiModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HoiNghiHoiThaoDangKyDeTaiModalPageModule { }
