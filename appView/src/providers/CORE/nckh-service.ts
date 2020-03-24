import { Injectable, Type } from '@angular/core';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { Operator } from 'rxjs/Operator';

@Injectable()
export class NCKHServiceProvider {
    constructor() {
    }
    init() {
        var me = this;

        // bindingHandlers
        ko.bindingHandlers.editableHTML = {
            init: function (element, valueAccessor) {
                var $element = $(element);
                var initialValue = ko.utils.unwrapObservable(valueAccessor());
                $element.html(initialValue);
                $element.on('input', function (e) {
                    var observable = valueAccessor();
                    observable($element.html());
                });
            }
        };
        ko.bindingHandlers.checkedHtml = {
            init: function (element, valueAccessor) {
                var $element = $(element);
                var initialValue = ko.utils.unwrapObservable(valueAccessor());
                if (initialValue) {
                    $element.attr("checked", initialValue)
                } else {
                    $element.removeAttr("checked")
                }
                $element.on('change', function () {
                    if (this.checked) {
                        $element.attr("checked", this.checked)
                    } else {
                        $element.removeAttr("checked")
                    }
                    var observable = valueAccessor();
                    if (observable instanceof Function) {
                        observable(this.checked);
                    } else {
                        valueAccessor(this.checked);
                    }
                });
            }
        };

        // eventHandlers
        $(".ptable,.pblock").on("click", ".clone", function (e) {
            var target = $(e.currentTarget).closest(".pconf"),
                sconf = target.attr("conf");
            if (sconf != null) {
                try {
                    var context = ko.contextFor(target[0]);
                    var conf = JSON.parse(sconf);
                    if (conf.add) {
                        var anchorNode = window.getSelection().anchorNode;
                        if (!anchorNode) {
                            me.addItem(context, conf.name, conf.props, null, null);
                        }
                        // @ts-ignore
                        else {
                            var sconf1 = $(anchorNode).closest(".pconf").attr("conf");
                            if (sconf1 == null) {
                                me.addItem(context, conf.name, conf.props, null, null);
                            } else {
                                try {
                                    var conf1 = JSON.parse(sconf1);
                                    if (conf1.name === conf.name) {
                                        if (anchorNode.parentElement.tagName == "TD" || anchorNode.parentElement.tagName == "TR") {
                                            var tr = $(anchorNode).closest('tr');
                                            var obj = ko.contextFor(tr[0]).$data;
                                            me.addItem(context, conf.name, conf.props, obj, tr.attr('values'));
                                        } else if ($(anchorNode).closest('.prow') && $(anchorNode).closest('.prow').length > 0) {
                                            var row = $(anchorNode).closest('.prow');
                                            var obj = ko.contextFor(row[0]).$data;
                                            me.addItem(context, conf.name, conf.props, obj, row.attr('values'));
                                        } else {
                                            me.addItem(context, conf.name, conf.props, null, null);
                                        }
                                    } else {
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
            var anchorNode = window.getSelection().anchorNode;
            if (anchorNode) {
                var ptable = $(e.currentTarget).closest(".pconf"),
                    sconf = ptable.attr("conf");
                var sconf1 = $(anchorNode).closest(".pconf").attr("conf");
                if (sconf != null && sconf1 != null && (anchorNode.parentElement.tagName == "TD" || anchorNode.parentElement.tagName == "TR")) {
                    try {
                        var conf = JSON.parse(sconf);
                        var conf1 = JSON.parse(sconf1);
                        if (conf.name === conf1.name && conf.add) {
                            var tr = $(anchorNode).closest('tr');
                            if (tr.attr('removable') == "1" || tr.attr('removable') == "true") {
                                var context = ko.contextFor(ptable[0]);
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
            var prow = $(e.currentTarget).closest(".prow"),
                pblock = prow.closest(".pconf"),
                sconf = pblock.attr("conf");
            if (sconf != null) {
                try {
                    var conf = JSON.parse(sconf);
                    if (conf.add) {
                        if (prow.attr('removable') == "1" || prow.attr('removable') == "true") {
                            var context = ko.contextFor(pblock[0]);
                            var obj = ko.contextFor(prow[0]).$data;
                            me.removeItem(context, conf.name, obj);
                        }
                    }
                    return false;
                } catch (e) {
                    console.error(e);
                    return false;
                }
            }
        });

        var ptableGroupConrtrol =
            $('<div class="group_controls" style="position:absolute;top:-24px;right:0;border:1px solid red">' +
                '<div class="fieldgroup_controls">' +
                '<button style="line-height:20px" class="remove"><i class="fa fa-minus"></i> Xóa</button>' +
                '<button style="line-height:20px" class="clone"><i class="fa fa-plus"></i> Thêm</button>' +
                '</div>' +
                '</div>');
        $(".ptable").mouseenter(function (event) {
            try {
                var ptable = $(event.currentTarget),
                    sconf = ptable.attr("conf");
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.add || conf.remove) {
                        var group_controls = ptable.find(".group_controls");
                        if (group_controls.length == 0) {
                            ptableGroupConrtrol.appendTo(ptable);
                        }
                    }
                }
            } catch (e) {
                console.error(e);
                return false;
            }
        }).mouseleave(function (event) {
            var ptable = $(event.currentTarget),
                group_controls = ptable.find(".group_controls");
            group_controls.detach();
        });

        var pblockConrtrol =
            $('<div class="group_controls" style="position:absolute;top:0;right:0;border:1px solid red">' +
                '<div class="fieldgroup_controls">' +
                '<button style="line-height:20px" class="clone"><i class="fa fa-plus"></i> Thêm</button>' +
                '</div>' +
                '</div>');
        $(".pblock").mouseenter(function (event) {
            try {
                var pblock = $(event.currentTarget);
                var sconf = pblock.attr("conf");
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.add || conf.remove) {
                        var group_controls = pblock.find(".group_controls");
                        if (group_controls.length == 0) {
                            pblockConrtrol.appendTo(pblock);
                            event.stopPropagation()
                        }
                    }
                }
            } catch (e) {
                console.error(e);
                return false;
            }
        }).mouseleave(function (event) {
            var t = $(event.currentTarget).find(".group_controls");
            t.detach();
        });

        var prowConrtrol =
            $('<div class="group_controls" style="position:absolute;top:0;right:0;border:1px solid red">' +
                '<div class="fieldgroup_controls">' +
                '<button style="line-height:20px" class="remove"><i class="fa fa-minus"></i> Xóa</button>' +
                '</div>' +
                '</div>');
        $(".pblock").on("mouseenter", ".prow", function (event) {
            try {
                var pblock = $(event.currentTarget);
                var sconf = pblock.attr("conf");
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.remove) {
                        var group_controls = pblock.find(".group_controls");
                        if (group_controls.length == 0) {
                            prowConrtrol.appendTo(pblock);
                        }
                    }
                }
            } catch (e) {
                console.error(e);
                return false;
            }
        });
        $(".pblock").on("mouseleave", ".prow", function (event) {
            var pblock = $(event.currentTarget),
                group_controls = pblock.find(".group_controls");
            group_controls.detach();
        });

        var wrapper = document.getElementsByClassName("nckh-form-wrapper")[0];
        if (wrapper != null) {
            var tables = wrapper.getElementsByClassName('resize-grid');
            for (var i = 0; i < tables.length; i++) {
                resizableGrid(tables[i]);
            }

            function resizableGrid(table) {
                var row = table.getElementsByTagName('tr')[0],
                    cols = row ? row.children : undefined;
                if (!cols) return;
                table.style.overflow = 'hidden';
                for (var i = 0; i < cols.length; i++) {
                    var div = createDiv(2440);
                    cols[i].appendChild(div);
                    cols[i].style.position = 'relative';
                    setListeners(div);
                }

                function setListeners(div) {
                    var pageX, curCol, nxtCol, curColWidth, nxtColWidth;

                    div.addEventListener('mousedown', function (e) {
                        curCol = e.target.parentElement;
                        nxtCol = curCol.nextElementSibling;
                        pageX = e.pageX;
                        var padding = paddingDiff(curCol);
                        curColWidth = curCol.offsetWidth - padding;
                        if (nxtCol)
                            nxtColWidth = nxtCol.offsetWidth - padding;
                    });

                    div.addEventListener('mouseover', function (e) {
                        e.target.style.borderRight = '2px solid #cbcbcb';
                    })

                    div.addEventListener('mouseout', function (e) {
                        e.target.style.borderRight = '';
                    })

                    table.addEventListener('mousemove', function (e) {
                        if (curCol) {
                            var diffX = e.pageX - pageX;
                            if (nxtCol)
                                nxtCol.style.width = (nxtColWidth - (diffX)) + 'px';
                            curCol.style.width = (curColWidth + diffX) + 'px';
                        }
                    });

                    table.addEventListener('mouseup', function (e) {
                        curCol = undefined;
                        nxtCol = undefined;
                        pageX = undefined;
                        nxtColWidth = undefined;
                        curColWidth = undefined
                    });
                }

                function createDiv(height) {
                    var div = document.createElement('div');
                    div.style.top = '0';
                    div.style.right = '0';
                    div.style.width = '5px';
                    div.style.position = 'absolute';
                    div.style.cursor = 'col-resize';
                    div.style.userSelect = 'none';
                    div.style.height = height + 'px';
                    return div;
                }

                function paddingDiff(col) {
                    if (getStyleVal(col, 'box-sizing') == 'border-box') {
                        return 0;
                    }
                    var padLeft = getStyleVal(col, 'padding-left');
                    var padRight = getStyleVal(col, 'padding-right');
                    return (parseInt(padLeft) + parseInt(padRight));

                }

                function getStyleVal(elm, css) {
                    return (window.getComputedStyle(elm, null).getPropertyValue(css))
                }
            };
        }
    }
    observableSimpleArray(arr, samples: Array<string>) {
        if ((arr == null || arr == undefined || arr.length == 0) && samples != null && samples.length > 0)
            arr = samples;
        return ko.observableArray($.map(arr, function (str) {
            return {
                data: ko.observable(str)
            };
        }));
    }
    typeof(val, instance: Function, type: string) {
        if (type == "object")
            return val instanceof instance && typeof val == type;
        else
            return val instanceof instance || typeof val == type;
    }
    copyPropertiesValue(fromItem, toItem) {
        for (let x in fromItem) {
            if (x != '_isChecked') {
                if (this.typeof(fromItem[x], Boolean, 'boolean')) {
                    toItem[x] = ko.observable(fromItem[x] || false);
                } else if (this.typeof(fromItem[x], Number, 'number')) {
                    toItem[x] = ko.observable(fromItem[x] || 0);
                } else if (this.typeof(fromItem[x], String, 'string')) {
                    toItem[x] = ko.observable(fromItem[x] || "");
                } else if (this.typeof(fromItem[x], Date, 'object')) {
                    toItem[x] = ko.observable(fromItem[x] || new Date());
                } else if (fromItem[x] instanceof Array) {
                    toItem[x] = ko.observable([]);
                } else if (fromItem[x] instanceof Object) {
                    var obj = {};
                    this.copyPropertiesValue(fromItem[x], obj);
                    toItem[x] = ko.observable(obj);
                } else if (fromItem[x] == undefined || fromItem[x] == null) {
                    toItem[x] = ko.observable("");
                }
            }
        }
    }
    stringifySimpleArray(arr) {
        return $.map(arr, function (str) {
            if (typeof str.data === "function")
                return str.data();
            return str.data;
        })
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