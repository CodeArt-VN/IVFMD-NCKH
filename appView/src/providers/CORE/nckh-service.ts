import { Injectable } from '@angular/core';
import * as $ from 'jquery';
import * as ko from 'knockout';

@Injectable()
export class NCKHServiceProvider {
    constructor() {
	}
	init() {
        $(".ptable").on("click", ".clone", function (e) {
            var sconf = $(e.currentTarget).closest(".ptable").attr("conf");
            if (sconf != null) {
                try {
                    var conf = JSON.parse(sconf);
                    if (conf.add) {
                        var context = ko.contextFor(this);
                        context.$root.addItem(conf.name, conf.props);
                    }
                    return false;
                } catch (e) {
                    console.error(e);
                    return false;
                }
            }
        });
        $(".ptable").on("click", ".remove", function (e) {
            var target = window.getSelection().anchorNode;
            var sconf = $(e.currentTarget).closest(".ptable").attr("conf");
            // @ts-ignore
            if (sconf != null && (target.parentElement.tagName == "TD" || target.parentElement.tagName == "TR")) {
                try {
                    var conf = JSON.parse(sconf);
                    if (conf.add) {
                        var tr = $(target).closest('tr');
                        var context = ko.contextFor(this);
                        context.$root.removeItem(conf.name, tr.attr('index'));
                    }
                    return false;
                } catch (e) {
                    console.error(e);
                    return false;
                }
            }
        });
    
        var popConrtrol = $('<div class="group_controls" style="position:absolute;top:-24px;right:0;border:1px solid red">' +
            '<div class="fieldgroup_controls">' +
            '<button style="line-height:20px" class="remove"><i class="fa fa-minus"></i> Xóa</button>' +
            '<button style="line-height:20px" class="clone"><i class="fa fa-plus"></i> Thêm</button>' +
            '</div>' +
            '</div>');
        $(".ptable").mouseenter(function (event) {
            try {
                var sconf = this.attributes["conf"].value;
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.add || conf.remove) {
                        var t = $(this).find(".group_controls");
                        if (t.length == 0) {
                            popConrtrol.appendTo($(this));
                        }
                    }
                }
            } catch (e) {
                console.error(e);
                return false;
            }
        }).mouseleave(function (event) {
            var t = $(this).find(".group_controls");
            t.detach();
        });
	}
}