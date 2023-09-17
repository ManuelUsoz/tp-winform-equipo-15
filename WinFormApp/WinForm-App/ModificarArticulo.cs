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
    public partial class ModificarArticulo : Form
    {
        private MarcaNegocio marcaNegocio;
        private CategoriaNegocio categoriaNegocio;
        private ArticuloNegocio articuloNegocio;
        private ImagenNegocio imagenNegocio;
        private int imageCounter = 0;

        public Articulo Articulo { get; set; }

        public MarcaNegocio MarcaNegocio
        {
            get
            {
                return this.marcaNegocio;
            }
        }

        public ImagenNegocio ImagenNegocio
        {
            get
            {
                return this.imagenNegocio;
            }
        }

        public CategoriaNegocio CategoriaNegocio
        {
            get
            {
                return this.categoriaNegocio;
            }
        }

        public ModificarArticulo()
        {
            InitializeComponent();
            this.marcaNegocio = new MarcaNegocio();
            this.categoriaNegocio = new CategoriaNegocio();
            this.articuloNegocio = new ArticuloNegocio();
            this.imagenNegocio = new ImagenNegocio();
        }
        

        public ModificarArticulo(bool enableUserModification)
        {
            InitializeComponent();

            this.marcaNegocio = new MarcaNegocio();
            this.categoriaNegocio = new CategoriaNegocio();
            this.imagenNegocio = new ImagenNegocio();
            BtnModificar.Enabled = false;
            BtnAddImage.Enabled = false;
            BtnDeleteImage.Enabled = false;
            BtnModifyImage.Enabled = false;

            TxtBoxCodigo.Enabled = enableUserModification;
            TxtBoxDescripcion.Enabled = enableUserModification;
            TxtBoxNombre.Enabled = enableUserModification;
            TxtBoxPrecio.Enabled = enableUserModification;

            CboxCategorias.Enabled = enableUserModification;
            CboxMarca.Enabled = enableUserModification;

            Text = "Detalle Articulo";
        }

        private void LoadImage(string imageUrl)
        {
            try
            {
                PicBoxArticulo.Load(imageUrl);

            }
            catch (Exception)
            {
                PicBoxArticulo.Image = Properties.Resources.OIP;
            }
        }

        

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {
            CboxMarca.DataSource = MarcaNegocio.list();
            CboxCategorias.DataSource = CategoriaNegocio.List();
            CboxImages.DataSource = ImagenNegocio.GetImagens(Articulo.Id);

            if (Articulo.ImagenURL == null || Articulo.ImagenURL.Count == 0)
            {
                PicBoxArticulo.Image = Properties.Resources.OIP;
            }
            else
            {
                LoadImage(Articulo.ImagenURL[0].ImagenUrl);
            }

            CboxCategorias.ValueMember = "Id";
            CboxCategorias.DisplayMember = "Descripcion";
            CboxMarca.ValueMember = "Id";
            CboxMarca.DisplayMember = "Descripcion";
            CboxImages.ValueMember = "Id";
            CboxImages.DisplayMember = "ImagenUrl";

            TxtBoxCodigo.Text = Articulo.Code;
            TxtBoxDescripcion.Text = Articulo.Descripcion;
            TxtBoxNombre.Text = Articulo.Nombre;
            TxtBoxPrecio.Text = Articulo.Precio.ToString();
            CboxCategorias.SelectedValue = Articulo.Categoria.Id;
            CboxMarca.SelectedValue = Articulo.Marca.Id;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(TxtBoxPrecio.Text, out decimal txt))
            {
                MessageBox.Show("Ingrese numeros en el campo precio");
                return;
            }

            //Articulo articulo = new Articulo();
            Articulo.Marca = new Marca();
            Articulo.Categoria  = new Categoria();
            Articulo.Id = Articulo.Id;
            Articulo.Code = TxtBoxCodigo.Text;
            Articulo.Nombre = TxtBoxNombre.Text;
            Articulo.Descripcion = TxtBoxDescripcion.Text;
            Articulo.Marca = (Marca)CboxMarca.SelectedItem;
            Articulo.Categoria = (Categoria)CboxCategorias.SelectedItem;
            Articulo.Precio = decimal.Parse(TxtBoxPrecio.Text);

            try
            {
                this.articuloNegocio.Update(Articulo);
                MessageBox.Show("Entidad modificada correctamente!");
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al modificar la entidad(Puede que sea por el .0000 de precios)");
            }

            
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImage(CboxImages.SelectedItem.ToString()); 
        }

        private void BtnChangeNextImage_Click(object sender, EventArgs e)
        {
            this.imageCounter++;
            try
            {
                PicBoxArticulo.Load(Articulo.ImagenURL[this.imageCounter].ImagenUrl);
                CboxImages.SelectedIndex = this.imageCounter;
            }
            catch (Exception)
            {
                this.imageCounter--;
                return;
            }
        }

        private void BtnChangePreviousImage_Click(object sender, EventArgs e)
        {
            this.imageCounter--;
            try
            {
                PicBoxArticulo.Load(Articulo.ImagenURL[this.imageCounter].ImagenUrl);
                CboxImages.SelectedIndex = this.imageCounter;
            }
            catch (Exception)
            {
                this.imageCounter++;
                return;
            }
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm();
            imageForm.Articulo = Articulo;
            imageForm.ShowDialog();
            CboxImages.DataSource = Articulo.ImagenURL;

        }

        private void BtnModifyImage_Click(object sender, EventArgs e)
        {
            Imagen imagen = Articulo.ImagenURL.FirstOrDefault(img => img.ImagenUrl == CboxImages.SelectedItem.ToString());
            if(imagen != null)
            {
                ImageForm imageForm = new ImageForm(CboxImages.SelectedItem.ToString());
                imageForm.imagen = imagen;
                imageForm.ShowDialog(this);
                //Se resetea el DataSource para que sea aquellos que se hayan manipulado en ImagenURL
                CboxImages.DataSource = Articulo.ImagenURL;

            }
            
        }

        private void BtnDeleteImage_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo? Esta acción es irreversible", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    Imagen selectedImage = (Imagen) CboxImages.SelectedItem;
                    this.ImagenNegocio.DeleteByImageId(selectedImage.Id);
                    MessageBox.Show("Imagen eliminada correctamente");                         
                }
                catch (Exception)
                {
                    MessageBox.Show("Error eliminando la imagen");
                }
                
            }
        }
    }
}
