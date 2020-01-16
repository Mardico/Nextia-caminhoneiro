var jsPage = function () {
    this.Limpar = function () {
    };

    this.AoAssociar = function () {
        $('.btnDetalhe').on('click', function () {
            ojsPage.CarregaCliente(this);
            return false;
        });
    };

    this.CarregaCliente = function (item) {
        var cpf = $(item).data('item');
        var ID = $(item).data('id');
        $('#CPF').val(cpf);
        $('#Id').val(ID);
        if (cpf !== '' || ID !== '') {
            $("#frmBusca").submit();
        } else {
            swal('Ops', 'Cadastro do Segurado com problema', 'error');
        }
    };
    this.Consultar = function (acao) {
        var form = $("#frmBusca");
        var oData = form.serialize();
        var oURL = "/Segurado/ConsultaSegurados";
        return $.ajax({
            data: oData,
            url: oURL,
            cache: false,
            type: "POST",
            dataType: 'json',
            success: function (returnedData) {
                if (returnedData.ID < 0) {  //Invalido
                    swal("Oops", returnedData.Mensagem, "error");
                } else {
                    if (returnedData.ID === 0) {
                        acao();
                        return;
                    }
                    if (returnedData.ID === 1) {
                        form.attr('action', '/Segurado/DadosCadastrais');
                        form.submit();
                        return;
                    }
                    if (returnedData.ID > 1) {
                        form.attr('action', '/Segurado/ListaTodos');
                        form.submit();
                        return;
                    }
                }
            }
        });
    };
    this.Inicio = function () {
        this.AoAssociar();
    };
    var table = $('.table');
    table.on('error.dt', function (e, settings, techNote, message) {
        swal("Oops", message, "error");
    }).DataTable({
        "processing": false,
        "serverSide": false,
        "deferRender": true,
        "columns": [
            { "data": "Nome", "name": "Nome", "Type": "Text" },
            { "data": "CPF", "name": "CPF", "Type": "Text" },
            { "data": "DataNascimento", "name": "Data", "Type": "Date" },
            { "data": "", "name": "View" },
        ],
    });
};

var ojsPage = new jsPage();
$(document).ready(function () {
    ojsPage.Inicio();
});