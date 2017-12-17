namespace UI
{
    partial class frmRegTeamMember
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
            this.cmbSkier = new System.Windows.Forms.ComboBox();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTeamMember = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeamMemberFind = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMember)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSkier);
            this.groupBox1.Controls.Add(this.cmbTeam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(476, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(304, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Integrantes de Equipo:";
            // 
            // cmbSkier
            // 
            this.cmbSkier.FormattingEnabled = true;
            this.cmbSkier.Location = new System.Drawing.Point(69, 42);
            this.cmbSkier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSkier.Name = "cmbSkier";
            this.cmbSkier.Size = new System.Drawing.Size(222, 21);
            this.cmbSkier.TabIndex = 3;
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(69, 18);
            this.cmbTeam.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(222, 21);
            this.cmbTeam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Esquiador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipo:";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.guardarToolStripMenuItem.Text = "Nuevo";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actualizarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // dgvTeamMember
            // 
            this.dgvTeamMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamMember.Location = new System.Drawing.Point(9, 51);
            this.dgvTeamMember.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTeamMember.Name = "dgvTeamMember";
            this.dgvTeamMember.RowTemplate.Height = 24;
            this.dgvTeamMember.Size = new System.Drawing.Size(463, 265);
            this.dgvTeamMember.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(392, 28);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 19);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Buscar Esquiador:";
            // 
            // txtTeamMemberFind
            // 
            this.txtTeamMemberFind.Location = new System.Drawing.Point(110, 27);
            this.txtTeamMemberFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeamMemberFind.Name = "txtTeamMemberFind";
            this.txtTeamMemberFind.Size = new System.Drawing.Size(278, 20);
            this.txtTeamMemberFind.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmRegTeamMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTeamMemberFind);
            this.Controls.Add(this.dgvTeamMember);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegTeamMember";
            this.Text = "Registro de Integrantes de Equipo";
            this.Load += new System.EventHandler(this.frmRegTeamMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSkier;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTeamMember;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeamMemberFind;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}