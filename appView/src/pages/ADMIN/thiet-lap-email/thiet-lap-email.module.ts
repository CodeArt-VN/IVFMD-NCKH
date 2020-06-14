import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ThietLapEmailPage } from './thiet-lap-email';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
import { FileUploadModule } from 'ng2-file-upload';
@NgModule({
  declarations: [
        ThietLapEmailPage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      IonicPageModule.forChild(ThietLapEmailPage),
      FileUploadModule
  ],
  exports: [
      ThietLapEmailPage
    ],
    schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class ThietLapTemplatePageModule {}
