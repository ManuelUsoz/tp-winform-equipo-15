using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_App
{
    public partial class ModificarArticulo : Form
    {
        private MarcaNegocio marcaNegocio;
        private CategoriaNegocio categoriaNegocio;
        private ArticuloNegocio articuloNegocio;

        public ModificarArticulo()
        {
            InitializeComponent();
            this.marcaNegocio = new MarcaNegocio();
            this.categoriaNegocio = new CategoriaNegocio();
            this.articuloNegocio = new ArticuloNegocio();
        }

        public ModificarArticulo(bool enableUserModification)
        {
            InitializeComponent();

            this.marcaNegocio = new MarcaNegocio();
            this.categoriaNegocio = new CategoriaNegocio();
            BtnModificar.Enabled = false;

            TxtBoxCodigo.Enabled = enableUserModification;
            TxtBoxDescripcion.Enabled = enableUserModification;
            TxtBoxNombre.Enabled = enableUserModification;
            TxtBoxPrecio.Enabled = enableUserModification;
            TxtBoxImagenUrl.Enabled = enableUserModification;

            CboxCategorias.Enabled = enableUserModification;
            CboxMarca.Enabled = enableUserModification;
        }

        public Articulo Articulo { get; set; }

        public MarcaNegocio MarcaNegocio
        {
            get
            {
                return this.marcaNegocio;
            }
        }

        public CategoriaNegocio CategoriaNegocio
        {
            get
            {
                return this.categoriaNegocio;
            }
        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {
            CboxMarca.DataSource = MarcaNegocio.list();
            CboxCategorias.DataSource = CategoriaNegocio.List();
            try
            {
                PicBoxArticulo.Load(Articulo.ImagenURL.ImagenUrl);

            }catch(Exception)
            {
                PicBoxArticulo.Image = Properties.Resources.OIP;
            }

            CboxCategorias.ValueMember = "Id";
            CboxCategorias.DisplayMember = "Descripcion";
            CboxMarca.ValueMember = "Id";
            CboxMarca.DisplayMember = "Descripcion";

            TxtBoxCodigo.Text = Articulo.Code;
            TxtBoxDescripcion.Text = Articulo.Descripcion;
            TxtBoxNombre.Text = Articulo.Nombre;
            TxtBoxPrecio.Text = Articulo.Precio.ToString();
            TxtBoxImagenUrl.Text = Articulo.ImagenURL.ImagenUrl;
            CboxCategorias.SelectedValue = Articulo.Categoria.Id;
            CboxMarca.SelectedValue = Articulo.Marca.Id;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(TxtBoxPrecio.Text, out decimal txt))
            {
                MessageBox.Show("Ingrese numeros en el campo precio");
                return;
            }

            Articulo articulo = new Articulo();
            articulo.Marca = new Marca();
            articulo.Categoria  = new Categoria();
            articulo.ImagenURL = new Imagen();
            articulo.Id = Articulo.Id;
            articulo.Code = TxtBoxCodigo.Text;
            articulo.Nombre = TxtBoxNombre.Text;
            articulo.Descripcion = TxtBoxDescripcion.Text;
            articulo.ImagenURL.Id = Articulo.ImagenURL.Id;
            articulo.ImagenURL.ImagenUrl = TxtBoxImagenUrl.Text;
            articulo.Marca = (Marca)CboxMarca.SelectedItem;
            articulo.Categoria = (Categoria)CboxCategorias.SelectedItem;
            articulo.Precio = decimal.Parse(TxtBoxPrecio.Text);

            try
            {
                this.articuloNegocio.Update(articulo);
                MessageBox.Show("Entidad modificada correctamente!");
                this.Close();
            }catch(Exception)
            {
                MessageBox.Show("Error al modificar la entidad");
            }

            
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBoxImagenUrl_Leave(object sender, EventArgs e)
        {
            try
            {
                PicBoxArticulo.Load(TxtBoxImagenUrl.Text);
            }
            catch (Exception)
            {
                PicBoxArticulo.Image = Properties.Resources.OIP;
                MessageBox.Show("Error al cargar la imagen ingresada");
            }
        }
    }
}
