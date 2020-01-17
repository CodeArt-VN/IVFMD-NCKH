import { Component } from '@angular/core';
import { IonicPage, NavController, Events, NavParams } from 'ionic-angular';

@IonicPage({ name: '*', segment: ':**' })
@Component({ selector: 'page-not-found', templateUrl: 'not-found.html' })

export class NotFoundPage {
    show404 = false;
    constructor(
        public navCtrl: NavController,
        public events: Events,
        public navParams: NavParams,
    ) {
        events.subscribe('user:update', () => {
            this.check();
        });
    }

    ionViewDidLoad() {
        console.log('page-not-found ionViewDidLoad');
        this.check();
    }

    openDefault() {
        this.events.publish('app:openDefaultPage');
    }


    check() {
        console.log('page-check', this.navParams.data);
        if (this.navParams.data) {
            let urlcommand = this.navParams.data["**"];
            if (urlcommand && urlcommand.match(/^.*-(\d+)/)) {
                let id = urlcommand.match(/^.*-(\d+)/)[1];

                if (urlcommand.indexOf('share-folder-') > -1) {
                    this.navCtrl.setRoot("page-sops", { cmd: 'open-folder', id: id });
                    return;
                }
                else if (urlcommand.indexOf('share-file-') > -1) {
                    this.navCtrl.setRoot("page-sops", { cmd: 'open-file', id: id });
                    return;
                }
                else if (urlcommand.indexOf('view-de-tai-') > -1) {
                    this.navCtrl.setRoot('page-de-tai-detail', { 'value': 'view-de-tai-' + id });
                    return;
                }
            }
        }
        

        let pageid = this.navCtrl.getViews()[0].id;
        if (!pageid || pageid == 'n4-0') {
            console.log('go to default');
            this.events.publish('app:openDefaultPage');
        }
        else {
            this.show404 = true;
        }
    }
}
