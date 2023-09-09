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
        public List<Categoria> List()
        {
            try
            {
                return CategoriaDAO.list();

            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
