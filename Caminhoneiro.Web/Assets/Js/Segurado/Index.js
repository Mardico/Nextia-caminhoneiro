var jsPage = function () {
    this.Limpar = function () {
        $('#Nome').val('');
        $('#CPF').val('');
        $('#ListaProdutos').empty();
    };
    this.AoAssociar = function () {
        $('#btnConsultar').on('click', function () {
            if ($("#frmDados").valid())
                ojsPage.Consultar(ojsPage.TrataRetornoConsulta);
            return false;
        });
        $('#btnLimpar').on('click', function () {
            ojsPage.Limpar();
            $('#CPF').focus();
        });
        $('#frmDados').validate({
            rules: {
                CPF: {
                    require_from_group: [1, ".search-group"],
                    CPF: true
                },
                Nome: {
                    require_from_group: [1, ".search-group"]
                }
            },
            messages: {
                CPF: { require_from_group: "" },
                Nome: { require_from_group: "Informe pelo menos um campo de busca" }

            }
        });
        $('#ListaProdutos').on('click', '.itemproduto', function () {
            ojsPage.NovoPedido(this);
        });
    };
    this.CarregaProdutos = function () {
        var form = $("#frmDados");
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
                }
            }
        });
    };
    this.Consultar = function (acao) {
        var form = $("#frmDados");
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
                    acao(returnedData);
                }
            }
        });
    };
    this.TrataRetornoConsulta = function (ret) {
        if (ret.ID === 0) {
            ojsPage.CarregaProdutos();
            return;
        }
        if (ret.ID === 1) {
            //valida se tem apolice pendentes
            ojsPage.CarregaApolicesPendentes();
            return;
        }
        if (ret.ID > 1) {
            form.attr('action', '/Segurado/ListaTodos');
            form.submit();
            return;
        }

    };
    this.CarregaApolicesPendentes = function () {
        var form = $("#frmDados");
        var oData = form.serialize();
        var oURL = "/Apolice/ApolicesPendentes";
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
                    //se tem 1 valida se 
                    if (returnedData.ID > 0) {
                        $('#Id').val(returnedData.Item[0].Id);
                        form.attr('action', '/Apolice/Adesao');
                    } else {
                        form.attr('action', '/Segurado/DadosCadastrais');
                    }
                    form.submit();
                }
            }
        });
    };
    this.Inicio = function () {
        this.AoAssociar();
    };
    this.NovoPedido = function (obj) {
        var IdProduto = $(obj).data('item');
        $('#DadosProdutoId').val(IdProduto);
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