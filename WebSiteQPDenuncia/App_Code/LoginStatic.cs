using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoginStatic
/// </summary>
namespace QPDenuncia.estatic
{
    public class LoginStatic
    {
        public static string ReturnConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ServidorBD"].ToString();
        }
    }
}