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
    public partial class MarcaManagment : Form
    {
        private bool onlyRead;
        private bool readOrUpdate;
        public Marca Marca { get; set; }
        public MarcaManagment(bool onlyRead, bool readOrUpdate)
        {
            InitializeComponent();
            this.onlyRead = onlyRead;
            this.readOrUpdate = readOrUpdate;
        }

        private void MarcaManagment_Load(object sender, EventArgs e)
        {
            if(onlyRead && readOrUpdate)
            {
                TxtBoxDescripcion.Enabled = false;
                TxtBoxDescripcion.Text = Marca.Descripcion;
            }

            if (readOrUpdate)
            {
                TxtBoxDescripcion.Text = Marca.Descripcion;
            }
        }
    }
}
