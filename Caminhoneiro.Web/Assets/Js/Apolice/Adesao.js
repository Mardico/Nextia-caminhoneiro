function jsPage() {
    this.Limpar = function () {
    };

    this.AoAssociar = function () {
        //Adicinona Dependente
        $("#addLinha").on("click", function () {
            var Dados = { Proximo: $("#ListaDependentes").children().children().length };
            if ($("#ListaDependentes").children().children().length <= 10) {
                ojsPage.CarregaDepFilhos();
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
            if ($("#tableBeneficiario").children().length <= 3) {
                ojsPage.CarregaBeneficiario();
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

        //Close MsgSucesso
        $("#btnConfirmar").click(function () {
            $("#modal-sucesso").modal("hide");
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
                DadosCliente_TelefoneFixo: {
                    require_from_group: [1, ".tel"]
                },
                DadosCliente_TelefoneCelular: {
                    require_from_group: [1, ".tel"]
                },
                DadosCliente_TelefoneSecundario: {
                    require_from_group: [1, ".tel"]
                },
                DadosCliente_TelefoneAdicional: {
                    require_from_group: [1, ".tel"]
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
                DadosCliente_TelefoneFixo: { require_from_group: "Informe pelo menos um tel" },
                DadosCliente_TelefoneCelular: { require_from_group: "" },
                DadosCliente_TelefoneSecundario: { require_from_group: "" },
                DadosCliente_TelefoneAdicional: { require_from_group: "" },
                DadosPagamento_CVV: { required: "requerido" }

            }
        });
        $('input[required="required"').rules('add', 'required');
        $('.credicard').rules('add', 'credicard');

        //Salvar Rascunho
        $('#btnRascunho').on('click', function () {
            $('#frmDados').valid();
            if ($('.error:visible').length === 0)
                ojsPage.Salvar(1);

        });
        //Salvar
        $('#btnSalvar').on('click', function () {
            $('#frmDados').valid();
            if ($('.error:visible').length === 0)
                ojsPage.Salvar(1);

        });

        //Formatação
        $('.moeda').autoNumeric('init', { digitGroupSeparator: '.', decimalCharacter: ',', aSign: 'R$ ' });

        //trava edição se informado
        if ($('#VinculoId').val() !== "")
            $('#VinculoId').attr('readonly', true);

        //Carrega dependentes Conjuge caso não exista
        var hasConjuge = $('#hasConjuge').length > 0;
        var hasFilhos = $("#ListaDependentes").length > 0;
        if (!hasConjuge) {
            this.CarregaDepConjuge();
        }
        if (!hasFilhos) {
            this.CarregaDepFilhos();
        }

        //Carrega beneficiario
        var hasBeneficiario = $('#tableBeneficiario').children().length > 0;
        if (!hasBeneficiario) {
            this.CarregaBeneficiario();
        }
    };

    this.CarregaDepConjuge = function () {
        var NDependentes = parseInt($('#NDependentes').val());
        $('#DepConjuge').prepend($("#tmpDepConjuge").html().replace(/DadosDependente_/gi, 'DadosDependente_' + NDependentes + '__').replace(/NameDependente./gi, 'DadosDependente[' + NDependentes + '].'));
        $('#NDependentes').val(NDependentes + 1);
    };
    this.CarregaDepFilhos = function () {
        var NDependentes = parseInt($('#NDependentes').val());
        var html = $("#tmpDependente").html().replace(/DadosDependente_/gi, 'DadosDependente_' + NDependentes + '__').replace(/NameDependente./gi, 'DadosDependente[' + NDependentes + '].');
        $('#DepFilhos').prepend(html);
        $('#NDependentes').val(NDependentes + 1);
    };
    this.CarregaBeneficiario = function () {
        var NBeneficiarios = $('#tableBeneficiario').children().length;
        $('#tableBeneficiario').append($("#tmpBeneficiario").html().replace(/DadosBeneficiario_/gi, 'DadosBeneficiario_' + NBeneficiarios + '__').replace(/DadosBeneficiario./gi, 'DadosBeneficiario[' + NBeneficiarios + '].'));
    };
    this.Salvar = function (Status) {
        var dataBene = [];
        var dataDep = [];
        var NDependentes = parseInt($('#NDependentes').val());
        for (var i = 0; i < NDependentes; i++) {
            if ($('#DadosDependente_' + i + '__Nome') !== "")
                dataDep.push({
                    Id: $('#DadosDependente_' + i + '__Id').val(),
                    Tipo: $('#DadosDependente_' + i + '__Tipo').val(),
                    Nome: $('#DadosDependente_' + i + '__Nome').val(),
                    DataNasc: $('#DadosDependente_' + i + '__DataNasc').val()
                });
        }

        for (var a = 0; a < $("#ListaDependentes").children().length; a++) {
            if ($('#Beneficiario_Nome')[a].val() !== "")
                dataBene.push({
                    Nome: $('#DadosBeneficiario_' + a + '__Nome')[a].val(),
                    NDocumento: $('#DadosBeneficiario_' + a + '__NDocumento')[a].val(),
                    DataNasc: $('#DadosBeneficiario_' + a + '__DataNasc')[a].val(),
                    SexoId: $('#DadosBeneficiario_' + a + '__SexoId')[a].val(),
                    Parentesco: $('#DadosBeneficiario_' + a + '__Parentesco')[a].val(),
                    Porcentagem: $('#DadosBeneficiario_' + a + '__Porcentagem')[a].val()
                });
        }

        var data = {
            "Id": $("#Id").val(),
            "VinculoId": $("#VinculoId").val(),
            "UsuarioId": $("#UsuarioId").val(),
            "DadosBeneficiario": dataBene,
            "DadosDependente": dataDep,
            "DadosProdutoId": $("#UsuarioId").val(),
            "DadosCliente": {
                "Id": $("#UsuarioId").val(),
                "Nome": $("#DadosCliente.Nome").val(),
                "CPF": $("#DadosCliente.CPF").val(),
                "SexoId": $("#DadosCliente.SexoId").val(),
                "DataNascimento": $("#DadosCliente.DataNascimento").val(),
                "EstadoCivilId": $("#DadosCliente.EstadoCivilId").val(),
                "Email": $("#DadosCliente.Email").val(),
                "CEP": $("#DadosCliente.CEP").val(),
                "Endereco": $("#DadosCliente.Endereco").val(),
                "Numero": $("#DadosCliente.Numero").val(),
                "Complemento": $("#DadosCliente.Complemento").val(),
                "Bairro": $("#DadosCliente.Bairro").val(),
                "Cidade": $("#DadosCliente.Cidade").val(),
                "UF": $("#DadosCliente.UF").val(),
                "TelefoneFixo": $("#DadosCliente.TelefoneFixo").val(),
                "TelefoneCelular": $("#DadosCliente.TelefoneCelular").val(),
                "TelefoneSecundario": $("#DadosCliente.TelefoneSecundario").val(),
                "TelefoneAdicional": $("#DadosCliente.TelefoneAdicional").val(),
                "ContactarPorId": $("#DadosCliente.ContactarPorId").val()
            },
            "DadosClienteId": $("#DadosClienteId").val(),
            "DadosVeiculoId": $("#DadosVeiculoId").val(),
            "DadosVeiculo": {
                "Id": $("#DadosVeiculoId").val(),
                "VeiculoID": $("#DadosVeiculo.VeiculoID").val(),
                "Segurado": $("#DadosVeiculo.Segurado").val(),
                "SeguradoraId": $("#DadosVeiculo.SeguradoraId").val(),
                "VeiculoProprioId": $("#DadosVeiculo.VeiculoProprioId").val(),
                "QdadeViagensId": $("#DadosVeiculo.QdadeViagensId").val(),
                "TipoEntregaId": $("#DadosVeiculo.TipoEntregaId").val(),
                "RendaLiquidaId": $("#DadosVeiculo.RendaLiquidaId").val(),
                "SolicitouServApolice": $("#DadosVeiculo.SolicitouServApolice").val()
            },
            "DadosPagamentoId": $("#DadosPagamentoId").val(),
            "StatusId": Status,
            "DadosPagamento": {
                "Id": $("#DadosPagamentoId").val(),
                "MeioPgtoId": $("#DadosPagamento.MeioPgtoId").val(),
                "Conta": $("#DadosPagamento.Conta").val(),
                "NomeResponsavel": $("#DadosPagamento.NomeResponsavel").val(),
                "DataExpiracao": $("#DadosPagamento.DataExpiracao").val(),
                "CVV": $("#DadosPagamento.CVV").val()
            }
        };

        return $.ajax({
            data: data,
            url: oURL,
            cache: false,
            type: "POST",
            dataType: 'json',
            success: function (returnedData) {
                if (returnedData.ID === 0) {  //Invalido
                    swal("Oops", returnedData.Mensagem, "error");
                } else {
                    returnedData.Item;
                    $('#modal-sucesso').html(returnedData.Item.Codigo);
                    $("#myModal").modal();
                }
            }
        });
    };
    this.SalvaAdesao = function () {
        //
    };
    this.Inicio = function () {
        this.AoAssociar();
    };
}

var ojsPage = new jsPage();
$(function () {
    ojsPage.Inicio();
});
