function myAjax(url, data, funSuccess, funError, funDone) {
    $.ajax({
        type: 'POST',
        url: url,
        contentType: 'application/json; charset utf-8',
        dataType: 'json',
        data: JSON.stringify(data),
        success: function (data, textStatus, xhr) {
            if (funSuccess) funSuccess(data, textStatus, xhr);
        },
        error: function (data, textStatus, xhr) {
            if (funError) funError(data, textStatus, xhr);
        },
    }).done(function () {
        if (funDone) funDone();
    });
}
