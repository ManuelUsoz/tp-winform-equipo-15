namespace WinForm_App
{
    partial class buscarForm
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
            this.titleFormSearch = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusquedaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(909, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 44);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultadoBusquedaArticulo
            // 
            this.dgvResultadoBusquedaArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvResultadoBusquedaArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusquedaArticulo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvResultadoBusquedaArticulo.Location = new System.Drawing.Point(28, 200);
            this.dgvResultadoBusquedaArticulo.Name = "dgvResultadoBusquedaArticulo";
            this.dgvResultadoBusquedaArticulo.RowHeadersWidth = 51;
            this.dgvResultadoBusquedaArticulo.RowTemplate.Height = 24;
            this.dgvResultadoBusquedaArticulo.Size = new System.Drawing.Size(993, 332);
            this.dgvResultadoBusquedaArticulo.TabIndex = 1;
            // 
            // titleFormSearch
            // 
            this.titleFormSearch.AutoSize = true;
            this.titleFormSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFormSearch.Location = new System.Drawing.Point(22, 9);
            this.titleFormSearch.Name = "titleFormSearch";
            this.titleFormSearch.Size = new System.Drawing.Size(102, 32);
            this.titleFormSearch.TabIndex = 2;
            this.titleFormSearch.Text = "Buscar\r\n";
            // 
            // categoryComboLabel
            // 
            this.categoryComboLabel.AutoSize = true;
            this.categoryComboLabel.Location = new System.Drawing.Point(314, 131);
            this.categoryComboLabel.Name = "categoryComboLabel";
            this.categoryComboLabel.Size = new System.Drawing.Size(66, 16);
            this.categoryComboLabel.TabIndex = 3;
            this.categoryComboLabel.Text = "Categoria";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(164, 131);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(45, 16);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Marca";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(317, 153);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(136, 24);
            this.cboxCategoria.TabIndex = 6;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(167, 153);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(135, 24);
            this.cboxMarca.TabIndex = 7;
            // 
            // BtnShowFilters
            // 
            this.BtnShowFilters.Location = new System.Drawing.Point(28, 131);
            this.BtnShowFilters.Name = "BtnShowFilters";
            this.BtnShowFilters.Size = new System.Drawing.Size(112, 46);
            this.BtnShowFilters.TabIndex = 17;
            this.BtnShowFilters.Text = "Filtros avanzados";
            this.BtnShowFilters.UseVisualStyleBackColor = true;
            this.BtnShowFilters.Click += new System.EventHandler(this.BtnShowFilters_Click);
            // 
            // LblCampoFilter
            // 
            this.LblCampoFilter.AutoSize = true;
            this.LblCampoFilter.Location = new System.Drawing.Point(465, 131);
            this.LblCampoFilter.Name = "LblCampoFilter";
            this.LblCampoFilter.Size = new System.Drawing.Size(51, 16);
            this.LblCampoFilter.TabIndex = 18;
            this.LblCampoFilter.Text = "Campo";
            // 
            // cboxCampoFilter
            // 
            this.cboxCampoFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampoFilter.FormattingEnabled = true;
            this.cboxCampoFilter.Location = new System.Drawing.Point(468, 153);
            this.cboxCampoFilter.Name = "cboxCampoFilter";
            this.cboxCampoFilter.Size = new System.Drawing.Size(121, 24);
            this.cboxCampoFilter.TabIndex = 19;
            this.cboxCampoFilter.SelectedIndexChanged += new System.EventHandler(this.OnSelectedFieldChange);
            // 
            // cboxCriterioFilter
            // 
            this.cboxCriterioFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterioFilter.FormattingEnabled = true;
            this.cboxCriterioFilter.Location = new System.Drawing.Point(606, 153);
            this.cboxCriterioFilter.Name = "cboxCriterioFilter";
            this.cboxCriterioFilter.Size = new System.Drawing.Size(121, 24);
            this.cboxCriterioFilter.TabIndex = 20;
            this.cboxCriterioFilter.SelectedIndexChanged += new System.EventHandler(this.cboxCriterioFilter_SelectedIndexChanged);
            // 
            // LblCriterioFilter
            // 
            this.LblCriterioFilter.AutoSize = true;
            this.LblCriterioFilter.Location = new System.Drawing.Point(603, 131);
            this.LblCriterioFilter.Name = "LblCriterioFilter";
            this.LblCriterioFilter.Size = new System.Drawing.Size(49, 16);
            this.LblCriterioFilter.TabIndex = 21;
            this.LblCriterioFilter.Text = "Criterio";
            // 
            // BtnQuickFilter
            // 
            this.BtnQuickFilter.Location = new System.Drawing.Point(28, 65);
            this.BtnQuickFilter.Name = "BtnQuickFilter";
            this.BtnQuickFilter.Size = new System.Drawing.Size(112, 46);
            this.BtnQuickFilter.TabIndex = 22;
            this.BtnQuickFilter.Text = "Filtro rapido";
            this.BtnQuickFilter.UseVisualStyleBackColor = true;
            this.BtnQuickFilter.Click += new System.EventHandler(this.BtnQuickFilter_Click);
            // 
            // TxtBoxQuickFilter
            // 
            this.TxtBoxQuickFilter.Location = new System.Drawing.Point(163, 89);
            this.TxtBoxQuickFilter.Name = "TxtBoxQuickFilter";
            this.TxtBoxQuickFilter.Size = new System.Drawing.Size(197, 22);
            this.TxtBoxQuickFilter.TabIndex = 23;
            this.TxtBoxQuickFilter.TextChanged += new System.EventHandler(this.OnHintChange);
            // 
            // LblHint
            // 
            this.LblHint.AutoSize = true;
            this.LblHint.Location = new System.Drawing.Point(160, 70);
            this.LblHint.Name = "LblHint";
            this.LblHint.Size = new System.Drawing.Size(109, 16);
            this.LblHint.TabIndex = 24;
            this.LblHint.Text = "Ingrese una pista";
            // 
            // TxtBoxCriteriaFilter
            // 
            this.TxtBoxCriteriaFilter.Location = new System.Drawing.Point(745, 155);
            this.TxtBoxCriteriaFilter.Name = "TxtBoxCriteriaFilter";
            this.TxtBoxCriteriaFilter.Size = new System.Drawing.Size(143, 22);
            this.TxtBoxCriteriaFilter.TabIndex = 25;
            // 
            // BtnResetFilters
            // 
            this.BtnResetFilters.Location = new System.Drawing.Point(909, 133);
            this.BtnResetFilters.Name = "BtnResetFilters";
            this.BtnResetFilters.Size = new System.Drawing.Size(112, 44);
            this.BtnResetFilters.TabIndex = 26;
            this.BtnResetFilters.Text = "Resetear filtros";
            this.BtnResetFilters.UseVisualStyleBackColor = true;
            this.BtnResetFilters.Click += new System.EventHandler(this.BtnResetFilters_Click);
            // 
            // buscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1316, 558);
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
            this.Controls.Add(this.titleFormSearch);
            this.Controls.Add(this.dgvResultadoBusquedaArticulo);
            this.Controls.Add(this.btnBuscar);
            this.MinimumSize = new System.Drawing.Size(1334, 605);
            this.Name = "buscarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscarForm";
            this.Load += new System.EventHandler(this.buscarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusquedaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultadoBusquedaArticulo;
        private System.Windows.Forms.Label titleFormSearch;
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
    }
}