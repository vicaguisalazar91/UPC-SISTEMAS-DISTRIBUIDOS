namespace UI
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.federacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquiadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeIntegrantesDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.federacionesToolStripMenuItem,
            this.esquiadoresToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.estacionesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // federacionesToolStripMenuItem
            // 
            this.federacionesToolStripMenuItem.Name = "federacionesToolStripMenuItem";
            this.federacionesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.federacionesToolStripMenuItem.Text = "Federaciones";
            // 
            // esquiadoresToolStripMenuItem
            // 
            this.esquiadoresToolStripMenuItem.Name = "esquiadoresToolStripMenuItem";
            this.esquiadoresToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.esquiadoresToolStripMenuItem.Text = "Esquiadores";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // estacionesToolStripMenuItem
            // 
            this.estacionesToolStripMenuItem.Name = "estacionesToolStripMenuItem";
            this.estacionesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.estacionesToolStripMenuItem.Text = "Estaciones";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeIntegrantesDeEquiposToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registroDeIntegrantesDeEquiposToolStripMenuItem
            // 
            this.registroDeIntegrantesDeEquiposToolStripMenuItem.Name = "registroDeIntegrantesDeEquiposToolStripMenuItem";
            this.registroDeIntegrantesDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.registroDeIntegrantesDeEquiposToolStripMenuItem.Text = "Registro de Integrantes de Equipo";
            this.registroDeIntegrantesDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.registroDeIntegrantesDeEquiposToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 420);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menú Gestión de Olimpiadas FIFO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem federacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquiadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeIntegrantesDeEquiposToolStripMenuItem;
    }
}