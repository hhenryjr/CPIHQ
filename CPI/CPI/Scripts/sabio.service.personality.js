if (!sabio.services.personality) {
    sabio.services.personality = {};
}

sabio.services.personality.sendHandler = function (url, onSuccess, onError) {
    var url = "/api/twitter/" + url;    
    var settings = {       
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        type: "GET",        
        dataType: "json",
    success: onSuccess,
    error: onError
};    $.ajax(url, settings);
}

