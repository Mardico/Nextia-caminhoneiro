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
            $('#tabApolice').attr('target', '_self');
            $('#tabApolice').attr('action', '/Apolice/ConsultarApolice');
            $('#tabApolice').submit();
        });

        $('#tabPagamentos').on('click', function () {
            $('#tabPagamentos').attr('target', '_self');
            $('#tabPagamentos').attr('action', '/Apolice/Pagamento');
            $('#tabPagamentos').submit();
        });

        $('#tabHistorico').on('click', function () {
            $('#tabHistorico').attr('target', '_self');
            $('#tabHistorico').attr('action', '/Segurado/Historico');
            $('#tabHistorico').submit();
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
