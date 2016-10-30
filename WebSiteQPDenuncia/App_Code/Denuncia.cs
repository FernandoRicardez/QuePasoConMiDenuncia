using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Denuncia
/// </summary>
namespace QPDenuncia.modelo
{
    public class Denuncia
    {
        public long idDenuncia { get; set; }
        public String folio { get; set; }
        public int estatus { get; set; }
        public String categoria { get; set; }
    }
}