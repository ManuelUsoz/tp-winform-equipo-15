namespace WinForm_App
{
    partial class frmListaArticulos
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
            this.pbListaArticulos = new System.Windows.Forms.PictureBox();
            this.labelListaArticulos = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonDetalle = new System.Windows.Forms.Button();
            this.BtnNextImage = new System.Windows.Forms.Button();
            this.BtnPrevImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbListaArticulos
            // 
            this.pbListaArticulos.Location = new System.Drawing.Point(794, 46);
            this.pbListaArticulos.Name = "pbListaArticulos";
            this.pbListaArticulos.Size = new System.Drawing.Size(301, 270);
            this.pbListaArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbListaArticulos.TabIndex = 8;
            this.pbListaArticulos.TabStop = false;
            // 
            // labelListaArticulos
            // 
            this.labelListaArticulos.AutoSize = true;
            this.labelListaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaArticulos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelListaArticulos.Location = new System.Drawing.Point(7, 9);
            this.labelListaArticulos.Name = "labelListaArticulos";
            this.labelListaArticulos.Size = new System.Drawing.Size(96, 26);
            this.labelListaArticulos.TabIndex = 7;
            this.labelListaArticulos.Text = "Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 46);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(761, 270);
            this.dgvArticulos.TabIndex = 6;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged_1);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_add_30;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAgregar.Location = new System.Drawing.Point(722, 8);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(49, 32);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_edit_30;
            this.buttonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonModificar.Location = new System.Drawing.Point(667, 8);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(49, 32);
            this.buttonModificar.TabIndex = 10;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_minus_30;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEliminar.Location = new System.Drawing.Point(612, 8);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(49, 32);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonDetalle
            // 
            this.buttonDetalle.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_eye_30;
            this.buttonDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDetalle.Location = new System.Drawing.Point(557, 8);
            this.buttonDetalle.Name = "buttonDetalle";
            this.buttonDetalle.Size = new System.Drawing.Size(49, 32);
            this.buttonDetalle.TabIndex = 13;
            this.buttonDetalle.UseVisualStyleBackColor = true;
            this.buttonDetalle.Click += new System.EventHandler(this.buttonDetalle_Click);
            // 
            // BtnNextImage
            // 
            this.BtnNextImage.Location = new System.Drawing.Point(946, 323);
            this.BtnNextImage.Name = "BtnNextImage";
            this.BtnNextImage.Size = new System.Drawing.Size(73, 24);
            this.BtnNextImage.TabIndex = 14;
            this.BtnNextImage.Text = "->";
            this.BtnNextImage.UseVisualStyleBackColor = true;
            this.BtnNextImage.Click += new System.EventHandler(this.BtnNextImage_Click);
            // 
            // BtnPrevImage
            // 
            this.BtnPrevImage.Location = new System.Drawing.Point(866, 323);
            this.BtnPrevImage.Name = "BtnPrevImage";
            this.BtnPrevImage.Size = new System.Drawing.Size(74, 24);
            this.BtnPrevImage.TabIndex = 15;
            this.BtnPrevImage.Text = "<-";
            this.BtnPrevImage.UseVisualStyleBackColor = true;
            this.BtnPrevImage.Click += new System.EventHandler(this.BtnPrevImage_Click);
            // 
            // frmListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 359);
            this.Controls.Add(this.BtnPrevImage);
            this.Controls.Add(this.BtnNextImage);
            this.Controls.Add(this.buttonDetalle);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pbListaArticulos);
            this.Controls.Add(this.labelListaArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.MinimumSize = new System.Drawing.Size(1101, 359);
            this.Name = "frmListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de articulos";
            this.Load += new System.EventHandler(this.frmListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbListaArticulos;
        private System.Windows.Forms.Label labelListaArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonDetalle;
        private System.Windows.Forms.Button BtnNextImage;
        private System.Windows.Forms.Button BtnPrevImage;
    }
}