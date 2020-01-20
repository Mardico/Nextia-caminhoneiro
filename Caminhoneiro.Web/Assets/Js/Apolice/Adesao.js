function jsPage() {
    this.Limpar = function () {
    };
    this.AoAssociar = function () {
        //Adicinona Dependente
        $("#addLinha").on("click", function () {
            var Dados = { Proximo: $("#DepFilhos").children().length };
            if ($("#DepFilhos").children().length < 10) {
                ojsPage.CarregaDepFilhos();
            }
            if ($("#DepFilhos").children().length > 9) {
                $("#addLinha").attr("disabled", true);
            }
        });
        //remove linha
        $("#DepFilhos").on("click", ".deleteLinha", function (event) {
            $(this).parent().parent().remove();
            $("#addLinha").attr("disabled", false);
        });
        //Adicinona Beneficiario
        $("#addLinhaBeneficiario").on("click", function () {
            if ($("#tableBeneficiario").children().length < 3) {
                ojsPage.CarregaBeneficiario();
            }

            if ($("#tableBeneficiario").children().length > 2) {
                $("#addLinhaBeneficiario").attr("disabled", true);
            }
        });
        //remove linha
        $("#tableBeneficiario").on("click", ".deleteLinhaBeneficiario", function (event) {
            $(this).parent().parent().parent().remove();
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
            window.location.href = '/';
        });
        $('.cc-number').on('change', function () {
            if ($('.cc-number').val() !== '') {
                var cardType = $.payment.cardType($('.cc-number').val());
                if (cardType === 'dinersclub' || cardType === 'visa' || cardType === 'maestro' || cardType === 'mastercard' || cardType === 'amex')
                    $('#credicardtype').attr('src', '/Assets/img/' + cardType + '.jpg');
                else
                    $('#credicardtype').attr('src', '/Assets/img/error.jpg');
            }
        });

        //Validacao
        $('#frmDados').validate({
            rules: {
                DadosCliente_CPF: {
                    CPF: true
                },
                DadosCliente_Email: {
                    email: true
                },
                DadosCliente_DataNascimento: {
                    datanasc: true
                }
            },
            messages: {
                DadosCliente_TelefoneFixo: { require_from_group: "Informe pelo menos um tel" },
                DadosCliente_TelefoneCelular: { require_from_group: "" },
                DadosCliente_TelefoneSecundario: { require_from_group: "" },
                DadosCliente_TelefoneAdicional: { require_from_group: "" }

            }
        });
        $('input[required="required"').rules('add', 'required');
        $('.contactar').rules('add', { Whatsapp: ".whatsapp" });
        $('.cc-number').rules('add', 'CardNumber');
        $('.cc-cvc').rules('add', { CardCVC: '.cc-number' });
        $('.cc-exp').rules('add', 'CardExpiry');
        $('.tel').rules('add', {
            require_from_group: [1, ".tel"],
            messages: {
                require_from_group: "Informe pelo menos um tel"
            }
        });

        $('.cc-number').payment('formatCardNumber');
        $('.cc-exp').payment('formatCardExpiry');
        $('.cc-cvc').payment('formatCardCVC');

        //Formatação
        $('.moeda').autoNumeric('init', { digitGroupSeparator: '.', decimalCharacter: ',', aSign: 'R$ ' });

        //trava edição se informado
        if ($('#VinculoId').val() !== "")
            $('#VinculoId').attr('disabled', true);

        //Carrega dependentes Conjuge caso não exista
        var hasConjuge = $('#hasConjuge').length > 0;
        var hasFilhos = $("#DepFilhos").children().length > 0;
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

        $('.percent').rules('add', 'Percent');


        //Salvar Rascunho
        $('#btnRascunho').on('click', function () {
            $('#frmDados').valid();
            ojsPage.Salvar(0);

        });
        //Salvar
        $('#btnSalvar').on('click', function () {
            $('#frmDados').valid();
            if ($('.error:visible').length === 0)
                ojsPage.Salvar(1);
            else
                swal("Existem campos não preenchidos", "Preencha os campos faltantes", "warning");
        });


    };
    this.CarregaDepConjuge = function () {
        var NDependentes = parseInt($('#NDependentes').val());
        var html = $("#tmpDepConjuge").html().replace(/DadosDependente./gi, 'DadosDependente_' + NDependentes + '__');
        html = html.replace(/NameDependente/gi, 'DadosDependente[' + NDependentes + ']');
        html = html.replace(/classdep/g, 'classdep' + NDependentes);
        $('#DepConjuge').prepend(html);
        $('#NDependentes').val(NDependentes + 1);

        var txtNome = '#DadosDependente_' + NDependentes + '__Nome';
        var txtDataNasc = '#DadosDependente_' + NDependentes + '__DataNasc';
        $(txtNome).rules('add', {
            require_from_any: ".classdep" + NDependentes,
            messages: {
                require_from_group: "Requerido"
            }
        });
        $(txtDataNasc).rules('add', {
            require_from_any: ".classdep" + NDependentes,
            messages: {
                require_from_group: "Requerido"
            }
        });
        $(txtDataNasc).mask('99/99/9999');
    };
    this.CarregaDepFilhos = function () {
        var NDependentes = parseInt($('#NDependentes').val());
        var html = $("#tmpDependente").html().replace(/DadosDependente./gi, 'DadosDependente_' + NDependentes + '__');
        html = html.replace(/NameDependente/gi, 'DadosDependente[' + NDependentes + ']');
        html = html.replace(/classdep/g, 'classdep' + NDependentes);
        html = html.replace(/chave/g, 'chave' + NDependentes);
        $('#DepFilhos').append(html);
        if (NDependentes < 2)
            $('.chave' + NDependentes).hide();

        $('#NDependentes').val(NDependentes + 1);


        var txtNome = '#DadosDependente_' + NDependentes + '__Nome';
        var txtDataNasc = '#DadosDependente_' + NDependentes + '__DataNasc';
        $(txtNome).rules('add', {
            require_from_any: ".classdep" + NDependentes,
            messages: {
                require_from_group: "requerido"
            }
        });
        $(txtDataNasc).rules('add', {
            require_from_any: ".classdep" + NDependentes,
            messages: {
                require_from_group: "requerido"
            }
        });
        $(txtDataNasc).mask('99/99/9999');
    };
    this.CarregaBeneficiario = function () {
        var NBeneficiarios = $('#tableBeneficiario').children().length;
        var html = $("#tmpBeneficiario").html().replace(/DadosBeneficiario./gi, 'DadosBeneficiario_' + NBeneficiarios + '__');
        html = html.replace(/NameBeneficiario/gi, 'NameBeneficiario[' + NBeneficiarios + ']');
        html = html.replace(/classbene/g, 'classbene' + NBeneficiarios);
        html = html.replace(/chavebene/g, 'chavebene' + NBeneficiarios);

        $('#tableBeneficiario').append(html);
        if (NBeneficiarios < 1)
            $('.chavebene' + NBeneficiarios).hide();


        var txtNome = '#DadosBeneficiario_' + NBeneficiarios + '__Nome';
        var txtNDocumento = '#DadosBeneficiario_' + NBeneficiarios + '__NDocumento';
        var txtDataNasc = '#DadosBeneficiario_' + NBeneficiarios + '__DataNasc';
        var txtSexoId = '#DadosBeneficiario_' + NBeneficiarios + '__SexoId';
        var txtParentesco = '#DadosBeneficiario_' + NBeneficiarios + '__Parentesco';
        var txtPorcentagem = '#DadosBeneficiario_' + NBeneficiarios + '__Porcentagem';
        var classname = ".classbene" + NBeneficiarios;
        $(txtDataNasc).mask('99/99/9999');
        $(txtNome).rules('add', {
            require_from_any: classname,
            messages: {
                require_from_group: "requerido"
            }
        });
        $(txtNDocumento).rules('add', {
            require_from_any: classname,
            messages: {
                require_from_group: "requerido"
            }
        });
        $(txtDataNasc).rules('add', {
            require_from_any: classname,
            messages: {
                require_from_group: "requerido"
            }
        });
        $(txtDataNasc).rules('add', {
            require_from_any: classname,
            messages: {
                require_from_group: "requerido"
            }
        });
        $(txtSexoId).rules('add', {
            require_from_any: classname,
            messages: {
                require_from_group: "requerido"
            }
        });
        $(txtParentesco).rules('add', {
            require_from_any: classname,
            messages: {
                require_from_group: "requerido"
            }
        });

        $(txtPorcentagem).rules('add', {
            Percent: ["percent"],
            require_from_any: classname
        });
        $(txtPorcentagem).on('keypress', function () {
            if (!isNaN(this.value)){
                if (parseInt(this.value) >= 100) {
                    this.value = 100;
                    return false;
                }
                if (parseInt(this.value) < 1) {
                    this.value = 1;
                    return false;
                }
            }
        });

    };
    this.Salvar = function (Status) {
        var dataBene = [];
        var dataDep = [];
        var NDependentes = parseInt($('#NDependentes').val());
        for (var i = 0; i < NDependentes; i++) {
            if ($('#DadosDependente_' + i + '__Nome').val() !== "")
                dataDep.push({
                    Id: $('#DadosDependente_' + i + '__Id').val(),
                    Tipo: $('#DadosDependente_' + i + '__Tipo').val(),
                    Nome: $('#DadosDependente_' + i + '__Nome').val(),
                    DataNasc: $('#DadosDependente_' + i + '__DataNasc').val()
                });
        }

        for (var a = 0; a < $("#tableBeneficiario").children().length; a++) {
            if ($('#DadosBeneficiario_' + a + '__Nome').val() !== "")
                dataBene.push({
                    Nome: $('#DadosBeneficiario_' + a + '__Nome').val(),
                    NDocumento: $('#DadosBeneficiario_' + a + '__NDocumento').val(),
                    DataNasc: $('#DadosBeneficiario_' + a + '__DataNasc').val(),
                    SexoId: $('#DadosBeneficiario_' + a + '__SexoId').val(),
                    Parentesco: $('#DadosBeneficiario_' + a + '__Parentesco').val(),
                    Porcentagem: $('#DadosBeneficiario_' + a + '__Porcentagem').val()
                });
        }

        var data = {
            "Id": $("#Id").val(),
            "VinculoId": $("#VinculoId").val(),
            "UsuarioId": $("#UsuarioId").val(),
            "DadosBeneficiario": dataBene,
            "DadosDependente": dataDep,
            "DadosProdutoId": $("#DadosProdutoId").val(),
            "DadosProduto": {
                "ProdutoId": $("#DadosProduto_ProdutoId").val()
            },
            "DadosCliente": {
                "Id": $("#UsuarioId").val(),
                "Nome": $("#DadosCliente_Nome").val(),
                "CPF": $("#DadosCliente_CPF").val(),
                "SexoId": $("#DadosCliente_SexoId").val(),
                "DataNascimento": $("#DadosCliente_DataNascimento").val(),
                "EstadoCivilId": $("#DadosCliente_EstadoCivilId").val(),
                "Email": $("#DadosCliente_Email").val(),
                "CEP": $("#DadosCliente_CEP").val(),
                "Endereco": $("#DadosCliente_Endereco").val(),
                "Numero": $("#DadosCliente_Numero").val(),
                "Complemento": $("#DadosCliente_Complemento").val(),
                "Bairro": $("#DadosCliente_Bairro").val(),
                "Cidade": $("#DadosCliente_Cidade").val(),
                "UF": $("#DadosCliente_UF").val(),
                "TelefoneFixo": $("#DadosCliente_TelefoneFixo").val(),
                "TelefoneCelular": $("#DadosCliente_TelefoneCelular").val(),
                "TelefoneSecundario": $("#DadosCliente_TelefoneSecundario").val(),
                "TelefoneAdicional": $("#DadosCliente_TelefoneAdicional").val(),
                "EWhatApp1": $("#WhatApp1").val(),
                "EWhatApp2": $("#WhatApp2").val(),
                "EWhatApp3": $("#WhatApp3").val(),
                "ContactarPorId": $("#DadosCliente_ContactarPorId").val()
            },
            "DadosClienteId": $("#DadosClienteId").val(),
            "DadosVeiculoId": $("#DadosVeiculoId").val(),
            "DadosVeiculo": {
                "Id": $("#DadosVeiculoId").val(),
                "VeiculoID": $("#DadosVeiculo_VeiculoID").val(),
                "Segurado": $("#DadosVeiculo_Segurado").val()==="0"?false:true,
                "SeguradoraId": $("#DadosVeiculo_SeguradoraId").val(),
                "VeiculoProprioId": $("#DadosVeiculo_VeiculoProprioId").val(),
                "QdadeViagensId": $("#DadosVeiculo_QdadeViagensId").val(),
                "TipoEntregaId": $("#DadosVeiculo_TipoEntregaId").val(),
                "RendaLiquidaId": $("#DadosVeiculo_RendaLiquidaId").val(),
                "SolicitouServApolice": $("#DadosVeiculo_SolicitouServApolice").val() === "0" ? false : true
            },
            "DadosPagamentoId": $("#DadosPagamentoId").val(),
            "StatusId": Status,
            "DadosPagamento": {
                "Id": $("#DadosPagamentoId").val(),
                "MeioPgtoId": $("#DadosPagamento_MeioPgtoId").val(),
                "Conta": $("#DadosPagamento_Conta").val(),
                "NomeResponsavel": $("#DadosPagamento_NomeResponsavel").val(),
                "DataExpiracao": $("#DadosPagamento_DataExpiracao").val(),
                "CVV": $("#DadosPagamento_CVV").val()
            }
        };
        $('#MsgApoliceId').html('');
        return $.ajax({
            data: data,
            url: '/Apolice/Salvar',
            cache: false,
            type: "POST",
            dataType: 'json',
            success: function (returnedData) {
                if (returnedData.ID === 0) {  //Invalido
                    swal("Oops", returnedData.Mensagem, "error");
                } else {
                    returnedData.Item;
                    $("#Id").val(returnedData.Item.Id);
                    $('#MsgApoliceId').html(returnedData.Item.Codigo);
                    $("#modal-sucesso").modal('show');
                }
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
