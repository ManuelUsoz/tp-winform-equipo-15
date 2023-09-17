namespace WinForm_App
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblGreeting = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnCategoriasMenu = new System.Windows.Forms.Button();
            this.BtnMarcasMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenArticlesForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGreeting
            // 
            this.LblGreeting.AutoSize = true;
            this.LblGreeting.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblGreeting.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreeting.ForeColor = System.Drawing.Color.DimGray;
            this.LblGreeting.Location = new System.Drawing.Point(429, 73);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(353, 70);
            this.LblGreeting.TabIndex = 1;
            this.LblGreeting.Text = "Bienvenido";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SidePanel.Controls.Add(this.BtnCategoriasMenu);
            this.SidePanel.Controls.Add(this.BtnMarcasMenu);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.OpenArticlesForm);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(283, 525);
            this.SidePanel.TabIndex = 3;
            // 
            // BtnCategoriasMenu
            // 
            this.BtnCategoriasMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCategoriasMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCategoriasMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCategoriasMenu.FlatAppearance.BorderSize = 0;
            this.BtnCategoriasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoriasMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategoriasMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCategoriasMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCategoriasMenu.Location = new System.Drawing.Point(26, 403);
            this.BtnCategoriasMenu.Name = "BtnCategoriasMenu";
            this.BtnCategoriasMenu.Size = new System.Drawing.Size(226, 48);
            this.BtnCategoriasMenu.TabIndex = 7;
            this.BtnCategoriasMenu.Text = "CATEGORIAS";
            this.BtnCategoriasMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategoriasMenu.UseVisualStyleBackColor = false;
            this.BtnCategoriasMenu.Click += new System.EventHandler(this.BtnCategoriasMenu_Click);
            // 
            // BtnMarcasMenu
            // 
            this.BtnMarcasMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnMarcasMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMarcasMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMarcasMenu.FlatAppearance.BorderSize = 0;
            this.BtnMarcasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarcasMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcasMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMarcasMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMarcasMenu.Location = new System.Drawing.Point(26, 328);
            this.BtnMarcasMenu.Name = "BtnMarcasMenu";
            this.BtnMarcasMenu.Size = new System.Drawing.Size(226, 48);
            this.BtnMarcasMenu.TabIndex = 6;
            this.BtnMarcasMenu.Text = "MARCAS";
            this.BtnMarcasMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMarcasMenu.UseVisualStyleBackColor = false;
            this.BtnMarcasMenu.Click += new System.EventHandler(this.BtnMarcasMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WinForm_App.Properties.Resources.staff_96px;
            this.pictureBox1.InitialImage = global::WinForm_App.Properties.Resources.staff_96px;
            this.pictureBox1.Location = new System.Drawing.Point(26, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(26, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "BUSCAR ARTICULOS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenArticlesForm
            // 
            this.OpenArticlesForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpenArticlesForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenArticlesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenArticlesForm.FlatAppearance.BorderSize = 0;
            this.OpenArticlesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenArticlesForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenArticlesForm.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenArticlesForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenArticlesForm.Location = new System.Drawing.Point(26, 182);
            this.OpenArticlesForm.Name = "OpenArticlesForm";
            this.OpenArticlesForm.Size = new System.Drawing.Size(226, 48);
            this.OpenArticlesForm.TabIndex = 4;
            this.OpenArticlesForm.Text = "ARTICULOS";
            this.OpenArticlesForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenArticlesForm.UseVisualStyleBackColor = false;
            this.OpenArticlesForm.Click += new System.EventHandler(this.OpenArticlesForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 42);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(830, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.LblGreeting);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(848, 572);
            this.MinimumSize = new System.Drawing.Size(848, 572);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button OpenArticlesForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCategoriasMenu;
        private System.Windows.Forms.Button BtnMarcasMenu;
    }
}

