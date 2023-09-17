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

        private void OpenArticlesForm_Click(object sender, EventArgs e)
        {
            frmListaArticulos form = new frmListaArticulos();
            form.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarForm buscarForm = new BuscarForm();
            buscarForm.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo 15 / Integrantes: Bee Bianco, Ignacio Ezequiel / Bressani, Efrain Victorio / Usoz Neri, Manuel Ignacio");   
        }

        private void BtnMarcasMenu_Click(object sender, EventArgs e)
        {
            MarcasViewForm marcasViewForm = new MarcasViewForm();
            marcasViewForm.ShowDialog();
        }

        private void BtnCategoriasMenu_Click(object sender, EventArgs e)
        {
            CategoriaViewForm categoriaViewForm = new CategoriaViewForm();
            categoriaViewForm.ShowDialog();
        }
    }
}
