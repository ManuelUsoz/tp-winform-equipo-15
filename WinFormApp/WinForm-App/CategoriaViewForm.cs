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
    public partial class CategoriaViewForm : Form
    {
        public CategoriaViewForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            DgvCategories.DataSource = categoriaNegocio.List();
        }

        private void CategoriaViewForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CategoriaManagment categoriaManagment = new CategoriaManagment(false, false);
            categoriaManagment.ShowDialog();
            LoadData();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Categoria categoria = DgvCategories.CurrentRow.DataBoundItem as Categoria;
            CategoriaManagment categoriaManagment = new CategoriaManagment(false, true);
            categoriaManagment.Categoria = categoria;
            categoriaManagment.ShowDialog();
            LoadData();
        }

        private void BtnSeeDetail_Click(object sender, EventArgs e)
        {
            Categoria categoria = DgvCategories.CurrentRow.DataBoundItem as Categoria;
            CategoriaManagment categoriaManagment = new CategoriaManagment(true, true);
            categoriaManagment.Categoria = categoria;
            categoriaManagment.ShowDialog(this);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Esto es irreversible", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    CategoriaNegocio catNeg = new CategoriaNegocio();
                    Categoria categoria = DgvCategories.CurrentRow.DataBoundItem as Categoria;
                    catNeg.Eliminar(categoria.Id);
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
