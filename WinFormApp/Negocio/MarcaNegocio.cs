using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAO;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> list()
        {
            MarcaDAO marcaDAO = new MarcaDAO();
            List<Marca> marcaList = marcaDAO.List();

            return marcaList; 
        }
    }
}
