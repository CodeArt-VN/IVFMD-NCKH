import { NgModule } from '@angular/core';
import { MyPipe, filterProperties, isNotDeleted, SafeHtml, SafeStyle, SafeFrame } from './filter/filter';
@NgModule({
	declarations: [MyPipe, filterProperties, isNotDeleted, SafeHtml, SafeStyle, SafeFrame ],
	imports: [],
	exports: [MyPipe, filterProperties, isNotDeleted, SafeHtml, SafeStyle, SafeFrame]
})
export class PipesModule {}
