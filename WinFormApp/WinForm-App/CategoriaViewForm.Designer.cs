namespace WinForm_App
{
    partial class CategoriaViewForm
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
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnSeeDetail = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategories
            // 
            this.DgvCategories.AllowUserToAddRows = false;
            this.DgvCategories.AllowUserToDeleteRows = false;
            this.DgvCategories.AllowUserToResizeColumns = false;
            this.DgvCategories.AllowUserToResizeRows = false;
            this.DgvCategories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.GridColor = System.Drawing.SystemColors.Highlight;
            this.DgvCategories.Location = new System.Drawing.Point(12, 77);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.RowHeadersWidth = 51;
            this.DgvCategories.RowTemplate.Height = 24;
            this.DgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategories.Size = new System.Drawing.Size(776, 361);
            this.DgvCategories.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitle.Location = new System.Drawing.Point(12, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(152, 32);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Categorías";
            // 
            // BtnSeeDetail
            // 
            this.BtnSeeDetail.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_eye_30;
            this.BtnSeeDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSeeDetail.Location = new System.Drawing.Point(533, 31);
            this.BtnSeeDetail.Name = "BtnSeeDetail";
            this.BtnSeeDetail.Size = new System.Drawing.Size(66, 40);
            this.BtnSeeDetail.TabIndex = 5;
            this.BtnSeeDetail.UseVisualStyleBackColor = true;
            this.BtnSeeDetail.Click += new System.EventHandler(this.BtnSeeDetail_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_minus_30;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.Location = new System.Drawing.Point(605, 31);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(57, 40);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnModify
            // 
            this.BtnModify.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_edit_30;
            this.BtnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModify.Location = new System.Drawing.Point(668, 31);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(57, 40);
            this.BtnModify.TabIndex = 3;
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_add_30;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdd.Location = new System.Drawing.Point(731, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(57, 40);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CategoriaViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeeDetail);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.DgvCategories);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "CategoriaViewForm";
            this.Text = "CategoriaViewForm";
            this.Load += new System.EventHandler(this.CategoriaViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSeeDetail;
    }
}