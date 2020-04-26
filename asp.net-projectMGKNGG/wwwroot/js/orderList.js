var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/order",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "temat", "width": "30%" },
            { "data": "zleceniodawca", "width": "30%" },
            { "data": "opisZamowienia", "width": "30%" },
            { "data": "data", "width": "30%" },

            

        ],
        "language": {
            "url": "~/json/polishApiTable.json",
            "emptyTable": "brak zamówień"
        },
        "width": "100%"
    });
}