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
    public partial class frmListaArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmListaArticulos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void frmListaArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            listaArticulos = artNegocio.listar();

            dgvArticulos.DataSource = listaArticulos;

            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }
    }
}
