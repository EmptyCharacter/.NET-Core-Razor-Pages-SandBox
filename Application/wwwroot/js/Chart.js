
    var data, ctx, mychart;

        data = {
        labels: ["Dmitri.Ivanovich.Mendeleev", "Yuri.Alekseyevich.Gagarin", "Alexey.Arkhipovich.Leonov"],
            datasets: [{
        label: "My First dataset",
    fillColor: "rgba(220,220,220,0.5)",
    strokeColor: "rgba(220,220,220,0.8)",
    highlightFill: "rgba(220,220,220,0.75)",
    highlightStroke: "rgba(220,220,220,1)",
    data: [50, 88, 15]
}]
};

ctx = document.getElementById("chart_b").getContext("2d");
        mychart2 = new Chart(ctx).Bar(data, {
        animation: false
});




        Chart.types.Bar.extend({
        name: "BarAlt",
            draw: function () {
        this.scale.endPoint = this.options.endPoint;
    Chart.types.Bar.prototype.draw.apply(this, arguments);
}
});

        data = {
        labels: ["Iantojones", "Jackharkness", "Owenharper"],
            datasets: [{
        label: "My First dataset",
    fillColor: "rgba(220,220,220,0.5)",
    strokeColor: "rgba(220,220,220,0.8)",
    highlightFill: "rgba(220,220,220,0.75)",
    highlightStroke: "rgba(220,220,220,1)",
    data: [50, 88, 15]
}]
};

ctx = document.getElementById("chart_a").getContext("2d");
        mychart1 = new Chart(ctx).BarAlt(data, {
        endPoint: mychart2.scale.endPoint,
    animation: false
});
