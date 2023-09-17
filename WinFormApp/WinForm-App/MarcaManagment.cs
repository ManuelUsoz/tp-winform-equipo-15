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
                BtnAgregar.Enabled = false;
            }

            if (readOrUpdate)
            {
                TxtBoxDescripcion.Text = Marca.Descripcion;
                BtnAgregar.Text = "Modificar";
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Marca.Descripcion = TxtBoxDescripcion.Text;
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                if (!onlyRead && !readOrUpdate)
                {
                    marcaNegocio.Create(Marca);
                    MessageBox.Show("Entidad creada correctamente");

                }
                if (readOrUpdate)
                {
                    marcaNegocio.Update(Marca);
                    MessageBox.Show("Entidad modificada correctamente");
                }

            }catch (Exception)
            {
                MessageBox.Show("Error al eliminar la entidad");
            }
            finally
            {
                this.Close();
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
