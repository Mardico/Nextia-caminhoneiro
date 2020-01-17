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

        var table = $('.table');
        table.on('error.dt', function (e, settings, techNote, message) {
            swal("Oops", message, "error");
        }).DataTable({
            "processing": false,
            "serverSide": false,
            "deferRender": true,
            "columns": [
                { "data": "DataVencimento", "name": "Data do Vencimento", "Type": "Date" },
                { "data": "DataPagamento", "name": "Data do Pagamento", "Type": "Date" },
                { "data": "TipoPagamento", "name": "Tipo do Pagamento", "Type": "Text" },
                { "data": "MeioPagamento", "name": "Meio de Pagamento", "Type": "Text" },
                { "data": "NrParcelas", "name": "NrParcelas", "Type":"Number" },
                { "data": "Valor", "name": "Valor Parcela(R$)", "Type":"Number" },
                { "data": "TipoTransacao", "name": "Tipo de Transacao", "Type": "Text" },
                { "data": "StatusPagamento", "name": "Status do Pagamento", "Type": "Text" },
            ],
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
