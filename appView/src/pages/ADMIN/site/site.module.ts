import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SitePage } from './site';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    SitePage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(SitePage),
  ],
  exports: [
    SitePage
  ]
})
export class SitePageModule {}
