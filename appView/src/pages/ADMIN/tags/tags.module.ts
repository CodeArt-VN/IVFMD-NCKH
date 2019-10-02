import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { TagsPage } from './tags';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    TagsPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(TagsPage),
  ],
  exports: [
    TagsPage
  ]
})
export class TagsPageModule {}
