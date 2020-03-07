import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ThietLapTemplatePage } from './thiet-lap-template';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
import { FileUploadModule } from 'ng2-file-upload';
@NgModule({
  declarations: [
        ThietLapTemplatePage,
  ],
  imports: [
      NgxDatatableModule,
      MatDatepickerModule,
      MatNativeDateModule,
      IonicPageModule.forChild(ThietLapTemplatePage),
      FileUploadModule
  ],
  exports: [
      ThietLapTemplatePage
    ],
    schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class ThietLapTemplatePageModule {}
