import { Directive } from '@angular/core';

/**
 * Generated class for the WebMenuDirective directive.
 *
 * See https://angular.io/api/core/Directive for more info on Angular
 * Directives.
 */
@Directive({
  selector: '[web-menu]' // Attribute selector
})
export class WebMenuDirective {

  constructor() {
    console.log('Hello WebMenuDirective Directive');
  }

}
