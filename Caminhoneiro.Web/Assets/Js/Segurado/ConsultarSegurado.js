﻿var jsPage = function () {
    this.Limpar = function () {
        $('#Nome').val('');
        $('#CPF').val('');
        $('#ListaProdutos').empty();
    };
    this.AoAssociar = function () {
        $('#btnConsultar').on('click', function () {
            if ($("#frmBusca").valid())
                ojsPage.Consultar(ojsPage.CarregaProdutos);
            return false;
        });
        $('#btnLimpar').on('click', function () {
            ojsPage.Limpar();
            $('#CPF').focus();
        });
        $('#frmBusca').validate({
            rules: {
                CPF: {
                    require_from_group: [1, ".search-group"]
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
                }
            }
        });
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
    this.NovoPedido = function (obj) {
        var IdProduto = $(obj).data('item');
        $('#DadosProdutoId').val(IdProduto);
        
        var form = $("#frmBusca");
        form.attr("action", "/Apolice/Adesao");
        form.submit();
    };
};

var ojsPage = new jsPage();
$(document).ready(function () {
    ojsPage.Inicio();
});