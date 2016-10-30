jQuery(document).ready(function () {
    $('#btnBuscar').click(function () { 
        var folio = $('#txtBuscar').val();
        //var token = $.cookie('cookieTipo');
        //var tipo = $.cookie('Tipo')
        //var tipo = $.cookie('cookieTipo').val();
        var tipo = "Sapal";
        buscarDenuncia(folio, tipo)
    });
    //$('#btnContinuarCfe').click(function () {
    //    var folio = $('#txt_idCfe').val();
    //    var tipo = 'Cfe'
    //    buscarDenuncia(folio, tipo)
    //});
    //$('#btnContinuarObra').click(function () {
    //    var folio = $('#txt_idObra').val();
    //    var tipo = 'Obra'
    //    buscarDenuncia(folio, tipo)
    //});
});
function buscarDenuncia(folio, tipo) {
    var objDenuncia = {
        "folio": folio,
        "categoria": tipo
    }
    var stringJsonDenuncia = JSON.stringify(objDenuncia);
    var datos = "{'d': " + stringJsonDenuncia + "}";
    var webMetod = "WebServiceQPDenuncia.asmx/MostrarHistoricos";
    $.ajax(
{
    //url: "http://localhost/WSQuery1/WJQueryREST.asmx/ListarUsuarios",
    url: webMetod,
    data: datos,
    dataType: "json",
    type: "POST",
    contentType: "application/json; utf-8",
    success: function (msg) {
        var datos_historicos = (typeof msg.d) === 'string' ? eval('(' + msg.d + ')') : msg.d;
        $('#pop' + tipo).hide();
        //$('.fade').collapse();
        //window.location.href("Index.aspx");
        //$('.fade').backGroundColor="transparent";
        $('#divHistoricos').empty();
        for (var i = 0; i < datos_historicos.length; i++) {
            var fecha = datos_historicos[i].fecha;
            var dependiente = datos_historicos[i].dependiente;
            var descripcion = datos_historicos[i].descripcion;
            $('#divHistoricos').append("<div class=\"row-fluid\" <div class=\"span4\" style=\"float:left;padding-left:20px;padding-bottom:20px\">" +
                               " <div class=\"block\">" +
                                  "  <h1>"+fecha+"</h1>"+
                                   " <p>"+descripcion+"</p>"
                                   +"<label>"+dependiente+"</label>"+
                               " </div>"+
                           " </div>");
        }
        $('#divHistoricos').append("</div>");
    },
    error: function (result) {
        alert('Error!');
    },
});
}