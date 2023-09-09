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

            LblCampoFilter.Visible = false;
            cboxCampoFilter.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Marca selectedBrand = (Marca)cboxMarca.SelectedItem;
            Categoria selectedCategory = (Categoria)cboxCategoria.SelectedItem;
            string selectedField = (string)cboxCampoFilter.SelectedItem;

            try
            {
                if(selectedBrand != null) 
                {
                    if(selectedCategory != null)
                    {
                        if(selectedField != null)
                        {
                            switch (selectedField)
                            {
                                case "Codigo":

                                    break;
                                case "Nombre":
                                    break;
                                case "Precio":
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                            List<Articulo> articulos = articuloNegocio.GetArticulos(selectedBrand.Id, selectedCategory.Id);
                            dgvResultadoBusquedaArticulo.DataSource = articulos;
                        }
                    }
                    else
                    {
                        dgvResultadoBusquedaArticulo.DataSource = null;
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                        List<Articulo> articulos = articuloNegocio.GetArticulos(selectedBrand.Id);
                        dgvResultadoBusquedaArticulo.DataSource = articulos;

                    }
                }
                else if(selectedBrand == null)
                {
                    if (selectedCategory != null)
                    {
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                        List<Articulo> articulos = articuloNegocio.GetArticulosByCategory(selectedCategory.Id);
                        dgvResultadoBusquedaArticulo.DataSource = articulos;
                    }
                }
                else
                {
                    //Listar todos
                }

                BtnShowFilters.Visible = true;
            }catch(Exception)
            {
                MessageBox.Show("No se encontro lo requerido");
            }
        }

        private void BtnShowFilters_Click(object sender, EventArgs e)
        {
            LblCampoFilter.Visible = true;
            cboxCampoFilter.Visible = true;
            List<string> optionsComboBox = new List<string> { "Codigo", "Nombre", "Descripcion", "Precio"};

            cboxCampoFilter.Items.AddRange(optionsComboBox.ToArray());


        }

        
    }
}
