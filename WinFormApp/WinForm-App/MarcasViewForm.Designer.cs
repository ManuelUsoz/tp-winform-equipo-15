namespace WinForm_App
{
    partial class MarcasViewForm
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
            this.LblMarcasTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnVerDetalleMarca = new System.Windows.Forms.Button();
            this.BtnEliminarMarca = new System.Windows.Forms.Button();
            this.BtnModificarMarca = new System.Windows.Forms.Button();
            this.BtnAgregarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMarcasTitle
            // 
            this.LblMarcasTitle.AutoSize = true;
            this.LblMarcasTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarcasTitle.Location = new System.Drawing.Point(6, 34);
            this.LblMarcasTitle.Name = "LblMarcasTitle";
            this.LblMarcasTitle.Size = new System.Drawing.Size(106, 32);
            this.LblMarcasTitle.TabIndex = 0;
            this.LblMarcasTitle.Text = "Marcas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 338);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnVerDetalleMarca
            // 
            this.BtnVerDetalleMarca.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_eye_30;
            this.BtnVerDetalleMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVerDetalleMarca.Location = new System.Drawing.Point(422, 34);
            this.BtnVerDetalleMarca.Name = "BtnVerDetalleMarca";
            this.BtnVerDetalleMarca.Size = new System.Drawing.Size(84, 39);
            this.BtnVerDetalleMarca.TabIndex = 5;
            this.BtnVerDetalleMarca.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarMarca
            // 
            this.BtnEliminarMarca.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_minus_30;
            this.BtnEliminarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminarMarca.Location = new System.Drawing.Point(512, 34);
            this.BtnEliminarMarca.Name = "BtnEliminarMarca";
            this.BtnEliminarMarca.Size = new System.Drawing.Size(84, 39);
            this.BtnEliminarMarca.TabIndex = 4;
            this.BtnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // BtnModificarMarca
            // 
            this.BtnModificarMarca.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_edit_30;
            this.BtnModificarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModificarMarca.Location = new System.Drawing.Point(602, 34);
            this.BtnModificarMarca.Name = "BtnModificarMarca";
            this.BtnModificarMarca.Size = new System.Drawing.Size(84, 39);
            this.BtnModificarMarca.TabIndex = 3;
            this.BtnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarMarca
            // 
            this.BtnAgregarMarca.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_add_30;
            this.BtnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAgregarMarca.Location = new System.Drawing.Point(692, 34);
            this.BtnAgregarMarca.Name = "BtnAgregarMarca";
            this.BtnAgregarMarca.Size = new System.Drawing.Size(84, 39);
            this.BtnAgregarMarca.TabIndex = 2;
            this.BtnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // MarcasViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVerDetalleMarca);
            this.Controls.Add(this.BtnEliminarMarca);
            this.Controls.Add(this.BtnModificarMarca);
            this.Controls.Add(this.BtnAgregarMarca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblMarcasTitle);
            this.Name = "MarcasViewForm";
            this.Text = "MarcasViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMarcasTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregarMarca;
        private System.Windows.Forms.Button BtnModificarMarca;
        private System.Windows.Forms.Button BtnEliminarMarca;
        private System.Windows.Forms.Button BtnVerDetalleMarca;
    }
}