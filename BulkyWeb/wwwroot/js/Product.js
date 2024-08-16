$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Admin/Product/GetAll',
            dataSrc: function (json) {
                console.log(json); // Log the response data
                return json.data; // Adjust according to your response format
            }
        },
        "columns": [
            { data: 'title', width: '20%' },
            { data: 'isbn', width: '15%' },
            { data: 'listPrice', width: '10%', className: 'text-center' }, // Center price column
            { data: 'author', width: '15%' },
            { data: 'category.name', width: '15%' },
            {
                data: 'id',
                width: '25%',
                render: function (data, type, row) {
                    var editUrl = '/Admin/Product/Upsert?id=' + data;
                    return `
                        <div class="d-flex justify-content-center">
                            <a href="${editUrl}" class="btn btn-secondary btn-sm d-inline-flex align-items-center justify-content-center" style="height: 30px; width: 100px;">
                                <i class="bi bi-pencil"></i> Edit
                            </a>
                            <a href="#" onClick="Delete(${data}); return false;" class="btn btn-outline-danger btn-sm d-inline-flex align-items-center justify-content-center" style="height: 30px; width: 100px;">
                                <i class="bi bi-trash"></i> Delete
                            </a>
                        </div>
                    `;
                }
            }
        ],
        "columnDefs": [
            { "className": "dt-center", "targets": "_all" }
        ]
    });
}

function Delete(id) {
    var url = '/Admin/Product/Delete?id=' + id;
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#134b5f",
        cancelButtonColor: "#ca1929",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    console.log("DELETE response:", data);
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                },
                error: function (xhr, status, error) {
                    toastr.error("An error occurred while deleting the record.", "Error");
                }
            });
        }
    });
}
