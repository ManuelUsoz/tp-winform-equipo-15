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
    public partial class buscarForm : Form
    {
        private List<Articulo> articulos = new List<Articulo>();

        public buscarForm()
        {
            InitializeComponent();
        }

        private void buscarForm_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.list();
            cboxMarca.Items.AddRange(marcas.ToArray());

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.List();
            cboxCategoria.Items.AddRange(categorias.ToArray());



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string selectedBrand = cboxMarca.SelectedItem.ToString();
            string selectedCategory = cboxCategoria.SelectedItem.ToString();

            try
            {
                if(selectedBrand != null)
                {
                    if(selectedCategory != null)
                    {
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                    }
                }

            }catch(Exception)
            {
                MessageBox.Show("No se encontro lo requerido");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
