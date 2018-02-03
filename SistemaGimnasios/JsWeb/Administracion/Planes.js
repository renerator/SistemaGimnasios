
$(document).ready(function () {
    $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
        paging: true,
        retrieve: true,
        searching: true,
        responsive: true,
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.11/i18n/Spanish.json"
        }
    });

    $("#btnEditar").click(function () {
        alert("hola mundo");
    });

});

