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
        public ArticuloDAO articuloDAO;

        public ArticuloNegocio()
        {
            articuloDAO = new ArticuloDAO();
        }

        public ArticuloDAO ArticuloDAO
        {
            get
            {
                return articuloDAO;
            }
        }
        public List<Articulo> listar()
        {
            List<Articulo> artList = new List<Articulo>();
            ArticuloDAO artDAO = new ArticuloDAO();
            artList = artDAO.GetArticulos();
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

        public List<Articulo> GetArticulos(int idMarca, int idCategoria)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulos(idMarca, idCategoria);
                return articulos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> GetArticulos(int idMarca)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulos(idMarca);
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public List<Articulo> GetArticulosByCategory(int idCategoria)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulosByCategoria(idCategoria);
                return articulos;

            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
