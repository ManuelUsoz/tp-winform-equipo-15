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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeUnArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblGreeting = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenArticlesForm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(1000, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeArticulosToolStripMenuItem,
            this.agregarArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem,
            this.buscarArticuloToolStripMenuItem,
            this.detalleDeUnArticuloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaDeArticulosToolStripMenuItem
            // 
            this.listaDeArticulosToolStripMenuItem.Name = "listaDeArticulosToolStripMenuItem";
            this.listaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.listaDeArticulosToolStripMenuItem.Text = "&Lista de articulos";
            this.listaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.listaDeArticulosToolStripMenuItem_Click);
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.agregarArticuloToolStripMenuItem.Text = "&Agregar articulo";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.modificarArticuloToolStripMenuItem.Text = "&Modificar articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.eliminarArticuloToolStripMenuItem.Text = "&Eliminar articulo";
            this.eliminarArticuloToolStripMenuItem.Click += new System.EventHandler(this.eliminarArticuloToolStripMenuItem_Click);
            // 
            // buscarArticuloToolStripMenuItem
            // 
            this.buscarArticuloToolStripMenuItem.Name = "buscarArticuloToolStripMenuItem";
            this.buscarArticuloToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.buscarArticuloToolStripMenuItem.Text = "&Buscar articulo por criterio";
            this.buscarArticuloToolStripMenuItem.Click += new System.EventHandler(this.buscarArticuloToolStripMenuItem_Click);
            // 
            // detalleDeUnArticuloToolStripMenuItem
            // 
            this.detalleDeUnArticuloToolStripMenuItem.Name = "detalleDeUnArticuloToolStripMenuItem";
            this.detalleDeUnArticuloToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.detalleDeUnArticuloToolStripMenuItem.Text = "&Detalle de un articulo";
            this.detalleDeUnArticuloToolStripMenuItem.Click += new System.EventHandler(this.detalleDeUnArticuloToolStripMenuItem_Click);
            // 
            // LblGreeting
            // 
            this.LblGreeting.AutoSize = true;
            this.LblGreeting.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblGreeting.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreeting.ForeColor = System.Drawing.Color.DimGray;
            this.LblGreeting.Location = new System.Drawing.Point(390, 81);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(353, 70);
            this.LblGreeting.TabIndex = 1;
            this.LblGreeting.Text = "Bienvenido";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.OpenArticlesForm);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 28);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(283, 505);
            this.SidePanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(26, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OpenArticlesForm
            // 
            this.OpenArticlesForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpenArticlesForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenArticlesForm.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenArticlesForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenArticlesForm.Location = new System.Drawing.Point(26, 105);
            this.OpenArticlesForm.Name = "OpenArticlesForm";
            this.OpenArticlesForm.Size = new System.Drawing.Size(226, 48);
            this.OpenArticlesForm.TabIndex = 4;
            this.OpenArticlesForm.Text = "ARTICULOS";
            this.OpenArticlesForm.UseVisualStyleBackColor = false;
            this.OpenArticlesForm.Click += new System.EventHandler(this.OpenArticlesForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 533);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.LblGreeting);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1176, 615);
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeUnArticuloToolStripMenuItem;
        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button OpenArticlesForm;
        private System.Windows.Forms.Button button1;
    }
}

