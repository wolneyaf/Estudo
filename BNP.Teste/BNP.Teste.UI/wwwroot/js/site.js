// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    HabilitarDesbilitarButon('True');
    CarregarProdutoCosif();

});

var filtroTeclas = function (event) {
    return ((event.charCode >= 48 && event.charCode <= 57) ||  event.charCode == 46);
}

function HabilitarDesbilitar(item, flag, btn) {
    var campo = $(item);
    if (flag === "True") {
        campo.attr('disabled', true);
        campo.attr('style', "cursor: not-allowed;");
        
        campo.removeClass(btn);
        campo.addClass("btn btn-light");        
    }
    else {
        campo.attr('disabled', false);
        campo.attr('style', "1");
        
        campo.removeClass("btn-light");
        campo.addClass("btn " + btn);
    }
}

function LimparCampos()
{
    $("div").find(".form-control").val("");
}

function HabilitaDesabilitaCampos(flag) {
    if (flag === "False") {
        $("div").find(".form-control").addClass("disabledItem");
        $("div").find(".form-control").attr('disabled', true);
    }
    else {
        $("div").find(".form-control").removeClass("disabledItem");
        $("div").find(".form-control").attr('disabled', false);
    }
}

function HabilitarDesbilitarButon(flag) {

    if (flag === "True") {
        HabilitarDesbilitar($('#btLimpar'), 'True', 'btn-info');
        HabilitarDesbilitar($('#btIncluir'), 'True', 'btn-primary');
        HabilitarDesbilitar($('#btNovo'), 'False', 'btn-secondary');
        HabilitaDesabilitaCampos("False");
    }
    else {
        HabilitarDesbilitar($('#btLimpar'), 'False', 'btn-info');
        HabilitarDesbilitar($('#btIncluir'), 'False', 'btn-primary');
        HabilitarDesbilitar($('#btNovo'), 'True', 'btn-secondary');
        HabilitaDesabilitaCampos("True");
    }

}
function CarregarProdutoCosif() {
    $("#cbProdutoCosif").empty();
    var codigo = $("#cbProduto").val().trim();
    $.ajax({
        type: "GET",
        url: "Home/BuscaProdutoCosif",
        data: { Codigo: codigo },
        contentType: "application/json; charset=utf-8",
        success: function (Data) {
            var strtag = "";

            var prod = JSON.parse(Data);

            for (i = 0; i < prod.length; i++) {
                strtag = strtag + "<option value='" + prod[i].CodigoCosif + "'>" + prod[i].Item + "</option>";
            }

            $("#cbProdutoCosif").append(strtag);
        }
    });
}