$.extend($.fn.dataTable.defaults, {
    autoFill: true,
    responsive: true,
    "pagingType": (window.innerWidth > 1024 ? "simple_numbers" : "simple"),
    pageLength: (window.innerWidth < 1300 ? 5 : 10),
    lengthMenu: (window.innerWidth < 1300 ? [[5, 10, 25, 50, -1], [5, 10, 25, 50, "Todos"]] : [[10, 25, 50, -1], [10, 25, 50, "Todos"]]),
    language: {
        url: "/Scripts/Portuguese-Brasil.json"
    }
});
$.fn.dataTable.ext.errMode = 'none';

$(function () {
    $('.cpf').mask('999.999.999-99');
    $('.tel').mask("(99) 9999-9999?9")
        .focusout(function (event) {
            var target, phone, element;
            target = (event.currentTarget) ? event.currentTarget : event.srcElement;
            phone = target.value.replace(/\D/g, '');
            element = $(target);
            element.unmask();
            if (phone.length > 10) {
                element.mask("(99) 99999-999?9");
            } else {
                element.mask("(99) 9999-9999?9");
            }
        });
});

$(document).ajaxError(function (event, request, settings) {
    swal("Oops", "Error requesting page: " + settings.url, "error");
});