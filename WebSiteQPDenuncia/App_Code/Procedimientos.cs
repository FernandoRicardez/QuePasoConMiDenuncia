using QPDenuncia.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Procedimientos
/// </summary>
namespace QPDenuncia.procs
{
    public class Procedimientos
    {
        public List<Historico> ListarHistoricos(Denuncia d)
        {
            conexion.SqlConexion sql = new conexion.SqlConexion();
            sql.Conectar(estatic.LoginStatic.ReturnConnectionString());
            List<SqlParameter> _Parametros = new List<SqlParameter>();
            _Parametros.Add(new SqlParameter("@Folio", d.folio));
            _Parametros.Add(new SqlParameter("@Categoria", d.categoria));
            sql.PrepararProcedimiento("dbo.BuscarDenunciaPorFolio", _Parametros);

            DataTable dt = sql.EjecutarTable();

            List<Historico> historicos = new List<Historico>();
            Historico historico;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                historico = new Historico()
                {
                    dependiente = dt.Rows[i]["his_dependiente"].ToString(),
                    descripcion = dt.Rows[i]["his_descripcion"].ToString(),
                    fecha = dt.Rows[i]["his_fecha"].ToString()
                };
                historicos.Add(historico);
            }

            sql.Desconectar();
            sql.Dispose();
            return historicos;
        }
    }
}
