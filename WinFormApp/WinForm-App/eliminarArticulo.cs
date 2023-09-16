using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinForm_App
{
    public partial class eliminarArticulo : Form
    {
        private int articuloId;

        public eliminarArticulo(int articuloId)
        {
            InitializeComponent();
            this.articuloId = articuloId;
        }

        private void eliminarArticulo_Load(object sender, EventArgs e)
        {
            txtEliminar.Text = articuloId.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
