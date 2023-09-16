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
        public Articulo articulo { get; set; }

        private string imageUrl;
        public ImageForm()
        {
            InitializeComponent();
        }

        public ImageForm(bool isEditing)
        {
            InitializeComponent();
            
        }

        public ImageForm(string imageUrl)
        {
            InitializeComponent();
            this.imageUrl = imageUrl;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Imagen imagen = new Imagen(TxtBoxImageUrl.Text);
            articulo.ImagenURL.Add(imagen);
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            TxtBoxImageUrl.Text = this.imageUrl;
        }
    }
}
