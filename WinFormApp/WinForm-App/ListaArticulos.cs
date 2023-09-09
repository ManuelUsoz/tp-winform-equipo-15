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
        /*
         * FALTA TERMINAR
         * 
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo selecArt = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(selecArt.ImagenURL);
        }

        

        private void cargarImagen(Imagen imagenURL)
        {
            try
            {
                pbListaArticulos.Load();
            }
            catch (Exception ex)
            {
                pbListaArticulos.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
            }
        }
        */
    }
}
