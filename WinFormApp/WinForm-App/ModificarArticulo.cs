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


        public ModificarArticulo()
        {
            this.marcaNegocio = new MarcaNegocio();
            this.categoriaNegocio = new CategoriaNegocio();
            InitializeComponent();
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

            }catch(Exception ex)
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
    }
}
