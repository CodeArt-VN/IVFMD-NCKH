import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PhieuXemXetDaoDucModalPage } from './phieu-xem-xet-dao-duc-modal';

@NgModule({
  declarations: [
    PhieuXemXetDaoDucModalPage,
  ],
  imports: [
      IonicPageModule.forChild(PhieuXemXetDaoDucModalPage)
  ],
  exports: [
    PhieuXemXetDaoDucModalPage
  ]
})
export class PhieuXemXetDaoDucModalPageModule {}
