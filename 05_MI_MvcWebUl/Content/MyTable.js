$(document).ready(function () {
    var eventFired = function (type) {
        var n = $('#info')[0];
        n.innerHTML += '<div>' + type + ' event - ' + new Date().getTime() + '</div>';
        n.scrollTop = n.scrollHeight;
    }

    $('#myTable')
        .on('order.dt', function () { eventFired('Order'); })
        .on('search.dt', function () { eventFired('Search'); })
        .on('page.dt', function () { eventFired('Page'); })
        .DataTable({
            "language": {
                "url": "//cdn.datatables.net/plug-ins/1.10.22/i18n/Turkish.json"
            }
        });
});