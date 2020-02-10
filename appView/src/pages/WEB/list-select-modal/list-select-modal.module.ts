import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ListSelectModalPage } from './list-select-modal';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
@NgModule({
  declarations: [
    ListSelectModalPage,
  ],
  imports: [
      NgxDatatableModule,
      IonicPageModule.forChild(ListSelectModalPage)
  ],
  exports: [
    ListSelectModalPage
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class ListSelectModalPageModule {}
