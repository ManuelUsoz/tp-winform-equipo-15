namespace WinForm_App
{
    partial class BuscarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvResultadoBusquedaArticulo = new System.Windows.Forms.DataGridView();
            this.categoryComboLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.BtnShowFilters = new System.Windows.Forms.Button();
            this.LblCampoFilter = new System.Windows.Forms.Label();
            this.cboxCampoFilter = new System.Windows.Forms.ComboBox();
            this.cboxCriterioFilter = new System.Windows.Forms.ComboBox();
            this.LblCriterioFilter = new System.Windows.Forms.Label();
            this.BtnQuickFilter = new System.Windows.Forms.Button();
            this.TxtBoxQuickFilter = new System.Windows.Forms.TextBox();
            this.LblHint = new System.Windows.Forms.Label();
            this.TxtBoxCriteriaFilter = new System.Windows.Forms.TextBox();
            this.BtnResetFilters = new System.Windows.Forms.Button();
            this.PicBoxArticulo = new System.Windows.Forms.PictureBox();
            this.BtnPrevImage = new System.Windows.Forms.Button();
            this.BtnNextImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusquedaArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(562, 11);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 36);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultadoBusquedaArticulo
            // 
            this.dgvResultadoBusquedaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusquedaArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResultadoBusquedaArticulo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvResultadoBusquedaArticulo.Location = new System.Drawing.Point(11, 121);
            this.dgvResultadoBusquedaArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResultadoBusquedaArticulo.MultiSelect = false;
            this.dgvResultadoBusquedaArticulo.Name = "dgvResultadoBusquedaArticulo";
            this.dgvResultadoBusquedaArticulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResultadoBusquedaArticulo.RowHeadersWidth = 51;
            this.dgvResultadoBusquedaArticulo.RowTemplate.Height = 24;
            this.dgvResultadoBusquedaArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusquedaArticulo.Size = new System.Drawing.Size(860, 270);
            this.dgvResultadoBusquedaArticulo.TabIndex = 1;
            this.dgvResultadoBusquedaArticulo.SelectionChanged += new System.EventHandler(this.OnSelectionChange);
            // 
            // categoryComboLabel
            // 
            this.categoryComboLabel.AutoSize = true;
            this.categoryComboLabel.Location = new System.Drawing.Point(215, 72);
            this.categoryComboLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryComboLabel.Name = "categoryComboLabel";
            this.categoryComboLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryComboLabel.TabIndex = 3;
            this.categoryComboLabel.Text = "Categoria";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(102, 72);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(37, 13);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Marca";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(217, 90);
            this.cboxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(103, 21);
            this.cboxCategoria.TabIndex = 6;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(104, 90);
            this.cboxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(102, 21);
            this.cboxMarca.TabIndex = 7;
            // 
            // BtnShowFilters
            // 
            this.BtnShowFilters.Location = new System.Drawing.Point(11, 75);
            this.BtnShowFilters.Margin = new System.Windows.Forms.Padding(2);
            this.BtnShowFilters.Name = "BtnShowFilters";
            this.BtnShowFilters.Size = new System.Drawing.Size(84, 37);
            this.BtnShowFilters.TabIndex = 17;
            this.BtnShowFilters.Text = "Filtros avanzados";
            this.BtnShowFilters.UseVisualStyleBackColor = true;
            this.BtnShowFilters.Click += new System.EventHandler(this.BtnShowFilters_Click);
            // 
            // LblCampoFilter
            // 
            this.LblCampoFilter.AutoSize = true;
            this.LblCampoFilter.Location = new System.Drawing.Point(328, 72);
            this.LblCampoFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampoFilter.Name = "LblCampoFilter";
            this.LblCampoFilter.Size = new System.Drawing.Size(40, 13);
            this.LblCampoFilter.TabIndex = 18;
            this.LblCampoFilter.Text = "Campo";
            // 
            // cboxCampoFilter
            // 
            this.cboxCampoFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampoFilter.FormattingEnabled = true;
            this.cboxCampoFilter.Location = new System.Drawing.Point(330, 90);
            this.cboxCampoFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCampoFilter.Name = "cboxCampoFilter";
            this.cboxCampoFilter.Size = new System.Drawing.Size(92, 21);
            this.cboxCampoFilter.TabIndex = 19;
            this.cboxCampoFilter.SelectedIndexChanged += new System.EventHandler(this.OnSelectedFieldChange);
            // 
            // cboxCriterioFilter
            // 
            this.cboxCriterioFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterioFilter.FormattingEnabled = true;
            this.cboxCriterioFilter.Location = new System.Drawing.Point(433, 90);
            this.cboxCriterioFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCriterioFilter.Name = "cboxCriterioFilter";
            this.cboxCriterioFilter.Size = new System.Drawing.Size(92, 21);
            this.cboxCriterioFilter.TabIndex = 20;
            this.cboxCriterioFilter.SelectedIndexChanged += new System.EventHandler(this.cboxCriterioFilter_SelectedIndexChanged);
            // 
            // LblCriterioFilter
            // 
            this.LblCriterioFilter.AutoSize = true;
            this.LblCriterioFilter.Location = new System.Drawing.Point(431, 72);
            this.LblCriterioFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCriterioFilter.Name = "LblCriterioFilter";
            this.LblCriterioFilter.Size = new System.Drawing.Size(39, 13);
            this.LblCriterioFilter.TabIndex = 21;
            this.LblCriterioFilter.Text = "Criterio";
            // 
            // BtnQuickFilter
            // 
            this.BtnQuickFilter.Location = new System.Drawing.Point(11, 23);
            this.BtnQuickFilter.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuickFilter.Name = "BtnQuickFilter";
            this.BtnQuickFilter.Size = new System.Drawing.Size(84, 37);
            this.BtnQuickFilter.TabIndex = 22;
            this.BtnQuickFilter.Text = "Filtro rapido";
            this.BtnQuickFilter.UseVisualStyleBackColor = true;
            this.BtnQuickFilter.Click += new System.EventHandler(this.BtnQuickFilter_Click);
            // 
            // TxtBoxQuickFilter
            // 
            this.TxtBoxQuickFilter.Location = new System.Drawing.Point(101, 38);
            this.TxtBoxQuickFilter.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBoxQuickFilter.Name = "TxtBoxQuickFilter";
            this.TxtBoxQuickFilter.Size = new System.Drawing.Size(149, 20);
            this.TxtBoxQuickFilter.TabIndex = 23;
            this.TxtBoxQuickFilter.TextChanged += new System.EventHandler(this.OnHintChange);
            // 
            // LblHint
            // 
            this.LblHint.AutoSize = true;
            this.LblHint.Location = new System.Drawing.Point(99, 23);
            this.LblHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHint.Name = "LblHint";
            this.LblHint.Size = new System.Drawing.Size(88, 13);
            this.LblHint.TabIndex = 24;
            this.LblHint.Text = "Ingrese una pista";
            // 
            // TxtBoxCriteriaFilter
            // 
            this.TxtBoxCriteriaFilter.Location = new System.Drawing.Point(538, 92);
            this.TxtBoxCriteriaFilter.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBoxCriteriaFilter.Name = "TxtBoxCriteriaFilter";
            this.TxtBoxCriteriaFilter.Size = new System.Drawing.Size(108, 20);
            this.TxtBoxCriteriaFilter.TabIndex = 25;
            // 
            // BtnResetFilters
            // 
            this.BtnResetFilters.Location = new System.Drawing.Point(474, 11);
            this.BtnResetFilters.Margin = new System.Windows.Forms.Padding(2);
            this.BtnResetFilters.Name = "BtnResetFilters";
            this.BtnResetFilters.Size = new System.Drawing.Size(84, 36);
            this.BtnResetFilters.TabIndex = 26;
            this.BtnResetFilters.Text = "Resetear filtros";
            this.BtnResetFilters.UseVisualStyleBackColor = true;
            this.BtnResetFilters.Click += new System.EventHandler(this.BtnResetFilters_Click);
            // 
            // PicBoxArticulo
            // 
            this.PicBoxArticulo.Location = new System.Drawing.Point(876, 121);
            this.PicBoxArticulo.Name = "PicBoxArticulo";
            this.PicBoxArticulo.Size = new System.Drawing.Size(301, 270);
            this.PicBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxArticulo.TabIndex = 27;
            this.PicBoxArticulo.TabStop = false;
            // 
            // BtnPrevImage
            // 
            this.BtnPrevImage.Location = new System.Drawing.Point(959, 397);
            this.BtnPrevImage.Name = "BtnPrevImage";
            this.BtnPrevImage.Size = new System.Drawing.Size(74, 24);
            this.BtnPrevImage.TabIndex = 29;
            this.BtnPrevImage.Text = "<-";
            this.BtnPrevImage.UseVisualStyleBackColor = true;
            this.BtnPrevImage.Click += new System.EventHandler(this.BtnPrevImage_Click);
            // 
            // BtnNextImage
            // 
            this.BtnNextImage.Location = new System.Drawing.Point(1039, 397);
            this.BtnNextImage.Name = "BtnNextImage";
            this.BtnNextImage.Size = new System.Drawing.Size(73, 24);
            this.BtnNextImage.TabIndex = 28;
            this.BtnNextImage.Text = "->";
            this.BtnNextImage.UseVisualStyleBackColor = true;
            this.BtnNextImage.Click += new System.EventHandler(this.BtnNextImage_Click);
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 429);
            this.Controls.Add(this.BtnPrevImage);
            this.Controls.Add(this.BtnNextImage);
            this.Controls.Add(this.PicBoxArticulo);
            this.Controls.Add(this.BtnResetFilters);
            this.Controls.Add(this.TxtBoxCriteriaFilter);
            this.Controls.Add(this.LblHint);
            this.Controls.Add(this.TxtBoxQuickFilter);
            this.Controls.Add(this.BtnQuickFilter);
            this.Controls.Add(this.LblCriterioFilter);
            this.Controls.Add(this.cboxCriterioFilter);
            this.Controls.Add(this.cboxCampoFilter);
            this.Controls.Add(this.LblCampoFilter);
            this.Controls.Add(this.BtnShowFilters);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.categoryComboLabel);
            this.Controls.Add(this.dgvResultadoBusquedaArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1192, 439);
            this.Name = "BuscarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscarForm";
            this.Load += new System.EventHandler(this.buscarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusquedaArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultadoBusquedaArticulo;
        private System.Windows.Forms.Label categoryComboLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Button BtnShowFilters;
        private System.Windows.Forms.Label LblCampoFilter;
        private System.Windows.Forms.ComboBox cboxCampoFilter;
        private System.Windows.Forms.ComboBox cboxCriterioFilter;
        private System.Windows.Forms.Label LblCriterioFilter;
        private System.Windows.Forms.Button BtnQuickFilter;
        private System.Windows.Forms.TextBox TxtBoxQuickFilter;
        private System.Windows.Forms.Label LblHint;
        private System.Windows.Forms.TextBox TxtBoxCriteriaFilter;
        private System.Windows.Forms.Button BtnResetFilters;
        private System.Windows.Forms.PictureBox PicBoxArticulo;
        private System.Windows.Forms.Button BtnPrevImage;
        private System.Windows.Forms.Button BtnNextImage;
    }
}