import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoiNghiHoiThaoPage } from './hoi-nghi-hoi-thao';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
@NgModule({
  declarations: [
        HoiNghiHoiThaoPage,
  ],
  imports: [
    NgxDatatableModule,
      IonicPageModule.forChild(HoiNghiHoiThaoPage)
  ],
  exports: [
      HoiNghiHoiThaoPage
  ]
})
export class HoiNghiHoiThaoPageModule {}
