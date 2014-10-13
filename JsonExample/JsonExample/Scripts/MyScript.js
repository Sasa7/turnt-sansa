/// <reference path="jquery-2.1.0-vsdoc.js" />

$(function () {
    $("#myButton").click(function () {
        var div = $("#results");
        $.ajax({
            type: "GET",
            url: "Home/GetByJson",
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                //$.each(data, function(i, item){
                //    var res = item.Name + " " + item.Description + "<br /> ";
                //    div.append(res);

                    $.each(data, function(i, item){
                        var res = item + "<br /> ";
                        div.append(res);
                });
            }
        });
    });
});