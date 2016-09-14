$(function () {
    var config = {
        devUrl: "http://192.168.1.220:8092",
        exampleUrl: function () { return "/Help/Dev/Debug/?Url=" + (document.location.host.indexOf('localhost') != -1 ? document.location.origin : config.devUrl) + "/api" + $("#url").val(); },
        ParaToJson: function (para) {
            var array = para.split('&'); var obj = {};
            for (var i = 0; i < array.length; i++) {
                if (array[i].indexOf("=") == -1) { obj["url"] = array[i]; }
                var temp = array[i].split("="); obj[temp[0]] = temp[1];
            } return obj;
        },
        init: function () {
            $.getScript("../dist/js/bootstrap.js");
            $(".panel-heading:eq(1)").find("a").attr("href", config.exampleUrl());
            $(".method").append(this.ParaToJson($("#url").val()).Method)
            if ($(".panel-body").length <= 1) { return false; }
            var target = $(".panel-body:eq(1)");
            target.html(target.html().replace(/RequestModel/g, "<a href='../dist/html/RequestModel.html'><strong>RequestModel</strong></a>"));
            target.find('a').bind("click", function () {
                modal.showModal({ url: this.href, title: $(this).text(), cancel: "确定" });
                return false;
            });
        }
    };
    config.init();
});



