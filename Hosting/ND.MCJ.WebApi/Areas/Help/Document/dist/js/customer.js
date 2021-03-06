﻿var doc = {
    toggleActive: function (obj) {
        if ($(obj).next().length == 0) {
            $(".menu").find("a").removeClass("active");
            $(obj).addClass("active").attr("href", obj.href.split('?')[0] + "?_=" + new Date().getTime()).attr("target", "mainFrame");
        } else {
            if ($(obj).next("ul").is(":hidden")) { $(obj).parents("ul").find("li ul").not(":hidden").toggle(200).prev("a").find("i").toggleClass("arrow-down arrow-right"); }
            $(obj).next("ul").toggle(200).prev("a").find("i").toggleClass("arrow-down arrow-right");
        }
    },
    resizeStyle: function () {
        $(".main-content,iframe[name='mainFrame']").width($(window).width() - $(".menu").width()).height("100%");
        var textareaHeight = $(window).height() - ($(".form-horizontal").height() - $("textarea[name='response']").height() + 70);
        if ($("textarea[name='response']").height() < textareaHeight) { $("textarea[name='response']").height(textareaHeight); }
    },
    submitForm: function (obj) {
        var data = this.serializeJson($(obj));
        $.ajax({
            type: data.method, dataType: "json",
            beforeSend: function () { $(obj).find('input[type="submit"]').button("loading"); },
            complete: function () { $(obj).find('input[type="submit"]').button("reset"); },
            url: "/Help/Dev/Debug/?Url=" + encodeURI(data.action) + "&Method=" + data.method + "&PlatformId=" + data.PlatformId + "&Parma=" + encodeURI(data.parameter.replace(/&/g, "|")),
            success: function (response) {
                json = response.Response;
                //$(".response").data("json", response.Response);
                doc.formatJson(response.Response); $("input[name='sign']").val(response.Sign);
            },
            error: function () { modal.alert({ content: "请求出错了 ！", cancel: "确定", type: "danger" }); },
            headers: { "Authenticate": " Basic eXN0Omp1bGk=" }
        }); return false;
    },
    formatJson: function (json) {
        if ($(".debugform").length > 0) {
            (new JsonFormater({ dom: ".response", isCollapsible: $(".console").prop("checked") })).doFormat(json);
            $(".console").change(function () { (new JsonFormater({ dom: ".response", isCollapsible: $(".console").prop("checked") })).doFormat(json); });
        }
    },
    serializeJson: function (obj) {
        var serializeObj = {}; var array = obj.serializeArray();
        $(array).each(function () {
            if (serializeObj[this.name]) {
                if ($.isArray(serializeObj[this.name])) {
                    serializeObj[this.name].push(this.value);
                } else { serializeObj[this.name] = [serializeObj[this.name], this.value]; }
            } else { serializeObj[this.name] = this.value; }
        }); return serializeObj;
    },
    validator: function () {
        $('#tryitForm').bootstrapValidator({
            fields: {
                firstName: {
                    validators: {
                        notEmpty: {
                            message: 'The first name is required and cannot be empty'
                        }
                    }
                },
                lastName: {
                    validators: {
                        notEmpty: {
                            message: 'The last name is required and cannot be empty'
                        }
                    }
                },
                email: {
                    validators: {
                        notEmpty: {
                            message: 'The email address is required'
                        },
                        emailAddress: {
                            message: 'The input is not a valid email address'
                        }
                    }
                },
                gender: {
                    validators: {
                        notEmpty: {
                            message: 'The gender is required'
                        }
                    }
                }
            },
            submitHandler: function (validator, form, submitButton) {
                var fullName = [validator.getFieldElements('firstName').val(),
                                validator.getFieldElements('lastName').val()].join(' ');
                $('#helloModal')
                    .find('.modal-title').html('Hello ' + fullName).end()
                    .modal();
            }
        });
    },
    init: function () {
        window.onresize = this.resizeStyle; $(window).resize();
        $(".menu").find("li ul").prev("a").css("padding-left", "0").prepend('<i class="arrow-right"></i>');
        $(".menu").find("a").bind("click", function () { doc.toggleActive(this); });
        $(".form-horizontal").bind("submit", function () { return doc.submitForm(this); });
        $(".form-horizontal").bind("keyup", function (event) { if (event.keyCode == 13) { return doc.submitForm(this); } })
        if ($(".debugform").length > 0) { this.formatJson(json); }
    }
};
$(function () { doc.init(); });