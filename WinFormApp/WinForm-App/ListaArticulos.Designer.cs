namespace WinForm_App
{
    partial class ListaArticulos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelListaArticulos = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(645, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 458);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelListaArticulos
            // 
            this.labelListaArticulos.AutoSize = true;
            this.labelListaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelListaArticulos.Location = new System.Drawing.Point(9, 11);
            this.labelListaArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaArticulos.Name = "labelListaArticulos";
            this.labelListaArticulos.Size = new System.Drawing.Size(207, 29);
            this.labelListaArticulos.TabIndex = 7;
            this.labelListaArticulos.Text = "Lista de Articulos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(16, 46);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(621, 458);
            this.dgvArticulos.TabIndex = 6;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(16, 511);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(93, 28);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelListaArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de articulos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelListaArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button buttonAgregar;
    }
}