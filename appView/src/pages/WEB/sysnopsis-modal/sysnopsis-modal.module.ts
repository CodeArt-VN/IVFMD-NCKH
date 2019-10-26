import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SysnopsisModalPage } from './sysnopsis-modal';

@NgModule({
    declarations: [
        SysnopsisModalPage,
    ],
    imports: [
        IonicPageModule.forChild(SysnopsisModalPage)
    ],
    exports: [
        SysnopsisModalPage
    ]
})
export class SysnopsisModalPageModule { }
