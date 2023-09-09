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
