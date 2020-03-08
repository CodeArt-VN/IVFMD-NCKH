import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoHRCOPage } from './hoi-nghi-hoi-thao-hrco';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { FileUploadModule } from 'ng2-file-upload';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
@NgModule({
  declarations: [
        HoiNghiHoiThaoHRCOPage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      IonicPageModule.forChild(HoiNghiHoiThaoHRCOPage), FileUploadModule
  ],
  exports: [
      HoiNghiHoiThaoHRCOPage
  ]
})
export class HoiNghiHoiThaoHRCOPageModule {}
