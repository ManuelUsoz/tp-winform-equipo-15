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
        private int imageCounter = 0;
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
            Articulo articulo = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            ModificarArticulo modificarArticulo = new ModificarArticulo();
            modificarArticulo.Articulo = articulo;
            modificarArticulo.ShowDialog();
            cargar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Articulo articulo = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    int id = articulo.Id;
                    negocio.eliminar(id);
                    MessageBox.Show("Entidad eliminada correctamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la entidad");
            }
            cargar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarForm buscar = new BuscarForm();
            buscar.ShowDialog();
        }

        private void buttonDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                Articulo articulo = dgvArticulos.SelectedRows[0].DataBoundItem as Articulo;
                ModificarArticulo modificarArticulo = new ModificarArticulo(false);
                modificarArticulo.Articulo = articulo;
                modificarArticulo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de hacer clic en Detalle.");
            }
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo articulo = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            ModificarArticulo modificarArticulo = new ModificarArticulo();
            modificarArticulo.Articulo = articulo;
            modificarArticulo.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged_1(object sender, EventArgs e)
        {
            Articulo articulo = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            this.imageCounter = 0;
            try
            {
                pbListaArticulos.Load(articulo.ImagenURL[this.imageCounter].ImagenUrl);
            }
            catch (Exception)
            {
                pbListaArticulos.Image = Properties.Resources.OIP;
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDetalle.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private void BtnNextImage_Click(object sender, EventArgs e)
        {
            this.imageCounter++;
            Articulo articulo = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            try
            {
                pbListaArticulos.Load(articulo.ImagenURL[this.imageCounter].ImagenUrl);

            }catch (Exception)
            {
                this.imageCounter--;
                return;
            }
        }

        private void BtnPrevImage_Click(object sender, EventArgs e)
        {
            this.imageCounter--;
            Articulo articulo = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            try
            {
                pbListaArticulos.Load(articulo.ImagenURL[this.imageCounter].ImagenUrl);
            }catch(Exception) 
            {
                this.imageCounter++;
                return; 
            }
        }
    }
}
