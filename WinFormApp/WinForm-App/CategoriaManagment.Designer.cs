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
            this.BtnAdd.Location = new System.Drawing.Point(177, 199);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(86, 35);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Guardar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(85, 199);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(86, 35);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LblDescripción
            // 
            this.LblDescripción.AutoSize = true;
            this.LblDescripción.Location = new System.Drawing.Point(36, 93);
            this.LblDescripción.Name = "LblDescripción";
            this.LblDescripción.Size = new System.Drawing.Size(79, 16);
            this.LblDescripción.TabIndex = 2;
            this.LblDescripción.Text = "Descripción";
            // 
            // TxtBoxDescription
            // 
            this.TxtBoxDescription.Location = new System.Drawing.Point(121, 90);
            this.TxtBoxDescription.Name = "TxtBoxDescription";
            this.TxtBoxDescription.Size = new System.Drawing.Size(142, 22);
            this.TxtBoxDescription.TabIndex = 3;
            // 
            // CategoriaManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 246);
            this.Controls.Add(this.TxtBoxDescription);
            this.Controls.Add(this.LblDescripción);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.MaximumSize = new System.Drawing.Size(366, 293);
            this.MinimumSize = new System.Drawing.Size(366, 293);
            this.Name = "CategoriaManagment";
            this.Text = "CategoriaManagment";
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