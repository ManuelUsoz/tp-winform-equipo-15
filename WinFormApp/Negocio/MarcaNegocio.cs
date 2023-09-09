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
            List<Marca> marcaList = new List<Marca>();
            MarcaDAO marcaDAO = new MarcaDAO();
            marcaList = marcaDAO.List();

            return marcaList; 
        }
    }
}
