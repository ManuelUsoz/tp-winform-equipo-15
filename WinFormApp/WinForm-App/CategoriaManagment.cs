using Dominio;
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
    }
}
