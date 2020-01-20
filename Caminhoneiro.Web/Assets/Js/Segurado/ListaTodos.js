var tabela = null;
var jsPage = function () {
    this.Limpar = function () {
        $('#Nome').val('');
        $('#CPF').val('');
        if (tabela !== null)
            tabela.clear();
    };
    this.AoAssociar = function () {
        $('.btnDetalhe').on('click', function () {
            ojsPage.CarregaCliente(this);
            return false;
        });
        $('#btnLimpar').on('click', function () {
            ojsPage.Limpar();
            $('#CPF').focus();
        });
        var tabela = $('.table').on('error.dt', function (e, settings, techNote, message) {
            swal("Oops", message, "error");
        }).DataTable({
            "processing": false,
            "serverSide": false,
            "deferRender": true,
            "columns": [
                { "data": "Nome", "name": "Nome", "Type": "Text" },
                { "data": "CPF", "name": "CPF", "Type": "Text" },
                { "data": "DataNascimento", "name": "Data", "Type": "Date" },
                { "data": "", "name": "View" }
            ]
        });
    };
    this.CarregaProdutos = function () {
        var form = $("#frmBusca");
        var oURL = "/Apolice/ProdutosUsuario";
        return $.ajax({
            url: oURL,
            cache: false,
            type: "POST",
            dataType: 'json',
            success: function (returnedData) {
                if (returnedData.ID < 0) {  //Invalido
                    swal("Oops", returnedData.Mensagem, "error");
                } else {
                    if (returnedData.ID === 0) {
                        $("#tmpProdutostmpProdutosVazio").tmpl().appendTo("#ListaProdutos");
                        return;
                    }
                    //Carrega Lista de Produtos
                    $("#ListaProdutos").empty();
                    $("#tmpProdutos").tmpl(returnedData.Item).appendTo("#ListaProdutos");
                    $('.moeda').autoNumeric('init', { digitGroupSeparator: '.', decimalCharacter: ',', aSign: 'R$ ' });
                }
            }
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
    this.TrataRetornoConsulta = function (ret) {
        if (ret.ID === 0) {
            ojsPage.CarregaProdutos();
            return;
        }
        if (ret.ID === 1) {
            //valida se tem apolice pendentes
            ojsPage.CarregaApolicesUsuario();
            return;
        }
        if (ret.ID > 1) {
            var form = $("#frmDados");
            form.attr('action', '/Segurado/ListaTodos');
            form.submit();
            return;
        }

    };
    this.NovoPedido = function (obj) {
        var IdProduto = $(obj).data('item');
        $('#DadosProduto_ProdutoId').val(IdProduto);
        var CPF = $('#CPF').val();
        $('#Codigo').val(CPF);
        var form = $("#frmDados");
        form.attr("action", "/Apolice/Adesao");
        form.submit();
    };
};

var ojsPage = new jsPage();
$(document).ready(function () {
    ojsPage.Inicio();
});