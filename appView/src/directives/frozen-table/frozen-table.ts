import { Directive, ElementRef, Renderer, NgZone } from '@angular/core';


@Directive({
    selector: '[frozen-table]' // Attribute selector
})
export class FrozenTableDirective {
    body: any;
    sidebar: any;
    header: any;
    headerFix: any;
    headerTable: any;
    sidebarTable: any;

    raf: any;

    lastScrollTop = 0;
    lastScrollLeft = 0;

    constructor(public el: ElementRef, public renderer: Renderer, private ngZone: NgZone) { }

    private running: boolean;

    ngOnInit() {
        this.running = true;
        this.body = this.el.nativeElement.querySelector('.frozenTable-body');

        this.sidebar = this.el.nativeElement.querySelector('.frozenTable-sidebar');
        this.header = this.el.nativeElement.querySelector('.frozenTable-header');
        this.headerFix = this.el.nativeElement.querySelector('.frozenTable-header-fix');
        this.headerTable = this.header.querySelector('table');
        this.sidebarTable = this.sidebar.querySelector('table');

        this.raf = window.requestAnimationFrame || window.webkitRequestAnimationFrame || function( callback ){
            window.setTimeout(callback, 1000 / 60);
        };
        
        // if (this.raf) {
        //     this.ngZone.runOutsideAngular(() => this.loop());
        //     console.log('requestAnimationFrame <== start');
        // } else {

            console.log('requestAnimationFrame <== false');
            this.body.addEventListener('scroll', () => {
                var scrollTop = this.body.scrollTop;
                var scrollLeft = this.body.scrollLeft;
                this.ngZone.runOutsideAngular(() => this.scroll(scrollTop, scrollLeft));
            });
        //}
    }

    ngOnDestroy() {
        this.running = false;
        console.log('requestAnimationFrame <== stop');
    }

    ngAfterContentInit() {

    }

    loop() {

        var scrollTop = this.body.scrollTop;
        var scrollLeft = this.body.scrollLeft;

        if (this.lastScrollTop === scrollTop && this.lastScrollLeft === scrollLeft) {
            this.raf(this.loop.bind(this));
            return;
        } else {
            this.lastScrollTop = scrollTop;
            this.lastScrollLeft = scrollLeft;

            this.scroll(scrollTop, scrollLeft);
            this.raf(this.loop.bind(this));
        }
    }

    scroll(scrollTop, scrollLeft) {
        if (scrollLeft == 0)
            this.sidebar.classList.remove("scrolling-x");
        else
            this.sidebar.classList.add("scrolling-x");

        if (scrollTop == 0) {
            this.headerFix.classList.remove("scrolling-y");
            this.header.classList.remove("scrolling-y");
        }
        else {
            this.headerFix.classList.add("scrolling-y");
            this.header.classList.add("scrolling-y");
        }
        this.sidebarTable.setAttribute('style', 'transform: translate3d(0px, -' + scrollTop + 'px, 0px);');
        this.headerTable.setAttribute('style', 'transform: translate3d(-' + scrollLeft + 'px, 0px, 0px);');

        // this.sidebarTable.setAttribute('style', 'margin-top: -' + scrollTop + 'px;');
        // this.headerTable.setAttribute('style', 'margin-left: -' + scrollLeft + 'px;');

        // this.sidebarTable.setAttribute('style', 'top: -' + scrollTop + 'px;');
        // this.headerTable.setAttribute('style', 'left: -' + scrollLeft + 'px;');

    };

}
