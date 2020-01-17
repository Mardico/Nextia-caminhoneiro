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

        $('.ReenviarKit').on('click', function () {
            var ID = $(this).data('item');
            $('#ApoliceId').val(ID);
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').attr('action', '/Segurado/KitProduto');
            $('#TabSegurado').submit();
        });
        $('.Editar').on('click', function () {
            var ID = $(this).data('item');
            $('#Id').val(ID);
            $('#TabSegurado').attr('action', '/Apolice/EditarApolice');
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').submit();
        });

        $('.Visualizar').on('click', function () {
            var ID = $(this).data('item');
            $('#ApoliceId').val(ID);
            $('#TabSegurado').attr('action', '/Apolice/ConsultarApolice');
            $('#TabSegurado').attr('target', '_self');
            $('#TabSegurado').submit();
        });
        
        $('.Imprimir').on('click', function () {
            var ID = $(this).data('item');
            $('#ApoliceId').val(ID);
            $('#TabSegurado').attr('action', '/Apolice/Impressao');
            $('#TabSegurado').attr('target', '_blank');
            $('#TabSegurado').submit();
        });

        $('.Cancelar').on('click', function () {
            var ID = $(this).data('item');
            var nome = $(this).data('name');
            ojsPage.AoExcluir(ID, nome);
        });
    };
    this.Inicio = function () {
        this.AoAssociar();
    };
    this.AoExcluir = function (id, name) {
        var Mensagem = "A exclusão do Produto [" + name + "] ,não poderá ser desfeita!";
        swal({
            title: "Deseja excluir o produto?",
            text: Mensagem,
            type: "warning",
            confirmButtonColor: "#DD6B55",
            confirmButtonText: "Sim, Exclua o Produto!",
            buttons: true,
            dangerMode: true
        }).then((willDelete) => {
            if (willDelete)
                ojsPage.Excluir(id);
        });
        return false;
    };
    this.Excluir = function (id) {
        $.ajax({
            url: '/Apolice/Excluir',
            data: { Id: id },
            cache: false,
            type: "POST",
            dataType: 'json',
            success: function (returnedData) {
                if (returnedData.ID === -1) {  //Invalido
                    swal("Oops", "Ocorreu uma falha ao excluir a apolice", "error");
                } else {  //Sucesso
                    swal("Apagado!", "A Apolice foi excluída.", "success");
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                swal("Oops", textStatus, "error");
            }
        });
    };
    var table = $('.table');
    table.on('error.dt', function (e, settings, techNote, message) {
        swal("Oops", message, "error");
    }).DataTable({
        "processing": false,
        "serverSide": false,
        "deferRender": true,
        "columns": [
            { "data": "DadosProduto.Nome", "name": "Nome do Produto", "Type": "Text" },
            { "data": "Codigo", "name": "Número da Proposta", "Type": "Text" },
            { "data": "Endosso", "name": "Endosso", "Type": "Date" },
            { "data": "DataInicio", "name": "Data Inicio", "Type":"Date"},
            { "data": "Status", "name": "Status", "Type":"Date"},
            { "data": "", "name": "Ação"},
        ],
    });
}

var ojsPage = new jsPage();
$(function () {
    ojsPage.Inicio();
});
