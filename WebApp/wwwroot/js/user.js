var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/User/GetAll' },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'email', "width": "15%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'company.name', "width": "15%" },
            { data: null, "width": "15%" },
            {
                data: 'id',
                "render": function (id) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/Admin/User/Upsert?id=${id}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
}
