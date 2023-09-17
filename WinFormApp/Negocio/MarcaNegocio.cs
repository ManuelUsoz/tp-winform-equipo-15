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
        public void Create(Marca marca)
        {
            MarcaDAO marcaDAO = new MarcaDAO();
            marcaDAO.Create(marca);
        }

        public void Eliminar(int id)
        {
            MarcaDAO marcaDAO=new MarcaDAO();
            marcaDAO.Delete(id);
        }

        public List<Marca> list()
        {
            try
            {
                MarcaDAO marcaDAO = new MarcaDAO();
                List<Marca> marcaList = marcaDAO.List();
                return marcaList;

            }catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Update(Marca marca)
        {
            try
            {
                MarcaDAO marcaDAO = new MarcaDAO();
                marcaDAO.Update(marca);
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
