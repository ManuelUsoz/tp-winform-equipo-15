using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;
using DAO;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> List()
        {
            List<Articulo> artList = new List<Articulo>();
            ArticuloDAO artDAO = new ArticuloDAO();
            artList = artDAO.List();
            try
            {
                return artList;

            }
            catch (Exception ex)
            {
                throw ex;
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
