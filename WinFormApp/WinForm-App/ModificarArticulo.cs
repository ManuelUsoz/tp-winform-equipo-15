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
            BtnCancelar.Visible = false;
            BtnModificar.Visible = false;

            TxtBoxCodigo.Enabled = enableUserModification;
            TxtBoxDescripcion.Enabled = enableUserModification;
            TxtBoxNombre.Enabled = enableUserModification;
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
            articulo.Marca = (Marca)CboxMarca.SelectedItem;
            articulo.Categoria = (Categoria)CboxCategorias.SelectedItem;

            this.articuloNegocio.Update(articulo);
            
        }
    }
}
