$(document).ready(function () {
    $('.delete-valesdet').on('click', function () {
        var idValesDet = $(this).data('idvalesdet');
        var cantidad = $(this).data('cantidad')

        $('#confirmarEliminacionRegistro').modal('show');

        $('#confirmarEliminacionRegistro .modal-body p').html('Seguro que deseas eliminar el registro?<br>ID: ' + idValesDet + '<br>Cantidad de Compra: ' + cantidad);

        $('#deleteButton').on('click', function () {
            $.post('/ValesDetCarrera/ConfirmDelete', { id: idValesDet }, function (data) {
                if (data.success) {
                    location.reload();
                } else {
                    alert('Error al eliminar el registro.');
                }
            });

            $('#confirmarEliminacionRegistro').modal('hide');
        });
    });
});