import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { BasePage } from '../../base-page';
import { PRO_SysnopsisCustomProvider } from '../../../providers/Services/CustomService';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { observable } from 'knockout';

@IonicPage({ name: 'page-sysnopsis-modal', priority: 'high', defaultHistory: ['page-de-tai'] })
@Component({
    selector: 'sysnopsis-modal',
    templateUrl: 'sysnopsis-modal.html',
})
export class SysnopsisModalPage extends BasePage {
    id: any;
    idDetai: any;
    item: any;
    constructor(
        public currentProvider: PRO_SysnopsisCustomProvider,
        public navCtrl: NavController,
        public viewCtrl: ViewController,
        public navParams: NavParams,
        public events: Events,
        public toastCtrl: ToastController,
        public loadingCtrl: LoadingController,
        public alertCtrl: AlertController,
        public commonService: CommonServiceProvider,
        public accountService: AccountServiceProvider,
    ) {
        super('', '', currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService);
        this.pageName = "page-de-tai";
        this.events.unsubscribe('app:Close-page-sysnopsis-modal');
        this.events.subscribe('app:Close-page-sysnopsis-modal', () => {
            this.dismiss();
        });
        
        this.id = navParams.get('id');
        if (this.id && commonService.isNumeric(this.id)) {
            this.id = parseInt(this.id, 10);
        }
        this.idDetai = navParams.get('idDetai');
        if (this.idDetai && commonService.isNumeric(this.idDetai)) {
            this.idDetai = parseInt(this.idDetai, 10);
        }
        if (this.idDetai == undefined || this.id == undefined) {
            commonService.getLocal('page-sysnopsis-modal').then(item => {
                if (commonService.isNumeric(item.id)) {
                    this.id = parseInt(item.id, 10);
                }
                if (commonService.isNumeric(item.idDetai)) {
                    this.idDetai = parseInt(item.idDetai, 10);
                }
            });
        }
        if (!this.item) {
            this.item = {}
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.id, this.idDetai).then((ite) => {
            this.commonService.copyPropertiesValue(ite, this.item);
            this.bindData();


        }).catch((data) => {
            this.item.ID = 0;
        });
    }

    loadedData() {

    }

    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $(this.item.HTML).appendTo("#frm111");
        debugger
        ko.bindingHandlers.editableHTML = {
            init: function (element, valueAccessor) {
                var $element = $(element);
                var initialValue = ko.utils.unwrapObservable(valueAccessor());
                $element.html(initialValue);
                $element.on('keyup', function () {
                    //observable = valueAccessor();
                    observable($element.html());
                });
            }
        };

        var SynopsisModel = function () {
            var self = this;
            self.study_title = ko.observable("");
            self.investigators = ko.observable("");
            self.backgroud_and_aims = ko.observable("<br><br><br><br>");
            self.objectives = ko.observable("<br><br><br><br>");
            self.study_design_and_oversight = ko.observable("");
            self.study_population = ko.observable("");
            self.endpoints = ko.observable("");
            self.primary_endpoints = ko.observable("");
            self.secondary_endpoints = ko.observable("");
            self.main_eligibility_criteria = ko.observable("");
            self.inclusion_criteria = ko.observable("");
            self.exclusion_criteria = ko.observable("");
            self.data_analysis_and_statistics = ko.observable("");
            self.references = ko.observable("");

            self.savedJson = ko.observable("");
            self.save = function () {
                self.savedJson(JSON.stringify(ko.toJS(self), null, 2));
            };
        }
        var model = new SynopsisModel();
        ko.applyBindings(model, document.getElementById("frmSynopsis"));
    }
}