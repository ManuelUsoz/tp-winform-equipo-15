using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.consultar("");//hacer la consutla
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    //Llenar con los demas atributos de Articulo
                    aux.Code = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.consultar("");//hacer la consulta
                //Para Usar Luego
                //datos.setearParametro("");
                //datos.setearParametro("");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Articulo Find(string code)
        {
            Articulo articulo = new Articulo();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("server=.; database=CATALOGO_P3_DB; integrated security=true"))
                {
                    sqlConnection.Open();
                    string consulta = "SELECT Codigo, Nombre, Descripcion, Precio FROM ARTICULOS WHERE Codigo = @codigo";
                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@codigo", code);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            articulo.Code = reader["Codigo"].ToString();
                            articulo.Nombre = reader["Nombre"].ToString();
                            articulo.Descripcion = reader["Descripcion"].ToString();
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return articulo;
        }

    }
}
