var jsPage = function () {
    this.Limpar = function () {

    };

    this.AoAssociar = function () {

        $('#frmEsqueci').validate({
            rules: {
                Usuario: {
                    required: true,
                    email: true
                }
            },
            messages: {
                Usuario: {
                    required: "Campo Obrigatório",
                    email:"Por favor entre com um email válido"}

            },
            errorPlacement: function (error, element) {
                var placement = $(element).attr('data-error');
                if (placement) {
                    $(placement).append(error);
                } else {
                    error.insertAfter(element);
                }
            }
        });
    };

    this.Inicio = function () {
        this.AoAssociar();
    };

};

var ojsPage = new jsPage();
$(document).ready(function () {
    ojsPage.Inicio();
});