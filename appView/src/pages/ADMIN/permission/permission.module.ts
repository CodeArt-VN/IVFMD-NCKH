import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PermissionPage } from './permission';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    PermissionPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(PermissionPage),
  ],
  exports: [
    PermissionPage
  ]
})
export class PermissionPageModule {}
