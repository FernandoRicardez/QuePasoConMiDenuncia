using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

/// <summary>
/// Summary description for SQLconexion
/// </summary>
namespace QPDenuncia.conexion
{
    public class SqlConexion : IDisposable
    {
        private SqlConnection _conn = null;
        string _ConnectionString = "";
        bool _Conectado = false;

        string _NombreProcedimiento = "";
        List<SqlParameter> _Parametros = new List<SqlParameter>();
        bool _Preparado = false;

        public bool AutoDesconexion { get; set; }

        public bool Conectar(string ConnectionString)
        {
            bool _Rsp = false;
            _conn = new SqlConnection(ConnectionString);
            try
            {
                _conn.Open();
                _Conectado = true;
                _Rsp = true;
            }
            catch
            {
                _Rsp = false;
            }
            return _Rsp;
        }

        public void Desconectar()
        {
            _conn.Close();
        }

        public void PrepararProcedimiento(string NombreProcedimiento, List<SqlParameter> Parametros)
        {
            if (_Conectado)
            {
                _NombreProcedimiento = "";
                _Parametros.Clear();

                _NombreProcedimiento = NombreProcedimiento;
                _Parametros = Parametros;
                _Preparado = true;
            }
            else
            {
                throw new Exception("No hay conexion con la bd");
            }
        }

        public int EjecutarProcedimiento()
        {
            if (_Preparado)
            {
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                _Preparado = false;
                return cmm.ExecuteNonQuery();

            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }
        public DataTableReader EjecutarTableReader(System.Data.CommandType TipoComando)
        {
            if (_Preparado)
            {
                DataTable dt = new DataTable();
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = TipoComando;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                SqlDataAdapter adt = new SqlDataAdapter(cmm);
                adt.Fill(dt);
                _Preparado = false;
                return dt.CreateDataReader();
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }
        public XmlTextReader EjecutarXmlReader()
        {
            object valor = null;
            if (_Preparado)
            {
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                _Preparado = false;
                cmm.ExecuteScalar();

                foreach (SqlParameter sp in cmm.Parameters)
                {
                    if (sp.Direction == ParameterDirection.ReturnValue || sp.Direction == ParameterDirection.Output)
                    {
                        valor = sp.Value;
                        break;
                    }
                }

                if (valor != null)
                {

                    XmlParserContext context =
    new XmlParserContext(null, null, string.Empty, XmlSpace.None, Encoding.UTF8);
                    XmlTextReader xmr = new XmlTextReader(new MemoryStream(UTF8Encoding.UTF8.GetBytes(valor.ToString())), XmlNodeType.Document, context);
                    return xmr;
                }
                else
                {
                    _Preparado = false;
                    throw new Exception("No es un xml valido");
                }
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }
        public XmlTextReader EjecutarXmlReader(System.Data.CommandType tipo)
        {
            object valor = null;
            if (_Preparado)
            {
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = tipo;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                _Preparado = false;
                cmm.ExecuteScalar();

                foreach (SqlParameter sp in cmm.Parameters)
                {
                    if (sp.Direction == ParameterDirection.ReturnValue || sp.Direction == ParameterDirection.Output)
                    {
                        valor = sp.Value;
                        break;
                    }
                }

                if (valor != null)
                {

                    XmlParserContext context =
    new XmlParserContext(null, null, string.Empty, XmlSpace.None, Encoding.UTF8);
                    XmlTextReader xmr = new XmlTextReader(new MemoryStream(UTF8Encoding.UTF8.GetBytes(valor.ToString())), XmlNodeType.Document, context);
                    return xmr;
                }
                else
                {
                    _Preparado = false;
                    throw new Exception("No es un xml valido");
                }
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }

        public object EjecutarProcedimientoOutput()
        {
            object valor = null;
            if (_Preparado)
            {
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                _Preparado = false;
                cmm.ExecuteScalar();

                foreach (SqlParameter sp in cmm.Parameters)
                {
                    if (sp.Direction == ParameterDirection.ReturnValue || sp.Direction == ParameterDirection.Output)
                    {
                        valor = sp.Value;
                        break;
                    }
                }
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
            return valor;
        }

        public object EjecutarScalar()
        {
            if (_Preparado)
            {
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                _Preparado = false;
                return cmm.ExecuteScalar();
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }

        public DataTable EjecutarTable()
        {
            if (_Preparado)
            {
                DataTable dt = new DataTable();
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                SqlDataAdapter adt = new SqlDataAdapter(cmm);
                adt.Fill(dt);
                _Preparado = false;
                return dt.Copy();
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }

        //************************Sobrecargué este método para que reciba el tipo de comando********************
        public DataTable EjecutarTable(System.Data.CommandType tipoComando)
        {
            if (_Preparado)
            {
                DataTable dt = new DataTable();
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = tipoComando;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                SqlDataAdapter adt = new SqlDataAdapter(cmm);
                adt.Fill(dt);
                _Preparado = false;
                return dt.Copy();
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }

        public object[] EjecutarObject()
        {
            if (_Preparado)
            {
                object[] Resp = new object[0];
                SqlCommand cmm = new SqlCommand(_NombreProcedimiento, _conn);
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.Parameters.AddRange(_Parametros.ToArray());
                _Preparado = false;
                SqlDataReader dtr = cmm.ExecuteReader();
                dtr.Read(); // Solo vamos a regresar la primera
                dtr.GetValues(Resp);
                return Resp;
            }
            else
            {
                _Preparado = false;
                throw new Exception("Procedimiento no preparado");
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            try
            {
                _conn.Dispose();
                _Parametros.Clear();
                _Preparado = false;
                GC.Collect();
            }
            catch { }
        }

        #endregion
    }
}
