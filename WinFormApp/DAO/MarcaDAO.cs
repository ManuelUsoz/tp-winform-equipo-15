using System;
using System.CodeDom;
using System.Collections.Generic;
using Dominio;
using Negocio;

namespace DAO
{
    public class MarcaDAO
    {
        private string connection = "server=.; database=CATALOGO_P3_DB; integrated security=true";
        public void Create(Marca marca)
        {
            AccesoADatos accesoADatos = new AccesoADatos(connection);
            try
            {
                string query = "INSERT INTO MARCAS (Descripcion) VALUES (@MarcaDescripcion)";
                accesoADatos.consultar(query);
                accesoADatos.setearParametro("@MarcaDescripcion", marca.Descripcion);
                accesoADatos.ejecutarAccion();
            }catch (Exception ex)
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
                string query = "DELETE FROM MARCAS WHERE Id = @Id";
                accesoADatos.consultar(query);
                accesoADatos.setearParametro("@Id", id);
                accesoADatos.ejecutarAccion();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoADatos.cerrarConexion();
            }
        }

        public List<Marca> List()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoADatos accesoADatos = new AccesoADatos("server=.; database=CATALOGO_P3_DB; integrated security=true");

            try
            {
                accesoADatos.AbrirConexion();

                string consulta = "SELECT Id, Descripcion FROM Marcas";

                accesoADatos.consultar(consulta);

                accesoADatos.ejecutarLectura();

                while (accesoADatos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)accesoADatos.Lector["Id"];
                    marca.Descripcion = accesoADatos.Lector["Descripcion"].ToString();

                    listaMarcas.Add(marca);
                }
                return listaMarcas;

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

        public void Update(Marca marca)
        {
            AccesoADatos accesoADatos = new AccesoADatos(connection);
            try
            {
                string query = "UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id";
                accesoADatos.consultar(query);
                accesoADatos.setearParametro("@Descripcion", marca.Descripcion);
                accesoADatos.setearParametro("@Id", marca.Id);
                accesoADatos.ejecutarAccion();

            }catch(Exception ex)
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
