using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriaDAO
    {
        public List<Categoria> list()
        {
            try
            {
                AccesoADatos accesoADatos = new AccesoADatos("server=.; database=CATALOGO_P3_DB; integrated security=true");
                List<Categoria> categorias = new List<Categoria>();
                accesoADatos.AbrirConexion();
                accesoADatos.consultar("SELECT Id, Descripcion FROM CATEGORIAS");
                accesoADatos.ejecutarLectura();
                while (accesoADatos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)accesoADatos.Lector["Id"];
                    categoria.Descripcion = accesoADatos.Lector["Descripcion"].ToString();
                    categorias.Add(categoria);
                }
                accesoADatos.cerrarConexion();
                return categorias;

            }
            catch(Exception) {
                throw new Exception("Error al listar las categorias");
            }
            
        }
    }
}
