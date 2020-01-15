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

        //Adicinona Dependente
        $("#addLinha").on("click", function () {
            var Dados = { Proximo: $("#ListaDependentes").children.length };
            if ($("#ListaDependentes").children().length <= 10) {
                $("#tmpDependente").tmpl(Dados).appendTo("#ListaDependentes");
            } if ($("#ListaDependentes").children().length > 10) {
                $("#addLinha").attr("disabled", true);
            }
        });
        //remove linha
        $("#ListaDependentes").on("click", "a.deleteLinha", function (event) {
            $(this).closest("tr").remove();
            $("#addLinha").attr("disabled", false);
        });
        //Adicinona Beneficiario
        $("#addLinhaBeneficiario").on("click", function () {
            var Dados = { Proximo: $("#ListaDependentes").children.length };
            if ($("#tableBeneficiario").children().length <= 3) {
                $("#tmpBeneficiario").tmpl(Dados).appendTo("#tableBeneficiario");
            } if ($("#tableBeneficiario").children().length > 3) {
                $("#addLinhaBeneficiario").attr("disabled", true);
            }
        });
        //remove linha
        $("#tableBeneficiario").on("click", "a.deleteLinhaBeneficiario", function (event) {
            $(this).parent().parent().remove();
            $("#addLinhaBeneficiario").attr("disabled", false);
        });
        //Alterna meio pgto
        $("#DadosPagamento_MeioPgtoId").on("change", function () {
            $('#divCartao').toggle();
        });

        $('#frmDados').validate({
            rules: {
                DadosCliente_CPF: {
                    required: true,
                    CPF: true
                },
                DadosCliente_Email: {
                    required: true,
                    email: true
                },
                DadosCliente_DataNascimento: {
                    datanasc: true
                },
                DadosDependente_0_DataNasc: {
                    datanasc: true
                },
                DadosDependente_1_DataNasc: {
                    datanasc: true
                },
                Beneficiario_0_DataNasc: {
                    datanasc: true
                },
                DadosPagamento_Conta: {
                    required: true,
                    creditcard: true
                }
            },
            messages: {
                CPF: { require_from_group: "" },
                Nome: { require_from_group: "Informe pelo menos um campo de busca" }

            }
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
