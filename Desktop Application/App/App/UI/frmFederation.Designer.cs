namespace UI
{
    partial class frmFederation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFedeName = new System.Windows.Forms.TextBox();
            this.txtFedeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFederation = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FederationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FederatedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFederation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFedeName);
            this.groupBox1.Controls.Add(this.txtFedeId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(505, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Federación:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFedeName
            // 
            this.txtFedeName.Enabled = false;
            this.txtFedeName.Location = new System.Drawing.Point(115, 58);
            this.txtFedeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFedeName.Name = "txtFedeName";
            this.txtFedeName.Size = new System.Drawing.Size(297, 22);
            this.txtFedeName.TabIndex = 3;
            // 
            // txtFedeId
            // 
            this.txtFedeId.Enabled = false;
            this.txtFedeId.Location = new System.Drawing.Point(115, 26);
            this.txtFedeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFedeId.Name = "txtFedeId";
            this.txtFedeId.Size = new System.Drawing.Size(57, 22);
            this.txtFedeId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Federación:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1032, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.guardarToolStripMenuItem.Text = "Nuevo";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.actualizarToolStripMenuItem.Text = "Modificar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // dgvFederation
            // 
            this.dgvFederation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFederation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FederationName,
            this.FederatedNumber});
            this.dgvFederation.Location = new System.Drawing.Point(17, 91);
            this.dgvFederation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFederation.Name = "dgvFederation";
            this.dgvFederation.RowTemplate.Height = 24;
            this.dgvFederation.Size = new System.Drawing.Size(483, 234);
            this.dgvFederation.TabIndex = 2;
            this.dgvFederation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFederation_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "FederationID";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // FederationName
            // 
            this.FederationName.DataPropertyName = "FederationName";
            this.FederationName.HeaderText = "Name";
            this.FederationName.Name = "FederationName";
            // 
            // FederatedNumber
            // 
            this.FederatedNumber.DataPropertyName = "FederatedNumber";
            this.FederatedNumber.HeaderText = "Number";
            this.FederatedNumber.Name = "FederatedNumber";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(861, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 47);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar:";
            // 
            // frmFederation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFederation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFederation";
            this.Text = "Mantenimiento de Federaciones";
            this.Load += new System.EventHandler(this.frmFederation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFederation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFedeName;
        private System.Windows.Forms.TextBox txtFedeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFederation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FederationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FederatedNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}