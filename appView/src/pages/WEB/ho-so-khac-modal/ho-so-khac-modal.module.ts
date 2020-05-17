import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { HoSoKhacModalPage } from './ho-so-khac-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
import { FileUploadModule } from 'ng2-file-upload';
@NgModule({
  declarations: [
        HoSoKhacModalPage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      FileUploadModule,
      IonicPageModule.forChild(HoSoKhacModalPage)
  ],
  exports: [
      HoSoKhacModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HoSoKhacModule {}
