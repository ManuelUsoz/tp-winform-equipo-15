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
    public partial class CategoriaManagment : Form
    {
        private bool onlyRead;
        private bool readOrUpdate;
        public Categoria Categoria { get; set; }
        public CategoriaManagment(bool onlyRead, bool readOrUpdate)
        {
            InitializeComponent();
            this.onlyRead = onlyRead;
            this.readOrUpdate = readOrUpdate;
        }

        private void CategoriaManagment_Load(object sender, EventArgs e)
        {
            if(onlyRead)
            {
                TxtBoxDescription.Text = Categoria.Descripcion;
                TxtBoxDescription.Enabled = false;
            }

            if(readOrUpdate)
            {
                TxtBoxDescription.Text = Categoria.Descripcion;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Categoria.Descripcion = TxtBoxDescription.Text;
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                if (!onlyRead && !readOrUpdate)
                {
                    categoriaNegocio.Create(Categoria);
                    MessageBox.Show("Entidad creada correctamente");

                }
                if (readOrUpdate)
                {
                    categoriaNegocio.Update(Categoria);
                    MessageBox.Show("Entidad modificada correctamente");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la entidad");
            }
            finally
            {
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
