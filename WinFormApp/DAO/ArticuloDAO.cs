using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ArticuloDAO
    {
        public List<Articulo> List()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoADatos accesoADatos = new AccesoADatos("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");

            try
            {
                accesoADatos.AbrirConexion();

                string consulta = "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS";

                accesoADatos.consultar(consulta);

                accesoADatos.ejecutarLectura();

                while (accesoADatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = accesoADatos.Lector.GetInt32(0);
                    articulo.Code = (string)accesoADatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoADatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoADatos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)accesoADatos.Lector["IdMarca"].ToString();//Revisar
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)accesoADatos.Lector["IdCategoria"].ToString();//Revisar
                    articulo.Precio = (decimal)accesoADatos.Lector["Precio"];
                    articulo.Descripcion = accesoADatos.Lector["Descripcion"].ToString();

                    listaArticulos.Add(articulo);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoADatos.cerrarConexion();
            }
        }
    }
    
}
