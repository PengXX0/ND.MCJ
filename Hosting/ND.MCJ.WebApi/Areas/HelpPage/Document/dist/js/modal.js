/*
基于bootstrap的模态框的拓展插件
author:Percy
email:lsnh@foxmail.com
createdate:2016-5-17 18:22:18
*/
var modal = {
    bootStrapModalHtml: ['<div class="modal fade">',
                         '    <div class="modal-dialog">',
                         '        <div class="modal-content">',
                         '            <div class="modal-header">',
                         '                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>',
                         '                <h4 class="modal-title"></h4>',
                         '            </div>',
                         '            <div class="modal-body"></div>',
                         '            <div class="modal-footer">',
                         '                <button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>',
                         '                <button type="button" class="btn btn-primary">确定</button>',
                         '            </div>',
                         '        </div>',
                         '    </div>',
                         '</div>'].join(""),
    initModal: function (options) {
        var defaultArgs = {
            title: "提示",
            content: false,
            type: "info",//info、warning 、danger、success
            large: null,
            confirm: false,
            cancel: false,
            backdrop: true,
            keyboard: true,
            show: true,
            url: false
        };
        options = $.extend(defaultArgs, options || {});
        $(".modal.fade").remove();
        $('body').append(this.bootStrapModalHtml);
        var modal = $(".modal.fade");
        if (options.large == true) { modal.find(".modal-dialog").addClass("modal-lg"); }
        if (options.large == false) { modal.find(".modal-dialog").addClass("modal-sm"); }
        if (!options.cancel) { modal.find(".modal-footer button:first").remove(); } else { modal.find(".modal-footer button:first").text(options.cancel); }
        if (!options.confirm) { modal.find(".modal-footer button:last").remove(); } else { modal.find(".modal-footer button:last").text(options.confirm); }
        if (!options.confirm && !options.cancel) { modal.find(".modal-footer").remove(); } modal.find('.modal-title').text(options.title);
        return modal;
    },
    showModal: function (options) {
        var target = this.initModal(options);
        if (!options.url) {
            target.find(".modal-body").html(options.content); target.modal();
        } else { target.find(".modal-body").load(options.url, function () { target.modal(); }); }
    },
    alert: function (options) {
        options.large = !(options.large == undefined);
        options.type = (options.type == undefined) ? "info" : options.type;
        var target = this.initModal(options); var html = "<strong>" + options.content + "<strong>";
        target.find(".modal-body").html(html).addClass("bg-" + options.type + " text-center").find("strong").addClass("text-" + options.type);
        target.modal();
    }
};