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
using Dominio;

namespace WinForm_App
{
    public partial class buscarForm : Form
    {
        private List<Articulo> articulos = new List<Articulo>();

        public buscarForm()
        {
            InitializeComponent();
        }

        private void buscarForm_Load(object sender, EventArgs e)
        {
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                Articulo articulo = articuloNegocio.Find("S99");
                if (articulo != null)
                {
                    articulos.Clear();
                    articulos.Add(articulo);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
