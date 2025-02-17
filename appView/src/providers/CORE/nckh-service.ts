import { Injectable, Type } from '@angular/core';
import * as $ from 'jquery';
import * as ko from 'knockout';
import { Operator } from 'rxjs/Operator';
import * as ckEditor from '../../assets/lib/ckeditor/ckeditor';
import { CommonServiceProvider } from '../CORE/common-service';
import { APIListBase, appSetting } from '../CORE/api-list';
@Injectable()
export class NCKHServiceProvider {
    commonService: CommonServiceProvider;
    e: number
    editors: any
    ckToolbarOptions: any
    ckToolbarWithImageOptions: any
    constructor(commonService: CommonServiceProvider) {
        this.commonService = commonService;
        this.e = 0;
        this.editors = [];
        this.ckToolbarOptions = {
            startupFocus: true,
            title: false,
            fontSize: {
                options: [
                    9,
                    10,
                    11,
                    12,
                    13,
                    'default',
                    17,
                    19,
                    21
                ]
            },
            toolbar: {
                items: [
                    'fontColor',
                    'fontSize',
                    'fontFamily',
                    'lineHeight',
                    '|',
                    'heading',
                    '|',
                    'bold',
                    'italic',
                    'underline',
                    'link',
                    'bulletedList',
                    'numberedList',
                    '|',
                    'alignment',
                    'undo',
                    'redo',
                    'blockQuote',
                    'subscript',
                    'superscript',
                    'strikethrough',
                    'removeFormat'
                ]
            },
            lineHeight: { // specify your otions in the lineHeight config object. Default values are [ 0, 0.5, 1, 1.5, 2 ]
                options: [0.5, 1, 1.5, 2, 2.5]
            },
            language: 'vi',
            licenseKey: ''
        };
        this.ckToolbarWithImageOptions = {
            startupFocus: true,
            fontSize: {
                options: [
                    9,
                    10,
                    11,
                    12,
                    13,
                    'default',
                    17,
                    19,
                    21
                ]
            },
            toolbar: {
                items: [
                    'fontColor',
                    'fontSize',
                    'fontFamily',
                    'lineHeight',
                    '|',
                    'heading',
                    '|',
                    'bold',
                    'italic',
                    'underline',
                    'link',
                    'bulletedList',
                    'numberedList',
                    '|',
                    'alignment',
                    'undo',
                    'redo',
                    'blockQuote',
                    'subscript',
                    'superscript',
                    'strikethrough',
                    'removeFormat',
                    'imageUpload'
                ]
            },
            language: 'vi',
            licenseKey: '',
            image: {
                toolbar: [
                    'imageTextAlternative',
                    'imageStyle:full',
                    'imageStyle:side'
                ]
            },
            lineHeight: { // specify your otions in the lineHeight config object. Default values are [ 0, 0.5, 1, 1.5, 2 ]
                options: [0.5, 1, 1.5, 2, 2.5]
            },
        }
    }
    dispose() {
        $.each(this.editors, function (i, o) {
            try {
                o.editor.destroy();
            } catch (e) {
                console.error(e);
            }
        })
    }
    init(configs, frmPrint = false) {
        var me = this;
        var enableCKEditor = 1;
        // bindingHandlers
        ko.bindingHandlers.editableHtml = {
            init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
                var $element: any = $(element);
                var regex = /<br\s*[\/]?>/gi;
                var initialValue = ko.utils.unwrapObservable(valueAccessor());
                var textOnly = $element.data('textonly');
                if (textOnly) {
                    var txt = initialValue.replace(regex, "\n");
                    var ele = $("<p>" + txt + "</p>").text();
                    $element.html(ele.replace(/(?:\r\n|\r|\n)/g, '<br>'));
                }
                else {
                    $element.html(initialValue);
                }
                $element.on('input', function (e) {
                    var observable = valueAccessor();
                    if (textOnly) {
                        var regex = /<br\s*[\/]?>/gi;
                        var txt = $("<p>" + $element.html().replace(regex, "\n") + "</p>");
                        observable(txt.text());
                    } else {
                        observable($element.html());
                    }
                });
                if (enableCKEditor && !!$element.data('editor')) {
                    var idx = me.e++;
                    var $editor;
                    if (!$element[0].ckeditorInstance) {
                        var ckOptions = me.ckToolbarOptions;
                        if (!!$element.data('editor-image'))
                            ckOptions = me.ckToolbarWithImageOptions;

                        var observable = valueAccessor();
                        // ckEditor.create($element.get(0), ckOptions).then((editor) => {
                        //     if ($element.data('read-only')) {
                        //         editor.isReadOnly = true;
                        //     }
                        //     $editor = editor;
                        //     me.editors.push({
                        //         id: idx,
                        //         editor: $editor
                        //     });
                        //     $editor.model.document.on('change:data', (evt, data) => {
                        //         observable($editor.getData());
                        //     });
                        // });
                    }

                    //$element.on('focus', function (e) {

                    //});
                    // handle disposal (if KO removes by the template binding)
                    ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
                        if ($editor) {
                            $editor.destroy();
                            me.editors.splice(idx, 1);
                        };
                    });
                }
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
                '<button style="line-height:20px" class="clone"><i class="fa fa-plus"></i> Thêm</button>' +
                '</div>' +
                '</div>');
        $(".ptable:not(.noaction)").mouseenter(function (event) {
            try {
                var ptable = $(event.currentTarget),
                    sconf = ptable.attr("conf");
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.add || conf.remove) {
                        var group_controls = ptable.find(".group_controls");
                        if (group_controls.length == 0) {
                            ptableGroupConrtrol.appendTo(ptable);
                            //event.stopPropagation()
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
        $(".pblock:not(.noaction)").mouseenter((event) => {
            try {
                var pblock = $(event.currentTarget);
                var sconf = pblock.attr("conf");
                if (sconf != null) {
                    var conf = JSON.parse(sconf);
                    if (conf.add || conf.remove) {
                        var group_controls = pblock.children(".group_controls");
                        if (group_controls.length == 0) {
                            pblockConrtrol.appendTo(pblock);
                        }
                    }
                }
            } catch (e) {
                console.error(e);
                return false;
            }
        }).mouseleave((event) => {
            var t = $(event.currentTarget).children(".group_controls");
            t.detach();
        });
        $(".ptable:not(.noaction) >table.editable-table").on('click', ' tr', function (e: JQueryEventObject): boolean {
            if (e.offsetY < -1) {
                var ptable = $(e.currentTarget).closest(".pconf"),
                    sconf = ptable.attr("conf");
                if (sconf != null) {
                    try {
                        var conf = JSON.parse(sconf);
                        if (conf.name && conf.add) {
                            var tr = $(e.currentTarget);
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
        })

        var prowConrtrol =
            $('<div class="group_controls" style="position:absolute;top:0;right:0;border:1px solid red">' +
                '<div class="fieldgroup_controls">' +
                '<button style="line-height:20px" class="remove"><i class="fa fa-minus"></i> Xóa</button>' +
                '</div>' +
                '</div>');
        $(".pblock:not(.noaction)").on("mouseenter", ".prow", function (event) {
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

        var config = {
            tables: {}
        };
        try {
            config = JSON.parse(configs);
        } catch (e) {
        }

        var lstWrapper = document.getElementsByClassName("nckh-form-wrapper");
        var wrapper = lstWrapper[0];
        if (lstWrapper.length > 1 && frmPrint)
            wrapper = lstWrapper[1];
        if (wrapper != null) {
            var tables = wrapper.getElementsByClassName('resize-grid');
            for (var i = 0; i < tables.length; i++) {
                var name = tables[i].getAttribute("name");
                var conf = config && config.tables && config.tables[name];
                resizableGrid(tables[i], conf);
            }

            function resizableGrid(table, conf) {
                var colgroup = table.getElementsByTagName('colgroup')[0];
                if (colgroup && conf != null) {
                    var gcols = colgroup.children;
                    for (var i = 0; i < gcols.length; i++) {
                        try {
                            if (conf.HeaderWidths[i] && conf.HeaderWidths[i] != '') {
                                var w = conf.HeaderWidths[i].endsWith('px') ? conf.HeaderWidths[i].substr(0, conf.HeaderWidths[i].length - 2) : conf.HeaderWidths[i];
                                gcols[i].width = w;
                            }
                        } catch (e) {
                            console.error(e)
                        }
                    }
                }
                var row = table.getElementsByTagName('tr')[0],
                    cols = row ? row.children : undefined;
                if (!cols) return;
                table.style.overflow = 'hidden';
                row.classList.add('row-resizer');
                for (var i = 0; i < cols.length; i++) {
                    var div = createDiv(2440);
                    cols[i].appendChild(div);
                    if (conf != null && !colgroup) {
                        try {
                            cols[i].style.width = conf.HeaderWidths[i];
                        } catch (e) {
                            console.error(e)
                        }
                    }
                    cols[i].style.position = 'relative';
                    setListeners(div, table, i);
                }

                function setListeners(div, table, idx) {
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
                            var row = table.getElementsByTagName('colgroup')[0],
                                cols = row ? row.children : undefined;
                            if (nxtCol) {
                                nxtCol.style.width = (nxtColWidth - (diffX)) + 'px';
                                if (cols && cols.length > idx) {
                                    cols[idx + 1].width = (nxtColWidth - (diffX));
                                }
                            }
                            curCol.style.width = (curColWidth + diffX) + 'px';
                            if (cols && cols.length >= idx) {
                                cols[idx].width = (curColWidth + diffX);
                            }
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
                    toItem[x] = ko.observableArray([]);
                } else if (fromItem[x] instanceof Object) {
                    var obj = {};
                    this.copyPropertiesValue(fromItem[x], obj);
                    toItem[x] = obj;
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
    isNull(val: any) {
        return val == null || val == undefined || val == '' || val.length == 0 || val == Infinity || val == NaN;
    }
    isInt(val: string) {
        if (val.startsWith("0"))
            val = val.substr(1);
        return Number.parseInt(val).toString() == val;
    }
    isInt0(val: string) {
        return Number.parseInt(val).toString() == val;
    }
    getIntValue(val: string): number {
        if (val.startsWith("0"))
            val = val.substr(1);
        return Number.parseInt(val);
    }
    inRange = function (val: string, min: Number, max: Number) {
        return Number.parseInt(val) >= min && Number.parseInt(val) <= max;
    }
    checkDateTime(day: any, month: any, year: any, hour: any, minute: any, second: any) {
        return this.checkDate(day, month, year) && this.checkTime(hour, minute, second);
    }
    checkFullDate(fullDate: any) {
        if (this.isNull(fullDate))
            return true;
        var arr = fullDate.split("/");
        if (arr.length == 3)
            return this.checkDate(arr[0], arr[1], arr[2]);
        return false;
    }
    checkDate(day: any, month: any, year: any, ignoreDay: boolean = false) {
        ignoreDay = ignoreDay || false;
        if ((ignoreDay || this.isNull(day)) && this.isNull(month) && this.isNull(year))
            return true;
        var isValid = this.isInt(day.toString()) && this.inRange(day, 1, 31)
            && this.isInt(month.toString()) && this.inRange(month, 1, 12)
            && this.isInt(year.toString()) && this.inRange(year, 1900, 2100);
        if (isValid) {
            var d = this.getIntValue(day.toString());
            var m = this.getIntValue(month.toString()) - 1;
            var y = this.getIntValue(year.toString());
            var date = new Date(y, m, d);
            isValid = date.getFullYear() == y && date.getMonth() == m && date.getDate() == d;
        }
        return isValid;
    }
    checkTime(hour: any, minute: any, second: any) {
        if (this.isNull(hour) && this.isNull(minute) && this.isNull(second))
            return true;
        if (this.isNull(second))
            second = 0;
        var isValid = this.isInt(hour.toString()) && this.inRange(hour, 0, 23)
            && this.isInt(minute.toString()) && this.inRange(minute, 0, 59)
            && this.isInt0(second.toString()) && this.inRange(second, 0, 59);
        return isValid;
    }
    isPhoneNumber(val: any) {
        if (this.isNull(val))
            return true;
        var phone = this.extractContent(val).toString().replace("<br>", "");
        if (phone != "" && (phone.length < 7 || phone.length > 11))
            return false;
        var res = true;
        for (var i = 0; i < phone.length; i++) {
            if (Number.parseInt(phone[i]).toString() !== phone[i]) {
                res = false;
                break;
            }
        }
        return res;
    }
    extractContent(val) {
        val = val.trim();
        var span = document.createElement('span');
        span.innerHTML = val;
        return span.textContent || span.innerText;
    }
    getConfigs() {
        var wrapper = document.getElementsByClassName("nckh-form-wrapper")[0];
        var data = {
            tables: {}
        };
        if (wrapper != null) {
            var tables = wrapper.getElementsByClassName('resize-grid');
            for (var i = 0; i < tables.length; i++) {
                var name = tables[i].getAttribute("name");
                data.tables[name] = getTableConfig(tables[i]);
            }
            function getTableConfig(table) {
                var headerWidths = [];
                var colgroup = table.getElementsByTagName('colgroup')[0];
                if (colgroup) {
                    var gcols = colgroup.children;
                    for (var i = 0; i < gcols.length; i++) {
                        if (gcols[i].width > 0)
                            headerWidths[i] = gcols[i].width + 'px';
                    }
                }
                var row = table.getElementsByTagName('tr')[0],
                    cols = row ? row.children : undefined;
                if (!cols) return {
                    HeaderWidths: headerWidths
                };
                for (var i = 0; i < cols.length; i++) {
                    if (!headerWidths[i])
                        headerWidths[i] = cols[i].style.width;
                }
                return {
                    HeaderWidths: headerWidths
                }
            }
        }
        return JSON.stringify(data);
    }
    disableContenteditable(html: string, excepts: string[]) {
        var div = $("<div>" + html + "</div>");
        var contents = div.find('[data-bind]');
        $.each(contents, (i, o) => {
            var bind = $(o).attr("data-bind");
            var contenteditable = $(o).attr("contenteditable");
            if (bind.startsWith("editableHtml") && contenteditable == "true") {
                var field = bind.split(":")[1].trim();
                if (excepts.indexOf(field) == -1)
                    $(o).attr("contenteditable", "false");
            } else if (bind.startsWith("checkedHtml")) {
                var field = bind.split(":")[1].trim();
                if (excepts.indexOf(field) == -1)
                    $(o).attr("disabled", "disabled");
            }
        })
        var tables = div.find("table.nckh-table");
        $.each(tables, (i, o) => {
            if ($(o).find('tbody tr').length > 0 && $(o).find("[contenteditable='true']").length == 0) {
                $(o).addClass('noaction');
                $(o).parent().addClass('noaction');
            }
        })
        var pblocks = div.find(".pblock");
        $.each(pblocks, (i, o) => {
            if ($(o).find('.prow').length > 0 && $(o).find("[contenteditable='true']").length == 0)
                $(o).addClass('noaction');
        })
        return div.children();
    }
    print(html: string, title: string = null, timeout = 1000, margin = 0.6) {
        var win = window.open('', '_blank');
        win.document.write('<html class="browser"><head><title>' + (title || document.title) + "_" + (new Date().getTime()) + '</title><link href="' + appSetting.mainService.base + 'content/style/nckh-form-template.css?v=' + (new Date().getTime()) + '" rel="stylesheet">');
        win.document.write('<style type="text/css" media="print">@page { size: a4;  margin: ' + margin + 'in 0; } body { margin: 0; padding: 0; }</style></head><body >');
        win.document.write('<div id="loader" class="centerLoader"></div>');
        win.document.write('<script> document.querySelector("body").style.visibility = "hidden";document.querySelector("#loader").style.visibility = "visible";setTimeout(function () { document.querySelector("#loader").style.display = "none";document.querySelector("body").style.visibility = "visible";window.print(); },' + timeout + '); </script>');
        win.document.write(html);
        win.document.write('</body></html>');

        win.document.close(); // necessary for IE >= 10
        win.focus(); // necessary for IE >= 10*/
    }
}