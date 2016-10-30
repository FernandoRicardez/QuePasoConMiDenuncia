using QPDenuncia.modelo;
using QPDenuncia.procs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebServiceQPDenuncia
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebServiceQPDenuncia : System.Web.Services.WebService
{

    public WebServiceQPDenuncia()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent();
    }

    [WebMethod]
    public List<Historico> MostrarHistoricos(Denuncia d)
    {
        Procedimientos _p = new Procedimientos();
        return _p.ListarHistoricos(d);
    }

}
