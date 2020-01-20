function jsPage() {
    this.Limpar = function () {
    };

    this.AoAssociar = function () {
        $('#tabSegurado').on('click', function () {
            $('#TabSegurado').attr('action', '/Segurado/DadosCadastrais');
            $('#TabSegurado').submit();
        });

        $('#tabProdutos').on('click', function () {
            $('#TabSegurado').attr('action', '/Apolice/ListaTodos');
            $('#TabSegurado').submit();
        });

        $('#tabKit').on('click', function () {
            if ($('#IdApolice').val() === null) {
                SweetAlert('Selecione antes o produto');
                return;
            }
            $('#TabSegurado').attr('action', '/Segurado/KitProduto');
            $('#TabSegurado').submit();
        });

        $('.SolicitaEnvio').click(function () {
            var tipo = $(this).data('item');
            ojsPage.SolicitaKitProduto(tipo);
        });

        //Formatação
        $('.moeda').autoNumeric('init', { digitGroupSeparator: '.', decimalCharacter: ',', aSign: 'R$ ' });

    };
    this.ValidaForm = function () {
        //Apolice 
        if ($('#ApoliceId').val() === "0") {
            swal.fire("Apolice não informada.", "Vá até a aba de produtos e selecione a apolice desejada", "warning");
            return false;
        }

        //Itens
        if (!$('#DocApolice').is(":checked") && !$('#Digital').is(":checked")) {
            swal.fire("Selecione um item", "informe ao menos um item para envio", "warning");
            return false;
        }
        return true;

    };
    this.SolicitaKitProduto = function (MeioEnvio) {
        if (!this.ValidaForm())
            return;

        var oURL = "/Segurado/SolicitarKitProduto";
        var oData = {
            ApoliceId: $('#ApoliceId').val(),
            EnviadoPorId: MeioEnvio,
            EnviarApolice: $('#DocApolice').is(":checked"),
            EnviarCartao: $('#Digital').is(":checked")
        };
        return $.ajax({
            data: oData,
            url: oURL,
            cache: false,
            type: "POST",
            dataType: 'json',
            success: function (returnedData) {
                if (returnedData.ID === 0) {  //Invalido
                    swal.fire('Ops!', returnedData.Mensagem, 'error');
                } else {
                    swal.fire('Solicitação Enviada', returnedData.Mensagem, 'success');
                }
            }
        });
    };


    this.Inicio = function () {
        this.AoAssociar();
    };
}

var ojsPage = new jsPage();
$(document).ready(function () {
    ojsPage.Inicio();
});

