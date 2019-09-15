import { NgModule } from '@angular/core';
import { FrozenTableDirective } from './frozen-table/frozen-table';
import { InputMaskDirective } from './input-mask/input-mask'
import { WebMenuDirective } from './web-menu/web-menu';
import { ShrinkHeaderDirective } from './shrink-header/shrink-header';

@NgModule({
	declarations: [FrozenTableDirective, InputMaskDirective,
    WebMenuDirective,
    ShrinkHeaderDirective],
	imports: [],
	exports: [FrozenTableDirective, InputMaskDirective,
    WebMenuDirective,
    ShrinkHeaderDirective]
})
export class DirectivesModule {}
