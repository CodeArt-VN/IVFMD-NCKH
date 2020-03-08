import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { TienDoNghienCuuModalPage } from './tien-do-nghien-cuu-modal';

@NgModule({
  declarations: [
    TienDoNghienCuuModalPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(TienDoNghienCuuModalPage),
  ],
  exports: [
    TienDoNghienCuuModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class TienDoNghienCuuModalPageModule {}