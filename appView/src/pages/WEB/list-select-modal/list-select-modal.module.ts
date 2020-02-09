import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ListSelectModalPage } from './list-select-modal';

@NgModule({
  declarations: [
    ListSelectModalPage,
  ],
  imports: [
    IonicPageModule.forChild(ListSelectModalPage),
  ],
})
export class ListSelectModalPageModule {}
