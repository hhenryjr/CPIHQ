if (!sabio.services.personality) {
    sabio.services.personality = {};
}

sabio.services.personality.sendText = function (text, onSuccess, onError) {
    var url = "/api/Input/";

    var settings = {
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        data: text,
        dataType: "json",
        type: "POST",
        success: onSuccess,
        error: onError
    };

    $.ajax(url, settings);
}


