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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buscarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarForm form = new buscarForm();
            form.ShowDialog();
        }

        private void detalleDeUnArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detalleArticulo form = new detalleArticulo();
            form.ShowDialog();
        }

        private void listaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaArticulos frmlistArt= new frmListaArticulos();
            frmlistArt.ShowDialog();
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo frmAgregarArticulo = new frmAgregarArticulo();
            frmAgregarArticulo.ShowDialog();
        }
    }
}
