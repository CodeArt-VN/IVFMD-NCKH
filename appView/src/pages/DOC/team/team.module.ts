import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { TeamPage } from './team';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { PipesModule } from '../../../pipes/pipes.module';

@NgModule({
  declarations: [
    TeamPage,
  ],
  imports: [
    NgxDatatableModule,
    IonicPageModule.forChild(TeamPage), PipesModule
  ],
  exports: [
    TeamPage
  ]
})
export class TeamPageModule {}
