﻿var utilities = {
    callAjax: function (options) {
        $.ajax({
            url: options.url,
            type: options.type,
            cache: false,
            success: function (data) {
                options.successFunction(data);
            },
            error: function (data) {
                options.errorFunction(data);
            }
        });
    },
    callAjaxPost: function (options) {
        $.ajax({
            url: options.url,
            type: options.type,
            cache: false,
            data: options.data,
            success: function (data) {
                options.successFunction(data);
            },
            error: function (data) {
                options.errorFunction(data);
            }
        });
    }
};