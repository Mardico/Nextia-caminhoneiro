function jsPage() {
    this.Limpar = function () {
    };
    this.AoAssociar = function () {
        //Adicinona Dependente
        $("#addLinha").on("click", function () {
            var Dados = { Proximo: $("#ListaDependentes").children().children().length };
            if ($("#ListaDependentes").children().children().length <= 10) {
                $("#tmpDependente").tmpl(Dados).appendTo("#ListaDependentes");
            } if ($("#ListaDependentes").children().children().length > 10) {
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
            var Dados = { Proximo: $("#ListaDependentes").children().length };
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
        //Carrega Usuarios
        $("#VinculoId").on("change", function () {
            var Id = $(this).val();
            var oURL = '/Apolice/BuscaUsuarios';
            return $.ajax({
                data: { 'ID': Id },
                url: oURL,
                cache: false,
                type: "POST",
                dataType: 'json',
                success: function (returnedData) {
                    if (returnedData.ID === 0) {  //Invalido
                        Mensagem.Erro(returnedData.Mensagem);
                    } else {
                        var lista = returnedData.Item;
                        $('#Usuario_id')
                            .find('option')
                            .remove()
                            .end()
                            .append('<option value="">:: Selecione ::</option>');
                        for (var i = 0; i < lista.length; i++) {
                            $('#Usuario_id').append($('<option></option>').val(lista[i].Id).data('item', lista[i].TipoUsuario).html(lista[i].Nome));
                        }
                        $('#Usuario_id').val(valor + '');
                    }
                }
            });

        });
        //Busca CPF
        $('#btnBuscaCPF').on('click', function () {
            var CPF = $('#DadosCliente_CPF').val();
            $.ajax({
                data: { 'CPF': CPF },
                url: '/Segurado/ConsultaDadosSegurado',
                cache: false,
                type: "POST",
                dataType: 'json',
                success: function (returnedData) {
                    if (returnedData.ID === -1) {  //Invalido
                        swal("Oops", returnedData.Mensagem, "error");
                    } else {
                        if (returnedData.ID > 0) {
                            var data = returnedData.Item;
                            var dia = moment(data.DataNascimento).format('dd/mm/yyyy');
                            $('#DadosCliente_Nome').val(data.Nome);
                            $('#DadosCliente_DataNascimento').val(dia);
                            $('#DadosCliente_SexoId').val(data.SexoId);
                            $('#DadosCliente_EstadoCivilId').val(data.EstadoCivilId);
                            $('#DadosCliente_Email').val(data.Email);
                            $('#DadosCliente_CEP').val(data.CEP);
                            $('#DadosCliente_Endereco').val(data.Endereco);
                            $('#DadosCliente_Numero').val(data.Numero);
                            $('#DadosCliente_Complemento').val(data.Complemento);
                            $('#DadosCliente_Bairro').val(data.Bairro);
                            $('#DadosCliente_Cidade').val(data.Cidade);
                            $('#DadosCliente_UF').val(data.UF);
                        } else {
                            swal("Informe do Sistema", "CPF não localizado nas bases do sistema", "info");
                        }
                    }
                }
            });
            return false;
        });
        //Busca CEP
        $('#btnBuscaCEP').on('click', function () {
            var CEP = $('#DadosCliente_CEP').val();
            $.ajax({
                data: { 'Texto': CEP },
                url: '/Segurado/ConsultaCEP',
                cache: false,
                type: "POST",
                dataType: 'json',
                success: function (returnedData) {
                    if (returnedData.ID === -1) {  //Invalido
                        swal("Oops", returnedData.Mensagem, "error");
                    } else {
                        if (returnedData.ID > 0) {
                            var data = returnedData.Item;
                            $('#DadosCliente_Endereco').val(data.Endereco);
                            $('#DadosCliente_Numero').val(data.Numero);
                            $('#DadosCliente_Complemento').val(data.Complemento);
                            $('#DadosCliente_Bairro').val(data.Bairro);
                            $('#DadosCliente_Cidade').val(data.Cidade);
                            $('#DadosCliente_UF').val(data.UF);
                        } else {
                            swal("Oops", "CEP não localizado", "info");
                        }
                    }
                }
            });
            return false;
        });
        //Validacao
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
                },
                DadosPagamento_DataExpiracao: {
                    required: true,
                    datacartao: true
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
