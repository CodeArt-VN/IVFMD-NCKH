import { Component } from '@angular/core';
import { ViewController, IonicPage, NavController, NavParams, Events, LoadingController, ToastController, AlertController } from 'ionic-angular';
import { FormBuilder, Validators } from '@angular/forms';
import { AccountServiceProvider } from '../../../providers/CORE/account-service';
import { PRO_SysnopsisCustomProvider } from '../../../providers/Services/CustomService';
import { CommonServiceProvider } from '../../../providers/CORE/common-service';
import { DetailPage } from '../../detail-page';
import 'jqueryui';
import * as $ from 'jquery';
import * as ko from 'knockout';
@IonicPage({ name: 'page-sysnopsis-modal', priority: 'high', defaultHistory: ['page-sysnopsis-modal'] })
@Component({
    selector: 'sysnopsis-modal',
    templateUrl: 'sysnopsis-modal.html',
})
export class SysnopsisModalPage extends DetailPage {
    idDeTai: any;
    constructor(
        public currentProvider: PRO_SysnopsisCustomProvider,
        public viewCtrl: ViewController,
        public navCtrl: NavController, public navParams: NavParams, public events: Events, public toastCtrl: ToastController, public loadingCtrl: LoadingController, public alertCtrl: AlertController, public formBuilder: FormBuilder, public commonService: CommonServiceProvider, public accountService: AccountServiceProvider,
    ) {
        super('page-sysnopsis-modal', null, currentProvider, navCtrl, navParams, events, toastCtrl, loadingCtrl, alertCtrl, commonService, accountService, formBuilder);
        this.pageName = "page-sysnopsis-modal";
        this.events.unsubscribe('app:Close-page-sysnopsis-modal');
        this.events.subscribe('app:Close-page-sysnopsis-modal', () => {
            this.dismiss();
        });
        this.idDeTai = navParams.get('idDeTai');
        if (this.idDeTai && commonService.isNumeric(this.idDeTai)) {
            this.idDeTai = parseInt(this.idDeTai, 10);
        }
    }

    loadData() {
        this.currentProvider.getItemCustom(this.id, this.idDeTai).then((ite) => {
            this.commonService.copyPropertiesValue(ite, this.item);
            super.loadData();
        }).catch((data) => {
            this.item.ID = 0;
            super.loadData();
        });
    }

    loadedData() {
        ko.cleanNode($('#frm111')[0]);
        this.bindData();
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
                    var observable = valueAccessor();
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
    };
}