var jsPage = function () {
    this.Limpar = function () {

    };

    this.AoAssociar = function () {
        //quando a janela for redimensionada, adaptamos a imagem
        $(window).resize(function () {
            ojsPage.adaptImage($('#fundo img'));
        });

        $('#frmLogar').validate({
            rules: {
                Usuario: {
                    required: true
                },
                Senha: {
                    required: true
                }
            },
            messages: {
                Usuario: { required: "Campo Obrigatório" },
                Senha: { required: "Campo Obrigatório" }

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

    this.adaptImage = function (targetimg) {
        var wheight = $(window).height(); // altura da janela do navegador
        var wwidth = $(window).width(); // largura da janela do navegador

        targetimg.removeAttr("width")
            .removeAttr("height")
            .css({ width: "", height: "" }); 

        var imgwidth = targetimg.width(); // largura da imagem
        var imgheight = targetimg.height(); // altura da imagem

        var destwidth = wwidth; // largura que a imagem deve ter
        var destheight = wheight; // altura que a imagem deve ter

        if (imgheight < wheight) {
            destwidth = (imgwidth * wheight) / imgheight;

            $('#fundo img').height(destheight);
            $('#fundo img').width(destwidth);
        }

        destheight = $('#fundo img').height();
        var posy = (destheight / 2 - wheight / 2);
        var posx = (destwidth / 2 - wwidth / 2);

        if (posy > 0) {
            posy *= -1;
        }
        if (posx > 0) {
            posx *= -1;
        }
        $('#fundo').css({ 'top': posy + 'px', 'left': posx + 'px' });
    };

    this.Inicio = function () {
        this.AoAssociar();
        $(window).resize();
    };

};

var ojsPage = new jsPage();
$(document).ready(function () {
    ojsPage.Inicio();
});