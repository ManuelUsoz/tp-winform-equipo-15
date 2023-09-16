﻿using System;
using System.Collections.Generic;
using Dominio;
using DAO;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private ArticuloDAO articuloDAO;
        private ImagenNegocio ImagenNegocio = new ImagenNegocio();

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
            try
            {
                List<Articulo> artList = this.ArticuloDAO.GetArticulos();
                artList.ForEach(articulo => articulo.ImagenURL = this.ImagenNegocio.GetImagens(articulo.Id));
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

        public void eliminar(int id)
        {
            try
            {
                this.articuloDAO.Delete(id);
                this.ImagenNegocio.Delete(id);
            }catch(Exception e)
            {
                throw e;
            }     
            
        }

        public void Update(Articulo articulo)
        {
            try
            {
                ArticuloDAO.Update(articulo);
                ImagenNegocio.Update(articulo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Create(Articulo articulo)
        {
            try
            {
                ArticuloDAO.agregar(articulo);
                int id = this.ArticuloDAO.GetLastId();
                this.ImagenNegocio.Create(id, articulo.ImagenURL);
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
