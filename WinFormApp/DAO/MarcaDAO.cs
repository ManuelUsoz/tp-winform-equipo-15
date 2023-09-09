using System;
using System.Collections.Generic;
using Dominio;
using Negocio;

namespace DAO
{
    public class MarcaDAO
    {
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
                accesoADatos?.cerrarConexion();
            };

        }
    }
    

}
