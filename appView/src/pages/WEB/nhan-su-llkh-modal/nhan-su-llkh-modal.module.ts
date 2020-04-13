import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NhanSuLLKHModalPage } from './nhan-su-llkh-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import {MatDatepickerModule, MatNativeDateModule } from '@angular/material';

@NgModule({
    declarations: [
      NhanSuLLKHModalPage,
    ],
    imports: [
      NgxDatatableModule,
    MatDatepickerModule,
    MatNativeDateModule,
        IonicPageModule.forChild(NhanSuLLKHModalPage)
    ],
    exports: [
      NhanSuLLKHModalPage
    ]
})
export class NhanSuLLKHModalPageModule { }
