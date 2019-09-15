import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { RolePage } from './role';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    RolePage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(RolePage),
  ],
  exports: [
    RolePage
  ]
})
export class RolePageModule {}
