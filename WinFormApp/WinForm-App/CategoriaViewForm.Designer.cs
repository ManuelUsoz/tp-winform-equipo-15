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
            this.DgvCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvCategories.GridColor = System.Drawing.SystemColors.Highlight;
            this.DgvCategories.Location = new System.Drawing.Point(9, 63);
            this.DgvCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvCategories.MultiSelect = false;
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.RowHeadersWidth = 51;
            this.DgvCategories.RowTemplate.Height = 24;
            this.DgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategories.Size = new System.Drawing.Size(582, 293);
            this.DgvCategories.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitle.Location = new System.Drawing.Point(9, 22);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(117, 26);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Categorías";
            // 
            // BtnSeeDetail
            // 
            this.BtnSeeDetail.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_eye_30;
            this.BtnSeeDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSeeDetail.Location = new System.Drawing.Point(400, 25);
            this.BtnSeeDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSeeDetail.Name = "BtnSeeDetail";
            this.BtnSeeDetail.Size = new System.Drawing.Size(50, 32);
            this.BtnSeeDetail.TabIndex = 5;
            this.BtnSeeDetail.UseVisualStyleBackColor = true;
            this.BtnSeeDetail.Click += new System.EventHandler(this.BtnSeeDetail_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_minus_30;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.Location = new System.Drawing.Point(454, 25);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(43, 32);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_edit_30;
            this.BtnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModify.Location = new System.Drawing.Point(501, 25);
            this.BtnModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(43, 32);
            this.BtnModify.TabIndex = 3;
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = global::WinForm_App.Properties.Resources.icons8_add_30;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdd.Location = new System.Drawing.Point(548, 25);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(43, 32);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CategoriaViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.BtnSeeDetail);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.DgvCategories);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "CategoriaViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";
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