import { IonicPageModule } from 'ionic-angular';
import { BangGiaKinhPhiModalPage } from './bang-gia-kinh-phi-modal';
import { MatDatepickerModule, MatNativeDateModule } from '@angular/material';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
@NgModule({
  declarations: [
    BangGiaKinhPhiModalPage,
    ],
    imports: [
        NgxDatatableModule,
        MatDatepickerModule,
        MatNativeDateModule,
        IonicPageModule.forChild(BangGiaKinhPhiModalPage)
    ],
    exports: [
        BangGiaKinhPhiModalPage
    ],
    schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class BangGiaKinhPhiModalPageModule { }
