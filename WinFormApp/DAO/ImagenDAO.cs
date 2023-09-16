using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImagenDAO
    {
        private AccesoADatos datos;
        private List<Imagen> imagenes;
        public List<Imagen> GetImagenes (int articuloId)
        {
            imagenes = new List<Imagen>();
            datos = new AccesoADatos();
            try
            {
                string consulta = "SELECT I.Id, I.IdArticulo, I.ImagenUrl FROM IMAGENES I WHERE I.IdArticulo = @ArticuloId";
                datos = new AccesoADatos("server=.; database=CATALOGO_P3_DB; integrated security=true");
                datos.AbrirConexion();
                datos.setearParametro("@ArticuloId", articuloId);
                datos.consultar(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen imagen = new Imagen();

                    imagen.Id = (int)datos.Lector["Id"];
                    imagen.IdArticulo = (int)datos.Lector["IdArticulo"];
                    imagen.ImagenUrl = datos.Lector["ImagenUrl"].ToString();
                    imagenes.Add(imagen); 
                }
                return imagenes;
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
    }
}
