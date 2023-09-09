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
            this.lblField = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusquedaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(836, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
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
            this.dgvResultadoBusquedaArticulo.Location = new System.Drawing.Point(28, 108);
            this.dgvResultadoBusquedaArticulo.Name = "dgvResultadoBusquedaArticulo";
            this.dgvResultadoBusquedaArticulo.RowHeadersWidth = 51;
            this.dgvResultadoBusquedaArticulo.RowTemplate.Height = 24;
            this.dgvResultadoBusquedaArticulo.Size = new System.Drawing.Size(883, 422);
            this.dgvResultadoBusquedaArticulo.TabIndex = 1;
            // 
            // titleFormSearch
            // 
            this.titleFormSearch.AutoSize = true;
            this.titleFormSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFormSearch.Location = new System.Drawing.Point(22, 48);
            this.titleFormSearch.Name = "titleFormSearch";
            this.titleFormSearch.Size = new System.Drawing.Size(150, 32);
            this.titleFormSearch.TabIndex = 2;
            this.titleFormSearch.Text = "Buscar por";
            // 
            // categoryComboLabel
            // 
            this.categoryComboLabel.AutoSize = true;
            this.categoryComboLabel.Location = new System.Drawing.Point(217, 37);
            this.categoryComboLabel.Name = "categoryComboLabel";
            this.categoryComboLabel.Size = new System.Drawing.Size(66, 16);
            this.categoryComboLabel.TabIndex = 3;
            this.categoryComboLabel.Text = "Categoria";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(377, 37);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(45, 16);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Marca";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(534, 37);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(51, 16);
            this.lblField.TabIndex = 5;
            this.lblField.Text = "Campo";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(220, 57);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(121, 24);
            this.cboxCategoria.TabIndex = 6;
            this.cboxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboxMarca
            // 
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(380, 56);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(121, 24);
            this.cboxMarca.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(537, 56);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // buscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1316, 558);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.lblField);
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
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}