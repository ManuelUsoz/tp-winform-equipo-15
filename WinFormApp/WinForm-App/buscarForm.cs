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

            //Setear todo en visible false
            LblCampoFilter.Visible = false;
            cboxCampoFilter.Visible = false;
            LblCriterioFilter.Visible = false;
            cboxCriterioFilter.Visible = false;
            LblHint.Visible = false;
            TxtBoxQuickFilter.Visible = false;
            cboxCategoria.Visible = false;
            cboxMarca.Visible = false;
            brandLabel.Visible = false;
            categoryComboLabel.Visible = false;
            TxtBoxCriteriaFilter.Visible = false;
            btnBuscar.Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultadoBusquedaArticulo.DataSource = null;
            Marca selectedBrand = (Marca)cboxMarca.SelectedItem;
            Categoria selectedCategory = (Categoria)cboxCategoria.SelectedItem;
            string selectedCriteria = cboxCriterioFilter.SelectedItem.ToString();
            string selectedField = (string)cboxCampoFilter.SelectedItem;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                //Selecciono una marca y categoria sin filtrado de campos y criterio
                if(selectedBrand != null && selectedCategory != null && selectedField == null)
                {
                    List<Articulo> articulos = articuloNegocio.GetArticulos(selectedBrand.Id, selectedCategory.Id);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;
                }

                //Selecciono una marca pero no categoria sin filtrado de campos y criterio
                if(selectedBrand != null && selectedCategory == null && selectedField == null)
                {
                    List<Articulo> articulos = articuloNegocio.GetArticulos(selectedBrand.Id);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;
                }

                //Selecciono una categoria pero no marca sin filtrado de campos y criterio
                if(selectedBrand == null && selectedCategory != null && selectedField == null)
                {
                    List<Articulo> articulos = articuloNegocio.GetArticulosByCategory(selectedCategory.Id);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;
                }

                //No selecciono combos, pero selecciono filtros avanzados
                if(selectedBrand == null && selectedCategory == null && selectedField != null)
                {
                    string value = TxtBoxCriteriaFilter.Text;
                    List<Articulo> articulos = articuloNegocio.GetArticulos(selectedField, selectedCriteria, value);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;
                    
                }

                //Selecciono el combo de marca, no selecciono categorias pero esta filtrando por campo y criterio
                if(selectedBrand != null && selectedCategory == null && selectedField != null)
                {
                    string value = TxtBoxCriteriaFilter.Text;

                    List<Articulo> articulos = articuloNegocio.GetArticulos(selectedBrand.Id, selectedField, selectedCriteria, value);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;

                }
            }catch(Exception)
            {
                MessageBox.Show("No se encontro lo requerido");
            }
        }

        private void BtnShowFilters_Click(object sender, EventArgs e)
        {
            LblCampoFilter.Visible = true;
            cboxCampoFilter.Visible = true;
            cboxCategoria.Visible = true;
            cboxMarca.Visible = true;
            brandLabel.Visible = true;
            categoryComboLabel.Visible = true;
            btnBuscar.Visible = true;
            List<string> optionsComboBox = new List<string> { "Codigo", "Nombre", "Descripcion", "Precio", "Todos"};

            cboxCampoFilter.Items.AddRange(optionsComboBox.ToArray());


        }

        private void OnSelectedFieldChange(object sender, EventArgs e)
        {
            cboxCriterioFilter.Visible = true;
            LblCriterioFilter.Visible = true;
            cboxCriterioFilter.Items.Clear();

            if (cboxCampoFilter.SelectedItem.ToString() == "Precio")
            {
                cboxCriterioFilter.Items.Add("Es igual a");
                cboxCriterioFilter.Items.Add("Es mayor a");
                cboxCriterioFilter.Items.Add("Es menor a");
            }
            else
            {
                cboxCriterioFilter.Items.Add("Contiene");
                cboxCriterioFilter.Items.Add("Igual a");
            }

        }

        private void OnHintChange(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> articulos = articuloNegocio.GetArticulosByHint(TxtBoxQuickFilter.Text.ToLower());
            dgvResultadoBusquedaArticulo.DataSource = articulos;
        }

        private void BtnQuickFilter_Click(object sender, EventArgs e)
        {
            LblHint.Visible = true;
            TxtBoxQuickFilter.Visible = true;  
        }

        private void cboxCriterioFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtBoxCriteriaFilter.Visible = true;
            TxtBoxCriteriaFilter.Text = null;
        }
    }
}
