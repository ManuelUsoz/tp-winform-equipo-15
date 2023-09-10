using System;
using System.Collections.Generic;
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

        public List<Articulo> GetArticulosByHint(string hint)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulosByHint(hint);
                return articulos;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> GetArticulos(string field, string criteria, string value)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulos(field, criteria, value);
                return articulos;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public List<Articulo> GetArticulos(int idMarca, string field, string criteria, string value)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulos(idMarca, field, criteria, value);
                return articulos;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> GetArticulosByCategory(int idCategoria, string field, string criteria, string value)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulosByCategory(idCategoria, field, criteria, value);
                return articulos;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> GetArticulos(int idMarca, int idCategoria, string field, string criteria, string value)
        {
            try
            {
                List<Articulo> articulos = ArticuloDAO.GetArticulos(idMarca, idCategoria, field, criteria, value);
                return articulos;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
