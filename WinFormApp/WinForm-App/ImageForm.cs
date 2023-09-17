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
    public partial class ImageForm : Form
    {
        public Imagen imagen { get; set; }
        public Articulo Articulo { get; set; }

        private readonly string imageUrl;
        private readonly bool isEditing;
        public ImageForm()
        {
            InitializeComponent();
            this.isEditing = false;
            Text = "Agregar Imagen";
        }

        public ImageForm(string imageUrl)
        {
            InitializeComponent();
            this.imageUrl = imageUrl;
            this.isEditing = true;
            Text = "Modificar ImagenURL";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (this.isEditing)
            {
                imagen.ImagenUrl = TxtBoxImageUrl.Text;
            }
            else
            {
                Imagen imagen = new Imagen(TxtBoxImageUrl.Text);
                Articulo.ImagenURL.Add(imagen);
            }

            this.Close();

        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            TxtBoxImageUrl.Text = this.imageUrl;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
