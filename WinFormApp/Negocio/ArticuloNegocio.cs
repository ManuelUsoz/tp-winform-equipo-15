using System;
using System.Collections.Generic;
using System.Linq;
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
                    aux.CodNumero = (int)datos.Lector["CodNumero"];
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
    }
}
