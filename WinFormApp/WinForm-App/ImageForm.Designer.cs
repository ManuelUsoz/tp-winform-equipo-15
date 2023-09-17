namespace WinForm_App
{
    partial class ImageForm
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblImageUrl = new System.Windows.Forms.Label();
            this.TxtBoxImageUrl = new System.Windows.Forms.TextBox();
            this.LblTitleForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(136, 119);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(68, 29);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(60, 119);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(72, 29);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblImageUrl
            // 
            this.LblImageUrl.AutoSize = true;
            this.LblImageUrl.Location = new System.Drawing.Point(20, 78);
            this.LblImageUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblImageUrl.Name = "LblImageUrl";
            this.LblImageUrl.Size = new System.Drawing.Size(62, 13);
            this.LblImageUrl.TabIndex = 4;
            this.LblImageUrl.Text = "Imagen (url)";
            // 
            // TxtBoxImageUrl
            // 
            this.TxtBoxImageUrl.Location = new System.Drawing.Point(82, 76);
            this.TxtBoxImageUrl.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBoxImageUrl.Name = "TxtBoxImageUrl";
            this.TxtBoxImageUrl.Size = new System.Drawing.Size(146, 20);
            this.TxtBoxImageUrl.TabIndex = 5;
            // 
            // LblTitleForm
            // 
            this.LblTitleForm.AutoSize = true;
            this.LblTitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleForm.Location = new System.Drawing.Point(19, 31);
            this.LblTitleForm.Name = "LblTitleForm";
            this.LblTitleForm.Size = new System.Drawing.Size(73, 24);
            this.LblTitleForm.TabIndex = 6;
            this.LblTitleForm.Text = "Imagen";
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 180);
            this.Controls.Add(this.LblTitleForm);
            this.Controls.Add(this.TxtBoxImageUrl);
            this.Controls.Add(this.LblImageUrl);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageForm";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblImageUrl;
        private System.Windows.Forms.TextBox TxtBoxImageUrl;
        private System.Windows.Forms.Label LblTitleForm;
    }
}