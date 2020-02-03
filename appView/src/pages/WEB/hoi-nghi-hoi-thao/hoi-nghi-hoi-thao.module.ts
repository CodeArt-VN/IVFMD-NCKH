import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoPage } from './hoi-nghi-hoi-thao';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { FileUploadModule } from 'ng2-file-upload';
@NgModule({
  declarations: [
        HoiNghiHoiThaoPage,
  ],
  imports: [
    NgxDatatableModule,
      IonicPageModule.forChild(HoiNghiHoiThaoPage), FileUploadModule
  ],
  exports: [
      HoiNghiHoiThaoPage
  ]
})
export class HoiNghiHoiThaoPageModule {}
