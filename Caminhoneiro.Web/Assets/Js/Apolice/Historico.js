function jsPage() {
    this.Limpar = function () {
    };
    this.AoAssociar = function () {
        $('#tabSegurado').on('click', function () {
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').attr('action', '/Segurado/DadosCadastrais');
            $('#TabSegurado').submit();
        });

        $('#tabProdutos').on('click', function () {
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').attr('action', '/Apolice/ListaTodos');
            $('#TabSegurado').submit();
        });

        $('#tabKit').on('click', function () {
            if ($('#IdApolice').val() === null) {
                SweetAlert('Selecione antes o produto');
                return;
            }
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').attr('action', '/Segurado/KitProduto');
            $('#TabSegurado').submit();
        }); 

        $('#tabApolice').on('click', function () {
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').attr('action', '/Apolice/ConsultarApolice');
            $('#TabSegurado').submit();
        });

        $('#tabPagamentos').on('click', function () {
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').attr('action', '/Apolice/Pagamento');
            $('#TabSegurado').submit();
        });

        $('#tabHistorico').on('click', function () {
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').attr('action', '/Apolice/Historico');
            $('#TabSegurado').submit();
        });

        $('.table').on('error.dt', function (e, settings, techNote, message) {
            swal("Oops", message, "error");
        }).DataTable({
            "processing": false,
            "serverSide": false,
            "deferRender": true,
            "columns": [
                { "data": "Codigo", "name": "Codigo", "Type": "Number" },
                { "data": "NrEndosso", "name": "NrEndosso", "Type": "Text" },
                { "data": "TipoEndosso", "name": "TipoEndosso", "Type": "Text" },
                { "data": "Endosso", "name": "Endosso", "Type": "Text" },
                { "data": "Data", "name": "Data", "Type": "Date" },
                { "data": "Usuario", "name": "Usuario", "Type": "Text" }
            ]
        });

    };
    this.Inicio = function () {
        this.AoAssociar();
    };
}

var ojsPage = new jsPage();
$(function () {
    ojsPage.Inicio();
});
