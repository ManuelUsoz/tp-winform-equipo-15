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

        public void Create(int idArticulo, List<Imagen> images)
        {
            try
            {
                this.imagenDAO.Create(idArticulo, images);
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int idArticulo)
        {
            try
            {
                this.imagenDAO.Delete(idArticulo);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Articulo articulo)
        {
            try
            {
                this.imagenDAO.Update(articulo);
            }catch(Exception e)
            {
                throw e;
            }
        }

        public void DeleteByImageId(int idImagen)
        {
            try
            {
                this.imagenDAO.DeleteByIdImage(idImagen);
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
