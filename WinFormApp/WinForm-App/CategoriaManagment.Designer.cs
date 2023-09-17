namespace WinForm_App
{
    partial class CategoriaManagment
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblDescripción = new System.Windows.Forms.Label();
            this.TxtBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(133, 162);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(64, 28);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Guardar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(64, 162);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(64, 28);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblDescripción
            // 
            this.LblDescripción.AutoSize = true;
            this.LblDescripción.Location = new System.Drawing.Point(27, 76);
            this.LblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripción.Name = "LblDescripción";
            this.LblDescripción.Size = new System.Drawing.Size(63, 13);
            this.LblDescripción.TabIndex = 2;
            this.LblDescripción.Text = "Descripción";
            // 
            // TxtBoxDescription
            // 
            this.TxtBoxDescription.Location = new System.Drawing.Point(91, 73);
            this.TxtBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBoxDescription.Name = "TxtBoxDescription";
            this.TxtBoxDescription.Size = new System.Drawing.Size(108, 20);
            this.TxtBoxDescription.TabIndex = 3;
            // 
            // CategoriaManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 206);
            this.Controls.Add(this.TxtBoxDescription);
            this.Controls.Add(this.LblDescripción);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(278, 245);
            this.MinimumSize = new System.Drawing.Size(278, 245);
            this.Name = "CategoriaManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificiar categoría";
            this.Load += new System.EventHandler(this.CategoriaManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblDescripción;
        private System.Windows.Forms.TextBox TxtBoxDescription;
    }
}