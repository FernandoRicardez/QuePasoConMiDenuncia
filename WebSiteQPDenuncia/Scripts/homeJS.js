jQuery(document).ready(function () {
    $('#btnSapal').click(function () {
         var tipo = 'Sapal'
        buscarDenuncia( tipo)
    });
    $('#btnCfe').click(function () { 
        var tipo = 'Cfe'
        buscarDenuncia( tipo)
    });
    $('#btnObra').click(function () {
        var tipo = 'Obra'
        buscarDenuncia( tipo)
    });
});

function buscarDenuncia( tipo) {
    /*
    try {
        if ($.cookie('cookieTipo') != null) {
            $.cookie('cookieTipo') = null;
        }
    } catch (Exception) {
        //$.cookie('cTipo', tipo, { expires: 1, path: '/' });
        var JSONToken = { Tipo: tipo }
        $.cookie('cookieTipo', JSON.stringify(JSONToken), { expires: 1, path: '/' });
    }*/
    window.location.href('Admin.aspx');
} 