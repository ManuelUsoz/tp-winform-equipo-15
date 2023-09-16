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
    public partial class BuscarForm : Form
    {
        private int imageCounter = 0;
        public BuscarForm()
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
            BtnResetFilters.Visible = false;

        }
            
        private bool validateCbox()
        {
            if(cboxCampoFilter.SelectedIndex != -1)
            {
                if(cboxCriterioFilter.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un criterio a filtrar");
                    return false;
                }
                else
                {
                    if(cboxCampoFilter.SelectedItem.ToString() == "Precio")
                    {
                        if (!decimal.TryParse(TxtBoxCriteriaFilter.Text, out decimal txt))
                        {
                            MessageBox.Show("Si quiere filtrar por precio ingrese números");
                            return false;
                        }
                    }
                }
            }

            
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultadoBusquedaArticulo.DataSource = null;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                Marca selectedBrand = (Marca)cboxMarca.SelectedItem ?? null;
                Categoria selectedCategory = (Categoria)cboxCategoria.SelectedItem;
                string selectedCriteria = (string)cboxCriterioFilter.SelectedItem;
                string selectedField = (string)cboxCampoFilter.SelectedItem;

                if (!this.validateCbox())
                {
                    this.BtnResetFilters_Click(sender, e);
                    return;
                }

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

                //Selecciono el combo de categoria, sin marca pero con filtros especificos
                if(selectedBrand == null && selectedCategory != null && selectedField != null)
                {
                    string value = TxtBoxCriteriaFilter.Text;
                    List<Articulo> articulos = articuloNegocio.GetArticulosByCategory(selectedCategory.Id, selectedField, selectedCriteria, value);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;
                }

                //Selecciono todos los combos
                if(selectedBrand != null && selectedCategory != null && selectedField != null)
                {
                    string value = TxtBoxCriteriaFilter.Text;
                    List<Articulo> articulos = articuloNegocio.GetArticulos(selectedBrand.Id, selectedCategory.Id, selectedField, selectedCriteria, value);
                    dgvResultadoBusquedaArticulo.DataSource = articulos;   
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro lo requerido");
            }
            finally
            {
                cboxCampoFilter.SelectedIndex = -1;
                cboxCategoria.SelectedIndex = -1;
                cboxCriterioFilter.SelectedIndex = -1;
                cboxMarca.SelectedIndex = -1;
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
            BtnResetFilters.Visible = true;
            List<string> optionsComboBox = new List<string> { "Codigo", "Nombre", "Descripcion", "Precio", "Todos"};

            cboxCampoFilter.Items.AddRange(optionsComboBox.ToArray());


        }

        private void OnSelectedFieldChange(object sender, EventArgs e)
        {
            cboxCriterioFilter.Visible = true;
            LblCriterioFilter.Visible = true;
            cboxCriterioFilter.Items.Clear();

            if ((string)cboxCampoFilter.SelectedItem == "Precio")
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

        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            cboxCampoFilter.SelectedIndex = -1;
            cboxMarca.SelectedIndex = -1;
            cboxCategoria.SelectedIndex = -1;
            cboxCriterioFilter.SelectedIndex = -1;
            TxtBoxCriteriaFilter.Text = null;
        }

        private void OnSelectionChange(object sender, EventArgs e)
        {
            Articulo articulo = dgvResultadoBusquedaArticulo.CurrentRow.DataBoundItem as Articulo;
            this.imageCounter = 0;
            try
            {
                PicBoxArticulo.Load(articulo.ImagenURL[this.imageCounter].ImagenUrl);
            }
            catch (Exception)
            {
                PicBoxArticulo.Image = Properties.Resources.OIP;
            }
        }
        private void BtnNextImage_Click(object sender, EventArgs e)
        {
            this.imageCounter++;
            Articulo articulo = dgvResultadoBusquedaArticulo.CurrentRow.DataBoundItem as Articulo;
            try
            {
                PicBoxArticulo.Load(articulo.ImagenURL[this.imageCounter].ImagenUrl);

            }
            catch (Exception)
            {
                this.imageCounter--;
                return;
            }
        }

        private void BtnPrevImage_Click(object sender, EventArgs e)
        {
            this.imageCounter--;
            Articulo articulo = dgvResultadoBusquedaArticulo.CurrentRow.DataBoundItem as Articulo;
            try
            {
                PicBoxArticulo.Load(articulo.ImagenURL[this.imageCounter].ImagenUrl);
            }
            catch (Exception)
            {
                this.imageCounter++;
                return;
            }
        }

        
    }
}
