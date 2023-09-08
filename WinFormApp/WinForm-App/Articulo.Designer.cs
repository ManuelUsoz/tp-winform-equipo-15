namespace WinForm_App
{
    partial class Articulo
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeArticulosToolStripMenuItem,
            this.agregarArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem,
            this.buscarArticuloToolStripMenuItem,
            this.detalleDeUnArticuloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaDeArticulosToolStripMenuItem
            // 
            this.listaDeArticulosToolStripMenuItem.Name = "listaDeArticulosToolStripMenuItem";
            this.listaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.listaDeArticulosToolStripMenuItem.Text = "&Lista de articulos";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.agregarArticuloToolStripMenuItem.Text = "&Agregar articulo";
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.modificarArticuloToolStripMenuItem.Text = "&Modificar articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.eliminarArticuloToolStripMenuItem.Text = "&Eliminar articulo";
            // 
            // buscarArticuloToolStripMenuItem
            // 
            this.buscarArticuloToolStripMenuItem.Name = "buscarArticuloToolStripMenuItem";
            this.buscarArticuloToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.buscarArticuloToolStripMenuItem.Text = "&Buscar articulo por criterio";
            // 
            // detalleDeUnArticuloToolStripMenuItem
            // 
            this.detalleDeUnArticuloToolStripMenuItem.Name = "detalleDeUnArticuloToolStripMenuItem";
            this.detalleDeUnArticuloToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.detalleDeUnArticuloToolStripMenuItem.Text = "&Detalle de un articulo";
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

