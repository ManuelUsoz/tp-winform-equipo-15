namespace WinForm_App
{
    partial class ModificarArticulo
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
            this.LblCodigoArticulo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CboxCategorias = new System.Windows.Forms.ComboBox();
            this.CboxMarca = new System.Windows.Forms.ComboBox();
            this.TxtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.TxtBoxNombre = new System.Windows.Forms.TextBox();
            this.TxtBoxCodigo = new System.Windows.Forms.TextBox();
            this.PicBoxArticulo = new System.Windows.Forms.PictureBox();
            this.TxtBoxPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblImagenUrl = new System.Windows.Forms.Label();
            this.TxtBoxImagenUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigoArticulo
            // 
            this.LblCodigoArticulo.AutoSize = true;
            this.LblCodigoArticulo.Location = new System.Drawing.Point(11, 22);
            this.LblCodigoArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodigoArticulo.Name = "LblCodigoArticulo";
            this.LblCodigoArticulo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigoArticulo.TabIndex = 0;
            this.LblCodigoArticulo.Text = "Código";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(11, 49);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(11, 75);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(11, 130);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(37, 13);
            this.LblMarca.TabIndex = 3;
            this.LblMarca.Text = "Marca";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoEllipsis = true;
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblCategoria.Location = new System.Drawing.Point(11, 159);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 4;
            this.LblCategoria.Text = "Categoria";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(88, 225);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(72, 32);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(237, 225);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(72, 32);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CboxCategorias
            // 
            this.CboxCategorias.FormattingEnabled = true;
            this.CboxCategorias.Location = new System.Drawing.Point(88, 156);
            this.CboxCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboxCategorias.Name = "CboxCategorias";
            this.CboxCategorias.Size = new System.Drawing.Size(145, 21);
            this.CboxCategorias.TabIndex = 8;
            // 
            // CboxMarca
            // 
            this.CboxMarca.FormattingEnabled = true;
            this.CboxMarca.Location = new System.Drawing.Point(88, 128);
            this.CboxMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboxMarca.Name = "CboxMarca";
            this.CboxMarca.Size = new System.Drawing.Size(145, 21);
            this.CboxMarca.TabIndex = 9;
            // 
            // TxtBoxDescripcion
            // 
            this.TxtBoxDescripcion.Location = new System.Drawing.Point(88, 73);
            this.TxtBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxDescripcion.Name = "TxtBoxDescripcion";
            this.TxtBoxDescripcion.Size = new System.Drawing.Size(145, 20);
            this.TxtBoxDescripcion.TabIndex = 10;
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(88, 47);
            this.TxtBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(145, 20);
            this.TxtBoxNombre.TabIndex = 11;
            // 
            // TxtBoxCodigo
            // 
            this.TxtBoxCodigo.Location = new System.Drawing.Point(88, 17);
            this.TxtBoxCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxCodigo.Name = "TxtBoxCodigo";
            this.TxtBoxCodigo.Size = new System.Drawing.Size(145, 20);
            this.TxtBoxCodigo.TabIndex = 12;
            // 
            // PicBoxArticulo
            // 
            this.PicBoxArticulo.Location = new System.Drawing.Point(237, 17);
            this.PicBoxArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicBoxArticulo.Name = "PicBoxArticulo";
            this.PicBoxArticulo.Size = new System.Drawing.Size(184, 184);
            this.PicBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxArticulo.TabIndex = 13;
            this.PicBoxArticulo.TabStop = false;
            // 
            // TxtBoxPrecio
            // 
            this.TxtBoxPrecio.Location = new System.Drawing.Point(88, 181);
            this.TxtBoxPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxPrecio.Name = "TxtBoxPrecio";
            this.TxtBoxPrecio.Size = new System.Drawing.Size(145, 20);
            this.TxtBoxPrecio.TabIndex = 15;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(11, 184);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 14;
            this.LblPrecio.Text = "Precio";
            // 
            // LblImagenUrl
            // 
            this.LblImagenUrl.AutoSize = true;
            this.LblImagenUrl.Location = new System.Drawing.Point(11, 103);
            this.LblImagenUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblImagenUrl.Name = "LblImagenUrl";
            this.LblImagenUrl.Size = new System.Drawing.Size(62, 13);
            this.LblImagenUrl.TabIndex = 16;
            this.LblImagenUrl.Text = "Imagen (url)";
            // 
            // TxtBoxImagenUrl
            // 
            this.TxtBoxImagenUrl.Location = new System.Drawing.Point(88, 100);
            this.TxtBoxImagenUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxImagenUrl.Name = "TxtBoxImagenUrl";
            this.TxtBoxImagenUrl.Size = new System.Drawing.Size(145, 20);
            this.TxtBoxImagenUrl.TabIndex = 17;
            this.TxtBoxImagenUrl.Leave += new System.EventHandler(this.TxtBoxImagenUrl_Leave);
            // 
            // ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 268);
            this.Controls.Add(this.TxtBoxImagenUrl);
            this.Controls.Add(this.LblImagenUrl);
            this.Controls.Add(this.TxtBoxPrecio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.PicBoxArticulo);
            this.Controls.Add(this.TxtBoxCodigo);
            this.Controls.Add(this.TxtBoxNombre);
            this.Controls.Add(this.TxtBoxDescripcion);
            this.Controls.Add(this.CboxMarca);
            this.Controls.Add(this.CboxCategorias);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigoArticulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(452, 307);
            this.Name = "ModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            this.Load += new System.EventHandler(this.ModificarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigoArticulo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CboxCategorias;
        private System.Windows.Forms.ComboBox CboxMarca;
        private System.Windows.Forms.TextBox TxtBoxDescripcion;
        private System.Windows.Forms.TextBox TxtBoxNombre;
        private System.Windows.Forms.TextBox TxtBoxCodigo;
        private System.Windows.Forms.PictureBox PicBoxArticulo;
        private System.Windows.Forms.TextBox TxtBoxPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblImagenUrl;
        private System.Windows.Forms.TextBox TxtBoxImagenUrl;
    }
}