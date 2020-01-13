$(document).ready(function () {
    var contador = 1;
    //adiciona nova linha
    $("#addLinha").on("click", function () {
        var newRow = $("<tr>");
        var cols = "";
        cols += '<td><input type="text" class="form-control" placeholder="Nome Filho(a)" name="first_name" /></td>';
        cols += '<td><input oninput="mascara(this, " data")" type="text" class="form-control" placeholder="Data Nascimento Filho" name="last_name" /></td>';
        cols += '<td><a class=" deleteLinha nav-icon far fa-arrow-alt-circle-up"></a></td>';
        newRow.append(cols);
        contador++;
        if (contador <= 10) {
            $("#products-table").append(newRow);
        } if (contador == 10) {
            $("#addLinha").attr("disabled", true);
        }
    });

    //remove linha
    $("#products-table").on("click", "a.deleteLinha", function (event) {
        $(this).closest("tr").remove();
        $("#addLinha").attr("disabled", false);
        contador--;
    });
});

$(document).ready(function () {
    var contador = 1;
    //adiciona nova linha
    $("#addLinhaBeneficiario").on("click", function () {
        var newRow = $("<div class='row linha-beneficiario' style='border-bottom: 1px solid rgba(0, 0, 0, 0.2); margin: 5px;'>");
        var cols = "";

        cols += "<div class='col-lg-6'>"
            + "<div class='form-group'>"
            + "<label>Nome</label>"
            + "<input type='text' class='form-control' placeholder='Nome do Beneficiário'>"
            + "</div>"
            + "</div>";

        cols += "<div class='col-lg-3'>"
            + "<div class='form-group'>"
            + "<label>Doc. Identificação</label>"
            + "<input type='text' class='form-control rg-beneficiario' placeholder='Doc. Identificação'>"
            + "</div>"
            + "</div>";

        cols += "<div class='col-lg-3'>"
            + "<div class='form-group'>"
            + "<label>Data Nascimento</label>"
            + "<input oninput='mascara(this, ' data')' class='form-control' placeholder='dd/mm/aaaa'>"
            + "</div>"
            + "</div>";

        cols += "<div class='col-lg-3'>"
            + "<div class='form-group'>"
            + "<label>Sexo</label>"
            + "<select class='form-control'>"
            + "<option>Feminino</option>"
            + "<option>Masculino</option>"
            + "<option>Outro</option>"
            + "</select>"
            + "</div>"
            + "</div>";

        cols += "<div class='col-lg-5'>"
            + "<div class='form-group'>"
            + "<label>Grau de parentesco</label>"
            + "<input type='text' class='form-control' max='100' placeholder='Grau'>"
            + "</div>"
            + "</div>";

        cols += "<div class='col-lg-4'>"
            + "<div class='form-group'>"
            + "<label>Porcentagem(%) do Beneficiário</label>"
            + "<input type='number' class='form-control' placeholder='Porcentagem'>"
            + "</div>"
            + "</div>"
            + "<div class='col-lg-11'></div>"
            + "<div class='col-lg-1'><a class='deleteLinhaBeneficiario nav-icon far fa-arrow-alt-circle-up' style='margin:5px; cursor:pointer'></a></div>"
            + "</div>";

        newRow.append(cols);
        contador++;

        if (contador <= 3) {
            $("#tableBeneficiario").append(newRow);
        } if (contador == 3) {
            $("#addLinhaBeneficiario").attr("disabled", true);
        }
    });
    //remove linha
    $("#tableBeneficiario").on("click", "a.deleteLinhaBeneficiario", function (event) {
        $(this).closest(".linha-beneficiario").remove();
        $("#addLinhaBeneficiario").attr("disabled", false);
        contador--;
    });

    $("select").on("change", function () {
        var valor = $(this).val();   // aqui vc pega cada valor selecionado com o this
        if (valor === "um")
            var c = Mostrar("minhaDiv");
        else
            var e = Esconder("minhaDiv");
    });
});

var maskCpfOuCnpj = IMask(document.getElementById('cpfcnpj'), {
    mask: [
        {
            mask: '000.000.000-00',
            maxLength: 11
        },
        {
            mask: '00.000.000/0000-00'
        }
    ]
});

var maskBeneficiarioRg = IMask(document.querySelector('.rg-beneficiario'), {
    mask: [
        {
            mask: '00.000.000-0',
            maxLength: 9
        }
    ]
});


function Mostrar(el) {
    var display = document.getElementById(el).style.display;
    if (display === "none")
        document.getElementById(el).style.display = 'block';
}
function Esconder(el) {
    var display = document.getElementById(el).style.display;
    if (display === "block")
        document.getElementById(el).style.display = 'none';
}

