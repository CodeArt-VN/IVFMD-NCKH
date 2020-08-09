import { Component } from '@angular/core';
import { IonicPage, NavParams, Events, ViewController } from 'ionic-angular';
import { GlobalData } from '../../../providers/CORE/global-variable';
@IonicPage({name: 'page-popover', segment: 'popover', priority: 'high',})
@Component({selector: 'page-popover',templateUrl: 'popover.html',})


export class PopoverPage {
    popid = '';
    version = GlobalData.Version;
    //user cp
    isAdminItems = null; 
    isDocItems = null;

    //share file + folder
    link = ""; 

    //cate menu
    menuList:any[] = null; 
    currentCateID = 0;



    constructor(public navParams: NavParams, public events: Events, public viewCtrl: ViewController) {
    }

    ngOnInit() {
        if (this.navParams.data) {
            this.popid = this.navParams.data.popid;

            //share file + folder
            this.link = this.navParams.data.link;

            //user cp
            this.isAdminItems = this.navParams.data.isAdminItems;
            this.isDocItems = this.navParams.data.isDocItems;
            
            //cate menu
            this.menuList = this.navParams.data.menuList;
            this.currentCateID = this.navParams.data.currentCateID;


        }
    }

    command(action) {
        this.viewCtrl.dismiss(action);
    }

    copyToClipboard(element) {
        let input = element.getNativeElement().querySelector('input');
        input.select();
        document.execCommand('copy');
        this.command('copied');
    }
}
