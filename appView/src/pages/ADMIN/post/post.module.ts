import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PostPage } from './post';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
  declarations: [
    PostPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(PostPage),
  ],
  exports: [
    PostPage
  ]
})
export class PostPageModule {}
