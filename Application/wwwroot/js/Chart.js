function LoadChart1() {
    var data;
    $.ajax({
        type: "POST",
        url: "Analysis.aspx/GetChart1",
        data: "{account: '" + $("[id*=ddlAccount]").val() + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            $("#dvChart").html("");
            $("#dvLegend").html("");
            var obj = r.d;
            data = JSON.parse(obj);

            var el = document.createElement('canvas');
            $("#dvChart")[0].appendChild(el);

            //Fix for IE 8
            if ($.browser.msie && $.browser.version == "8.0") {
                G_vmlCanvasManager.initElement(el);
            }
            var ctx = el.getContext('2d');
            ctx.canvas.width = 500;
            ctx.canvas.height = 500;
            var userStrengthsChart;
            userStrengthsChart = new Chart(ctx).Bar(data);
        },
        failure: function (response) {
            alert('There was an error.');
        }
    });
}