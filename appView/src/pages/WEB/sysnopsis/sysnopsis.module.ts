import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { SysnopsisPage } from './sysnopsis';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
    declarations: [
        SysnopsisPage,
    ],
    imports: [
        NgxDatatableModule,
        IonicPageModule.forChild(SysnopsisPage),
    ],
    exports: [
        SysnopsisPage
    ]
})
export class SysnopsisPageModule { }
