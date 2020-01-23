$.extend($.fn.dataTable.defaults, {
    autoFill: true,
    responsive: true,
    bFilter: false,
    lengthChange: false,
    pagingType: window.innerWidth > 1024 ? "simple_numbers" : "simple",
    pageLength: 7,
    lengthMenu: window.innerWidth < 1300 ? [[5, 10, 25, 50, -1], [5, 10, 25, 50, "Todos"]] : [[10, 25, 50, -1], [10, 25, 50, "Todos"]],
    language: {
        url: "/Scripts/Portuguese-Brasil.txt"
    }
});
$.fn.dataTable.ext.errMode = 'none';

jQuery.validator.addMethod("Whatsapp", function (value, element, data) {
    var checado = false;
    if (value === "0") {
        $(data).each(function () {
            if ($(this).is(':checked'))
                checado = true;
        });
    } else
        checado = true;
    return checado;
}, "Um dos telefones deve ser whatsapp.");

jQuery.validator.addMethod("AnoVeiculo", function (value, element, data) {
    var currentYear = (new Date).getFullYear();
    console.log(currentYear);
    if (value > currentYear) {
        return false;
    }
    return true;
}, "O ano deve ser menor ou igual o atual");

jQuery.validator.addMethod("Percent", function (value, element) {
    var sum = 0;
    $('.percent').each(function (atual, indice) {
        if (!isNaN($(this).val()))
            sum += Number($(this).val());
    });
    if (sum !== 100)
        return false;
    else
        return true;
}, "A soma tem de ser 100%.");

jQuery.validator.addMethod("require_from_any", function (value, element, data) {
    var naovazio = false;
    $(data).each(function () {
        var oval = $(this).val();
        if (oval !== "__/__/____" && oval !== '' && value !== null) {
            naovazio = true;
        }
    });

    if (value === "__/__/____" || value ==='' || value ===null)
        if (naovazio)
            return false;
        else
            return true;
    else
        return true;
}, "Este campo é requerido.");

jQuery.validator.addMethod("CardNumber", function (value, element) {
    //if (this.optional(b))
    //    return "dependency-mismatch";
    //if (/[^0-9 \-]+/.test(a))
    //    return !1;
    //var c, d, e = 0, f = 0, g = !1;
    //if (a = a.replace(/\D/g, ""), a.length < 13 || a.length > 19) return !1;
    //for (c = a.length - 1; c >= 0; c--)
    //    d = a.charAt(c), f = parseInt(d, 10), g && (f *= 2) > 9 && (f -= 9), e += f, g = !g;
    //return e % 10 === 0;
    return $.payment.validateCardNumber(value);
}, "Numero do Cartão Inválido.");

jQuery.validator.addMethod("CardCVC", function (value, element, data) {
    if (value === '')
        return true;
    var cardNumber = $(data).val();
    if (cardNumber !== '') {
        var type = $.payment.cardType(cardNumber);
        return $.payment.validateCardCVC(value, type);
    } else
        return true;
}, "Inválido");

jQuery.validator.addMethod("CardExpiry", function (value, element) {
    if (value === "") return true;
    if (value.length !== 9) return false;
    var partes = value.split('/');
    if (partes.length !== 2) return false;
    return $.payment.validateCardExpiry(partes[0], partes[1]);
}, "Data inválida");

jQuery.validator.addMethod("CPF", function (value, element) {
   return ValidaCPF(value);
}, "Informe um CPF válido");

jQuery.validator.addMethod("datanasc", function (value, element) {
    if (value === "") return true;
    if (value === "__/__/____") return true;
    if (value === "__/__/____   :  ") return true;
    if (value.length !== 10) return false;
    return value.match(/^(0[1-9]|[12][0-9]|3[01])[- \/.](0[1-9]|1[012])[- \/.](19|20)\d\d$/);
}, "Data inválida");

jQuery.extend(jQuery.validator.messages, {
    required: "Este campo &eacute; requerido.",
    remote: "Por favor, corrija este campo.",
    email: "Por favor, forne&ccedil;a um endere&ccedil;o eletr&ocirc;nico v&aacute;lido.",
    url: "Por favor, forne&ccedil;a uma URL v&aacute;lida.",
    date: "Por favor, forne&ccedil;a uma data v&aacute;lida.",
    dateISO: "Por favor, forne&ccedil;a uma data v&aacute;lida (ISO).",
    number: "Por favor, forne&ccedil;a um n&uacute;mero v&aacute;lido.",
    digits: "Por favor, forne&ccedil;a somente d&iacute;gitos.",
    creditcard: "Por favor, forne&ccedil;a um cart&atilde;o de cr&eacute;dito v&aacute;lido.",
    equalTo: "Por favor, forne&ccedil;a o mesmo valor novamente.",
    accept: "Por favor, forne&ccedil;a um valor com uma extens&atilde;o v&aacute;lida.",
    maxlength: jQuery.validator.format("Por favor, forne&ccedil;a n&atilde;o mais que {0} caracteres."),
    minlength: jQuery.validator.format("Por favor, forne&ccedil;a ao menos {0} caracteres."),
    rangelength: jQuery.validator.format("Por favor, forne&ccedil;a um valor entre {0} e {1} caracteres de comprimento."),
    range: jQuery.validator.format("Por favor, forne&ccedil;a um valor entre {0} e {1}."),
    max: jQuery.validator.format("Por favor, forne&ccedil;a um valor menor ou igual a {0}."),
    min: jQuery.validator.format("Por favor, forne&ccedil;a um valor maior ou igual a {0}."),
    step: "Por favor entre com um multiplo de {0}."
});

$(function () {
    $('.datanasc').mask('99/99/9999');
    $('.datacartao').mask('99/9999');
    $('.cpf').mask('999.999.999-99');
    $('.cep').mask('99999-999');
    $('.telfixo').mask("(99)9999-9999");
    $('.anoveiculo').mask("9999");
    $('.tel').mask("(99) 9999-9999?9")
        .focusout(function (event) {
            var target, phone, element;
            target = event.currentTarget ? event.currentTarget : event.srcElement;
            phone = target.value.replace(/\D/g, '');
            element = $(target);
            element.unmask();
            if (phone.length > 10) {
                element.mask("(99) 99999-999?9");
            } else {
                element.mask("(99) 9999-9999?9");
            }
        });

    $(document).ajaxError(function (event, request, settings) {
        swal("Oops", "Falha na chamada: " + settings.url, "error");
    });
});

function ValidaCPF(valor) {
    valor = valor.toString();
    valor = valor.replace(/[^0-9]/g, '');
    if (valor === '') return true;
    var digitos = valor.substr(0, 9);
    var novo_cpf = calc_digitos_posicoes(digitos);
    novo_cpf = calc_digitos_posicoes(novo_cpf, 11);
    if (novo_cpf === valor) {
        return true;
    } else {
        return false;
    }
}

function calc_digitos_posicoes(digitos, posicoes = 10, soma_digitos = 0) {

    digitos = digitos.toString();

    for (var i = 0; i < digitos.length; i++) {
        soma_digitos = soma_digitos + (digitos[i] * posicoes);
        posicoes--;
        if (posicoes < 2) {
            posicoes = 9;
        }
    }

    soma_digitos = soma_digitos % 11;
    if (soma_digitos < 2) {
        soma_digitos = 0;
    } else {
        soma_digitos = 11 - soma_digitos;
    }
    var cpf = digitos + soma_digitos;
    return cpf;
} 