var cargarH =
{
    cargarHistoricos: function () {
        var objDenuncia = {
            "folio": "kml123",
            "categoria": "Sapal"
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
           $('#divHistoricos').empty();
           for (var i = 0; i < datos_historicos.length; i++) {
               var fecha = datos_historicos[i].fecha;
               var dependiente = datos_historicos[i].dependiente;
               var descripcion = datos_historicos[i].descripcion;
               $('#divHistoricos').append("<div><label>" + fecha + "</label><br/>" +
                                         "<label>" + descripcion + "</label>" +
                                         "<label>" + dependiente + "</label><br/>");
           }
       },
       error: function (result) {
           alert('Error!');
       },
   });
    }
}