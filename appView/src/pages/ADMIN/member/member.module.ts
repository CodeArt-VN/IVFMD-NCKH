import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { MemberPage } from './member';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    MemberPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(MemberPage),
  ],
  exports: [
    MemberPage
  ]
})
export class MemberPageModule {}
