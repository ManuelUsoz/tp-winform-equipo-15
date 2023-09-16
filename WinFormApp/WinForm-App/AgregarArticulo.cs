using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Dominio;
using Negocio;
using DAO;

namespace WinForm_App
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo;

        public frmAgregarArticulo()
        {
            InitializeComponent();
            this.articulo = new Articulo();
            this.articulo.ImagenURL = new List<Imagen>();
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCodigo.Text) || string.IsNullOrWhiteSpace(txtbNombre.Text) || string.IsNullOrWhiteSpace(txtbDescripcion.Text) || cbMarca.SelectedItem == null || cbCategoria.SelectedItem == null || string.IsNullOrWhiteSpace(txtbImagenUrl.Text) || !decimal.TryParse(nudPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }
            
            ArticuloDAO artDAO = new ArticuloDAO();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                articulo.Code = txtbCodigo.Text;
                articulo.Nombre = txtbNombre.Text;
                articulo.Descripcion = txtbDescripcion.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio= decimal.Parse(nudPrecio.Text);
                articuloNegocio.Create(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta la entidad", ex.Message);
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaDAO marcaDAO = new MarcaDAO();
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            try
            {
                cbMarca.DataSource = marcaDAO.List();
                cbCategoria.DataSource = categoriaDAO.list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenUrl.Load(imagen);
            }
            catch (Exception ex)
            {
                pbImagenUrl.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
            }
        }
        
        private void txtbImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbImagenUrl.Text);
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            if(txtbImagenUrl != null)
            {
                Imagen imagen = new Imagen(txtbImagenUrl.Text);
                this.articulo.ImagenURL.Add(imagen);
            }
            else
            {
                MessageBox.Show("Por favor ingrese una url de imagen");
            }
        }
    }
}
