import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { CatePage } from './cate';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    CatePage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(CatePage),
  ],
  exports: [
    CatePage
  ]
})
export class CatePageModule {}
