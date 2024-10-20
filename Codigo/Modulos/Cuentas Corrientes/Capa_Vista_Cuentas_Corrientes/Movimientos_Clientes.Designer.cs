
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class From1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creacionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creacionClientesToolStripMenuItem
            // 
            this.creacionClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.creacionClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.cobradoresToolStripMenuItem,
            this.movimientsoToolStripMenuItem,
            this.tiposDePagoToolStripMenuItem,
            this.paisToolStripMenuItem});
            this.creacionClientesToolStripMenuItem.Name = "creacionClientesToolStripMenuItem";
            this.creacionClientesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.creacionClientesToolStripMenuItem.Text = "Catalogos";
            this.creacionClientesToolStripMenuItem.Click += new System.EventHandler(this.creacionClientesToolStripMenuItem_Click);
            // 
            // nuevosToolStripMenuItem
            // 
            this.nuevosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nuevosToolStripMenuItem.Name = "nuevosToolStripMenuItem";
            this.nuevosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevosToolStripMenuItem.Text = "Clientes";
            this.nuevosToolStripMenuItem.Click += new System.EventHandler(this.nuevosToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // cobradoresToolStripMenuItem
            // 
            this.cobradoresToolStripMenuItem.Name = "cobradoresToolStripMenuItem";
            this.cobradoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobradoresToolStripMenuItem.Text = "Cobradores";
            // 
            // movimientsoToolStripMenuItem
            // 
            this.movimientsoToolStripMenuItem.Name = "movimientsoToolStripMenuItem";
            this.movimientsoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimientsoToolStripMenuItem.Text = "Movimientso";
            // 
            // tiposDePagoToolStripMenuItem
            // 
            this.tiposDePagoToolStripMenuItem.Name = "tiposDePagoToolStripMenuItem";
            this.tiposDePagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiposDePagoToolStripMenuItem.Text = "Tipos de Pago";
            this.tiposDePagoToolStripMenuItem.Click += new System.EventHandler(this.tiposDePagoToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paisToolStripMenuItem.Text = "Pais";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "From1";
            this.Text = "Movimientos Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creacionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
    }
}

