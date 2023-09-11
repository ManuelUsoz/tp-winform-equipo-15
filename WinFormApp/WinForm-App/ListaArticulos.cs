using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
        
        private void frmListaArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = artNegocio.listar();

                dgvArticulos.DataSource = listaArticulos;

                dgvArticulos.Columns["ImagenUrl"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //llenar cuando se cree
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminarArticulo eliminar = new eliminarArticulo();
            eliminar.ShowDialog();
            cargar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscarForm buscar = new buscarForm();
            buscar.ShowDialog();
        }

        private void buttonDetalle_Click(object sender, EventArgs e)
        {
            detalleArticulo detalle= new detalleArticulo();
            detalle.ShowDialog();
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarArticulo modificarArticulo = new ModificarArticulo();
            modificarArticulo.ShowDialog();
        }
        /*
* FALTA REVISAR
* 
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
