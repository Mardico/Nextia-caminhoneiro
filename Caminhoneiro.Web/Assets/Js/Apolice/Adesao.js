function jsPage() {
    this.Limpar = function () {
    };
    this.AoAssociar = function () {
        //Adicinona Dependente
        $("#addLinha").on("click", function () {
            var Dados = { Proximo : $("#ListaDependentes").children.length };
            if ($("#ListaDependentes").children.length <= 10) {
                $("#tmpDependente").tmpl(Dados).appendTo("#ListaDependentes");
            } if ($("#ListaDependentes").children.length === 10) {
                $("#addLinha").attr("disabled", true);
            }
        });

        //remove linha
        $("#tableBeneficiario").on("click", "a.deleteLinhaBeneficiario", function (event) {
            $(this).closest(".linha-beneficiario").remove();
            $("#addLinhaBeneficiario").attr("disabled", false);
        });

        //Adicinona Beneficiario
        $("#addLinhaBeneficiario").on("click", function () {
            $("#tmpBeneficiario").tmpl(returnedData.Item).appendTo("#tableBeneficiario");
            if ($("#tableBeneficiario").children.length <= 3) {
                $("#tableBeneficiario").append(newRow);
            } if ($("#tableBeneficiario").children.length === 3) {
                $("#addLinhaBeneficiario").attr("disabled", true);
            }
        });
        //remove linha
        $("#tableBeneficiario").on("click", "a.deleteLinhaBeneficiario", function (event) {
            $(this).closest(".linha-beneficiario").remove();
            $("#addLinhaBeneficiario").attr("disabled", false);
        });

        //Alterna meio pgto
        $("#DadosPagamento_MeioPgtoId").on("change", function () {
            $('#divCartao').toggle();
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
