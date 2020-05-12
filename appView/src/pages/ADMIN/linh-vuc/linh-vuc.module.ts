import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { LinhVucPage } from './linh-vuc';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    LinhVucPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(LinhVucPage),
  ],
  exports: [
    LinhVucPage
  ]
})
export class LinhVucPageModule {}
