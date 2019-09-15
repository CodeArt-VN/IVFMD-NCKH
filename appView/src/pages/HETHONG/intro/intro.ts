import { Component, ViewChild } from '@angular/core';
import { IonicPage, NavController, NavParams, Events, Slides, MenuController } from 'ionic-angular';
import { Storage } from '@ionic/storage';

@IonicPage({
    name: 'page-intro',
    segment: 'intro',
    priority: 'high',
})
@Component({
  selector: 'page-intro',
  templateUrl: 'intro.html',
})
export class IntroPage {
    @ViewChild('mySlider') slider: Slides;

    constructor(
        public navCtrl: NavController,
        public navParams: NavParams,
        public menu: MenuController,
		public storage: Storage,
        public events: Events
    ) {

    }
    slides = [
		{
			title: "Kết quả đột phá!",
			description: "Tỉ lệ nhớ sau khi học <b>trên 80%</b> lớn hơn rất nhiều so với các phương pháp hiện tại (2-10%).",
			image: "./assets/imgs/intro/ica-slidebox-img-1.png",
		},
		{
			title: "Khác biệt vượt trội",
			description: "Nhờ phương pháp <b>học siêu tốc</b>, bạn có thể thu nạp một lượng lớn từ vựng <b>trong thời gian ngắn</b>, từ đó sẽ giúp bạn luyện nghe dễ dàng hơn.",
			image: "./assets/imgs/intro/ica-slidebox-img-2.png",
		},
		{
			title: "Học nhanh nhớ lâu",
			description: "Trên thực tế các bạn thấy 10% là tiếng Anh. Với 90% còn lại là các nguyên tắc vận hành của não bộ trong việc lưu trữ và xử lý thông tin...",
			image: "./assets/imgs/intro/ica-slidebox-img-3.png",
		}
    ];
    goToEnd() {
		this.slider.slideTo(3, 300);
	}

	goBack(page) {
		this.storage.set('hasSeenTutorial', 'true');
		
	}

    ionViewDidLoad() {
        this.events.publish('app:changeMenu', "page-intro");
        this.menu.enable(false);
    }
    ionViewDidEnter() {
        this.menu.enable(false);
      }
    
      ionViewDidLeave() {
        this.menu.enable(true);
      }
}
