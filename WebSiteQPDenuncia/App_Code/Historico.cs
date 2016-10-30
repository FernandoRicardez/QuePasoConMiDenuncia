using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Historico
/// </summary>
namespace QPDenuncia.modelo
{
    public class Historico
    {
        public long idHistorico { get; set; }
        public String fecha { get; set; }
        public String dependiente { get; set; }
        public String descripcion { get; set; }
        public Denuncia idDenuncia { get; set; }
    }
}