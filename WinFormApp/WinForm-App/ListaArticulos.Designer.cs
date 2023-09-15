﻿namespace WinForm_App
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
            ((System.ComponentModel.ISupportInitialize)(this.pbListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbListaArticulos
            // 
            this.pbListaArticulos.Location = new System.Drawing.Point(779, 46);
            this.pbListaArticulos.Name = "pbListaArticulos";
            this.pbListaArticulos.Size = new System.Drawing.Size(301, 270);
            this.pbListaArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbListaArticulos.TabIndex = 8;
            this.pbListaArticulos.TabStop = false;
            // 
            // labelListaArticulos
            // 
            this.labelListaArticulos.AutoSize = true;
            this.labelListaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelListaArticulos.Location = new System.Drawing.Point(7, 9);
            this.labelListaArticulos.Name = "labelListaArticulos";
            this.labelListaArticulos.Size = new System.Drawing.Size(160, 25);
            this.labelListaArticulos.TabIndex = 7;
            this.labelListaArticulos.Text = "Lista de Artículos";
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
            this.buttonAgregar.Location = new System.Drawing.Point(701, 8);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(72, 32);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(625, 8);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(72, 32);
            this.buttonModificar.TabIndex = 10;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(549, 8);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(72, 32);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonDetalle
            // 
            this.buttonDetalle.Location = new System.Drawing.Point(473, 8);
            this.buttonDetalle.Name = "buttonDetalle";
            this.buttonDetalle.Size = new System.Drawing.Size(72, 32);
            this.buttonDetalle.TabIndex = 13;
            this.buttonDetalle.Text = "Detalle";
            this.buttonDetalle.UseVisualStyleBackColor = true;
            this.buttonDetalle.Click += new System.EventHandler(this.buttonDetalle_Click);
            // 
            // frmListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 322);
            this.Controls.Add(this.buttonDetalle);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pbListaArticulos);
            this.Controls.Add(this.labelListaArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.MinimumSize = new System.Drawing.Size(1102, 361);
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
    }
}