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

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarArticulo form = new eliminarArticulo();
            form.ShowDialog();
        }

        private void OpenArticlesForm_Click(object sender, EventArgs e)
        {
            frmListaArticulos form = new frmListaArticulos();
            form.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarForm buscarForm = new buscarForm();
            buscarForm.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo 15 / Integrantes: Bee Bianco, Ignacio Ezequiel / Bressani, Efrain Victorio / Usoz Neri, Manuel Ignacio");   
        }
    }
}
