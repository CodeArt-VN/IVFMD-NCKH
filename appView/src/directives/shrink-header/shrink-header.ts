import { Directive, Input, ElementRef, Renderer } from '@angular/core';

@Directive({
	selector: '[shrink-header]' // Attribute selector
	
})
export class ShrinkHeaderDirective {
	@Input('default-height') defaultHeight: number;

	scrollerHandle: any;
	header: any;
	ticking: any;
	showShadow = false;

	constructor(public element: ElementRef, public renderer: Renderer) {

	}

	ngOnInit() {

		this.scrollerHandle = this.element.nativeElement.parentElement.getElementsByClassName('scroll-content')[0];
		this.header = this.element.nativeElement;
		this.ticking = false;
		this.renderer.setElementStyle(this.header, 'height', this.defaultHeight + 'px');
		this.scrollerHandle.addEventListener('scroll', () => {

			if (!this.ticking) {
				window.requestAnimationFrame(() => {
					this.calcElement();
				});
			}
			this.ticking = true;
		});

	}

	calcElement() {
		let calcHeight = this.defaultHeight - this.scrollerHandle.scrollTop;
		let headerHeight = calcHeight;
		if (calcHeight < 120 && calcHeight >= 60) {
			headerHeight = calcHeight;
		}
		else if (calcHeight < 60) {
			headerHeight = 60;
		}
		else {
			headerHeight = 120;
		}

		if(headerHeight < 120 && !this.showShadow){
			this.renderer.setElementStyle(this.header, 'box-shadow', '0 1px 16px rgba(3, 124, 197, 0.25882352941176473)');
			this.showShadow = true;
		}
		else if(headerHeight >= 120 && this.showShadow){
			this.renderer.setElementStyle(this.header, 'box-shadow', 'none');
			this.showShadow = false
		}


		this.renderer.setElementStyle(this.header, 'height', headerHeight + 'px');
		this.renderer.setElementStyle(this.scrollerHandle, 'margin-top',headerHeight + 'px');
		this.ticking = false;
	}
}
