using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriaDAO
    {
        private string connection = "server=.; database=CATALOGO_P3_DB; integrated security=true";
        public void Create(Categoria categoria)
        {
            AccesoADatos accesoADatos = new AccesoADatos(connection);
            try
            {
                string query = "INSERT INTO CATEGORIAS (Descripcion) VALUES (@Descripcion)";
                accesoADatos.consultar(query);
                accesoADatos.setearParametro("@Descripcion", categoria.Descripcion);
                accesoADatos.ejecutarAccion();
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

        public void Update(Categoria categoria)
        {
            AccesoADatos accesoADatos = new AccesoADatos(connection);
            try
            {
                string query = "UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @Id";
                accesoADatos.consultar(query);
                accesoADatos.setearParametro("@Descripcion", categoria.Descripcion);
                accesoADatos.setearParametro("@Id", categoria.Id);
                accesoADatos.ejecutarAccion();

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

        

        public void Delete(int id)
        {
            AccesoADatos accesoADatos = new AccesoADatos(connection);
            try
            {
                string query = "DELETE FROM CATEGORIAS WHERE Id = @Id";
                accesoADatos.consultar(query);
                accesoADatos.setearParametro("@Id", id);
                accesoADatos.ejecutarAccion();
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
