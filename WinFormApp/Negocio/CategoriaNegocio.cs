using DAO;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    
    public class CategoriaNegocio
    {
        private CategoriaDAO categoriaDAO;
        public CategoriaNegocio()
        {
            categoriaDAO = new CategoriaDAO();
        }
        public CategoriaDAO CategoriaDAO
        {
            get
            {
                return categoriaDAO;
            }
        }

        public void Create(Categoria categoria)
        {
            try
            {
                CategoriaDAO catDAO= new CategoriaDAO();
                catDAO.Create(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categoria> List()
        {
            try
            {
                CategoriaDAO catDAO = new CategoriaDAO();
                List<Categoria> catList = catDAO.list();
                return catList;

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Categoria categoria)
        {
            try
            {
                CategoriaDAO catDAO= new CategoriaDAO();
                catDAO.Update(categoria);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                CategoriaDAO catDAO = new CategoriaDAO();
                catDAO.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
