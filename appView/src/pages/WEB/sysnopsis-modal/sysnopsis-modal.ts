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
    model: any;
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
        this.currentProvider.getItemCustom(this.idDeTai).then((ite) => {
            //this.commonService.copyPropertiesValue(ite, this.item);
            this.item = ite;
            this.loadedData();
        }).catch((data) => {
            this.item.ID = 0;
            this.loadedData();
        });
    }

    loadedData() {
        ko.cleanNode($('#frmSynopsis')[0]);
        this.bindData();
    }
    dismiss() {
        let data = { 'foo': 'bar' };
        this.viewCtrl.dismiss(data);
    }

    bindData() {
        $("#frmSynopsis").empty();
        $(this.item.HTML).appendTo("#frmSynopsis");
        let id = this.item.ID;
        var that = this;
        ko.bindingHandlers.editableHTML = {
            init: function (element, valueAccessor) {
                var $element = $(element);
                var initialValue = ko.utils.unwrapObservable(valueAccessor());
                if (id <= 0)
                    $element.html(initialValue);
                $element.on('keyup', function () {
                    var observable = valueAccessor();
                    observable($element.html());
                });
            }
        };

        let SynopsisModel = function (item) {
            var self = this;
            that.commonService.copyPropertiesValue(item, self);
            self.StudyTitle = ko.observable(item.StudyTitle);
            self.Investigators = ko.observable(item.Investigators);
            self.BackgroundAims = ko.observable(item.BackgroundAims);
            self.Objectives = ko.observable(item.Objectives);
            self.StudyDesign = ko.observable(item.StudyDesign);
            self.StudyPopulation = ko.observable(item.StudyPopulation);
            self.Endpoint = ko.observable(item.Endpoint);
            self.PrimaryEndpoint = ko.observable(item.PrimaryEndpoint);
            self.SecondaryEndpoint = ko.observable(item.SecondaryEndpoint);
            self.MainEligibilityCriteria = ko.observable(item.MainEligibilityCriteria);
            self.InclusionCriteria = ko.observable(item.InclusionCriteria);
            self.ExclusionCriteria = ko.observable(item.ExclusionCriteria);
            self.DataAnalysis = ko.observable(item.DataAnalysis);
            self.References = ko.observable(item.References);

            self.getItem = function () {
                return ko.toJS(self);
            };
        }
        this.model = new SynopsisModel(this.item);
        ko.applyBindings(this.model, document.getElementById("frmSynopsis"));
    };

    saveChange() {
        let item = this.model.getItem();
        item.HTML = $("#frmSynopsis").html();
        console.log(item);
        this.loadingMessage('Lưu dữ liệu...').then(() => {
            this.currentProvider.save(item).then((savedItem: any) => {
                this.item.ID = savedItem.ID;
                this.model.ID = savedItem.ID;
                if (this.loading) this.loading.dismiss();
                this.events.publish('app:Update' + this.pageName);
                console.log('publish => app:Update ' + this.pageName);
                //this.goBack();
                this.toastMessage('Đã lưu xong!');
            }).catch(err => {
                console.log(err);
                if (this.loading) this.loading.dismiss();
                this.toastMessage('Không lưu được, \nvui lòng thử lại.');
            });
        })
    };
}