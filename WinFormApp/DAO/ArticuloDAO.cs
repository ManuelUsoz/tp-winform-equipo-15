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
        public List<Articulo> GetArticulos()
        {
            //TODO
            return null;
        }

        public List<Articulo> GetArticulos(int marcaId, int categoriaId)
        {
            try
            {
                AccesoADatos accesoADatos = new AccesoADatos();
                List<Articulo> articulos = new List<Articulo>();
                
                accesoADatos.consultar("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE M.Id = @MarcaId AND C.Id = @CategoriaId;");
                accesoADatos.setearParametro("@MarcaId", marcaId);
                accesoADatos.setearParametro("@CategoriaId", categoriaId);
                accesoADatos.AbrirConexion();
                accesoADatos.ejecutarLectura();

                while (accesoADatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Code = accesoADatos.Lector["Codigo"].ToString();
                    articulo.Nombre = accesoADatos.Lector["Nombre"].ToString();
                    articulo.Descripcion = accesoADatos.Lector["Descripcion"].ToString();
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = accesoADatos.Lector["Marca"].ToString();
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = accesoADatos.Lector["Categoria"].ToString();
                    articulo.Precio = (decimal)accesoADatos.Lector["Precio"];

                    articulos.Add(articulo);

                }
                accesoADatos.cerrarConexion();
                return articulos;
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> GetArticulos(int marcaId)
        {

            try
            {
                AccesoADatos accesoADatos = new AccesoADatos();
                List<Articulo> articulos = new List<Articulo>();

                accesoADatos.consultar("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio FROM ARTICULOS A JOIN MARCAS M ON A.IdMarca = M.Id JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE M.Id = @MarcaId;");
                accesoADatos.setearParametro("@MarcaId", marcaId);
                accesoADatos.AbrirConexion();
                accesoADatos.ejecutarLectura();

                while (accesoADatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Code = accesoADatos.Lector["Codigo"].ToString();
                    articulo.Nombre = accesoADatos.Lector["Nombre"].ToString();
                    articulo.Descripcion = accesoADatos.Lector["Descripcion"].ToString();
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = accesoADatos.Lector["Marca"].ToString();
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = accesoADatos.Lector["Categoria"].ToString();
                    articulo.Precio = (decimal)accesoADatos.Lector["Precio"];

                    articulos.Add(articulo);

                }
                accesoADatos.cerrarConexion();
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> GetArticulosByCategoria(int idCategoria)
        {
            try
            {
                AccesoADatos accesoADatos = new AccesoADatos();
                List<Articulo> articulos = new List<Articulo>();

                accesoADatos.consultar("SELECT A.Codigo, A.Nombre, A.Descripcion, C.Descripcion as Categoria, M.Descripcion as Marca, A.Precio FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id WHERE A.IdCategoria = @CategoriaId;");
                accesoADatos.setearParametro("@CategoriaId", idCategoria);
                accesoADatos.AbrirConexion();
                accesoADatos.ejecutarLectura();

                while (accesoADatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Code = accesoADatos.Lector["Codigo"].ToString();
                    articulo.Nombre = accesoADatos.Lector["Nombre"].ToString();
                    articulo.Descripcion = accesoADatos.Lector["Descripcion"].ToString();
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = accesoADatos.Lector["Marca"].ToString();
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = accesoADatos.Lector["Categoria"].ToString();
                    articulo.Precio = (decimal)accesoADatos.Lector["Precio"];

                    articulos.Add(articulo);

                }
                accesoADatos.cerrarConexion();
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
