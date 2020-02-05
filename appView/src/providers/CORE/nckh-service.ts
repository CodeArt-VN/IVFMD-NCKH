import { Injectable } from '@angular/core';
import * as $ from 'jquery';
import * as ko from 'knockout';

@Injectable()
export class NCKHServiceProvider {
    constructor() {
    }
    init() {
        var me = this;
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
        $(".ptable,.pblock").on("click", ".clone", function (e) {
            var sconf = $(e.currentTarget).closest(".pconf").attr("conf");
            if (sconf != null) {
                try {
                    var conf = JSON.parse(sconf);
                    if (conf.add) {
                        var target = window.getSelection().anchorNode;
                        if (!target) {
                            var context = ko.contextFor(this);
                            me.addItem(context, conf.name, conf.props, null, null);
                        }
                        // @ts-ignore
                        else {
                            var sconf1 = $(target).closest(".pconf").attr("conf");
                            if (sconf1 == null) {
                                var context = ko.contextFor(this);
                                me.addItem(context, conf.name, conf.props, null, null);
                            } else {
                                try {
                                    var conf1 = JSON.parse(sconf1);
                                    if (conf1.name === conf.name) {
                                        if (target.parentElement.tagName == "TD" || target.parentElement.tagName == "TR") {
                                            var tr = $(target).closest('tr');
                                            var context = ko.contextFor(this);
                                            var obj = ko.contextFor(tr[0]).$data;
                                            me.addItem(context, conf.name, conf.props, obj, tr.attr('values'));
                                        } else if ($(target).closest('.prow')) {
                                            var row = $(target).closest('.prow');
                                            var context = ko.contextFor(this);
                                            var obj = ko.contextFor(row[0]).$data;
                                            me.addItem(context, conf.name, conf.props, obj, tr.attr('values'));
                                        }
                                    } else {
                                        var context = ko.contextFor(this);
                                        me.addItem(context, conf.name, conf.props, null, null);
                                    }
                                } catch (e) {
                                }
                            }
                        }
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
            if (target) {
                var sconf = $(e.currentTarget).closest(".ptable").attr("conf");
                var sconf1 = $(target).closest(".ptable").attr("conf");
                if (sconf != null && sconf1 != null && (target.parentElement.tagName == "TD" || target.parentElement.tagName == "TR")) {
                    try {
                        var conf = JSON.parse(sconf);
                        var conf1 = JSON.parse(sconf1);
                        if (conf.name === conf1.name && conf.add) {
                            var tr = $(target).closest('tr');
                            if (tr.attr('removeable') == "1" || tr.attr('removeable') == "true") {
                                var context = ko.contextFor(this);
                                var obj = ko.contextFor(tr[0]).$data;
                                me.removeItem(context, conf.name, obj);
                            }
                        }
                        return false;
                    } catch (e) {
                        console.error(e);
                        return false;
                    }
                }
            }
        });
        $(".pblock").on("click", ".remove", function (e) {
            var target = window.getSelection().anchorNode;
            if (target) {
                var sconf = $(e.currentTarget).closest(".pconf").attr("conf");
                var sconf1 = $(target).closest(".pconf").attr("conf");
                if (sconf != null && sconf1 != null) {
                    try {
                        var conf = JSON.parse(sconf);
                        var conf1 = JSON.parse(sconf1);
                        if (conf.name === conf1.name && conf.add) {
                            var row = $(target).closest('.prow');
                            if (row.attr('removeable') == "1" || row.attr('removeable') == "true") {
                                var context = ko.contextFor(this);
                                var obj = ko.contextFor(row[0]).$data;
                                me.removeItem(context, conf.name, obj);
                            }
                        }
                        return false;
                    } catch (e) {
                        console.error(e);
                        return false;
                    }
                }
            }
        });
        var ptablePopConrtrol = $('<div class="group_controls" style="position:absolute;top:-24px;right:0;border:1px solid red">' +
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
                            ptablePopConrtrol.appendTo($(this));
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

        var prowPopConrtrol = $('<div class="group_controls" style="position:absolute;top:0;right:0;border:1px solid red">' +
            '<div class="fieldgroup_controls">' +
            '<button style="line-height:20px" class="remove"><i class="fa fa-minus"></i> Xóa</button>' +
            '</div>' +
            '</div>');
        var pblockPopConrtrol = $('<div class="group_controls" style="position:absolute;top:0;right:0;border:1px solid red">' +
            '<div class="fieldgroup_controls">' +
            '<button style="line-height:20px" class="clone"><i class="fa fa-plus"></i> Thêm</button>' +
            '</div>' +
            '</div>');
        $(".pblock").mouseenter(function (event) {
            try {
                var sconf = this.attributes["conf"].value;
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.add || conf.remove) {
                        var t = $(this).find(".group_controls");
                        if (t.length == 0) {
                            pblockPopConrtrol.appendTo($(this));
                            event.stopPropagation()
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

        $(".pblock").on("mouseenter", ".prow", function (event) {
            try {
                var sconf = this.attributes["conf"].value;
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.remove) {
                        var t = $(this).find(".group_controls");
                        if (t.length == 0) {
                            prowPopConrtrol.appendTo($(this));
                        }
                    }
                }
            } catch (e) {
                console.error(e);
                return false;
            }
        });
        $(".pblock").on("mouseleave", ".prow", function (event) {
            var t = $(this).find(".group_controls");
            t.detach();
        });
    }
    observableSimpleArray(arr) {
        return ko.observableArray($.map(arr, function (str) {
            return {
                data: ko.observable(str)
            };
        }));
    }
    stringifySimpleArray(arr) {
        return ko.computed(function () {
            return JSON.stringify($.map(arr, function (str) { return str.data(); }));
        });
    }
    getItem(context) {
        try {
            return ko.toJS(context.$root);
        } catch (e) {
            console.error(e);
        }
        return false;
    }
    addItem(context, name, props, curr, k) {
        try {
            var model = context.$root;
            if (model[name]) {
                if (curr) {
                    var obj;
                    if (Array.isArray(props)) {
                        obj = {};
                        var arr = (k || "").split(",");
                        $.each(props || [], function (i, o) {
                            var vv = o.split('--');
                            if (vv.length == 1) {
                                if (arr.indexOf(o) > -1)
                                    obj[o] = ko.observable(curr[o]());
                                else
                                    obj[o] = ko.observable("");
                            }
                            else {
                                var f = vv[0];
                                var v = vv[1];
                                if (arr.indexOf(f) > -1)
                                    obj[f] = ko.observable(curr[f]());
                                else
                                    obj[f] = ko.observable(v);
                            }
                        })
                    } else {
                        obj = "";
                    }
                    var index = model[name].indexOf(curr);
                    if (index > -1 && index < model[name]().length) {
                        model[name].splice(index + 1, 0, (obj));
                    } else {
                        model[name].push(obj);
                    }
                } else {
                    var obj;
                    if (Array.isArray(props)) {
                        obj = {};
                        $.each(props || [], function (i, o) {
                            var vv = o.split('--');
                            if (vv.length == 1) {
                                obj[o] = ko.observable("");
                            }
                            else {
                                obj[vv[0]] = ko.observable(vv[1]);
                            }
                        })
                    } else {
                        obj = "";
                    }
                    model[name].push(obj);
                }
            }
        } catch (e) {
            console.error(e);
        }
    }
    removeItem(context, name, obj) {
        try {
            var model = context.$root;
            if (model[name]().length > 1)
                model[name].remove(obj);
        } catch (e) {
            console.error(e);
        }
    }
}