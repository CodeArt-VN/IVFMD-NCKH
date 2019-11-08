import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';

/**
 * Generated class for the DeTaiDetailPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */
@IonicPage({ name: 'page-de-tai-detail', segment: 'de-tai-detail', priority: 'high' }) 
@Component({
  selector: 'page-de-tai-detail',
  templateUrl: 'de-tai-detail.html',
})
export class DeTaiDetailPage {

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad DeTaiDetailPage');
  }

}
