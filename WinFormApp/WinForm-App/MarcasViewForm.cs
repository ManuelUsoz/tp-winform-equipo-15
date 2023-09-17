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
    public partial class MarcasViewForm : Form
    {
        public MarcasViewForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            DgvMarcas.DataSource = marcaNegocio.list();
        }

        private void MarcasViewForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaManagment marcaManagment = new MarcaManagment(false, false);
            marcaManagment.ShowDialog();
            LoadData();
        }

        private void BtnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = DgvMarcas.CurrentRow.DataBoundItem as Marca;
            MarcaManagment marcaManagment = new MarcaManagment(false, true);
            marcaManagment.Marca = marca;
            marcaManagment.ShowDialog();
            LoadData();
        }

        private void BtnVerDetalleMarca_Click(object sender, EventArgs e)
        {
            Marca marca = DgvMarcas.CurrentRow.DataBoundItem as Marca;
            MarcaManagment marcaManagment = new MarcaManagment(true, true);
            marcaManagment.Marca = marca;
            marcaManagment.ShowDialog(this);
        }

        private void BtnEliminarMarca_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Esto es irreversible", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    MarcaNegocio marcaNeg = new MarcaNegocio();
                    Marca marca = DgvMarcas.CurrentRow.DataBoundItem as Marca;
                    marcaNeg.Eliminar(marca.Id);
                    MessageBox.Show("Entidad eliminada correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar la entidad");
                }
            }
            LoadData();

        }
    }
}
