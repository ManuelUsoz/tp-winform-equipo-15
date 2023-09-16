using DAO;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        private ImagenDAO imagenDAO = new ImagenDAO();
        public List<Imagen> GetImagens(int idArticulo) {
            try
            {
                List<Imagen> images = this.imagenDAO.GetImagenes(idArticulo);
                return images;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
