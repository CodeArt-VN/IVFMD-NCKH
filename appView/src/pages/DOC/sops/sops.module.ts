import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SopsPage } from './sops';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    SopsPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(SopsPage),
  ],
  exports: [
    SopsPage
  ]
})
export class SopsPageModule {}
