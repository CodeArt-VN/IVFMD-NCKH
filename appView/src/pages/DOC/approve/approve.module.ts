import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ApprovePage } from './approve';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    ApprovePage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(ApprovePage),
  ],
  exports: [
    ApprovePage
  ]
})
export class ApprovePageModule {}
